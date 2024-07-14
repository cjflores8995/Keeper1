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
    public class CRD_EmpresasServicio
    {
        readonly ICRD_EmpresasRepositorio repo;
        public CRD_EmpresasServicio()
        {
            repo = new CRD_EmpresasRepositorioImpl();
        }

        public void Add(CRD_Empresas entry)
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

        public void Modify(CRD_Empresas entry)
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

        public IEnumerable<CRD_Empresas> ObtenerElementosActivos()
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
        public IEnumerable<CRD_Empresas> GetAll()
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

        public CRD_Empresas GetById(int id)
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

        public CRD_Empresas buscarPorNombre(string nom)
        {
            try
            {
                return repo.buscarPorNombre(nom);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo insertar registro,", ex);
            }
        }

        public CRD_Empresas buscarPorCodigoEmpresa(string codemp)
        {
            try
            {
                return repo.buscarPorCodigoEmpresa(codemp);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo insertar registro,", ex);
            }
        }
    }
}
