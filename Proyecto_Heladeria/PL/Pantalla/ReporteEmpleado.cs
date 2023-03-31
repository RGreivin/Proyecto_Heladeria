using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PL.Pantalla
{
    public partial class ReporteEmpleado : Form
    {
        public ReporteEmpleado()
        {
            InitializeComponent();
        }

        private void ReporteEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alturaPolar_v2.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.alturaPolar_v2.Usuarios);
            this.report_empleados.RefreshReport();
         
        }
  

    }
}
