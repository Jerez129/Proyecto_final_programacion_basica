using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Capa_Presentacion_Proyecto_Final
{
    //1
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarsesión_Click(object sender, EventArgs e)
        {
           CN_Login.UsuarioNegocio usuarioNegocio = new CN_Login.UsuarioNegocio();

            if (usuarioNegocio.IniciarSesion(txtUsuario.Text, txtClave.Text))
            {
                MessageBox.Show("Bienvenido");
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }

        }
    }
}
