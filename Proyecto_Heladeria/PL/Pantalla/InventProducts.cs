using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.ImvemtarioProduct;

namespace PL.Pantalla
{
    public partial class InventProducts : Form
    {
        public InventProducts()
        {
            InitializeComponent();
            Tbl_Invent();
        }


        #region Metodos Genericos 
        private void Tbl_Invent()
        {
            Productos inv = new Productos();
            DGV_InventProduct.DataSource = inv.mostrarInvent();
        }
        #endregion Termina Los Metodos Genericos 
    }
}
