using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{

    public interface ICRD_CajasRepositorio : IBaseRepositorio<CRD_Cajas>
    {
        CRD_Cajas ObtenerElementoPorNombre(string nombre);
        List<CRD_Cajas> ObtenerElementosActivos();

        bool EliminadoLogico(int id);

        List<CRD_Cajas> ObtenerListaPorNombre(string nombre);
    }
}
