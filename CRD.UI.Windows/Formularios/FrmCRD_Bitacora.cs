using CRD.Dominio.Modelo.Entidades;
using CRD.Infraestructura.CrossCuting.Cache;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRD.UI.Windows.Formularios
{
    public partial class FrmCRD_Bitacora : Form
    {
        private CRD_BitacoraControlador bitacora_SC;
        private CRD_BitacoraVistaModelo bitacora_VM;
        private CRD_EstadoTipoProcesosControlador estadoTipoProceso_SC;
        private CRD_EstadoTipoProcesosVistaModelo estadoTipoProceso_VM;
        private CRD_TipoDocumentoPagosControlador TipoDocumentoPago_SC;
        private CRD_TipoDocumentoPagosVistaModelo TipoDocumentoPago_VM;
        private CRD_TipoDocumentosControlador tipodedocumento_SC;
        private CRD_TipoDocumentosVistaModelo tipodedocumento_VM;

        private CRD_EmpresasControlador empresas_SC;
        private CRD_EmpresasVistaModelo empresas_VM;

        private CRD_AnalistasControlador analistas_SC;
        private CRD_AnalistasVistaModelo analistas_VM;

        private CRD_OrdenesControlador ordenesControlador;
        private CRD_ProveedoresControlador proveedoresControlador;

        private static FrmCRD_Bitacora instancia = null;

        public static FrmCRD_Bitacora VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new FrmCRD_Bitacora();
                return instancia;
            }
            return instancia;
        }

        private void CargarDatosSesionUsuario()
        {
            txtUsuario.Text = UsuarioLoginCache.NombreUsuario;
            txtCargo.Text = UsuarioLoginCache.NombreCargo;
            txtDepartamento.Text = UsuarioLoginCache.NombreDepartamento;
            txtCiudad.Text = UsuarioLoginCache.NombreCiudad;
        }

        public FrmCRD_Bitacora()
        {
            InitializeComponent();
            txtOrden.Focus();

           txtFechaRegistro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            timer1.Interval = 1000; // Intervalo de 1 minuto (60000 milisegundos)
            timer1.Start();



            bitacora_SC =new CRD_BitacoraControlador();
            bitacora_VM=new CRD_BitacoraVistaModelo();
            estadoTipoProceso_SC = new CRD_EstadoTipoProcesosControlador();
            estadoTipoProceso_VM = new CRD_EstadoTipoProcesosVistaModelo();

            TipoDocumentoPago_SC = new CRD_TipoDocumentoPagosControlador();
            TipoDocumentoPago_VM = new CRD_TipoDocumentoPagosVistaModelo();

            tipodedocumento_SC = new CRD_TipoDocumentosControlador();
            tipodedocumento_VM = new CRD_TipoDocumentosVistaModelo();

            empresas_SC = new CRD_EmpresasControlador();
            empresas_VM = new CRD_EmpresasVistaModelo();

            analistas_SC = new CRD_AnalistasControlador();
            analistas_VM = new CRD_AnalistasVistaModelo();

            ordenesControlador = new CRD_OrdenesControlador();
            proveedoresControlador = new CRD_ProveedoresControlador();

            /*llamos a todos los combos relacionados a la bitacora*/
            leerestadoTipoProceso();
            leerEmpresas();
            leerTipoDocumntoPago();
            leerTiposdeDocumento();
            leerAnalistas();
            limpiarbitacora();
            listarDatos();
            ListardarsoDwBitacora();
            this.FormClosed += new FormClosedEventHandler(FrmCRD_FormClosed);

            CargarDatosSesionUsuario();
        }

        private void FrmCRD_FormClosed(object sender, FormClosedEventArgs e)
        {
            instancia = null;
        }


        private void leerestadoTipoProceso()
        {
            //cmbEstadoTipos.DataSource = estadoTipoProceso_SC.ListarTodo();
            //cmbEstadoTipos.DisplayMember = "Nombre";
            //cmbEstadoTipos.ValueMember = "IdEstadoTipoProceso";


            cmbEstadoTipos.DisplayMember = "Nombre";
            cmbEstadoTipos.ValueMember = "Id";

            cmbEstadoTipos.DataSource = estadoTipoProceso_SC.ListarTodo()
                .Select(c => new {
                    Id = c.IdEstadoTipoProceso,
                    Nombre = c.Nombre
                }).ToList();

            cmbEstadoTipos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbEstadoTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEstadoTipos.SelectedIndex == -1)
            {
                txtIdEstadoProceso.Text = string.Empty;
            }
            else
            {
                txtIdEstadoProceso.Text = cmbEstadoTipos.SelectedValue.ToString();
                txtRuc.Focus();
            }
        }

        private void leerEmpresas()
        {
            cmbEmpresas.DataSource = empresas_SC.ListarTodo();
            cmbEmpresas.DisplayMember = "Nombre";
            cmbEmpresas.ValueMember = "CodigoEmpresa";
            
        }
                
        private void cmbEmpresas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbEmpresas.SelectedIndex == -1)
            {
                txtCodigoempresa.Text = string.Empty;
            }
            else
            {
                txtCodigoempresa.Text = cmbEmpresas.SelectedValue.ToString();
                cmbTipoDocumento.Focus();
               
            }
        }

        private void leerTipoDocumntoPago()
        {
            cmbTipoDocumentoPago.DisplayMember = "Nombre";
            cmbTipoDocumentoPago.ValueMember = "Id";

            cmbTipoDocumentoPago.DataSource = TipoDocumentoPago_SC.ListarTodo()
                .Select(c => new {
                    Id = c.IdTipoDocumentoPago,
                    Nombre = c.Nombre
                }).ToList();

            cmbTipoDocumentoPago.DropDownStyle = ComboBoxStyle.DropDownList;

            

            //cmbTipoDocumentoPago.DataSource = TipoDocumentoPago_SC.ListarTodo();
            //cmbTipoDocumentoPago.DisplayMember = "Nombre";
            //cmbTipoDocumentoPago.ValueMember = "IdTipoDocumentoPago";
        }

        private void cmbTipoDocumentoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoDocumentoPago.SelectedIndex == -1)
            {
                txtIdTipoDocumentoPago.Text = string.Empty;
            }
            else
            {
                txtIdTipoDocumentoPago.Text = cmbTipoDocumentoPago.SelectedValue.ToString();
                txtObservaciones.Focus();

            }
        }

        private void leerTiposdeDocumento()
        {
            cmbTipoDocumento.DisplayMember = "Nombre";
            cmbTipoDocumento.ValueMember = "Id";

            cmbTipoDocumento.DataSource = tipodedocumento_SC.ListarTodo()
                .Select(c => new {
                    Id = c.IdTipoDocumento,
                    Nombre = c.Nombre
                }).ToList();

            cmbTipoDocumento.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoDocumento.SelectedIndex == -1)
            {
                txtTipoDocumento.Text = string.Empty;
            }
            else
            {
                txtTipoDocumento.Text = cmbTipoDocumento.SelectedValue.ToString();
                cmbAnalistas.Focus();

            }
        }
        private void leerAnalistas()
        {
            //cmbAnalistas.DataSource = analistas_SC.ListarAnalista();
            //cmbAnalistas.DisplayMember = "Nombre";
            //cmbAnalistas.ValueMember = "IdAnalista";


            cmbAnalistas.DisplayMember = "Nombre";
            cmbAnalistas.ValueMember = "Id";

            cmbAnalistas.DataSource = analistas_SC.ListarAnalista()
                .Select(c => new {
                    Id = c.IdAnalista,
                    Nombre = c.Nombre
                }).ToList();

            cmbAnalistas.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cmbAnalistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAnalistas.SelectedIndex == -1)
            {
                txtAnalistas.Text = string.Empty;
            }
            else
            {
                txtAnalistas.Text = cmbAnalistas.SelectedValue.ToString();

            }
        }

        public void listarDatos()
        {
           // dwgBitacora.DataSource = bitacora_SC.ListarBitacora();
        }





        public void InsertarBitacorafrm()
        {
            string f_emision = txtFechaemision.Text;
            string f_recepcion = txtFechaRegistro.Text;

            DateTime dateTimeF_Emision = DateTime.Now;
            DateTime dateTimeF_Recepcion = DateTime.Now;

            if (!string.IsNullOrEmpty(f_emision))
            {
                dateTimeF_Emision = DateTime.Parse(f_emision);
            }

            if (!string.IsNullOrEmpty(f_recepcion))
            {
                dateTimeF_Recepcion = DateTime.Parse(f_recepcion);
            }
           

            bitacora_VM.NumeroDocumentoPago = txtNumeroDocumetnoPago.Text;
            bitacora_VM.FechaEmisionDocumento = dateTimeF_Emision;
            bitacora_VM.FechaRecepcionDocumento = dateTimeF_Recepcion;
           // bitacora_VM.IvaDocumento = txtIva.Text;
            bitacora_VM.Observaciones = txtObservaciones.Text;
          //  bitacora_VM.ValorTotal = txtValor.Text;
            bitacora_VM.TipoOrden = txtTipoOrden.Text;
            bitacora_VM.EstadoBienesRecibidos = chkBienesRecibidos.Checked;

            bitacora_VM.IdTipoDocumentoPago = (int)cmbTipoDocumentoPago.SelectedValue;
            bitacora_VM.IdTipoDocumento = (int)cmbTipoDocumento.SelectedValue;
            bitacora_VM.IdAnalistas = (int)cmbAnalistas.SelectedValue;
            bitacora_VM.IdEstadoProceso = (int)cmbEstadoTipos.SelectedValue;



            if (txtIdBitacora.Text == "")
            {
                if (bitacora_SC.InsertarBitacora(bitacora_VM))
                {
                    MessageBox.Show("Registro Insertado Correctamente");
                    limpiarbitacora();
                }
                else
                {
                    MessageBox.Show("Error: No se Insertado registro, consulte a su Administrador");
                }
            }
            else
            {
                bitacora_VM.IdBitacora = int.Parse(txtIdBitacora.Text);
                if (bitacora_SC.ActualizarBitacora(bitacora_VM))
                {
                    MessageBox.Show("Registro Actualizado Correctamente");
                    limpiarbitacora();
                }
                else
                {
                    MessageBox.Show("Error: No se Actualizo el registro, consulte a su Administrador");
                }
            }
            listarDatos();
        }



        

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {
                MessageBox.Show("No se puede registrar campos vacios");
            }
            else
            {
                InsertarBitacorafrm();
            }

        }

        
        private bool ValidarCampos()
        {
            return false;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCRD_Proveedores FrmProveedires = new FrmCRD_Proveedores();
            FrmProveedires.Show();


        }

        private void btnCajas_Click(object sender, EventArgs e)
        {
            FrmCRD_Cajas frmCaja = new FrmCRD_Cajas();
            frmCaja.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void limpiarbitacora()
        {
            txtOrden.Text = "";
            txtIdEstadoProceso.Text = "";
            txtIdEstadoProceso.Text = "";
            txtRuc.Text = "";
            txtCodigoProveedor.Text = "";
            txtNombreProveedor.Text = "";
            txtSerie1.Text = "";
            txtSerie2.Text = "";
            txtSerie3.Text = "";
            txtNumeroDocumetnoPago.Text = "";
            //txtDiaFecha.Text = "";
            //txtMesFecha.Text = "";
            //txtAñoFecha.Text = "";
            txtFechaemision.Text = "";
            txtFechaOrden.Text = "";
            txtValor.Text = "";
            txtIdTipoDocumentoPago.Text = "";
            txtObservaciones.Text = "";
            txtTipoDocumento.Text = "";
            txtAnalistas.Text = "";
            txtTipoOrden.Text = "";
            txtSistemaOrigen.Text = "CRD";
            txtTipoProveedor.Text = "";
            txtCajaPaquete.Text = "";
            txtCodigoempresa.Text = "";
            txtEmpresa.Text = "";
            txtValijaOrigen.Text = "";
            txtValijaRemitente.Text = "";
            txtValijaObservacion.Text = "";

            txtReferencia.Text = "";
            txtRechazado.Text = "";
            txtVersion.Text = "1";
            chkBienesRecibidos.Checked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtHoraRegistro.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void ListardarsoDwBitacora()
        {
             dwgBitacora.DataSource = bitacora_SC.ListarBitacora();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaEmision_ValueChanged(object sender, EventArgs e)
        {
            txtFechaemision.Text = dtpFechaEmision.Value.ToString("dd/MM/yyyy");
            txtValor.Focus();
        }

        private void btnOrdenes_Click(object sender, EventArgs e)
        {
            FrmCRD_Ordenes frmOrdenes=new FrmCRD_Ordenes();
            frmOrdenes.Show();

        }

        private void txtSerie1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               e.SuppressKeyPress = true;
                txtSerie2.Focus();
            }
        }

        private void txtSerie2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtSerie3.Focus();
            }
        }

        private void txtSerie3_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string concatenatedText = txtSerie1.Text + "" + txtSerie2.Text + "" + txtSerie3.Text;

                if (concatenatedText.Length <= 15)
                {
                    txtNumeroDocumetnoPago.Text = concatenatedText;
                    dtpFechaEmision.Focus();
                }
                else{
                    MessageBox.Show("NO se puede ingresar mas de 15 digitos.");

                    txtSerie1.Text = "";
                    txtSerie2.Text = "";
                    txtSerie3.Text = "";
                    txtSerie1.Focus();

                }
            }

                        
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                cmbTipoDocumentoPago.Focus();
            }
        }

        private void txtObservaciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                cmbEmpresas.Focus();
            }
        }

        private void txtRuc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtSerie1.Focus();
            }
        }

        private void txtCodigoProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtSerie1.Focus();
            }
        }

        private void btnBuscarOrden_Click(object sender, EventArgs e)
        {
            var resultadoLista = ordenesControlador.ObtenerOrdenesPorNumeroOrden(txtOrden.Text);

            var orden = resultadoLista.FirstOrDefault();

            if(orden != null)
            {
                txtCodigoProveedor.Text = orden.Proveedor;
                txtNombreProveedor.Text = orden.DescProveedor;
                txtValor.Text = orden.ImporteBruto;
                txtTipoOrden.Text = Funcionalidades.ValidarCampoOrden(txtOrden.Text);
                txtSistemaOrigen.Text = orden.CodigoSistema;
                txtTipoProveedor.Text = orden.DescProveedor;
                txtFechaOrden.Text = orden.FechaOrden;
                txtReferencia.Text = orden.PersonaReferencia;
                chkBienesRecibidos.Checked = Funcionalidades.ConvertirABoolean(orden.Liberado);
                txtIva.Text = orden.Iva;
                txtEmpresa.Text = orden.DesCompania;
                txtCodigoempresa.Text = orden.Compania;
            } 
            else
            {
                MessageBox.Show("No se enconro información de ordenes", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbEstadoTipos.Focus();
                limpiarbitacora();
            }
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            var resultadoLista = proveedoresControlador.ObtenerProveedoresPorCodProveedores(txtCodigoProveedor.Text);

            var proveedor = resultadoLista.FirstOrDefault();

            if (proveedor != null)
            {
                txtRuc.Text = proveedor.RucCedula;
            }
            else
            {
                MessageBox.Show("No se enconro información de proveedor", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRuc.Focus();
                txtRuc.Text = string.Empty;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea eliminar Registro", "Eliminar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                bitacora_SC.EliminarBitacora(int.Parse(txtIdBitacora.Text));
                limpiarbitacora();
                listarDatos();
            }
        }

        private void btnBuscaFactura_Click(object sender, EventArgs e)
        {

            dwgBitacora.DataSource = bitacora_SC.ObtenerBitacoraPorNombre(txtNumeroDocumetnoPago.Text);
            MessageBox.Show("Busqeuda ok");

            

        }
    }
}


