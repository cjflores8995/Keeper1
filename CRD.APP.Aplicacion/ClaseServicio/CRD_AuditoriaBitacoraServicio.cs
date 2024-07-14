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
    public class CRD_AuditoriaBitacoraServicio
    {

        readonly ICRD_AuditoriaBitacoraRepositorio repo;
        public CRD_AuditoriaBitacoraServicio()
        {
            repo = new CRD_AuditoriaBitacoraRepositorioImpl();
        }

        public void Add(CRD_AuditoriaBitacora entry)
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

        public void Modify(CRD_AuditoriaBitacora entry)
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

        public IEnumerable<CRD_AuditoriaBitacora> GetAll()
        {
            try
            {
                return repo.ObtenerElementos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }

        public CRD_AuditoriaBitacora GetById(int id)
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


        public List<CRD_AuditoriaBitacora> ObtenerAuditoriaBitacoraPorNombreUsuario(string nombre)
        {
            try
            {
                return repo.ObtenerAuditoriaBitacoraPorNombreUsuario(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }


        public List<CRD_AuditoriaBitacora> ObtenerAuditoriaBitacoraPorRangoFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                return repo.ObtenerAuditoriaBitacoraPorRangoFechas(fechaInicio, fechaFin);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }


        public List<CRD_AuditoriaBitacora> ObtenerAuditoriaBitacoraPorRangoFechasRegistroHistorico(string registroHistorico)
        {
            try
            {
                return repo.ObtenerAuditoriaBitacoraPorRangoFechasRegistroHistorico(registroHistorico);
    }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }
    }
}