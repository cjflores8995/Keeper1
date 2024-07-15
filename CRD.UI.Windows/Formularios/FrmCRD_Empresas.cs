using CRD.Infraestructura.CrossCuting.Messages;
using CRD.UI.Windows.ControladorAplicacion;
using CRD.UI.Windows.ControladoresApp;
using CRD.UI.Windows.VistaModelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRD.UI.Windows.Formularios
{
    public partial class FrmCRD_Empresas : Form
    {
        private CRD_EmpresasControlador controlador;
        private CRD_EmpresasVistaModelo vistaModelo;


        public FrmCRD_Empresas()
        {
            InitializeComponent();
            controlador = new CRD_EmpresasControlador();
            vistaModelo = new CRD_EmpresasVistaModelo();
            ListarRegistros();
            this.StartPosition = FormStartPosition.CenterParent;
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private CRD_EmpresasVistaModelo CrearObjeto(bool incluirId = false)
        {
            CRD_EmpresasVistaModelo resultado = new CRD_EmpresasVistaModelo();
            resultado.Nombre = txtNombre.Text;
            resultado.CodigoEmpresa = txtCodigo.Text;
            resultado.Descripcion = txtDescripcion.Text;
            resultado.Activo = true;

            if (incluirId)
            {
                resultado.IdEmpresa = int.Parse(txtIdEmpresas.Text);
            }

            return resultado;

        }
        private void Insertar(CRD_EmpresasVistaModelo vistaModelo)
        {
            var resultado = controlador.Insertar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);
            Funcionalidades.LimpiarCampos(this);
        }

        private bool Actualizar(CRD_EmpresasVistaModelo vistaModelo)
        {
            var resultado = controlador.Actualizar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);
            Funcionalidades.LimpiarCampos(this);
            return resultado;         
        }

        private void InsertUpdate()
        {
            if (string.IsNullOrEmpty(txtIdEmpresas.Text))
            {
                vistaModelo = CrearObjeto();
                Insertar(vistaModelo);
                ListarRegistros();
            }
            else
            {
                var resultado = MessageBox.Show(CustomMessages.ConfirmacionActualizacion, "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    vistaModelo = CrearObjeto(true);
                    bool result = Actualizar(vistaModelo);
                    if (result)
                    {
                        Funcionalidades.LimpiarCampos(this);
                        ListarRegistros();
                    }
                }
                else
                {
                    Funcionalidades.LimpiarCampos(this);
                }
            }
        }


        private void ListarRegistros()
        {
            dgvLista.DataSource = controlador.ListarTodo();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                CustomMessages.DebesLlenarCamposRequeridos();
            }
            else
            {
                InsertUpdate();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdEmpresas.Text))
            {
                CustomMessages.DebesSeleccionarRegistro();
            }
            else
            {
                var confirmacion = MessageBox.Show(CustomMessages.ConfirmacionEliminacion, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    int id = int.Parse(txtIdEmpresas.Text);
                    var resultado = controlador.Eliminar(id);
                    CustomMessages.RespuestaProcesoDb(resultado);
                    ListarRegistros();
                    Funcionalidades.LimpiarCampos(this);
                }
                else
                {

                    Funcionalidades.LimpiarCampos(this);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Funcionalidades.LimpiarCampos(this);
        }

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvLista.Rows[e.RowIndex];

                txtIdEmpresas.Text = fila.Cells[0].Value.ToString();
                txtCodigo.Text = fila.Cells[1].Value.ToString();
                txtNombre.Text = fila.Cells[2].Value.ToString();
                txtDescripcion.Text = fila.Cells[3].Value.ToString();


                fila.Cells[0].ReadOnly = true;
                fila.Cells[1].ReadOnly = true;
                fila.Cells[2].ReadOnly = true;
                fila.Cells[3].ReadOnly = true;
            }
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscador.Text))
            {
                string valor = txtBuscador.Text;
                dgvLista.DataSource = controlador.BuscarNombre(valor);
            }
        }
    }
}
