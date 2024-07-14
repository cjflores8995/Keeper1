using CRD.Infraestructura.CrossCuting.Messages;
using CRD.UI.Windows.ControladorAplicacion;
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
    public partial class FrmCRD_EstadoTipoProcesos : Form
    {
        private CRD_EstadoTipoProcesosControlador controlador;
        private CRD_EstadoTipoProcesosVistaModelo vistaModelo;

        private static FrmCRD_EstadoTipoProcesos instancia = null;
        public static FrmCRD_EstadoTipoProcesos VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new FrmCRD_EstadoTipoProcesos();
                return instancia;
            }
            return instancia;
        }

        public FrmCRD_EstadoTipoProcesos()
        {
            InitializeComponent();
            controlador = new CRD_EstadoTipoProcesosControlador();
            vistaModelo = new CRD_EstadoTipoProcesosVistaModelo();
            ListarRegistros();
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormClosed += new FormClosedEventHandler(FrmCRD_FormClosed);
        }

        private void FrmCRD_FormClosed(object sender, FormClosedEventArgs e)
        {
            instancia = null;
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
        private CRD_EstadoTipoProcesosVistaModelo CrearObjeto(bool incluirId = false)
        {
            CRD_EstadoTipoProcesosVistaModelo resultado = new CRD_EstadoTipoProcesosVistaModelo();
            resultado.Nombre = txtNombre.Text;
            resultado.Descripcion = txtDescripcion.Text;
            resultado.Activo = chkEstado.Checked;

            if (incluirId)
            {
                resultado.IdEstadoTipoProceso = int.Parse(txtIdEstadoTipoProcesos.Text);
            }

            return resultado;

        }
        private void Insertar(CRD_EstadoTipoProcesosVistaModelo vistaModelo)
        {
            var resultado = controlador.Insertar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);
            Funcionalidades.LimpiarCampos(this);
        }

        private bool Actualizar(CRD_EstadoTipoProcesosVistaModelo vistaModelo)
        {
            var resultado = controlador.Actualizar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);
            Funcionalidades.LimpiarCampos(this);
            return resultado;
        }

        private void InsertUpdate()
        {
            if (string.IsNullOrEmpty(txtIdEstadoTipoProcesos.Text))
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

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdEstadoTipoProcesos.Text))
            {
                CustomMessages.DebesSeleccionarRegistro();
            }
            else
            {
                var confirmacion = MessageBox.Show(CustomMessages.ConfirmacionEliminacion, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    int id = int.Parse(txtIdEstadoTipoProcesos.Text);
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

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvLista.Rows[e.RowIndex];

                txtIdEstadoTipoProcesos.Text = fila.Cells[0].Value.ToString();
                txtNombre.Text = fila.Cells[1].Value.ToString();
                txtDescripcion.Text = fila.Cells[2].Value.ToString();
                chkEstado.Checked = (bool)fila.Cells[3].Value;

                fila.Cells[0].ReadOnly = true;
                fila.Cells[1].ReadOnly = true;
                fila.Cells[2].ReadOnly = true;
                fila.Cells[3].ReadOnly = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Funcionalidades.LimpiarCampos(this);
        }
    }
}
