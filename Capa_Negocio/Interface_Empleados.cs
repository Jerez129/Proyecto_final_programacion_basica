using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    // Interfaz que define los métodos que deben implementar las clases encargadas de manejar empleados
    public interface Interface_Empleados


    // Método para mostrar los empleados. Este método debe devolver un DataTable con los detalles de los empleados.
    // El DataTable contiene los registros de los empleados que luego se pueden mostrar en la interfaz de usuario.
    {
        DataTable MostrarEmpleado();
        void InsertarEmpleado(string nombre, string apellido, string cedula, string correo, string fechanacimiento, string cargo, string telefono, string fechaingreso, string iddepartamento, string iddireccion, string genero);
        void EditarEmpleado(int id, string nombre, string apellido, string cedula, string correo, string fechanacimiento, string cargo, string telefono, string fechaingreso, string iddepartamento, string iddireccion, string genero);
        void EliminarEmpleado(int id);
    }
}