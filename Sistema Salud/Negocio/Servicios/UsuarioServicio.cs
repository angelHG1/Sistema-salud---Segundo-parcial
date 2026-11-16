using Entidades;
using Negocio.Interfaces;
using System;
using System.Collections.Generic;

namespace Negocio.Servicios
{
    public class UsuarioServicio
    {
        private readonly IUsuario Iusuario;

        public UsuarioServicio(IUsuario Iusuario)
        {
            this.Iusuario = Iusuario;
        }

        public Usuarios IniciarSesion(string usuario, string contraseña)
        {
            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(contraseña))
            {
                throw new Exception("Debes completar todos los campos.");
            }

            Usuarios? usuarioEncontrado = Iusuario.IniciarSesion(usuario, contraseña);

            if (usuarioEncontrado == null)
            {
                throw new Exception("Usuario o contraseña incorrectos.");
            }

            return usuarioEncontrado;
        }

        // Multi-tenant: un administrador provincial solo puede consultar
        // usuarios de su propia provincia.
        public Usuarios? ObtenerPorId(int idUsuario, Usuarios? usuarioActual)
        {
            if (usuarioActual == null)
                throw new Exception("No hay una sesión activa.");

            Usuarios? encontrado = Iusuario.ObtenerPorId(idUsuario);

            if (encontrado == null)
                return null;

            if (usuarioActual.Rol == "AdministradorNacional")
                return encontrado;

            if (usuarioActual.Rol == "AdministradorProvincial" &&
                usuarioActual.IdProvincia.HasValue &&
                encontrado.IdProvincia == usuarioActual.IdProvincia)
            {
                return encontrado;
            }

            throw new Exception("No tienes permisos para consultar este usuario.");
        }

        public List<Usuarios> ObtenerUsuarios(Usuarios? usuarioActual)
        {
            if (usuarioActual == null)
                throw new Exception("No hay una sesión activa.");

            if (usuarioActual.Rol == "AdministradorNacional")
                return Iusuario.ObtenerTodos();

            if (usuarioActual.Rol == "AdministradorProvincial" && usuarioActual.IdProvincia.HasValue)
                return Iusuario.ObtenerPorProvincia(usuarioActual.IdProvincia.Value);

            throw new Exception("No tienes permisos para consultar usuarios.");
        }
    }
}
