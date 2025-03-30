using Conexion;
using System.Data.SqlClient;
using System.Data;

namespace Capa_Datos.ClasesDAL
{
    public class DeduccionesDAL
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlDataReader? leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarDeducciones()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarDeduccionesDetallado";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarDeducciones(decimal seguros, decimal montoNeto, decimal cooperativa, decimal prestamo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarDeducciones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Seguros", seguros);
            comando.Parameters.AddWithValue("@MontoNeto", montoNeto);
            comando.Parameters.AddWithValue("@Cooperativa", cooperativa);
            comando.Parameters.AddWithValue("@Prestamo", prestamo);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EditarDeducciones(int id_Deducciones, decimal seguros, decimal montoNeto, decimal cooperativa, decimal prestamo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarDeducciones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Deducciones", id_Deducciones);
            comando.Parameters.AddWithValue("@Seguros", seguros);
            comando.Parameters.AddWithValue("@MontoNeto", montoNeto);
            comando.Parameters.AddWithValue("@Cooperativa", cooperativa);
            comando.Parameters.AddWithValue("@Prestamo", prestamo);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void EliminarDeducciones(int id_Deducciones)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarDeducciones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Deducciones", id_Deducciones);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
