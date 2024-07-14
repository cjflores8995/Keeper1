using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;

using System.Collections.Generic;
using System;
using System.Linq;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_BitacoraRepositorioImpl : BaseRepositorioImpl<CRD_Bitacora>, ICRD_BitacoraRepositorio
    {
        public List<CRD_Bitacora> buscarPorFactura(string Factura)
        {
            try
            {
                using (var context = new SRGI_4Entities())
                {
                    return context.CRD_Bitacora.Where(x => x.NumeroDocumentoPago == Factura).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo encontrar el listado de Bitacoras", ex);
            }
        }
    }
}
