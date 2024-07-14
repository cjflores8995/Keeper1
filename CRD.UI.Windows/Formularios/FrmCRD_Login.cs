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

using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CRD.UI.Windows.Formularios
{
    public partial class FrmLogin : Form
    {
        private CRD_UsuariosControlador controlador;
        private CRD_UsuariosVistaModelo vistaModelo;


        

        public FrmLogin()
        {
            InitializeComponent();
            controlador = new CRD_UsuariosControlador();
            vistaModelo = new CRD_UsuariosVistaModelo();
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtUsuario.Clear();
            txtPassword.Clear();
            
            lblError.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }

        private void btnAcceder_Click_1(object sender, EventArgs e)
        {
            lblError.Visible = false;
            lblError.Text = string.Empty;

            if (!string.IsNullOrEmpty(txtUsuario.Text))
            {
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    var validLogin = controlador.LoginUsuario(txtUsuario.Text, txtPassword.Text);

                    if (validLogin)
                    {


                        MDIPrincipal main = new MDIPrincipal();
                        main.Show();
                        main.FormClosed += Logout;
                        main.WindowState = FormWindowState.Maximized;
                        this.Hide();

                    }
                    else
                    {
                        CustomMessages.UsuarioOPasswordIncorrectos();
                        txtUsuario.Text = string.Empty;
                        txtPassword.Text = string.Empty;
                    }
                }
                else
                {
                    lblError.Text = "Ingresa la contraseña";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Ingresa nombre de usuario";
                lblError.Visible = true;
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            Frm_CRD_RegistroDeUsuarios frm = new Frm_CRD_RegistroDeUsuarios();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Frm_CRD_ReseteoPassword frm = new Frm_CRD_ReseteoPassword();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }
    }
}
