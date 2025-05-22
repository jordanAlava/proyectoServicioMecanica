namespace capaPresentacion.administrador.ReportesAdministrador
{
    partial class reporteServiciosPendiente
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
            this.bDTallerMecanicoDataSet2 = new capaPresentacion.BDTallerMecanicoDataSet2();
            this.vehiculoServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculo_ServicioTableAdapter = new capaPresentacion.BDTallerMecanicoDataSet2TableAdapters.Vehiculo_ServicioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bDTallerMecanicoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoServicioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vehiculoServicioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "capaPresentacion.administrador.ReportesAdministrador.reporteServiciosPendiente.rd" +
    "lc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // bDTallerMecanicoDataSet2
            // 
            this.bDTallerMecanicoDataSet2.DataSetName = "BDTallerMecanicoDataSet2";
            this.bDTallerMecanicoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculoServicioBindingSource
            // 
            this.vehiculoServicioBindingSource.DataMember = "Vehiculo_Servicio";
            this.vehiculoServicioBindingSource.DataSource = this.bDTallerMecanicoDataSet2;
            // 
            // vehiculo_ServicioTableAdapter
            // 
            this.vehiculo_ServicioTableAdapter.ClearBeforeFill = true;
            // 
            // reporteServiciosPendiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reporteServiciosPendiente";
            this.Text = "reporteServiciosPendiente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.reporteServiciosPendiente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDTallerMecanicoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoServicioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private BDTallerMecanicoDataSet2 bDTallerMecanicoDataSet2;
        private System.Windows.Forms.BindingSource vehiculoServicioBindingSource;
        private BDTallerMecanicoDataSet2TableAdapters.Vehiculo_ServicioTableAdapter vehiculo_ServicioTableAdapter;
    }
}