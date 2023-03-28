using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Soporte.Cache;

namespace PL.Pantalla
{
    public partial class Principal : Form
    {
        #region Metodos del sistema
        public Principal()
        {
            InitializeComponent();
            this.Tt_Mensaje.SetToolTip(this.Btn_MenuLateral, "Presione para ocultar  menú lateral");

        }
        private void Principal_Load(object sender, EventArgs e)
        {
            LoadUser();
         
           
        }

        private void Button_Closed_Click(object sender, EventArgs e)
        {
            ClosedApp();
        }

        private void Btn_MenuLateral_Click(object sender, EventArgs e)
        {
            MenuLateral();
        }
        private void Hora_Fecha_Tick(object sender, EventArgs e)
        {
            Lbl_hora.Text=  DateTime.Now.ToString("hh:mm:ss: tt");
            Lbl_fech.Text = DateTime.Now.ToShortDateString();
        }
        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
#endregion
        #region Metodos genericos
        private void ClosedApp()
        {
            Application.Exit();
        }
        private void MenuLateral()
        {
            if (Panel_Options.Width == 60)
            {
                Panel_Options.Visible = false;
                Panel_Options.Width = 265;
                Panel_Transition.ShowSync(Panel_Options);
                Logo_Transition.ShowSync(Panel_Infor);
                Btn_1.Visible = true;
                Btn_2.Visible = true;
                Btn_3.Visible = false;
                Btn_4.Visible = false;
                this.Tt_Mensaje.SetToolTip(this.Btn_MenuLateral, "Presione para ocultar  menú lateral");

            }
            else
            {
                Logo_Transition.Hide(Panel_Infor);
                Panel_Options.Visible = false;
                Panel_Options.Width = 60;
                Panel_Transition.ShowSync(Panel_Options);
                Btn_1.Visible = false;
                Btn_2.Visible = false;
                Btn_3.Visible = false;
                Btn_4.Visible = false;
                this.Tt_Mensaje.SetToolTip(this.Btn_MenuLateral, "Presione para mostrar el menú lateral");

            }   
        }
        private void LoadUser()
        {
            Lbl_FullName.Text = CacheLogin.Nombre +" "+ CacheLogin.Apellidos;
            Lbl_Rol.Text = CacheLogin.Rol;
        }




        #endregion

       
    }
}
