using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.VistaModelo
{
    public class CRD_ValijasVistaModelo
    {
        public int IdValija { get; set; }
        public int IdBitacora { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Origen { get; set; }
        public string Remitente { get; set; }
        public string Centro { get; set; }
        public string OBSV { get; set; }
        public bool Activo { get; set; }
    }
}
