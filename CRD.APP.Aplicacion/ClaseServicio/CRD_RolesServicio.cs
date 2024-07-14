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
    public class CRD_RolesServicio
    {
        readonly ICRD_RolesRepositorio repo;

        public CRD_RolesServicio()
        {
            repo = new CRD_RolesRepositorioImpl();
        }

        public void Add(CRD_Roles entity)
        {
            repo.Add(entity);
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }

        public IEnumerable<CRD_Roles> GetAll()
        {
            return repo.GetAll();
        }

        public CRD_Roles GetById(int id)
        {
            return repo.GetById(id);
        }

        public void Modify(CRD_Roles entity)
        {
            repo.Modify(entity);
        }
    }
}
