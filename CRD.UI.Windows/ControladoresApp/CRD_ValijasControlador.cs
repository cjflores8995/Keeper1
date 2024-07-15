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
    public class CRD_ValijasControlador
    {
        private readonly CRD_ValijasServicio servicio;

        public CRD_ValijasControlador()
        {
            servicio = new CRD_ValijasServicio();
        }

        public bool Insertar(CRD_ValijasVistaModelo obj)
        {
            try
            {
                CRD_Valijas entry = MapearVistaEnObjeto(obj);

                servicio.Add(entry);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Actualizar(CRD_ValijasVistaModelo obj)
        {
            try
            {
                CRD_Valijas entry = MapearVistaEnObjeto(obj, agregarId: true);

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

        public List<CRD_ValijasVistaModelo> ListarTodo()
        {
            try
            {
                List<CRD_ValijasVistaModelo> result = new List<CRD_ValijasVistaModelo>();

                var query = servicio.ObtenerElementosActivos();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_ValijasVistaModelo entry = new CRD_ValijasVistaModelo()
                        {
                            IdValija = item.IdValija,
                            Fecha = item.Fecha,
                            Origen = item.Origen,
                            Remitente = item.Remitente,
                            Centro = item.Centro,
                            OBSV = item.OBSV,
                            Activo = item.Activo,
                            IdBitacora = item.CRD_Bitacora.IdBitacora
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



        public List<CRD_ValijasVistaModelo> BuscarOrigen(string nombre)
        {
            try
            {
                List<CRD_ValijasVistaModelo> result = new List<CRD_ValijasVistaModelo>();

                var query = servicio.ObtenerElementosActivos();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        if (item.Origen == nombre)

                        {
                            CRD_ValijasVistaModelo entry = new CRD_ValijasVistaModelo()
                            {
                                IdValija = item.IdValija,
                                IdBitacora = item.IdBitacora,
                                Fecha = item.Fecha,
                                Origen = item.Origen,
                                Remitente = item.Remitente,
                                Centro = item.Centro,
                                OBSV = item.OBSV,
                                Activo = item.Activo

                            };
                            result.Add(entry);
                        }
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
        public List<CRD_ValijasVistaModelo> BuscarRemitente(string nombre)
        {
            try
            {
                List<CRD_ValijasVistaModelo> result = new List<CRD_ValijasVistaModelo>();

                var query = servicio.ObtenerElementosActivos();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        if (item.Remitente == nombre)

                        {
                            CRD_ValijasVistaModelo entry = new CRD_ValijasVistaModelo()
                            {
                                IdValija = item.IdValija,
                                IdBitacora = item.IdBitacora,
                                Fecha = item.Fecha,
                                Origen = item.Origen,
                                Remitente = item.Remitente,
                                Centro = item.Centro,
                                OBSV = item.OBSV,
                                Activo = item.Activo

                            };
                            result.Add(entry);
                        }
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

        private CRD_Valijas MapearVistaEnObjeto(CRD_ValijasVistaModelo vistaModelo, bool agregarId = false)
        {
            CRD_Valijas entry = new CRD_Valijas();

            entry.IdBitacora = vistaModelo.IdBitacora;
            entry.Fecha = vistaModelo.Fecha;
            entry.Origen = vistaModelo.Origen;
            entry.Remitente = vistaModelo.Remitente;
            entry.Centro = vistaModelo.Centro;
            entry.OBSV = vistaModelo.OBSV;
            entry.Activo = vistaModelo.Activo;

            if (agregarId)
            {
                entry.IdValija = vistaModelo.IdValija;
            }

            return entry;
        }
    }
}
