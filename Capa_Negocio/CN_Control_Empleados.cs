using Capa_Datos.ClasesDAL;
using Capa_Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Control_Empleados : ICapa_de_Negocio
    {
        private EmpleadosDAL CN_Empleados = new EmpleadosDAL();

        public DataTable Mostrar()
        {
            return CN_Empleados.Mostrar();
        }

        public void Insertar(EmpleadosDAL empleado)
        {
        
            CN_Empleados.Insertar(empleado); 
        }

        public void Editar(EmpleadosDAL empleado)
        {
            CN_Empleados.Editar(empleado);
        }

        public void Eliminar(EmpleadosDAL empleado)
        {
            CN_Empleados.Eliminar(empleado);
        }
    }
}
