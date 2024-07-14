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

        private static FrmCRD_Ordenes instancia = null;
        public static FrmCRD_Ordenes VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new FrmCRD_Ordenes();
                return instancia;
            }
            return instancia;
        }

        public FrmCRD_Ordenes()
        {
            InitializeComponent();
            controlador = new CRD_OrdenesControlador();
            this.FormClosed += new FormClosedEventHandler(FrmCRD_FormClosed);
        }

        private void FrmCRD_FormClosed(object sender, FormClosedEventArgs e)
        {
            instancia = null;
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscador.Text))
            {
                dgvLista.DataSource = controlador.ObtenerOrdenesPorNumeroOrden(txtBuscador.Text);
            }
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscador.Text))
            {
                limpiar();
            }
        }

        public void limpiar() { 
            txtId.Text= string.Empty;
            txtCodigoSistema.Text = string.Empty;
            txtPersonaReferenciada.Text=string.Empty;
            txtDescuentoCompania.Text = string.Empty;
            txtImporteBruto.Text = string.Empty;
            txtIva.Text = string.Empty;
            txtFechaOrden.Text = string.Empty;
            txtBienesFacturadosRecibidos.Text = string.Empty;
            txtCodigoProveedorPrinciapal.Text = string.Empty;
            txtNombreProveedorPrincipal.Text = string.Empty;
            txtNumeroOrden.Text = string.Empty;
            txtLiberado.Text = string.Empty;
            txtDescuentoProveedor.Text = string.Empty;
            txtCompania.Text = string.Empty;
            dgvLista.DataSource = null;
            dgvLista.Rows.Clear();
        }

    }
}
