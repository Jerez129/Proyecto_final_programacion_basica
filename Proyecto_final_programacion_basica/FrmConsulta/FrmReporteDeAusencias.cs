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
using ClosedXML.Excel;

namespace Capa_Presentacion.FrmConsulta
{
    public partial class FrmReporteDeAusencias : Form
    {
        public FrmReporteDeAusencias()
        {
            InitializeComponent();
            MostrarReporte();
            CargarTiposAusencias();
            CargarAprobacion();
            
        }
        private DataTable tablaAusencias;

        private void CargarTiposAusencias()
        {
            CN_Control_Ausencias ausencias = new CN_Control_Ausencias();
            DataTable dt = ausencias.MostrarTipodeausencia();

            cbTipoasuencia.DataSource = dt;
            cbTipoasuencia.DisplayMember = "Tipo";  // La columna visible
            cbTipoasuencia.ValueMember = "id_Tipo_Ausencia";  // El valor interno
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
            cbAprobado.DataSource = estados;
            cbAprobado.DisplayMember = "Key";  // Muestra "Aprobado" o "No Aprobado"
            cbAprobado.ValueMember = "Value";  // El valor será true o false
            cbAprobado.SelectedIndex = 0;  // Establecer por defecto "Aprobado"
        }
        private void FrmReporteDeAusencias_Load(object sender, EventArgs e)
        {
            cbAprobado.SelectedIndex = -1; // No seleccionar ningún ítem por defecto
            cbTipoasuencia.SelectedIndex = -1; // No seleccionar ningún ítem por defecto
        }

        private void MostrarReporte()
        {
            CN_Control_Ausencias reporte = new CN_Control_Ausencias();
            tablaAusencias = reporte.Mostrar();
            dgvReportedeausencias.DataSource = tablaAusencias;
            dgvReportedeausencias.Columns["id_Empleado"].Visible = false;
            dgvReportedeausencias.Columns["id_Ausencia"].Visible = false;
        }

        // Filtrar según los criterios seleccionados
        private void FiltrarDatos()
        {
            if (tablaAusencias == null) return;

            string texto = txtNombre.Text.Trim().Replace("'", "''");

            // Obtener el valor del ComboBox de tipo de ausencia
            string tipoAusencia = cbTipoasuencia.SelectedValue?.ToString();

            // Obtener el valor del ComboBox de aprobado (Booleano)
            bool? aprobado = cbAprobado.SelectedValue as bool?;

            // Obtener la fecha seleccionada en el DateTimePicker
            DateTime fechaSeleccionada = dtpFechaausencia.Value.Date;

            // Construir el filtro según las condiciones
            string filtro = "";

            // Si hay texto en el nombre o apellido
            if (!string.IsNullOrEmpty(texto))
            {
                filtro = $"(Nombre LIKE '%{texto}%' OR Apellido LIKE '%{texto}%')";
            }

            // Filtrar por tipo de ausencia
            if (!string.IsNullOrEmpty(tipoAusencia))
            {
                if (!string.IsNullOrEmpty(filtro)) filtro += " AND ";
                filtro += $"TipoAusencia = '{tipoAusencia}'";
            }

            // Filtrar por aprobado
            if (aprobado.HasValue)
            {
                if (!string.IsNullOrEmpty(filtro)) filtro += " AND ";
                filtro += $"Aprobado = {Convert.ToInt32(aprobado.Value)}";  // Utiliza directamente el valor booleano (1 o 0)
            }

            // Filtrar por fecha de ausencia
            if (fechaSeleccionada != DateTime.MinValue)
            {
                if (!string.IsNullOrEmpty(filtro)) filtro += " AND ";
                filtro += $"FechaInicio = '{fechaSeleccionada:yyyy-MM-dd}'";  // Ajustar el formato de la fecha
            }

            // Mostrar el filtro para depurar
            MessageBox.Show($"Filtro aplicado: {filtro}");

            // Aplicar el filtro a la vista
            if (dgvReportedeausencias.DataSource is DataTable tablaReporte)
            {
                tablaReporte.DefaultView.RowFilter = filtro;
            }
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
           FiltrarDatos();
        }

        private void cbTipoasuencia_SelectedIndexChanged(object sender, EventArgs e)
        {
          FiltrarDatos();
        }

        private void cbAprobado_SelectedIndexChanged(object sender, EventArgs e)
        {
           FiltrarDatos();
        }

        private void dtpFechaausencia_ValueChanged(object sender, EventArgs e)
        {
           FiltrarDatos();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           FiltrarDatos();
        }

        private void btnExportaraexcel_Click(object sender, EventArgs e)
        {
            // Crear un nuevo archivo de Excel
            using (XLWorkbook wb = new XLWorkbook())
            {
                // Crear una hoja de trabajo en el archivo
                var ws = wb.Worksheets.Add("Reporte de Ausencias");

                // Agregar los encabezados de columna
                for (int col = 0; col < dgvReportedeausencias.Columns.Count; col++)
                {
                    ws.Cell(1, col + 1).Value = dgvReportedeausencias.Columns[col].HeaderText;
                }

                // Agregar los datos de las filas
                for (int row = 0; row < dgvReportedeausencias.Rows.Count; row++)
                {
                    for (int col = 0; col < dgvReportedeausencias.Columns.Count; col++)
                    {
                        if (dgvReportedeausencias.Rows[row].Cells[col].Value != null)
                        {
                            ws.Cell(row + 2, col + 1).Value = dgvReportedeausencias.Rows[row].Cells[col].Value.ToString();
                        }
                    }
                }

                // Guardar el archivo Excel
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = "Reporte_Ausencias.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("El archivo Excel se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}
