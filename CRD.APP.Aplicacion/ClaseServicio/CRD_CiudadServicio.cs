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
    public class CRD_CiudadServicio
    {
        readonly ICRD_CiudadRepositorio repo;
        public CRD_CiudadServicio()
        {
            repo = new CRD_CiudadRepositorioImpl();
        }

        public void Add(CRD_Ciudad entry)
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

        public void Modify(CRD_Ciudad entry)
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

        public List<CRD_Ciudad> ObtenerElementosActivos()
        {
            try
            {
                return repo.ObtenerElementosActivos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }

        public CRD_Ciudad GetById(int id)
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

        public CRD_Ciudad ObtenerElementoPorNombre(string nombre)
        {
            try
            {
                return repo.ObtenerElementoPorNombre(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }

        public List<CRD_Ciudad> ObtenerListaPorNombre(string nombre)
        {
            try
            {
                return repo.ObtenerListaPorNombre(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }
    }
}
