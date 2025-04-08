using Capa_Presentacion.FrmConsulta;
using Capa_Presentacion.FrmsControldeasencias;
using Capa_Presentacion.FrmsControldeempleados;

namespace Capa_Presentacion_Proyecto_Final
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin());
        }
    }
}