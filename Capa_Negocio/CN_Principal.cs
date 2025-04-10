using System.Data;

namespace Capa_Negocio
{
    public class CN_Principal
    {
        AusenciasModel CN_principal = new AusenciasModel();

        public DataTable Mostrarausenciaporfecha(DateTime fecha)
        {
            return CN_principal.MostrarAusenciasPorFecha(fecha);
        }

    }
}
