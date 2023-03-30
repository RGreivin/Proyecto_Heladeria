using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Empleados;

namespace PL.Pantalla
{
    public partial class Empleados : Form
    {

        public Empleados()
        {
            InitializeComponent();
            Tbl_Empleados();
        }
        #region Metodos Genericos

        private void Tbl_Empleados()
        {
            MostrarDtosEmpleados empleado = new MostrarDtosEmpleados();
            DGV_Empleado.DataSource = empleado.mostrarEmpleado();
        }
        #endregion
    }
}
