using CRD.Infraestructura.CrossCuting.Messages;
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
    public partial class FrmCRD_Ordenes : Form
    {
        private CRD_OrdenesControlador controlador;
        private CRD_OrdenesVistaModelo vistaModelo;

        public FrmCRD_Ordenes()
        {
            InitializeComponent();
            controlador = new CRD_OrdenesControlador();
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscador.Text))
            {
                var lista = controlador.ObtenerOrdenesPorNumeroOrden(txtBuscador.Text);
                var orden = lista.FirstOrDefault();

                if (orden != null)
                {
                    dgvLista.DataSource = lista;
                }
                else {
                    MessageBox.Show("No se encontro información de la ORDEN", "Error en proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscador.Text))
            {
                limpiar();
            }
        }

        public void limpiar() {
            Funcionalidades.LimpiarCampos(this);
            dgvLista.DataSource = null;
            dgvLista.Rows.Clear();
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

                txtId.Text = fila.Cells[0].Value.ToString();
                txtCodigoSistema.Text = fila.Cells[1].Value.ToString();
                txtPersonaReferenciada.Text = fila.Cells[2].Value.ToString();
                txtDescuentoCompania.Text = fila.Cells[3].Value.ToString();
                txtImporteBruto.Text = fila.Cells[4].Value.ToString();
                txtIva.Text = fila.Cells[5].Value.ToString();
                txtFechaOrden.Text = fila.Cells[6].Value.ToString();
                txtBienesFacturadosRecibidos.Text = fila.Cells[7].Value.ToString();
                txtCodigoProveedorPrinciapal.Text = fila.Cells[8].Value.ToString();
                txtNombreProveedorPrincipal.Text = fila.Cells[9].Value.ToString();
                txtNumeroOrden.Text = fila.Cells[10].Value.ToString();
                txtLiberado.Text = fila.Cells[11].Value.ToString();
                txtDescuentoProveedor.Text = fila.Cells[12].Value.ToString();
                txtCompania.Text = fila.Cells[13].Value.ToString();

                fila.Cells[0].ReadOnly = true;
                fila.Cells[1].ReadOnly = true;
                fila.Cells[2].ReadOnly = true;
                fila.Cells[3].ReadOnly = true;
                fila.Cells[4].ReadOnly = true;
                fila.Cells[5].ReadOnly = true;
                fila.Cells[6].ReadOnly = true;
                fila.Cells[7].ReadOnly = true;
                fila.Cells[8].ReadOnly = true;
                fila.Cells[9].ReadOnly = true;
                fila.Cells[10].ReadOnly = true;
                fila.Cells[11].ReadOnly = true;
                fila.Cells[12].ReadOnly = true;
                fila.Cells[13].ReadOnly = true;
            }
        }
    }
}
