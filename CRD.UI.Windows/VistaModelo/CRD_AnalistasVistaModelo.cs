using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.VistaModelo
{
    public class CRD_AnalistasVistaModelo
    {
        public int IdAnalista { get; set; }
        public int IdEstadoTipoProceso { get; set; }
        public string UsuarioLN { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
    }
}
