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
        }

        private void CargarTiposAusencias()
        {
            CN_Control_Ausencias ausencias = new CN_Control_Ausencias();
            DataTable dt = ausencias.MostrarTipodeausencia();

            cbTipodeausencia.DataSource = dt;
            cbTipodeausencia.DisplayMember = "Nombre";  // La columna visible
           cbTipodeausencia.ValueMember = "id_Tipo_Ausencia";  // El valor interno
        }

        private void FrmVisualRegistrarusencias_Load(object sender, EventArgs e)
        {
                    
        }

        private void dgvAusencias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRegistrarausencia_Click(object sender, EventArgs e)
        {
            AusenciasModel ausencia = new AusenciasModel();

            ausencia.IdEmpleado = Convert.ToInt32(txtIdEmpleado.Text); /// El id del empleado
            ausencia.FechaInicio = dtpFechadeinicio.Value;
            ausencia.FechaFin = dtpFechadefin.Value;
            ausencia.IdTipoAusencia = Convert.ToInt32(cbTipodeausencia.SelectedValue); // Id del tipo de ausencia
            ausencia.Aprobado = Convert.ToBoolean(cbAprobacionausencia.SelectedValue); // Valor de aprobación (true o false)
            

            // Insertar en la base de datos
           ausencia.Insertar(ausencia);

            // Mostrar mensaje de éxito
              MessageBox.Show("Ausencia registrada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
    
}
