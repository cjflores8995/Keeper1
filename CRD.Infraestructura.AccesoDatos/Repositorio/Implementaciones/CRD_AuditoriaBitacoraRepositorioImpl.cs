using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_AuditoriaBitacoraRepositorioImpl : BaseRepositorioImpl<CRD_AuditoriaBitacora>, ICRD_AuditoriaBitacoraRepositorio
    {
        public List<CRD_AuditoriaBitacora> ObtenerAuditoriaBitacoraPorNombreUsuario(string nombre)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    var result = (from obj in db.CRD_AuditoriaBitacora
                                  where obj.CRD_Usuarios.NombreUsuario.ToLower().Equals(nombre.ToLower())
                                  select obj).ToList();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public List<CRD_AuditoriaBitacora> ObtenerAuditoriaBitacoraPorRangoFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    var result = (from obj in db.CRD_AuditoriaBitacora
                                  where obj.FechaModificacion >= fechaInicio && obj.FechaModificacion <= fechaFin
                                  select obj).ToList();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public List<CRD_AuditoriaBitacora> ObtenerAuditoriaBitacoraPorRangoFechasRegistroHistorico(string registroHistorico)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    var result = (from obj in db.CRD_AuditoriaBitacora
                                  where obj.RegistroHistorico.Contains(registroHistorico)
                                  select obj).ToList();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public List<CRD_AuditoriaBitacora> ObtenerElementos()
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    var result = db.CRD_AuditoriaBitacora.Include(c => c.CRD_Usuarios).ToList();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }
    }
}
