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
    public partial class FrmCRD_Proveedores : Form
    {
        private CRD_ProveedoresControlador controlador;
        private CRD_ProveedoresVistaModelo vistaModelo;


        public FrmCRD_Proveedores()
        {
            InitializeComponent();
            controlador = new CRD_ProveedoresControlador();
            vistaModelo = new CRD_ProveedoresVistaModelo();
            ListarRegistros();
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBuscador.Text))
            {
                if (rbtnCodProveedor.Checked) {
                    var lista = controlador.ObtenerProveedoresPorCodProveedores(txtBuscador.Text);
                    var codProveedores = lista.FirstOrDefault();
                    if (codProveedores != null)
                    {
                        dgvLista.DataSource = lista;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró información del PROVEEDOR", "Error en proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (rbtnRucCedula.Checked) {
                    var lista = controlador.ObtenerProveedoresPorRucCedula(txtBuscador.Text);
                    var rucCedula = lista.FirstOrDefault();
                    if (rucCedula != null)
                    {
                        dgvLista.DataSource = lista;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró información del PROVEEDOR", "Error en proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (rbtnRazonSocial.Checked) {
                    var lista = controlador.ObtenerProveedoresPorRazonSocial(txtBuscador.Text);
                    var razonSocial = lista.FirstOrDefault();
                    if (razonSocial != null)
                    {
                        dgvLista.DataSource = lista;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró información del PROVEEDOR", "Error en proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }

        private void ListarRegistros()
        {
            dgvLista.DataSource = controlador.ListarTodo();
        }

        public void limpiar() {
            Funcionalidades.LimpiarCampos(this);
            ListarRegistros();
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscador.Text))
            {
                limpiar();
            }
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Funcionalidades.LimpiarCampos(this);
            rbtnCodProveedor.Focus();
        }

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
