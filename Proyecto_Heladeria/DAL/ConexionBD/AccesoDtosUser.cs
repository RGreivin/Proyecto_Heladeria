using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL.ConexionBD
{
    //Esta clase hereda de la clase conexion
    public class AccesoDtosUser:ConectarBD
    {
        #region Metodo login usuarios
        //Creamos un metodo de tipo bool para el login
        public bool login(string user, string passw)
        {
            //variable implicita
            using (var connection = GetSqlConnection())
            {
                //Abrimos la conexion
                connection.Open();
                using (var command = new SqlCommand())
                {
                    //Especificamos la conexion del comando
                    command.Connection = connection;
                    //Especificamos el texto de comando
                    command.CommandText = "LoginEmpleados";
                    command.Parameters.AddWithValue("@Usuario", user);
                    command.Parameters.AddWithValue("@Password", passw);
                    //command.Parameters.AddWithValue("@Rol", rol);
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader rd = command.ExecuteReader();
                    if (rd.HasRows)
                    {
                        return true;
                    }
                    else
                        //La consulta no existe
                        return false;
                }
            }
        }
        #endregion
    }
}
