using Capa_Presentacion;
using Capa_Presentacion.FrmConsulta;
using Capa_Presentacion.FrmsControldeausencias;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion_Proyecto_Final
{
    public partial class FrmPrincipal : Form
    {
        private int mes;
        private int año;

        public FrmPrincipal()
        {
            InitializeComponent();
        }



        private void btnMenuprincipal_Click(object sender, EventArgs e)

        {
            this.BackColor = ColorTranslator.FromHtml("#13747D");
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
            this.BackColor = ColorTranslator.FromHtml("#13747D");
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
            this.BackColor = ColorTranslator.FromHtml("#13747D");
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
            this.BackColor = ColorTranslator.FromHtml("#13747D");
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
            this.BackColor = ColorTranslator.FromHtml("#13747D");
            FrmVisualcontroldeempleados frmVisualcontroldeempleados = new FrmVisualcontroldeempleados();
            frmVisualcontroldeempleados.Show();
            this.Hide();

        }
        private void btnControldeausencias_Click(object sender, EventArgs e)
        {
            FrmEntradaausencias frm = new FrmEntradaausencias();
            this.BackColor = ColorTranslator.FromHtml("#13747D");
            this.Hide();
            frm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#FCF7C5");
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MostrarDias();
        }


        private void MostrarDias()
        {
            DateTime now = DateTime.Now;
            mes = now.Month;
            año = now.Year;
            string Mesnombre = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lblMesAño.Text = Mesnombre + " " + año;

            // Toma el primer día del mes
            DateTime iniciodemes = new DateTime(año, mes, 1);

            // Cuenta los días en el mes
            int dias = DateTime.DaysInMonth(año, mes);
            int diasdelasemana = (int)iniciodemes.DayOfWeek; // Día de la semana en número

            // Espacios en blanco para los días antes del primer día del mes
            for (int i = 0; i < diasdelasemana; i++)
            {
                ucEspciosparadias ucespaciosparadias = new ucEspciosparadias();
                flpContenedordedias.Controls.Add(ucespaciosparadias);
            }

            // Días del mes con su fecha correcta
            for (int i = 1; i <= dias; i++)
            {
                ucDias ucdias = new ucDias();
                ucdias.ConfigurarDia(i, new DateTime(año, mes, i)); // Ahora sí asignamos la fecha correctamente
                flpContenedordedias.Controls.Add(ucdias);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            flpContenedordedias.Controls.Clear();
            //sumar un mes
            mes++;
            if (mes > 12)
            {
                mes = 1;
                año++;
            }
            //Sumar un mes y año a label
            string Mesnombre = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lblMesAño.Text = Mesnombre + " " + año;

            DateTime now = DateTime.Now;
            // Toma el primer día del mes
            DateTime iniciodemes = new DateTime(año, mes, 1);

            // Cuenta los días en el mes
            int dias = DateTime.DaysInMonth(año, mes);
            int diasdelasemana = (int)iniciodemes.DayOfWeek; // Día de la semana en número

            // Espacios en blanco para los días antes del primer día del mes
            for (int i = 0; i < diasdelasemana; i++)
            {
                ucEspciosparadias ucespaciosparadias = new ucEspciosparadias();
                flpContenedordedias.Controls.Add(ucespaciosparadias);
            }

            // Días del mes con su fecha correcta
            for (int i = 1; i <= dias; i++)
            {
                ucDias ucdias = new ucDias();
                ucdias.ConfigurarDia(i, new DateTime(año, mes, i)); // Ahora sí asignamos la fecha correctamente
                flpContenedordedias.Controls.Add(ucdias);
            }
        }
        private void btnAtras_Click(object sender, EventArgs e)

        {

            flpContenedordedias.Controls.Clear();
            //Resta un mes
            mes--;
            if (mes < 1)
            {
                mes = 12;
                año--;
            }
            //Resta un mes y año a label
            string Mesnombre = DateTimeFormatInfo.CurrentInfo.GetMonthName(mes);
            lblMesAño.Text = Mesnombre + " " + año;
            DateTime now = DateTime.Now;

            // Toma el primer día del mes
            DateTime iniciodemes = new DateTime(año, mes, 1);

            // Cuenta los días en el mes
            int dias = DateTime.DaysInMonth(año, mes);
            int diasdelasemana = (int)iniciodemes.DayOfWeek; // Día de la semana en número

            // Espacios en blanco para los días antes del primer día del mes
            for (int i = 2; i < diasdelasemana; i++)
            {
                ucEspciosparadias ucespaciosparadias = new ucEspciosparadias();
                flpContenedordedias.Controls.Add(ucespaciosparadias);
            }

            // Días del mes con su fecha correcta
            for (int i = 1; i <= dias; i++)
            {
                ucDias ucdias = new ucDias();
                ucdias.ConfigurarDia(i, new DateTime(año, mes, i)); // Ahora sí asignamos la fecha correctamente
                flpContenedordedias.Controls.Add(ucdias);
            }

        }
        private void btnListadeempledos_Click(object sender, EventArgs e)
        {
            FrmListaDeEmpleados frmListaDeEmpleados = new FrmListaDeEmpleados();
            frmListaDeEmpleados.Show();
            this.Hide();

        }

        private void btnReportedeausencias_Click(object sender, EventArgs e)
        {
            FrmReporteDeAusencias frmReporteDeAusencias = new FrmReporteDeAusencias();
            frmReporteDeAusencias.Show();
            this.Hide();
        }

        private void btnAcercade_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void pnlMenuPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
