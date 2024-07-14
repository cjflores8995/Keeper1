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
    public partial class Frm_InsertarNuevoPassword : Form
    {
        CRD_UsuariosControlador controlador;
        CRD_UsuariosVistaModelo vistaModelo;

        public Frm_InsertarNuevoPassword()
        {
            InitializeComponent();

            controlador = new CRD_UsuariosControlador();
            vistaModelo = new CRD_UsuariosVistaModelo();
        }

        private void btnResetearPassword_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtViejoPassword.Text) || string.IsNullOrEmpty(txtNuevoPassword.Text))
            {
                MessageBox.Show("Todos los campos son requeridos", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ResetearPassword();
            }
        }

        private void ResetearPassword()
        {
            var passwordHash = Funcionalidades.ConvertirStringEnSHA256(txtViejoPassword.Text);
            var resultado = controlador.LoginUsuarioConEmail(txtEmail.Text, passwordHash);

            if (resultado)
            {
                var usuario = controlador.ObtenerUsuarioPorEmail(txtEmail.Text);
                if (usuario != null)
                {
                    vistaModelo.Id = usuario.Id;
                    vistaModelo.PasswordHash = txtNuevoPassword.Text;

                    var result = controlador.SetearPasswordPorDefecto(vistaModelo);

                    if (result)
                    {
                        MessageBox.Show("La contraseña se reestablecio correctamente", "Proceso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var nuevoPasswordHash = Funcionalidades.ConvertirStringEnSHA256(txtNuevoPassword.Text);
                        var validLogin = controlador.LoginUsuarioConEmail(txtEmail.Text, nuevoPasswordHash);

                        if (validLogin)
                        {
                            MDIPrincipal main = new MDIPrincipal();
                            main.Show();
                            main.WindowState = FormWindowState.Maximized;
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("No se pudo acceder, comunicate con el administrador", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el password", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El email o password son incorrectos", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
