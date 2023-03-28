using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Login;
using Capa_Soporte.Cache;

namespace PL.Pantalla
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        #region Metodos del sistema
        private void ShowPassw_CheckedChanged(object sender, EventArgs e)
        {
            ShowPasword();
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            Registrar();
        }
        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            ValidarLog();
          
        }
        private void Link_RecuperarAcceso_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarAcceso();
        }
        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        #endregion Termina metodos del sistema

        #region metodos handler del evento enter
        //Este se da cuando el control esta activo
        private void Txt_Enter(object sender, EventArgs e)
        {
            //Hace referencia al objeto que dispara el evento
            //En este caso el textbox que esta activo
            TextBox txt = sender as TextBox;
            //Recorremos todos los controles que se encuentran dentro del panel
            foreach (Control ctrl in PContainer.Controls)
            {
                /*
                 * Si es un Panel y el nombre del Panel es "p"
                 * concatenamos el name del textbox 
                 */
                if(ctrl is Panel && ctrl.Name=="p"+ txt.Name)
                {
                    ctrl.BackColor = Color.Gold;
                }
            }
        }
        private void Txt_Leave(object sender, EventArgs e)
        {
            //Hace referencia al objeto que dispara el evento
            //En este caso el textbox que esta activo
            TextBox txt = sender as TextBox;

            //Recorremos todos los controles que se encuentran dentro del panel
            foreach (Control ctrl in PContainer.Controls)
            {
                /*
                 * Si es un Panel y el nombre del Panel es "p"
                 * concatenamos el name del textbox 
                 */
                if (ctrl is Panel && ctrl.Name == "p" + txt.Name)
                {
                    if (txt.Text == string.Empty)
                    {
                        ctrl.BackColor = Color.Red;
                    }
                    else
                    {
                        ctrl.BackColor = Color.DarkGray;
                    }  
                }
            }
        }
        #endregion Fin metodos handler del evento enter

        #region Metodos genericos
        private void Limpiartext()
        {
            Passw.Clear();
            User.Clear();
        }
        private void ValidarLog()
        {
            if (User.Text == "" || Passw.Text == "")
            {

                MessageBox.Show("No dejes campos vacios", "Informative messages ",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }        
            else
            {
                    Login_BLL log = new Login_BLL();
                    //var implicita
                    var valid_Login = log.Dtos_Login(User.Text, Passw.Text);
                    //Validamos que dtos  exitan 
                    if (valid_Login == true && CacheLogin.Rol !="")
                    {
                        Pantalla.Principal form_Princ = new Pantalla.Principal();
                        form_Princ.Show();
                        Hide();
                    }else{

                    MessageBox.Show("Los datos no son correctos, o no cuentas con un rol asignado", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Limpiartext();
                    }
               
            }
           
        }
        private void Registrar()
        {
            Pantalla.Registro Form_registro = new Pantalla.Registro();
            Form_registro.Show();
            Dispose();
        }
        private void ShowPasword()
        {
            if (ShowPassw.Checked)
            {
                Passw.UseSystemPasswordChar = false;

            }
            else
            {
                Passw.UseSystemPasswordChar = true;
            }
        }
        private void ExitApp()
        {
            Application.Exit();
        }
        private void RecuperarAcceso()
        {
            Pantalla.Recuperar_Dtos form_recup = new Pantalla.Recuperar_Dtos();
            form_recup.Show();
            Dispose();
        }
        #endregion Fin Metodos genericos
    }
}