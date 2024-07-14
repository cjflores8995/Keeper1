using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{

    public interface ICRD_CargoRepositorio : IBaseRepositorio<CRD_Cargo>
    {
        CRD_Cargo ObtenerElementoPorNombre(string nombre);
        List<CRD_Cargo> ObtenerElementosActivos();

        bool EliminadoLogico(int id);
        List<CRD_Cargo> ObtenerListaPorNombre(string nombre);
    }
}
