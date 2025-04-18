﻿using Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio.Modelos.Empleados
{//esta clase reprenseta el modelo de genero dentro de la capa de negocio 
    public class GeneroModel : ModeloBase
    {//creamos la conexo a la base de datos y le indicamos que es lo que vamos a utilizar en este caso Genero
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();
        SqlDataReader leer;
        DataTable tabla = new DataTable();

        int Genero { get; set; }

        public DataTable MostrarGenero()
        {//aqui selecionamos los datos con un comando y no con proceso almacenado , abrimos la cadena de coxnexion y le indicamos que es lo que vamos a utilizar    
            comando.Connection = conexion.AbrirConexion();
            string query = "SELECT id_Genero, Genero FROM Genero"; 
            comando.CommandText = query;
            comando.CommandType = CommandType.Text;
            comando.Parameters.Clear();
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();

            // Agregar una nueva columna "MostrarGenero" para la visualización de "Masculino" y "Femenino"
            tabla.Columns.Add("MostrarGenero", typeof(string));

            // Asignar "Masculino" o "Femenino" a la nueva columna según el valor de la columna "Genero"
            foreach (DataRow row in tabla.Rows)
            {
                row["MostrarGenero"] = (Convert.ToBoolean(row["Genero"])) ? "Masculino" : "Femenino";
            }

            return tabla;
        }




    }
}
