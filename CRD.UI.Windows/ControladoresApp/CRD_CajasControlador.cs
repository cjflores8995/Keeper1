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
    public class CRD_CajasControlador
    {
        private readonly CRD_CajasServicio servicio;

        public CRD_CajasControlador()
        {
            servicio = new CRD_CajasServicio();
        }

        public bool Insertar(CRD_CajasVistaModelo obj)
        {
            try
            {
                CRD_Cajas entry = MapearVistaEnObjeto(obj);

                servicio.Add(entry);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Actualizar(CRD_CajasVistaModelo obj)
        {
            try
            {
                CRD_Cajas entry = MapearVistaEnObjeto(obj, agregarId: true);

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

        public List<CRD_CajasVistaModelo> ListarTodo()
        {
            try
            {
                List<CRD_CajasVistaModelo> result = new List<CRD_CajasVistaModelo>();

                var query = servicio.ObtenerElementosActivos();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_CajasVistaModelo entry = new CRD_CajasVistaModelo()
                        {
                            IdCaja = item.IdCaja,
                            NombreCaja = item.NombreCaja,
                            Descripcion = item.Descripcion,
                            EstatusCaja = item.EstatusCaja,
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

        public List<CRD_CajasVistaModelo> ObtenerListaPorNombre(string nombre)
        {
            try
            {
                List<CRD_CajasVistaModelo> result = new List<CRD_CajasVistaModelo>();

                var query = servicio.ObtenerListaPorNombre(nombre);

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_CajasVistaModelo entry = new CRD_CajasVistaModelo()
                        {
                            IdCaja = item.IdCaja,
                            NombreCaja = item.NombreCaja,
                            Descripcion = item.Descripcion,
                            EstatusCaja = item.EstatusCaja,
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

        

        private CRD_Cajas MapearVistaEnObjeto(CRD_CajasVistaModelo vistaModelo, bool agregarId = false)
        {
            CRD_Cajas entry = new CRD_Cajas();
            
            entry.NombreCaja = vistaModelo.NombreCaja;
            entry.Descripcion = vistaModelo.Descripcion;
            entry.EstatusCaja = vistaModelo.EstatusCaja;
            entry.Activo = vistaModelo.Activo;

            if (agregarId)
            {
                entry.IdCaja = vistaModelo.IdCaja;
            }

            return entry;
        }
    }
}
