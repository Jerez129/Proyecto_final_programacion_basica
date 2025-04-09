using Capa_Presentacion.FrmsControldeempleados;
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
    public partial class FrmVisualcontroldeempleados : Form
    {
        public FrmVisualcontroldeempleados()
        {
            InitializeComponent();
        }

        private void btnVolveralmenuprincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();

            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
        }

        private void btnVisualeditarempleado_Click(object sender, EventArgs e)
        {
            FrmVisualeditarempleado frm = new FrmVisualeditarempleado();
            frm.Show();
            this.Hide();
        }

        private void btnVisualregistrarempleado_Click(object sender, EventArgs e)
        {
            FrmVisualregistrarempleado frm = new FrmVisualregistrarempleado();
            frm.Show();
            this.Hide();
        }

        private void FrmVisualcontroldeempleados_Load(object sender, EventArgs e)
        {

        }
    }
}
