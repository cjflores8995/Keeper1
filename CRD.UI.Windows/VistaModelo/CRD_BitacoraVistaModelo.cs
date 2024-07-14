using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.VistaModelo
{
    public class CRD_BitacoraVistaModelo
    {

        public int IdBitacora { get; set; }
        public string NumeroDocumentoPago { get; set; }
        public Nullable<bool> EstadoBienesRecibidos { get; set; }
        public Nullable<System.DateTime> FechaEmisionDocumento { get; set; }
        public Nullable<System.DateTime> FechaRecepcionDocumento { get; set; }
        public Nullable<decimal> IvaDocumento { get; set; }
        public string Observaciones { get; set; }
        public Nullable<decimal> ValorTotal { get; set; }
        public string TipoOrden { get; set; }



    }
}
