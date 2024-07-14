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
    public partial class FrmCRD_Iva : Form
    {
        private CRD_IvaControlador controlador;
        private CRD_IvaVistaModelo vistaModelo;

        private static FrmCRD_Iva instancia = null;
        public static FrmCRD_Iva VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new FrmCRD_Iva();
                return instancia;
            }
            return instancia;
        }

        public FrmCRD_Iva()
        {
            InitializeComponent();
            controlador = new CRD_IvaControlador();
            vistaModelo = new CRD_IvaVistaModelo();
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
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private CRD_IvaVistaModelo CrearObjeto(bool incluirId = false)
        {
            CRD_IvaVistaModelo resultado = new CRD_IvaVistaModelo();
            resultado.ValorIva = int.Parse(txtValor.Text);
            resultado.Activo = true;

            if (incluirId)
            {
                resultado.IdIva = int.Parse(txtIdIva.Text);
            }

            return resultado;

        }
        private void Insertar(CRD_IvaVistaModelo vistaModelo)
        {
            var resultado = controlador.Insertar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);
            Funcionalidades.LimpiarCampos(this);
        }

        private bool Actualizar(CRD_IvaVistaModelo vistaModelo)
        {
            var resultado = controlador.Actualizar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);
            Funcionalidades.LimpiarCampos(this);
            return resultado;
        }

        private void InsertUpdate()
        {
            if (string.IsNullOrEmpty(txtIdIva.Text))
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
            if (string.IsNullOrEmpty(txtIdIva.Text))
            {
                CustomMessages.DebesSeleccionarRegistro();
            }
            else
            {
                var confirmacion = MessageBox.Show(CustomMessages.ConfirmacionEliminacion, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    int id = int.Parse(txtIdIva.Text);
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

                txtIdIva.Text = fila.Cells[0].Value.ToString();
                txtValor.Text = fila.Cells[1].Value.ToString();

                fila.Cells[0].ReadOnly = true;
                fila.Cells[1].ReadOnly = true;
                fila.Cells[2].ReadOnly = true;

                MostrarUOcultarBotonIva();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Funcionalidades.LimpiarCampos(this);
        }

        private void MostrarUOcultarBotonIva()
        {
            if (!string.IsNullOrEmpty(txtIdIva.Text) && !string.IsNullOrEmpty(txtValor.Text))
            {
                btnEstablecerIva.Visible = true;
            }
            else
            {
                btnEstablecerIva.Visible = false;
            }
        }

        private void btnEstablecerIva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdIva.Text) && string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Sebes seleccionar un IVA como principal", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                controlador.EstablecerIvaPrincipal(int.Parse(txtIdIva.Text));
                ListarRegistros();
            }
        }
    }
}
