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
        }
        /// <summary>
        /// Método para cargar los tipos de ausencias en el ComboBox.
        /// </summary>
        private DataTable tablaAusencias;
        private void CargarTiposAusencias()
        {
            CN_Reporte_Ausencias ausencias = new CN_Reporte_Ausencias();
            DataTable dt = ausencias.MostrarTipodeausencia();

            cbTipodeausencias.DataSource = dt;
            cbTipodeausencias.DisplayMember = "Tipo";  // La columna visible
            cbTipodeausencias.ValueMember = "id_Tipo_Ausencia";  // El valor interno
        }
        /// <summary>
        /// Evento que se ejecuta cuando el formulario se carga. Configura los controles iniciales.
        /// </summary>

        private void FrmReporteDeAusencias_Load(object sender, EventArgs e)
        {
            SetPlaceholder(txtNombre, "Buscar Empleado por Nombre");
            cbTipodeausencias.SelectedIndex = -1; // No seleccionar ningún ítem por defecto
        }


        /// <summary>
        /// Método para limpiar los campos de búsqueda y filtros.
        /// </summary>
        private void limpiarcampos()
        {
            txtNombre.Clear();
            cbTipodeausencias.SelectedIndex = -1; // No seleccionar ningún ítem por defecto
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechafin.Value = DateTime.Now;
            checkBox1.Checked = false; // Desmarcar el checkbox
        }
        /// <summary>
        /// Método para mostrar el reporte de ausencias en el DataGridView.
        /// </summary>
        private void MostrarReporte()
        {
            CN_Reporte_Ausencias ausencias = new CN_Reporte_Ausencias();
            tablaAusencias = ausencias.Mostrar();
            dgvReportedeausencias.DataSource = tablaAusencias;
            dgvReportedeausencias.Columns["id_Empleado"].Visible = false;
            dgvReportedeausencias.Columns["id_Ausencia"].Visible = false;
        }

        /// <summary>
        /// Método para filtrar los datos según los criterios seleccionados.
        /// </summary>
        private void FiltrarDatos()
        {
            if (tablaAusencias == null) return;

            string texto = txtNombre.Text.Trim().Replace("'", "''");
            string tipoAusencia = cbTipodeausencias.Text;


            // Obtener las fechas seleccionadas
            DateTime fechaInicio = dtpFechaInicio.Value.Date;
            DateTime fechaFin = dtpFechafin.Value.Date;

            // Construir el filtro
            string filtro = "";

            // Filtro por texto (Nombre o Apellido)
            if (!string.IsNullOrEmpty(texto))
            {
                filtro = $"(Nombre LIKE '%{texto}%' OR Apellido LIKE '%{texto}%')";
            }

            // Filtro por fechas (si el checkbox está marcado)
            if (checkBox1.Checked)
            {
                if (!string.IsNullOrEmpty(filtro)) filtro += " AND ";
                filtro += $"FechaInicio >= #{fechaInicio:MM/dd/yyyy}# AND FechaInicio <= #{fechaFin:MM/dd/yyyy}#";
            }

            // Filtro por tipo de ausencia
            if (!string.IsNullOrEmpty(tipoAusencia))
            {
                if (!string.IsNullOrEmpty(filtro)) filtro += " AND ";
                filtro += $"TipoAusencia LIKE '%{tipoAusencia}%'";
            }

            // Aplicar el filtro al DataView
            DataView vista = tablaAusencias.DefaultView;
            vista.RowFilter = filtro;

            dgvReportedeausencias.DataSource = vista;
        }
  
        // Eliminar el marcador de posición cuando el usuario empieza a escribir
        private void RemovePlaceholder(TextBox textBox, string placeholder)
        {
            if (textBox.Text == placeholder)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black; // Color del texto normal
            }
        }

        // Agregar el marcador de posición si el campo está vacío
        private void AddPlaceholder(TextBox textBox, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholder;
                textBox.ForeColor = Color.Gray; // Color del texto del marcador de posición
            }
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray; // Color del texto del marcador de posición
            textBox.GotFocus += (sender, e) => RemovePlaceholder(sender as TextBox, placeholder);
            textBox.LostFocus += (sender, e) => AddPlaceholder(sender as TextBox, placeholder);
        }
        /// <summary>
        /// Métodos que se ejecutan cuando se insertan datos a los txt,dtp,cb. 
        /// Estos eventos activan el filtrado de los datos.
        /// </summary>
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }
        private void cbTipodeausencias_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        private void dtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            FiltrarDatos();

        }

        private void dtpFechafin_ValueChanged(object sender, EventArgs e)
        {
            FiltrarDatos();
        }

        /// <summary>
        /// Método para exportar los datos filtrados a un archivo Excel.
        /// Utiliza la biblioteca ClosedXML para crear el archivo Excel.
        /// </summary>
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

        /// <summary>
        /// Método para limpiar los campos de búsqueda y filtros al hacer clic en el botón Limpiar.
        /// </summary>
        private void btnLimpiarcampos_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        /// <summary>
        /// Método para volver al menú principal.
        /// </summary>
        private void btnVolveralmenuprincipal_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }
    }
}
