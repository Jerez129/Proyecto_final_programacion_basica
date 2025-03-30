using System;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
namespace Conexion
{
    public class CD_Conexion
    {
        public SqlConnection Conexion = new SqlConnection("Server=.; Database=BD_Empleados; Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}