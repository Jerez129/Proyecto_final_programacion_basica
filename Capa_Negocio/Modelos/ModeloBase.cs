using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{  //TODO: Aplicar metodo virtuar paraa la validación de datos a la hora de trabajar su inserción .
    public abstract class ModeloBase
    {
        public virtual bool Validacion(out string mensaje)
        {
            // Inicializa el mensaje de error

            mensaje = null;
            // Implementación de la validación básica
            return true; // Retorna true si la validación es exitosa
        }

        public virtual bool ValidacionEditar (out string mensaje)
        {
            mensaje = null;
            // Implementación de la validación básica
            return true; // Retorna true si la validación es exitosa
        }
    }
}
