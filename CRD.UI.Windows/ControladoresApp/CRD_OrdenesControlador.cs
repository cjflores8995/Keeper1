using CRD.APP.Aplicacion.ClaseServicio;
using CRD.UI.Windows.VistaModelo;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.ControladoresApp
{
    public class CRD_OrdenesControlador
    {
        private readonly CRD_OrdenesServicio servicio;

        public CRD_OrdenesControlador()
        {
            servicio = new CRD_OrdenesServicio();
        }

        public List<CRD_OrdenesTablaVistaModelo> ObtenerOrdenesPorNumeroOrden(string nombre)
        {
            try
            {
                List<CRD_OrdenesTablaVistaModelo> result = new List<CRD_OrdenesTablaVistaModelo>();

                var query = servicio.ObtenerOrdenesPorNumeroOrden(nombre);

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_OrdenesTablaVistaModelo entry = new CRD_OrdenesTablaVistaModelo()
                        {
                            ID = item.ID,
                            CodigoSistema = item.CodigoSistema,
                            PersonaReferencia = item.PersonaReferencia,
                            DesCompania = item.DesCompania,
                            ImporteBruto = item.ImporteBruto,
                            Iva = item.Iva,
                            FechaOrden = item.FechaOrden,
                            BienesFacturadosRecib = item.BienesFacturadosRecib,
                            CodProveedorPrincipal = item.CodProveedorPrincipal,
                            NombreProveedorPrincipal = item.NombreProveedorPrincipal,
                            NumeroOrden = item.NumeroOrden,
                            Liberado = item.Liberado,
                            DescProveedor = item.DescProveedor,
                            Compania = item.Compania,
                            Proveedor = item.Proveedor
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
