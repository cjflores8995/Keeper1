using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{
    public interface ICRD_CiudadRepositorio : IBaseRepositorio<CRD_Ciudad>
    {
        CRD_Ciudad ObtenerElementoPorNombre(string nombre);
        List<CRD_Ciudad> ObtenerElementosActivos();

        bool EliminadoLogico(int id);

        List<CRD_Ciudad> ObtenerListaPorNombre(string nombre);
    }
}