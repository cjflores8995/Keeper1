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
    public class CRD_BitacoraControlador
    {


        private CRD_BitacoraServicio bitacora_SC;
        private CRD_EstadoTipoProcesos bitacora_VM;

        public CRD_BitacoraControlador()
        {
            bitacora_SC = new CRD_BitacoraServicio();
            bitacora_VM = new CRD_EstadoTipoProcesos();
        }

        public bool InsertarBitacora(CRD_BitacoraVistaModelo nuevaBitacoraVistaModelo)
        {
            CRD_Bitacora nuevaBitacora = new CRD_Bitacora(); //objeto de la BD
            try
            {
                nuevaBitacora.IdBitacora = nuevaBitacoraVistaModelo.IdBitacora;
                nuevaBitacora.NumeroDocumentoPago = nuevaBitacoraVistaModelo.NumeroDocumentoPago;
                nuevaBitacora.EstadoBienesRecibidos = nuevaBitacoraVistaModelo.EstadoBienesRecibidos;
                nuevaBitacora.FechaEmisionDocumento = nuevaBitacoraVistaModelo.FechaEmisionDocumento;
                nuevaBitacora.FechaRecepcionDocumento = nuevaBitacoraVistaModelo.FechaRecepcionDocumento;
                nuevaBitacora.IvaDocumento = nuevaBitacoraVistaModelo.IvaDocumento;
                nuevaBitacora.Observaciones = nuevaBitacoraVistaModelo.Observaciones;
                nuevaBitacora.ValorTotal = nuevaBitacoraVistaModelo.ValorTotal;
                nuevaBitacora.TipoOrden = nuevaBitacoraVistaModelo.TipoOrden;
                bitacora_SC.AddBitacora(nuevaBitacora);
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }

        }

        public IEnumerable<CRD_BitacoraVistaModelo> ListarBitacora()
        {
            var listabitacora = bitacora_SC.ListarTodo();
            List<CRD_BitacoraVistaModelo> listabitacoraVistaModelo = new List<CRD_BitacoraVistaModelo>();
            foreach (var item in listabitacora)
            {
                listabitacoraVistaModelo.Add(new CRD_BitacoraVistaModelo
                {
                    IdBitacora = item.IdBitacora,
                    NumeroDocumentoPago = item.NumeroDocumentoPago,
                    EstadoBienesRecibidos = item.EstadoBienesRecibidos,
                    FechaEmisionDocumento = item.FechaEmisionDocumento,
                    FechaRecepcionDocumento = item.FechaRecepcionDocumento,
                    IvaDocumento = item.IvaDocumento,
                    Observaciones = item.Observaciones,
                    ValorTotal = item.ValorTotal,
                    TipoOrden = item.TipoOrden,
                });
            }
            return listabitacoraVistaModelo;
        }
    }
}
