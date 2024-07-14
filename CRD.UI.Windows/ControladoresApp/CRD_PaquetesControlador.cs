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
    public class CRD_PaquetesControlador
    {
        private readonly CRD_PaquetesServicio servicio;

        public CRD_PaquetesControlador()
        {
            servicio = new CRD_PaquetesServicio();
        }

        public bool Insertar(CRD_PaquetesVistaModelo obj)
        {
            try
            {
                CRD_Paquetes entry = MapearVistaEnObjeto(obj);

                servicio.Add(entry);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Actualizar(CRD_PaquetesVistaModelo obj)
        {
            try
            {
                CRD_Paquetes entry = MapearVistaEnObjeto(obj, agregarId: true);

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

        public List<CRD_PaquetesVistaModelo> ListarTodo()
        {
            try
            {
                List<CRD_PaquetesVistaModelo> result = new List<CRD_PaquetesVistaModelo>();

                var query = servicio.ObtenerElementosActivos();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_PaquetesVistaModelo entry = new CRD_PaquetesVistaModelo()
                        {
                            IdPaquete = item.IdPaquete,
                            NombrePaquete = item.NombrePaquete,
                            Descripcion = item.Descripcion,
                            EstatusPaquete = item.EstatusPaquete,
                            Activo = item.Activo,
                            IdCajas = item.CRD_Cajas.IdCaja
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



        private CRD_Paquetes MapearVistaEnObjeto(CRD_PaquetesVistaModelo vistaModelo, bool agregarId = false)
        {
            CRD_Paquetes entry = new CRD_Paquetes();

            entry.NombrePaquete = vistaModelo.NombrePaquete;
            entry.Descripcion = vistaModelo.Descripcion;
            entry.EstatusPaquete = vistaModelo.EstatusPaquete;
            entry.Activo = vistaModelo.Activo;
            entry.IdCaja = vistaModelo.IdCajas;

            if (agregarId)
            {
                entry.IdPaquete = vistaModelo.IdPaquete;
            }

            return entry;
        }
    }
}
