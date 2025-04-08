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

        private void btnCerrarvisualregistraremplead_Click(object sender, EventArgs e)
        {
            FrmVisualcontroldeempleados frm = new FrmVisualcontroldeempleados();
              this.Close();
              frm.Show();
        }

    }

}
