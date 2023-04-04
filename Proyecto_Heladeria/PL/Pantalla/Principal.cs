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
            validarRol();
            AbrirForm(new InicioPrincipal());
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
            Lbl_hora.Text = DateTime.Now.ToString("hh:mm:ss: tt");
            Lbl_fech.Text = DateTime.Now.ToShortDateString();
        }
        private void Btn_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Btn_Inventario_Click(object sender, EventArgs e)
        {
            SubMenuInventarios();
        }
        private void Btn_Products_Click(object sender, EventArgs e)
        {
            InventarioProducts();
            AbrirForm(new InventProducts());
        }
        private void Btn_Promociones_Click(object sender, EventArgs e)
        {
            InventarioProducts();
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            RegresarLogin();
        }
        private void Btn_Empleados_Click(object sender, EventArgs e)
        {
            AbrirForm(new Empleados());
        }
        private void Btn_Inicio_Click(object sender, EventArgs e)
        {
            AbrirForm(new InicioPrincipal());
        }
        private void Btn_Ventas_Click(object sender, EventArgs e)
        {
            AbrirForm(new Ventas());
        }
        #endregion Finaliza los metodos del sistema

        #region Metodos genericos
        private void ClosedApp()
        {
            Application.Exit();
        }
        private void validarRol()
        {
            if (CacheLogin.Rol == "Empleado")
            {
                Btn_Empleados.Enabled = false;
                Btn_Inventario.Enabled = false;
            }
            else
            {
                Btn_Empleados.Enabled = true;
                Btn_Inventario.Enabled = true;

            }
        }

        private void MenuLateral()
        {
            if (Panel_Options.Width == 55 )
            {
                Panel_Options.Visible = false;
                Panel_Options.Width = 265;
                Panel_Transition.ShowSync(Panel_Options);
                Logo_Transition.ShowSync(Panel_Infor);
                SeparadoLateral.Visible = true;
                //Btn_Ventas.Visible = true;
                //Btn2.Visible = true;
                //Btn3.Visible = false;
                //Btn4.Visible = false;
                this.Tt_Mensaje.SetToolTip(this.Btn_MenuLateral, "Presione para ocultar  menú lateral");

            }
            else
            {
                Logo_Transition.Hide(Panel_Infor);
                Panel_Options.Visible = false;
                Panel_Options.Width = 55;
                Panel_Transition.ShowSync(Panel_Options);
                SeparadoLateral.Visible = false;
                //Btn_Ventas.Visible = false;
                //Btn2.Visible = false;
                //Btn3.Visible = false;
                //Btn4.Visible = false;
                this.Tt_Mensaje.SetToolTip(this.Btn_MenuLateral, "Presione para mostrar el menú lateral");

            }
        }
        private void LoadUser()
        {
            Lbl_FullName.Text = CacheLogin.Nombre + " " + CacheLogin.Apellidos;
            Lbl_Rol.Text = CacheLogin.Rol;
        }
        private void SubMenuInventarios()
        {
            P_SubMenu.Visible = true;
        }
        private void InventarioProducts()
        {
            P_SubMenu.Visible = false;
        }

        private void RegresarLogin()
        {
            Pantalla.Login ins = new Login();
            ins.Show();
            Hide();
        }
        //funcion para abir el form
        private void AbrirForm(object formhija)
        {
            if (this.Panel_main.Controls.Count > 0)

                this.Panel_main.Controls.RemoveAt(0);
                Form fh = formhija as Form;
                fh.TopLevel = false;
                fh.Dock=DockStyle.Fill;
                this.Panel_main.Controls.Add(fh);
                this.Panel_main.Tag =fh;
                fh.Show();
            
        }




        #endregion

      
    }
}
/*
 * Para usar el reportViewer para guardar pdf hay que ir propiedades  en la capa de presentacion ,
 * 1.configuracion propiedades/configuracion  
 * 2.debug  cambiarlo  64 
 */