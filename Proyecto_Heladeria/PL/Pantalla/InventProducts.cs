using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        private void CantIngreso_TextChanged(object sender, EventArgs e)
        {
            Stock.Text = CantIngreso.Text;

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
                    MessageBox.Show("Datos Guardados, Exitosamente", "Information message ", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        }

        #endregion Termina Los Metodos Genericos 
        private void ReporteProducts()
        {
            Pantalla.Reporte_Productos rport = new Reporte_Productos();
            rport.ShowDialog();
        }

    }

}
