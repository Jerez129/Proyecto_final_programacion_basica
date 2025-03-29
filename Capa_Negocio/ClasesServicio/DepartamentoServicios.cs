using Capa_Datos.ClasesDAL;
using Capa_Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio.ClasesServicio
{
    public class Departamento : EntidadBase
    {
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public override bool EsValido()
        {
            return !string.IsNullOrEmpty(Nombre) && !string.IsNullOrEmpty(Descripcion);
        }

        public static Departamento FromDAL(DepartamentoDAL dal)
        {
            return new Departamento
            {
                IdDepartamento = dal.IdDepartamento,
                Nombre = dal.Nombre,
                Descripcion = dal.Descripcion
            };
        }
    }

}


