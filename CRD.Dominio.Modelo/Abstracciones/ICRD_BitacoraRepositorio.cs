using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{
    public interface ICRD_BitacoraRepositorio : IBaseRepositorio<CRD_Bitacora>
    {
        List<CRD_Bitacora> buscarPorFactura(string Factura);
    }

}
