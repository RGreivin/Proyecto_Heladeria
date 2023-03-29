using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_Soporte.Cache;
namespace DAL.ConexionBD
{

    public class AccesoDtosUser
    {
        #region Metodo login usuarios

        private ConexionBD.ConectarBD conexion = new ConexionBD.ConectarBD();
        SqlCommand comand = new SqlCommand();

        //Creamos un metodo de tipo bool para el login
        public bool Login(string user, string passw)
        {
            comand.Connection = conexion.AbrirConexion();
            comand.CommandText = "LoginEmpleados";
            comand.Parameters.AddWithValue("@Usuario", user);
            comand.Parameters.AddWithValue("@Password", passw);
            comand.CommandType = CommandType.StoredProcedure;
            SqlDataReader rd = comand.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    //agregamos los valores a la clase statica 
                    //Estos datos permaneceran en menoria
                    CacheLogin.Nombre = rd.GetString(0);
                    CacheLogin.Apellidos = rd.GetString(1);
                    CacheLogin.Rol = rd.GetString(2);
                }
                return true;
            }
            else
                //La consulta no existe
                return false;
        }
        #endregion Termina la validacion del logueo del usuario

        #region Recuperacion del logueo del usuario
        public string RecuperarUserPass(string userRequesting)
        {
            comand.Connection = conexion.AbrirConexion();
            comand.CommandText = "RecuperarLogin";
            //comand.Parameters.AddWithValue("@Usuario", userRequesting);
            comand.Parameters.AddWithValue("@Correo", userRequesting);
            comand.CommandType = CommandType.StoredProcedure;
            SqlDataReader rd = comand.ExecuteReader();
            if (rd.Read() == true)
            {
                string userName = rd.GetString(0) + "  " + rd.GetString(1);
                string user = rd.GetString(2);
                //Obtenemos el correo del usuario y la contraseña
                string userMail = rd.GetString(4);
                string password = rd.GetString(3);

                //Instanciamos la clase de correo de soporte de sistema
                var mailService = new ServiciosMail.SistemaSoportMail();
                //Invocamos el metodo de enviar correo de la clase de soporte de sistema
                mailService.sendMail(
                    subject: "Recuperación de contraseña y usuario",
                    body: "Solicitud de recuperacion de la cuenta de " + userName + "\n Su usuario es : " + user + "\n Su contraseña es : " + password,
                    recipientMail: new List<string> { userMail }
                    );
                return "Correo Enviado, Por favor \nVerifiqué su correo electrónico";
            }
            else
            {
                return "Lo sentimos, no tienes una cuenta con\n"+
                    "este correo electrónico.";
            }
        }
        public string recuperarAcceso(string usertelefono)
        {

            comand.Connection = conexion.AbrirConexion();
            comand.CommandText = "SELECT * FROM Empleados WHERE  Telefono=@Telefono";
            comand.Parameters.AddWithValue("@Telefono", usertelefono);
            comand.CommandType = CommandType.Text;
            SqlDataReader rd = comand.ExecuteReader();
            if (rd.Read() == true)
            {
                string userName = rd.GetString(2) + "," + rd.GetString(3);
                string user = rd.GetString(7);
                //Obtenemos el correo del usuario y la contraseña
                string userTelefono = rd.GetString(6);
                string password = rd.GetString(8);


                if (usertelefono.Length <= 0)
                {
                    usertelefono = "+506 " + usertelefono;
                }
                usertelefono = usertelefono.Replace(" ", "");
                System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone=" + usertelefono + "&text=" + userName + " su usuario es:  " + user + "\n" + " su contraseña es: " + password);
                return "EL Mensaje  se envio, correctamente";
            }
            else
            {
                return "Lo sentimos, no tiene un numero de telefono \n a esta cuenta";
            }
        }
    }
    #endregion Termina la recuperacion del logueo del usuario
}



