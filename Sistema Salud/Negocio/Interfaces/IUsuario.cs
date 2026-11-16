using Entidades;
using System.Collections.Generic;

namespace Negocio.Interfaces
{
    public interface IUsuario
    {
        Usuarios? IniciarSesion(string usuario, string contraseña);

        Usuarios? ObtenerPorId(int idUsuario);

        List<Usuarios> ObtenerTodos();

        List<Usuarios> ObtenerPorProvincia(int idProvincia);
    }
}
