using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL.InventarioProducts
{
    public class InvProductos
    {
        private ConexionBD.ConectarBD conexion = new ConexionBD.ConectarBD();
        SqlCommand comand = new SqlCommand();
        //Lee datos de la fila  de la tabla productos
        SqlDataReader red;
        DataTable tbl = new DataTable();
        public DataTable MostrarDatosProductos()
        {
            //Procedimiento Almacenado

            comand.Connection = conexion.AbrirConexion();
            comand.CommandText = "mostrar_Products";
            comand.CommandType = CommandType.StoredProcedure;
            red = comand.ExecuteReader();
            tbl.Load(red);
            conexion.CerrarConexion();
            return tbl;

        }
    }
}
