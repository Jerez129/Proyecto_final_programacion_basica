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


namespace Capa_Presentacion.FrmsControldeausencias
{
    public partial class FrmVisualEditarausencias : Form
    {
        public FrmVisualEditarausencias()
        {
            InitializeComponent();
            MostrarAusenciasDeEmpleados();
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
        private void LimpiarCampos()
        {
            txtIdEmpleadoEditar.Clear();
            txtIdAusenciaEditar.Clear();
            dtpFechadeinicio.Value = DateTime.Now;
            dtpFechadefin.Value = DateTime.Now;
            cbTipodeausencia.SelectedIndex = -1;
            cbAprobacionEditar.SelectedIndex = -1;
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
            cbAprobacionEditar.DataSource = estados;
            cbAprobacionEditar.DisplayMember = "Key";  // Muestra "Aprobado" o "No Aprobado"
            cbAprobacionEditar.ValueMember = "Value";  // El valor será true o false
            cbAprobacionEditar.SelectedIndex = 0;  // Establecer por defecto "Aprobado"
        }


        private void MostrarAusenciasDeEmpleados()
        {
            CN_Control_Ausencias CN_Ausencias = new CN_Control_Ausencias();
            DataTable ausencias = CN_Ausencias.MostrarAusenciasParaEditar();
            dgvEditarausencias.DataSource = ausencias;
            dgvEditarausencias.Columns["id_Empleado"].Visible = false;
        }


        private void FrmVisualEditarausencias_Load(object sender, EventArgs e)
        {

        }

        private void dgvEditarausencias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex >= 0) // Aseguramos que se haya hecho clic en una fila válida
            {
                if (dgvEditarausencias.SelectedRows.Count > 0)
                {
                    DataGridViewRow fila = dgvEditarausencias.SelectedRows[0];
                    txtIdEmpleadoEditar.Text = fila.Cells["id_Empleado"].Value.ToString();
                    txtIdAusenciaEditar.Text = fila.Cells["id_Ausencia"].Value.ToString();
                    dtpFechadeinicio.Value = Convert.ToDateTime(fila.Cells["FechaInicio"].Value);
                    dtpFechadefin.Value = Convert.ToDateTime(fila.Cells["FechaFin"].Value);
                    cbTipodeausencia.Text = fila.Cells["TipoAusencia"].Value.ToString();
                    cbAprobacionEditar.Text = fila.Cells["Aprobado"].Value.ToString();

                }
                else
                {
                    MessageBox.Show("Selecciona una fila.");
                }

            }
          

        }

        private void btnRegistrarausencia_Click(object sender, EventArgs e)
        {
            if (dgvEditarausencias.SelectedRows.Count > 0)
            {
                CN_Control_Ausencias ausencias = new CN_Control_Ausencias();
                ausencias.IdAusencia = Convert.ToInt32(txtIdAusenciaEditar.Text);
                ausencias.IdEmpleado = Convert.ToInt32(txtIdEmpleadoEditar.Text);
                ausencias.FechaInicio = dtpFechadeinicio.Value;
                ausencias.FechaFin = dtpFechadefin.Value;
                ausencias.IdTipoAusencia = Convert.ToInt32(cbTipodeausencia.SelectedValue);
                ausencias.Aprobado = ((KeyValuePair<string, bool>)cbAprobacionEditar.SelectedItem).Value;

                ausencias.Editar(ausencias);

                // Validación
                string mensajeError;
                if (ausencias.ValidacionEditar(out mensajeError))
                {
                    // Si la validación es correcta, registrar la ausencia

                    MessageBox.Show("Ausencia editada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                    MostrarAusenciasDeEmpleados();
                }
                else
                {
                    // Si hay un error de validación, mostrar el mensaje de error
                    MessageBox.Show(mensajeError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor, seleccione una ausencia para editar.");
            }

        }

        private void btnEliminarasuenciaeditar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado alguna fila en el DataGridView
            if (dgvEditarausencias.SelectedRows.Count > 0)
            {
                // Obtener el ID de la ausencia de la fila seleccionada
                int idAusencia = Convert.ToInt32(dgvEditarausencias.SelectedRows[0].Cells["IdAusencia"].Value);

                // Crear el objeto de ausencias y eliminarlo
                CN_Control_Ausencias ausencias = new CN_Control_Ausencias();
                ausencias.IdAusencia = idAusencia;
                ausencias.Eliminar(ausencias);

                // Mostrar mensaje de éxito
                MessageBox.Show("Ausencia eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Actualizar la vista de las ausencias
                MostrarAusenciasDeEmpleados();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una ausencia para eliminar.");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            FrmEntradaausencias frmEntradaausencias = new FrmEntradaausencias();
            frmEntradaausencias.Show();
            this.Close();
        }

        private void btnRegistrarausencia_Click_1(object sender, EventArgs e)
        {

        }

        private void lblAprobacioneditar_Click(object sender, EventArgs e)
        {

        }
    }



}
