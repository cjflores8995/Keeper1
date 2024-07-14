using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_DepartamentoRepositorioImpl : BaseRepositorioImpl<CRD_Departamento>, ICRD_DepartamentoRepositorio
    {
        public CRD_Departamento ObtenerElementoPorNombre(string nombre)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    var resultado = db.CRD_Departamento.FirstOrDefault(x => x.NombreDepartamento.ToLower() == nombre.ToLower());
                    return resultado;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo insertar registro,", ex);
            }
        }

        public List<CRD_Departamento> ObtenerElementosActivos()
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    return db.CRD_Departamento.Where(x => x.Activo == true).ToList();
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
                    var elemento = db.CRD_Departamento.FirstOrDefault(x => x.IdDepartamento == id);

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