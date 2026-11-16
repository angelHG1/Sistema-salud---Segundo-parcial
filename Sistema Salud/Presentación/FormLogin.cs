using System;
using System.Windows.Forms;
using Datos.Repositorios;
using Negocio.Servicios;

namespace Presentación
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.BotonIngresar.Click += BotonIngresar_Click;
            this.AcceptButton = BotonIngresar;
        }

        private void BotonIngresar_Click(object? sender, EventArgs e)
        {
            try
            {
                string usuario = textUsuario.Text.Trim();
                string contraseña = textContraseña.Text.Trim();

                UsuarioServicio servicio = new UsuarioServicio(new UsuarioRepo());
                var usuarioEncontrado = servicio.IniciarSesion(usuario, contraseña);

                SesionUsuario.Iniciar(usuarioEncontrado);

                FormMenu menu = new FormMenu();
                menu.FormClosed += (s, args) =>
                {
                    if (SesionUsuario.Actual == null)
                    {
                        // El usuario cerró sesión: volver a mostrar el login
                        textUsuario.Clear();
                        textContraseña.Clear();
                        this.Show();
                        textUsuario.Focus();
                    }
                    else
                    {
                        // Cerró la ventana del menú: terminar la aplicación
                        this.Close();
                    }
                };
                menu.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
