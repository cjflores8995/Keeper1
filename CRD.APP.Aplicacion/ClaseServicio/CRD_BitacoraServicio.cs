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
    public class CRD_BitacoraServicio
    {

        readonly ICRD_BitacoraRepositorio repo;
        public CRD_BitacoraServicio()
        {
            repo = new CRD_BitacoraRepositorioImpl();
        }

        public void AddBitacora(CRD_Bitacora entry)
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

        public void ModifyBitacora(CRD_Bitacora entry)
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

        public IEnumerable<CRD_Bitacora> ListarTodo()
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

        public CRD_Bitacora GetByIdBitacora(int id)
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

        public void DeleteBitacora(int id)
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

        public List<CRD_Bitacora> buscarPorFacturaBitacora(string Factura)
        {
            try
            {
                return repo.buscarPorFactura(Factura);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: No se pudo mostrar registro,", ex);
            }
        }
    }
}
