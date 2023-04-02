
namespace PL.Pantalla
{
    partial class ReporteEmpleado
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.usuariosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.alturaPolarv2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alturaPolar_v2 = new PL.AlturaPolar_v2();
            this.alturaPolar_v2DataSet = new PL.AlturaPolar_v2DataSet();
            this.UsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.report_empleados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usuariosTableAdapter = new PL.AlturaPolar_v2TableAdapters.UsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alturaPolarv2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alturaPolar_v2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alturaPolar_v2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // usuariosBindingSource2
            // 
            this.usuariosBindingSource2.DataMember = "Usuarios";
            this.usuariosBindingSource2.DataSource = this.alturaPolarv2BindingSource;
            // 
            // alturaPolarv2BindingSource
            // 
            this.alturaPolarv2BindingSource.DataSource = this.alturaPolar_v2;
            this.alturaPolarv2BindingSource.Position = 0;
            // 
            // alturaPolar_v2
            // 
            this.alturaPolar_v2.DataSetName = "AlturaPolar_v2";
            this.alturaPolar_v2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alturaPolar_v2DataSet
            // 
            this.alturaPolar_v2DataSet.DataSetName = "AlturaPolar_v2DataSet";
            this.alturaPolar_v2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UsuariosBindingSource
            // 
            this.UsuariosBindingSource.DataMember = "Usuarios";
            this.UsuariosBindingSource.DataSource = this.alturaPolar_v2DataSet;
            // 
            // report_empleados
            // 
            this.report_empleados.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Usuarios";
            reportDataSource1.Value = this.usuariosBindingSource2;
            this.report_empleados.LocalReport.DataSources.Add(reportDataSource1);
            this.report_empleados.LocalReport.ReportEmbeddedResource = "PL.Pantalla.ReportEmpleado.rdlc";
            this.report_empleados.Location = new System.Drawing.Point(0, 0);
            this.report_empleados.Margin = new System.Windows.Forms.Padding(0);
            this.report_empleados.Name = "report_empleados";
            this.report_empleados.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.report_empleados.ServerReport.BearerToken = null;
            this.report_empleados.Size = new System.Drawing.Size(690, 410);
            this.report_empleados.TabIndex = 0;
            this.report_empleados.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataMember = "Usuarios";
            this.usuariosBindingSource1.DataSource = this.alturaPolarv2BindingSource;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(690, 410);
            this.Controls.Add(this.report_empleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReporteEmpleado";
            this.Text = "ReporteEmpleado";
            this.Load += new System.EventHandler(this.ReporteEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alturaPolarv2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alturaPolar_v2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alturaPolar_v2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion

        private AlturaPolar_v2DataSet alturaPolar_v2DataSet;
        private System.Windows.Forms.BindingSource UsuariosBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer report_empleados;
        private System.Windows.Forms.BindingSource alturaPolarv2BindingSource;
        private AlturaPolar_v2 alturaPolar_v2;
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private AlturaPolar_v2TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.BindingSource usuariosBindingSource2;
    }
}