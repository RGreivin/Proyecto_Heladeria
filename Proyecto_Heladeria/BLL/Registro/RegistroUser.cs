using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.ConexionBD;

namespace BLL.Registro
{
    public class RegistroUser
    {
        //instanciamos al objeto de acceso dtos de usuario
        RegistroDtosUser registro = new RegistroDtosUser();

        public void Registro(string cedula, string nombre, string apellidos, string user, string passw, string correo, string telefono,string rol)
        {
            registro.InsertRegistro(Convert.ToInt32(cedula), nombre, apellidos, user, passw, correo, Convert.ToInt32(telefono),rol);
        }
    }
}
