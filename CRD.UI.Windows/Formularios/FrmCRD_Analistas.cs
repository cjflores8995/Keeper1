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
    public partial class FrmCRD_Analistas : Form
        {

        private CRD_AnalistasControlador analista_SC;
        private CRD_AnalistasVistaModelo analista_VM;
        private CRD_EstadoTipoProcesosControlador estadoTipo_SC;
        private CRD_EstadoTipoProcesosVistaModelo estadoTipo_VM;

        private static FrmCRD_Analistas instancia = null;
        public static FrmCRD_Analistas VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new FrmCRD_Analistas();
                return instancia;
            }
            return instancia;
        }

        public FrmCRD_Analistas()
        {
            InitializeComponent();
            analista_SC = new CRD_AnalistasControlador();
            analista_VM = new CRD_AnalistasVistaModelo();
            estadoTipo_SC = new CRD_EstadoTipoProcesosControlador();
            estadoTipo_VM = new CRD_EstadoTipoProcesosVistaModelo();
            listarAnalista();
            leerestadoTipoProceso();
            this.FormClosed += new FormClosedEventHandler(FrmCRD_FormClosed);
        }

        private void FrmCRD_FormClosed(object sender, FormClosedEventArgs e)
        {
            instancia = null;
        }

        public void listarAnalista() {

            dgvLista.DataSource = analista_SC.ListarAnalista();
          }


        private void FrmCRD_Analistas_Load(object sender, EventArgs e)
        {

        }


        public void InsertarAnalista()
        {
            analista_VM.UsuarioLN = txtUsuarioLN.Text;
            analista_VM.Nombre = txtNombre.Text;
            analista_VM.IdEstadoTipoProceso = int.Parse(txtIdEstadoTipoProceso.Text);
                  
            if(chkActivoAnalista.Checked)
            {
                analista_VM.Activo = true;
            }
            else
            {
                analista_VM.Activo = false;
            }

            //if (txtIdAnalistas.Text == "")
            if (string.IsNullOrEmpty(txtIdAnalistas.Text))
            {
                if (txtNombre.Text!="" || txtUsuarioLN.Text != "")
                {
                    analista_SC.InsertarAnalista(analista_VM);
                    MessageBox.Show("Registro Insertado Correctamente");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error: No se puede ingresar valores Nulos..!");
                }
            }
            else
            {
                analista_VM.IdAnalista = int.Parse(txtIdAnalistas.Text);
                if (analista_SC.ActualizarAnalista(analista_VM))
                {
                    MessageBox.Show("Registro Actualizado Correctamente");
                    limpiar();
                }
                else
                {
                    MessageBox.Show("Error: No se Actualizo el registro, consulte a su Administrador");
                }
            }


            listarAnalista();
        }


        private void limpiar()
        {
            txtIdAnalistas.Text = "";
            txtIdEstadoTipoProceso.Text = "";
            txtUsuarioLN.Text = "";
            txtNombre.Text = "";
        }

        private void leerestadoTipoProceso()
        {
            cmbEstadoProceso_Analistas.DataSource = estadoTipo_SC.ListarTodo();
            cmbEstadoProceso_Analistas.DisplayMember = "Nombre";
            cmbEstadoProceso_Analistas.ValueMember = "IdEstadoTipoProceso";
        }

        private void cmbEstadoProceso_Analistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstadoProceso_Analistas.SelectedIndex == -1)
            {
                txtIdEstadoTipoProceso.Text = string.Empty;
            }
            else
            {
                txtIdEstadoTipoProceso.Text = cmbEstadoProceso_Analistas.SelectedValue.ToString();
                
            }
        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            InsertarAnalista();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Funcionalidades.LimpiarCampos(this);
            Dispose();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar Registro", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                analista_SC.EliminarAnalista(int.Parse(txtIdAnalistas.Text));
                limpiar();
                listarAnalista();
            }
        }

        private void dgvLista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int item = dgvLista.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (item > 0)
            {

                txtIdAnalistas.Text = dgvLista.Rows[dgvLista.CurrentRow.Index].Cells[0].Value.ToString();
                txtIdEstadoTipoProceso.Text = dgvLista.Rows[dgvLista.CurrentRow.Index].Cells[1].Value.ToString();
                txtUsuarioLN.Text = dgvLista.Rows[dgvLista.CurrentRow.Index].Cells[2].Value.ToString();
                txtNombre.Text = dgvLista.Rows[dgvLista.CurrentRow.Index].Cells[3].Value.ToString();

            }
        }
    }
}

