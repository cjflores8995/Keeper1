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
    public partial class FrmValijas : Form
    {
        private CRD_ValijasControlador controlador;
        private CRD_ValijasVistaModelo vistaModelo;

        private static FrmValijas instancia = null;
        public static FrmValijas VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new FrmValijas();
                return instancia;
            }
            return instancia;
        }

        public FrmValijas()
        {
            InitializeComponent();
            controlador = new CRD_ValijasControlador();
            vistaModelo = new CRD_ValijasVistaModelo();
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
            if (string.IsNullOrEmpty(txtBitacora.Text) || string.IsNullOrEmpty(txtOBSV.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private CRD_ValijasVistaModelo CrearObjeto(bool incluirId = false)
        {
            CRD_ValijasVistaModelo resultado = new CRD_ValijasVistaModelo();
            resultado.IdBitacora = int.Parse(txtBitacora.Text);
            resultado.Fecha = DateTime.Parse(txtFecha.Text);
            resultado.Origen = txtOrigen.Text;
            resultado.Remitente = txtRemitente.Text;
            resultado.Centro = txtCentro.Text;
            resultado.OBSV = txtOBSV.Text;
            resultado.Activo = chkEstado.Checked;

            if (incluirId)
            {
                resultado.IdValija = int.Parse(txtIdValija.Text);
            }

            return resultado;

        }
        private void Insertar(CRD_ValijasVistaModelo vistaModelo)
        {
            var resultado = controlador.Insertar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);
            Funcionalidades.LimpiarCampos(this);
        }

        private bool Actualizar(CRD_ValijasVistaModelo vistaModelo)
        {
            var resultado = controlador.Actualizar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);
            Funcionalidades.LimpiarCampos(this);
            return resultado;
        }

        private void InsertUpdate()
        {
            if (string.IsNullOrEmpty(txtIdValija.Text))
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

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
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

        private void Eliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdValija.Text))
            {
                CustomMessages.DebesSeleccionarRegistro();
            }
            else
            {
                var confirmacion = MessageBox.Show(CustomMessages.ConfirmacionEliminacion, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    int id = int.Parse(txtIdValija.Text);
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

                txtIdValija.Text = fila.Cells[0].Value.ToString();
                txtBitacora.Text = fila.Cells[1].Value.ToString();
                txtFecha.Text = fila.Cells[2].Value.ToString();
                txtOrigen.Text = fila.Cells[3].Value.ToString();
                txtRemitente.Text = fila.Cells[4].Value.ToString();
                txtCentro.Text = fila.Cells[5].Value.ToString();
                txtOBSV.Text = fila.Cells[6].Value.ToString();
                chkEstado.Checked = (bool)fila.Cells[7].Value;

                fila.Cells[0].ReadOnly = true;
                fila.Cells[1].ReadOnly = true;
                fila.Cells[2].ReadOnly = true;
                fila.Cells[3].ReadOnly = true;
                fila.Cells[4].ReadOnly = true;
                fila.Cells[5].ReadOnly = true;
                fila.Cells[6].ReadOnly = true;
                fila.Cells[7].ReadOnly = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Funcionalidades.LimpiarCampos(this);
        }

    }
}
