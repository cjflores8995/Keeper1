using CRD.Dominio.Modelo.Abstracciones;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{

    public class BaseRepositorioImpl<TEntity> : IDisposable, IBaseRepositorio<TEntity> where TEntity : class
    {
        public void Add(TEntity entity)
        {
            try
            {

                using (var context = new SRGI_4Entities())
                {
                    context.Set<TEntity>().Add(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo insertar registro,", ex);
            }

        }

        public void Modify(TEntity entity)
        {
            try
            {
                using (var context = new SRGI_4Entities())

                {
                    context.Entry(entity).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo modificar registro,", ex);
            }


        }

        public void Delete(int id)
        {
            try
            {
                using (var context = new SRGI_4Entities())

                {
                    var entity = context.Set<TEntity>().Find(id);
                    context.Set<TEntity>().Remove(entity);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo eliminar registro,", ex);
            }

        }

        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                using (var context = new SRGI_4Entities())

                {
                    return context.Set<TEntity>().ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo listar registro,", ex);
            }
        }

        public TEntity GetById(int id)
        {
            try
            {
                using (var context = new SRGI_4Entities())

                {
                    return context.Set<TEntity>().Find(id);

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo recuperar registro,", ex);
            }
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }


}
