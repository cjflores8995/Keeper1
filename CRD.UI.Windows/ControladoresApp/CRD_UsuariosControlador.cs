using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;
using CRD.Infraestructura.CrossCuting.Messages;
using CRD.UI.Windows.VistaModelo;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.ControladoresApp
{
    public class CRD_UsuariosControlador
    {
        private readonly CRD_UsuariosServicio servicio;

        public CRD_UsuariosControlador()
        {
            servicio = new CRD_UsuariosServicio();
        }

        public bool LoginUsuario(string usuario, string password)
        {
            return servicio.LoginUsuario(usuario, password);
        }

        public bool LoginUsuarioConEmail(string email, string password)
        {
            return servicio.LoginUsuarioConEmail(email, password);
        }

        public bool Insertar(CRD_UsuariosVistaModelo obj)
        {
            try
            {
                CRD_Usuarios entry = MapearVistaEnObjeto(obj);

                servicio.Add(entry);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Actualizar(CRD_UsuariosVistaModelo obj)
        {
            try
            {
                CRD_Usuarios entry = MapearVistaEnObjeto(obj, agregarId: true);

                servicio.ActualizarUsuario(entry);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool SetearPasswordPorDefecto(CRD_UsuariosVistaModelo obj)
        {
            try
            {
                CRD_Usuarios entry = new CRD_Usuarios()
                {
                    Id = obj.Id,
                    PasswordHash = Funcionalidades.ConvertirStringEnSHA256(obj.PasswordHash),
                };

                servicio.ActualizarUsuarioPassword(entry);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }


        public List<CRD_UsuariosTablaVistaModelo> ListarTodo()
        {
            try
            {
                List<CRD_UsuariosTablaVistaModelo> result = new List<CRD_UsuariosTablaVistaModelo>();

                var query = servicio.ObtenerElementosActivos();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_UsuariosTablaVistaModelo entry = new CRD_UsuariosTablaVistaModelo()
                        {
                            Id = item.Id,
                            Nombre = item.Nombre,
                            Apellido = item.Apellido,
                            NombreUsuario = item.NombreUsuario,
                            Email = item.Email,
                            Cargo = item.CRD_Cargo.IdCargo,
                            Departamento = item.CRD_Departamento.IdDepartamento,
                            Ciudad = item.CRD_Ciudad.IdCiudad
                        };

                        result.Add(entry);
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return null;
            }
        }


        public CRD_UsuariosVistaModelo ObtenerUsuarioPorEmail(string email)
        {
            try
            {
                CRD_UsuariosVistaModelo result = new CRD_UsuariosVistaModelo();

                var query = servicio.ObtenerUsuarioPorEmail(email);

                if (query != null)
                {
                    result  = new CRD_UsuariosVistaModelo()
                    {
                        Id = query.Id,
                        Email = query.Email
                    };
                }

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return null;
            }
        }

        private CRD_Usuarios MapearVistaEnObjeto(CRD_UsuariosVistaModelo vistaModelo, bool agregarId = false)
        {
            CRD_Usuarios resultado = new CRD_Usuarios();
            resultado.Nombre = vistaModelo.Nombre;
            resultado.Apellido = vistaModelo.Apellido;
            resultado.FechaRegistro = DateTime.Now;
            resultado.FechaUltimoAcceso = new DateTime(2999, 12, 12);
            resultado.Email = vistaModelo.Email;
            resultado.PasswordHash = Funcionalidades.ConvertirStringEnSHA256(vistaModelo.PasswordHash);
            resultado.NombreUsuario = vistaModelo.NombreUsuario;
            resultado.IdCargo = vistaModelo.IdCargo;
            resultado.IdDepartamento = vistaModelo.IdDepartamento;
            resultado.IdCiudad = vistaModelo.IdCiudad;

            resultado.Activo = true;

            if (agregarId)
            {
                resultado.Id = vistaModelo.Id;
            }

            return resultado;
        }

        public bool Eliminar(int idObj)
        {
            try
            {
                var resultado = servicio.Delete(idObj);
                return resultado;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
