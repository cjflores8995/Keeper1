using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRD.Infraestructura.CrossCuting.Messages
{
    public static class CustomMessages
    {
        public static string ConfirmacionActualizacion = "¿Seguro que desea actualizar el registro?";
        public static string ConfirmacionEliminacion = "¿Seguro que desea eliminar el registro?";
        public static void RespuestaProcesoDb(bool result)
        {
            if (result)
            {
                MessageBox.Show("Proceso realizado correctamente.", "Proceso Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al realizar el proceso", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DialogResult DebesSeleccionarRegistro()
        {
            return MessageBox.Show("Debes seleccionar un registro", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult DebesLlenarCamposRequeridos()
        {
            return MessageBox.Show("Debes llenar los campos requeridos", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult UsuarioOPasswordIncorrectos()
        {
            return MessageBox.Show("El usuario o password son incorrectos", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
