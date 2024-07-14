using CRD.APP.Aplicacion.ClaseServicio;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.ControladoresApp
{
    public class CRD_ProveedoresControlador
    {
        private readonly CRD_ProveedoresServicio servicio;

        public CRD_ProveedoresControlador()
        {
            servicio = new CRD_ProveedoresServicio();
        }

        public IEnumerable<CRD_ProveedoresTablaVistaModelo> ListarTodo()
        {
            try
            {
                List<CRD_ProveedoresTablaVistaModelo> result = new List<CRD_ProveedoresTablaVistaModelo>();

                var query = servicio.GetAll();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_ProveedoresTablaVistaModelo entry = new CRD_ProveedoresTablaVistaModelo()
                        {
                            RucCedula = item.RucCedula,
                            CodProveedor = item.CodProveedor,
                            RazonSocial = item.RazonSocial,
                            Telefono = item.Telefono,
                            Ciudad = item.Ciudad,
                            Estado2 = item.Estado2,
                            CodCondionesPago = item.CodCondicionesPago
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


        public List<CRD_ProveedoresTablaVistaModelo> ObtenerProveedoresPorRucCedula(string RucCedula)
        {
            try
            {
                List<CRD_ProveedoresTablaVistaModelo> result = new List<CRD_ProveedoresTablaVistaModelo>();

                var query = servicio.ObtenerProveedoresPorRUC(RucCedula);

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_ProveedoresTablaVistaModelo entry = new CRD_ProveedoresTablaVistaModelo()
                        {
                            RucCedula = item.RucCedula,
                            CodProveedor = item.CodProveedor,
                            RazonSocial = item.RazonSocial,
                            Telefono = item.Telefono,
                            Ciudad = item.Ciudad,
                            Estado2 = item.Estado2,
                            CodCondionesPago = item.CodCondicionesPago
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

        public List<CRD_ProveedoresTablaVistaModelo> ObtenerProveedoresPorRazonSocial(string razonSocial)
        {
            try
            {
                List<CRD_ProveedoresTablaVistaModelo> result = new List<CRD_ProveedoresTablaVistaModelo>();

                var query = servicio.ObtenerProveedoresPorRazonSocial(razonSocial);

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_ProveedoresTablaVistaModelo entry = new CRD_ProveedoresTablaVistaModelo()
                        {
                            RucCedula = item.RucCedula,
                            CodProveedor = item.CodProveedor,
                            RazonSocial = item.RazonSocial,
                            Telefono = item.Telefono,
                            Ciudad = item.Ciudad,
                            Estado2 = item.Estado2,
                            CodCondionesPago = item.CodCondicionesPago
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

        public List<CRD_ProveedoresTablaVistaModelo> ObtenerProveedoresPorCodProveedores(string codProveedor)
        {
            try
            {
                List<CRD_ProveedoresTablaVistaModelo> result = new List<CRD_ProveedoresTablaVistaModelo>();

                var query = servicio.ObtenerProveedoresPorCodProveedor(codProveedor);

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_ProveedoresTablaVistaModelo entry = new CRD_ProveedoresTablaVistaModelo()
                        {
                            RucCedula = item.RucCedula,
                            CodProveedor = item.CodProveedor,
                            RazonSocial = item.RazonSocial,
                            Telefono = item.Telefono,
                            Ciudad = item.Ciudad,
                            Estado2 = item.Estado2,
                            CodCondionesPago = item.CodCondicionesPago
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
