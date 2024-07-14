using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_CajasRepositorioImpl : BaseRepositorioImpl<CRD_Cajas>, ICRD_CajasRepositorio
    {
        public CRD_Cajas ObtenerElementoPorNombre(string nombre)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    var result = db.CRD_Cajas.FirstOrDefault(x => x.NombreCaja.ToLower() == nombre.ToLower());
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public List<CRD_Cajas> ObtenerElementosActivos()
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    return db.CRD_Cajas.Where(x => x.Activo == true).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public List<CRD_Cajas> ObtenerListaPorNombre(string nombre)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    var result = db.CRD_Cajas.Where(x => x.Activo == true && x.NombreCaja.ToLower() == nombre.ToLower()).ToList();
                    return result;
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
                    var elemento = db.CRD_Cajas.FirstOrDefault(x => x.IdCaja == id);

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
