using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_CiudadRepositorioImpl : BaseRepositorioImpl<CRD_Ciudad>, ICRD_CiudadRepositorio
    {
        public CRD_Ciudad ObtenerElementoPorNombre(string nombre)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    var result = (from obj in db.CRD_Ciudad
                                  where obj.NombreCiudad.ToLower() == nombre.ToLower()
                                  select obj).FirstOrDefault();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public List<CRD_Ciudad> ObtenerElementosActivos()
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    return db.CRD_Ciudad.Where(x => x.Activo == true).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public List<CRD_Ciudad> ObtenerListaPorNombre(string nombre)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    return db.CRD_Ciudad.Where(x => x.Activo == true && x.NombreCiudad.ToLower() == nombre.ToLower()).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public bool EliminadoLogico(int id)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    var elemento = db.CRD_Ciudad.FirstOrDefault(x => x.IdCiudad == id);

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
    }
}