using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_AnalistasRepositorioImpl: BaseRepositorioImpl<CRD_Analistas>, ICRD_AnalistasRepositorio
    {
        public CRD_Analistas buscarPorIdAnalista(int IdAnalista)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    var resultado = from obj in context.CRD_Analistas
                                    where obj.IdAnalista == IdAnalista
                                    select obj;
                    return resultado.Single();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar el Analista solicitado", ex);
            }
        }


        public string buscarPorIdProceso(int IdProceso)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    return context.CRD_Analistas.FirstOrDefault(x => x.IdAnalista == IdProceso).Nombre;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar la lista Analistas", ex);
            }
        }

        public List<CRD_Analistas> ObtenerListaPorNombre(string nombre)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    return db.CRD_Analistas.Where(x => x.Activo == true && x.Nombre.ToLower() == nombre.ToLower()).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }
    }
}
