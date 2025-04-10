using Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Negocio;

namespace Capa_Negocio
{
    public class AusenciasModel : ModeloBase
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        
        public int IdAusencia { get; set; }//se declaran las variables que se van a utilizar
        public int IdEmpleado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IdTipoAusencia { get; set; }
        public bool Aprobado { get; set; }
        public DataTable MostrarTipodeausencia() //se llama el proceso almacenado a utlizar 
         
         // con las demas lineas e repite lo mismo tienen su conexion a la base de datos y su respectivo proceso almacenado
         //proceso almancedos que se encargan de conectarlo a la base datos y verificar la informacion 
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarTipoddeausnecia";
            comando.CommandType = CommandType.StoredProcedure;
             // Se ejecuta la consulta y se leen los datos
            leer = comando.ExecuteReader();
               // Se cargan los datos en la tabla para devolverlos
            tabla.Load(leer);
             // Se cierra la conexión
            conexion.CerrarConexion();
             // Se retorna la tabla con los resultados
            return tabla;
        }//se repite el mismo proceso para los demas metodos
        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAusencias";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(AusenciasModel ausencia)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarAusencias";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Empleado", ausencia.IdEmpleado);
            comando.Parameters.AddWithValue("@FechaInicio", ausencia.FechaInicio);
            comando.Parameters.AddWithValue("@FechaFin", ausencia.FechaFin);
            comando.Parameters.AddWithValue("@id_Tipo_Ausencia", ausencia.IdTipoAusencia);
            comando.Parameters.AddWithValue("@Aprobado", ausencia.Aprobado);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(AusenciasModel ausencia)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarAusencias";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", ausencia.IdAusencia);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Editar(AusenciasModel ausencia)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarAusencia";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Ausencia", ausencia.IdAusencia);
            comando.Parameters.AddWithValue("@id_Empleado", ausencia.IdEmpleado);
            comando.Parameters.AddWithValue("@FechaInicio", ausencia.FechaInicio);
            comando.Parameters.AddWithValue("@FechaFin", ausencia.FechaFin);
            comando.Parameters.AddWithValue("@id_Tipo_Ausencia", ausencia.IdTipoAusencia);
            comando.Parameters.AddWithValue("@Aprobado", ausencia.Aprobado);
  
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public DataTable MostrarAusenciasParaEditar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarAusenciasParaEditar";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarAusenciasPorFecha(DateTime fecha)
        {
            // Este método recibe una fecha como parámetro
            // y devuelve una tabla con todas las ausencias que coinciden con esa fecha.
            // Es decir, busca las ausencias que estén activas ese día.
            comando.Connection = conexion.AbrirConexion();
             string query = @"
             SELECT 
                A.id_Ausencia,
             E.Nombre,
              E.Apellido,
              E.Cargo,
              E.Telefono,
               E.Correo,
              D.NombreDepartamento,
             A.FechaInicio,
              A.FechaFin,
              TA.Tipo AS TipoAusencia,
              CASE 
                WHEN A.Aprobado = 1 THEN 'Aprobado'
                ELSE 'Pendiente'
              END AS Estado
              FROM Ausencias A
               INNER JOIN Empleados E ON A.id_Empleado = E.id_Empleado
                INNER JOIN Departamentos D ON E.id_Departamento = D.id_Departamento
               INNER JOIN Tipo_Ausencia TA ON A.id_Tipo_Ausencia = TA.id_Tipo_Ausencia
              WHERE @Fecha BETWEEN A.FechaInicio AND A.FechaFin";
            // Se asigna el texto de la consulta al comando
            comando.CommandText = query;
             comando.CommandType = CommandType.Text;
            // Se limpian los parámetros anteriores del comando
            comando.Parameters.Clear();
            // Se agrega el parámetro de fecha que se usará en la consulta
            comando.Parameters.AddWithValue("@Fecha", fecha.Date);
          
            leer = comando.ExecuteReader();
           
            tabla.Load(leer);
           
            conexion.CerrarConexion();
      
            return tabla;
           
           

        }
    }
}
