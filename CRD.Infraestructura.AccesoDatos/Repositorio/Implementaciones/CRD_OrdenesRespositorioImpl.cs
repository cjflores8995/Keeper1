using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_OrdenesRespositorioImpl : BaseRepositorioImpl<CRD_Ordenes>, ICRD_OrdenesRepositorio
    {
        public List<CRD_Ordenes> ObtenerOrdenesPorNumeroOrden(string numeroOrden)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    return db.CRD_Ordenes.Where(x => x.NumeroOrden.Contains(numeroOrden)).ToList();

                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }
    }
}