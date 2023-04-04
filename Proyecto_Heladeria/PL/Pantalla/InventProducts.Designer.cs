
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventProducts));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pContainer = new System.Windows.Forms.GroupBox();
            this.Lbl_Message6 = new System.Windows.Forms.Label();
            this.Lbl_Message5 = new System.Windows.Forms.Label();
            this.Lbl_Message4 = new System.Windows.Forms.Label();
            this.Lbl_Message3 = new System.Windows.Forms.Label();
            this.Lbl_Message2 = new System.Windows.Forms.Label();
            this.Lbl_Message1 = new System.Windows.Forms.Label();
            this.Date_Caducidad = new System.Windows.Forms.DateTimePicker();
            this.Date_Ingreso = new System.Windows.Forms.DateTimePicker();
            this.Btn_Report = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
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
            this.pCodProduc = new System.Windows.Forms.Panel();
            this.pNombreProd = new System.Windows.Forms.Panel();
            this.pCantIngreso = new System.Windows.Forms.Panel();
            this.pPrecioCompra = new System.Windows.Forms.Panel();
            this.pPrecioVent = new System.Windows.Forms.Panel();
            this.pStock = new System.Windows.Forms.Panel();
            this.DGV_InventProduct = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InventProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pContainer);
            this.panel1.Controls.Add(this.DGV_InventProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1273, 871);
            this.panel1.TabIndex = 0;
            // 
            // pContainer
            // 
            this.pContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pContainer.Controls.Add(this.pStock);
            this.pContainer.Controls.Add(this.pPrecioVent);
            this.pContainer.Controls.Add(this.pPrecioCompra);
            this.pContainer.Controls.Add(this.pCantIngreso);
            this.pContainer.Controls.Add(this.pNombreProd);
            this.pContainer.Controls.Add(this.pCodProduc);
            this.pContainer.Controls.Add(this.Lbl_Message6);
            this.pContainer.Controls.Add(this.Lbl_Message5);
            this.pContainer.Controls.Add(this.Lbl_Message4);
            this.pContainer.Controls.Add(this.Lbl_Message3);
            this.pContainer.Controls.Add(this.Lbl_Message2);
            this.pContainer.Controls.Add(this.Lbl_Message1);
            this.pContainer.Controls.Add(this.Date_Caducidad);
            this.pContainer.Controls.Add(this.Date_Ingreso);
            this.pContainer.Controls.Add(this.Btn_Report);
            this.pContainer.Controls.Add(this.Btn_Limpiar);
            this.pContainer.Controls.Add(this.Btn_Eliminar);
            this.pContainer.Controls.Add(this.Btn_Modificar);
            this.pContainer.Controls.Add(this.Btn_Guardar);
            this.pContainer.Controls.Add(this.label8);
            this.pContainer.Controls.Add(this.label7);
            this.pContainer.Controls.Add(this.Stock);
            this.pContainer.Controls.Add(this.PrecioVent);
            this.pContainer.Controls.Add(this.PrecioCompra);
            this.pContainer.Controls.Add(this.CantIngreso);
            this.pContainer.Controls.Add(this.NombreProd);
            this.pContainer.Controls.Add(this.CodProduc);
            this.pContainer.Controls.Add(this.label6);
            this.pContainer.Controls.Add(this.label5);
            this.pContainer.Controls.Add(this.label4);
            this.pContainer.Controls.Add(this.label3);
            this.pContainer.Controls.Add(this.label2);
            this.pContainer.Controls.Add(this.label1);
            this.pContainer.Font = new System.Drawing.Font("Forte", 20.25F);
            this.pContainer.ForeColor = System.Drawing.Color.White;
            this.pContainer.Location = new System.Drawing.Point(0, 422);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1273, 449);
            this.pContainer.TabIndex = 0;
            this.pContainer.TabStop = false;
            this.pContainer.Text = "Inventario Productos";
            // 
            // Lbl_Message6
            // 
            this.Lbl_Message6.AutoSize = true;
            this.Lbl_Message6.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Message6.Location = new System.Drawing.Point(775, 218);
            this.Lbl_Message6.Name = "Lbl_Message6";
            this.Lbl_Message6.Size = new System.Drawing.Size(62, 19);
            this.Lbl_Message6.TabIndex = 29;
            this.Lbl_Message6.Text = "label13";
            this.Lbl_Message6.Visible = false;
            // 
            // Lbl_Message5
            // 
            this.Lbl_Message5.AutoSize = true;
            this.Lbl_Message5.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Message5.Location = new System.Drawing.Point(775, 141);
            this.Lbl_Message5.Name = "Lbl_Message5";
            this.Lbl_Message5.Size = new System.Drawing.Size(62, 19);
            this.Lbl_Message5.TabIndex = 28;
            this.Lbl_Message5.Text = "label12";
            this.Lbl_Message5.Visible = false;
            // 
            // Lbl_Message4
            // 
            this.Lbl_Message4.AutoSize = true;
            this.Lbl_Message4.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Message4.Location = new System.Drawing.Point(279, 380);
            this.Lbl_Message4.Name = "Lbl_Message4";
            this.Lbl_Message4.Size = new System.Drawing.Size(62, 19);
            this.Lbl_Message4.TabIndex = 27;
            this.Lbl_Message4.Text = "label11";
            this.Lbl_Message4.Visible = false;
            // 
            // Lbl_Message3
            // 
            this.Lbl_Message3.AutoSize = true;
            this.Lbl_Message3.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Message3.Location = new System.Drawing.Point(279, 296);
            this.Lbl_Message3.Name = "Lbl_Message3";
            this.Lbl_Message3.Size = new System.Drawing.Size(62, 19);
            this.Lbl_Message3.TabIndex = 26;
            this.Lbl_Message3.Text = "label10";
            this.Lbl_Message3.Visible = false;
            // 
            // Lbl_Message2
            // 
            this.Lbl_Message2.AutoSize = true;
            this.Lbl_Message2.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Message2.Location = new System.Drawing.Point(279, 218);
            this.Lbl_Message2.Name = "Lbl_Message2";
            this.Lbl_Message2.Size = new System.Drawing.Size(53, 19);
            this.Lbl_Message2.TabIndex = 25;
            this.Lbl_Message2.Text = "label9";
            this.Lbl_Message2.Visible = false;
            // 
            // Lbl_Message1
            // 
            this.Lbl_Message1.AutoSize = true;
            this.Lbl_Message1.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Message1.Location = new System.Drawing.Point(279, 141);
            this.Lbl_Message1.Name = "Lbl_Message1";
            this.Lbl_Message1.Size = new System.Drawing.Size(53, 19);
            this.Lbl_Message1.TabIndex = 24;
            this.Lbl_Message1.Text = "label9";
            this.Lbl_Message1.Visible = false;
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
            this.Stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Stock_KeyPress);
            // 
            // PrecioVent
            // 
            this.PrecioVent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrecioVent.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioVent.Location = new System.Drawing.Point(779, 102);
            this.PrecioVent.Name = "PrecioVent";
            this.PrecioVent.Size = new System.Drawing.Size(186, 26);
            this.PrecioVent.TabIndex = 10;
            this.PrecioVent.Enter += new System.EventHandler(this.Txt_Enter);
            this.PrecioVent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioVent_KeyPress);
            this.PrecioVent.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PrecioCompra.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrecioCompra.Location = new System.Drawing.Point(283, 336);
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.Size = new System.Drawing.Size(186, 26);
            this.PrecioCompra.TabIndex = 9;
            this.PrecioCompra.Enter += new System.EventHandler(this.Txt_Enter);
            this.PrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecioCompra_KeyPress);
            this.PrecioCompra.Leave += new System.EventHandler(this.Txt_Leave);
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
            this.CantIngreso.Enter += new System.EventHandler(this.Txt_Enter);
            this.CantIngreso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantIngreso_KeyPress);
            this.CantIngreso.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // NombreProd
            // 
            this.NombreProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NombreProd.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreProd.Location = new System.Drawing.Point(283, 182);
            this.NombreProd.Name = "NombreProd";
            this.NombreProd.Size = new System.Drawing.Size(186, 26);
            this.NombreProd.TabIndex = 7;
            this.NombreProd.TextChanged += new System.EventHandler(this.NombreProd_TextChanged);
            this.NombreProd.Enter += new System.EventHandler(this.Txt_Enter);
            this.NombreProd.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // CodProduc
            // 
            this.CodProduc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodProduc.Font = new System.Drawing.Font("Forte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodProduc.Location = new System.Drawing.Point(283, 102);
            this.CodProduc.Name = "CodProduc";
            this.CodProduc.Size = new System.Drawing.Size(186, 26);
            this.CodProduc.TabIndex = 6;
            this.CodProduc.Enter += new System.EventHandler(this.Txt_Enter);
            this.CodProduc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CodProduc_KeyPress);
            this.CodProduc.Leave += new System.EventHandler(this.Txt_Leave);
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
            this.label5.Location = new System.Drawing.Point(552, 98);
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
            // pCodProduc
            // 
            this.pCodProduc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pCodProduc.Location = new System.Drawing.Point(283, 127);
            this.pCodProduc.Name = "pCodProduc";
            this.pCodProduc.Size = new System.Drawing.Size(186, 5);
            this.pCodProduc.TabIndex = 30;
            // 
            // pNombreProd
            // 
            this.pNombreProd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pNombreProd.Location = new System.Drawing.Point(283, 208);
            this.pNombreProd.Name = "pNombreProd";
            this.pNombreProd.Size = new System.Drawing.Size(186, 5);
            this.pNombreProd.TabIndex = 31;
            // 
            // pCantIngreso
            // 
            this.pCantIngreso.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pCantIngreso.Location = new System.Drawing.Point(283, 281);
            this.pCantIngreso.Name = "pCantIngreso";
            this.pCantIngreso.Size = new System.Drawing.Size(186, 5);
            this.pCantIngreso.TabIndex = 32;
            // 
            // pPrecioCompra
            // 
            this.pPrecioCompra.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pPrecioCompra.Location = new System.Drawing.Point(283, 362);
            this.pPrecioCompra.Name = "pPrecioCompra";
            this.pPrecioCompra.Size = new System.Drawing.Size(186, 5);
            this.pPrecioCompra.TabIndex = 33;
            // 
            // pPrecioVent
            // 
            this.pPrecioVent.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pPrecioVent.Location = new System.Drawing.Point(779, 127);
            this.pPrecioVent.Name = "pPrecioVent";
            this.pPrecioVent.Size = new System.Drawing.Size(186, 5);
            this.pPrecioVent.TabIndex = 34;
            // 
            // pStock
            // 
            this.pStock.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pStock.Location = new System.Drawing.Point(779, 208);
            this.pStock.Name = "pStock";
            this.pStock.Size = new System.Drawing.Size(186, 5);
            this.pStock.TabIndex = 35;
            // 
            // DGV_InventProduct
            // 
            this.DGV_InventProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_InventProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.DGV_InventProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_InventProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_InventProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_InventProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_InventProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV_InventProduct.Location = new System.Drawing.Point(0, 0);
            this.DGV_InventProduct.Name = "DGV_InventProduct";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_InventProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_InventProduct.Size = new System.Drawing.Size(1273, 443);
            this.DGV_InventProduct.TabIndex = 1;
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
            this.pContainer.ResumeLayout(false);
            this.pContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InventProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox pContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
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
        private System.Windows.Forms.Label Lbl_Message6;
        private System.Windows.Forms.Label Lbl_Message5;
        private System.Windows.Forms.Label Lbl_Message4;
        private System.Windows.Forms.Label Lbl_Message3;
        private System.Windows.Forms.Label Lbl_Message2;
        private System.Windows.Forms.Label Lbl_Message1;
        private System.Windows.Forms.Panel pCodProduc;
        private System.Windows.Forms.Panel pNombreProd;
        private System.Windows.Forms.Panel pCantIngreso;
        private System.Windows.Forms.Panel pStock;
        private System.Windows.Forms.Panel pPrecioVent;
        private System.Windows.Forms.Panel pPrecioCompra;
        private System.Windows.Forms.DataGridView DGV_InventProduct;
    }
}