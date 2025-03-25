using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public interface Interface_Empleados
    {
        DataTable MostrarEmpleado();
        void InsertarEmpleado(string nombre, string apellido, string cedula, string correo, string fechanacimiento, string cargo, string telefono, string fechaingreso, string iddepartamento, string iddireccion, string genero);
        void EditarEmpleado(int id, string nombre, string apellido, string cedula, string correo, string fechanacimiento, string cargo, string telefono, string fechaingreso, string iddepartamento, string iddireccion, string genero);
        void EliminarEmpleado(int id);
    }
}