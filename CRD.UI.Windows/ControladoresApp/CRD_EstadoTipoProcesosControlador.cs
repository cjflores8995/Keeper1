using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;
using CRD.UI.Windows.VistaModelo;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.ControladorAplicacion
{
    public class CRD_EstadoTipoProcesosControlador
    {
        private readonly CRD_EstadoTipoProcesosServicio servicio;

        public CRD_EstadoTipoProcesosControlador()
        {
            servicio = new CRD_EstadoTipoProcesosServicio();
        }

        public bool Insertar(CRD_EstadoTipoProcesosVistaModelo obj)
        {
            try
            {
                CRD_EstadoTipoProcesos entry = MapearVistaEnObjeto(obj);

                servicio.Add(entry);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Actualizar(CRD_EstadoTipoProcesosVistaModelo obj)
        {
            try
            {
                CRD_EstadoTipoProcesos entry = MapearVistaEnObjeto(obj, agregarId: true);

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

        public List<CRD_EstadoTipoProcesosVistaModelo> ListarTodo()
        {
            try
            {
                List<CRD_EstadoTipoProcesosVistaModelo> result = new List<CRD_EstadoTipoProcesosVistaModelo>();

                var query = servicio.ObtenerElementosActivos();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_EstadoTipoProcesosVistaModelo entry = new CRD_EstadoTipoProcesosVistaModelo()
                        {
                            IdEstadoTipoProceso = item.IdEstadoTipoProceso,
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

        private CRD_EstadoTipoProcesos MapearVistaEnObjeto(CRD_EstadoTipoProcesosVistaModelo vistaModelo, bool agregarId = false)
        {
            CRD_EstadoTipoProcesos entry = new CRD_EstadoTipoProcesos();

            entry.Nombre = vistaModelo.Nombre;
            entry.Descripcion = vistaModelo.Descripcion;
            entry.Activo = vistaModelo.Activo;

            if (agregarId)
            {
                entry.IdEstadoTipoProceso = vistaModelo.IdEstadoTipoProceso;
            }

            return entry;
        }
    }
}
