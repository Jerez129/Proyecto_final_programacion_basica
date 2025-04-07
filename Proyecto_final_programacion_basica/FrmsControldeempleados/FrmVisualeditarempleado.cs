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

            CN_Control_Empleados empleado = new CN_Control_Empleados();
            empleado.IdEmpleado = Convert.ToInt32(txtId_Empleadoeditar.Text);
            empleado.Nombre = txtNombreeditar.Text;
            empleado.Apellido = txtApellidoeditar.Text;
            empleado.Cedula = txtCedulaeditar.Text;
            empleado.Correo = txtCorreoeditar.Text;
            empleado.Telefono = txtTelefonoeditar.Text;
            empleado.FechaNacimiento = dtpFechanacimientoeditar.Value;
            empleado.FechaIngreso = dtpFechaingresoeditar.Value;
            empleado.SalarioBase = txtSalariobaseeditar.Text == "0" ? 0 : Convert.ToDecimal(txtSalariobaseeditar.Text);
            empleado.Cargo = cbCargoeditar.Text;
            empleado.IdDireccion = Convert.ToInt32(cbDireccioneditar.SelectedValue);
            empleado.IdDepartamento = Convert.ToInt32(cbDepartamentoeditar.SelectedValue);
            empleado.IdGenero = Convert.ToInt32(cbGeneroeditar.SelectedValue);
            empleado.Editar(empleado);
            MessageBox.Show("Empleado editado exitosamente.");
            Mostrarempleadodetallado();
            Limpiarcampos();
        }



        private void dgvEmpleadosEditar_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CN_Control_Empleados empleado = new CN_Control_Empleados();
            empleado.IdEmpleado = Convert.ToInt32(txtId_Empleadoeditar.Text);
            empleado.Eliminar(empleado);
            Mostrarempleadodetallado();
            Limpiarcampos();

        }

        private void btnCerrarvisualeditarempleado_Click(object sender, EventArgs e)
        {
            FrmVisualcontroldeempleados frm = new FrmVisualcontroldeempleados();
            this.Close();
            frm.Show();
        }
    }
}
