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
    public class CRD_CiudadControlador
    {
        private readonly CRD_CiudadServicio servicio;

        public CRD_CiudadControlador()
        {
            servicio = new CRD_CiudadServicio();
        }

        public bool Insertar(CRD_CiudadVistaModelo obj)
        {
            try
            {
                CRD_Ciudad entry = MapearVistaEnObjeto(obj);

                servicio.Add(entry);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Actualizar(CRD_CiudadVistaModelo obj)
        {
            try
            {
                CRD_Ciudad entry = MapearVistaEnObjeto(obj, agregarId: true);

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

        public List<CRD_CiudadVistaModelo> ListarTodo()
        {
            try
            {
                List<CRD_CiudadVistaModelo> result = new List<CRD_CiudadVistaModelo>();

                var query = servicio.ObtenerElementosActivos();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_CiudadVistaModelo entry = new CRD_CiudadVistaModelo()
                        {
                            IdCiudad = item.IdCiudad,
                            NombreCiudad = item.NombreCiudad,
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

        public List<CRD_CiudadVistaModelo> ObtenerListaPorNombre(string nombre)
        {
            try
            {
                List<CRD_CiudadVistaModelo> result = new List<CRD_CiudadVistaModelo>();

                var query = servicio.ObtenerListaPorNombre(nombre);

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_CiudadVistaModelo entry = new CRD_CiudadVistaModelo()
                        {
                            IdCiudad = item.IdCiudad,
                            NombreCiudad = item.NombreCiudad,
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

        public CRD_CiudadVistaModelo ObtenerElementoPorNombre(string nombre)
        {
            try
            {
                CRD_CiudadVistaModelo result = new CRD_CiudadVistaModelo();

                var query = servicio.ObtenerElementoPorNombre(nombre);

                if (query != null)
                {
                    result = new CRD_CiudadVistaModelo()
                    {
                        IdCiudad = query.IdCiudad,
                        NombreCiudad = query.NombreCiudad,
                        Descripcion = query.Descripcion,
                        Activo = query.Activo
                    };
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return null;
            }
        }

        private CRD_Ciudad MapearVistaEnObjeto(CRD_CiudadVistaModelo vistaModelo, bool agregarId = false)
        {
            CRD_Ciudad entry = new CRD_Ciudad();

            entry.NombreCiudad = vistaModelo.NombreCiudad;
            entry.Descripcion = vistaModelo.Descripcion;
            entry.Activo = vistaModelo.Activo;

            if (agregarId)
            {
                entry.IdCiudad = vistaModelo.IdCiudad;
            }

            return entry;
        }
    }
}
