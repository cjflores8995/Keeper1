using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.VistaModelo
{
    public class CRD_UsuariosVistaModelo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public System.DateTime FechaUltimoAcceso { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Telefono { get; set; }
        public string NombreUsuario { get; set; }
        public bool Activo { get; set; }
        public int IdCargo { get; set; }
        public int IdDepartamento { get; set; }
        public int IdCiudad { get; set; }
    }
}
