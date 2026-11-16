using Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Datos.Repositorios
{
    public class EstablecimientoRepo : Negocio.Interfaces.IEstablecimientos
    {
        private readonly AccesoDatosBD accesoDatos = new AccesoDatosBD();

        // Multi-tenant: solo devuelve los registros de la provincia indicada
        public List<Establecimiento> ObtenerPorProvincia(int idProvincia)
        {
            string consulta = @"
                SELECT IdEstablecimiento, Nombre, Direccion, Telefono, IdProvincia, IdTipo
                FROM Establecimientos
                WHERE IdProvincia = @idProvincia";

            DataTable resultado = accesoDatos.EjecutarConsulta(
                consulta,
                new SqlParameter("@idProvincia", idProvincia)
            );

            return ConvertirLista(resultado);
        }

        // Solo para el administrador nacional
        public List<Establecimiento> ObtenerTodos()
        {
            string consulta = @"
                SELECT IdEstablecimiento, Nombre, Direccion, Telefono, IdProvincia, IdTipo
                FROM Establecimientos";

            DataTable resultado = accesoDatos.EjecutarConsulta(consulta);

            return ConvertirLista(resultado);
        }

        public bool Registrar(Establecimiento establecimiento)
        {
            string consulta = @"
                INSERT INTO Establecimientos
                (Nombre, Direccion, Telefono, IdProvincia, IdTipo)
                VALUES
                (@nombre, @direccion, @telefono, @provincia, @tipo)";

            return accesoDatos.EjecutarComando(
                consulta,
                new SqlParameter("@nombre", establecimiento.NombreEstablecimiento),
                new SqlParameter("@direccion", establecimiento.DireccionEstablecimiento),
                new SqlParameter("@telefono", establecimiento.TelefonoEstablecimiento),
                new SqlParameter("@provincia", establecimiento.IdProvincia),
                new SqlParameter("@tipo", establecimiento.IdTipo)
            );
        }

        public bool Actualizar(Establecimiento establecimiento)
        {
            // El filtro por IdProvincia impide modificar registros de otras provincias
            string consulta = @"
                UPDATE Establecimientos
                SET Nombre = @nombre,
                    Direccion = @direccion,
                    Telefono = @telefono,
                    IdTipo = @tipo
                WHERE IdEstablecimiento = @id
                AND IdProvincia = @provincia";

            return accesoDatos.EjecutarComando(
                consulta,
                new SqlParameter("@nombre", establecimiento.NombreEstablecimiento),
                new SqlParameter("@direccion", establecimiento.DireccionEstablecimiento),
                new SqlParameter("@telefono", establecimiento.TelefonoEstablecimiento),
                new SqlParameter("@tipo", establecimiento.IdTipo),
                new SqlParameter("@id", establecimiento.IdEstablecimiento),
                new SqlParameter("@provincia", establecimiento.IdProvincia)
            );
        }

        public bool Eliminar(int idEstablecimiento, int idProvincia)
        {
            // El filtro por IdProvincia impide eliminar registros de otras provincias
            string consulta = @"
                DELETE FROM Establecimientos
                WHERE IdEstablecimiento = @id
                AND IdProvincia = @provincia";

            return accesoDatos.EjecutarComando(
                consulta,
                new SqlParameter("@id", idEstablecimiento),
                new SqlParameter("@provincia", idProvincia)
            );
        }

        public List<Tipo> ObtenerTipos()
        {
            string consulta = @"
                SELECT IdTipo, Nombre, descripcion
                FROM TipoEstablecimiento
                ORDER BY Nombre";

            DataTable resultado = accesoDatos.EjecutarConsulta(consulta);
            List<Tipo> lista = new List<Tipo>();

            foreach (DataRow fila in resultado.Rows)
            {
                lista.Add(new Tipo
                {
                    IdTipo = Convert.ToInt32(fila["IdTipo"]),
                    NombreTipo = fila["Nombre"].ToString() ?? "",
                    DescripcionTipo = fila["descripcion"].ToString() ?? ""
                });
            }

            return lista;
        }

        public List<Provincia> ObtenerProvincias()
        {
            string consulta = @"
                SELECT IdProvincia, NombreProvincia
                FROM Provincias
                ORDER BY NombreProvincia";

            DataTable resultado = accesoDatos.EjecutarConsulta(consulta);
            List<Provincia> lista = new List<Provincia>();

            foreach (DataRow fila in resultado.Rows)
            {
                lista.Add(new Provincia
                {
                    IdProvincia = Convert.ToInt32(fila["IdProvincia"]),
                    NombreProvincia = fila["NombreProvincia"].ToString() ?? ""
                });
            }

            return lista;
        }

        private List<Establecimiento> ConvertirLista(DataTable tabla)
        {
            List<Establecimiento> lista = new List<Establecimiento>();

            foreach (DataRow fila in tabla.Rows)
            {
                lista.Add(new Establecimiento
                {
                    IdEstablecimiento = Convert.ToInt32(fila["IdEstablecimiento"]),
                    NombreEstablecimiento = fila["Nombre"].ToString() ?? "",
                    DireccionEstablecimiento = fila["Direccion"].ToString() ?? "",
                    TelefonoEstablecimiento = fila["Telefono"].ToString() ?? "",
                    IdProvincia = Convert.ToInt32(fila["IdProvincia"]),
                    IdTipo = Convert.ToInt32(fila["IdTipo"])
                });
            }

            return lista;
        }
    }
}
