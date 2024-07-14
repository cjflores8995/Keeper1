using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.VistaModelo
{
    public class CRD_AuditoriaBitacoraVistaModelo
    {
        public int IdAuditoriaBitacora { get; set; }
        public string NombreUsuario { get; set; }
        public string NombreTabla { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string RegistroHistorico { get; set; }
    }
}
