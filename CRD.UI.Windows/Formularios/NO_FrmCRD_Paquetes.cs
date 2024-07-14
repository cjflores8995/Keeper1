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
    public partial class NO_FrmCRD_Paquetes : Form
    {
        CRD_PaquetesControlador controlador;
        CRD_CajasControlador cajasControlador;
        CRD_PaquetesVistaModelo vistaModelo;

        public NO_FrmCRD_Paquetes()
        {
            InitializeComponent();

            controlador=new CRD_PaquetesControlador();
            cajasControlador = new CRD_CajasControlador();
            vistaModelo=new CRD_PaquetesVistaModelo();

            ListarRegistros();
            CargarCajas();
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
            if (string.IsNullOrEmpty(txtId.Text))
            {
                CustomMessages.DebesSeleccionarRegistro();
            }
            else
            {
                var confirmacion = MessageBox.Show(CustomMessages.ConfirmacionEliminacion, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    int id = int.Parse(txtId.Text);
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

        private void dgvLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvLista.Rows[e.RowIndex];

                txtId.Text = fila.Cells[0].Value.ToString();
                txtNombre.Text = fila.Cells[1].Value.ToString();
                txtDescripcion.Text = fila.Cells[2].Value.ToString();
                chkEstatus.Checked = (bool)fila.Cells[3].Value;
                chkActivo.Checked = (bool)fila.Cells[4].Value;
                foreach (var item in cbxCajas.Items)
                {
                    if ((int)((dynamic)item).IdCaja == int.Parse(fila.Cells[5].Value.ToString()))
                    {
                        cbxCajas.SelectedItem = item;
                        break;
                    }
                }

                fila.Cells[0].ReadOnly = true;
                fila.Cells[1].ReadOnly = true;
                fila.Cells[2].ReadOnly = true;
                fila.Cells[3].ReadOnly = true;
                fila.Cells[4].ReadOnly = true;
                fila.Cells[5].ReadOnly = true;
            }

        }

        private CRD_PaquetesVistaModelo CrearObjeto(bool incluirId = false)
        {
            CRD_PaquetesVistaModelo resultado = new CRD_PaquetesVistaModelo();
            resultado.IdCajas= (int)cbxCajas.SelectedValue;
            resultado.NombrePaquete = txtNombre.Text;
            resultado.Descripcion = txtDescripcion.Text;
            resultado.EstatusPaquete = chkEstatus.Checked;
            resultado.Activo = chkActivo.Checked;

            if (incluirId)
            {
                resultado.IdPaquete = int.Parse(txtId.Text);
            }

            return resultado;
        }

        private void CargarCajas() {


            cbxCajas.DataSource = cajasControlador.ListarTodo();
            cbxCajas.DisplayMember = "NombreCaja";
            cbxCajas.ValueMember = "IdCaja";
        }

        private void Insertar(CRD_PaquetesVistaModelo vistaModelo)
        {
            var resultado = controlador.Insertar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);
            Funcionalidades.LimpiarCampos(this);

        }

        private bool Actualizar(CRD_PaquetesVistaModelo vistaModelo)
        {
            var resultado = controlador.Actualizar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);
            return resultado;
        }


        private void InsertUpdate()
        {
            if (string.IsNullOrEmpty(txtId.Text))
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
    }




}

