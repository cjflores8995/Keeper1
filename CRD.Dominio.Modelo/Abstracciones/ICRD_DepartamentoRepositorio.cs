using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{
    public interface ICRD_DepartamentoRepositorio : IBaseRepositorio<CRD_Departamento>
    {
        CRD_Departamento ObtenerElementoPorNombre(string nombre);
        List<CRD_Departamento> ObtenerElementosActivos();
    }
}