using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{
    public interface ICRD_ValijasRepositorio : IBaseRepositorio<CRD_Valijas>
    {
        CRD_Valijas buscarPorOrigen(string ori);
        CRD_Valijas buscarPorRemitente(string rem);
        List<CRD_Valijas> ObtenerElementosActivos();
    }
}