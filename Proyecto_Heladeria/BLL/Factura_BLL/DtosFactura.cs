using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Facturacion;
namespace BLL.Factura_BLL
{
    public class DtosFactura
    {
        private Factura fact= new Factura();

        //instanciamos al objeto de acceso dtos de usuario
        public bool Buscar_Product(string cod)
        {
            return fact.BuscarProduct(Convert.ToInt32(cod));

        }
    }
}
