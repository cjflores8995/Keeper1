using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_PaquetesRepositorioImpl : BaseRepositorioImpl<CRD_Paquetes>, ICRD_PaquetesRepositorio
    {
        public bool ActualizarPaquete(CRD_Paquetes obj)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    var paquete = db.CRD_Paquetes.FirstOrDefault(x => x.IdPaquete == obj.IdPaquete);

                    if (paquete == null)
                    {
                        return false;

                    }

                    paquete.CRD_Cajas = db.CRD_Cajas.FirstOrDefault(x => x.IdCaja == obj.IdCaja);

                    paquete.NombrePaquete = obj.NombrePaquete;
                    paquete.Descripcion = obj.Descripcion;
                    paquete.EstatusPaquete = obj.EstatusPaquete;
                    paquete.Activo = obj.Activo;
                    paquete.IdCaja = obj.IdCaja;

                    return db.SaveChanges() > 0;
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
                    var elemento = db.CRD_Paquetes.FirstOrDefault(x => x.IdPaquete == id);

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

        public bool InsertarPaquete(CRD_Paquetes obj)
        {
            {
                try
                {
                    using (var db = new SRGI_4Entities())
                    {

                        obj.CRD_Cajas = db.CRD_Cajas.FirstOrDefault(x => x.IdCaja == obj.IdCaja);



                        var usuario = db.CRD_Paquetes.Add(obj);
                        return db.SaveChanges() > 0;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("No se puede devolver el resultado", ex);
                }
            }
        }

        public List<CRD_Paquetes> ObtenerElementosActivos()
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    return db.CRD_Paquetes.Include("CRD_Cajas").Where(x => x.Activo == true).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public List<CRD_Paquetes> ObtenerPaquetesPorIdCaja(int id)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    var result = (from obj in db.CRD_Paquetes
                                  where obj.CRD_Cajas.IdCaja == id
                                  select obj).ToList();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public CRD_Paquetes ObtenerPaquetesPorNombre(string nombre)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    var resultado = from obj in db.CRD_Paquetes
                                    where obj.NombrePaquete == nombre
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