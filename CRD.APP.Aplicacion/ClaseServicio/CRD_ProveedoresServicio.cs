using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.APP.Aplicacion.ClaseServicio
{
    public class CRD_ProveedoresServicio
    {
        readonly ICRD_ProveedoresRepositorio repo;
        public CRD_ProveedoresServicio()
        {
            repo = new CRD_ProveedoresRepositorioImpl();
        }

        public void Add(CRD_Proveedores entry)
        {
            try
            {
                repo.Add(entry);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }

        }

        public void Modify(CRD_Proveedores entry)
        {
            try
            {
                repo.Modify(entry);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }

        }

        public IEnumerable<CRD_Proveedores> GetAll()
        {
            try
            {
                return repo.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }

        public CRD_Proveedores GetById(int id)
        {
            try
            {
                return repo.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }

        public void Delete(int id)
        {
            try
            {
                repo.Delete(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }

        public List<CRD_Proveedores> ObtenerProveedoresPorCodProveedor(String codProveedor)
        {
            try
            {
                return repo.ObtenerProveedoresPorCodProveedor(codProveedor);
            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo encontrar el registro", ex);
            }
        }

        public List<CRD_Proveedores> ObtenerProveedoresPorRUC(string rucCedula)
        {
            try
            {
                return repo.ObtenerProveedoresPorRUC(rucCedula);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: No se pudo mostrar registro,", ex);
            }
        }

        public List<CRD_Proveedores> ObtenerProveedoresPorRazonSocial(string razonSocial)
        {
            try
            {
                return repo.ObtenerProveedoresPorRazonSocial(razonSocial);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: No se pudo mostrar registro,", ex);
            }
        }
    }
}
