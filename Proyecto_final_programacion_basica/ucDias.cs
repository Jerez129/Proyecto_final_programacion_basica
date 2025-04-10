using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class ucDias : UserControl
    {
        private DateTime fecha; // Fecha seleccionada

        public ucDias()
        {
            InitializeComponent();
        }

        private void ucDias_Load(object sender, EventArgs e)
        {
        }

        // Método corregido para configurar la fecha correctamente
        public void ConfigurarDia(int numeroDeDia, DateTime fechaMesAño)

        {
            this.BackColor = ColorTranslator.FromHtml("#13747D");
            lblDias.Text = numeroDeDia.ToString();

            // Asignamos correctamente la fecha completa
            fecha = new DateTime(fechaMesAño.Year, fechaMesAño.Month, numeroDeDia);
        }

        private void ucDias_Click(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#13747D");
            Frmcalendariodeausencias frmcalendariodeausencias = new Frmcalendariodeausencias(fecha);
            frmcalendariodeausencias.ShowDialog();

        }

        private void lblDias_Click(object sender, EventArgs e)
        {
         
        }
    }
}
