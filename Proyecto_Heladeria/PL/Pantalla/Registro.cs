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
            if (!(Txt_Ced.Text.Equals("") || Txt_User.Text.Equals("") || txt_Passw.Text.Equals("")))
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
                txt_Passw.UseSystemPasswordChar = false;

            }
            else
            {
                txt_Passw.UseSystemPasswordChar = true;
            }
        }
        #endregion


    }
}
