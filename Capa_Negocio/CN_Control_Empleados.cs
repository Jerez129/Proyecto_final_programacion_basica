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

        public void Insertar(string nombre, string apellido, string cedula, string correo, string fechanacimiento, string cargo, string telefono, string fechaingreso, string iddepartamento, string iddireccion, string genero)
        {
            CN_Empleados.Insertar(nombre, apellido, cedula, correo, fechanacimiento, cargo, telefono, fechaingreso, iddepartamento, iddireccion, genero);
        }

        public void Editar(int id, string nombre, string apellido, string cedula, string correo, string fechanacimiento, string cargo, string telefono, string fechaingreso, string iddepartamento, string iddireccion, string genero)
        {
            CN_Empleados.Editar(id, nombre, apellido, cedula, correo, fechanacimiento, cargo, telefono, fechaingreso, iddepartamento, iddireccion, genero);
        }

        public void Eliminar(int id)
        {
            CN_Empleados.Eliminar(id);
        }


    }
}
