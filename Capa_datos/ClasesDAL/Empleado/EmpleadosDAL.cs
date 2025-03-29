﻿using Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_Datos.ClasesDAL
{

    public class EmpleadosDAL
    {
        private CD_Conexion conexion = new CD_Conexion();
        //esto es para leer data de las tablas
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();


        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Cargo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int IdDepartamento { get; set; }
        public int IdDireccion { get; set; }
        public int IdGenero { get; set; }

        // Propiedades de navegación (para relaciones) 
        public DepartamentoDAL Departamento { get; set; }
        public DireccionDAL Direccion { get; set; }

        public DataTable Mostrar()
        //TRANSACT SQL
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarEmpleadosDetallado";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

            //PROCEDIMIENTO
        }
        public void Insertar(EmpleadosDAL Empleado)
        {
            //PROCEDIMIENTO
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarEmpleados";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Empleado.Nombre);
            comando.Parameters.AddWithValue("@Apellido", Empleado.Apellido);
            comando.Parameters.AddWithValue("@Cedula", Empleado.Cedula);
            comando.Parameters.AddWithValue("@Correo", Empleado.Correo);
            comando.Parameters.AddWithValue("@FechaNacimiento", Empleado.FechaNacimiento);
            comando.Parameters.AddWithValue("@Cargo", Empleado.Cargo);
            comando.Parameters.AddWithValue("@Telefono", Empleado.Telefono);
            comando.Parameters.AddWithValue("@FechaIngreso", Empleado   .FechaIngreso);
            comando.Parameters.AddWithValue("@id_Departamento", Empleado.IdDepartamento);
            comando.Parameters.AddWithValue("@id_Direccion", Empleado.IdDireccion);
            comando.Parameters.AddWithValue("@id_Genero", Empleado.IdGenero);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(EmpleadosDAL Empleado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id_Empleado", Empleado.IdEmpleado);
            comando.Parameters.AddWithValue("@Nombre", Empleado.Nombre);
            comando.Parameters.AddWithValue("@Apellido", Empleado.Apellido);
            comando.Parameters.AddWithValue("@Cedula", Empleado.Cedula);
            comando.Parameters.AddWithValue("@Correo", Empleado .Correo);
            comando.Parameters.AddWithValue("@FechaNacimiento", Empleado.FechaNacimiento);
            comando.Parameters.AddWithValue("@Cargo", Empleado.Cargo);
            comando.Parameters.AddWithValue("@Telefono", Empleado.Telefono);
            comando.Parameters.AddWithValue("@FechaIngreso", Empleado.FechaIngreso);
            comando.Parameters.AddWithValue("@id_Departamento", Empleado.IdDepartamento);
            comando.Parameters.AddWithValue("@id_Direccion", Empleado.IdDireccion);
            comando.Parameters.AddWithValue("@id_Genero", Empleado.IdGenero);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        public void Eliminar(EmpleadosDAL Empleado)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id_Empleado", Empleado.IdEmpleado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

 
    }
}
