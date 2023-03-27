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
    public partial class Recuperar_Dtos : Form
    {
        public Recuperar_Dtos()
        {
            InitializeComponent();
        }
        #region Config de botones
        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            Pantalla.Login back = new Login();
            back.Show();
            Dispose();
        }
        #endregion
    }
}
