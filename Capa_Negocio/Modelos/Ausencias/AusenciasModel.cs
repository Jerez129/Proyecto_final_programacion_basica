using Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Negocio.Interfaces;

namespace Capa_Negocio
{
    public class AusenciasModel
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        
        public int IdAusencia { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public int IdTipoAusencia { get; set; }
        public bool Aprobado { get; set; }
        public DataTable MostrarTipodeausencia()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarTipoddeausnecia";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
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

        public DataTable MostrarAusenciasPorFecha(DateTime fecha)
        {
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
 
                comando.CommandText = query;
             comando.CommandType = CommandType.Text;
             comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@Fecha", fecha.Date); 
             leer = comando.ExecuteReader();
             tabla.Load(leer);
             conexion.CerrarConexion();
             return tabla;

        }





    }




}
