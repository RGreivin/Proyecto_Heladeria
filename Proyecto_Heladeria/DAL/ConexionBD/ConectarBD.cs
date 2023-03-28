using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ConexionBD
{
    /*
     * La clase abstract no puede ser instanciada,
     * solo se puede acceder como una clase base
     */
    public  class ConectarBD
    {
        //Conexion ANDREY-Laptop
        private SqlConnection Cn = new SqlConnection("Data Source=LAPTOP-ANDREY;Initial Catalog=AlturaPolar_v2;Integrated Security=True");

        public SqlConnection AbrirConexion()
        {

            if (Cn.State == ConnectionState.Closed)
                Cn.Open();
            return Cn;
        }

        public SqlConnection CerrarConexion()
        {
            if (Cn.State == ConnectionState.Open)
                Cn.Close();
            return Cn;

        }
    }
}
