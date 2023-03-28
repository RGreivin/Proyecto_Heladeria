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
        #endregion
    }
}
   
    
