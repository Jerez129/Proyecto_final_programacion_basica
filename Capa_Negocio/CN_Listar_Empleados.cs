using Capa_Negocio.Modelos.Empleados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class CN_Listar_Empleados 
    {
        private EmpleadosModel CN_listarempleados = new EmpleadosModel();
        GeneroModel CN_genero = new GeneroModel();
        DepartamentoModel CN_departamento = new DepartamentoModel();

        public DataTable MostrarGenero()
        {
            return CN_genero.MostrarGenero();
        }

        public DataTable MostrarDepartamento()
        {
            return CN_departamento.MostrarDepartamento();
        }

        public DataTable Mostrar()
        {
            return CN_listarempleados.Mostrar();
        }


    }
}
