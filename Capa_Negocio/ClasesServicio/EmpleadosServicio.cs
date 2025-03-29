using Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos.ClasesDAL;
using Capa_Negocio.Interfaces;
/*

namespace Capa_Negocio.ClasesServicio
{
    public class Empleado : EntidadBase
    {
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

        // Método para convertir de DAL a Negocio
        public static Empleado FromDAL(EmpleadosDAL dal)
        {
            return new Empleado
            {
                IdEmpleado = dal.IdEmpleado,
                Nombre = dal.Nombre,
                Apellido = dal.Apellido,
                Cedula = dal.Cedula,
                Correo = dal.Correo,
                FechaNacimiento = dal.FechaNacimiento,
                Cargo = dal.Cargo,
                Telefono = dal.Telefono,
                FechaIngreso = dal.FechaIngreso,
                IdDepartamento = dal.IdDepartamento,
                IdDireccion = dal.IdDireccion,
                IdGenero = dal.IdGenero
            };
        }
 
    }


}
*/