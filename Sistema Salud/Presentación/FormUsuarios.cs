using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Datos.Repositorios;
using Negocio.Servicios;

namespace Presentación
{
    public partial class FormUsuarios : Form
    {
        private readonly UsuarioServicio servicio = new UsuarioServicio(new UsuarioRepo());

        public FormUsuarios()
        {
            InitializeComponent();
            this.Load += FormUsuarios_Load;
            this.BotonActualizarLista.Click += (s, e) => CargarDatos();
            this.BotonVolver.Click += (s, e) => this.Close();
            this.dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void FormUsuarios_Load(object? sender, EventArgs e)
        {
            CargarDatos();
            MostrarUsuarioActual();
        }

        private void CargarDatos()
        {
            try
            {
                var lista = servicio.ObtenerUsuarios(SesionUsuario.Actual);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;
                if (dataGridView1.Columns["Contraseña"] != null)
                {
                    dataGridView1.Columns["Contraseña"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarUsuarioActual()
        {
            if (SesionUsuario.Actual != null)
            {
                textBoxId.Text = SesionUsuario.Actual.IdUsuario.ToString();
                textBoxNombre.Text = SesionUsuario.Actual.NombreUsuario;
                textBoxUsuario.Text = SesionUsuario.Actual.Usuario;
                textBoxRol.Text = SesionUsuario.Actual.Rol;
                textBoxIdProvincia.Text = SesionUsuario.Actual.IdProvincia?.ToString() ?? "";
            }
        }

        private void DataGridView1_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView1.CurrentRow != null)
            {
                var fila = dataGridView1.Rows[e.RowIndex];
                textBoxId.Text = fila.Cells["IdUsuario"].Value?.ToString();
                textBoxNombre.Text = fila.Cells["NombreUsuario"].Value?.ToString();
                textBoxUsuario.Text = fila.Cells["Usuario"].Value?.ToString();
                textBoxRol.Text = fila.Cells["Rol"].Value?.ToString();
                textBoxIdProvincia.Text = fila.Cells["IdProvincia"].Value?.ToString();
            }
        }
    }
}
