using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;
using CRD.UI.Windows.VistaModelo;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.ControladoresApp
{
    public class CRD_TipoDocumentoPagosControlador
    {
        private readonly CRD_TipoDocumentoPagosServicio servicio;

        public CRD_TipoDocumentoPagosControlador()
        {
            servicio = new CRD_TipoDocumentoPagosServicio();
        }

        public bool Insertar(CRD_TipoDocumentoPagosVistaModelo obj)
        {
            try
            {
                CRD_TipoDocumentoPagos entry = MapearVistaEnObjeto(obj);

                servicio.Add(entry);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Actualizar(CRD_TipoDocumentoPagosVistaModelo obj)
        {
            try
            {
                CRD_TipoDocumentoPagos entry = MapearVistaEnObjeto(obj, agregarId: true);

                servicio.Modify(entry);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Eliminar(int idObj)
        {
            try
            {
                servicio.Delete(idObj);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public List<CRD_TipoDocumentoPagosVistaModelo> ListarTodo()
        {
            try
            {
                List<CRD_TipoDocumentoPagosVistaModelo> result = new List<CRD_TipoDocumentoPagosVistaModelo>();

                var query = servicio.ObtenerElementosActivos();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_TipoDocumentoPagosVistaModelo entry = new CRD_TipoDocumentoPagosVistaModelo()
                        {
                            IdTipoDocumentoPago = item.IdTipoDocumentoPago,
                            Nombre = item.Nombre,
                            Descripcion = item.Descripcion,
                            Activo = item.Activo
                        };

                        result.Add(entry);
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return null;
            }
        }

        public List<CRD_TipoDocumentoPagosVistaModelo> ObtenerTipoDocumentoPagosPorNombre(string nombre)
        {
            try
            {
                List<CRD_TipoDocumentoPagosVistaModelo> result = new List<CRD_TipoDocumentoPagosVistaModelo>();

                var query = servicio.ObtenerTipoDocumentoPagosPorNombre(nombre);

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_TipoDocumentoPagosVistaModelo entry = new CRD_TipoDocumentoPagosVistaModelo()
                        {
                            IdTipoDocumentoPago = item.IdTipoDocumentoPago,
                            Nombre = item.Nombre,
                            Descripcion = item.Descripcion,
                            Activo = item.Activo
                        };

                        result.Add(entry);
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return null;
            }
        }

        private CRD_TipoDocumentoPagos MapearVistaEnObjeto(CRD_TipoDocumentoPagosVistaModelo vistaModelo, bool agregarId = false)
        {
            CRD_TipoDocumentoPagos entry = new CRD_TipoDocumentoPagos();

            entry.Nombre = vistaModelo.Nombre;
            entry.Descripcion = vistaModelo.Descripcion;
            entry.Activo = vistaModelo.Activo;

            if (agregarId)
            {
                entry.IdTipoDocumentoPago = vistaModelo.IdTipoDocumentoPago;
            }

            return entry;
        }

    }
}
