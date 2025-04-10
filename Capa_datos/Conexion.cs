using System;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
namespace Conexion
{
    public class CD_Conexion
    {
        public SqlConnection Conexion = new SqlConnection("Server=.; Database=BD_Empleados; Integrated Security=true");
        //esta es la cadena de conexion a la base de datos
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        //aqui se abre al conexio y se retorna la conexion
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }// y en esta parte del codigo se cierra la conexion
    }
}