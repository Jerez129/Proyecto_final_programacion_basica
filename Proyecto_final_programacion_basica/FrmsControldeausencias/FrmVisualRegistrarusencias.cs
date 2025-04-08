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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Capa_Presentacion.FrmsControldeasencias
{
    public partial class FrmVisualRegistrarusencias : Form
    {


        public FrmVisualRegistrarusencias(int id, string nombre, string apellido, string cedula)
        {
            InitializeComponent();

            // Asignar los valores a los TextBox
            txtIdEmpleado.Text = id.ToString();
            txtNombreAusencia.Text = nombre;
            txtApellidoAusencia.Text = apellido;
            txtCedulaAusencia.Text = cedula;
            CargarTiposAusencias();
            CargarAprobacion();
        }


        private void CargarTiposAusencias()
        {
            CN_Control_Ausencias ausencias = new CN_Control_Ausencias();
            DataTable dt = ausencias.MostrarTipodeausencia();

            cbTipodeausencia.DataSource = dt;
            cbTipodeausencia.DisplayMember = "Tipo";  // La columna visible
            cbTipodeausencia.ValueMember = "id_Tipo_Ausencia";  // El valor interno
        }

        private void CargarAprobacion()
        {
            // Crear la lista de valores gráficos con los valores booleanos
            List<KeyValuePair<string, bool>> estados = new List<KeyValuePair<string, bool>>
            {
             new KeyValuePair<string, bool>("Aprobado", true),   // Para "Aprobado" será true
             new KeyValuePair<string, bool>("No Aprobado", false) // Para "No Aprobado" será false
            };

            // Configurar el ComboBox
            cbAprobacionausencia.DataSource = estados;
            cbAprobacionausencia.DisplayMember = "Key";  // Muestra "Aprobado" o "No Aprobado"
            cbAprobacionausencia.ValueMember = "Value";  // El valor será true o false
            cbAprobacionausencia.SelectedIndex = 0;  // Establecer por defecto "Aprobado"
        }

        private void Limpiarcampos()
        {
            txtIdEmpleado.Clear();
            txtNombreAusencia.Clear();
            txtApellidoAusencia.Clear();
            txtCedulaAusencia.Clear();
            dtpFechadeinicio.Value = DateTime.Now;
            dtpFechadefin.Value = DateTime.Now;
            cbTipodeausencia.SelectedIndex = -1;
            cbAprobacionausencia.SelectedIndex = -1; 
        }

        private void FrmVisualRegistrarusencias_Load(object sender, EventArgs e)
        {

        }



        private void dgvAusencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrarausencia_Click(object sender, EventArgs e)
        {
            CN_Control_Ausencias ausencia = new CN_Control_Ausencias();

            ausencia.IdEmpleado = Convert.ToInt32(txtIdEmpleado.Text); /// El id del empleado
            ausencia.FechaInicio = dtpFechadeinicio.Value;
            ausencia.FechaFin = dtpFechadefin.Value;
            ausencia.IdTipoAusencia = Convert.ToInt32(cbTipodeausencia.SelectedValue); // Id del tipo de ausencia
            ausencia.Aprobado = ((KeyValuePair<string, bool>)cbAprobacionausencia.SelectedItem).Value;  // Valor booleano (true o false)
                                                                                                        // Insertar en la base de datos


            string mensajeError;
            if (ausencia.Validacion(out mensajeError))  // Llamamos a Validacion con out
            {
                // Si la validación es correcta, registrar la ausencia
                ausencia.Insertar(ausencia);
                MessageBox.Show("Ausencia registrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cerrar el formulario después de registrar la ausencia
            }
            else
            {
                // Si la validación falla, mostrar el mensaje de error específico
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
