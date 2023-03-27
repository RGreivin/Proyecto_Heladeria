
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
            BunifuAnimatorNS.Animation animation6 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.Button_Closed = new Bunifu.Framework.UI.BunifuImageButton();
            this.Panel_main = new System.Windows.Forms.Panel();
            this.Panel_Options = new System.Windows.Forms.Panel();
            this.Btn_4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_MenuLateral = new Bunifu.Framework.UI.BunifuImageButton();
            this.Btn_3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Btn_1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Panel_Infor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_Rol = new System.Windows.Forms.Label();
            this.Lbl_FullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Panel_Transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Logo_Transition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.Tt_Mensaje = new System.Windows.Forms.ToolTip(this.components);
            this.Lbl_hora = new System.Windows.Forms.Label();
            this.hora_Fecha = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Lbl_fech = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Btn_Minimizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Closed)).BeginInit();
            this.Panel_main.SuspendLayout();
            this.Panel_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_MenuLateral)).BeginInit();
            this.Panel_Infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).BeginInit();
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
            this.header.Size = new System.Drawing.Size(1131, 50);
            this.header.TabIndex = 0;
            // 
            // Button_Closed
            // 
            this.Button_Closed.BackColor = System.Drawing.SystemColors.Highlight;
            this.Logo_Transition.SetDecoration(this.Button_Closed, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Button_Closed, BunifuAnimatorNS.DecorationType.None);
            this.Button_Closed.Image = ((System.Drawing.Image)(resources.GetObject("Button_Closed.Image")));
            this.Button_Closed.ImageActive = null;
            this.Button_Closed.Location = new System.Drawing.Point(1079, 3);
            this.Button_Closed.Name = "Button_Closed";
            this.Button_Closed.Size = new System.Drawing.Size(47, 44);
            this.Button_Closed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Button_Closed.TabIndex = 0;
            this.Button_Closed.TabStop = false;
            this.Button_Closed.Zoom = 10;
            this.Button_Closed.Click += new System.EventHandler(this.Button_Closed_Click);
            // 
            // Panel_main
            // 
            this.Panel_main.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Panel_main.Controls.Add(this.Panel_Options);
            this.Panel_Transition.SetDecoration(this.Panel_main, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Transition.SetDecoration(this.Panel_main, BunifuAnimatorNS.DecorationType.None);
            this.Panel_main.Location = new System.Drawing.Point(0, 50);
            this.Panel_main.Name = "Panel_main";
            this.Panel_main.Size = new System.Drawing.Size(1131, 723);
            this.Panel_main.TabIndex = 2;
            // 
            // Panel_Options
            // 
            this.Panel_Options.BackColor = System.Drawing.SystemColors.MenuText;
            this.Panel_Options.Controls.Add(this.Btn_MenuLateral);
            this.Panel_Options.Controls.Add(this.Btn_4);
            this.Panel_Options.Controls.Add(this.Btn_3);
            this.Panel_Options.Controls.Add(this.Btn_2);
            this.Panel_Options.Controls.Add(this.Btn_1);
            this.Panel_Options.Controls.Add(this.Panel_Infor);
            this.Panel_Transition.SetDecoration(this.Panel_Options, BunifuAnimatorNS.DecorationType.None);
            this.Logo_Transition.SetDecoration(this.Panel_Options, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Options.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Options.Location = new System.Drawing.Point(0, 0);
            this.Panel_Options.Name = "Panel_Options";
            this.Panel_Options.Size = new System.Drawing.Size(265, 723);
            this.Panel_Options.TabIndex = 0;
            // 
            // Btn_4
            // 
            this.Btn_4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_4.BorderRadius = 0;
            this.Btn_4.ButtonText = "bunifuFlatButton4";
            this.Btn_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo_Transition.SetDecoration(this.Btn_4, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Btn_4, BunifuAnimatorNS.DecorationType.None);
            this.Btn_4.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_4.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_4.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_4.Iconimage")));
            this.Btn_4.Iconimage_right = null;
            this.Btn_4.Iconimage_right_Selected = null;
            this.Btn_4.Iconimage_Selected = null;
            this.Btn_4.IconMarginLeft = 0;
            this.Btn_4.IconMarginRight = 0;
            this.Btn_4.IconRightVisible = true;
            this.Btn_4.IconRightZoom = 0D;
            this.Btn_4.IconVisible = true;
            this.Btn_4.IconZoom = 90D;
            this.Btn_4.IsTab = false;
            this.Btn_4.Location = new System.Drawing.Point(12, 635);
            this.Btn_4.Name = "Btn_4";
            this.Btn_4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_4.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_4.selected = false;
            this.Btn_4.Size = new System.Drawing.Size(241, 48);
            this.Btn_4.TabIndex = 5;
            this.Btn_4.Text = "bunifuFlatButton4";
            this.Btn_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_4.Textcolor = System.Drawing.Color.White;
            this.Btn_4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_MenuLateral
            // 
            this.Btn_MenuLateral.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_MenuLateral.BackColor = System.Drawing.Color.Black;
            this.Logo_Transition.SetDecoration(this.Btn_MenuLateral, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Btn_MenuLateral, BunifuAnimatorNS.DecorationType.None);
            this.Btn_MenuLateral.Image = ((System.Drawing.Image)(resources.GetObject("Btn_MenuLateral.Image")));
            this.Btn_MenuLateral.ImageActive = null;
            this.Btn_MenuLateral.Location = new System.Drawing.Point(204, 1);
            this.Btn_MenuLateral.Name = "Btn_MenuLateral";
            this.Btn_MenuLateral.Size = new System.Drawing.Size(61, 50);
            this.Btn_MenuLateral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_MenuLateral.TabIndex = 1;
            this.Btn_MenuLateral.TabStop = false;
            this.Btn_MenuLateral.Zoom = 10;
            this.Btn_MenuLateral.Click += new System.EventHandler(this.Btn_MenuLateral_Click);
            // 
            // Btn_3
            // 
            this.Btn_3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_3.BorderRadius = 0;
            this.Btn_3.ButtonText = "bunifuFlatButton3";
            this.Btn_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo_Transition.SetDecoration(this.Btn_3, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Btn_3, BunifuAnimatorNS.DecorationType.None);
            this.Btn_3.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_3.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_3.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_3.Iconimage")));
            this.Btn_3.Iconimage_right = null;
            this.Btn_3.Iconimage_right_Selected = null;
            this.Btn_3.Iconimage_Selected = null;
            this.Btn_3.IconMarginLeft = 0;
            this.Btn_3.IconMarginRight = 0;
            this.Btn_3.IconRightVisible = true;
            this.Btn_3.IconRightZoom = 0D;
            this.Btn_3.IconVisible = true;
            this.Btn_3.IconZoom = 90D;
            this.Btn_3.IsTab = false;
            this.Btn_3.Location = new System.Drawing.Point(12, 567);
            this.Btn_3.Name = "Btn_3";
            this.Btn_3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_3.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_3.selected = false;
            this.Btn_3.Size = new System.Drawing.Size(241, 48);
            this.Btn_3.TabIndex = 4;
            this.Btn_3.Text = "bunifuFlatButton3";
            this.Btn_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_3.Textcolor = System.Drawing.Color.White;
            this.Btn_3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_2
            // 
            this.Btn_2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_2.BorderRadius = 0;
            this.Btn_2.ButtonText = "bunifuFlatButton2";
            this.Btn_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo_Transition.SetDecoration(this.Btn_2, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Btn_2, BunifuAnimatorNS.DecorationType.None);
            this.Btn_2.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_2.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_2.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_2.Iconimage")));
            this.Btn_2.Iconimage_right = null;
            this.Btn_2.Iconimage_right_Selected = null;
            this.Btn_2.Iconimage_Selected = null;
            this.Btn_2.IconMarginLeft = 0;
            this.Btn_2.IconMarginRight = 0;
            this.Btn_2.IconRightVisible = true;
            this.Btn_2.IconRightZoom = 0D;
            this.Btn_2.IconVisible = true;
            this.Btn_2.IconZoom = 90D;
            this.Btn_2.IsTab = false;
            this.Btn_2.Location = new System.Drawing.Point(12, 499);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_2.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_2.selected = false;
            this.Btn_2.Size = new System.Drawing.Size(241, 48);
            this.Btn_2.TabIndex = 3;
            this.Btn_2.Text = "bunifuFlatButton2";
            this.Btn_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_2.Textcolor = System.Drawing.Color.White;
            this.Btn_2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Btn_1
            // 
            this.Btn_1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_1.BorderRadius = 0;
            this.Btn_1.ButtonText = "bunifuFlatButton1";
            this.Btn_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Logo_Transition.SetDecoration(this.Btn_1, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Btn_1, BunifuAnimatorNS.DecorationType.None);
            this.Btn_1.DisabledColor = System.Drawing.Color.Gray;
            this.Btn_1.Iconcolor = System.Drawing.Color.Transparent;
            this.Btn_1.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btn_1.Iconimage")));
            this.Btn_1.Iconimage_right = null;
            this.Btn_1.Iconimage_right_Selected = null;
            this.Btn_1.Iconimage_Selected = null;
            this.Btn_1.IconMarginLeft = 0;
            this.Btn_1.IconMarginRight = 0;
            this.Btn_1.IconRightVisible = true;
            this.Btn_1.IconRightZoom = 0D;
            this.Btn_1.IconVisible = true;
            this.Btn_1.IconZoom = 90D;
            this.Btn_1.IsTab = false;
            this.Btn_1.Location = new System.Drawing.Point(11, 432);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btn_1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btn_1.OnHoverTextColor = System.Drawing.Color.White;
            this.Btn_1.selected = false;
            this.Btn_1.Size = new System.Drawing.Size(241, 48);
            this.Btn_1.TabIndex = 2;
            this.Btn_1.Text = "bunifuFlatButton1";
            this.Btn_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_1.Textcolor = System.Drawing.Color.White;
            this.Btn_1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Panel_Infor.Location = new System.Drawing.Point(12, 65);
            this.Panel_Infor.Name = "Panel_Infor";
            this.Panel_Infor.Size = new System.Drawing.Size(240, 333);
            this.Panel_Infor.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.Logo_Transition.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
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
            this.Lbl_Rol.Location = new System.Drawing.Point(47, 180);
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
            this.Lbl_FullName.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FullName.ForeColor = System.Drawing.Color.White;
            this.Lbl_FullName.Location = new System.Drawing.Point(7, 150);
            this.Lbl_FullName.Name = "Lbl_FullName";
            this.Lbl_FullName.Size = new System.Drawing.Size(60, 29);
            this.Lbl_FullName.TabIndex = 1;
            this.Lbl_FullName.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.Logo_Transition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 116);
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
            this.Panel_Transition.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.Panel_Transition.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 1;
            animation6.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 2F;
            animation6.TransparencyCoeff = 0F;
            this.Panel_Transition.DefaultAnimation = animation6;
            // 
            // Logo_Transition
            // 
            this.Logo_Transition.AnimationType = BunifuAnimatorNS.AnimationType.Scale;
            this.Logo_Transition.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.Logo_Transition.DefaultAnimation = animation5;
            // 
            // Tt_Mensaje
            // 
            this.Tt_Mensaje.IsBalloon = true;
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
            this.Lbl_hora.Location = new System.Drawing.Point(59, 230);
            this.Lbl_hora.Name = "Lbl_hora";
            this.Lbl_hora.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_hora.Size = new System.Drawing.Size(51, 20);
            this.Lbl_hora.TabIndex = 6;
            this.Lbl_hora.Text = "label2";
            this.Lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hora_Fecha
            // 
            this.hora_Fecha.Enabled = true;
            this.hora_Fecha.Tick += new System.EventHandler(this.hora_Fecha_Tick);
            // 
            // pictureBox2
            // 
            this.Logo_Transition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 218);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
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
            // pictureBox3
            // 
            this.Logo_Transition.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 267);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
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
            this.Lbl_fech.Location = new System.Drawing.Point(60, 280);
            this.Lbl_fech.Name = "Lbl_fech";
            this.Lbl_fech.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Lbl_fech.Size = new System.Drawing.Size(51, 20);
            this.Lbl_fech.TabIndex = 9;
            this.Lbl_fech.Text = "label2";
            this.Lbl_fech.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Logo_Transition.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1018, 3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(47, 46);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 9;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Logo_Transition.SetDecoration(this.Btn_Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.Btn_Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Minimizar.Image")));
            this.Btn_Minimizar.ImageActive = null;
            this.Btn_Minimizar.Location = new System.Drawing.Point(952, 2);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(58, 46);
            this.Btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Minimizar.TabIndex = 10;
            this.Btn_Minimizar.TabStop = false;
            this.Btn_Minimizar.Zoom = 10;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.Logo_Transition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 35);
            this.label2.TabIndex = 11;
            this.label2.Text = "Heladería Altura Polar";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 771);
            this.Controls.Add(this.header);
            this.Controls.Add(this.Panel_main);
            this.Logo_Transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Panel_Transition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Button_Closed)).EndInit();
            this.Panel_main.ResumeLayout(false);
            this.Panel_Options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btn_MenuLateral)).EndInit();
            this.Panel_Infor.ResumeLayout(false);
            this.Panel_Infor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).EndInit();
            this.ResumeLayout(false);

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
        private Bunifu.Framework.UI.BunifuFlatButton Btn_4;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_3;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_2;
        private Bunifu.Framework.UI.BunifuFlatButton Btn_1;
        private System.Windows.Forms.Label Lbl_hora;
        private System.Windows.Forms.Timer hora_Fecha;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Label Lbl_fech;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuImageButton Btn_Minimizar;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label2;
    }
}