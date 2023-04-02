
namespace PL.Pantalla
{
    partial class Recuperar_Dtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recuperar_Dtos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Regresar = new System.Windows.Forms.Button();
            this.pContainer = new System.Windows.Forms.Panel();
            this.Lbl_Msj = new System.Windows.Forms.Label();
            this.Lbl_Message = new System.Windows.Forms.Label();
            this.pTelefono = new System.Windows.Forms.Panel();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.pEmail = new System.Windows.Forms.Panel();
            this.Btn_EnviarTelefono = new System.Windows.Forms.Button();
            this.Btn_EnviarEmail = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 45);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(94, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recuperación de Login";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.Btn_Regresar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(481, 48);
            this.panel2.TabIndex = 3;
            // 
            // Btn_Regresar
            // 
            this.Btn_Regresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_Regresar.BackColor = System.Drawing.SystemColors.Highlight;
            this.Btn_Regresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Btn_Regresar.FlatAppearance.BorderSize = 0;
            this.Btn_Regresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Btn_Regresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.Btn_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Regresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Regresar.ForeColor = System.Drawing.Color.White;
            this.Btn_Regresar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Regresar.Image")));
            this.Btn_Regresar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Regresar.Location = new System.Drawing.Point(13, 5);
            this.Btn_Regresar.Name = "Btn_Regresar";
            this.Btn_Regresar.Size = new System.Drawing.Size(136, 34);
            this.Btn_Regresar.TabIndex = 10;
            this.Btn_Regresar.Text = "Regresar";
            this.Btn_Regresar.UseVisualStyleBackColor = false;
            this.Btn_Regresar.Click += new System.EventHandler(this.Btn_Regresar_Click);
            // 
            // pContainer
            // 
            this.pContainer.Controls.Add(this.Lbl_Msj);
            this.pContainer.Controls.Add(this.Lbl_Message);
            this.pContainer.Controls.Add(this.pTelefono);
            this.pContainer.Controls.Add(this.Telefono);
            this.pContainer.Controls.Add(this.pEmail);
            this.pContainer.Controls.Add(this.Btn_EnviarTelefono);
            this.pContainer.Controls.Add(this.Btn_EnviarEmail);
            this.pContainer.Controls.Add(this.Email);
            this.pContainer.Controls.Add(this.label3);
            this.pContainer.Controls.Add(this.label2);
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(0, 45);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(481, 266);
            this.pContainer.TabIndex = 4;
            // 
            // Lbl_Msj
            // 
            this.Lbl_Msj.AutoSize = true;
            this.Lbl_Msj.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Msj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Msj.ForeColor = System.Drawing.Color.White;
            this.Lbl_Msj.Location = new System.Drawing.Point(96, 213);
            this.Lbl_Msj.Name = "Lbl_Msj";
            this.Lbl_Msj.Size = new System.Drawing.Size(51, 20);
            this.Lbl_Msj.TabIndex = 22;
            this.Lbl_Msj.Text = "label4";
            this.Lbl_Msj.Visible = false;
            // 
            // Lbl_Message
            // 
            this.Lbl_Message.AutoSize = true;
            this.Lbl_Message.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Message.ForeColor = System.Drawing.Color.White;
            this.Lbl_Message.Location = new System.Drawing.Point(83, 93);
            this.Lbl_Message.Name = "Lbl_Message";
            this.Lbl_Message.Size = new System.Drawing.Size(51, 20);
            this.Lbl_Message.TabIndex = 21;
            this.Lbl_Message.Text = "label4";
            this.Lbl_Message.Visible = false;
            // 
            // pTelefono
            // 
            this.pTelefono.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pTelefono.Location = new System.Drawing.Point(175, 180);
            this.pTelefono.Name = "pTelefono";
            this.pTelefono.Size = new System.Drawing.Size(175, 5);
            this.pTelefono.TabIndex = 20;
            // 
            // Telefono
            // 
            this.Telefono.BackColor = System.Drawing.SystemColors.Window;
            this.Telefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Telefono.Location = new System.Drawing.Point(175, 154);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(175, 26);
            this.Telefono.TabIndex = 19;
            this.Telefono.Enter += new System.EventHandler(this.Txt_Enter);
            this.Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Telefono_KeyPress);
            this.Telefono.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // pEmail
            // 
            this.pEmail.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pEmail.Location = new System.Drawing.Point(87, 71);
            this.pEmail.Name = "pEmail";
            this.pEmail.Size = new System.Drawing.Size(263, 5);
            this.pEmail.TabIndex = 18;
            // 
            // Btn_EnviarTelefono
            // 
            this.Btn_EnviarTelefono.AutoSize = true;
            this.Btn_EnviarTelefono.BackColor = System.Drawing.Color.Transparent;
            this.Btn_EnviarTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EnviarTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(136)))), ((int)(((byte)(182)))));
            this.Btn_EnviarTelefono.Image = ((System.Drawing.Image)(resources.GetObject("Btn_EnviarTelefono.Image")));
            this.Btn_EnviarTelefono.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_EnviarTelefono.Location = new System.Drawing.Point(362, 148);
            this.Btn_EnviarTelefono.Name = "Btn_EnviarTelefono";
            this.Btn_EnviarTelefono.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Btn_EnviarTelefono.Size = new System.Drawing.Size(107, 38);
            this.Btn_EnviarTelefono.TabIndex = 17;
            this.Btn_EnviarTelefono.Text = "Enviar";
            this.Btn_EnviarTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_EnviarTelefono.UseMnemonic = false;
            this.Btn_EnviarTelefono.UseVisualStyleBackColor = false;
            this.Btn_EnviarTelefono.Click += new System.EventHandler(this.Btn_EnviarTelefono_Click);
            // 
            // Btn_EnviarEmail
            // 
            this.Btn_EnviarEmail.AutoSize = true;
            this.Btn_EnviarEmail.BackColor = System.Drawing.Color.Transparent;
            this.Btn_EnviarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EnviarEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(136)))), ((int)(((byte)(182)))));
            this.Btn_EnviarEmail.Image = ((System.Drawing.Image)(resources.GetObject("Btn_EnviarEmail.Image")));
            this.Btn_EnviarEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_EnviarEmail.Location = new System.Drawing.Point(362, 42);
            this.Btn_EnviarEmail.Name = "Btn_EnviarEmail";
            this.Btn_EnviarEmail.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Btn_EnviarEmail.Size = new System.Drawing.Size(107, 38);
            this.Btn_EnviarEmail.TabIndex = 16;
            this.Btn_EnviarEmail.Text = "Enviar";
            this.Btn_EnviarEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_EnviarEmail.UseVisualStyleBackColor = false;
            this.Btn_EnviarEmail.Click += new System.EventHandler(this.Btn_EnviarEmail_Click);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(87, 48);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(263, 26);
            this.Email.TabIndex = 15;
            this.Email.Enter += new System.EventHandler(this.Txt_Enter);
            this.Email.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(8, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Número Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Correo:";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Recuperar_Dtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(481, 359);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recuperar_Dtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar_Dtos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pContainer.ResumeLayout(false);
            this.pContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Regresar;
        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Panel pTelefono;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.Panel pEmail;
        private System.Windows.Forms.Button Btn_EnviarTelefono;
        private System.Windows.Forms.Button Btn_EnviarEmail;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Message;
        private System.Windows.Forms.Label Lbl_Msj;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}