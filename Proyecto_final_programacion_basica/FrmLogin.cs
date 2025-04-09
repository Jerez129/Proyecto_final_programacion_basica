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

    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarsesión_Click(object sender, EventArgs e)
        {
            CN_Login.UsuarioNegocio usuarioNegocio = new CN_Login.UsuarioNegocio();

            bool esUsuarioValido = usuarioNegocio.IniciarSesion(txtUsuario.Text.Trim(), txtClave.Text.Trim());

            if (esUsuarioValido)
            {
                MessageBox.Show("Bienvenido");
                FrmPrincipal frmPrincipal = new FrmPrincipal();
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectos");
            }
        }

        // Eliminar el marcador de posición cuando el usuario empieza a escribir
        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black; // Color del texto normal
            }
        }

        // Agregar el marcador de posición si el campo está vacío
        private void AddPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray; // Color del texto del marcador de posición
            }
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray; // Color del texto del marcador de posición
            textBox.GotFocus += (sender, e) => RemovePlaceholder(sender as TextBox, placeholder);
            textBox.LostFocus += (sender, e) => AddPlaceholder(sender as TextBox, placeholder);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            // Establecer los placeholders en los campos de usuario y clave
            SetPlaceholder(txtUsuario, "Usuario");
            SetPlaceholder(txtClave, "Clave");

        }
        private bool showPassword = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            /*showPassword = !showPassword;
            if (showPassword)
            {
                txtClave.PasswordChar = '\0';
                pictureBox2.Image = Capa_Presentacion.Properties.Resources.hide;
            }
            else
            {
                txtClave.PasswordChar = '*';
                pictureBox2.Image = Capa_Presentacion.Properties.Resources.show;
            }*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
