using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos.Repositorios;
using Entidades;
using Negocio.Servicios;

namespace Presentación
{
    public partial class FormEstablecimiento : Form
    {
        private readonly EstablecimientoServicio servicio = new EstablecimientoServicio(new EstablecimientoRepo());

        public FormEstablecimiento()
        {
            InitializeComponent();
            this.Load += FormEstablecimiento_Load;
            this.BotonRegistrar.Click += BotonRegistrar_Click;
            this.BotonActualizar.Click += BotonActualizar_Click;
            this.BotonEliminar.Click += BotonEliminar_Click;
            this.BotonLimpiar.Click += BotonLimpiar_Click;
            this.BotonVolver.Click += (s, e) => this.Close();
            this.dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void FormEstablecimiento_Load(object? sender, EventArgs e)
        {
            CargarCatalogos();
            ConfigurarPermisos();
            CargarDatos();
        }

        private void CargarCatalogos()
        {
            try
            {
                var tipos = servicio.ObtenerTipos();
                comboBoxTipo.DataSource = tipos;
                comboBoxTipo.DisplayMember = "NombreTipo";
                comboBoxTipo.ValueMember = "IdTipo";
                comboBoxTipo.SelectedIndex = tipos.Count > 0 ? 0 : -1;

                var provincias = servicio.ObtenerProvincias();
                comboBoxProvincia.DataSource = provincias;
                comboBoxProvincia.DisplayMember = "NombreProvincia";
                comboBoxProvincia.ValueMember = "IdProvincia";
                comboBoxProvincia.SelectedIndex = provincias.Count > 0 ? 0 : -1;

                if (SesionUsuario.Actual != null && SesionUsuario.Actual.Rol == "AdministradorProvincial" && SesionUsuario.Actual.IdProvincia.HasValue)
                {
                    comboBoxProvincia.SelectedValue = SesionUsuario.Actual.IdProvincia.Value;
                    comboBoxProvincia.Enabled = false;
                }
                else if (SesionUsuario.Actual != null && SesionUsuario.Actual.Rol != "AdministradorProvincial")
                {
                    comboBoxProvincia.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar los catálogos: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ConfigurarPermisos()
        {
            if (SesionUsuario.Actual == null || SesionUsuario.Actual.Rol != "AdministradorProvincial")
            {
                BotonRegistrar.Enabled = false;
                BotonActualizar.Enabled = false;
                BotonEliminar.Enabled = false;
                comboBoxTipo.Enabled = false;
                textBoxNombre.ReadOnly = true;
                textBoxDireccion.ReadOnly = true;
                textBoxTelefono.ReadOnly = true;
            }
        }

        private void CargarDatos()
        {
            try
            {
                var lista = servicio.ObtenerEstablecimientos(SesionUsuario.Actual);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Establecimiento ObtenerDesdeFormulario()
        {
            int id = 0;
            int.TryParse(textBoxId.Text, out id);

            int idTipo = 0;
            if (comboBoxTipo.SelectedValue != null)
                int.TryParse(comboBoxTipo.SelectedValue.ToString(), out idTipo);

            int idProvincia = 0;
            if (SesionUsuario.Actual != null && SesionUsuario.Actual.Rol == "AdministradorProvincial" && SesionUsuario.Actual.IdProvincia.HasValue)
                idProvincia = SesionUsuario.Actual.IdProvincia.Value;
            else if (comboBoxProvincia.SelectedValue != null)
                int.TryParse(comboBoxProvincia.SelectedValue.ToString(), out idProvincia);

            return new Establecimiento
            {
                IdEstablecimiento = id,
                NombreEstablecimiento = textBoxNombre.Text.Trim(),
                DireccionEstablecimiento = textBoxDireccion.Text.Trim(),
                TelefonoEstablecimiento = textBoxTelefono.Text.Trim(),
                IdTipo = idTipo,
                IdProvincia = idProvincia
            };
        }

        private void BotonRegistrar_Click(object? sender, EventArgs e)
        {
            try
            {
                var est = ObtenerDesdeFormulario();
                servicio.Registrar(est, SesionUsuario.Actual);
                MessageBox.Show("Establecimiento registrado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonActualizar_Click(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxId.Text))
                {
                    MessageBox.Show("Seleccione un establecimiento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var est = ObtenerDesdeFormulario();
                servicio.Actualizar(est, SesionUsuario.Actual);
                MessageBox.Show("Establecimiento actualizado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonEliminar_Click(object? sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxId.Text))
                {
                    MessageBox.Show("Seleccione un establecimiento.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show("¿Desea eliminar el establecimiento seleccionado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;

                int id = int.Parse(textBoxId.Text);
                servicio.Eliminar(id, SesionUsuario.Actual);
                MessageBox.Show("Establecimiento eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonLimpiar_Click(object? sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            textBoxId.Text = "";
            textBoxNombre.Text = "";
            textBoxDireccion.Text = "";
            textBoxTelefono.Text = "";
            if (comboBoxTipo.Items.Count > 0) comboBoxTipo.SelectedIndex = 0;
            if (SesionUsuario.Actual != null && SesionUsuario.Actual.Rol == "AdministradorProvincial" && SesionUsuario.Actual.IdProvincia.HasValue)
            {
                comboBoxProvincia.SelectedValue = SesionUsuario.Actual.IdProvincia.Value;
            }
            dataGridView1.ClearSelection();
        }

        private void DataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.CurrentRow != null)
            {
                var fila = dataGridView1.Rows[e.RowIndex];
                textBoxId.Text = fila.Cells["IdEstablecimiento"].Value?.ToString();
                textBoxNombre.Text = fila.Cells["NombreEstablecimiento"].Value?.ToString();
                textBoxDireccion.Text = fila.Cells["DireccionEstablecimiento"].Value?.ToString();
                textBoxTelefono.Text = fila.Cells["TelefonoEstablecimiento"].Value?.ToString();

                var idTipo = fila.Cells["IdTipo"].Value;
                if (idTipo != null) comboBoxTipo.SelectedValue = Convert.ToInt32(idTipo);

                var idProvincia = fila.Cells["IdProvincia"].Value;
                if (idProvincia != null && comboBoxProvincia.Enabled)
                    comboBoxProvincia.SelectedValue = Convert.ToInt32(idProvincia);
                else if (idProvincia != null && SesionUsuario.Actual?.Rol == "AdministradorProvincial")
                    comboBoxProvincia.SelectedValue = SesionUsuario.Actual.IdProvincia;
            }
        }
    }
}
