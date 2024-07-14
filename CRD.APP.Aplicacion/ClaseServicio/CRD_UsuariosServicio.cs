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
    public class CRD_UsuariosServicio
    {
        readonly ICRD_UsuariosRepositorio repo;

        public CRD_UsuariosServicio()
        {
            repo = new CRD_UsuariosRepositorioImpl();
        }

        public void Add(CRD_Usuarios entity)
        {
            repo.InsertarUsuario(entity);
        }

        public bool Delete(int id)
        {
            return repo.EliminadoLogico(id);
        }

        public IEnumerable<CRD_Usuarios> GetAll()
        {
            return repo.GetAll();
        }

        public CRD_Usuarios GetById(int id)
        {
            return repo.GetById(id);
        }

        public void Modify(CRD_Usuarios entity)
        {
            repo.Modify(entity);
        }

        public CRD_Usuarios ObtenerUsuarioPorEmail(string email)
        {
            return repo.ObtenerUsuarioPorEmail(email);
        }

        public CRD_Usuarios ObtenerUsuarioPorId(int id)
        {
            return repo.ObtenerUsuarioPorId(id);
        }

        public bool LoginUsuario(string usuario, string password)
        {
            return repo.LoginUsuario(usuario, password);
        }

        public bool LoginUsuarioConEmail(string usuario, string password)
        {
            return repo.LoginUsuarioConEmail(usuario, password);
        }

        public List<CRD_Usuarios> ObtenerElementosActivos()
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

        public bool ActualizarUsuario(CRD_Usuarios entity)
        {
            try
            {
                return repo.ActualizarUsuario(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }

        public bool ActualizarUsuarioPassword(CRD_Usuarios entity)
        {
            try
            {
                return repo.ActualizarUsuarioPassword(entity);
            }
            catch (Exception ex)
            {
                throw new Exception("Error Servicio: ", ex);
            }
        }

        
    }
}
