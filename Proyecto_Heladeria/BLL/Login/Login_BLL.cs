using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.ConexionBD;
using Capa_Soporte.Cache;
namespace BLL.Login
{
    public class Login_BLL
    {
        //instanciamos al objeto de acceso dtos de usuario
         AccesoDtosUser Dtos_Users = new AccesoDtosUser();
        public bool Dtos_Login(string user, string pass)
        {
            return Dtos_Users.Login(user, pass);

        }
        //Creamos un metodo publico con retorno string y un parametro de entrada
        public string RecuperarPassword(string userRequesting)
        {
            return Dtos_Users.RecuperarUserPass(userRequesting);
        }
        public string RecuperarCuenta(string usertelefono)
        {
            return Dtos_Users.recuperarAcceso(usertelefono);
        }
    }
}
