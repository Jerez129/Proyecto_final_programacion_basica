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
        /*Definición de métodos para la interfaz ICapa_de_Negocio
         Estos métodos son genéricos y se aplican a cualquier entidad que implemente esta interfaz
         Se espera que cada entidad tenga su propia implementación de estos métodos
         El tipo T representa el modelo de datos específico que se utilizará en la implementación*/
        DataTable Mostrar();
        void Insertar(T modelo);
        void Editar(T modelo);
        void Eliminar(T modelo);


    }
}
