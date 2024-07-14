﻿using CRD.Infraestructura.CrossCuting.Messages;
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
    public partial class FrmCRD_TipoDocumentoPagos : Form
    {
        private CRD_TipoDocumentoPagosControlador controlador;
        private CRD_TipoDocumentoPagosVistaModelo vistaModelo;

        private static FrmCRD_TipoDocumentoPagos instancia = null;
        public static FrmCRD_TipoDocumentoPagos VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new FrmCRD_TipoDocumentoPagos();
                return instancia;
            }
            return instancia;
        }

        public FrmCRD_TipoDocumentoPagos()
        {
            InitializeComponent();
            controlador = new CRD_TipoDocumentoPagosControlador();
            vistaModelo = new CRD_TipoDocumentoPagosVistaModelo();
            ListarRegistros();
            this.FormClosed += new FormClosedEventHandler(FrmCRD_FormClosed);
        }

        private void FrmCRD_FormClosed(object sender, FormClosedEventArgs e)
        {
            instancia = null;
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
                chkActivo.Checked = (bool)fila.Cells[3].Value;

                fila.Cells[0].ReadOnly = true;
                fila.Cells[1].ReadOnly = true;
                fila.Cells[2].ReadOnly = true;
                fila.Cells[3].ReadOnly = true;
            }

        }

        private CRD_TipoDocumentoPagosVistaModelo CrearObjeto(bool incluirId = false)
        {
            CRD_TipoDocumentoPagosVistaModelo resultado = new CRD_TipoDocumentoPagosVistaModelo();
            resultado.Nombre = txtNombre.Text;
            resultado.Descripcion = txtDescripcion.Text;
            resultado.Activo = chkActivo.Checked;

            if (incluirId)
            {
                resultado.IdTipoDocumentoPago = int.Parse(txtId.Text);
            }

            return resultado;
        }

        private void Insertar(CRD_TipoDocumentoPagosVistaModelo vistaModelo)
        {
            var resultado = controlador.Insertar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);
            Funcionalidades.LimpiarCampos(this);

        }

        private bool Actualizar(CRD_TipoDocumentoPagosVistaModelo vistaModelo)
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
            dgvLista.Columns[0].HeaderText = "ID";
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
