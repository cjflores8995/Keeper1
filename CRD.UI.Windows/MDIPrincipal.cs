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
            FrmCRD_Bitacora frm = FrmCRD_Bitacora.VentanaUnica(); ;
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_RegistroUsuario frm = FrmCRD_RegistroUsuario.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_AuditoriaBitacora frm = FrmCRD_AuditoriaBitacora.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Ordenes frm = FrmCRD_Ordenes.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void cajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Cajas frm = FrmCRD_Cajas.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void paquetesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Paquetes frm = FrmCRD_Paquetes.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void valijasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmValijas frm = FrmValijas.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void analistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Analistas frm = FrmCRD_Analistas.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargo frm = frmCargo.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Ciudad frm = FrmCRD_Ciudad.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Departamento frm = FrmCRD_Departamento.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Empresas frm = FrmCRD_Empresas.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void estadoTipoProcesosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_EstadoTipoProcesos frm = FrmCRD_EstadoTipoProcesos.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void ivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Iva frm = FrmCRD_Iva.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void tipoDocumentoPagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_TipoDocumentoPagos frm = FrmCRD_TipoDocumentoPagos.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void tipoDocumentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_TipoDocumentos frm = FrmCRD_TipoDocumentos.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Proveedores frm = FrmCRD_Proveedores.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCRD_Bitacora frm = FrmCRD_Bitacora.VentanaUnica();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }
    }
}
