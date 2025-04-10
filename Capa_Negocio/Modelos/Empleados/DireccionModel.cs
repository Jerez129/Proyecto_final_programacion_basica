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
    //clase que reprenseta el modelo de direccion dentro de la capa de negocio 
    public class DireccionModel : ModeloBase
    {
        //se crea una instacia de la clase CD_Conexion para poder realizar la conexion a la base de datos   
        private CD_Conexion conexion = new CD_Conexion();
        //se declaran las variables que se van a utilizar para realizar la consulta a la base de datos
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        public int IdDireccion { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }
       
        public string Municipio { get; set; }


        // Método que obtiene todas las direcciones almacenadas en la base de datos
        // y devuelve un DataTable con los datos formateados

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

