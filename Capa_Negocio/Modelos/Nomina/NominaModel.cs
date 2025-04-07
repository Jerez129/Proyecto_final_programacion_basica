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
    public class NominaModel : DeduccionesModel
    {
        private CD_Conexion conexion = new CD_Conexion();
        //esto es para leer data de las tablas
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public int IdNomina { get; set; }
        public int IdEmpleado { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal Monto { get; set; }
        public int IdDeducciones { get; set; }

        



        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarNominas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(NominaModel Nomina)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "GuardarNomina";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Empleado", Nomina.IdEmpleado);
            comando.Parameters.AddWithValue("@SalarioBase", Nomina.SalarioBase);
            comando.Parameters.AddWithValue("@SeguroFijo", Nomina.Seguros);
            comando.Parameters.AddWithValue("@Cooperativa", Nomina.Cooperativa);
            comando.Parameters.AddWithValue("@Prestamo", Nomina.Prestamo);
            comando.Parameters.AddWithValue("@CuotasPrestamo", Nomina.Cuotas);
            comando.Parameters.AddWithValue("@FechaPago", Nomina.FechaPago);
            comando.Parameters.AddWithValue("@Monto", Nomina.Monto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Editar(NominaModel Nomina)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarNomina";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Nomina", Nomina.IdNomina);
            comando.Parameters.AddWithValue("@id_Empleado", Nomina.IdEmpleado);
            comando.Parameters.AddWithValue("@SalarioBase", Nomina.SalarioBase);
            comando.Parameters.AddWithValue("@SeguroFijo", Nomina.Seguros);
            comando.Parameters.AddWithValue("@Cooperativa", Nomina.Cooperativa);
            comando.Parameters.AddWithValue("@Prestamo", Nomina.Prestamo);
            comando.Parameters.AddWithValue("@CuotasPrestamo", Nomina.Cuotas);
            comando.Parameters.AddWithValue("@FechaPago", Nomina.FechaPago);
            comando.Parameters.AddWithValue("@Monto", Nomina.Monto);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(NominaModel Nomina)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarNomina";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Nomina", Nomina.IdNomina);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }


    }
}  
