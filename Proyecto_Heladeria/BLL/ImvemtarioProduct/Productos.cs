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
    }
}
