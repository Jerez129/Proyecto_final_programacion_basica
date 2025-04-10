using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Reporte_Ausencias
    {
        AusenciasModel CN_reportedeausencias = new AusenciasModel();

        public DataTable MostrarTipodeausencia()
        {
            return CN_reportedeausencias.MostrarTipodeausencia();
        }
        public DataTable Mostrar()
        {
            return CN_reportedeausencias.Mostrar();
        }

    }
}
