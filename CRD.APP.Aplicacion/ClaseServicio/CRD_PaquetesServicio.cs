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
    public class CRD_PaquetesServicio
    {
        readonly ICRD_PaquetesRepositorio repo;
        public CRD_PaquetesServicio()
        {
            repo = new CRD_PaquetesRepositorioImpl();
        }

        public void Add(CRD_Paquetes entry)
        {
            try
            {
                repo.InsertarPaquete(entry);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }

        }

        public void Modify(CRD_Paquetes entry)
        {
            try
            {
                repo.ActualizarPaquete(entry);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }

        }

        public IEnumerable<CRD_Paquetes> GetAll()
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

        public CRD_Paquetes GetById(int id)
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
                repo.EliminadoLogico(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }

        public List<CRD_Paquetes> ObtenerPaquetesPorNombre(string nombre)
        {
            try
            {
                return repo.ObtenerPaquetesPorNombre(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }

        public List<CRD_Paquetes> ObtenerElementosActivos()
        {
            try
            {
                return repo.ObtenerElementosActivos();
            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo encontrar el listado", ex);
            }
        }

        public List<CRD_Paquetes> ObtenerPaquetesPorIdCaja(int id)
        {
            try
            {
                return repo.ObtenerPaquetesPorIdCaja(id);
            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo encontrar el listado", ex);
            }
        }

        public bool InsertarUsuario(CRD_Paquetes entity)
        {
            try
            {
                return repo.InsertarPaquete(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }

        public bool ActualizarPaquete(CRD_Paquetes entity)
        {
            try
            {
                return repo.ActualizarPaquete(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }

    }
}
