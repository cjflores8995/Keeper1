using CRD.Infraestructura.CrossCuting.Messages;
using CRD.UI.Windows.ControladoresApp;
using CRD.UI.Windows.VistaModelo;

using System;
using System.Windows.Forms;

namespace CRD.UI.Windows.Formularios
{
    public partial class frmCargo : Form
    {
        private CRD_CargoControlador controlador;
        private CRD_CargoVistaModelo vistaModelo;

        private static frmCargo instancia = null;

        public static frmCargo VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new frmCargo();
                return instancia;
            }
            return instancia;
        }

        public frmCargo()
        {
            InitializeComponent();
            controlador = new CRD_CargoControlador();
            vistaModelo = new CRD_CargoVistaModelo();
            ListarRegistros();

            this.StartPosition = FormStartPosition.CenterParent;
            this.FormClosed += new FormClosedEventHandler(FrmCRD_FormClosed);
        }

        private void FrmCRD_FormClosed(object sender, FormClosedEventArgs e)
        {
            instancia = null;
        }

        private void ListarRegistros()
        {
            dgvLista.DataSource = controlador.ListarTodo();
        }

        private void InsertUpdate()
        {
            

            if (string.IsNullOrEmpty(txtIdCargo.Text))
            {
                vistaModelo = CrearObjeto();
                Insertar(vistaModelo);
                ListarRegistros();
            }
            else
            {
                var resultado = MessageBox.Show(CustomMessages.ConfirmacionActualizacion, "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if(resultado == DialogResult.Yes)
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

        private void Insertar(CRD_CargoVistaModelo vistaModelo)
        {
            var resultado = controlador.Insertar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);
            Funcionalidades.LimpiarCampos(this);
        }

        private bool Actualizar(CRD_CargoVistaModelo vistaModelo)
        {
            var resultado = controlador.Actualizar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);
            return resultado;
        }


        private bool ValidarCampos()
        {
            if(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        

        private CRD_CargoVistaModelo CrearObjeto(bool incluirId = false)
        {
            CRD_CargoVistaModelo resultado = new CRD_CargoVistaModelo();
            resultado.NombreCargo = txtNombre.Text;
            resultado.Descripcion = txtDescripcion.Text;
            resultado.Activo = true;

            if (incluirId)
            {
                resultado.IdCargo = int.Parse(txtIdCargo.Text);
            }

            return resultado;

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

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdCargo.Text))
            {
                CustomMessages.DebesSeleccionarRegistro();
            }
            else
            {
                var confirmacion = MessageBox.Show(CustomMessages.ConfirmacionEliminacion, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    int id = int.Parse(txtIdCargo.Text);
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

        private void dgvLista_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvLista.Rows[e.RowIndex];

                txtIdCargo.Text = fila.Cells[0].Value.ToString();
                txtNombre.Text = fila.Cells[1].Value.ToString();
                txtDescripcion.Text = fila.Cells[2].Value.ToString();

                fila.Cells[0].ReadOnly = true;
                fila.Cells[1].ReadOnly = true;
                fila.Cells[2].ReadOnly = true;
                fila.Cells[3].ReadOnly = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarPorNombre.Text))
            {
                CustomMessages.DebesLlenarCamposRequeridos();
            }
            else
            {
                dgvLista.DataSource = controlador.ObtenerListaPorNombre(txtBuscarPorNombre.Text);
            }
        }
    }
}
