using Capa_Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades.Empleado
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

        // Propiedades de navegación (para relaciones) 
        public Departamento Departamento { get; set; }
        public Direccion Direccion { get; set; }

        public int CalcularEdad()
        {
            int edad = DateTime.Today.Year - FechaNacimiento.Year;
            if (FechaNacimiento.Date > DateTime.Today.AddYears(-edad))
                edad--;
            return edad;
        }

        /// <summary> 
        /// Calcula la antigüedad del empleado en años 
        /// </summary> 
        public int CalcularAntiguedad()
        {
            int antiguedad = DateTime.Today.Year - FechaIngreso.Year;
            if (FechaIngreso.Date > DateTime.Today.AddYears(-antiguedad))
                antiguedad--;
            return antiguedad;
        }

        /// <summary> 
        /// Sobrescribe el método de validación de la clase base 
        /// </summary> 
        public override bool EsValido()
        {
            // Validaciones básicas 
            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Apellido) ||
            string.IsNullOrEmpty(Cedula))
                return false;

            // Validación de cédula (ejemplo) 
            if (Cedula.Length < 10)
                return false;

            return true;
        }


    }

}

