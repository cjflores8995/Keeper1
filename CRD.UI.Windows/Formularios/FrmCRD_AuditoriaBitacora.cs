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


        public FrmCRD_AuditoriaBitacora()
        {
            InitializeComponent();
            controlador = new CRD_AuditoriaBitacoraControlador();
            vistaModelo = new CRD_AuditoriaBitacoraVistaModelo();
            ListarRegistros();

            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void ListarRegistros()
        {
            dgvLista.DataSource = controlador.ListarTodo();
        }
    }
}
