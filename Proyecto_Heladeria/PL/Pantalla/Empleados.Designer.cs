
namespace PL.Pantalla
{
    partial class Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            this.DGV_Empleado = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Cedula = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Lbl_Message = new System.Windows.Forms.Label();
            this.Lbl_Message2 = new System.Windows.Forms.Label();
            this.Cbo_Rol = new System.Windows.Forms.ComboBox();
            this.Lbl_Message3 = new System.Windows.Forms.Label();
            this.Lbl_Message4 = new System.Windows.Forms.Label();
            this.Lbl_Message0 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Empleado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV_Empleado
            // 
            this.DGV_Empleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Empleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGV_Empleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.DGV_Empleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Empleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Empleado.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_Empleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV_Empleado.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_Empleado.Location = new System.Drawing.Point(0, 0);
            this.DGV_Empleado.Name = "DGV_Empleado";
            this.DGV_Empleado.Size = new System.Drawing.Size(1197, 474);
            this.DGV_Empleado.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.Lbl_Message0);
            this.groupBox1.Controls.Add(this.Lbl_Message4);
            this.groupBox1.Controls.Add(this.Lbl_Message3);
            this.groupBox1.Controls.Add(this.Cbo_Rol);
            this.groupBox1.Controls.Add(this.Lbl_Message2);
            this.groupBox1.Controls.Add(this.Lbl_Message);
            this.groupBox1.Controls.Add(this.Btn_Limpiar);
            this.groupBox1.Controls.Add(this.Btn_Eliminar);
            this.groupBox1.Controls.Add(this.Btn_Editar);
            this.groupBox1.Controls.Add(this.Btn_Guardar);
            this.groupBox1.Controls.Add(this.Telefono);
            this.groupBox1.Controls.Add(this.Correo);
            this.groupBox1.Controls.Add(this.Apellidos);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.Cedula);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1197, 413);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(493, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Roles:";
            // 
            // Cedula
            // 
            this.Cedula.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cedula.Location = new System.Drawing.Point(195, 83);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(209, 29);
            this.Cedula.TabIndex = 6;
            this.Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cedula_KeyPress);
            // 
            // Nombre
            // 
            this.Nombre.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(195, 170);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(209, 29);
            this.Nombre.TabIndex = 7;
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            // 
            // Apellidos
            // 
            this.Apellidos.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellidos.Location = new System.Drawing.Point(195, 257);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(209, 29);
            this.Apellidos.TabIndex = 8;
            this.Apellidos.TextChanged += new System.EventHandler(this.Apellidos_TextChanged);
            // 
            // Correo
            // 
            this.Correo.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.Location = new System.Drawing.Point(636, 83);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(194, 29);
            this.Correo.TabIndex = 9;
            this.Correo.TextChanged += new System.EventHandler(this.Coreo_TextChanged);
            // 
            // Telefono
            // 
            this.Telefono.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.Location = new System.Drawing.Point(636, 170);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(194, 29);
            this.Telefono.TabIndex = 10;
            this.Telefono.TextChanged += new System.EventHandler(this.Telefono_TextChanged);
            this.Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Telefono_KeyPress);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Btn_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Guardar.FlatAppearance.BorderSize = 0;
            this.Btn_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.Location = new System.Drawing.Point(906, 80);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Padding = new System.Windows.Forms.Padding(0, 0, 11, 0);
            this.Btn_Guardar.Size = new System.Drawing.Size(213, 36);
            this.Btn_Guardar.TabIndex = 12;
            this.Btn_Guardar.Text = "Guardar Datos";
            this.Btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Btn_Editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Editar.FlatAppearance.BorderSize = 0;
            this.Btn_Editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Editar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Editar.ForeColor = System.Drawing.Color.White;
            this.Btn_Editar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Editar.Image")));
            this.Btn_Editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Editar.Location = new System.Drawing.Point(906, 167);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(213, 38);
            this.Btn_Editar.TabIndex = 13;
            this.Btn_Editar.Text = "Modificar Datos";
            this.Btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Editar.UseVisualStyleBackColor = false;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Btn_Eliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Eliminar.Image")));
            this.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Eliminar.Location = new System.Drawing.Point(906, 250);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(213, 38);
            this.Btn_Eliminar.TabIndex = 14;
            this.Btn_Eliminar.Text = "Eliminar Datos";
            this.Btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Limpiar.FlatAppearance.BorderSize = 0;
            this.Btn_Limpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.Btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.Image")));
            this.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar.Location = new System.Drawing.Point(906, 335);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(213, 38);
            this.Btn_Limpiar.TabIndex = 15;
            this.Btn_Limpiar.Text = "Limpiar Campos";
            this.Btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Lbl_Message
            // 
            this.Lbl_Message.AutoSize = true;
            this.Lbl_Message.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Message.Location = new System.Drawing.Point(191, 212);
            this.Lbl_Message.Name = "Lbl_Message";
            this.Lbl_Message.Size = new System.Drawing.Size(54, 22);
            this.Lbl_Message.TabIndex = 16;
            this.Lbl_Message.Text = "label7";
            this.Lbl_Message.Visible = false;
            // 
            // Lbl_Message2
            // 
            this.Lbl_Message2.AutoSize = true;
            this.Lbl_Message2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Message2.Location = new System.Drawing.Point(191, 310);
            this.Lbl_Message2.Name = "Lbl_Message2";
            this.Lbl_Message2.Size = new System.Drawing.Size(54, 22);
            this.Lbl_Message2.TabIndex = 17;
            this.Lbl_Message2.Text = "label7";
            this.Lbl_Message2.Visible = false;
            // 
            // Cbo_Rol
            // 
            this.Cbo_Rol.Font = new System.Drawing.Font("Palatino Linotype", 12F);
            this.Cbo_Rol.FormattingEnabled = true;
            this.Cbo_Rol.Location = new System.Drawing.Point(636, 254);
            this.Cbo_Rol.Name = "Cbo_Rol";
            this.Cbo_Rol.Size = new System.Drawing.Size(194, 30);
            this.Cbo_Rol.TabIndex = 18;
            // 
            // Lbl_Message3
            // 
            this.Lbl_Message3.AutoSize = true;
            this.Lbl_Message3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Message3.Location = new System.Drawing.Point(632, 124);
            this.Lbl_Message3.Name = "Lbl_Message3";
            this.Lbl_Message3.Size = new System.Drawing.Size(54, 22);
            this.Lbl_Message3.TabIndex = 19;
            this.Lbl_Message3.Text = "label7";
            this.Lbl_Message3.Visible = false;
            // 
            // Lbl_Message4
            // 
            this.Lbl_Message4.AutoSize = true;
            this.Lbl_Message4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Message4.Location = new System.Drawing.Point(632, 212);
            this.Lbl_Message4.Name = "Lbl_Message4";
            this.Lbl_Message4.Size = new System.Drawing.Size(48, 20);
            this.Lbl_Message4.TabIndex = 20;
            this.Lbl_Message4.Text = "label8";
            this.Lbl_Message4.Visible = false;
            // 
            // Lbl_Message0
            // 
            this.Lbl_Message0.AutoSize = true;
            this.Lbl_Message0.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Message0.Location = new System.Drawing.Point(195, 128);
            this.Lbl_Message0.Name = "Lbl_Message0";
            this.Lbl_Message0.Size = new System.Drawing.Size(54, 22);
            this.Lbl_Message0.TabIndex = 21;
            this.Lbl_Message0.Text = "label9";
            this.Lbl_Message0.Visible = false;
            // 
            // Empleados
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1197, 871);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DGV_Empleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Empleado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Empleado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Cedula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Editar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Label Lbl_Message;
        private System.Windows.Forms.Label Lbl_Message2;
        private System.Windows.Forms.Label Lbl_Message4;
        private System.Windows.Forms.Label Lbl_Message3;
        private System.Windows.Forms.ComboBox Cbo_Rol;
        private System.Windows.Forms.Label Lbl_Message0;
    }
}