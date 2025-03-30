using Conexion;
using System.Data.SqlClient;
using System.Data;


namespace Capa_Datos.ClasesDAL
{
    public class NominaDAL
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader? leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarNomina()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarNominaConDeducciones"; // Ejecuta el procedimiento almacenado original
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        // Método para insertar una nueva nómina
        public void InsertarNomina(int id_Empleado, DateTime fechaPago, decimal monto, int id_Deducciones)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarNomina";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Empleado", id_Empleado);
            comando.Parameters.AddWithValue("@FechaPago", fechaPago);
            comando.Parameters.AddWithValue("@Monto", monto);
            comando.Parameters.AddWithValue("@id_Deducciones", id_Deducciones);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        // Método para actualizar una nómina existente
        public void EditarNomina(int id_Nomina, int id_Empleado, DateTime fechaPago, decimal monto, int id_Deducciones)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarNomina";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Nomina", id_Nomina);
            comando.Parameters.AddWithValue("@id_Empleado", id_Empleado);
            comando.Parameters.AddWithValue("@FechaPago", fechaPago);
            comando.Parameters.AddWithValue("@Monto", monto);
            comando.Parameters.AddWithValue("@id_Deducciones", id_Deducciones);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        // Método para eliminar una nómina
        public void EliminarNomina(int id_Nomina)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarNomina";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Nomina", id_Nomina);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }

}
