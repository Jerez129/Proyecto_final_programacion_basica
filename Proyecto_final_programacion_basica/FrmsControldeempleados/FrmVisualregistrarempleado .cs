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

namespace Capa_Presentacion_Proyecto_Final
{
    public partial class FrmVisualregistrarempleado : Form
    {
        public FrmVisualregistrarempleado()
        {
            InitializeComponent();
        }

        private void btnRegistrarusuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("HOLA MENOL");
            CN_Control_Empleados empleados = new CN_Control_Empleados();
            try
            {
                //empleados.Insertar(txtNombre.Text, txtApellido.Text, txtCedula.Text, cbCargo.Text, txtTelefono.Text, txtFechaIngreso.Text, cbDireccion.Text, cbGenero.Text, cbDepartamento.Text, txtFechaNacimiento.Text, txtCorreo.Text );
                MessageBox.Show("Empleado registrado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar el empleado" + ex);
            }
        }

        private void FrmVisualregistrarempleado_Load(object sender, EventArgs e)
        {

        }
    }
}
