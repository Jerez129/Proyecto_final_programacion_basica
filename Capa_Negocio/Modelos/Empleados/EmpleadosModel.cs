using Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos.ClasesDAL;

namespace Capa_Negocio
{
    // Esta clase representa el modelo de empleados. Se usa para manejar toda la lógica de los datos del empleado
    public class EmpleadosModel : ModeloBase
    {
        // Conexión a la base de datos
        private CD_Conexion conexion = new CD_Conexion();

        // Objetos necesarios para ejecutar comandos SQL y leer resultados
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        // Propiedades del empleado. Representan los datos que se guardan en la base de datos
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Cargo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal SalarioBase { get; set; }
        public int IdDepartamento { get; set; }
        public int IdDireccion { get; set; }
        public int IdGenero { get; set; }

        // Este método ejecuta un procedimiento almacenado que trae todos los datos detallados de los empleados
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();  // Abrir conexión a la base de datos
            comando.CommandText = "MostrarEmpleadosDetallado";  // Nombre del procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;  // Se especifica que es un procedimiento
            leer = comando.ExecuteReader();     // Ejecutar y leer los datos
            tabla.Load(leer); 
            conexion.CerrarConexion();     
            return tabla;  
        }

        // Este método carga solo datos básicos de los empleados 
        public DataTable MostrarEmpleadoBasico()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEmpleadosBasico";   // lo mismo de arriba pero con menos datos 
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        // Este método sirve para insertar un nuevo empleado en la base de datos
        public void Insertar(EmpleadosModel Empleado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarEmpleados";     // Nombre del procedimiento almacenado que se ulizara para insertar
            comando.CommandType = CommandType.StoredProcedure;

            // Se agregan los parámetros con los valores del empleado que se va a guardar
            comando.Parameters.AddWithValue("@Nombre", Empleado.Nombre);
            comando.Parameters.AddWithValue("@Apellido", Empleado.Apellido);
            comando.Parameters.AddWithValue("@Cedula", Empleado.Cedula);
            comando.Parameters.AddWithValue("@Correo", Empleado.Correo);
            comando.Parameters.AddWithValue("@FechaNacimiento", Empleado.FechaNacimiento);
            comando.Parameters.AddWithValue("@Cargo", Empleado.Cargo);
            comando.Parameters.AddWithValue("@Telefono", Empleado.Telefono);
            comando.Parameters.AddWithValue("@FechaIngreso", Empleado.FechaIngreso);
            comando.Parameters.AddWithValue("@SalarioBase", Empleado.SalarioBase);
            comando.Parameters.AddWithValue("@id_Departamento", Empleado.IdDepartamento);
            comando.Parameters.AddWithValue("@id_Direccion", Empleado.IdDireccion);
            comando.Parameters.AddWithValue("@id_Genero", Empleado.IdGenero);

            comando.ExecuteNonQuery();    // Ejecuta el guardado
            comando.Parameters.Clear();      // Limpia los parámetros para evitar errores después
        }

        // Este método sirve para actualizar los datos de un empleado que ya existe
        public void Editar(EmpleadosModel Empleado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarEmpleado";     // Llama al procedimiento para actualizar
            comando.CommandType = CommandType.StoredProcedure;

            // Igual que en insertar, pero se incluye el ID del empleado para saber a quién actualizar
            comando.Parameters.AddWithValue("@id_Empleado", Empleado.IdEmpleado);
            comando.Parameters.AddWithValue("@Nombre", Empleado.Nombre);
            comando.Parameters.AddWithValue("@Apellido", Empleado.Apellido);
            comando.Parameters.AddWithValue("@Cedula", Empleado.Cedula);
            comando.Parameters.AddWithValue("@Correo", Empleado.Correo);
            comando.Parameters.AddWithValue("@FechaNacimiento", Empleado.FechaNacimiento);
            comando.Parameters.AddWithValue("@Cargo", Empleado.Cargo);
            comando.Parameters.AddWithValue("@Telefono", Empleado.Telefono);
            comando.Parameters.AddWithValue("@FechaIngreso", Empleado.FechaIngreso);
            comando.Parameters.AddWithValue("@SalarioBase", Empleado.SalarioBase);
            comando.Parameters.AddWithValue("@id_Departamento", Empleado.IdDepartamento);
            comando.Parameters.AddWithValue("@id_Direccion", Empleado.IdDireccion);
            comando.Parameters.AddWithValue("@id_Genero", Empleado.IdGenero);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        // Este método elimina un empleado según su ID (lógico o físico, depende del procedimiento)
        public void Eliminar(EmpleadosModel Empleado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarEmpleados";                          // Procedimiento que elimina
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Empleado", Empleado.IdEmpleado); // Se indica cuál empleado borrar
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
