using Capa_Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//comprobacion de datos  con metodo virtual
namespace Capa_Negocio.Interfaces
{
    public abstract class EntidadBase : IEntidad
    {
        public int Id { get; set; }

        public virtual bool EsValido()
        {

            return true;
        }


    }
}


