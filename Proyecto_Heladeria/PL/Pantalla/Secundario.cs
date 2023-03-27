using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Pantalla
{
    public partial class Secundario : Form
    {
        public Secundario(string nombre, string apellido, string rol)
        {
            InitializeComponent();
            Lbl_Msj.Text= nombre + apellido;
        }
    }
}
