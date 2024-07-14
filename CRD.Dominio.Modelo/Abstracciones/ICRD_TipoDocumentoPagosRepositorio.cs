using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{
    public interface ICRD_TipoDocumentoPagosRepositorio : IBaseRepositorio<CRD_TipoDocumentoPagos>
    {
        List<CRD_TipoDocumentoPagos> ObtenerTipoDocumentoPagosPorNombre(string nombreTipoDocumentoPagos);
        List<CRD_TipoDocumentoPagos> ObtenerElementosActivos();
        bool EliminadoLogico(int id);
    }
}