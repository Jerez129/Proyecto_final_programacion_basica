using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_Negocio
{
    public class CN_Control_Ausencias : ICapa_de_Negocio<AusenciasModel>
    {
        AusenciasModel CN_Ausencias = new AusenciasModel();
        private EmpleadosModel CN_Empleados = new EmpleadosModel();

        public DataTable Mostrarausenciaporfecha(DateTime fecha)
        {
            return CN_Ausencias.MostrarAusenciasPorFecha(fecha);
        }
        public DataTable MostrarTipodeausencia()
        {
            return CN_Ausencias.MostrarTipodeausencia();
        }

        public DataTable MostrarEmpleadoBasico()
        {
            return CN_Empleados.MostrarEmpleadoBasico();
        }

        public DataTable Mostrar()
        {
            return CN_Ausencias.Mostrar();
        }

        public void Insertar(AusenciasModel ausencia)
        {
            CN_Ausencias.Insertar(ausencia);
        }

        public void Eliminar(AusenciasModel ausencia)
        {
            CN_Ausencias.Eliminar(ausencia);
        }

        public void Editar(AusenciasModel ausencia)
        {
            CN_Ausencias.Editar(ausencia);
        }


    }


}

