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
            // Establecer los placeholders
            SetPlaceholder(txtUsuario, "Usuario");
            SetPlaceholder(txtClave, "Clave");

            // Ocultar la contraseña por defecto
            txtClave.UseSystemPasswordChar = true;

            // Cargar imagen de ojito cerrado
            pictureBox2.Image = Capa_Presentacion.Properties.Resources.hide;

            // Asegúrate de que el estado esté sincronizado
            passwordVisible = false;
        }


        private bool passwordVisible = true;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (passwordVisible)
            {
                // Muestra la contraseña
                txtClave.UseSystemPasswordChar = false;
                pictureBox2.Image = Capa_Presentacion.Properties.Resources.show;
            }
            else
            {
                // Oculta la contraseña
                txtClave.UseSystemPasswordChar = true;
                pictureBox2.Image = Capa_Presentacion.Properties.Resources.hide;
            }
            passwordVisible = !passwordVisible;
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        //Aqui precargo el ojito para que se pueda utilizar desde que se compila el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            /// Oculta la contraseña por defecto
            txtClave.UseSystemPasswordChar = true;

            // Carga el ojito cerrado como imagen inicial
            pictureBox2.Image = Capa_Presentacion.Properties.Resources.show;

            // Inicializa el estado
            passwordVisible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}