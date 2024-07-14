using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{
    public interface ICRD_EstadoTipoProcesosRepositorio : IBaseRepositorio<CRD_EstadoTipoProcesos>
    {
        CRD_EstadoTipoProcesos buscarPorNombre(string nom);
        List<CRD_EstadoTipoProcesos> ObtenerElementosActivos();
    }
}