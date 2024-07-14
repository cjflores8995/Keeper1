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
    public class CRD_TipoDocumentosServicio
    {
        readonly ICRD_TipoDocumentosRepositorio repo;
        public CRD_TipoDocumentosServicio()
        {
            repo = new CRD_TipoDocumentosRepositorioImpl();
        }

        public void Add(CRD_TipoDocumentos entry)
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

        public void Modify(CRD_TipoDocumentos entry)
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

        public IEnumerable<CRD_TipoDocumentos> GetAll()
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

        public CRD_TipoDocumentos GetById(int id)
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

        public CRD_TipoDocumentos ObtenerTipoDocumentoPorNombre(string nombre)
        {
            try
            {
                return repo.ObtenerTipoDocumentoPorNombre(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception("No se puedo encontrar el registro", ex);
            }
        }

        public List<CRD_TipoDocumentos> ObtenerElementosActivos()
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
    }
}
