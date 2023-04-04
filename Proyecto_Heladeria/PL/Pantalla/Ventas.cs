using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Factura_BLL;
using Capa_Soporte.Cache;

namespace PL.Pantalla
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }
        #region Metodos del sistema
        private void Cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                Lbl_Message1.Text = "Solo se permiten números";
                Lbl_Message1.Visible = true;
                Lbl_Message1.ForeColor = Color.Yellow;
            }
        }
        private void Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                Lbl_Message2.Text = "Solo se permiten números";
                Lbl_Message2.Visible = true;
                Lbl_Message2.ForeColor = Color.Yellow;
            }
        }
      
        private void Btn_buscar_Click(object sender, EventArgs e)
         {
            Buscar_Prod();
        }
        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCamp();
        }
        #endregion Termina los metodos del sistema

        #region Metodos Genericos

        private void Buscar_Prod()
        {
            DtosFactura dtos = new DtosFactura();
           

            if (Cod.Text == "")
            {
                MessageBox.Show("No hay registro", "Error message ",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var buscar_Product = dtos.Buscar_Product(Cod.Text);
                if (buscar_Product == true && Cod.Text != "")
                {

                    Producto.Text = CacheLogin.Nombre_Product;
                    Precio.Text = Convert.ToDouble(CacheLogin.Precio).ToString();


                }
                else
                {
                    MessageBox.Show("No se encontro el codigo del producto", "Error message ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

             }

        }
        private void LimpiarCamp()
        {
            Cod.Clear();
            Producto.Clear();
            Cantidad.Clear();
            Precio.Clear();
        }

        #endregion Termina Los Metodos Genericos


    }
}
