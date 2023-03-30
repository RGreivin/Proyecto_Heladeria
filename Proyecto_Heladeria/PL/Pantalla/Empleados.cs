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
using BLL.Empleados;

namespace PL.Pantalla
{
    public partial class Empleados : Form
    {

        public Empleados()
        {
            InitializeComponent();
            Tbl_Empleados();
        }
        #region Eventos del sistema
        private void Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                Lbl_Message0.Text = "Solo se permiten números";
                Lbl_Message0.Visible=true;
                Lbl_Message0.ForeColor = Color.Yellow;
            }
        }
        private void Nombre_TextChanged(object sender, EventArgs e)
        {
            ValidarNombre();
        }
        private void Apellidos_TextChanged(object sender, EventArgs e)
        {
            ValidarApellido();
        }
        private void Coreo_TextChanged(object sender, EventArgs e)
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
                Lbl_Message4.Text = "Solo se permiten números";
                Lbl_Message4.Visible = true;
                Lbl_Message4.ForeColor = Color.Yellow;
            }
        }
        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarTxt();
        }
        
        #endregion
        #region Metodos Genericos

        private void Tbl_Empleados()
        {
            MostrarDtosEmpleados empleado = new MostrarDtosEmpleados();
            DGV_Empleado.DataSource = empleado.mostrarEmpleado();
        }
        private void LimpiarTxt()
        {
            Cedula.Clear();
            Nombre.Clear();
            Apellidos.Clear();
            Correo.Clear();
            Telefono.Clear();
            
        }
        private void ValidarNombre()
        {
            if (Regex.IsMatch(Nombre.Text, @"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$"))
            {
                Lbl_Message.Text = "Nombre Correcto";
                Lbl_Message.Visible = true;
                Lbl_Message.ForeColor = Color.Green;
            }
            else
            {
                Lbl_Message.Text = "Nombre Incorrecto";
                Lbl_Message.Visible = true;
                Lbl_Message.ForeColor = Color.Red;
            }
        }
        private void ValidarApellido()
        {
            if (Regex.IsMatch(Apellidos.Text, @"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$"))
            {
                Lbl_Message2.Text = "Apellido/s Correctos";
                Lbl_Message2.Visible = true;
                Lbl_Message2.ForeColor = Color.Green;
            }
            else
            {
                Lbl_Message2.Text = "Apellido/s Incorrecto";
                Lbl_Message2.Visible = true;
                Lbl_Message2.ForeColor = Color.Red;
            }
        }
        private void ValidarEmail(string correo)
        {
            string emailFormato;
            emailFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, emailFormato))
            {
                Lbl_Message3.Text = "Es un Correo valido!";
                Lbl_Message3.Visible = true;
                Lbl_Message3.ForeColor = Color.Green;
            }
            else
            {
                if (Regex.Replace(correo, emailFormato, String.Empty).Length == 0)
                {
                    Lbl_Message3.Text = "No es un Correo valido!";
                    Lbl_Message3.Visible = true;
                    Lbl_Message3.ForeColor = Color.Red;
                }
            }
        }
        private void ValidarTelefono()
        {
            if (Regex.IsMatch(Telefono.Text, @"^[5-9]\d{3}-?\d{4}$"))
            {
                Lbl_Message4.Text = "Teléfono Correcto";
                Lbl_Message4.Visible = true;
                Lbl_Message4.ForeColor = Color.Green;
            }
            

        }




        #endregion


    }
}
