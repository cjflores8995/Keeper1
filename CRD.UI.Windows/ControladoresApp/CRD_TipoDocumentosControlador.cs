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
    public class CRD_TipoDocumentosControlador
    {
        private readonly CRD_TipoDocumentosServicio servicio;

        public CRD_TipoDocumentosControlador()
        {
            servicio = new CRD_TipoDocumentosServicio();
        }

        public bool Insertar(CRD_TipoDocumentosVistaModelo obj) {
            try
            {
                CRD_TipoDocumentos entry = MapearVistaEnObjeto(obj);

                servicio.Add(entry);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Actualizar(CRD_TipoDocumentosVistaModelo obj)
        {
            try
            {
                CRD_TipoDocumentos entry = MapearVistaEnObjeto(obj, agregarId: true);

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

        public List<CRD_TipoDocumentosVistaModelo> ListarTodo()
        {
            try
            {
                List<CRD_TipoDocumentosVistaModelo> result = new List<CRD_TipoDocumentosVistaModelo>();

                var query = servicio.ObtenerElementosActivos();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_TipoDocumentosVistaModelo entry = new CRD_TipoDocumentosVistaModelo()
                        {
                            IdTipoDocumento = item.IdTipoDocumento,
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



        private CRD_TipoDocumentos MapearVistaEnObjeto(CRD_TipoDocumentosVistaModelo vistaModelo, bool agregarId = false)
        {
            CRD_TipoDocumentos entry = new CRD_TipoDocumentos();

            entry.Nombre = vistaModelo.Nombre;
            entry.Descripcion = vistaModelo.Descripcion;
            entry.Activo = vistaModelo.Activo;

            if (agregarId)
            {
                entry.IdTipoDocumento = vistaModelo.IdTipoDocumento;
            }

            return entry;
        }

    }
}
