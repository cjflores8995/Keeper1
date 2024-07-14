using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRD.Infraestructura.CrossCuting.Messages
{
    public static class Funcionalidades
    {
        public static void LimpiarCampos(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
                else if (c.Controls.Count > 0)
                {
                    LimpiarCampos(c);
                }
            }
        }

        public static string ConvertirStringEnSHA256(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password.ToLower()));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static string GenerateAlphanumericValue(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string ValidarCampoOrden(string entrada)
        {
            if(int.TryParse(entrada, out int number))
            {
                return "OC";
            } else
            {
                return "OS";
            }
        }

        public static bool ConvertirABoolean(string input)
        {
            string normalizarString = input.ToLower().Trim();

            if(normalizarString == "verdadero" || normalizarString == "true")
            {
                return true;
            }
            else{
                return false;
            }
        }
    }
}
