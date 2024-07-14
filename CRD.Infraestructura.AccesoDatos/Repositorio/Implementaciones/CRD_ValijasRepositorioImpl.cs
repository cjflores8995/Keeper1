using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_ValijasRepositorioImpl : BaseRepositorioImpl<CRD_Valijas>, ICRD_ValijasRepositorio
    {
        public CRD_Valijas buscarPorOrigen(string ori)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    var resultado = from pasc in context.CRD_Valijas
                                    where pasc.Origen == ori
                                    select pasc;
                    return resultado.Single();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo insertar registro,", ex);
            }
        }

        public CRD_Valijas buscarPorRemitente(string rem)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    var resultado = from pasc in context.CRD_Valijas
                                    where pasc.Remitente == rem
                                    select pasc;
                    return resultado.Single();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error: No se pudo insertar registro,", ex);
            }
        }
        public List<CRD_Valijas> ObtenerElementosActivos()
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    return db.CRD_Valijas.Where(x => x.Activo == true).ToList();
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
                    var elemento = db.CRD_Valijas.FirstOrDefault(x => x.IdValija == id);

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