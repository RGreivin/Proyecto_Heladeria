using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Registro;

namespace PL.Pantalla
{
    public partial class Registro : Form
    {
        //Instanciamos la clase
        RegistroUser v_ins = new RegistroUser();
        public Registro()
        {
            InitializeComponent();
            this.Tt_Message.SetToolTip(this.Ced, "Solo se permiten números.");
            this.Tt_Message.SetToolTip(this.Nombre, "Solo se permiten letras");
            this.Tt_Message.SetToolTip(this.Apellidos, "Solo se permite letras");
            this.Tt_Message.SetToolTip(this.User, "El usuario tiene que ser de 6 a 12 dígitos y solo puede contener numeros, letras y guion bajo.");
            this.Tt_Message.SetToolTip(this.Passw, "La contraseña tiene que ser de 8 a 16 dígitos y solo puede contener numeros, letras y guion bajo.");
            this.Tt_Message.SetToolTip(this.Correo, "Tiene que ser un correo valido");
            this.Tt_Message.SetToolTip(this.Telefono, "Formato del campo del telefono 40206587");
        }
        #region Metodos del sistema
        private void Btn_Regresar_Click(object sender, EventArgs e)
        {
            Regresar();
        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

            GuardarDtos();

        }
        private void ShowPassw_CheckedChanged(object sender, EventArgs e)
        {
            MostrarPassw();

        }
        private void Ced_TextChanged(object sender, EventArgs e)
        {
            //ValidarTelefono();
        }
        //Texbox Numerico
        private void Ced_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                Lbl_Message1.Text = "Solo se permiten números";
                Lbl_Message1.Visible = true;
                Lbl_Message1.ForeColor = Color.Yellow;
            }
            
        }
        private void Nombre_TextChanged(object sender, EventArgs e)
        {
            ValidarNombres();
        }
        private void Apellidos_TextChanged_1(object sender, EventArgs e)
        {
            ValidarApellido();
        }
        private void User_TextChanged_1(object sender, EventArgs e)
        {
            ValidarUser();
        }
        private void Passw_TextChanged_1(object sender, EventArgs e)
        {
            ValidarPassword();
        }
        private void Correo_TextChanged_1(object sender, EventArgs e)
        {
            ValidarEmail(Correo.Text);
        }
        private void Telefono_TextChanged_1(object sender, EventArgs e)
        {
            ValidarTelefono();
        }
        private void Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                Lbl_Message7.Text = "Solo se permiten números";
                Lbl_Message7.Visible = true;
                Lbl_Message7.ForeColor = Color.Yellow;
            }
        }

        #endregion termina metodos del sistema

        #region Metodos genericos
        private void MostrarPassw()
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
        private void GuardarDtos()
        {
            if (Ced.Text == "" || Nombre.Text == "" || Apellidos.Text == "" || User.Text == "" || Passw.Text == "" || Correo.Text == "" || Telefono.Text == "")
            {
                MessageBox.Show("No dejes campos vacios", "Informative messages ",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                if (Lbl_Message2.ForeColor==Color.Red || Lbl_Message3.ForeColor == Color.Red || Lbl_Message4.ForeColor == Color.Red || Lbl_Message5.ForeColor == Color.Red)
                {
                    MessageBox.Show("Los datos son correctos", "Error messages ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        v_ins.Registro(Ced.Text, Nombre.Text, Apellidos.Text, User.Text, Passw.Text, Correo.Text, Telefono.Text, "");
                       
                    }catch(Exception ex)
                    {
                        
                        MessageBox.Show("No se puede guardar los datos"+ex, "Informative messages ",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }

                    MessageBox.Show("Datos Guardados, Regreses a la pagina anterior.");
                    LimpiarCampos();
                }

            }
               
            

        }
        private void LimpiarCampos()
        {
            Ced.Clear();
            Nombre.Clear();
            Apellidos.Clear();
            User.Clear();
            Passw.Clear();
            Correo.Clear();
            Telefono.Clear();
            Lbl_Message1.Visible = false;
            Lbl_Message2.Visible = false;
            Lbl_Message3.Visible = false;
            Lbl_Message4.Visible = false;
            Lbl_Message5.Visible = false;
            Lbl_Message6.Visible = false;
            Lbl_Message7.Visible = false;


        }
        private void Regresar()
        {
            Pantalla.Login back = new Pantalla.Login();
            back.Show();
            Dispose();
        }


        private void ValidarNombres()
        {
            if (Regex.IsMatch(Nombre.Text, @"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$"))
            {
                Lbl_Message2.Text = "Nombre Correcto";
                Lbl_Message2.Visible = true;
                Lbl_Message2.ForeColor = Color.Green;
            }
            else
            {
                Lbl_Message2.Text = "Nombre Incorrecto";
                Lbl_Message2.Visible = true;
                Lbl_Message2.ForeColor = Color.Red;
            }
        }

        private void ValidarApellido()
        {
            if (Regex.IsMatch(Apellidos.Text, @"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$"))
            {
                Lbl_Message3.Text = "Apellido/s Correctos";
                Lbl_Message3.Visible = true;
                Lbl_Message3.ForeColor = Color.Green;
            }
            else
            {
                Lbl_Message3.Text = "Apellido/s Incorrecto";
                Lbl_Message3.Visible = true;
                Lbl_Message3.ForeColor = Color.Red;
            }
        }
        private void ValidarUser()
        {
            if (Regex.IsMatch(User.Text, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,12}$"))
            {
                Lbl_Message4.Text = "Usuario Correcto";
                Lbl_Message4.Visible = true;
                Lbl_Message4.ForeColor = Color.Green;
            }
            else
            {
                Lbl_Message4.Text = "Usuario Incorrecto";
                Lbl_Message4.Visible = true;
                Lbl_Message4.ForeColor = Color.Red;
            }
        }
        private void ValidarPassword()
        {
            if (Regex.IsMatch(Passw.Text, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,16}$"))
            {
                Lbl_Message5.Text = "Contraseña Correcta";
                Lbl_Message5.Visible = true;
                Lbl_Message5.ForeColor =Color.Green;
            }
            else
            {
                Lbl_Message5.Text = "Contraseña Incorrecta";
                Lbl_Message5.Visible = true;
                Lbl_Message5.ForeColor = Color.Red;
            }
        }
        private void ValidarEmail(string correo)
        {
            string emailFormato;
            emailFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, emailFormato))
            {
                Lbl_Message6.Text = "Es un Correo valido!";
                Lbl_Message6.Visible = true;
                Lbl_Message6.ForeColor = Color.Green;
            }
            else
            {
                if (Regex.Replace(correo, emailFormato, String.Empty).Length == 0)
                {
                    Lbl_Message6.Text = "No es un Correo valido!";
                    Lbl_Message6.Visible = true;
                    Lbl_Message6.ForeColor = Color.Red;
                }
            }
        }
        private void ValidarTelefono()
        {
            if (Regex.IsMatch(Telefono.Text, @"^[5-9]\d{3}-?\d{4}$"))
            {
                Lbl_Message7.Text = "Teléfono Correcto";
                Lbl_Message7.Visible = true;
                Lbl_Message7.ForeColor = Color.Green;
            }

        }
        #endregion termina los metodos genericos

        #region metodos handler del evento enter

        private void Txt_Enter(object sender, EventArgs e)
        {
            //Hace referencia al objeto que dispara el evento
            //En este caso el textbox que esta activo
            TextBox txt = sender as TextBox;
            //Recorremos todos los controles que se encuentran dentro del panel
            foreach (Control ctrl in pContaniner.Controls)
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
            foreach (Control ctrl in pContaniner.Controls)
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
                        //cambiar el color
                        ctrl.BackColor = Color.DarkGray;
                    }
                }
            }
        }


        #endregion Termina handler del evento enter

      
    }
 }
