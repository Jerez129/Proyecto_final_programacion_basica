using Capa_Datos.ClasesDAL;
using Capa_Negocio;
using Capa_Negocio.Modelos.Empleados;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    // La clase CN_Control_Empleados se encarga de gestionar las operaciones relacionadas con los empleados.
    // Esta clase hereda de EmpleadosModel y también implementa la interfaz ICapa_de_Negocio,
    // lo que le permite realizar operaciones CRUD sobre los empleados.
    public class CN_Control_Empleados : EmpleadosModel, ICapa_de_Negocio<EmpleadosModel>
    {
        // Instancia de la clase EmpleadosModel, usada para acceder a los métodos de manejo de empleados.
        private EmpleadosModel CN_Empleados = new EmpleadosModel();

        // Instancias de otras clases que gestionan la información relacionada con dirección, género y departamento.
        DireccionModel CN_Direccion = new DireccionModel();
        GeneroModel CN_Genero = new GeneroModel();
        DepartamentoModel CN_Departamento = new DepartamentoModel();

        // Método para mostrar los géneros de los empleados.
        // Devuelve un DataTable con los géneros disponibles (Masculino, Femenino).
        public DataTable MostrarGenero()
        {
            return CN_Genero.MostrarGenero();
        }

        // Método para mostrar los departamentos de la empresa.
        // Devuelve un DataTable con los departamentos disponibles.
        public DataTable MostrarDepartamento()
        {
            return CN_Departamento.MostrarDepartamento();
        }

        // Método para mostrar las direcciones de los empleados.
        // Devuelve un DataTable con las direcciones registradas en el sistema.
        public DataTable MostrarDireccion()
        {
            return CN_Direccion.MostrarDireccion();
        }

        // Método para mostrar la lista completa de empleados.
        // Retorna un DataTable con todos los empleados registrados en el sistema.
        public DataTable Mostrar()
        {
            return CN_Empleados.Mostrar();
        }

        // Método para insertar un nuevo empleado en la base de datos.
        // Recibe un objeto de tipo EmpleadosModel y lo inserta en la base de datos.
        public void Insertar(EmpleadosModel empleado)
        {
            CN_Empleados.Insertar(empleado);
        }

        // Método para editar un empleado existente en la base de datos.
        // Recibe un objeto de tipo EmpleadosModel y actualiza la información del empleado.
        public void Editar(EmpleadosModel empleado)
        {
            CN_Empleados.Editar(empleado);
        }

        // Método para eliminar un empleado de la base de datos.
        // Recibe un objeto de tipo EmpleadosModel y elimina el empleado correspondiente.
        public void Eliminar(EmpleadosModel empleado)
        {
            CN_Empleados.Eliminar(empleado);
        }
    }
}
public override bool Validacion(out string mensaje)
        {
            // Validar que la fecha de nacimiento no sea mayor que la fecha de ingreso
            if (FechaNacimiento > FechaIngreso)
            {
                mensaje = "La fecha de nacimiento no puede ser mayor que la fecha de ingreso.";
                return false;
            }

            // Validar que la fecha de nacimiento y fecha de ingreso no sean nulas
            if (FechaNacimiento == null || FechaIngreso == null)
            {
                mensaje = "La fecha de nacimiento y la fecha de ingreso no pueden ser nulas.";
                return false;
            }

            // Validar que el nombre no sea nulo o vacío
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                mensaje = "El nombre no puede estar vacío.";
                return false;
            }

            // Validar que el apellido no sea nulo o vacío
            if (string.IsNullOrWhiteSpace(Apellido))
            {
                mensaje = "El apellido no puede estar vacío.";
                return false;
            }

            // Validar que la cédula no sea nula o vacía 
            if (string.IsNullOrWhiteSpace(Cedula) || Cedula.Length != 11 || !Cedula.All(char.IsDigit))
            {
                mensaje = "La cédula debe tener 11 dígitos y solo contener números.";
                return false; //  Cédula no válida
            }

            // Validar que la cédula no este duplicada
            DataTable empleados = CN_Empleados.Mostrar();
            foreach (DataRow row in empleados.Rows)
            {
                if (Cedula == row["Cedula"].ToString())
                {
                    mensaje = "La cédula ya está registrada.";
                    return false; //  Cédula duplicada
                }
            }

            // Validar que el correo no sea nulo o vacío
            if (string.IsNullOrWhiteSpace(Correo) ||
                !Regex.IsMatch(Correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                mensaje = "El correo no es válido. Debe tener un formato adecuado (ejemplo@dominio.com).";
                return false; //  Correo no válido
            }
            // Validar que el correo no esté duplicado
            foreach (DataRow row in empleados.Rows)
            {
                if (Correo == row["Correo"].ToString())
                {
                    mensaje = "El correo ya está registrado.";
                    return false; //  Correo duplicado
                }
            }

            // Validar que el teléfono no sea nulo o vacío
            if (string.IsNullOrWhiteSpace(Telefono) || Telefono.Length != 10 || !Telefono.All(char.IsDigit))
            {
                mensaje = "El teléfono debe tener 10 dígitos y solo contener números.";
                return false; //  Teléfono no válido
            }

              // Validar que el salario base no sea nulo o menor que 0
               if (SalarioBase == null || SalarioBase <= 0)
               {
                   mensaje = "El salario base debe ser un valor mayor a cero y no nulo.";
                   return false; // Salario base no válido
               }

            // Validar que el id del departamento no sea nulo o vacío
            if (IdDepartamento <= 0)
            {
                mensaje = "El ID del departamento debe ser un valor válido.";
                return false; //  ID de departamento no válido
            }

            // Validar que el id de la dirección no sea nulo o vacío
            if (IdDireccion <= 0)
            {
                mensaje = "El ID de la dirección debe ser un valor válido.";
                return false; //  ID de dirección no válido
            }

            // Validar que el id del género no sea nulo o vacío
            if (IdGenero <= 0)
            {
                mensaje = "El ID del género debe ser un valor válido.";
                return false; //  ID de género no válido
            }

            // Validar que el cargo no sea nulo o vacío
            if (string.IsNullOrWhiteSpace(Cargo))
            {
                mensaje = "El cargo no puede estar vacío.";
                return false; //  Cargo no válido
            }

            // Si todas las validaciones son correctas
            mensaje = "OK"; // Puedes devolver un mensaje positivo si todo es válid
            return true;
        }

        public override bool ValidacionEditar(out string mensaje)
        {
            // Validar que la fecha de nacimiento no sea mayor que la fecha de ingreso
            if (FechaNacimiento > FechaIngreso)
            {
                mensaje = "La fecha de nacimiento no puede ser mayor que la fecha de ingreso.";
                return false;
            }

            // Validar que la fecha de nacimiento y fecha de ingreso no sean nulas
            if (FechaNacimiento == null || FechaIngreso == null)
            {
                mensaje = "La fecha de nacimiento y la fecha de ingreso no pueden ser nulas.";
                return false;
            }

            // Validar que el nombre no sea nulo o vacío
            if (string.IsNullOrWhiteSpace(Nombre))
            {
                mensaje = "El nombre no puede estar vacío.";
                return false;
            }

            // Validar que el apellido no sea nulo o vacío
            if (string.IsNullOrWhiteSpace(Apellido))
            {
                mensaje = "El apellido no puede estar vacío.";
                return false;
            }

            // Validar que la cédula no sea nula o vacía 
            if (string.IsNullOrWhiteSpace(Cedula) || Cedula.Length != 11 || !Cedula.All(char.IsDigit))
            {
                mensaje = "La cédula debe tener 11 dígitos y solo contener números.";
                return false; //  Cédula no válida
            }

            // Validar que la cédula no este duplicada pero excluyendo el empleado actual
            DataTable empleados = CN_Empleados.Mostrar();
            foreach (DataRow row in empleados.Rows)
            {
                if (Cedula == row["Cedula"].ToString() && IdEmpleado != Convert.ToInt32(row["id_Empleado"]))
                {
                    mensaje = "La cédula ya está registrada.";
                    return false; //  Cédula duplicada
                }
            }

            // Validar que el correo no sea nulo o vacío
            if (string.IsNullOrWhiteSpace(Correo) ||
                !Regex.IsMatch(Correo, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                mensaje = "El correo no es válido. Debe tener un formato adecuado (ejemplo@dominio.com).";
                return false; //  Correo no válido
            }
            // Validar que el correo no esté duplicado pero excluyendo el empleado actual
            foreach (DataRow row in empleados.Rows)
            {
                if (Correo == row["Correo"].ToString() && IdEmpleado != Convert.ToInt32(row["id_Empleado"]))
                {
                    mensaje = "El correo ya está registrado.";
                    return false; //  Correo duplicado
                }
            }

            // Validar que el teléfono no sea nulo o vacío
            if (string.IsNullOrWhiteSpace(Telefono) || Telefono.Length != 10 || !Telefono.All(char.IsDigit))
            {
                mensaje = "El teléfono debe tener 10 dígitos y solo contener números.";
                return false; //  Teléfono no válido
            }

            // Validar que el salario base no sea nulo o menor que 0
            if (SalarioBase == null || SalarioBase <= 0)
            {
                mensaje = "El salario base debe ser un valor mayor a cero y no nulo.";
                return false; // Salario base no válido
            }

            // Validar que el id del departamento no sea nulo o vacío
            if (IdDepartamento <= 0)
            {
                mensaje = "El ID del departamento debe ser un valor válido.";
                return false; //  ID de departamento no válido
            }

            // Validar que el id de la dirección no sea nulo o vacío
            if (IdDireccion <= 0)
            {
                mensaje = "El ID de la dirección debe ser un valor válido.";
                return false; //  ID de dirección no válido
            }

            // Validar que el id del género no sea nulo o vacío
            if (IdGenero <= 0)
            {
                mensaje = "El ID del género debe ser un valor válido.";
                return false; //  ID de género no válido
            }

            // Validar que el cargo no sea nulo o vacío
            if (string.IsNullOrWhiteSpace(Cargo))
            {
                mensaje = "El cargo no puede estar vacío.";
                return false; //  Cargo no válido
            }
            // Si todas las validaciones son correctas
            mensaje = "OK"; // Puedes devolver un mensaje positivo si todo es válid
            return true;
        }
    }
}
