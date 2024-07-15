using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{
    public interface ICRD_EmpresasRepositorio : IBaseRepositorio<CRD_Empresas>
    {
        CRD_Empresas buscarPorCodigoEmpresa(string codemp);
        CRD_Empresas buscarPorNombre(string nom);
        List<CRD_Empresas> ObtenerElementosActivos();
        bool EliminadoLogico(int id);

    }
}