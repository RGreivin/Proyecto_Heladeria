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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        #region Config botones login
        private void ShowPassw_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassw.Checked)
            {
                Txt_passw.UseSystemPasswordChar = false;

            }
            else
            {
                Txt_passw.UseSystemPasswordChar = true;
            }
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Pantalla.Registro Form_registro = new Pantalla.Registro();
            Form_registro.Show();
            Dispose();
        }
        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            Pantalla.Principal form_Princ = new Pantalla.Principal();
            form_Princ.Show();
            Dispose();
        }
        private void link_RecuperarAcceso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Pantalla.Recuperar_Dtos form_recup = new Pantalla.Recuperar_Dtos();
            form_recup.Show();
            Dispose();
        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        #endregion

       
    }
}
