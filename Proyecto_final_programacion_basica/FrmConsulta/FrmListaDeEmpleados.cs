using Capa_Negocio;
using Capa_Presentacion_Proyecto_Final;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.FrmConsulta
{
    public partial class FrmListaDeEmpleados : Form
    {
        public FrmListaDeEmpleados()
        {
            InitializeComponent();
            ListarEmpleado();
        }
        private DataTable tablaEmpleados;

        private void ListarEmpleado()
        {
            CN_Control_Empleados empleado = new CN_Control_Empleados();
            tablaEmpleados = empleado.Mostrar(); // Aquí asignas a la variable global
            dgvListadeempleados.DataSource = tablaEmpleados;
            dgvListadeempleados.Columns["id_Departamento"].Visible = false;
            dgvListadeempleados.Columns["id_Direccion"].Visible = false;
            dgvListadeempleados.Columns["id_Genero"].Visible = false;
        }

        private void limpiarcampos()
        {
            txtBuscarEmpleado.Clear();
            cbDepartamento.SelectedIndex = -1;
            cbGenero.SelectedIndex = -1;
            dtpFechaMinima.Value = DateTime.Now;
            dtpFechaMaxima.Value = DateTime.Now;
            chkFiltrarFecha.Checked = false;
        }
        private void FrmListaDeEmpleados_Load(object sender, EventArgs e)
        {
            CN_Control_Empleados empleado = new CN_Control_Empleados();

            cbGenero.DataSource = empleado.MostrarGenero();
            cbGenero.DisplayMember = "MostrarGenero"; // Mostrar "Masculino" o "Femenino"
            cbGenero.ValueMember = "id_Genero"; // Usar el id_Genero como valor subyacente
            cbGenero.SelectedIndex = -1; // No seleccionar ningún ítem por defecto

            cbDepartamento.DataSource = empleado.MostrarDepartamento();
            cbDepartamento.DisplayMember = "NombreDepartamento"; // Nombre de la columna que se mostrará
            cbDepartamento.ValueMember = "id_Departamento"; // Nombre de la columna que se usará como valor
            cbDepartamento.SelectedIndex = -1; // No seleccionar ningún ítem por defecto
        }

        private void FiltrarEmpleados()
        {
            if (tablaEmpleados == null) return;

            string texto = txtBuscarEmpleado.Text.Trim().Replace("'", "''");
            string departamento = cbDepartamento.Text;
            string genero = cbGenero.Text;

            // Obtener las fechas seleccionadas en los DateTimePickers
            DateTime fechaMinima = dtpFechaMinima.Value.Date;
            DateTime fechaMaxima = dtpFechaMaxima.Value.Date;

            // Construir el filtro según si hay texto o no
            string filtro = "";

            // Si hay texto, buscamos en ambos campos (Nombre y Apellido)
            if (!string.IsNullOrEmpty(texto))
            {
                filtro = $"(Nombre LIKE '%{texto}%' OR Apellido LIKE '%{texto}%')";
            }
            else if (chkFiltrarFecha.Checked)
            {
                // Filtro solo por FechaIngreso en el rango de fechas
                filtro = $"FechaIngreso >= #{fechaMinima:MM/dd/yyyy}# " +
                         $"AND FechaIngreso <= #{fechaMaxima:MM/dd/yyyy}#";
            }
            else
            {
                // Filtro solo por Departamento, Cargo, Género
                filtro = $"Departamento LIKE '%{departamento}%' " +
                         $"AND Genero LIKE '%{genero}%'";
            }

            // Aplicar el filtro al DataView
            DataView vista = tablaEmpleados.DefaultView;
            vista.RowFilter = filtro;

            dgvListadeempleados.DataSource = vista;
        }
        private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            FiltrarEmpleados();
        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            FiltrarEmpleados();
        }

        private void chkFiltrarFecha_CheckedChanged(object sender, EventArgs e)
        {
            FiltrarEmpleados();
        }

        private void dtpFechaMinima_ValueChanged(object sender, EventArgs e)
        {
            FiltrarEmpleados();
        }

        private void cbGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarEmpleados();
        }

        private void cbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarEmpleados();
        }

        private void btnEliminarfiltros_Click(object sender, EventArgs e)
        {
            limpiarcampos();
        }

        private void btnExportarexcel_Click(object sender, EventArgs e)
        {
            // Crear un nuevo archivo de Excel
            using (XLWorkbook wb = new XLWorkbook())
            {
                // Crear una hoja de trabajo en el archivo
                var ws = wb.Worksheets.Add("Empleados");

                // Agregar los encabezados de columna
                for (int col = 0; col < dgvListadeempleados.Columns.Count; col++)
                {
                    ws.Cell(1, col + 1).Value = dgvListadeempleados.Columns[col].HeaderText;
                }

                // Agregar los datos de las filas
                for (int row = 0; row < dgvListadeempleados.Rows.Count; row++)
                {
                    for (int col = 0; col < dgvListadeempleados.Columns.Count; col++)
                    {
                        if (dgvListadeempleados.Rows[row].Cells[col].Value != null)
                        {
                            ws.Cell(row + 2, col + 1).Value = dgvListadeempleados.Rows[row].Cells[col].Value.ToString();
                        }
                    }
                }

                // Guardar el archivo Excel
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos de Excel (*.xlsx)|*.xlsx";
                saveFileDialog.FileName = "Empleados.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("El archivo Excel se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnVolveralmenuprincipal_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }
    }
}
