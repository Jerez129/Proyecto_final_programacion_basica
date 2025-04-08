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

namespace Capa_Presentacion.FrmConsulta
{
    public partial class FrmListaDeEmpleados : Form
    {
        public FrmListaDeEmpleados()
        {
            InitializeComponent();
        }

        private void btnVerConsultasListar_Click(object sender, EventArgs e)
        {
            /*try
            {
                CN_Control_Nomina controlNomina = new CN_Control_Nomina();
                DataTable datosNomina = controlNomina.MostrarNomina();
                dgvNomina.DataSource = datosNomina;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/

        }
    }
}
