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
using BLL.ImvemtarioProduct;


namespace PL.Pantalla
{
    public partial class InventProducts : Form
    {
        private bool edit = false;
        public InventProducts()
        {
            InitializeComponent();
            Tbl_Invent();

        }

        #region Evento del sistema
        private void CodProduc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                Lbl_Message1.Text = "Solo se permiten números";
                Lbl_Message1.Visible = true;
                Lbl_Message1.ForeColor = Color.Yellow;
            }
        }
        private void NombreProd_TextChanged(object sender, EventArgs e)
        {
            ValidarNombre();
        }
        private void CantIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                Lbl_Message3.Text = "Solo se permiten números";
                Lbl_Message3.Visible = true;
                Lbl_Message3.ForeColor = Color.Yellow;
            }
        }
        //Pienso en sumarle la cantidad a stock si esta vacio
        private void CantIngreso_TextChanged(object sender, EventArgs e)
        {
            Stock.Text = CantIngreso.Text;

        }
        private void PrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                Lbl_Message4.Text = "Solo se permiten números";
                Lbl_Message4.Visible = true;
                Lbl_Message4.ForeColor = Color.Yellow;
            }
        }

        private void PrecioVent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                Lbl_Message5.Text = "Solo se permiten números";
                Lbl_Message5.Visible = true;
                Lbl_Message5.ForeColor = Color.Yellow;
            }
        }

        private void Stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                Lbl_Message6.Text = "Solo se permiten números";
                Lbl_Message6.Visible = true;
                Lbl_Message6.ForeColor = Color.Yellow;
            }
        }
        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            GuardarProductos();
        }
        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            ModificarProduct();
        }
        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            EliminarProduc();
        }
        private void Btn_Report_Click(object sender, EventArgs e)
        {
            ReporteProducts();
        }
        #endregion Termina Los Eventos del Sistema
        #region Metodos Genericos 
        private void Tbl_Invent()
        {
            Productos inv = new Productos();
            DGV_InventProduct.DataSource = inv.mostrarInvent();
        }
        private void ValidarNombre()
        {
            if (Regex.IsMatch(NombreProd.Text, @"^[a-zA-Z]+(([\'\,\.\- ][a-zA-Z ])?[a-zA-Z]*)*$"))
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
            private void GuardarProductos()
        {
            if (CodProduc.Text == " " || NombreProd.Text == "" || CantIngreso.Text == "" || PrecioCompra.Text == "" || PrecioVent.Text == "")
            {
                MessageBox.Show("No dejes campos vacios", "Warning message ",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (edit == false)
                {


                    try
                    {
                        Productos inv = new Productos();
                        inv.InsertProducts(CodProduc.Text, NombreProd.Text, CantIngreso.Text, PrecioCompra.Text, PrecioVent.Text, Stock.Text, Date_Ingreso.Text, Date_Caducidad.Text);
                        MessageBox.Show("Datos Guardados, Exitosamente", "Information message ",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Tbl_Invent();
                        LimpiarCampos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo Insertar los datos" + ex, "Error message ",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

            }
            if (edit == true)
            {
                try
                {
                    Productos ins = new Productos();
                    ins.EditProducts(NombreProd.Text, CantIngreso.Text, PrecioCompra.Text, PrecioVent.Text, Stock.Text, Date_Ingreso.Text, Date_Caducidad.Text, CodProduc.Text);
                    MessageBox.Show("Se edito el producto, Correctamente", "Information message ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Tbl_Invent();
                    edit = false;
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar los datos" + ex, "Error message ",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LimpiarCampos()
        {
            CodProduc.Clear();
            NombreProd.Clear();
            CantIngreso.Clear();
            PrecioCompra.Clear();
            PrecioVent.Clear();
            Stock.Clear();
            Lbl_Message1.Visible=false;  
            Lbl_Message2.Visible = false;
            Lbl_Message3.Visible = false;
            Lbl_Message4.Visible = false;
            Lbl_Message5.Visible = false;
            Lbl_Message6.Visible = false;

        }
        private void ModificarProduct()
        {
            if (DGV_InventProduct.SelectedRows.Count > 0)
            {
                edit = true;
                NombreProd.Text = DGV_InventProduct.CurrentRow.Cells["N_Producto"].Value.ToString();
                CantIngreso.Text = DGV_InventProduct.CurrentRow.Cells["Cantidad_Ingreso"].Value.ToString();
                PrecioCompra.Text = DGV_InventProduct.CurrentRow.Cells["Precio_Compra"].Value.ToString();
                PrecioVent.Text = DGV_InventProduct.CurrentRow.Cells["Precio_Venta"].Value.ToString();
                Stock.Text = DGV_InventProduct.CurrentRow.Cells["Stock"].Value.ToString();
                Date_Ingreso.Text = DGV_InventProduct.CurrentRow.Cells["Fecha_Ingreso"].Value.ToString();
                Date_Caducidad.Text = DGV_InventProduct.CurrentRow.Cells["Fecha_Caducidad"].Value.ToString();
                CodProduc.Text = DGV_InventProduct.CurrentRow.Cells["Codigo"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea modificar", "Warning message ",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void EliminarProduc()
        {
            if (DGV_InventProduct.SelectedRows.Count > 0)
            {
                CodProduc.Text = DGV_InventProduct.CurrentRow.Cells["Codigo"].Value.ToString();
                CodProduc.Enabled = false;
                Productos delete = new Productos();
                delete.EliminarProduct(CodProduc.Text);
                MessageBox.Show("Se elimino el producto", "Information message ",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                Tbl_Invent();
                CodProduc.Clear();
            }
            else
            {
                MessageBox.Show("Seleccione la fila que desea eliminar", "Warning message ",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CodProduc.Enabled = true;
        }
        private void ReporteProducts()
        {
            Pantalla.Reporte_Productos rport = new Reporte_Productos();
            rport.ShowDialog();
        }
        #endregion Termina Los Metodos Genericos 

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

    }

}
