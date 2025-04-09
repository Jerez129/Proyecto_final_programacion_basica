using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Presentacion;
using Capa_Presentacion_Proyecto_Final;

namespace Capa_Presentacion.FrmsControldeausencias
{
    public partial class FrmEntradaausencias : Form
    {
        public FrmEntradaausencias()
        {
            InitializeComponent();
        }

        private void btnEditarEntrada_Click(object sender, EventArgs e)
        {
            FrmVisualEditarausencias frmVisualEditarausencias = new FrmVisualEditarausencias();
            frmVisualEditarausencias.Show();
            this.Close();
        }

        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            FrmControldeausencias frmControl = new FrmControldeausencias();
            frmControl.Show();
            this.Close();
        }

        private void FrmEntradaausencias_Load(object sender, EventArgs e)
        {

        }

        private void btnVolveralmenuprincipal_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Show();
            this.Close();
        }
    }
}
