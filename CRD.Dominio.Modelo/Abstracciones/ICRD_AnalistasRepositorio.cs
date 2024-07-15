using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{

    public interface ICRD_AnalistasRepositorio : IBaseRepositorio<CRD_Analistas>
    {
        CRD_Analistas buscarPorIdAnalista(int IdAnalista);
        string buscarPorIdProceso(int IdProceso);
        List<CRD_Analistas> ObtenerListaPorNombre(string nombre);
    }
}
