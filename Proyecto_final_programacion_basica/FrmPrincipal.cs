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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }



        private void btnMenuprincipal_Click(object sender, EventArgs e)
        {
            if (pnlMenuPrincipal.Visible == true)
            {
                pnlMenuPrincipal.Visible = false;
            }
            else
            {
                pnlMenuPrincipal.Visible = true;
            }
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            if (pnlMenuempleados.Visible == true)
            {
                pnlMenuempleados.Visible = false;
            }
            else
            {
                pnlMenuempleados.Visible = true;
            }
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            if (pnlConsulta.Visible == true)
            {
                pnlConsulta.Visible = false;
            }
            else
            {
                pnlConsulta.Visible = true;
            }
        }

        private void btnSistema_Click(object sender, EventArgs e)
        {
            if (pnlSistema.Visible == true)
            {
                pnlSistema.Visible = false;
            }

            else
            {
                pnlSistema.Visible = true;
            }

        }

        private void btnControldeempleados_Click(object sender, EventArgs e)
        {
            FrmVisualcontroldeempleados frmVisualcontroldeempleados = new FrmVisualcontroldeempleados();
            frmVisualcontroldeempleados.Show();
            this.Hide();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
