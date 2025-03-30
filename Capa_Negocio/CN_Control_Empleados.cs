using Capa_Datos.ClasesDAL;
using Capa_Negocio.Interfaces;
using Capa_Negocio.Modelos.Empleados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Control_Empleados : EmpleadosModel, ICapa_de_Negocio<EmpleadosModel>
    {
        private EmpleadosModel CN_Empleados = new EmpleadosModel();

        DireccionModel CN_Direccion = new DireccionModel();
        GeneroModel CN_Genero = new GeneroModel();
        DepartamentoModel CN_Departamento = new DepartamentoModel();

        public DataTable MostrarGenero()
        {
            return CN_Genero.MostrarGenero();
        }

        public DataTable MostrarDepartamento()
        {
            return CN_Departamento.MostrarDepartamento();
        }
        public DataTable MostrarDireccion()
        {
            return CN_Direccion.MostrarDireccion();
        }

        public DataTable Mostrar()
        {
            return CN_Empleados.Mostrar();
        }

        public void Insertar(EmpleadosModel empleado)
        {
        
            CN_Empleados.Insertar(empleado); 
        }

        public void Editar(EmpleadosModel empleado)
        {
            CN_Empleados.Editar(empleado);
        }

        public void Eliminar(EmpleadosModel empleado)
        {
            CN_Empleados.Eliminar(empleado);
        }
    }
}
