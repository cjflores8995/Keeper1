using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{
    public interface ICRD_OrdenesRepositorio : IBaseRepositorio<CRD_Ordenes>
    {
        List<CRD_Ordenes> ObtenerOrdenesPorNumeroOrden(string numeroOrden);
    }
}