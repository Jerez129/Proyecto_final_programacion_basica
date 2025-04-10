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
    {    // Propiedades del modelo de departamento
        public int IdDepartamento { get; set; }
        public string NombreDepartamento { get; set; }
        public string Descripcion { get; set; }

        // Conexión a la base de datos y objetos necesarios para ejecutar la consulta
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        // Este método obtiene todos los departamentos desde la base de datos
        // y devuelve los resultados en un DataTable.
        public DataTable MostrarDepartamento()
        {
            comando.Connection = conexion.AbrirConexion();
            // Consulta SQL que selecciona los campos de la tabla Departamentos
            string query = "SELECT id_Departamento, NombreDepartamento, Descripcion FROM Departamentos";
            // Se indica que se va a ejecutar una consulta de texto (no un procedimiento almacenado)
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

