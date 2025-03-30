using Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    
    public class DireccionModel
    {

        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        public int IdDireccion { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }
       
        public string Municipio { get; set; }


        public DataTable MostrarDireccion()
        {
            comando.Connection = conexion.AbrirConexion();
            string query = "SELECT Id_Direccion, CONCAT(Di.Pais, ', ', Di.Provincia, ', ', Di.Municipio) AS Direccion FROM Direccion Di";
            comando.CommandText = query;
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

    }


}

