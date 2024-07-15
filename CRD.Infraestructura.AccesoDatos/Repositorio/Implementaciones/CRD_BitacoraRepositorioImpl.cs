using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;

using System.Collections.Generic;
using System;
using System.Linq;
using CRD.Infraestructura.CrossCuting.Cache;

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

        public bool AgregarBitacora(CRD_Bitacora bitacora)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    bitacora.CRD_TipoDocumentoPagos = db.CRD_TipoDocumentoPagos.FirstOrDefault(x => x.IdTipoDocumentoPago == bitacora.IdTipoDocumentoPago);
                    bitacora.CRD_TipoDocumentos = db.CRD_TipoDocumentos.FirstOrDefault(x => x.IdTipoDocumento == bitacora.IdTipoDocumento);
                    bitacora.CRD_EstadoTipoProcesos = db.CRD_EstadoTipoProcesos.FirstOrDefault(x => x.IdEstadoTipoProceso == bitacora.IdEstadoProceso);
                    bitacora.CRD_Usuarios = db.CRD_Usuarios.FirstOrDefault(x => x.NombreUsuario == UsuarioLoginCache.NombreUsuario);
                    bitacora.CRD_Empresas = db.CRD_Empresas.FirstOrDefault();
                    bitacora.CRD_Ordenes = db.CRD_Ordenes.FirstOrDefault(x => x.NumeroOrden == bitacora.Orden);
                    bitacora.CRD_Paquetes = db.CRD_Paquetes.FirstOrDefault();
                    bitacora.CRD_Proveedores = db.CRD_Proveedores.FirstOrDefault();


                    db.CRD_Bitacora.Add(bitacora);


                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede insertar al usuario", ex);
            }
        }
    }
}
