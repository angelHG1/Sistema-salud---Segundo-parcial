using Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Datos.Repositorios
{
    public class UsuarioRepo : Negocio.Interfaces.IUsuario
    {
        private const string ColumnasUsuario =
            "IdUsuario, Nombre, usuario, contraseña, Rol, IdProvincia";

        private readonly AccesoDatosBD accesoDatos = new AccesoDatosBD();

        public Usuarios? IniciarSesion(string usuario, string contraseña)
        {
            string consulta = $@"
                SELECT {ColumnasUsuario}
                FROM Usuarios
                WHERE usuario = @usuario
                AND contraseña = @clave";

            DataTable resultado = accesoDatos.EjecutarConsulta(
                consulta,
                new SqlParameter("@usuario", usuario),
                new SqlParameter("@clave", contraseña)
            );

            if (resultado.Rows.Count == 0)
                return null;

            return ConvertirUsuario(resultado.Rows[0]);
        }

        public Usuarios? ObtenerPorId(int idUsuario)
        {
            string consulta = $@"
                SELECT {ColumnasUsuario}
                FROM Usuarios
                WHERE IdUsuario = @id";

            DataTable resultado = accesoDatos.EjecutarConsulta(
                consulta,
                new SqlParameter("@id", idUsuario)
            );

            if (resultado.Rows.Count == 0)
                return null;

            return ConvertirUsuario(resultado.Rows[0]);
        }

        public List<Usuarios> ObtenerTodos()
        {
            string consulta = $@"
                SELECT {ColumnasUsuario}
                FROM Usuarios";

            DataTable resultado = accesoDatos.EjecutarConsulta(consulta);
            return ConvertirLista(resultado);
        }

        public List<Usuarios> ObtenerPorProvincia(int idProvincia)
        {
            string consulta = $@"
                SELECT {ColumnasUsuario}
                FROM Usuarios
                WHERE IdProvincia = @idProvincia";

            DataTable resultado = accesoDatos.EjecutarConsulta(
                consulta,
                new SqlParameter("@idProvincia", idProvincia)
            );

            return ConvertirLista(resultado);
        }

        private List<Usuarios> ConvertirLista(DataTable tabla)
        {
            List<Usuarios> lista = new List<Usuarios>();

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(ConvertirUsuario(fila));
            }

            return lista;
        }

        private Usuarios ConvertirUsuario(DataRow fila)
        {
            return new Usuarios
            {
                IdUsuario = Convert.ToInt32(fila["IdUsuario"]),
                NombreUsuario = fila["Nombre"].ToString() ?? "",
                Usuario = fila["usuario"].ToString() ?? "",
                Contraseña = fila["contraseña"].ToString() ?? "",
                Rol = fila["Rol"].ToString() ?? "",
                IdProvincia = fila["IdProvincia"] == DBNull.Value
                    ? null
                    : Convert.ToInt32(fila["IdProvincia"])
            };
        }
    }
}
