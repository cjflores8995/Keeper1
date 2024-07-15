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
    public class CRD_IvaControlador
    {
        private readonly CRD_IvaServicio servicio;

        public CRD_IvaControlador()
        {
            servicio = new CRD_IvaServicio();
        }

        public bool Insertar(CRD_IvaVistaModelo obj)
        {
            try
            {
                CRD_Iva entry = MapearVistaEnObjeto(obj);

                servicio.Add(entry);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Actualizar(CRD_IvaVistaModelo obj)
        {
            try
            {
                CRD_Iva entry = MapearVistaEnObjeto(obj, agregarId: true);

                servicio.Modify(entry);
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool EstablecerIvaPrincipal(int id)
        {
            try
            {
                return servicio.EstablecerIvaPrincipal(id);
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

        public List<CRD_IvaVistaModelo> ListarTodo()
        {
            try
            {
                List<CRD_IvaVistaModelo> result = new List<CRD_IvaVistaModelo>();

                var query = servicio.ObtenerElementosActivos();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_IvaVistaModelo entry = new CRD_IvaVistaModelo()
                        {
                            IdIva = item.IdIva,
                            ValorIva = item.ValorIva,
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

        public CRD_IvaVistaModelo buscarPorValor(string valor)
        {
            try
            {
                CRD_IvaVistaModelo result = new CRD_IvaVistaModelo();

                var item = servicio.buscarPorValor(valor);

                if (item != null)
                {
                    CRD_IvaVistaModelo entry = new CRD_IvaVistaModelo()
                    {
                        IdIva = item.IdIva,
                        ValorIva = item.ValorIva,
                        Activo = item.Activo
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

        private CRD_Iva MapearVistaEnObjeto(CRD_IvaVistaModelo vistaModelo, bool agregarId = false)
        {
            CRD_Iva entry = new CRD_Iva();

            entry.ValorIva = vistaModelo.ValorIva;
            entry.Activo = vistaModelo.Activo;

            if (agregarId)
            {
                entry.IdIva = vistaModelo.IdIva;
            }

            return entry;
        }
    }
}
