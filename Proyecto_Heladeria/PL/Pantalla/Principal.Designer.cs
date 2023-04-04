
namespace PL.Pantalla
{
    partial class Principal
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Button_Closed = new Bunifu.Framework.UI.BunifuImageButton();
            this.Panel_main = new System.Windows.Forms.Panel();
            this.Panel_Options = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btn_Inicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_Login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.P_SubMenu = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Btn_Promociones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Btn_Products = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SeparadoLateral = new Bunifu.Framework.UI.BunifuSeparator();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Btn_Inventario = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Empleados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Ventas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_MenuLateral = new Bunifu.Framework.UI.BunifuImageButton();
            this.Panel_Infor = new System.Windows.Forms.Panel();
            this.Lbl_fech = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lbl_Rol = new System.Windows.Forms.Label();
            this.Lbl_FullName = new System.Windows.Forms.Label();
            this.Lbl_hora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Panel_Transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Logo_Transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Tt_Mensaje = new System.Windows.Forms.ToolTip(this.components);
            this.hora_Fecha = new System.Windows.Forms.Timer(this.components);
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Closed)).BeginInit();
            this.Panel_Options.SuspendLayout();
            this.P_SubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_MenuLateral)).BeginInit();
            this.Panel_Infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.Highlight;
            this.header.Controls.Add(this.label2);
            this.header.Controls.Add(this.Btn_Minimizar);
            this.header.Controls.Add(this.bunifuImageButton1);
            this.header.Controls.Add(this.Lbl_fecha);
            this.header.Controls.Add(this.Button_Closed);
            this.Panel_Transition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Transition.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1531, 35);
            this.header.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.Logo_Transition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(6, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Heladería Altura Polar";
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimizar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Logo_Transition.SetDecoration(this.Btn_Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Btn_Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Minimizar.Image")));
            this.Btn_Minimizar.ImageActive = null;
            this.Btn_Minimizar.Location = new System.Drawing.Point(1351, 3);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(58, 33);
            this.Btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Minimizar.TabIndex = 10;
            this.Btn_Minimizar.TabStop = false;
            this.Btn_Minimizar.Zoom = 10;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Logo_Transition.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1418, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(47, 32);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 9;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.BackColor = System.Drawing.Color.Transparent;
            this.Logo_Transition.SetDecoration(this.Lbl_fecha, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Lbl_fecha, BunifuAnimatorNS.DecorationType.None);
            this.Lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.Lbl_fecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_fecha.Location = new System.Drawing.Point(239, 13);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_fecha.Size = new System.Drawing.Size(0, 20);
            this.Lbl_fecha.TabIndex = 8;
            this.Lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Button_Closed
            // 
            this.Button_Closed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Closed.BackColor = System.Drawing.SystemColors.Highlight;
            this.Logo_Transition.SetDecoration(this.Button_Closed, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Button_Closed, BunifuAnimatorNS.DecorationType.None);
            this.Button_Closed.Image = ((System.Drawing.Image)(resources.GetObject("Button_Closed.Image")));
            this.Button_Closed.ImageActive = null;
            this.Button_Closed.Location = new System.Drawing.Point(1477, 3);
            this.Button_Closed.Name = "Button_Closed";
            this.Button_Closed.Size = new System.Drawing.Size(47, 32);
            this.Button_Closed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_Closed.TabIndex = 0;
            this.Button_Closed.TabStop = false;
            this.Button_Closed.Zoom = 10;
            this.Button_Closed.Click += new System.EventHandler(this.Button_Closed_Click);
            // 
            // Panel_main
            // 
            this.Panel_main.AutoSize = true;
            this.Panel_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.Panel_Transition.SetDecoration(this.Panel_main, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Transition.SetDecoration(this.Panel_main, BunifuAnimatorNS.DecorationType.None);
            this.Panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_main.Location = new System.Drawing.Point(258, 35);
            this.Panel_main.Name = "Panel_main";
            this.Panel_main.Size = new System.Drawing.Size(1273, 871);
            this.Panel_main.TabIndex = 2;
            // 
            // Panel_Options
            // 
            this.Panel_Options.BackColor = System.Drawing.Color.Black;
            this.Panel_Options.Controls.Add(this.panel4);
            this.Panel_Options.Controls.Add(this.Btn_Inicio);
            this.Panel_Options.Controls.Add(this.Btn_Login);
            this.Panel_Options.Controls.Add(this.P_SubMenu);
            this.Panel_Options.Controls.Add(this.SeparadoLateral);
            this.Panel_Options.Controls.Add(this.panel3);
            this.Panel_Options.Controls.Add(this.Btn_Inventario);
            this.Panel_Options.Controls.Add(this.panel2);
            this.Panel_Options.Controls.Add(this.Btn_Empleados);
            this.Panel_Options.Controls.Add(this.panel1);
            this.Panel_Options.Controls.Add(this.Btn_Ventas);
            this.Panel_Options.Controls.Add(this.Btn_MenuLateral);
            this.Panel_Options.Controls.Add(this.Panel_Infor);
            this.Panel_Transition.SetDecoration(this.Panel_Options, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Transition.SetDecoration(this.Panel_Options, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Options.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Options.Location = new System.Drawing.Point(0, 35);
            this.Panel_Options.Name = "Panel_Options";
            this.Panel_Options.Size = new System.Drawing.Size(258, 871);
            this.Panel_Options.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Panel_Transition.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Transition.SetDecoration(this.panel4, BunifuAnimatorNS.DecorationType.None);
            this.panel4.Location = new System.Drawing.Point(-3, 373);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(6, 51);
            this.panel4.TabIndex = 10;
            // 
            // Btn_Inicio
            // 
            this.Btn_Inicio.Activecolor = System.Drawing.Color.Transparent;
            this.Btn_Inicio.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Btn_Inicio.BackColor = System.Drawing.Color.Black;
            this.Btn_Inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Inicio.BorderRadius = 0;
            this.Btn_Inicio.ButtonText = "Inicio";
            this.Btn_Inicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo_Transition.SetDecoration(this.Btn_Inicio, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Btn_Inicio, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Inicio.DisabledColor = System.Drawing.Color.Transparent;
            this.Btn_Inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inicio.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Inicio.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Inicio.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Inicio.Iconimage")));
            this.Btn_Inicio.Iconimage_right = null;
            this.Btn_Inicio.Iconimage_right_Selected = null;
            this.Btn_Inicio.Iconimage_Selected = null;
            this.Btn_Inicio.IconMarginLeft = 15;
            this.Btn_Inicio.IconMarginRight = 3;
            this.Btn_Inicio.IconRightVisible = false;
            this.Btn_Inicio.IconRightZoom = 0D;
            this.Btn_Inicio.IconVisible = true;
            this.Btn_Inicio.IconZoom = 85D;
            this.Btn_Inicio.IsTab = false;
            this.Btn_Inicio.Location = new System.Drawing.Point(-3, 373);
            this.Btn_Inicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Inicio.Name = "Btn_Inicio";
            this.Btn_Inicio.Normalcolor = System.Drawing.Color.Black;
            this.Btn_Inicio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btn_Inicio.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.Btn_Inicio.selected = false;
            this.Btn_Inicio.Size = new System.Drawing.Size(261, 53);
            this.Btn_Inicio.TabIndex = 11;
            this.Btn_Inicio.Text = "Inicio";
            this.Btn_Inicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Inicio.Textcolor = System.Drawing.Color.White;
            this.Btn_Inicio.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inicio.Click += new System.EventHandler(this.Btn_Inicio_Click);
            // 
            // Btn_Login
            // 
            this.Btn_Login.Activecolor = System.Drawing.Color.Transparent;
            this.Btn_Login.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Btn_Login.BackColor = System.Drawing.Color.Black;
            this.Btn_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Login.BorderRadius = 0;
            this.Btn_Login.ButtonText = "Cerrar Sesión";
            this.Btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo_Transition.SetDecoration(this.Btn_Login, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Btn_Login, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Login.DisabledColor = System.Drawing.Color.Transparent;
            this.Btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Login.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Login.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Login.Iconimage")));
            this.Btn_Login.Iconimage_right = null;
            this.Btn_Login.Iconimage_right_Selected = null;
            this.Btn_Login.Iconimage_Selected = null;
            this.Btn_Login.IconMarginLeft = 5;
            this.Btn_Login.IconMarginRight = 0;
            this.Btn_Login.IconRightVisible = true;
            this.Btn_Login.IconRightZoom = 0D;
            this.Btn_Login.IconVisible = true;
            this.Btn_Login.IconZoom = 90D;
            this.Btn_Login.IsTab = false;
            this.Btn_Login.Location = new System.Drawing.Point(0, 815);
            this.Btn_Login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Normalcolor = System.Drawing.Color.Black;
            this.Btn_Login.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btn_Login.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.Btn_Login.selected = false;
            this.Btn_Login.Size = new System.Drawing.Size(251, 53);
            this.Btn_Login.TabIndex = 9;
            this.Btn_Login.Text = "Cerrar Sesión";
            this.Btn_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Login.Textcolor = System.Drawing.Color.White;
            this.Btn_Login.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // P_SubMenu
            // 
            this.P_SubMenu.Controls.Add(this.panel6);
            this.P_SubMenu.Controls.Add(this.Btn_Promociones);
            this.P_SubMenu.Controls.Add(this.panel5);
            this.P_SubMenu.Controls.Add(this.Btn_Products);
            this.Panel_Transition.SetDecoration(this.P_SubMenu, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Transition.SetDecoration(this.P_SubMenu, BunifuAnimatorNS.DecorationType.None);
            this.P_SubMenu.Location = new System.Drawing.Point(66, 640);
            this.P_SubMenu.Name = "P_SubMenu";
            this.P_SubMenu.Size = new System.Drawing.Size(192, 157);
            this.P_SubMenu.TabIndex = 7;
            this.P_SubMenu.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Panel_Transition.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Transition.SetDecoration(this.panel6, BunifuAnimatorNS.DecorationType.None);
            this.panel6.Location = new System.Drawing.Point(3, 79);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(6, 51);
            this.panel6.TabIndex = 9;
            // 
            // Btn_Promociones
            // 
            this.Btn_Promociones.Activecolor = System.Drawing.Color.Transparent;
            this.Btn_Promociones.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Btn_Promociones.BackColor = System.Drawing.Color.Black;
            this.Btn_Promociones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Promociones.BorderRadius = 0;
            this.Btn_Promociones.ButtonText = "Promociones";
            this.Btn_Promociones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo_Transition.SetDecoration(this.Btn_Promociones, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Btn_Promociones, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Promociones.DisabledColor = System.Drawing.Color.Transparent;
            this.Btn_Promociones.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Promociones.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Promociones.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Promociones.Iconimage = null;
            this.Btn_Promociones.Iconimage_right = null;
            this.Btn_Promociones.Iconimage_right_Selected = null;
            this.Btn_Promociones.Iconimage_Selected = null;
            this.Btn_Promociones.IconMarginLeft = 30;
            this.Btn_Promociones.IconMarginRight = 0;
            this.Btn_Promociones.IconRightVisible = true;
            this.Btn_Promociones.IconRightZoom = 0D;
            this.Btn_Promociones.IconVisible = true;
            this.Btn_Promociones.IconZoom = 60D;
            this.Btn_Promociones.IsTab = false;
            this.Btn_Promociones.Location = new System.Drawing.Point(7, 78);
            this.Btn_Promociones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Promociones.Name = "Btn_Promociones";
            this.Btn_Promociones.Normalcolor = System.Drawing.Color.Black;
            this.Btn_Promociones.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btn_Promociones.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.Btn_Promociones.selected = false;
            this.Btn_Promociones.Size = new System.Drawing.Size(182, 52);
            this.Btn_Promociones.TabIndex = 10;
            this.Btn_Promociones.Text = "Promociones";
            this.Btn_Promociones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Promociones.Textcolor = System.Drawing.Color.White;
            this.Btn_Promociones.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Promociones.Click += new System.EventHandler(this.Btn_Promociones_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Panel_Transition.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Transition.SetDecoration(this.panel5, BunifuAnimatorNS.DecorationType.None);
            this.panel5.Location = new System.Drawing.Point(4, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(6, 51);
            this.panel5.TabIndex = 7;
            // 
            // Btn_Products
            // 
            this.Btn_Products.Activecolor = System.Drawing.Color.Transparent;
            this.Btn_Products.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Btn_Products.BackColor = System.Drawing.Color.Black;
            this.Btn_Products.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Products.BorderRadius = 0;
            this.Btn_Products.ButtonText = "Productos";
            this.Btn_Products.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo_Transition.SetDecoration(this.Btn_Products, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Btn_Products, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Products.DisabledColor = System.Drawing.Color.Transparent;
            this.Btn_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Products.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Products.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Products.Iconimage = null;
            this.Btn_Products.Iconimage_right = null;
            this.Btn_Products.Iconimage_right_Selected = null;
            this.Btn_Products.Iconimage_Selected = null;
            this.Btn_Products.IconMarginLeft = 30;
            this.Btn_Products.IconMarginRight = 0;
            this.Btn_Products.IconRightVisible = true;
            this.Btn_Products.IconRightZoom = 0D;
            this.Btn_Products.IconVisible = true;
            this.Btn_Products.IconZoom = 60D;
            this.Btn_Products.IsTab = false;
            this.Btn_Products.Location = new System.Drawing.Point(9, 10);
            this.Btn_Products.Margin = new System.Windows.Forms.Padding(5);
            this.Btn_Products.Name = "Btn_Products";
            this.Btn_Products.Normalcolor = System.Drawing.Color.Black;
            this.Btn_Products.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btn_Products.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.Btn_Products.selected = false;
            this.Btn_Products.Size = new System.Drawing.Size(178, 52);
            this.Btn_Products.TabIndex = 8;
            this.Btn_Products.Text = "Productos";
            this.Btn_Products.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn_Products.Textcolor = System.Drawing.Color.White;
            this.Btn_Products.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Products.Click += new System.EventHandler(this.Btn_Products_Click);
            // 
            // SeparadoLateral
            // 
            this.SeparadoLateral.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Transition.SetDecoration(this.SeparadoLateral, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Transition.SetDecoration(this.SeparadoLateral, BunifuAnimatorNS.DecorationType.None);
            this.SeparadoLateral.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.SeparadoLateral.LineThickness = 1;
            this.SeparadoLateral.Location = new System.Drawing.Point(-3, 330);
            this.SeparadoLateral.Name = "SeparadoLateral";
            this.SeparadoLateral.Size = new System.Drawing.Size(269, 12);
            this.SeparadoLateral.TabIndex = 0;
            this.SeparadoLateral.Transparency = 255;
            this.SeparadoLateral.Vertical = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Panel_Transition.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Transition.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(-3, 578);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(6, 51);
            this.panel3.TabIndex = 5;
            // 
            // Btn_Inventario
            // 
            this.Btn_Inventario.Activecolor = System.Drawing.Color.Transparent;
            this.Btn_Inventario.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Btn_Inventario.BackColor = System.Drawing.Color.Black;
            this.Btn_Inventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Inventario.BorderRadius = 0;
            this.Btn_Inventario.ButtonText = "Inventario";
            this.Btn_Inventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo_Transition.SetDecoration(this.Btn_Inventario, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Btn_Inventario, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Inventario.DisabledColor = System.Drawing.Color.Transparent;
            this.Btn_Inventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inventario.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Inventario.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Inventario.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Inventario.Iconimage")));
            this.Btn_Inventario.Iconimage_right = null;
            this.Btn_Inventario.Iconimage_right_Selected = null;
            this.Btn_Inventario.Iconimage_Selected = null;
            this.Btn_Inventario.IconMarginLeft = 12;
            this.Btn_Inventario.IconMarginRight = 5;
            this.Btn_Inventario.IconRightVisible = false;
            this.Btn_Inventario.IconRightZoom = 0D;
            this.Btn_Inventario.IconVisible = true;
            this.Btn_Inventario.IconZoom = 85D;
            this.Btn_Inventario.IsTab = false;
            this.Btn_Inventario.Location = new System.Drawing.Point(-3, 578);
            this.Btn_Inventario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Inventario.Name = "Btn_Inventario";
            this.Btn_Inventario.Normalcolor = System.Drawing.Color.Black;
            this.Btn_Inventario.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btn_Inventario.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.Btn_Inventario.selected = false;
            this.Btn_Inventario.Size = new System.Drawing.Size(261, 53);
            this.Btn_Inventario.TabIndex = 6;
            this.Btn_Inventario.Text = "Inventario";
            this.Btn_Inventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Inventario.Textcolor = System.Drawing.Color.White;
            this.Btn_Inventario.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Inventario.Click += new System.EventHandler(this.Btn_Inventario_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Panel_Transition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Transition.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(-3, 504);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(6, 51);
            this.panel2.TabIndex = 3;
            // 
            // Btn_Empleados
            // 
            this.Btn_Empleados.Activecolor = System.Drawing.Color.Transparent;
            this.Btn_Empleados.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Btn_Empleados.BackColor = System.Drawing.Color.Black;
            this.Btn_Empleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Empleados.BorderRadius = 0;
            this.Btn_Empleados.ButtonText = "Empleados";
            this.Btn_Empleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo_Transition.SetDecoration(this.Btn_Empleados, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Btn_Empleados, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Empleados.DisabledColor = System.Drawing.Color.Transparent;
            this.Btn_Empleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Empleados.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Empleados.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Empleados.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Empleados.Iconimage")));
            this.Btn_Empleados.Iconimage_right = null;
            this.Btn_Empleados.Iconimage_right_Selected = null;
            this.Btn_Empleados.Iconimage_Selected = null;
            this.Btn_Empleados.IconMarginLeft = 15;
            this.Btn_Empleados.IconMarginRight = 3;
            this.Btn_Empleados.IconRightVisible = false;
            this.Btn_Empleados.IconRightZoom = 0D;
            this.Btn_Empleados.IconVisible = true;
            this.Btn_Empleados.IconZoom = 85D;
            this.Btn_Empleados.IsTab = false;
            this.Btn_Empleados.Location = new System.Drawing.Point(-3, 504);
            this.Btn_Empleados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Empleados.Name = "Btn_Empleados";
            this.Btn_Empleados.Normalcolor = System.Drawing.Color.Black;
            this.Btn_Empleados.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btn_Empleados.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.Btn_Empleados.selected = false;
            this.Btn_Empleados.Size = new System.Drawing.Size(258, 53);
            this.Btn_Empleados.TabIndex = 4;
            this.Btn_Empleados.Text = "Empleados";
            this.Btn_Empleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Empleados.Textcolor = System.Drawing.Color.White;
            this.Btn_Empleados.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Empleados.Click += new System.EventHandler(this.Btn_Empleados_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Panel_Transition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Transition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(-3, 436);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(6, 51);
            this.panel1.TabIndex = 0;
            // 
            // Btn_Ventas
            // 
            this.Btn_Ventas.Activecolor = System.Drawing.Color.Transparent;
            this.Btn_Ventas.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Btn_Ventas.BackColor = System.Drawing.Color.Black;
            this.Btn_Ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Ventas.BorderRadius = 0;
            this.Btn_Ventas.ButtonText = "Ventas";
            this.Btn_Ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo_Transition.SetDecoration(this.Btn_Ventas, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Btn_Ventas, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Ventas.DisabledColor = System.Drawing.Color.Transparent;
            this.Btn_Ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ventas.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Btn_Ventas.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_Ventas.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_Ventas.Iconimage")));
            this.Btn_Ventas.Iconimage_right = null;
            this.Btn_Ventas.Iconimage_right_Selected = null;
            this.Btn_Ventas.Iconimage_Selected = null;
            this.Btn_Ventas.IconMarginLeft = 15;
            this.Btn_Ventas.IconMarginRight = 3;
            this.Btn_Ventas.IconRightVisible = false;
            this.Btn_Ventas.IconRightZoom = 0D;
            this.Btn_Ventas.IconVisible = true;
            this.Btn_Ventas.IconZoom = 85D;
            this.Btn_Ventas.IsTab = false;
            this.Btn_Ventas.Location = new System.Drawing.Point(-3, 436);
            this.Btn_Ventas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_Ventas.Name = "Btn_Ventas";
            this.Btn_Ventas.Normalcolor = System.Drawing.Color.Black;
            this.Btn_Ventas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.Btn_Ventas.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.Btn_Ventas.selected = false;
            this.Btn_Ventas.Size = new System.Drawing.Size(258, 53);
            this.Btn_Ventas.TabIndex = 2;
            this.Btn_Ventas.Text = "Ventas";
            this.Btn_Ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ventas.Textcolor = System.Drawing.Color.White;
            this.Btn_Ventas.TextFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ventas.Click += new System.EventHandler(this.Btn_Ventas_Click);
            // 
            // Btn_MenuLateral
            // 
            this.Btn_MenuLateral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_MenuLateral.BackColor = System.Drawing.Color.Black;
            this.Logo_Transition.SetDecoration(this.Btn_MenuLateral, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Btn_MenuLateral, BunifuAnimatorNS.DecorationType.None);
            this.Btn_MenuLateral.Image = ((System.Drawing.Image)(resources.GetObject("Btn_MenuLateral.Image")));
            this.Btn_MenuLateral.ImageActive = null;
            this.Btn_MenuLateral.Location = new System.Drawing.Point(206, 0);
            this.Btn_MenuLateral.Name = "Btn_MenuLateral";
            this.Btn_MenuLateral.Size = new System.Drawing.Size(52, 44);
            this.Btn_MenuLateral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_MenuLateral.TabIndex = 1;
            this.Btn_MenuLateral.TabStop = false;
            this.Btn_MenuLateral.Zoom = 10;
            this.Btn_MenuLateral.Click += new System.EventHandler(this.Btn_MenuLateral_Click);
            // 
            // Panel_Infor
            // 
            this.Panel_Infor.Controls.Add(this.Lbl_fech);
            this.Panel_Infor.Controls.Add(this.pictureBox3);
            this.Panel_Infor.Controls.Add(this.pictureBox1);
            this.Panel_Infor.Controls.Add(this.pictureBox2);
            this.Panel_Infor.Controls.Add(this.Lbl_Rol);
            this.Panel_Infor.Controls.Add(this.Lbl_FullName);
            this.Panel_Infor.Controls.Add(this.Lbl_hora);
            this.Panel_Infor.Controls.Add(this.label1);
            this.Panel_Transition.SetDecoration(this.Panel_Infor, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Transition.SetDecoration(this.Panel_Infor, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Infor.Location = new System.Drawing.Point(12, 15);
            this.Panel_Infor.Name = "Panel_Infor";
            this.Panel_Infor.Size = new System.Drawing.Size(243, 318);
            this.Panel_Infor.TabIndex = 0;
            // 
            // Lbl_fech
            // 
            this.Lbl_fech.AutoSize = true;
            this.Lbl_fech.BackColor = System.Drawing.Color.Transparent;
            this.Logo_Transition.SetDecoration(this.Lbl_fech, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Lbl_fech, BunifuAnimatorNS.DecorationType.None);
            this.Lbl_fech.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fech.ForeColor = System.Drawing.Color.White;
            this.Lbl_fech.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_fech.Location = new System.Drawing.Point(68, 280);
            this.Lbl_fech.Name = "Lbl_fech";
            this.Lbl_fech.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_fech.Size = new System.Drawing.Size(51, 20);
            this.Lbl_fech.TabIndex = 9;
            this.Lbl_fech.Text = "label2";
            this.Lbl_fech.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox3
            // 
            this.Logo_Transition.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(25, 266);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.Logo_Transition.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(54, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.Logo_Transition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 217);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Lbl_Rol
            // 
            this.Lbl_Rol.AutoSize = true;
            this.Lbl_Rol.BackColor = System.Drawing.Color.Transparent;
            this.Logo_Transition.SetDecoration(this.Lbl_Rol, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Lbl_Rol, BunifuAnimatorNS.DecorationType.None);
            this.Lbl_Rol.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Rol.ForeColor = System.Drawing.Color.White;
            this.Lbl_Rol.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Rol.Location = new System.Drawing.Point(49, 178);
            this.Lbl_Rol.Name = "Lbl_Rol";
            this.Lbl_Rol.Size = new System.Drawing.Size(60, 29);
            this.Lbl_Rol.TabIndex = 2;
            this.Lbl_Rol.Text = "label3";
            this.Lbl_Rol.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_FullName
            // 
            this.Lbl_FullName.AutoSize = true;
            this.Lbl_FullName.BackColor = System.Drawing.Color.Transparent;
            this.Logo_Transition.SetDecoration(this.Lbl_FullName, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Lbl_FullName, BunifuAnimatorNS.DecorationType.None);
            this.Lbl_FullName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lbl_FullName.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FullName.ForeColor = System.Drawing.Color.White;
            this.Lbl_FullName.Location = new System.Drawing.Point(10, 150);
            this.Lbl_FullName.Name = "Lbl_FullName";
            this.Lbl_FullName.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.Lbl_FullName.Size = new System.Drawing.Size(59, 27);
            this.Lbl_FullName.TabIndex = 1;
            this.Lbl_FullName.Text = "label2";
            this.Lbl_FullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_hora
            // 
            this.Lbl_hora.AutoSize = true;
            this.Lbl_hora.BackColor = System.Drawing.Color.Transparent;
            this.Logo_Transition.SetDecoration(this.Lbl_hora, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Lbl_hora, BunifuAnimatorNS.DecorationType.None);
            this.Lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_hora.ForeColor = System.Drawing.Color.White;
            this.Lbl_hora.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_hora.Location = new System.Drawing.Point(66, 229);
            this.Lbl_hora.Name = "Lbl_hora";
            this.Lbl_hora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_hora.Size = new System.Drawing.Size(51, 20);
            this.Lbl_hora.TabIndex = 6;
            this.Lbl_hora.Text = "label2";
            this.Lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.Logo_Transition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "BIENVENID@";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Panel_Transition
            // 
            this.Panel_Transition.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.Panel_Transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.Panel_Transition.DefaultAnimation = animation1;
            this.Panel_Transition.Interval = 20;
            this.Panel_Transition.TimeStep = 0.05F;
            // 
            // Logo_Transition
            // 
            this.Logo_Transition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.Logo_Transition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.Logo_Transition.DefaultAnimation = animation2;
            // 
            // Tt_Mensaje
            // 
            this.Tt_Mensaje.IsBalloon = true;
            // 
            // hora_Fecha
            // 
            this.hora_Fecha.Enabled = true;
            this.hora_Fecha.Tick += new System.EventHandler(this.Hora_Fecha_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1531, 906);
            this.Controls.Add(this.Panel_main);
            this.Controls.Add(this.Panel_Options);
            this.Controls.Add(this.header);
            this.Logo_Transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Closed)).EndInit();
            this.Panel_Options.ResumeLayout(false);
            this.P_SubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_MenuLateral)).EndInit();
            this.Panel_Infor.ResumeLayout(false);
            this.Panel_Infor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Panel_main;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton Button_Closed;
        private BunifuAnimatorNS.BunifuTransition Logo_Transition;
        private BunifuAnimatorNS.BunifuTransition Panel_Transition;
        private System.Windows.Forms.Panel Panel_Options;
        private Bunifu.Framework.UI.BunifuImageButton Btn_MenuLateral;
        private System.Windows.Forms.Panel Panel_Infor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl_Rol;
        private System.Windows.Forms.Label Lbl_FullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip Tt_Mensaje;
        private System.Windows.Forms.Label Lbl_hora;
        private System.Windows.Forms.Timer hora_Fecha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl_fech;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuImageButton Btn_Minimizar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Ventas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Empleados;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Inventario;
        private Bunifu.Framework.UI.BunifuSeparator SeparadoLateral;
        private System.Windows.Forms.Panel P_SubMenu;
        private System.Windows.Forms.Panel panel6;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Promociones;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Products;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Login;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_Inicio;
    }
}