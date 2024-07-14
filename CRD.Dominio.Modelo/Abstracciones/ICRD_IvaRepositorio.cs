using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{
    public interface ICRD_IvaRepositorio : IBaseRepositorio<CRD_Iva>
    {
        List<CRD_Iva> ObtenerElementosActivos();
        bool EliminadoLogico(int id);

        bool EstablecerIvaPrincipal(int id);
    }
}