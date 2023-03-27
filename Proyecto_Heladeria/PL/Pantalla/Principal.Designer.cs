
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
            this.Lbl_Msj = new System.Windows.Forms.Label();
            this.Lbl_Rol = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Msj
            // 
            this.Lbl_Msj.AutoSize = true;
            this.Lbl_Msj.Location = new System.Drawing.Point(111, 85);
            this.Lbl_Msj.Name = "Lbl_Msj";
            this.Lbl_Msj.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Msj.TabIndex = 0;
            this.Lbl_Msj.Text = "label1";
            // 
            // Lbl_Rol
            // 
            this.Lbl_Rol.AutoSize = true;
            this.Lbl_Rol.Location = new System.Drawing.Point(111, 131);
            this.Lbl_Rol.Name = "Lbl_Rol";
            this.Lbl_Rol.Size = new System.Drawing.Size(35, 13);
            this.Lbl_Rol.TabIndex = 1;
            this.Lbl_Rol.Text = "label1";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_Rol);
            this.Controls.Add(this.Lbl_Msj);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Msj;
        private System.Windows.Forms.Label Lbl_Rol;
    }
}