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
    public partial class FrmCRD_Valijas : Form
    {
        private CRD_ValijasControlador controlador;
        private CRD_ValijasVistaModelo vistaModelo;
        private CRD_BitacoraControlador bitacoracontrolador;


        public FrmCRD_Valijas()
        {
            InitializeComponent();
            controlador = new CRD_ValijasControlador();
            bitacoracontrolador = new CRD_BitacoraControlador();
            vistaModelo = new CRD_ValijasVistaModelo();
            ListarRegistros();
            this.StartPosition = FormStartPosition.CenterParent;
            LLenarBitacora();
        }

        private void LLenarBitacora()
        {
            cbxIdBitacora.DataSource = bitacoracontrolador.ListarBitacora();
            cbxIdBitacora.DisplayMember = "Observaciones";
            cbxIdBitacora.ValueMember = "IdBitacora";

        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtOBSV.Text))
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
            resultado.IdBitacora = (int)cbxIdBitacora.SelectedValue;
            resultado.Fecha = DateTime.Parse(txtFecha.Text);
            resultado.Origen = txtOrigen.Text;
            resultado.Remitente = txtRemitente.Text;
            resultado.Centro = txtCentro.Text;
            resultado.OBSV = txtOBSV.Text;
            resultado.Activo = true;

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
            DateTime fecha = DateTime.Now;
            string fechaConvertida = fecha.ToString("yyyy/MM/dd");
            txtFecha.Text = fechaConvertida;
            dgvLista.DataSource = controlador.ListarTodo();
        }


        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvLista.Rows[e.RowIndex];

                txtIdValija.Text = fila.Cells[0].Value.ToString();

                foreach (var item in cbxIdBitacora.Items)
                {
                    if ((int)((dynamic)item).IdBitacora == int.Parse(fila.Cells[1].Value.ToString()))
                    {
                        cbxIdBitacora.SelectedItem = item;
                        break;
                    }
                }

                txtFecha.Text = fila.Cells[2].Value.ToString();
                txtOrigen.Text = fila.Cells[3].Value.ToString();
                txtRemitente.Text = fila.Cells[4].Value.ToString();
                txtCentro.Text = fila.Cells[5].Value.ToString();
                txtOBSV.Text = fila.Cells[6].Value.ToString();

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

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscador.Text))
            {
                string valor = txtBuscador.Text;
                if (rbtnOrigen.Checked)
                {
                    dgvLista.DataSource = controlador.BuscarOrigen(valor);
                }
                if (rbtnRemitente.Checked)
                {
                    dgvLista.DataSource = controlador.BuscarRemitente(valor);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Funcionalidades.LimpiarCampos(this);
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
    }
}
