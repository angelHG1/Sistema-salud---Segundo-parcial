using Entidades;
using Negocio.Interfaces;


namespace Negocio.Servicios
{
    public class EstablecimientoServicio
    {
        private readonly IEstablecimientos establecimiento1;

        public EstablecimientoServicio(
            IEstablecimientos establecimientos1)
        {
            this.establecimiento1 = establecimientos1;
        }

        // Consultar establecimientos según el usuario
        public List<Establecimiento> ObtenerEstablecimientos(Usuarios? usuario)
        {
            if (usuario == null)
                throw new Exception("No hay una sesión activa.");

            if (usuario.Rol == "AdministradorNacional")
                return establecimiento1.ObtenerTodos();

            if (usuario.Rol == "AdministradorProvincial" &&
                usuario.IdProvincia.HasValue)
            {
                return establecimiento1.ObtenerPorProvincia(
                    usuario.IdProvincia.Value);
            }

            throw new Exception("No tienes permisos para esta operación.");
        }

        // Registrar establecimiento
        public bool Registrar(Establecimiento establecimiento, Usuarios? usuario)
        {
            ValidarAdministradorProvincial(usuario);

            establecimiento.IdProvincia = usuario!.IdProvincia!.Value;

            ValidarEstablecimiento(establecimiento);

            if (!establecimiento1.Registrar(establecimiento))
                throw new Exception("No se pudo registrar el establecimiento.");

            return true;
        }

        // Actualizar establecimiento
        public bool Actualizar(Establecimiento establecimiento, Usuarios? usuario)
        {
            ValidarAdministradorProvincial(usuario);

            establecimiento.IdProvincia = usuario!.IdProvincia!.Value;

            ValidarEstablecimiento(establecimiento);

            if (!establecimiento1.Actualizar(establecimiento))
                throw new Exception(
                    "No se encontró el establecimiento en tu provincia.");

            return true;
        }

        // Eliminar establecimiento
        public bool Eliminar(int idEstablecimiento, Usuarios? usuario)
        {
            ValidarAdministradorProvincial(usuario);

            if (!establecimiento1.Eliminar(
                    idEstablecimiento,
                    usuario!.IdProvincia!.Value))
            {
                throw new Exception(
                    "No se encontró el establecimiento en tu provincia.");
            }

            return true;
        }

        public List<Tipo> ObtenerTipos()
        {
            return establecimiento1.ObtenerTipos();
        }

        public List<Provincia> ObtenerProvincias()
        {
            return establecimiento1.ObtenerProvincias();
        }

        private void ValidarAdministradorProvincial(Usuarios? usuario)
        {
            if (usuario == null ||
                usuario.Rol != "AdministradorProvincial" ||
                !usuario.IdProvincia.HasValue)
            {
                throw new Exception(
                    "No tienes permisos para realizar esta operación.");
            }
        }

        private void ValidarEstablecimiento(Establecimiento establecimiento)
        {
            if (establecimiento == null)
                throw new Exception("El establecimiento es obligatorio.");

            if (string.IsNullOrWhiteSpace(establecimiento.NombreEstablecimiento))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(establecimiento.DireccionEstablecimiento))
                throw new Exception("La dirección es obligatoria.");

            if (string.IsNullOrWhiteSpace(establecimiento.TelefonoEstablecimiento))
                throw new Exception("El teléfono es obligatorio.");

            if (establecimiento.IdTipo <= 0)
                throw new Exception("Debes seleccionar un tipo de establecimiento.");
        }
    }
}

