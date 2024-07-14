using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_CargoRepositorioImpl : BaseRepositorioImpl<CRD_Cargo>, ICRD_CargoRepositorio
    {
        public CRD_Cargo ObtenerElementoPorNombre(string nombre)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    var result = (from obj in db.CRD_Cargo
                                  where obj.NombreCargo.ToLower() == nombre.ToLower()
                                  select obj).FirstOrDefault();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public List<CRD_Cargo> ObtenerElementosActivos()
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    return db.CRD_Cargo.Where(x => x.Activo == true).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public List<CRD_Cargo> ObtenerListaPorNombre(string nombre)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    var result = db.CRD_Cargo.Where(x => x.Activo == true && x.NombreCargo.ToLower() == nombre.ToLower()).ToList();
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
                    var elemento = db.CRD_Cargo.FirstOrDefault(x => x.IdCargo == id);

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
