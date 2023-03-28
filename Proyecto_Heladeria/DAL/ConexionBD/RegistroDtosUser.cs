using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ConexionBD
{
    //Esta clase hereda de la clase conexion
    public class RegistroDtosUser : ConectarBD
    {
        private ConexionBD.ConectarBD conexion = new ConexionBD.ConectarBD();
        SqlCommand comand = new SqlCommand();

        public void InsertRegistro(int cedula, string nombre, string apellidos, string user, string passw, string correo, int telefono,string rol)
        {
            comand.Connection = conexion.AbrirConexion();
            comand.CommandText = "Insertar_Usuarios";
            comand.Parameters.AddWithValue("@Cedula", cedula);
            comand.Parameters.AddWithValue("@Nombre", nombre);
            comand.Parameters.AddWithValue("@Apellidos", apellidos);
            comand.Parameters.AddWithValue("@Usuario", user);
            comand.Parameters.AddWithValue("@Password", passw);
            comand.Parameters.AddWithValue("@Correo", correo);
            comand.Parameters.AddWithValue("@Telefono", telefono);
            comand.Parameters.AddWithValue("@Rol", rol);
            comand.CommandType = CommandType.StoredProcedure;
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();
        }
    }
}



