using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Capa_Presentacion_Proyecto_Final
{
    public partial class FrmVisualregistrarempleado : Form
    {
        public FrmVisualregistrarempleado()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Limpia todos los campos del formulario.
        /// </summary>
        private void Limpiarcampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCedula.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtSalariobase.Clear();
            dtpFechanacimiento.Value = DateTime.Now;
            dtpFechaingreso.Value = DateTime.Now;
            cbCargo.SelectedIndex = -1;
            cbDireccion.SelectedIndex = -1;
            cbGenero.SelectedIndex = -1;
            cbDepartamento.SelectedIndex = -1;
        }

        /// <summary>
        /// Evento que se ejecuta al hacer clic en el botón de registrar usuario.
        /// Valida los datos, inserta el nuevo empleado y muestra mensajes según el resultado.
        /// </summary>
        private void btnRegistrarusuario_Click(object sender, EventArgs e)
        {
            CN_Control_Empleados empleado = new CN_Control_Empleados();

            empleado.Nombre = txtNombre.Text;
            empleado.Apellido = txtApellido.Text;
            empleado.Cedula = txtCedula.Text;
            empleado.Correo = txtCorreo.Text;
            empleado.Telefono = txtTelefono.Text;
            empleado.FechaNacimiento = dtpFechanacimiento.Value;
            empleado.FechaIngreso = dtpFechaingreso.Value;
            // Validación para el salario base
            if (string.IsNullOrWhiteSpace(txtSalariobase.Text) || !decimal.TryParse(txtSalariobase.Text, out decimal salario))
            {
                MessageBox.Show("El salario base debe ser un número válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir si el salario base no es válido
            }
            empleado.SalarioBase = salario; // Asignar el salario base al objeto empleado
            empleado.IdDireccion = Convert.ToInt32(cbDireccion.SelectedValue);
            empleado.Cargo = cbCargo.Text;
            empleado.IdDepartamento = Convert.ToInt32(cbDepartamento.SelectedValue);
            empleado.IdGenero = Convert.ToInt32(cbGenero.SelectedValue);

            // Validación de los datos del objeto empleado
            string mensajeError;
            if (empleado.Validacion(out mensajeError))  // Llamamos a Validacion con out
            {
                // Si la validación es correcta, registrar el empleado
                empleado.Insertar(empleado);
                MessageBox.Show("Empleado registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiarcampos();
            }
            else
            {
                // Si hay un error de validación, mostrar el mensaje de error
                MessageBox.Show(mensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /// <summary>
        /// Evento que se ejecuta al cargar el formulario. Llena los combobox con datos desde la base de datos.
        /// </summary>
        private void FrmVisualregistrarempleado_Load(object sender, EventArgs e)
        {
            CN_Control_Empleados empleado = new CN_Control_Empleados();
            cbDireccion.DataSource = empleado.MostrarDireccion();
            cbDireccion.DisplayMember = "Direccion"; // Nombre de la columna que se mostrará
            cbDireccion.ValueMember = "id_Direccion"; // Nombre de la columna que se usará como valor
            cbDireccion.SelectedIndex = -1;

            cbGenero.DataSource = empleado.MostrarGenero();
            cbGenero.DisplayMember = "MostrarGenero"; // Mostrar "Masculino" o "Femenino"
            cbGenero.ValueMember = "id_Genero"; // Usar el id_Genero como valor subyacente
            cbGenero.SelectedIndex = -1; // No seleccionar ningún ítem por defecto

            cbDepartamento.DataSource = empleado.MostrarDepartamento();
            cbDepartamento.DisplayMember = "NombreDepartamento"; // Nombre de la columna que se mostrará
            cbDepartamento.ValueMember = "id_Departamento"; // Nombre de la columna que se usará como valor
            cbDepartamento.SelectedIndex = -1; // No seleccionar ningún ítem por defecto


        }

        /// <summary>
        /// Cierra el formulario actual y muestra el formulario de control de empleados.
        /// </summary>
        private void btnCerrarvisualregistraremplead_Click(object sender, EventArgs e)
        {
            FrmVisualcontroldeempleados frm = new FrmVisualcontroldeempleados();
            this.Close();
            frm.Show();
        }


        /// <summary>
        /// Solo permite ingresar letras en el campo de nombre.
        /// </summary>
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y retroceso, impedir números y símbolos
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear el carácter
            }
        }

        /// <summary>
        /// Solo permite ingresar letras en el campo de apellido.
        /// </summary>
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y retroceso, impedir números y símbolos
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear el carácter
            }
        }

        /// <summary>
        /// Solo permite ingresar números en el campo de cédula.
        /// </summary>
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear el carácter
            }
        }

        /// <summary>
        /// Solo permite ingresar números en el campo de teléfono.
        /// </summary>
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear el carácter
            }
        }

        /// <summary>
        /// Solo permite ingresar números en el campo de salario base.
        /// </summary>
        private void txtSalariobase_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y retroceso
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear el carácter
            }
        }
    }

}
