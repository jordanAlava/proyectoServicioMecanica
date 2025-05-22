namespace capaPresentacion.administrador.ReportesAdministrador
{
    partial class reporteTiposServicios
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
            this.servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDTallerMecanicoDataSet = new capaPresentacion.BDTallerMecanicoDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.servicioTableAdapter = new capaPresentacion.BDTallerMecanicoDataSetTableAdapters.ServicioTableAdapter();
            this.bDTallerMecanicoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bDTallerMecanicoDataSet1 = new capaPresentacion.BDTallerMecanicoDataSet1();
            this.servicioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.servicioTableAdapter1 = new capaPresentacion.BDTallerMecanicoDataSet1TableAdapters.ServicioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTallerMecanicoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTallerMecanicoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTallerMecanicoDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // servicioBindingSource
            // 
            this.servicioBindingSource.DataMember = "Servicio";
            this.servicioBindingSource.DataSource = this.bDTallerMecanicoDataSet;
            // 
            // bDTallerMecanicoDataSet
            // 
            this.bDTallerMecanicoDataSet.DataSetName = "BDTallerMecanicoDataSet";
            this.bDTallerMecanicoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.servicioBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "capaPresentacion.administrador.ReportesAdministrador.tiposServicios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(600, 366);
            this.reportViewer1.TabIndex = 0;
            // 
            // servicioTableAdapter
            // 
            this.servicioTableAdapter.ClearBeforeFill = true;
            // 
            // bDTallerMecanicoDataSetBindingSource
            // 
            this.bDTallerMecanicoDataSetBindingSource.DataSource = this.bDTallerMecanicoDataSet;
            this.bDTallerMecanicoDataSetBindingSource.Position = 0;
            // 
            // servicioBindingSource1
            // 
            this.servicioBindingSource1.DataMember = "Servicio";
            this.servicioBindingSource1.DataSource = this.bDTallerMecanicoDataSetBindingSource;
            // 
            // bDTallerMecanicoDataSet1
            // 
            this.bDTallerMecanicoDataSet1.DataSetName = "BDTallerMecanicoDataSet1";
            this.bDTallerMecanicoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicioBindingSource2
            // 
            this.servicioBindingSource2.DataMember = "Servicio";
            this.servicioBindingSource2.DataSource = this.bDTallerMecanicoDataSet1;
            // 
            // servicioTableAdapter1
            // 
            this.servicioTableAdapter1.ClearBeforeFill = true;
            // 
            // reporteTiposServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "reporteTiposServicios";
            this.Text = "reporteTiposServicios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.reporteTiposServicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTallerMecanicoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTallerMecanicoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDTallerMecanicoDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BDTallerMecanicoDataSet bDTallerMecanicoDataSet;
        private System.Windows.Forms.BindingSource servicioBindingSource;
        private BDTallerMecanicoDataSetTableAdapters.ServicioTableAdapter servicioTableAdapter;
        private System.Windows.Forms.BindingSource servicioBindingSource1;
        private System.Windows.Forms.BindingSource bDTallerMecanicoDataSetBindingSource;
        private BDTallerMecanicoDataSet1 bDTallerMecanicoDataSet1;
        private System.Windows.Forms.BindingSource servicioBindingSource2;
        private BDTallerMecanicoDataSet1TableAdapters.ServicioTableAdapter servicioTableAdapter1;
    }
}