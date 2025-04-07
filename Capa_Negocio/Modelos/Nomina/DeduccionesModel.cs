using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class DeduccionesModel : EmpleadosModel
    {
        public int IdDeducciones { get; set; }
        public decimal Seguros { get; set; }
        public decimal MontoNeto { get; set; }
        public decimal Cooperativa { get; set; }
        public decimal Prestamo { get; set; }
        public int Cuotas { get; set; }
        public int CuotasPagadas { get; set; }
        public int IdEmpleado { get; set; }





    }
}
