using CRD.UI.Windows.ControladoresApp;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using CRD.Infraestructura.CrossCuting.Messages;
using CRD.UI.Windows.VistaModelo;

namespace CRD.UI.Windows.Formularios
{
    public partial class Frm_CRD_ReseteoPassword : Form
    {
        CRD_UsuariosControlador usuarioControlador;

        public Frm_CRD_ReseteoPassword()
        {
            InitializeComponent();

            usuarioControlador = new CRD_UsuariosControlador();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            EnviarEmailRecordatorioPassword();
        }

        public void EnviarEmailRecordatorioPassword()
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Deber ingresar un correo electronico", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var usuarioExiste = usuarioControlador.ObtenerUsuarioPorEmail(txtEmail.Text);

                if(usuarioExiste != null && usuarioExiste.Email != null)
                {
                    EnviarEmailConTokenMock(usuarioExiste);
                }
                else
                {
                    MessageBox.Show("El usuari ingresado no pertenece al sistema", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void EnviarEmailConTokenMock(CRD_UsuariosVistaModelo usuario)
        {
            string configEmail = ConfigurationManager.AppSettings["Email"];
            string configPassword = ConfigurationManager.AppSettings["Password"];

            string toAddress = usuario.Email;
            string token = "abcd1234";

            try
            {
                usuario.PasswordHash = token;
                usuarioControlador.SetearPasswordPorDefecto(usuario);

                MessageBox.Show($"Un mensaje con la clave se ha enviado a tu correo", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                linkResetear.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar email: {ex.Message}", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnviarEmailConToken(CRD_UsuariosVistaModelo usuario)
        {
            string configEmail = ConfigurationManager.AppSettings["Email"];
            string configPassword = ConfigurationManager.AppSettings["Password"];

            string toAddress = usuario.Email; 
            string subject = "Token para recordar contraseña";
            string token = Funcionalidades.GenerateAlphanumericValue(10);
            string body = $"La clave temporal es: {token}"; 
            
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587)
                {
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(configEmail, configPassword),
                    EnableSsl = true
                };

                MailMessage mailMessage = new MailMessage(configEmail, toAddress, subject, body);


                smtpClient.Send(mailMessage);

                MessageBox.Show($"Un mensaje con la clave se ha enviado a tu correo", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al enviar email: {ex.Message}", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkResetear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_InsertarNuevoPassword frm = new Frm_InsertarNuevoPassword();
            frm.FormClosed += (s, args) => this.Close();
            frm.Show();
            this.Hide();
        }
    }
}
