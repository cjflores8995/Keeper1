using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_TipoDocumentoPagosRepositorioImpl : BaseRepositorioImpl<CRD_TipoDocumentoPagos>, ICRD_TipoDocumentoPagosRepositorio
    {
        public bool EliminadoLogico(int id)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    var elemento = db.CRD_TipoDocumentoPagos.FirstOrDefault(x => x.IdTipoDocumentoPago == id);

                    if (elemento != null)
                    {
                        elemento.Activo = false;
                        var result = db.SaveChanges();

                        return result > 0;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public List<CRD_TipoDocumentoPagos> ObtenerElementosActivos()
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    return db.CRD_TipoDocumentoPagos.Where(x => x.Activo == true).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public CRD_TipoDocumentoPagos ObtenerTipoDocumentoPagosPorNombre(string nombreTipoDocumentoPagos)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    var resultado = from tipoDocumentoPago in context.CRD_TipoDocumentoPagos
                                    where tipoDocumentoPago.Nombre == nombreTipoDocumentoPagos
                                    select tipoDocumentoPago;
                    return resultado.Single();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar el tipo de documento", ex);
            }
        }
    }
}