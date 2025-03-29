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

