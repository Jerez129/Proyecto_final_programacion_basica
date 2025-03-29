using Capa_Datos.ClasesDAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio.Interfaces
{
    public interface ICapa_de_Negocio
    {
        DataTable Mostrar();
        void Insertar(EmpleadosDAL empleado);
        void Editar(EmpleadosDAL empleado);
        void Eliminar(EmpleadosDAL empleado);

    }
}
