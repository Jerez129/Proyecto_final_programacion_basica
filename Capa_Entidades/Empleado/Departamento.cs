using Capa_Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades.Empleado
{
    public class Departamento : EntidadBase
    {
        int idDepartamento { get; set; }
        string nombre { get; set; }

        string descripcion { get; set; }

        public override bool EsValido()
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion))
                return false;
            return true;
        }

    }
}
