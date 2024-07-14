using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_TipoDocumentosRepositorioImpl : BaseRepositorioImpl<CRD_TipoDocumentos>, ICRD_TipoDocumentosRepositorio
    {
        public bool EliminadoLogico(int id)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    var elemento = db.CRD_TipoDocumentos.FirstOrDefault(x => x.IdTipoDocumento == id);

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

        public List<CRD_TipoDocumentos> ObtenerElementosActivos()
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    return db.CRD_TipoDocumentos.Where(x => x.Activo == true).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public CRD_TipoDocumentos ObtenerTipoDocumentoPorNombre(string nombreTipoDocumento)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    var resultado = from obj in db.CRD_TipoDocumentos
                                    where obj.Nombre == nombreTipoDocumento
                                    select obj;
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