using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Infraestructura.CrossCuting.Cache
{
    public static class UsuarioLoginCache
    {
        public static int Id { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Email { get; set; }
        public static string NombreUsuario { get; set; }
        public static int IdCargo { get; set; }
    }
}
