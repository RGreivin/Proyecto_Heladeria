using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.InventarioProducts;
using System.Data;
namespace BLL.ImvemtarioProduct
{
    public class Productos
    {
        private InvProductos dtos = new InvProductos();

        //Creamos un metodo Para mostrar los datos del empleado...
        public DataTable mostrarInvent()
        {
            DataTable tblaUsuarios = new DataTable();
            tblaUsuarios = dtos.MostrarDatosProductos();
            return tblaUsuarios;

        }
        public void InsertProducts(string Codigo, string product, string cantidad_Ingreso, string precioComp, string precioVent, string stock, string ingreso, string caducidad)
        {
            dtos.InsertRegistro(Convert.ToInt32(Codigo), product, Convert.ToInt32(cantidad_Ingreso), Convert.ToDouble(precioComp), Convert.ToDouble(precioVent),
                                                Convert.ToInt32(stock),Convert.ToDateTime(ingreso), Convert.ToDateTime(caducidad));
        }
        public void EditProducts(string product, string cantidad_Ingreso, string precioComp, string precioVent, string stock, string ingreso, string caducidad, string Codigo)
        {
            dtos.EditRegistro(product, Convert.ToInt32(cantidad_Ingreso), Convert.ToDouble(precioComp), Convert.ToDouble(precioVent), Convert.ToInt32(stock), Convert.ToDateTime(ingreso),
                                            Convert.ToDateTime(caducidad), Convert.ToInt32(Codigo));
        }
        public void EliminarProduct(string Codigo)
        {
            dtos.EliminarRegistro(Convert.ToInt32(Codigo));
        }
    }
}
