using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentación
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            this.Load += FormMenu_Load;
            this.BotonEstablecimientos.Click += BotonEstablecimientos_Click;
            this.BotonUsuarios.Click += BotonUsuarios_Click;
            this.BotonCerrarSesion.Click += BotonCerrarSesion_Click;
        }

        private void FormMenu_Load(object? sender, EventArgs e)
        {
            if (SesionUsuario.Actual != null)
            {
                labelUsuario.Text = $"Usuario: {SesionUsuario.Actual.NombreUsuario} - Rol: {SesionUsuario.Actual.Rol}";
            }
        }

        private void BotonEstablecimientos_Click(object? sender, EventArgs e)
        {
            FormEstablecimiento form = new FormEstablecimiento();
            form.ShowDialog();
        }

        private void BotonUsuarios_Click(object? sender, EventArgs e)
        {
            FormUsuarios form = new FormUsuarios();
            form.ShowDialog();
        }

        private void BotonCerrarSesion_Click(object? sender, EventArgs e)
        {
            SesionUsuario.Cerrar();
            this.Close();
        }
    }
}
