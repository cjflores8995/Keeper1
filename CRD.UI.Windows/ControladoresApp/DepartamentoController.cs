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
    public class DepartamentoController
    {
        private CRD_DepartamentoServicio servicio;
        public DepartamentoController()
        {
            servicio = new CRD_DepartamentoServicio();
        }
        public bool InsertarDepartamento(CRD_DepartamentoVistaModelo nuevoDepartamentoVistaModelo)
        {
            CRD_Departamento nuevoDepartamento = new CRD_Departamento();
            try
            {
                nuevoDepartamento.NombreDepartamento = nuevoDepartamentoVistaModelo.NombreDepartamento;
                nuevoDepartamento.Descripcion = nuevoDepartamentoVistaModelo.Descripcion;
                nuevoDepartamento.Activo = nuevoDepartamentoVistaModelo.Activo;
                servicio.Add(nuevoDepartamento);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public bool EliminarDepartamento(int id)
        {

            try
            {
                servicio.Delete(id);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public bool ActualizarDepartamento(CRD_DepartamentoVistaModelo nuevoDepartamentoVistaModelo)
        {
            CRD_Departamento nuevoDepartamento = new CRD_Departamento(); //objeto de la BD
            try
            {
                nuevoDepartamento.NombreDepartamento = nuevoDepartamentoVistaModelo.NombreDepartamento;
                nuevoDepartamento.Descripcion = nuevoDepartamentoVistaModelo.Descripcion;
                nuevoDepartamento.Activo = nuevoDepartamentoVistaModelo.Activo;
                nuevoDepartamento.IdDepartamento = nuevoDepartamentoVistaModelo.IdDepartamento;
                servicio.Modify(nuevoDepartamento);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public IEnumerable<CRD_DepartamentoVistaModelo> ListarDepartamento()
        {
            var listaDepartamento = servicio.ObtenerElementosActivos();
            List<CRD_DepartamentoVistaModelo> listaVistaModelo = new List<CRD_DepartamentoVistaModelo>();
            foreach (var item in listaDepartamento)
            {
                listaVistaModelo.Add(new CRD_DepartamentoVistaModelo
                {
                    IdDepartamento = item.IdDepartamento,
                    NombreDepartamento = item.NombreDepartamento,
                    Descripcion = item.Descripcion,
                    Activo = item.Activo,
                });
            }
            return listaVistaModelo;
        }
    }
}
