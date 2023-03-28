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

namespace PL.Pantalla
{
    public partial class Registro : Form
    {
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
        //Texbox Numerico
        private void Ced_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Name_TextChanged(object sender, EventArgs e)
        {
            ValidarNombres();

        }
        private void Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }

        }
        private void Apellidos_TextChanged(object sender, EventArgs e)
        {
            ValidarApellido();
        }
        private void Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))

            {
                e.Handled = true;

                return;

            }
        }
        private void User_TextChanged(object sender, EventArgs e)
        {
            ValidarUser();
        }

        private void Passw_TextChanged(object sender, EventArgs e)
        {
            ValidarPassword();

        }

        private void Correo_TextChanged(object sender, EventArgs e)
        {
            ValidarEmail(Correo.Text);
        }

        private void Telefono_TextChanged(object sender, EventArgs e)
        {
            ValidarTelefono();
        }
        private void Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
            if (Ced.Text=="" || Nombre.Text=="" || Apellidos.Text=="" || User.Text=="" || Passw.Text==""|| Correo.Text=="" || Telefono.Text=="")
            {
                MessageBox.Show("No dejes campos vacios.");
            }
            else
            {
                if (ValidarEmail(Correo.Text) == false)
                {
                    Lbl_Message.Text = "Correo Electronico invalido";
                    Lbl_Message.ForeColor = Color.Red;
                }
                else
                {
                    Lbl_Message.Text = "Correo Electronico valido";
                    Lbl_Message.ForeColor = Color.Green;
                }
                MessageBox.Show("Datos Guardados, Regreses a la pagina anterior.");
            }




            }
        private void Regresar()
        {
            Pantalla.Login back = new Pantalla.Login();
            back.Show();
            Dispose();
        }

        private void ValidarNombres()
        {
            if (Regex.IsMatch(Nombre.Text, @"[^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$"))
            {
                Lbl_Message.Text = "Nombre Correcto";
            }
            else
            {
                Lbl_Message.Text = "Nombre Incorrecto";
            }
        }
        private void ValidarApellido()
        {
            if (Regex.IsMatch(Apellidos.Text, @"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$"))
            {
                Lbl_Message.Text = "Apellido Correctos";
            }
            else
            {
                Lbl_Message.Text = "Apellido Incorrecto";
            }
        }
        private void ValidarUser()
        {
            if (Regex.IsMatch(User.Text, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{6,12}$"))
            {
                Lbl_Message.Text = "Usuario Correcto";
            }
            else
            {
                Lbl_Message.Text = "Usuario Incorrecto";
            }
        }
        private void ValidarPassword()
        {
            if (Regex.IsMatch(Passw.Text, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,16}$"))
            {
                Lbl_Message.Text = "Contraseña Correcta";
            }
            else
            {
                Lbl_Message.Text = "Contraseña Incorrecta";
            }
        }
        private static bool ValidarEmail(string correo)
        {
            string emailFormato;
            emailFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, emailFormato))
            {
                if (Regex.Replace(correo, emailFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
            private void ValidarTelefono()
            {
                if (Regex.IsMatch(Telefono.Text, @"^[5-9]\d{3}-?\d{4}$"))
                {
                    Lbl_Message.Text = "Telefono Correcto";
                }
                else
                {
                    Lbl_Message.Text = "Telefono Incorrecto";
                }
                
            }


        #endregion termina los metodos genericos

       
    }
}
