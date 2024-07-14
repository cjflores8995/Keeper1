using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.VistaModelo
{
    public class CRD_UsuariosTablaVistaModelo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }
        public int Cargo { get; set; }
        public int Departamento { get; set; }
        public int Ciudad { get; set; }
    }
}
