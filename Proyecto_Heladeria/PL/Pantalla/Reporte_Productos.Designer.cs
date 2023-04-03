
namespace PL.Pantalla
{
    partial class Reporte_Productos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.alturaPolar_v2DataSet2 = new PL.AlturaPolar_v2DataSet2();
            this.inventarioProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioProductsTableAdapter = new PL.AlturaPolar_v2DataSet2TableAdapters.InventarioProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.alturaPolar_v2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Inventario";
            reportDataSource1.Value = this.inventarioProductsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PL.Pantalla.Report_InventarioProducts.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // alturaPolar_v2DataSet2
            // 
            this.alturaPolar_v2DataSet2.DataSetName = "AlturaPolar_v2DataSet2";
            this.alturaPolar_v2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioProductsBindingSource
            // 
            this.inventarioProductsBindingSource.DataMember = "InventarioProducts";
            this.inventarioProductsBindingSource.DataSource = this.alturaPolar_v2DataSet2;
            // 
            // inventarioProductsTableAdapter
            // 
            this.inventarioProductsTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_Productos";
            this.Text = "Reporte_Productos";
            this.Load += new System.EventHandler(this.Reporte_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alturaPolar_v2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioProductsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private AlturaPolar_v2DataSet2 alturaPolar_v2DataSet2;
        private System.Windows.Forms.BindingSource inventarioProductsBindingSource;
        private AlturaPolar_v2DataSet2TableAdapters.InventarioProductsTableAdapter inventarioProductsTableAdapter;
    }
}