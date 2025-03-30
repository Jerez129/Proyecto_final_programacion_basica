using Capa_Negocio.Interfaces;
using System.Data;
using Capa_Datos.ClasesDAL;

namespace Capa_Negocio
{
    public class CN_Control_Nomina : IControlNomina
    {
        private readonly NominaDAL nominaDAL = new NominaDAL();
        private readonly DeduccionesDAL deduccionesDAL = new DeduccionesDAL();

        // CRUD Nómina
        public DataTable MostrarNomina()
        {
            try
            {
                DataTable tabla = nominaDAL.MostrarNomina();
                // Aquí podrías procesar los datos si es necesario antes de devolverlos
                return tabla;
            }
            catch (Exception ex)
            {
                // Manejo de errores adecuado
                throw new Exception("Error al obtener la nómina: " + ex.Message);
            }
        }

        public void InsertarNomina(int id_Empleado, DateTime fechaPago, decimal monto, int id_Deducciones)
        {
            nominaDAL.InsertarNomina(id_Empleado, fechaPago, monto, id_Deducciones);
        }

        public void EditarNomina(int id_Nomina, int id_Empleado, DateTime fechaPago, decimal monto, int id_Deducciones)
        {
            nominaDAL.EditarNomina(id_Nomina, id_Empleado, fechaPago, monto, id_Deducciones);
        }

        public void EliminarNomina(int id_Nomina)
        {
            nominaDAL.EliminarNomina(id_Nomina);
        }

        // CRUD Deducciones
        public void MostrarDeduccion()
        {
            DataTable tabla = deduccionesDAL.MostrarDeducciones();
        }

        public void InsertarDeducciones(decimal seguros, decimal montoNeto, decimal cooperativa, decimal prestamo)
        {
            deduccionesDAL.InsertarDeducciones(seguros, montoNeto, cooperativa, prestamo);
        }

        public void EditarDeducciones(int id_Deducciones, decimal seguros, decimal montoNeto, decimal cooperativa, decimal prestamo)
        {
            deduccionesDAL.EditarDeducciones(id_Deducciones, seguros, montoNeto, cooperativa, prestamo);
        }

        public void EliminarDeducciones(int id_Deducciones)
        {
            deduccionesDAL.EliminarDeducciones(id_Deducciones);
        }
    }

}
