using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_Negocio
{
    public class CN_Control_Ausencias : AusenciasModel , ICapa_de_Negocio<AusenciasModel>
    {
        AusenciasModel CN_Ausencias = new AusenciasModel();
        private EmpleadosModel CN_Empleados = new EmpleadosModel();

        public DataTable Mostrarausenciaporfecha(DateTime fecha)
        {
            return CN_Ausencias.MostrarAusenciasPorFecha(fecha);
        }
        public DataTable MostrarTipodeausencia()
        {
            return CN_Ausencias.MostrarTipodeausencia();
        }

        public DataTable MostrarEmpleadoBasico()
        {
            return CN_Empleados.MostrarEmpleadoBasico();
        }

        public DataTable MostrarAusenciasParaEditar()
        {
            return CN_Ausencias.MostrarAusenciasParaEditar();
        }
        
        public DataTable Mostrar()
        {
            return CN_Ausencias.Mostrar();
        }

        public void Insertar(AusenciasModel ausencia)
        {
            CN_Ausencias.Insertar(ausencia);
        }

        public void Eliminar(AusenciasModel ausencia)
        {
            CN_Ausencias.Eliminar(ausencia);
        }

        public void Editar(AusenciasModel ausencia)
        {
            CN_Ausencias.Editar(ausencia);
        }

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

