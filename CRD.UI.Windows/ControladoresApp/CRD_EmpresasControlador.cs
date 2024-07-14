using CRD.APP.Aplicacion.ClaseServicio;
using CRD.Dominio.Modelo.Entidades;
using CRD.UI.Windows.VistaModelo;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRD.UI.Windows.ControladorAplicacion
{
    public class CRD_EmpresasControlador
    {
        private readonly CRD_EmpresasServicio servicio;

        public CRD_EmpresasControlador()
        {
            servicio = new CRD_EmpresasServicio();
        }

        public bool Insertar(CRD_EmpresasVistaModelo obj)
        {
            try
            {
                CRD_Empresas entry = MapearVistaEnObjeto(obj);

                servicio.Add(entry);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool Actualizar(CRD_EmpresasVistaModelo obj)
        {
            try
            {
                CRD_Empresas entry = MapearVistaEnObjeto(obj, agregarId: true);

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

        public List<CRD_EmpresasVistaModelo> ListarTodo()
        {
            try
            {
                List<CRD_EmpresasVistaModelo> result = new List<CRD_EmpresasVistaModelo>();

                var query = servicio.ObtenerElementosActivos();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_EmpresasVistaModelo entry = new CRD_EmpresasVistaModelo()
                        {
                            IdEmpresa = item.IdEmpresa,
                            CodigoEmpresa = item.CodigoEmpresa,
                            Nombre = item.Nombre,
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

        private CRD_Empresas MapearVistaEnObjeto(CRD_EmpresasVistaModelo vistaModelo, bool agregarId = false)
        {
            CRD_Empresas entry = new CRD_Empresas();

            entry.CodigoEmpresa = vistaModelo.CodigoEmpresa;
            entry.Nombre = vistaModelo.Nombre;
            entry.Descripcion = vistaModelo.Descripcion;
            entry.Activo = vistaModelo.Activo;

            if (agregarId)
            {
                entry.IdEmpresa = vistaModelo.IdEmpresa;
            }

            return entry;
        }
    }
}
