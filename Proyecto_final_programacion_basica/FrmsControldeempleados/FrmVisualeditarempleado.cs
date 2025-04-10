using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Presentacion_Proyecto_Final;

namespace Capa_Presentacion.FrmsControldeempleados
{
    public partial class FrmVisualeditarempleado : Form
    {
        public FrmVisualeditarempleado()
        {
            InitializeComponent();
            Mostrarempleadodetallado();
        }

        private void Mostrarempleadodetallado()
        {
            CN_Control_Empleados empleado = new CN_Control_Empleados();
            DataTable empleados = empleado.Mostrar();
            dgvEmpleadosEditar.DataSource = empleados;
            dgvEmpleadosEditar.Columns["id_Departamento"].Visible = false;
            dgvEmpleadosEditar.Columns["id_Direccion"].Visible = false;
            dgvEmpleadosEditar.Columns["id_Genero"].Visible = false;
        }
        private void Limpiarcampos()
        {

            txtId_Empleadoeditar.Clear();
            txtNombreeditar.Clear();
            txtApellidoeditar.Clear();
            txtCedulaeditar.Clear();
            txtCorreoeditar.Clear();
            txtTelefonoeditar.Clear();
            txtSalariobaseeditar.Clear();
            dtpFechanacimientoeditar.Value = DateTime.Now;
            dtpFechaingresoeditar.Value = DateTime.Now;
            cbCargoeditar.SelectedIndex = -1;
            cbDireccioneditar.SelectedIndex = -1;
            cbGeneroeditar.SelectedIndex = -1;
            cbDepartamentoeditar.SelectedIndex = -1;



        }
        private void FrmVisualeditarempleado_Load(object sender, EventArgs e)
        {
            CN_Control_Empleados empleado = new CN_Control_Empleados();
            cbDireccioneditar.DataSource = empleado.MostrarDireccion();
            cbDireccioneditar.DisplayMember = "Direccion"; // Nombre de la columna que se mostrará
            cbDireccioneditar.ValueMember = "id_Direccion"; // Nombre de la columna que se usará como valor
            cbDireccioneditar.SelectedIndex = -1;

            cbGeneroeditar.DataSource = empleado.MostrarGenero();
            cbGeneroeditar.DisplayMember = "MostrarGenero"; // Mostrar "Masculino" o "Femenino"
            cbGeneroeditar.ValueMember = "id_Genero"; // Usar el id_Genero como valor subyacente
            cbGeneroeditar.SelectedIndex = -1; // No seleccionar ningún ítem por defecto

            cbDepartamentoeditar.DataSource = empleado.MostrarDepartamento();
            cbDepartamentoeditar.DisplayMember = "NombreDepartamento"; // Nombre de la columna que se mostrará
            cbDepartamentoeditar.ValueMember = "id_Departamento"; // Nombre de la columna que se usará como valor
            cbDepartamentoeditar.SelectedIndex = -1; // No seleccionar ningún ítem por defecto
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvEmpleadosEditar.SelectedRows.Count > 0)
            {


                CN_Control_Empleados empleado = new CN_Control_Empleados();
                empleado.IdEmpleado = Convert.ToInt32(txtId_Empleadoeditar.Text);
                empleado.Nombre = txtNombreeditar.Text;
                empleado.Apellido = txtApellidoeditar.Text;
                empleado.Cedula = txtCedulaeditar.Text;
                empleado.Correo = txtCorreoeditar.Text;
                empleado.Telefono = txtTelefonoeditar.Text;
                empleado.FechaNacimiento = dtpFechanacimientoeditar.Value;
                empleado.FechaIngreso = dtpFechaingresoeditar.Value;
                // Validación para el salario base
                if (string.IsNullOrWhiteSpace(txtSalariobaseeditar.Text) || !decimal.TryParse(txtSalariobaseeditar.Text, out decimal salario))
                {
                    MessageBox.Show("El salario base debe ser un número válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Salir si el salario base no es válido
                }
                empleado.SalarioBase = salario; // Asignar el salario base al objeto empleado
                empleado.Cargo = cbCargoeditar.Text;
                empleado.IdDireccion = Convert.ToInt32(cbDireccioneditar.SelectedValue);
                empleado.IdDepartamento = Convert.ToInt32(cbDepartamentoeditar.SelectedValue);
                empleado.IdGenero = Convert.ToInt32(cbGeneroeditar.SelectedValue);

                string mensajeError;
                if (empleado.ValidacionEditar(out mensajeError))  // Llamamos a Validacion con out

                {
                    // Si la validación es correcta, registrar el empleado
                    empleado.Editar(empleado);
                    MessageBox.Show("Empleado editado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiarcampos();
                }
                else
                {
                    // Si hay un error de validación, mostrar el mensaje de error
                    MessageBox.Show(mensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Mostrarempleadodetallado();

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para editar.");
                return;
            }
          
        }



        private void dgvEmpleadosEditar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica que no haya clic en la casilla de selección de fila (RowIndex == -1)
            if (e.RowIndex >= 0) // Aseguramos que se haya hecho clic en una fila válida
            {
                if (dgvEmpleadosEditar.SelectedRows.Count > 0)
                {
                    DataGridViewRow fila = dgvEmpleadosEditar.SelectedRows[0];
                    txtId_Empleadoeditar.Text = fila.Cells["id_Empleado"].Value.ToString();
                    txtNombreeditar.Text = fila.Cells["Nombre"].Value.ToString();
                    txtApellidoeditar.Text = fila.Cells["Apellido"].Value.ToString();
                    txtCedulaeditar.Text = fila.Cells["Cedula"].Value.ToString();
                    txtCorreoeditar.Text = fila.Cells["Correo"].Value.ToString();
                    txtTelefonoeditar.Text = fila.Cells["Telefono"].Value.ToString();
                    dtpFechanacimientoeditar.Value = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value);
                    dtpFechaingresoeditar.Value = Convert.ToDateTime(fila.Cells["FechaIngreso"].Value);
                    txtSalariobaseeditar.Text = fila.Cells["SalarioBase"].Value.ToString();
                    cbCargoeditar.Text = fila.Cells["Cargo"].Value.ToString();
                    cbDepartamentoeditar.SelectedValue = Convert.ToInt32(fila.Cells["id_Departamento"].Value);
                    cbDireccioneditar.SelectedValue = Convert.ToInt32(fila.Cells["id_Direccion"].Value);
                    cbGeneroeditar.SelectedValue = Convert.ToInt32(fila.Cells["id_Genero"].Value);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado alguna fila en el DataGridView
            if (dgvEmpleadosEditar.SelectedRows.Count > 0)
            {
                // Obtener el ID del empleado de la fila seleccionada
                int idEmpleado = Convert.ToInt32(dgvEmpleadosEditar.SelectedRows[0].Cells["id_Empleado"].Value);

                // Crear el objeto empleado y eliminarlo
                CN_Control_Empleados empleado = new CN_Control_Empleados();
                empleado.IdEmpleado = idEmpleado;
                empleado.Eliminar(empleado);

                // Actualizar la vista
                Mostrarempleadodetallado();
                Limpiarcampos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un empleado para eliminar.");
            }

        }

        private void btnCerrarvisualeditarempleado_Click(object sender, EventArgs e)
        {
            FrmVisualcontroldeempleados frm = new FrmVisualcontroldeempleados();
            this.Close();
            frm.Show();
        }

        private void txtNombreeditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y retroceso, impedir números y símbolos
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear el carácter
            }

        }

        private void txtApellidoeditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras y retroceso, impedir números y símbolos
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear el carácter
            }
        }

        private void txtCedulaeditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo numeros y retroceso, impedir letras
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear el carácter
            }
        }

        private void txtTelefonoeditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo numeros y retroceso, impedir letras
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear el carácter
            }
        }

        private void txtSalariobaseeditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo numeros y retroceso, impedir letras
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear el carácter
            }

        }


    }
}
