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
    public class CRD_AnalistasControlador
    {

        private readonly CRD_AnalistasServicio servicio;

        public CRD_AnalistasControlador()
        {
            servicio = new CRD_AnalistasServicio();
        }

        public bool InsertarAnalista(CRD_AnalistasVistaModelo nuevoAnalistaVistaModelo)
        {
            CRD_Analistas nuevoAnalista = new CRD_Analistas(); //objeto de la BD
            try
            {
                nuevoAnalista.IdAnalista = nuevoAnalistaVistaModelo.IdAnalista;
                nuevoAnalista.IdEstadoTipoProceso = nuevoAnalistaVistaModelo.IdEstadoTipoProceso;
                nuevoAnalista.UsuarioLN = nuevoAnalistaVistaModelo.UsuarioLN;
                nuevoAnalista.Nombre = nuevoAnalistaVistaModelo.Nombre;
                nuevoAnalista.Activo = nuevoAnalistaVistaModelo.Activo;
                servicio.Add(nuevoAnalista);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public IEnumerable<CRD_AnalistasVistaModelo> ListarAnalista()
        {
            var listaAnalista = servicio.GetAll();
            List<CRD_AnalistasVistaModelo> listaVistaModelo = new List<CRD_AnalistasVistaModelo>();
            foreach (var item in listaAnalista)
            {
                listaVistaModelo.Add(new CRD_AnalistasVistaModelo
                {
                    IdAnalista = item.IdAnalista,
                    IdEstadoTipoProceso = item.IdEstadoTipoProceso,
                    UsuarioLN = item.UsuarioLN,
                    Nombre = item.Nombre,
                    Activo = item.Activo,

                });
            }
            return listaVistaModelo;
        }

        public IEnumerable<CRD_EstadoTipoProcesosVistaModelo> ListarEstadoTipoProcesos()
        {
            var listaEstadoTipoProcesos = servicio.GetAll();
            List<CRD_EstadoTipoProcesosVistaModelo> listaVistaModelo = new List<CRD_EstadoTipoProcesosVistaModelo>();
            foreach (var item in listaEstadoTipoProcesos)
            {
                listaVistaModelo.Add(new CRD_EstadoTipoProcesosVistaModelo
                {
                    IdEstadoTipoProceso = item.IdEstadoTipoProceso,
                    Nombre = item.Nombre,
                    //Descripcion = item.Descripcion,
                    //Activo = item.Activo,
                });
            }
            return listaVistaModelo;
        }


        public bool ActualizarAnalista(CRD_AnalistasVistaModelo nuevoAnalistaVistaModelo)
        {
            CRD_Analistas nuevaAnalista = new CRD_Analistas(); //objeto de la BD
            try
            {
                nuevaAnalista.IdAnalista = nuevoAnalistaVistaModelo.IdAnalista;
                nuevaAnalista.IdEstadoTipoProceso = nuevoAnalistaVistaModelo.IdEstadoTipoProceso;
                nuevaAnalista.UsuarioLN = nuevoAnalistaVistaModelo.UsuarioLN;
                nuevaAnalista.Nombre = nuevoAnalistaVistaModelo.Nombre;
                nuevaAnalista.Activo = nuevoAnalistaVistaModelo.Activo;

                servicio.Modify(nuevaAnalista);
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool EliminarAnalista(int id)
        {

            try
            {
                servicio.Delete(id);
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }


        public List<CRD_AnalistasVistaModelo> ObtenerListaPorNombre(string nombre)
        {
            try
            {
                List<CRD_AnalistasVistaModelo> result = new List<CRD_AnalistasVistaModelo>();

                var query = servicio.ObtenerListaPorNombre(nombre);

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_AnalistasVistaModelo entry = new CRD_AnalistasVistaModelo()
                        {
                            IdAnalista = item.IdAnalista,
                            IdEstadoTipoProceso = item.IdEstadoTipoProceso,
                            Nombre = item.Nombre,
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





    }
}
