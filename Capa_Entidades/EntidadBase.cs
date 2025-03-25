using Capa_Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
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
