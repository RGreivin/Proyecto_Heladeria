
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
            this.DGV_Empleado = new System.Windows.Forms.DataGridView();
            this.pContainer = new System.Windows.Forms.GroupBox();
            this.pApellidos = new System.Windows.Forms.Panel();
            this.pNombre = new System.Windows.Forms.Panel();
            this.pCedula = new System.Windows.Forms.Panel();
            this.Btn_Reporte = new System.Windows.Forms.Button();
            this.Cbo_Rol = new System.Windows.Forms.ComboBox();
            this.Lbl_Message0 = new System.Windows.Forms.Label();
            this.Lbl_Message4 = new System.Windows.Forms.Label();
            this.Lbl_Message3 = new System.Windows.Forms.Label();
            this.Lbl_Message2 = new System.Windows.Forms.Label();
            this.Lbl_Message = new System.Windows.Forms.Label();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Editar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Cedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pCorreo = new System.Windows.Forms.Panel();
            this.pTelefono = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Empleado)).BeginInit();
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Empleado
            // 
            this.DGV_Empleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Empleado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.DGV_Empleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Empleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Empleado.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Empleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.DGV_Empleado.GridColor = System.Drawing.SystemColors.Control;
            this.DGV_Empleado.Location = new System.Drawing.Point(0, 0);
            this.DGV_Empleado.Name = "DGV_Empleado";
            this.DGV_Empleado.Size = new System.Drawing.Size(1197, 477);
            this.DGV_Empleado.TabIndex = 0;
            // 
            // pContainer
            // 
            this.pContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pContainer.Controls.Add(this.pTelefono);
            this.pContainer.Controls.Add(this.pCorreo);
            this.pContainer.Controls.Add(this.pApellidos);
            this.pContainer.Controls.Add(this.pNombre);
            this.pContainer.Controls.Add(this.pCedula);
            this.pContainer.Controls.Add(this.Btn_Reporte);
            this.pContainer.Controls.Add(this.Cbo_Rol);
            this.pContainer.Controls.Add(this.Lbl_Message0);
            this.pContainer.Controls.Add(this.Lbl_Message4);
            this.pContainer.Controls.Add(this.Lbl_Message3);
            this.pContainer.Controls.Add(this.Lbl_Message2);
            this.pContainer.Controls.Add(this.Lbl_Message);
            this.pContainer.Controls.Add(this.Btn_Limpiar);
            this.pContainer.Controls.Add(this.Btn_Eliminar);
            this.pContainer.Controls.Add(this.Btn_Editar);
            this.pContainer.Controls.Add(this.Btn_Guardar);
            this.pContainer.Controls.Add(this.Telefono);
            this.pContainer.Controls.Add(this.Correo);
            this.pContainer.Controls.Add(this.Apellidos);
            this.pContainer.Controls.Add(this.Nombre);
            this.pContainer.Controls.Add(this.Cedula);
            this.pContainer.Controls.Add(this.label6);
            this.pContainer.Controls.Add(this.label5);
            this.pContainer.Controls.Add(this.label4);
            this.pContainer.Controls.Add(this.label3);
            this.pContainer.Controls.Add(this.label2);
            this.pContainer.Controls.Add(this.label1);
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pContainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pContainer.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pContainer.ForeColor = System.Drawing.Color.White;
            this.pContainer.Location = new System.Drawing.Point(0, 460);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(1197, 411);
            this.pContainer.TabIndex = 1;
            this.pContainer.TabStop = false;
            this.pContainer.Text = "Información del Empleado";
            // 
            // pApellidos
            // 
            this.pApellidos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pApellidos.Location = new System.Drawing.Point(198, 309);
            this.pApellidos.Name = "pApellidos";
            this.pApellidos.Size = new System.Drawing.Size(209, 5);
            this.pApellidos.TabIndex = 26;
            // 
            // pNombre
            // 
            this.pNombre.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pNombre.Location = new System.Drawing.Point(198, 223);
            this.pNombre.Name = "pNombre";
            this.pNombre.Size = new System.Drawing.Size(209, 5);
            this.pNombre.TabIndex = 25;
            // 
            // pCedula
            // 
            this.pCedula.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pCedula.Location = new System.Drawing.Point(198, 136);
            this.pCedula.Name = "pCedula";
            this.pCedula.Size = new System.Drawing.Size(209, 5);
            this.pCedula.TabIndex = 24;
            // 
            // Btn_Reporte
            // 
            this.Btn_Reporte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Btn_Reporte.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Reporte.FlatAppearance.BorderSize = 0;
            this.Btn_Reporte.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Reporte.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reporte.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Reporte.ForeColor = System.Drawing.Color.White;
            this.Btn_Reporte.Image = global::PL.Properties.Resources.icons8_document_32px;
            this.Btn_Reporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reporte.Location = new System.Drawing.Point(924, 324);
            this.Btn_Reporte.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.Btn_Reporte.Name = "Btn_Reporte";
            this.Btn_Reporte.Size = new System.Drawing.Size(248, 38);
            this.Btn_Reporte.TabIndex = 23;
            this.Btn_Reporte.Text = "Crear Reporte";
            this.Btn_Reporte.UseVisualStyleBackColor = false;
            this.Btn_Reporte.Click += new System.EventHandler(this.Btn_Reporte_Click);
            // 
            // Cbo_Rol
            // 
            this.Cbo_Rol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbo_Rol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cbo_Rol.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbo_Rol.FormattingEnabled = true;
            this.Cbo_Rol.Items.AddRange(new object[] {
            "Empleado",
            "Administrador"});
            this.Cbo_Rol.Location = new System.Drawing.Point(639, 284);
            this.Cbo_Rol.Name = "Cbo_Rol";
            this.Cbo_Rol.Size = new System.Drawing.Size(217, 30);
            this.Cbo_Rol.TabIndex = 22;
            // 
            // Lbl_Message0
            // 
            this.Lbl_Message0.AutoSize = true;
            this.Lbl_Message0.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Message0.Location = new System.Drawing.Point(198, 155);
            this.Lbl_Message0.Name = "Lbl_Message0";
            this.Lbl_Message0.Size = new System.Drawing.Size(54, 22);
            this.Lbl_Message0.TabIndex = 21;
            this.Lbl_Message0.Text = "label9";
            this.Lbl_Message0.Visible = false;
            // 
            // Lbl_Message4
            // 
            this.Lbl_Message4.AutoSize = true;
            this.Lbl_Message4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Message4.Location = new System.Drawing.Point(635, 239);
            this.Lbl_Message4.Name = "Lbl_Message4";
            this.Lbl_Message4.Size = new System.Drawing.Size(52, 21);
            this.Lbl_Message4.TabIndex = 20;
            this.Lbl_Message4.Text = "label8";
            this.Lbl_Message4.Visible = false;
            // 
            // Lbl_Message3
            // 
            this.Lbl_Message3.AutoSize = true;
            this.Lbl_Message3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Message3.Location = new System.Drawing.Point(635, 151);
            this.Lbl_Message3.Name = "Lbl_Message3";
            this.Lbl_Message3.Size = new System.Drawing.Size(54, 22);
            this.Lbl_Message3.TabIndex = 19;
            this.Lbl_Message3.Text = "label7";
            this.Lbl_Message3.Visible = false;
            // 
            // Lbl_Message2
            // 
            this.Lbl_Message2.AutoSize = true;
            this.Lbl_Message2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Message2.Location = new System.Drawing.Point(194, 324);
            this.Lbl_Message2.Name = "Lbl_Message2";
            this.Lbl_Message2.Size = new System.Drawing.Size(54, 22);
            this.Lbl_Message2.TabIndex = 17;
            this.Lbl_Message2.Text = "label7";
            this.Lbl_Message2.Visible = false;
            // 
            // Lbl_Message
            // 
            this.Lbl_Message.AutoSize = true;
            this.Lbl_Message.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Message.Location = new System.Drawing.Point(194, 239);
            this.Lbl_Message.Name = "Lbl_Message";
            this.Lbl_Message.Size = new System.Drawing.Size(54, 22);
            this.Lbl_Message.TabIndex = 16;
            this.Lbl_Message.Text = "label7";
            this.Lbl_Message.Visible = false;
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Btn_Limpiar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Limpiar.FlatAppearance.BorderSize = 0;
            this.Btn_Limpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Limpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold);
            this.Btn_Limpiar.ForeColor = System.Drawing.Color.White;
            this.Btn_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Limpiar.Image")));
            this.Btn_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Limpiar.Location = new System.Drawing.Point(924, 257);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(248, 38);
            this.Btn_Limpiar.TabIndex = 15;
            this.Btn_Limpiar.Text = "Limpiar Campos";
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.Btn_Eliminar.Location = new System.Drawing.Point(924, 190);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(248, 38);
            this.Btn_Eliminar.TabIndex = 14;
            this.Btn_Eliminar.Text = "Eliminar Datos";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Editar
            // 
            this.Btn_Editar.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.Btn_Editar.Location = new System.Drawing.Point(924, 126);
            this.Btn_Editar.Name = "Btn_Editar";
            this.Btn_Editar.Size = new System.Drawing.Size(248, 38);
            this.Btn_Editar.TabIndex = 13;
            this.Btn_Editar.Text = "Modificar Datos";
            this.Btn_Editar.UseVisualStyleBackColor = false;
            this.Btn_Editar.Click += new System.EventHandler(this.Btn_Editar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Btn_Guardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Guardar.FlatAppearance.BorderSize = 0;
            this.Btn_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(174)))));
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Guardar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Guardar.Image")));
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.Location = new System.Drawing.Point(924, 55);
            this.Btn_Guardar.Margin = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(248, 36);
            this.Btn_Guardar.TabIndex = 12;
            this.Btn_Guardar.Text = "Guardar Datos";
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Telefono
            // 
            this.Telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Telefono.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.Location = new System.Drawing.Point(639, 197);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(217, 26);
            this.Telefono.TabIndex = 10;
            this.Telefono.TextChanged += new System.EventHandler(this.Telefono_TextChanged);
            this.Telefono.Enter += new System.EventHandler(this.Txt_Enter);
            this.Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Telefono_KeyPress);
            this.Telefono.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // Correo
            // 
            this.Correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Correo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.Location = new System.Drawing.Point(639, 110);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(217, 26);
            this.Correo.TabIndex = 9;
            this.Correo.TextChanged += new System.EventHandler(this.Coreo_TextChanged);
            this.Correo.Enter += new System.EventHandler(this.Txt_Enter);
            this.Correo.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // Apellidos
            // 
            this.Apellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Apellidos.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellidos.Location = new System.Drawing.Point(198, 284);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(209, 26);
            this.Apellidos.TabIndex = 8;
            this.Apellidos.TextChanged += new System.EventHandler(this.Apellidos_TextChanged);
            this.Apellidos.Enter += new System.EventHandler(this.Txt_Enter);
            this.Apellidos.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // Nombre
            // 
            this.Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nombre.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(198, 197);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(209, 26);
            this.Nombre.TabIndex = 7;
            this.Nombre.TextChanged += new System.EventHandler(this.Nombre_TextChanged);
            this.Nombre.Enter += new System.EventHandler(this.Txt_Enter);
            this.Nombre.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // Cedula
            // 
            this.Cedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Cedula.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cedula.Location = new System.Drawing.Point(198, 110);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(209, 26);
            this.Cedula.TabIndex = 6;
            this.Cedula.Enter += new System.EventHandler(this.Txt_Enter);
            this.Cedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cedula_KeyPress);
            this.Cedula.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(496, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Roles:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(496, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(496, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cédula:";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            // 
            // pCorreo
            // 
            this.pCorreo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pCorreo.Location = new System.Drawing.Point(639, 136);
            this.pCorreo.Name = "pCorreo";
            this.pCorreo.Size = new System.Drawing.Size(217, 5);
            this.pCorreo.TabIndex = 27;
            // 
            // pTelefono
            // 
            this.pTelefono.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pTelefono.Location = new System.Drawing.Point(639, 223);
            this.pTelefono.Name = "pTelefono";
            this.pTelefono.Size = new System.Drawing.Size(217, 5);
            this.pTelefono.TabIndex = 28;
            // 
            // Empleados
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1197, 871);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.DGV_Empleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Empleado)).EndInit();
            this.pContainer.ResumeLayout(false);
            this.pContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DGV_Empleado;
        private System.Windows.Forms.GroupBox pContainer;
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
        private System.Windows.Forms.Label Lbl_Message0;
        
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        
        private System.Windows.Forms.ComboBox Cbo_Rol;
        private System.Windows.Forms.Button Btn_Reporte;
        private System.Windows.Forms.Panel pCedula;
        private System.Windows.Forms.Panel pApellidos;
        private System.Windows.Forms.Panel pNombre;
        private System.Windows.Forms.Panel pCorreo;
        private System.Windows.Forms.Panel pTelefono;
    }
}