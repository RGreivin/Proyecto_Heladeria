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

        public void InsertRegistro(int  Codigo, string product, int cantidad_Ingreso, double precioComp ,double precioVent, int stock, DateTime ingreso , DateTime caducidad)
        {
            comand.Connection = conexion.AbrirConexion();
            comand.CommandText = "Insertar_Products";
            comand.Parameters.AddWithValue("@Codigo", Codigo);
            comand.Parameters.AddWithValue("@N_Producto", product);
            comand.Parameters.AddWithValue("@Cantidad_Ingreso",cantidad_Ingreso );
            comand.Parameters.AddWithValue("@Precio_Compra",precioComp );
            comand.Parameters.AddWithValue("@Precio_Venta",precioVent );
            comand.Parameters.AddWithValue("@Stock", stock);
            comand.Parameters.AddWithValue("@Fecha_Ingreso", ingreso );
            comand.Parameters.AddWithValue("@Fecha_Caducidad ",caducidad);
            comand.CommandType = CommandType.StoredProcedure;
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();
        }
        public void EditRegistro(string product, int cantidad_Ingreso, double precioComp, double precioVent, int stock, DateTime ingreso, DateTime caducidad, int Codigo)
        {
            comand.Connection = conexion.AbrirConexion();
            comand.CommandText = "Editar_Products";
            comand.Parameters.AddWithValue("@N_Producto", product);
            comand.Parameters.AddWithValue("@Cantidad_Ingreso", cantidad_Ingreso);
            comand.Parameters.AddWithValue("@Precio_Compra", precioComp);
            comand.Parameters.AddWithValue("@Precio_Venta", precioVent);
            comand.Parameters.AddWithValue("@Stock", stock);
            comand.Parameters.AddWithValue("@Fecha_Ingreso", ingreso);
            comand.Parameters.AddWithValue("@Fecha_Caducidad ",caducidad);
            comand.Parameters.AddWithValue("@Codigo", Codigo);
            comand.CommandType = CommandType.StoredProcedure;
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();
        }
        public void EliminarRegistro(int Codigo)
        {
            comand.Connection = conexion.AbrirConexion();
            comand.CommandText = "Eliminar_Products";
            comand.Parameters.AddWithValue("@Codigo", Codigo);
            comand.CommandType = CommandType.StoredProcedure;
            comand.ExecuteNonQuery();
            comand.Parameters.Clear();

        }
    }
}
