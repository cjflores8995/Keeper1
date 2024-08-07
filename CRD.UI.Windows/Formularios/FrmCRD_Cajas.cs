﻿using CRD.Infraestructura.CrossCuting.Messages;
using CRD.UI.Windows.ControladoresApp;
using CRD.UI.Windows.VistaModelo;

using System;
using System.Windows.Forms;

namespace CRD.UI.Windows.Formularios
{
    public partial class FrmCRD_Cajas : Form
    {
        private CRD_CajasControlador controlador;
        private CRD_CajasVistaModelo vistaModelo;

        public FrmCRD_Cajas()
        {
            InitializeComponent();
            controlador = new CRD_CajasControlador();
            vistaModelo = new CRD_CajasVistaModelo();
            ListarRegistros();

            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void InsertUpdate()
        {


            if (string.IsNullOrEmpty(txtIdCajas.Text))
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



        #region Private Methods

        private void ListarRegistros()
        {
            dgvLista.DataSource = controlador.ListarTodo();
        }

        private CRD_CajasVistaModelo CrearObjeto(bool incluirId = false)
        {
            CRD_CajasVistaModelo resultado = new CRD_CajasVistaModelo();
            resultado.NombreCaja = txtNombre.Text;
            resultado.Descripcion = txtDescripcion.Text;
            resultado.EstatusCaja = chkEstadoCajas.Checked;
            resultado.Activo = true;

            if (incluirId)
            {
                resultado.IdCaja = int.Parse(txtIdCajas.Text);
            }

            return resultado;
        }

        private void Insertar(CRD_CajasVistaModelo vistaModelo)
        {
            var resultado = controlador.Insertar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);
            Funcionalidades.LimpiarCampos(this);
        }

        private bool Actualizar(CRD_CajasVistaModelo vistaModelo)
        {
            var resultado = controlador.Actualizar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);
            return resultado;
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
            if (string.IsNullOrEmpty(txtIdCajas.Text))
            {
                CustomMessages.DebesSeleccionarRegistro();
            }
            else
            {
                var confirmacion = MessageBox.Show(CustomMessages.ConfirmacionEliminacion, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    int id = int.Parse(txtIdCajas.Text);
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
        }

        private void dgvLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvLista.Rows[e.RowIndex];

                txtIdCajas.Text = fila.Cells[0].Value.ToString();
                txtNombre.Text = fila.Cells[1].Value.ToString();
                txtDescripcion.Text = fila.Cells[2].Value.ToString();
                chkEstadoCajas.Checked = (bool)fila.Cells[3].Value;

                fila.Cells[0].ReadOnly = true;
                fila.Cells[1].ReadOnly = true;
                fila.Cells[2].ReadOnly = true;
                fila.Cells[3].ReadOnly = true;
                fila.Cells[4].ReadOnly = true;
            }
        }

        private void btnBuscador_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscador.Text))
            {
                CustomMessages.DebesLlenarCamposRequeridos();
            }
            else
            {
                dgvLista.DataSource = controlador.ObtenerListaPorNombre(txtBuscador.Text.ToLower().Trim());
            }
        }
    }
}
