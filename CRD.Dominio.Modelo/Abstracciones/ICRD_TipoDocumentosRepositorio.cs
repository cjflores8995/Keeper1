using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{
    public interface ICRD_TipoDocumentosRepositorio : IBaseRepositorio<CRD_TipoDocumentos>
    {
        CRD_TipoDocumentos ObtenerTipoDocumentoPorNombre(string nombreTipoDocumento);
        List<CRD_TipoDocumentos> ObtenerElementosActivos();
        bool EliminadoLogico(int id);
    }
}