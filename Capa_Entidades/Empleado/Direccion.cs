using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades.Empleado
{
    public class Direccion : EntidadBase
    {
        public int IdDireccion { get; set; }
        public string Pais { get; set; }
        public string Provincia { get; set; }
        public string Sector { get; set; }
        public string Calle { get; set; }
        public string Barrio { get; set; }
        public string Residencia { get; set; }

        public override bool EsValido()
        {
            if (string.IsNullOrEmpty(Pais) || string.IsNullOrEmpty(Provincia) || string.IsNullOrEmpty(Sector) || string.IsNullOrEmpty(Calle) || string.IsNullOrEmpty(Residencia))
                return false;

            return true;
        }


    }
}
