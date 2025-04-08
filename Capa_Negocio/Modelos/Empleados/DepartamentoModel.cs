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
    public class DepartamentoModel : ModeloBase
    {
        public int IdDepartamento { get; set; }
        public string NombreDepartamento { get; set; }
        public string Descripcion { get; set; }


        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        public DataTable MostrarDepartamento()
        {
            comando.Connection = conexion.AbrirConexion();
            string query = "SELECT id_Departamento, NombreDepartamento, Descripcion FROM Departamentos";
            comando.CommandType = CommandType.StoredProcedure;
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

