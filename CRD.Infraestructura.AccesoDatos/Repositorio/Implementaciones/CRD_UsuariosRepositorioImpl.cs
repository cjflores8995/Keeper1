using CRD.Dominio.Modelo.Abstracciones;
using CRD.Dominio.Modelo.Entidades;
using CRD.Infraestructura.CrossCuting.Cache;
using CRD.Infraestructura.CrossCuting.Messages;

using Microsoft.AspNet.Identity;

using System;
using System.Collections.Generic;
using System.Linq;

namespace CRD.Infraestructura.AccesoDatos.Repositorio.Implementaciones
{
    public class CRD_UsuariosRepositorioImpl : BaseRepositorioImpl<CRD_Usuarios>, ICRD_UsuariosRepositorio
    {
        public CRD_Usuarios ObtenerUsuarioPorEmail(string email)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    var result = (from obj in db.CRD_Usuarios
                                  where obj.Email.ToLower().Equals(email.ToLower())
                                  select obj).FirstOrDefault();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public CRD_Usuarios ObtenerUsuarioPorId(int id)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    var result = db.CRD_Usuarios.FirstOrDefault(x => x.Id == id);

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public bool LoginUsuario(string usuario, string password)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    CRD_Usuarios usuarioDb = db.CRD_Usuarios.FirstOrDefault(x => x.NombreUsuario.ToLower() == usuario.ToLower().Trim() && x.Activo == true);

                    if (usuarioDb == null)
                    {
                        return false;
                    }
                    else
                    {
                        string paswordHash = Funcionalidades.ConvertirStringEnSHA256(password);

                        if (usuarioDb.PasswordHash.ToLower().Equals(paswordHash))
                        {
                            UsuarioLoginCache.Id = usuarioDb.Id;
                            UsuarioLoginCache.Nombre = usuarioDb.Nombre;
                            UsuarioLoginCache.Apellido = usuarioDb.Apellido;
                            UsuarioLoginCache.NombreUsuario = usuarioDb.NombreUsuario;
                            UsuarioLoginCache.IdCargo = usuarioDb.IdCargo;

                            usuarioDb.FechaUltimoAcceso = DateTime.Now;
                            db.SaveChanges();

                            return true;
                        } else
                        {
                            return false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public bool LoginUsuarioConEmail(string email, string password)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    CRD_Usuarios usuarioDb = db.CRD_Usuarios.FirstOrDefault(x => x.Email.ToLower() == email.ToLower().Trim() && x.Activo == true);

                    if (usuarioDb == null)
                    {
                        return false;
                    }
                    else
                    {
                        string paswordHash = password;

                        if (usuarioDb.PasswordHash.ToLower().Equals(paswordHash))
                        {
                            UsuarioLoginCache.Id = usuarioDb.Id;
                            UsuarioLoginCache.Nombre = usuarioDb.Nombre;
                            UsuarioLoginCache.Apellido = usuarioDb.Apellido;
                            UsuarioLoginCache.NombreUsuario = usuarioDb.NombreUsuario;
                            UsuarioLoginCache.IdCargo = usuarioDb.IdCargo;

                            usuarioDb.PasswordHash = paswordHash;
                            usuarioDb.FechaUltimoAcceso = DateTime.Now;
                            db.SaveChanges();

                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }


        public List<CRD_Usuarios> ObtenerElementosActivos()
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {

                    return db.CRD_Usuarios.Include("CRD_Departamento").Include("CRD_Cargo").Include("CRD_Ciudad").Where(x => x.Activo == true).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public bool EliminadoLogico(int id)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    var elemento = db.CRD_Usuarios.FirstOrDefault(x => x.Id == id && x.CRD_Cargo.NombreCargo.ToLower() != "administrador");

                    if (elemento != null)
                    {
                        elemento.Activo = false;
                        var result = db.SaveChanges();

                        return result > 0;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public bool InsertarUsuario(CRD_Usuarios obj)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    var usuarioExistente = db.CRD_Usuarios.FirstOrDefault(x => x.Email.ToLower() == obj.Email.ToLower() || x.NombreUsuario.ToLower() == obj.NombreUsuario.ToLower());

                    if(usuarioExistente != null)
                    {
                        throw new Exception("El suuario ingresado ya existe.");
                    }

                    obj.CRD_Cargo = db.CRD_Cargo.FirstOrDefault(x => x.IdCargo == obj.IdCargo);
                    obj.CRD_Ciudad = db.CRD_Ciudad.FirstOrDefault(x => x.IdCiudad == obj.IdCiudad);
                    obj.CRD_Departamento = db.CRD_Departamento.FirstOrDefault(x => x.IdDepartamento == obj.IdDepartamento);


                    var usuario = db.CRD_Usuarios.Add(obj);
                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede insertar al usuario", ex);
            }
        }

        public bool ActualizarUsuario(CRD_Usuarios obj)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    var usuario = db.CRD_Usuarios.FirstOrDefault(x => x.Id == obj.Id);

                    if(usuario == null)
                    {
                        return false;

                    }

                    usuario.CRD_Cargo = db.CRD_Cargo.FirstOrDefault(x => x.IdCargo == obj.IdCargo);
                    usuario.CRD_Ciudad = db.CRD_Ciudad.FirstOrDefault(x => x.IdCiudad == obj.IdCiudad);
                    usuario.CRD_Departamento = db.CRD_Departamento.FirstOrDefault(x => x.IdDepartamento == obj.IdDepartamento);

                    usuario.Nombre = obj.Nombre;
                    usuario.Apellido = obj.Apellido;
                    usuario.IdCargo = obj.IdCargo;
                    usuario.IdDepartamento = obj.IdDepartamento;
                    usuario.IdCiudad = obj.IdCiudad;
                    usuario.Email = obj.Email;

                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }

        public bool ActualizarUsuarioPassword(CRD_Usuarios obj)
        {
            try
            {
                using (var db = new SRGI_4Entities())
                {
                    var usuario = db.CRD_Usuarios.FirstOrDefault(x => x.Id == obj.Id);

                    if (usuario == null)
                    {
                        return false;

                    }

                    usuario.PasswordHash = obj.PasswordHash;

                    return db.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede devolver el resultado", ex);
            }
        }
    }
}
