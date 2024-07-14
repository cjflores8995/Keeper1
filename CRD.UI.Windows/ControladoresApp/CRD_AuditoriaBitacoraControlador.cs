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
    public class CRD_AuditoriaBitacoraControlador
    {
        private readonly CRD_AuditoriaBitacoraServicio servicio;

        public CRD_AuditoriaBitacoraControlador()
        {
            servicio = new CRD_AuditoriaBitacoraServicio();
        }

        public List<CRD_AuditoriaBitacoraVistaModelo> ListarTodo()
        {
            try
            {
                List<CRD_AuditoriaBitacoraVistaModelo> result = new List<CRD_AuditoriaBitacoraVistaModelo>();

                var query = servicio.GetAll();

                if (query.Any())
                {
                    foreach (var item in query)
                    {
                        CRD_AuditoriaBitacoraVistaModelo entry = new CRD_AuditoriaBitacoraVistaModelo()
                        {
                            IdAuditoriaBitacora = item.IdAuditoriaBitacora,
                            NombreUsuario = item.CRD_Usuarios.NombreUsuario,
                            NombreTabla = item.NombreTabla,
                            FechaModificacion = item.FechaModificacion,
                            RegistroHistorico = item.RegistroHistorico
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
    }
}
