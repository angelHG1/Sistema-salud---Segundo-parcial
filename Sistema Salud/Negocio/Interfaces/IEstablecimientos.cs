using Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Negocio.Interfaces
{
    public interface IEstablecimientos
    {
        List<Establecimiento> ObtenerPorProvincia(int idProvincia);
        List<Establecimiento> ObtenerTodos();
        bool Registrar(Establecimiento establecimiento);
        bool Actualizar(Establecimiento establecimiento);
        bool Eliminar(int idEstablecimiento, int idProvincia);
        List<Tipo> ObtenerTipos();
        List<Provincia> ObtenerProvincias();
    }
}
