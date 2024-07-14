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
    public class CRD_CargoControlador
    {
        private readonly CRD_CargoServicio servicio;

        public CRD_CargoControlador()
        {
            servicio = new CRD_CargoServicio();
        }

        public bool Insertar(CRD_CargoVistaModelo obj)
        {
            try
            {
                CRD_Cargo entry = MapearVistaEnObjeto(obj);

                servicio.Add(entry);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Actualizar(CRD_CargoVistaModelo obj)
        {
            try
            {
                CRD_Cargo entry = MapearVistaEnObjeto(obj, agregarId: true);

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

        public List<CRD_CargoVistaModelo> ListarTodo()
        {
            try
            {
                List<CRD_CargoVistaModelo> result = new List<CRD_CargoVistaModelo>();

                var query = servicio.ObtenerElementosActivos();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_CargoVistaModelo entry = new CRD_CargoVistaModelo()
                        {
                            IdCargo = item.IdCargo,
                            NombreCargo = item.NombreCargo,
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

        public List<CRD_CargoVistaModelo> ObtenerListaPorNombre(string nombre)
        {
            try
            {
                List<CRD_CargoVistaModelo> result = new List<CRD_CargoVistaModelo>();

                var query = servicio.ObtenerListaPorNombre(nombre);

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_CargoVistaModelo entry = new CRD_CargoVistaModelo()
                        {
                            IdCargo = item.IdCargo,
                            NombreCargo = item.NombreCargo,
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

        public CRD_CargoVistaModelo ObtenerElementoPorNombre(string nombre)
        {
            try
            {
                CRD_CargoVistaModelo result = new CRD_CargoVistaModelo();

                var query = servicio.ObtenerElementoPorNombre(nombre);

                if (query != null)
                {
                    result = new CRD_CargoVistaModelo()
                    {
                        IdCargo = query.IdCargo,
                        NombreCargo = query.NombreCargo,
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

        private CRD_Cargo MapearVistaEnObjeto(CRD_CargoVistaModelo vistaModelo, bool agregarId = false)
        {
            CRD_Cargo entry = new CRD_Cargo();

            entry.NombreCargo = vistaModelo.NombreCargo;
            entry.Descripcion = vistaModelo.Descripcion;
            entry.Activo = vistaModelo.Activo;

            if (agregarId)
            {
                entry.IdCargo = vistaModelo.IdCargo;
            }

            return entry;
        }
    }
}
