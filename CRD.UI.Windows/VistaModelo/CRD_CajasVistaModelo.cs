using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.VistaModelo
{
    public class CRD_CajasVistaModelo
    {
        public int IdCaja { get; set; }
        public string NombreCaja { get; set; }
        public string Descripcion { get; set; }
        public Nullable<bool> EstatusCaja { get; set; }
        public bool Activo { get; set; }
    }
}
