using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Empleados;
using System.Data;
namespace BLL.Empleados
{
    public class MostrarDtosEmpleados
    {
        private DtosEmpleados dtos = new DtosEmpleados();

        //Creamos un metodo Para mostrar los datos del empleado...
        public DataTable mostrarEmpleado()
        {
            DataTable tblaUsuarios = new DataTable();
            tblaUsuarios = dtos.MostrarDatosEmpelados();
            return tblaUsuarios;

        }
        public void EditEmpleados(string nombre, string apellido, string correo, string telefono, string rol, string ced)
        {
            dtos.ModificarDtos(nombre, apellido, correo, Convert.ToInt32(telefono),rol ,Convert.ToInt32(ced));
        }
    }
}
