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
    public partial class FrmCRD_Proveedores : Form
    {
        private CRD_ProveedoresControlador controlador;
        private CRD_ProveedoresVistaModelo vistaModelo;

        private static FrmCRD_Proveedores instancia = null;
        public static FrmCRD_Proveedores VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new FrmCRD_Proveedores();
                return instancia;
            }
            return instancia;
        }

        public FrmCRD_Proveedores()
        {
            InitializeComponent();
            controlador = new CRD_ProveedoresControlador();
            vistaModelo = new CRD_ProveedoresVistaModelo();
            ListarRegistros();
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
                if (rbtnCodProveedor.Checked) {
                   
                    dgvLista.DataSource = controlador.ObtenerProveedoresPorCodProveedores(txtBuscador.Text);
                    

                }

                if (rbtnRucCedula.Checked) {
                    dgvLista.DataSource = controlador.ObtenerProveedoresPorRucCedula(txtBuscador.Text);
                }

                if (rbtnRazonSocial.Checked) {
                    dgvLista.DataSource = controlador.ObtenerProveedoresPorRazonSocial(txtBuscador.Text);
                }
                
            }
        }

        private void ListarRegistros()
        {
            dgvLista.DataSource = controlador.ListarTodo();
        }

        public void limpiar() {
            txtRucCedula.Text = string.Empty;
            txtCodProveedor.Text=string.Empty;
            txtRazonSocial.Text= string.Empty;
            txtTelefono.Text= string.Empty;
            txtCiudad.Text= string.Empty;
            txtEstado2.Text= string.Empty;
            txtCodCondicionesPago.Text= string.Empty;
            ListarRegistros();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscador.Text))
            {
                limpiar();
            }
        }

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvLista.Rows[e.RowIndex];

                txtRucCedula.Text = fila.Cells[0].Value.ToString();
                txtCodProveedor.Text = fila.Cells[1].Value.ToString();
                txtRazonSocial.Text = fila.Cells[2].Value.ToString();
                txtTelefono.Text = fila.Cells[3].Value.ToString();
                txtCiudad.Text = fila.Cells[4].Value.ToString();
                txtEstado2.Text = fila.Cells[5].Value.ToString();
                txtCodCondicionesPago.Text = fila.Cells[6].Value.ToString();

                fila.Cells[0].ReadOnly = true;
                fila.Cells[1].ReadOnly = true;
                fila.Cells[2].ReadOnly = true;
                fila.Cells[3].ReadOnly = true;
                fila.Cells[4].ReadOnly = true;
                fila.Cells[5].ReadOnly = true;
                fila.Cells[6].ReadOnly = true;
            }

        }
    }
}
