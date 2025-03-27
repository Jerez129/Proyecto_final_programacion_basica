using Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_Datos.ClasesDAL
{

    public class EmpleadosDAL
    {
        private CD_Conexion conexion = new CD_Conexion();
        //esto es para leer data de las tablas
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        //TRANSACT SQL
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEmpleadosDetallado";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

            //PROCEDIMIENTO
        }
        public void Insertar(string nombre, string apellido, string cedula, string correo, string fechanacimiento, string cargo, string telefono, string fechaingreso, string iddepartamento, string iddireccion, string genero)
        {
            //PROCEDIMIENTO
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre ", nombre);
            comando.Parameters.AddWithValue("@Apellido", telefono);
            comando.Parameters.AddWithValue("@Cedula", cedula);
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@FechaNacimiento", fechanacimiento);
            comando.Parameters.AddWithValue("@Cargo", cargo);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@FechaIngreso", fechaingreso);
            comando.Parameters.AddWithValue("@id_Departamento", iddepartamento);
            comando.Parameters.AddWithValue("@id_Direccion", iddireccion);
            comando.Parameters.AddWithValue("@id_Genero", genero);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(int id, string nombre, string apellido, string cedula, string correo, string fechanacimiento, string cargo, string telefono, string fechaingreso, string iddepartamento, string iddireccion, string genero)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Empleado", id);
            comando.Parameters.AddWithValue("@Nombre ", nombre);
            comando.Parameters.AddWithValue("@Apellido", telefono);
            comando.Parameters.AddWithValue("@Cedula", cedula);
            comando.Parameters.AddWithValue("@Correo", correo);
            comando.Parameters.AddWithValue("@FechaNacimiento", fechanacimiento);
            comando.Parameters.AddWithValue("@Cargo", cargo);
            comando.Parameters.AddWithValue("@Telefono", telefono);
            comando.Parameters.AddWithValue("@FechaIngreso", fechaingreso);
            comando.Parameters.AddWithValue("@id_Departamento", iddepartamento);
            comando.Parameters.AddWithValue("@id_Direccion", iddireccion);
            comando.Parameters.AddWithValue("@id_Genero", genero);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }
    }
}
