using Capa_Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio.Interfaces
{
    public interface IControlNomina
    {
        //Crud Nomina
        public DataTable MostrarNomina();
        public void InsertarNomina(int id_Empleado, DateTime fechaPago, decimal monto, int id_Deducciones);
        public void EditarNomina(int id_Nomina, int id_Empleado, DateTime fechaPago, decimal monto, int id_Deducciones);
        public void EliminarNomina(int id_Nomina);

        //Crud Deducciones
        public void MostrarDeduccion();
        public void InsertarDeducciones(decimal seguros, decimal montoNeto, decimal cooperativa, decimal prestamo);
        public void EditarDeducciones(int id_Deducciones, decimal seguros, decimal montoNeto, decimal cooperativa, decimal prestamo);
        public void EliminarDeducciones(int id_Deducciones);
    }
}
