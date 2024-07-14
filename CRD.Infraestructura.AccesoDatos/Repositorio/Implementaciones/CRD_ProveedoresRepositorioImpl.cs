using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_ProveedoresRepositorioImpl : BaseRepositorioImpl<CRD_Proveedores>, ICRD_ProveedoresRepositorio
    {
        public List<CRD_Proveedores> ObtenerProveedoresPorCodProveedor(string codProveerdor)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    return db.CRD_Proveedores.Where(x => x.CodProveedor.Contains(codProveerdor)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar la lista", ex);
            }
        }

        public List<CRD_Proveedores> ObtenerProveedoresPorRazonSocial(string razonSocial)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    return db.CRD_Proveedores.Where(x => x.RazonSocial.Contains(razonSocial)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar la lista", ex);
            }

        }

        public List<CRD_Proveedores> ObtenerProveedoresPorRUC(string rucCedula)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    return db.CRD_Proveedores.Where(x => x.RucCedula.Contains(rucCedula)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar la lista", ex);
            }
        }
    }
}