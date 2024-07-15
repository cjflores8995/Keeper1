using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;
using CRD.UI.Windows.VistaModelo;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.ControladoresApp
{
    public class CRD_DepartamentoControlador
    {
        private readonly CRD_DepartamentoServicio servicio;

        public CRD_DepartamentoControlador()
        {
            servicio = new CRD_DepartamentoServicio();
        }

        public bool Insertar(CRD_DepartamentoVistaModelo obj)
        {
            try
            {
                CRD_Departamento entry = MapearVistaEnObjeto(obj);

                servicio.Add(entry);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }



        public bool Actualizar(CRD_DepartamentoVistaModelo obj)
        {
            try
            {
                CRD_Departamento entry = MapearVistaEnObjeto(obj, agregarId: true);

                servicio.Modify(entry);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Eliminar(int idObj)
        {
            try
            {
                servicio.Delete(idObj);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public List<CRD_DepartamentoVistaModelo> ListarTodo()
        {
            try
            {
                List<CRD_DepartamentoVistaModelo> result = new List<CRD_DepartamentoVistaModelo>();

                var query = servicio.ObtenerElementosActivos();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_DepartamentoVistaModelo entry = new CRD_DepartamentoVistaModelo()
                        {
                            IdDepartamento = item.IdDepartamento,
                            NombreDepartamento = item.NombreDepartamento,
                            Descripcion = item.Descripcion,
                            Activo = item.Activo
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

        public CRD_DepartamentoVistaModelo ObtenerElementoPorNombre(string nombre)
        {
            try
            {
                CRD_DepartamentoVistaModelo result = new CRD_DepartamentoVistaModelo();

                var query = servicio.ObtenerElementoPorNombre(nombre);

                if (query != null)
                {
                    result = new CRD_DepartamentoVistaModelo()
                    {
                        IdDepartamento = query.IdDepartamento,
                        NombreDepartamento = query.NombreDepartamento,
                        Descripcion = query.Descripcion,
                        Activo = query.Activo
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

        public List<CRD_DepartamentoVistaModelo> Buscar(string nombre)
        {
            try
            {
                List<CRD_DepartamentoVistaModelo> result = new List<CRD_DepartamentoVistaModelo>();

                var query = servicio.ObtenerElementosActivos();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        if (item.NombreDepartamento == nombre)

                        {
                            CRD_DepartamentoVistaModelo entry = new CRD_DepartamentoVistaModelo()
                            {
                                IdDepartamento = item.IdDepartamento,
                                NombreDepartamento = item.NombreDepartamento,
                                Descripcion = item.Descripcion,
                                Activo = item.Activo
                            };
                            result.Add(entry);
                        }
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

        private CRD_Departamento MapearVistaEnObjeto(CRD_DepartamentoVistaModelo vistaModelo, bool agregarId = false)
        {
            CRD_Departamento entry = new CRD_Departamento();

            entry.NombreDepartamento = vistaModelo.NombreDepartamento;
            entry.Descripcion = vistaModelo.Descripcion;
            entry.Activo = vistaModelo.Activo;

            if (agregarId)
            {
                entry.IdDepartamento = vistaModelo.IdDepartamento;
            }

            return entry;
        }
    }
}
