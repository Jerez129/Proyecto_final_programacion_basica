using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public abstract class ModeloBase
    {
        public virtual bool Validacion(out string mensaje)
        {
            // Inicializa el mensaje de error

            mensaje = null;
            // Implementación de la validación básica
            // Aquí puedes agregar la lógica común para validar los modelos
            // Por ejemplo, verificar si los campos obligatorios están completos
            return true; // Retorna true si la validación es exitosa
        }

        public virtual bool ValidacionEditar (out string mensaje)
        {
            mensaje = null;
            // Implementación de la validación básica
            // Aquí puedes agregar la lógica común para validar los modelos
            // Por ejemplo, verificar si los campos obligatorios están completos
            return true; // Retorna true si la validación es exitosa
        }
    }
}
