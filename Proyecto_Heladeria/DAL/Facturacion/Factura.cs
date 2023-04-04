using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_Soporte.Cache;
namespace DAL.Facturacion
{
    public class Factura
    {
        private ConexionBD.ConectarBD conexion = new ConexionBD.ConectarBD();
        SqlCommand comand = new SqlCommand();
        //Lee datos de la fila  de la tabla productos
    
        public bool BuscarProduct(int cod)
        {
            comand.Connection = conexion.AbrirConexion();
            comand.CommandText = "Buscar_Products";
            comand.Parameters.AddWithValue("@Codigo", cod);
            comand.CommandType = CommandType.StoredProcedure;
            SqlDataReader rd = comand.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    //agregamos los valores a la clase statica 
                    //Estos datos permaneceran en menoria
                    CacheLogin. Nombre_Product= rd.GetString(0);
                    CacheLogin.Precio = rd.GetDouble(1);
                    
                }
                return true;
            }
            else
                //La consulta no existe
                return false;
        }

    }
}
