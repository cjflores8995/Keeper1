using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_IvaRepositorioImpl : BaseRepositorioImpl<CRD_Iva>, ICRD_IvaRepositorio
    {
        public List<CRD_Iva> ObtenerElementosActivos()
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    return db.CRD_Iva.Where(x => x.Activo == true).ToList();
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
                    var elemento = db.CRD_Iva.FirstOrDefault(x => x.IdIva == id);

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

        public bool EstablecerIvaPrincipal(int id)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    var ivaRegistros = db.CRD_Iva.ToList();

                    ivaRegistros.ForEach(x =>
                    {
                        x.Activo = false;
                    });

                    var principal = db.CRD_Iva.FirstOrDefault(x => x.IdIva == id);

                    if(principal != null)
                    {
                        principal.Activo = true;
                    }

                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }
    }
}