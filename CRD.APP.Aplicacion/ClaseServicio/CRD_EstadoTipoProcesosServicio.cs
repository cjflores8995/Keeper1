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
    public class CRD_EstadoTipoProcesosServicio
    {
        readonly ICRD_EstadoTipoProcesosRepositorio repo;
        public CRD_EstadoTipoProcesosServicio()
        {
            repo = new CRD_EstadoTipoProcesosRepositorioImpl();
        }

        public void Add(CRD_EstadoTipoProcesos entry)
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

        public void Modify(CRD_EstadoTipoProcesos entry)
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
        public IEnumerable<CRD_EstadoTipoProcesos> ObtenerElementosActivos()
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
        public IEnumerable<CRD_EstadoTipoProcesos> GetAll()
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

        public CRD_EstadoTipoProcesos GetById(int id)
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

        public CRD_EstadoTipoProcesos buscarPorNombre(string nom)
        {
            try
            {
                return repo.buscarPorNombre(nom);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: Error no pasa,", ex);
            }
        }

    }
}
