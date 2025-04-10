using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_Negocio
{
    // La clase CN_Control_Ausencias gestiona las operaciones relacionadas con las ausencias de los empleados.
    // Hereda de AusenciasModel para acceder a sus funcionalidades y también implementa la interfaz ICapa_de_Negocio,
    // lo que le permite realizar las operaciones CRUD sobre las ausencias.
    public class CN_Control_Ausencias : AusenciasModel, ICapa_de_Negocio<AusenciasModel>
    {
        // Instancia de la clase AusenciasModel, usada para acceder a los métodos de manejo de ausencias.
        AusenciasModel CN_Ausencias = new AusenciasModel();

        // Instancia de la clase EmpleadosModel, usada para acceder a los métodos de manejo de empleados.
        private EmpleadosModel CN_Empleados = new EmpleadosModel();

        // Método para mostrar las ausencias de los empleados filtradas por una fecha específica.
        // Recibe una fecha y retorna un DataTable con las ausencias de esa fecha.
        public DataTable Mostrarausenciaporfecha(DateTime fecha)
        {
            return CN_Ausencias.MostrarAusenciasPorFecha(fecha);
        }

        // Método para mostrar los tipos de ausencias disponibles. Devuelve un DataTable con los tipos.
        public DataTable MostrarTipodeausencia()
        {
            return CN_Ausencias.MostrarTipodeausencia();
        }

        // Método para mostrar los empleados con una información básica.
        // Este método se utiliza para obtener una lista de empleados con detalles básicos.
        public DataTable MostrarEmpleadoBasico()
        {
            return CN_Empleados.MostrarEmpleadoBasico();
        }

        // Método para obtener las ausencias que se pueden editar.
        // Este método devuelve un DataTable con las ausencias que se pueden modificar.
        public DataTable MostrarAusenciasParaEditar()
        {
            return CN_Ausencias.MostrarAusenciasParaEditar();
        }

        // Método para mostrar todas las ausencias registradas.
        // Retorna un DataTable con todas las ausencias en el sistema.
        public DataTable Mostrar()
        {
            return CN_Ausencias.Mostrar();
        }

        // Método para insertar una nueva ausencia.
        // Recibe un objeto de tipo AusenciasModel y lo inserta en la base de datos.
        public void Insertar(AusenciasModel ausencia)
        {
            CN_Ausencias.Insertar(ausencia);
        }

        // Método para eliminar una ausencia.
        // Recibe un objeto de tipo AusenciasModel y elimina la ausencia correspondiente.
        public void Eliminar(AusenciasModel ausencia)
        {
            CN_Ausencias.Eliminar(ausencia);
        }

        // Método para editar una ausencia existente.
        // Recibe un objeto de tipo AusenciasModel y actualiza la información de la ausencia.
        public void Editar(AusenciasModel ausencia)
        {
            CN_Ausencias.Editar(ausencia);
        }

        // Método de validación, sobrecargado de la clase base.
        // Este método se utiliza para validar la ausencia antes de realizar operaciones.
        // Si la validación es exitosa, retorna 'true' y el mensaje es vacío. Si no, retorna 'false' y un mensaje de error.
        public override bool Validacion(out string mensaje)
        {


            // Validar que la fecha de inicio no sea mayor que la fecha de fin
            if (FechaInicio > FechaFin)
            {
                mensaje = "La fecha de inicio no puede ser mayor que la fecha de fin.";
                return false;
            }

            // Validar que la fecha de inicio y fin no sean nulas
            if (FechaInicio == null || FechaFin == null)
            {
                mensaje = "Las fechas de inicio y fin no pueden ser nulas.";
                return false;
            }

            // Validar que el id del empleado no sea nulo o vacío
            if (IdEmpleado <= 0)
            {
                mensaje = "El ID del empleado debe ser un valor válido.";
                return false;
            }

            // Validar que el tipo de ausencia no sea nulo o vacío
            if (IdTipoAusencia <= 0)
            {
                mensaje = "El tipo de ausencia debe ser un valor válido.";
                return false;
            }

            // Validar que la ausencia no esté duplicada
            DataTable ausencias = CN_Ausencias.Mostrar();
            foreach (DataRow row in ausencias.Rows)
            {
                DateTime fechaInicioExistente = Convert.ToDateTime(row["FechaInicio"]);
                DateTime fechaFinExistente = Convert.ToDateTime(row["FechaFin"]);
                if (IdEmpleado == Convert.ToInt32(row["id_Empleado"]) &&
                    ((FechaInicio >= fechaInicioExistente && FechaInicio <= fechaFinExistente) ||
                    (FechaFin >= fechaInicioExistente && FechaFin <= fechaFinExistente)))
                {
                    mensaje = "Ya existe una ausencia registrada en este período para el empleado.";
                    return false;
                }
            }

            // Si todo está correcto
            mensaje = "OK"; // Puedes devolver un mensaje positivo si todo es válido
            return true;
        }


        public override bool ValidacionEditar(out string mensaje)
        {
            // Aquí puedes implementar la lógica de validación específica para editar
            // Por ejemplo, verificar que las fechas no se superpongan con otras ausencias
            // o que el ID del empleado sea válido.
            // Llamar a la validación base
            // Validar que la fecha de inicio no sea mayor que la fecha de fin
            if (FechaInicio > FechaFin)
            {
                mensaje = "La fecha de inicio no puede ser mayor que la fecha de fin.";
                return false;
            }
            // Si todas las validaciones son correctas
            mensaje = "OK"; // Puedes devolver un mensaje positivo si todo es válid
            return true;
        }



    }


}

