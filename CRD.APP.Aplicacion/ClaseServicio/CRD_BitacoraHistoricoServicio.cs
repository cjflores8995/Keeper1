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
    public class CRD_BitacoraHistoricoServicio
    {

        readonly ICRD_BitacoraHistoricoRepositorio repo;
        public CRD_BitacoraHistoricoServicio()
        {
            repo = new CRD_BitacoraHistoricoRepositorioImpl();
        }

        public void Add(CRD_BitacoraHistorico entry)
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

        public void Modify(CRD_BitacoraHistorico entry)
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

        public IEnumerable<CRD_BitacoraHistorico> GetAll()
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

        public CRD_BitacoraHistorico GetById(int id)
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

        public List<CRD_BitacoraHistorico> buscarPorFactura(string Factura)
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

        public List<CRD_BitacoraHistorico> buscarPorPartner(string Partner)
        {
            try
            {
                return repo.buscarPorPartner(Partner);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: No se pudo mostrar registro,", ex);
            }
        }

        public List<CRD_BitacoraHistorico> buscarPorRuc(string Ruc)
        {
            try
            {
                return repo.buscarPorRuc(Ruc);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: No se pudo mostrar registro,", ex);
            }
        }
        public List<CRD_BitacoraHistorico> buscarPorNumeroOrden(string NumeroOrden)
        {
            try
            {
                return repo.buscarPorNumeroOrden(NumeroOrden);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: No se pudo mostrar registro,", ex);
            }
        }
    }
}
