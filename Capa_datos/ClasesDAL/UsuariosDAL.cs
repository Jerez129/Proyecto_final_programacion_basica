using Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.ClasesDAL
{
   public class UsuariosDAL
    {
        private CD_Conexion conexion = new CD_Conexion();

        public object ObtenerUsuario(string usuario, string contraseña)
        {
            using (var cmd = new SqlCommand("SELECT 1 FROM Usuarios WHERE NombreUsuario = @NombreUsuario AND Clave = @Clave", conexion.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@NombreUsuario", usuario);
                cmd.Parameters.AddWithValue("@Clave", contraseña);

                var resultado = cmd.ExecuteScalar();  // Devuelve null si no hay coincidencia
                conexion.CerrarConexion();

                return resultado;  // Si no hay coincidencia, 'resultado' será null
            }
        }

    }
}
