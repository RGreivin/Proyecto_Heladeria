﻿
namespace PL.Pantalla
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_User = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_passw = new System.Windows.Forms.TextBox();
            this.ShowPassw = new System.Windows.Forms.CheckBox();
            this.Btn_Ingresar = new System.Windows.Forms.Button();
            this.link_RecuperarAcceso = new System.Windows.Forms.LinkLabel();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 45);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(129, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio sesión";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.Btn_Salir);
            this.panel2.Location = new System.Drawing.Point(-1, 540);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 45);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(144, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario:";
            // 
            // Txt_User
            // 
            this.Txt_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_User.Location = new System.Drawing.Point(96, 263);
            this.Txt_User.Name = "Txt_User";
            this.Txt_User.Size = new System.Drawing.Size(232, 22);
            this.Txt_User.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(131, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña:";
            // 
            // Txt_passw
            // 
            this.Txt_passw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_passw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_passw.Location = new System.Drawing.Point(96, 354);
            this.Txt_passw.Name = "Txt_passw";
            this.Txt_passw.Size = new System.Drawing.Size(232, 22);
            this.Txt_passw.TabIndex = 5;
            this.Txt_passw.UseSystemPasswordChar = true;
            // 
            // ShowPassw
            // 
            this.ShowPassw.AutoSize = true;
            this.ShowPassw.BackColor = System.Drawing.Color.Transparent;
            this.ShowPassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPassw.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ShowPassw.Location = new System.Drawing.Point(134, 393);
            this.ShowPassw.Name = "ShowPassw";
            this.ShowPassw.Size = new System.Drawing.Size(160, 22);
            this.ShowPassw.TabIndex = 6;
            this.ShowPassw.Text = "Mostrar Contraseña";
            this.ShowPassw.UseVisualStyleBackColor = false;
            this.ShowPassw.CheckedChanged += new System.EventHandler(this.ShowPassw_CheckedChanged);
            // 
            // Btn_Ingresar
            // 
            this.Btn_Ingresar.BackColor = System.Drawing.Color.SteelBlue;
            this.Btn_Ingresar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Btn_Ingresar.FlatAppearance.BorderSize = 0;
            this.Btn_Ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.Btn_Ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.Btn_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ingresar.ForeColor = System.Drawing.Color.White;
            this.Btn_Ingresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ingresar.Image")));
            this.Btn_Ingresar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Ingresar.Location = new System.Drawing.Point(240, 446);
            this.Btn_Ingresar.Name = "Btn_Ingresar";
            this.Btn_Ingresar.Padding = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.Btn_Ingresar.Size = new System.Drawing.Size(155, 38);
            this.Btn_Ingresar.TabIndex = 9;
            this.Btn_Ingresar.Text = "Ingresar";
            this.Btn_Ingresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ingresar.UseVisualStyleBackColor = false;
            this.Btn_Ingresar.Click += new System.EventHandler(this.Btn_Ingresar_Click);
            // 
            // link_RecuperarAcceso
            // 
            this.link_RecuperarAcceso.ActiveLinkColor = System.Drawing.Color.IndianRed;
            this.link_RecuperarAcceso.AutoSize = true;
            this.link_RecuperarAcceso.BackColor = System.Drawing.Color.Transparent;
            this.link_RecuperarAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_RecuperarAcceso.ForeColor = System.Drawing.Color.Transparent;
            this.link_RecuperarAcceso.LinkColor = System.Drawing.SystemColors.HotTrack;
            this.link_RecuperarAcceso.Location = new System.Drawing.Point(104, 504);
            this.link_RecuperarAcceso.Name = "link_RecuperarAcceso";
            this.link_RecuperarAcceso.Size = new System.Drawing.Size(216, 18);
            this.link_RecuperarAcceso.TabIndex = 14;
            this.link_RecuperarAcceso.TabStop = true;
            this.link_RecuperarAcceso.Text = "Recuperar usuario / contraseña";
            this.link_RecuperarAcceso.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_RecuperarAcceso_LinkClicked);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_Registrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Registrar.FlatAppearance.BorderSize = 0;
            this.btn_Registrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btn_Registrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Registrar.ForeColor = System.Drawing.Color.White;
            this.btn_Registrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Registrar.Image")));
            this.btn_Registrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Registrar.Location = new System.Drawing.Point(30, 446);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(169, 38);
            this.btn_Registrar.TabIndex = 13;
            this.btn_Registrar.Text = "Registrarse";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(124, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Btn_Salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Salir.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Salir.Image")));
            this.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Salir.Location = new System.Drawing.Point(6, 5);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(156, 35);
            this.Btn_Salir.TabIndex = 0;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(421, 585);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.link_RecuperarAcceso);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.Btn_Ingresar);
            this.Controls.Add(this.ShowPassw);
            this.Controls.Add(this.Txt_passw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_User;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_passw;
        private System.Windows.Forms.CheckBox ShowPassw;
        private System.Windows.Forms.Button Btn_Ingresar;
        private System.Windows.Forms.LinkLabel link_RecuperarAcceso;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_Salir;
    }
}