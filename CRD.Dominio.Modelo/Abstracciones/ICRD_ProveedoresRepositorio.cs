using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{
    public interface ICRD_ProveedoresRepositorio : IBaseRepositorio<CRD_Proveedores>
    {
        List<CRD_Proveedores> ObtenerProveedoresPorRUC(string rucCedula);
        List<CRD_Proveedores> ObtenerProveedoresPorCodProveedor(string codProveerdor);
        List<CRD_Proveedores> ObtenerProveedoresPorRazonSocial(string razonSocial);
    }
}