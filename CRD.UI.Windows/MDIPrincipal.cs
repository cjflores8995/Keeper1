using CRD.UI.Windows.Formularios;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRD.UI.Windows
{
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirBitacora(object sender, EventArgs e)
        {
            FrmCRD_Bitacora frm = new FrmCRD_Bitacora();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_RegistroUsuario frm = new FrmCRD_RegistroUsuario();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_AuditoriaBitacora frm = new FrmCRD_AuditoriaBitacora();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Ordenes frm = new FrmCRD_Ordenes();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void cajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Cajas frm = new FrmCRD_Cajas();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void paquetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Paquetes frm = new FrmCRD_Paquetes();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void valijasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Valijas frm = new FrmCRD_Valijas();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void analistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Analistas frm = new FrmCRD_Analistas();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Cargos frm = new FrmCRD_Cargos();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Ciudad frm = new FrmCRD_Ciudad();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Departamento frm = new FrmCRD_Departamento();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Empresas frm = new FrmCRD_Empresas();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void estadoTipoProcesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_EstadoTipoProcesos frm =new FrmCRD_EstadoTipoProcesos();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void ivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Iva frm = new FrmCRD_Iva();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void tipoDocumentoPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_TipoDocumentoPagos frm = new FrmCRD_TipoDocumentoPagos();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void tipoDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_TipoDocumentos frm = new FrmCRD_TipoDocumentos();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Proveedores frm = new FrmCRD_Proveedores();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Bitacora frm = new FrmCRD_Bitacora();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }
    }
}
