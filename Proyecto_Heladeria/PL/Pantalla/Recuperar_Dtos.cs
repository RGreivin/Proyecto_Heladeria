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

        private void Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Btn_EnviarEmail_Click(object sender, EventArgs e)
        {
            EnviarCorreo();
        }
        private void Btn_EnviarTelefono_Click(object sender, EventArgs e)
        {
            RecuperarTelefono();
        }
        #endregion

        #region metodos handler del evento enter
        //Este se da cuando el control esta activo
        private void Txt_Enter(object sender, EventArgs e)
        {
            //Hace referencia al objeto que dispara el evento
            //En este caso el textbox que esta activo
            TextBox txt = sender as TextBox;
            //Recorremos todos los controles que se encuentran dentro del panel
            foreach (Control ctrl in pContainer.Controls)
            {
                /*
                 * Si es un Panel y el nombre del Panel es "p"
                 * concatenamos el name del textbox 
                 */
                if (ctrl is Panel && ctrl.Name == "p" + txt.Name)
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
            foreach (Control ctrl in pContainer.Controls)
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

        #region metodos genericos
        private void EnviarCorreo()
        {
            if (Email.Text == "")
            {
                Lbl_Message.Text = ("ingrese un correo electronico, valido!");
                Lbl_Message.ForeColor= Color.Red;
                Lbl_Message.Visible= true;
            }
            else
            {
                var user = new Login_BLL();
                var result = user.RecuperarPassword(Email.Text);
                Lbl_Message.Text = result;
                //Lbl_Message.ForeColor= Color.Red;
                //Lbl_Message.ForeColor = Color.Green;
                Lbl_Message.Visible=true;
                Email.Clear();
            }
            
        }
        private void RecuperarTelefono()
        {
            var user = new Login_BLL();
            var result = user.RecuperarCuenta(Telefono.Text);
            Lbl_Msj.Text = result;
            Lbl_Msj.Visible = true;
        }


        #endregion

     
    }
}
