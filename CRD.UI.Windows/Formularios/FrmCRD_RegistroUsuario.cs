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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRD.UI.Windows.Formularios
{
    public partial class FrmCRD_RegistroUsuario : Form
    {
        CRD_UsuariosControlador controlador;
        CRD_CargoControlador cargoControlador;
        CRD_DepartamentoControlador departamentoControlador;
        CRD_CiudadControlador ciudadControlador;
        CRD_UsuariosVistaModelo vistaModelo;


        public FrmCRD_RegistroUsuario()
        {
            InitializeComponent();
            controlador = new CRD_UsuariosControlador();
            cargoControlador = new CRD_CargoControlador();
            departamentoControlador = new CRD_DepartamentoControlador();
            ciudadControlador = new CRD_CiudadControlador();
            vistaModelo = new CRD_UsuariosVistaModelo();


            CargarCargos();
            CargarDepartamentos();
            CargarCiudades();

            ListarRegistros();

            this.StartPosition = FormStartPosition.CenterParent;
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
                        txtNombreUsuario.Enabled = true;
                        txtPassword.Enabled = true;
                    }
                }
                else
                {

                    Funcionalidades.LimpiarCampos(this);
                }
            }
        }

        private void Insertar(CRD_UsuariosVistaModelo vistaModelo)
        {
            var resultado = controlador.Insertar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);
            Funcionalidades.LimpiarCampos(this);
        }

        private bool Actualizar(CRD_UsuariosVistaModelo vistaModelo)
        {
            var resultado = controlador.Actualizar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);
            return resultado;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || 
                string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtNombreUsuario.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) ||
                string.IsNullOrEmpty(txtPassword.Text)
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ListarRegistros()
        {
            dgvLista.DataSource = controlador.ListarTodo();
        }

        #region Private Methods

        private void CargarCargos()
        {


            cbxCargo.DisplayMember = "Nombre";
            cbxCargo.ValueMember = "Id";

            cbxCargo.DataSource = cargoControlador.ListarTodo()
                .Select(c => new { 
                    Id = c.IdCargo,
                    Nombre = c.NombreCargo
                }).ToList();

            cbxCargo.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void CargarDepartamentos()
        {
            cbxDepartamento.DisplayMember = "Nombre";
            cbxDepartamento.ValueMember = "Id";

            cbxDepartamento.DataSource = departamentoControlador.ListarTodo()
                .Select(c => new {
                    Id = c.IdDepartamento,
                    Nombre = c.NombreDepartamento
                }).ToList();

            cbxDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarCiudades()
        {
            cbxCiudad.DisplayMember = "Nombre";
            cbxCiudad.ValueMember = "Id";

            cbxCiudad.DataSource = ciudadControlador.ListarTodo()
                .Select(c => new {
                    Id = c.IdCiudad,
                    Nombre = c.NombreCiudad
                }).ToList();

            cbxCiudad.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private CRD_UsuariosVistaModelo CrearObjeto(bool incluirId = false)
        {
            CRD_UsuariosVistaModelo resultado = new CRD_UsuariosVistaModelo();
            
            resultado.Nombre = txtNombre.Text;
            resultado.Apellido = txtApellido.Text;
            resultado.Email = txtEmail.Text;
            resultado.PasswordHash = txtPassword.Text;
            resultado.NombreUsuario = txtNombreUsuario.Text;
            resultado.IdCargo = (int)cbxCargo.SelectedValue;
            resultado.IdDepartamento = (int)cbxDepartamento.SelectedValue;
            resultado.IdCiudad = (int)cbxCiudad.SelectedValue;

            if (incluirId)
            {
                resultado.Id = int.Parse(txtId.Text);
            }

            return resultado;
        }

        #endregion Private Methods


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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Funcionalidades.LimpiarCampos(this);
            txtNombreUsuario.Enabled = true;
            txtPassword.Enabled = true;
            txtNombre.Focus();

            cbxCargo.SelectedIndex = 0;
            cbxDepartamento.SelectedIndex = 0;
            cbxCiudad.SelectedIndex = 0;

        }


        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvLista.Rows[e.RowIndex];

                txtId.Text = fila.Cells["Id"].Value.ToString();
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
                txtNombreUsuario.Text = fila.Cells["NombreUsuario"].Value.ToString();
                txtEmail.Text = fila.Cells["Email"].Value.ToString();

                foreach (var item in cbxCargo.Items)
                {
                    if ((int)((dynamic)item).Id == int.Parse(fila.Cells["Cargo"].Value.ToString()))
                    {
                        cbxCargo.SelectedItem = item;
                        break;
                    }
                }

                foreach (var item in cbxDepartamento.Items)
                {
                    if ((int)((dynamic)item).Id == int.Parse(fila.Cells["Departamento"].Value.ToString()))
                    {
                        cbxDepartamento.SelectedItem = item;
                        break;
                    }
                }

                foreach (var item in cbxCiudad.Items)
                {
                    if ((int)((dynamic)item).Id == int.Parse(fila.Cells["Ciudad"].Value.ToString()))
                    {
                        cbxCiudad.SelectedItem = item;
                        break;
                    }
                }

                fila.Cells[0].ReadOnly = true;
                fila.Cells[1].ReadOnly = true;
                fila.Cells[2].ReadOnly = true;
                fila.Cells[3].ReadOnly = true;
                fila.Cells[4].ReadOnly = true;
                fila.Cells[5].ReadOnly = true;
                fila.Cells[6].ReadOnly = true;
                fila.Cells[7].ReadOnly = true;

                txtNombreUsuario.Enabled = false;
                txtPassword.Enabled = false;
                txtPassword.Text = "Password";
            }
        }
    }
}
