using System;
using System.Collections.Generic;
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
    public abstract class ConectarBD
    {
        /*
         * Declaramos una variable privada de solo lectura
         * de tipo string para la cadena de conexion
         */
        private readonly string conectionString;

        //creamos el constructor e inicializamos la cadena de conexion
        public ConectarBD()
        {
            conectionString = "Data Source=LAPTOP-ANDREY;Initial Catalog=AlturaPolar_v2;Integrated Security=True";
        }
        /*
         * Creamos un metodo protegido tipo conexion para
         * obtener la cadena de conexion 
         */
        protected SqlConnection GetSqlConnection()
        {
            return new SqlConnection(conectionString);
        }


    }
}

