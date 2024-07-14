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
    public partial class FrmCRD_AuditoriaBitacora : Form
    {
        private CRD_AuditoriaBitacoraControlador controlador;
        private CRD_AuditoriaBitacoraVistaModelo vistaModelo;

        private static FrmCRD_AuditoriaBitacora instancia = null;

        public static FrmCRD_AuditoriaBitacora VentanaUnica()
        {
            if (instancia == null)
            {
                instancia = new FrmCRD_AuditoriaBitacora();
                return instancia;
            }
            return instancia;
        }

        public FrmCRD_AuditoriaBitacora()
        {
            InitializeComponent();
            controlador = new CRD_AuditoriaBitacoraControlador();
            vistaModelo = new CRD_AuditoriaBitacoraVistaModelo();
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
    }
}
