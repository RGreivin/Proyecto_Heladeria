
namespace PL.Pantalla
{
    partial class InventProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventProducts));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Date_Caducidad = new System.Windows.Forms.DateTimePicker();
            this.Date_Ingreso = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Stock = new System.Windows.Forms.TextBox();
            this.PrecioVent = new System.Windows.Forms.TextBox();
            this.PrecioCompra = new System.Windows.Forms.TextBox();
            this.CantIngreso = new System.Windows.Forms.TextBox();
            this.NombreProd = new System.Windows.Forms.TextBox();
            this.CodProduc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_InventProduct = new System.Windows.Forms.DataGridView();
            this.Btn_Report = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InventProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.DGV_InventProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 871);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Date_Caducidad);
            this.groupBox1.Controls.Add(this.Date_Ingreso);
            this.groupBox1.Controls.Add(this.Btn_Report);
            this.groupBox1.Controls.Add(this.Btn_Limpiar);
            this.groupBox1.Controls.Add(this.Btn_Eliminar);
            this.groupBox1.Controls.Add(this.Btn_Modificar);
            this.groupBox1.Controls.Add(this.Btn_Guardar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Stock);
            this.groupBox1.Controls.Add(this.PrecioVent);
            this.groupBox1.Controls.Add(this.PrecioCompra);
            this.groupBox1.Controls.Add(this.CantIngreso);
            this.groupBox1.Controls.Add(this.NombreProd);
            this.groupBox1.Controls.Add(this.CodProduc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Forte", 20.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 422);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1273, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventario Productos";
            // 
            // Date_Caducidad
            // 
            this.Date_Caducidad.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Caducidad.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_Caducidad.Location = new System.Drawing.Point(779, 336);
            this.Date_Caducidad.Name = "Date_Caducidad";
            this.Date_Caducidad.Size = new System.Drawing.Size(186, 33);
            this.Date_Caducidad.TabIndex = 23;
            this.Date_Caducidad.Value = new System.DateTime(2023, 4, 2, 0, 0, 0, 0);
            // 
            // Date_Ingreso
            // 
            this.Date_Ingreso.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Ingreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date_Ingreso.Location = new System.Drawing.Point(779, 250);
            this.Date_Ingreso.Name = "Date_Ingreso";
            this.Date_Ingreso.Size = new System.Drawing.Size(186, 33);
            this.Date_Ingreso.TabIndex = 22;
            this.Date_Ingreso.Value = new System.DateTime(2023, 4, 2, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F);
            this.label8.Location = new System.Drawing.Point(552, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 34);
            this.label8.TabIndex = 14;
            this.label8.Text = "Fecha Caducidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F);
            this.label7.Location = new System.Drawing.Point(552, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha Actual:";
            // 
            // Stock
            // 
            this.Stock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Stock.Enabled = false;
            this.Stock.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stock.Location = new System.Drawing.Point(779, 182);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(186, 26);
            this.Stock.TabIndex = 11;
            // 
            // PrecioVent
            // 
            this.PrecioVent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrecioVent.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioVent.Location = new System.Drawing.Point(779, 102);
            this.PrecioVent.Name = "PrecioVent";
            this.PrecioVent.Size = new System.Drawing.Size(186, 26);
            this.PrecioVent.TabIndex = 10;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrecioCompra.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioCompra.Location = new System.Drawing.Point(283, 336);
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.Size = new System.Drawing.Size(186, 26);
            this.PrecioCompra.TabIndex = 9;
            // 
            // CantIngreso
            // 
            this.CantIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CantIngreso.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CantIngreso.Location = new System.Drawing.Point(283, 256);
            this.CantIngreso.Name = "CantIngreso";
            this.CantIngreso.Size = new System.Drawing.Size(186, 26);
            this.CantIngreso.TabIndex = 8;
            this.CantIngreso.TextChanged += new System.EventHandler(this.CantIngreso_TextChanged);
            // 
            // NombreProd
            // 
            this.NombreProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreProd.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreProd.Location = new System.Drawing.Point(283, 182);
            this.NombreProd.Name = "NombreProd";
            this.NombreProd.Size = new System.Drawing.Size(186, 26);
            this.NombreProd.TabIndex = 7;
            // 
            // CodProduc
            // 
            this.CodProduc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodProduc.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodProduc.Location = new System.Drawing.Point(283, 102);
            this.CodProduc.Name = "CodProduc";
            this.CodProduc.Size = new System.Drawing.Size(186, 26);
            this.CodProduc.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F);
            this.label6.Location = new System.Drawing.Point(552, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F);
            this.label5.Location = new System.Drawing.Point(540, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio Compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad Ingreso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Producto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Producto:";
            // 
            // DGV_InventProduct
            // 
            this.DGV_InventProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_InventProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_InventProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.DGV_InventProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_InventProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_InventProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_InventProduct.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_InventProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV_InventProduct.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_InventProduct.Location = new System.Drawing.Point(0, 0);
            this.DGV_InventProduct.Name = "DGV_InventProduct";
            this.DGV_InventProduct.Size = new System.Drawing.Size(1273, 453);
            this.DGV_InventProduct.TabIndex = 1;
            // 
            // Btn_Report
            // 
            this.Btn_Report.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Report.FlatAppearance.BorderSize = 0;
            this.Btn_Report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Report.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Report.ForeColor = System.Drawing.Color.White;
            this.Btn_Report.Image = global::PL.Properties.Resources.icons8_document_32px;
            this.Btn_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Report.Location = new System.Drawing.Point(1020, 353);
            this.Btn_Report.Name = "Btn_Report";
            this.Btn_Report.Size = new System.Drawing.Size(241, 46);
            this.Btn_Report.TabIndex = 21;
            this.Btn_Report.Text = "Crear Reporte";
            this.Btn_Report.UseVisualStyleBackColor = true;
            this.Btn_Report.Click += new System.EventHandler(this.Btn_Report_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Limpiar.FlatAppearance.BorderSize = 0;
            this.Btn_Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.Btn_Limpiar.Image = global::PL.Properties.Resources.icons8_erase_32px_1;
            this.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar.Location = new System.Drawing.Point(1020, 280);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(241, 46);
            this.Btn_Limpiar.TabIndex = 20;
            this.Btn_Limpiar.Text = "Limpiar Campos";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Image = global::PL.Properties.Resources.icons8_Delete_List_32px;
            this.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar.Location = new System.Drawing.Point(1020, 211);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(241, 46);
            this.Btn_Eliminar.TabIndex = 19;
            this.Btn_Eliminar.Text = "Eliminar Datos";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Modificar.FlatAppearance.BorderSize = 0;
            this.Btn_Modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Modificar.ForeColor = System.Drawing.Color.White;
            this.Btn_Modificar.Image = global::PL.Properties.Resources.icons8_edit_property_32px_1;
            this.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Modificar.Location = new System.Drawing.Point(1020, 137);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(241, 46);
            this.Btn_Modificar.TabIndex = 18;
            this.Btn_Modificar.Text = "Modificar Datos";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Guardar.FlatAppearance.BorderSize = 0;
            this.Btn_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.Location = new System.Drawing.Point(1020, 65);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(241, 46);
            this.Btn_Guardar.TabIndex = 17;
            this.Btn_Guardar.Text = "Guardar Datos";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // InventProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1273, 871);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventProducts";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InventProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_InventProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Stock;
        private System.Windows.Forms.TextBox PrecioVent;
        private System.Windows.Forms.TextBox PrecioCompra;
        private System.Windows.Forms.TextBox CantIngreso;
        private System.Windows.Forms.TextBox NombreProd;
        private System.Windows.Forms.TextBox CodProduc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Report;
        private System.Windows.Forms.DateTimePicker Date_Ingreso;
        private System.Windows.Forms.DateTimePicker Date_Caducidad;
    }
}