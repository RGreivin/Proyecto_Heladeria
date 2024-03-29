﻿using System;
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
            MostrarNoFact();
        }
        string  [,] ListaVenta= new string[200,6];
        int fila = 0;
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
        private void Efectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                Lbl_Message3.Text = "Solo se permiten números";
                Lbl_Message3.Visible = true;
                Lbl_Message3.ForeColor = Color.Yellow;
            }
        }
        private void Efectivo_TextChanged(object sender, EventArgs e)
        {
            Metodo_Efectivo();
        }
        private void Btn_buscar_Click(object sender, EventArgs e)
         {
            Buscar_Prod();
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            CargarList();
        }
        private void Btn_QuitarProd_Click(object sender, EventArgs e)
        {
            Quitar_Product();
        }
        private void Btn_Limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCamp();
        }
        private void Btn_Vender_Click(object sender, EventArgs e)
        {
            Vender();
        }

        private void Btn_cambio_Click(object sender, EventArgs e)
        {
            cal_Reinicio();
            if (Rb_Efectivo.Checked)
            {
                Rb_Efectivo.Enabled = false;
                Rb_Tarjeta.Enabled = true;
                efectivo();
            }
            else
            {
                Rb_Efectivo.Enabled = true;
                Rb_Tarjeta.Enabled = false;
                tarjeta();
                Efectivo.Clear();
            }
            MessageBox.Show("Seleccione el nuevo tipo de pago");
            Btn_Add.Enabled = false;
        }

        private void Rb_Efectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Efectivo.Checked)
            {
                Rb_Efectivo.Enabled = true;
                Rb_Tarjeta.Enabled = false;
                efectivo();
                Btn_Add.Enabled = false;


            }
            else
            {
                MessageBox.Show("Pago Tarjeta");
            }
        }

        private void Rb_Tarjeta_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_Tarjeta.Checked)
            {
                Rb_Efectivo.Enabled = false;
                Rb_Tarjeta.Enabled = true;
                tarjeta();
                Btn_Add.Enabled = false;
                Efectivo.Text = "0";
            }
            else
            {
                MessageBox.Show("Pago Efectivo");
            }
        }
        private void Btn_NuevaCompra_Click(object sender, EventArgs e)
        {
            Rb_Efectivo.Checked = false;
            Rb_Tarjeta.Checked = false;
            Rb_Efectivo.Enabled = true;
            Rb_Tarjeta.Enabled = true;
            Btn_Add.Enabled = true;
        }
        #endregion Termina los metodos del sistema

        #region Metodos Genericos

        private void MostrarNoFact()
        {
            DtosFactura noFact = new DtosFactura();
            Lbl_NumbFact.Text = noFact.consultFactura();
        }
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
            Lbl_Message1.Visible = false;
            Lbl_Message2.Visible = false;
            Lbl_Message3.Visible =false;
            Lbl_IVA.Text = "0.00" ;
        }


        private void CargarList()
        {
            try
            {
                if(Cod.Text !="" && Producto.Text != "" && Cantidad.Text !="" && Precio.Text != "")
                {
                    ListaVenta[fila, 0] = Cod.Text;
                    ListaVenta[fila, 1] = Producto.Text;
                    ListaVenta[fila, 2] = Cantidad.Text;
                    ListaVenta[fila, 3] = Precio.Text;
                    ListaVenta[fila, 4] = (float.Parse(Precio.Text)*float.Parse(Cantidad.Text)).ToString();

                    DGV_Lista.Rows.Add(ListaVenta[fila, 0], ListaVenta[fila, 1], ListaVenta[fila, 2], ListaVenta[fila, 3], ListaVenta[fila, 4]);
                    fila++;
                    LimpiarCamp();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el pedido"+ex, "Error message ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CostApagar();
        }
        private void CostApagar()
        {
            float CostoTotal= 0;
            int conteo = 0;

            conteo = DGV_Lista.RowCount;
            for(int i = 0; i<conteo; i++)
            {
                CostoTotal += float.Parse(DGV_Lista.Rows[i].Cells[4].Value.ToString());
            }
            Lbl_CostApgar.Text = CostoTotal.ToString();
        }

        private void Metodo_Efectivo()
        {
            try
            {
                Lbl_Devolucion.Text = (float.Parse(Efectivo.Text) - float.Parse(Lbl_CostApgar.Text)).ToString();
            }
            catch
            {
                Lbl_Devolucion.Text = "0.00" ;
            }
        }
        private void Quitar_Product()
        {
            try
            {
                DialogResult respuesta = MessageBox.Show("Deseas Eliminar El Producto?",
                    "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    DGV_Lista.Rows.Remove(DGV_Lista.CurrentRow);
                    float CostoTotal = 0;
                    int conteo = 0;

                    conteo = DGV_Lista.RowCount;
                    for (int i = 0; i < conteo; i++)
                    {
                        CostoTotal -= float.Parse(DGV_Lista.Rows[i].Cells[4].Value.ToString());
                    }
                    Lbl_CostApgar.Text = CostoTotal.ToString();
                }
                else
                {
                    if (DGV_Lista == null)
                    {
                        Btn_Vender.Enabled = true;
                    }
                }
            }
            catch 
            {

            }
          
          
         }
        private void Vender()
        {
            Cls_Funciones.CreaTicket Ticket1 = new Cls_Funciones.CreaTicket();

            Ticket1.TextoCentro(" Heladeria Altura Polar "); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("Dirc: xxxx");
            Ticket1.TextoIzquierda("Tel:  xxxx ");
            Ticket1.TextoIzquierda("Rnc: xxxx");
            Ticket1.TextoIzquierda("");
            Ticket1.TextoCentro("Factura de Venta"); //imprime una linea de descripcion
            Ticket1.TextoIzquierda("No Fac: " + Lbl_NumbFact.Text) ;
            Ticket1.TextoIzquierda("Fecha:" + DateTime.Now.ToShortDateString());
            Ticket1.TextoIzquierda("Hora:" + DateTime.Now.ToString("hh:mm tt"));
            Ticket1.TextoIzquierda("Le Atendio: "+CacheLogin.Nombre);
            Ticket1.TextoIzquierda("");
            Cls_Funciones.CreaTicket.LineasGuion();

            Cls_Funciones.CreaTicket.EncabezadoVenta();
            Cls_Funciones.CreaTicket.LineasGuion();
            foreach (DataGridViewRow r in DGV_Lista.Rows)
            {
                                                                        // Producto                                       //Cantidad                                              Precio                                                       Subtotal
              Ticket1.AgregaArticulo(r.Cells[1].Value.ToString(), int.Parse(r.Cells[2].Value.ToString()), double.Parse(r.Cells[3].Value.ToString()),double.Parse(r.Cells[4].Value.ToString())); //imprime una linea de descripcion
            }


            Cls_Funciones.CreaTicket.LineasGuion();

            Ticket1.AgregaTotales("Sub-Total", double.Parse(Lbl_Subtotal.Text)); // imprime linea con Subtotal
            Ticket1.AgregaTotales("Descuento", double.Parse("0")); // imprime linea con decuento total
            Ticket1.AgregaTotales("IVA", double.Parse(Lbl_IVA.Text));
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(Lbl_CostApgar.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Efectivo Entregado:", double.Parse(Efectivo.Text));
            Ticket1.AgregaTotales("Efectivo Devuelto:", double.Parse(Lbl_Devolucion.Text));


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
            Ticket1.TextoCentro("**********************************");
            Ticket1.TextoCentro("* Gracias por preferirnos    *");

            Ticket1.TextoCentro("       *************************************");
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);
           // RebajarInvent();
            //Hasta aqui el codigo para imprimir

            //Aqui se limpia la tabla
            fila = 0;
            while (DGV_Lista.RowCount > 0)//limpia el dgv
            { DGV_Lista.Rows.Remove(DGV_Lista.CurrentRow); }
            //LBLIDnuevaFACTURA.Text = ClaseFunciones.ClsFunciones.IDNUEVAFACTURA().ToString();

            Producto.Text = Precio.Text = Cantidad.Text = Efectivo.Text = "";
            Lbl_CostApgar.Text =Lbl_Devolucion.Text = Lbl_Subtotal.Text = "0.00";
            MessageBox.Show("Gracias por preferirnos");
        }

        public void efectivo()
        {
            double result = 0;
            double iva = 0;
            float costoTotal = 0;
            int conteo = 0;
            conteo = DGV_Lista.RowCount;
            for (int i = 0; i < conteo; i++)
            {
                costoTotal += float.Parse(DGV_Lista.Rows[i].Cells[4].Value.ToString());
            }
            Lbl_Subtotal.Text = costoTotal.ToString();
            iva = double.Parse(Lbl_Subtotal.Text) * 0.13;
            Lbl_IVA.Text = Convert.ToString(iva);
            result = double.Parse(Lbl_Subtotal.Text);
            Lbl_CostApgar.Text = Convert.ToString(result);
        }
        public void tarjeta()
        {
            double result = 0;
            double iva = 0;
            float costoTotal = 0;
            int conteo = 0;
            conteo = DGV_Lista.RowCount;
            for (int i = 0; i < conteo; i++)
            {
                costoTotal += float.Parse(DGV_Lista.Rows[i].Cells[4].Value.ToString());
            }
            Lbl_Subtotal.Text = costoTotal.ToString();
            iva = double.Parse(Lbl_Subtotal.Text) * 0.13;
            Lbl_IVA.Text = Convert.ToString(iva);
            result = double.Parse(Lbl_Subtotal.Text);
            Lbl_CostApgar.Text = Convert.ToString(result);
            //Txt_Efect.Text = Convert.ToDouble(Lbl_CostApgar.Text).ToString();
             Efectivo.Text = "0.00";

        }
        public void cal_Reinicio()
        {
            float imp = 0;
            float costoTotal = 0;
            int conteo = 0;
            conteo = DGV_Lista.RowCount;
            for (int i = 0; i < conteo; i++)
            {
                costoTotal += float.Parse(DGV_Lista.Rows[i].Cells[4].Value.ToString());
            }
            Lbl_CostApgar.Text = Convert.ToString(costoTotal);
            Lbl_IVA.Text = Convert.ToString(imp);
        }



        #endregion Termina Los Metodos Genericos

      
    }
}
