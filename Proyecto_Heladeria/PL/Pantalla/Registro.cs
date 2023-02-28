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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }
        #region Config botones
        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            Pantalla.Login back = new Pantalla.Login();
            back.Show();
            Dispose();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            if (!(Txt_Ced.Text.Equals("") || txt_Name.Text.Equals("")|| Txt_Apellidos.Text.Equals("") || Txt_User.Text.Equals("") || Txt_Paassw.Text.Equals("")))
            {
           
                MessageBox.Show("Datos Guardados, Regreses a la pagina anterior.");
            }
            else
            {
                MessageBox.Show("No dejes campos vacios.");
            }
        }
        private void ShowPassw_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassw.Checked)
            {
                Txt_Paassw.UseSystemPasswordChar = false;

            }
            else
            {
                Txt_Paassw.UseSystemPasswordChar = true;
            }
        }
        #endregion


    }
}
