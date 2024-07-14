using CRD.Dominio.Modelo.Entidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.Dominio.Modelo.Abstracciones
{
    public interface ICRD_UsuariosRepositorio: IBaseRepositorio<CRD_Usuarios>
    {
        CRD_Usuarios ObtenerUsuarioPorEmail(string email);

        CRD_Usuarios ObtenerUsuarioPorNombreUsuario(string nombreUsuario);
        CRD_Usuarios ObtenerUsuarioPorId(int id);
        bool LoginUsuario(string usuario, string password);

        List<CRD_Usuarios> ObtenerElementosActivos();

        bool EliminadoLogico(int id);

        bool InsertarUsuario(CRD_Usuarios obj);

        bool ActualizarUsuario(CRD_Usuarios obj);

        bool ActualizarUsuarioPassword(CRD_Usuarios entity);
        bool LoginUsuarioConEmail(string email, string password);
    }
}
