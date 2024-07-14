using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_EmpresasRepositorioImpl : BaseRepositorioImpl<CRD_Empresas>, ICRD_EmpresasRepositorio
    {
        public CRD_Empresas buscarPorCodigoEmpresa(string codemp)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    var resultado = from pasc in context.CRD_Empresas
                                    where pasc.CodigoEmpresa == codemp
                                    select pasc;
                    return resultado.Single();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo insertar registro,", ex);
            }
        }

        public CRD_Empresas buscarPorNombre(string nom)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    var resultado = from pasc in context.CRD_Empresas
                                    where pasc.Nombre == nom
                                    select pasc;
                    return resultado.Single();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo insertar registro,", ex);
            }
        }


        public List<CRD_Empresas> ObtenerElementosActivos()
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    return db.CRD_Empresas.Where(x => x.Activo == true).ToList();
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
                    var elemento = db.CRD_Empresas.FirstOrDefault(x => x.IdEmpresa == id);

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