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
         AccesoDtosUser dtos_Users = new AccesoDtosUser();
        public bool Dtos_Login(string user, string pass)
        {
            return dtos_Users.login(user, pass);

        }
        //Cambiar el logueo
        //public bool editUser(string user, string pass)
        //{
        //    if (user == cacheLogin.user)
        //    {

        //    }
        //    return true;

        //}
    }
}
