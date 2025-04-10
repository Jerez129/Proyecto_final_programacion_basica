using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Capa_Presentacion
{
    public partial class Frmcalendariodeausencias : Form
    {
        private DateTime fechaSeleccionada;
        public Frmcalendariodeausencias(DateTime fecha)
        {
            InitializeComponent();
            fechaSeleccionada = fecha;
            // Agregamos esto para verificar qué fecha está llegando
            MessageBox.Show("Fecha seleccionada: " + fechaSeleccionada.ToString("yyyy-MM-dd"));
            CargarAusencias();

        }

        private void Frmcalendariodeausencias_Load(object sender, EventArgs e)
        {

        }

        /* private void CargarAusencias()
          {

              CN_Control_Ausencias ausencias = new CN_Control_Ausencias();
              DataTable dt = ausencias.Mostrar();
              dgvAusenciascalendario.DataSource = dt;
          }*/

        private void CargarAusencias()
        {
            CN_Control_Ausencias ausencias = new CN_Control_Ausencias();
            DataTable dt = ausencias.Mostrarausenciaporfecha(fechaSeleccionada);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No hay ausencias registradas para esta fecha.");
            }

            dgvAusenciascalendario.DataSource = dt; // Carga los datos en el DataGridView
        }

        private void btnCerrarreportedecalendario_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

