using System.Data;
using System.Windows.Forms;
using Capa_Negocio;
using Capa_Presentacion.FrmsControldeasencias;
using Capa_Presentacion.FrmsControldeausencias;

namespace Capa_Presentacion_Proyecto_Final
{
    public partial class FrmControldeausencias : Form
    {
        public FrmControldeausencias()
        {
            InitializeComponent();
            MostrarEmpleadosbasico();
        }
        private void MostrarEmpleadosbasico()
        {
            CN_Control_Ausencias CN_Ausencias = new CN_Control_Ausencias();
            DataTable empleados = CN_Ausencias.MostrarEmpleadoBasico();
            dgvEmpleadosbasico.DataSource = empleados;
        }

        private void FrmControldeausencias_Load_1(object sender, EventArgs e)
        {



        }

        private void btnVisualRegistrarausencia_Click(object sender, EventArgs e)
        {
            if (dgvEmpleadosbasico.SelectedRows.Count > 0) // Verifica que haya una fila seleccionada
            {
                DataGridViewRow fila = dgvEmpleadosbasico.SelectedRows[0];

                int id = Convert.ToInt32(fila.Cells["id_Empleado"].Value);
                string nombre = fila.Cells["Nombre"].Value.ToString();
                string apellido = fila.Cells["Apellido"].Value.ToString();
                string cedula = fila.Cells["Cedula"].Value.ToString();

                // Crear el formulario de registrar ausencia y pasar los datos
                FrmVisualRegistrarusencias frm = new FrmVisualRegistrarusencias(id, nombre, apellido, cedula);
                frm.ShowDialog(); // Abre el formulario de manera modal
            }

            else
            {
                MessageBox.Show("Seleccione un empleado antes de registrar una ausencia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmEntradaausencias frmEntradaausencias = new FrmEntradaausencias();
            frmEntradaausencias.Show();
            this.Close();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
