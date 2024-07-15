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
    public partial class Frm_CRD_RegistroDeUsuarios : Form
    {
        CRD_UsuariosControlador controlador;
        CRD_UsuariosVistaModelo vistaModelo;

        CRD_CargoControlador cargoControlador;
        CRD_DepartamentoControlador departamentoControlador;
        CRD_CiudadControlador ciudadControlador;

        private CRD_UsuariosControlador loginControlador;

        public Frm_CRD_RegistroDeUsuarios()
        {
            InitializeComponent();

            controlador = new CRD_UsuariosControlador();
            vistaModelo = new CRD_UsuariosVistaModelo();

            cargoControlador = new CRD_CargoControlador();
            departamentoControlador = new CRD_DepartamentoControlador();
            ciudadControlador = new CRD_CiudadControlador();
            loginControlador = new CRD_UsuariosControlador();
        }

        private void InsertUsuario()
        {
            vistaModelo = CrearObjeto();
            var resultado = Insertar(vistaModelo);

            if (resultado)
            {
                var validLogin = controlador.LoginUsuario(txtUsuario.Text, txtPassword.Text);

                if (validLogin)
                {


                    MDIPrincipal main = new MDIPrincipal();
                    main.Show();
                    main.WindowState = FormWindowState.Maximized;
                    this.Hide();

                }
                else
                {
                    CustomMessages.UsuarioOPasswordIncorrectos();
                }
            }
            else
            {
                MessageBox.Show("Error en el registro, comunicate con el administrador", "Error En Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool Insertar(CRD_UsuariosVistaModelo vistaModelo)
        {
            var resultado = controlador.Insertar(vistaModelo);
            CustomMessages.RespuestaProcesoDb(resultado);

            return resultado;
        }

        private CRD_UsuariosVistaModelo CrearObjeto()
        {
            CRD_UsuariosVistaModelo resultado = new CRD_UsuariosVistaModelo();

            resultado.Nombre = txtNombre.Text;
            resultado.Apellido = txtApellido.Text;
            resultado.Email = txtEmail.Text;
            resultado.PasswordHash = txtPassword.Text;
            resultado.NombreUsuario = txtUsuario.Text;
            resultado.IdCargo = cargoControlador.ObtenerElementoPorNombre("desconocido").IdCargo;
            resultado.IdDepartamento = departamentoControlador.ObtenerElementoPorNombre("desconocido").IdDepartamento;
            resultado.IdCiudad = ciudadControlador.ObtenerElementoPorNombre("desconocido").IdCiudad;


            return resultado;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InsertUsuario();
        }
    }
}
