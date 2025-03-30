using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public interface ICapa_de_Negocio<T>
    {
        DataTable Mostrar();
        void Insertar(T modelo);
        void Editar(T modelo);
        void Eliminar(T modelo);

    }
}
