using Capa_Datos.ClasesDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using System.Data.SqlClient;
using Conexion;


namespace Capa_Negocio
{
    public class CN_Login
    {
        //aqui creamos la logica que se ulilisara para validad el usuario que nos brinda usuariosDal
        //es decir esta sera como otra capa de acceso que se encargara de validar el usuario 
        public class UsuarioNegocio
        {
            private UsuariosDAL usuariosDAL = new UsuariosDAL();

            public bool IniciarSesion(string usuario, string contraseña)
            {
                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
                    return false;
    
                try
                {
                    return usuariosDAL.ObtenerUsuario(usuario, contraseña) != null;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error en la validación del usuario.", ex);
                }
            }
        }


    }
}




     
    
