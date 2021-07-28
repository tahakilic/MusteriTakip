namespace MusteriTakip
{
    partial class GecmisRapor
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
            this.ybsdbDataSet1 = new MusteriTakip.ybsdbDataSet1();
            this.gecmisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gecmisTableAdapter = new MusteriTakip.ybsdbDataSet1TableAdapters.gecmisTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ybsdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gecmisBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.gecmisBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MusteriTakip.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(850, 644);
            this.reportViewer1.TabIndex = 0;
            // 
            // ybsdbDataSet1
            // 
            this.ybsdbDataSet1.DataSetName = "ybsdbDataSet1";
            this.ybsdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gecmisBindingSource
            // 
            this.gecmisBindingSource.DataMember = "gecmis";
            this.gecmisBindingSource.DataSource = this.ybsdbDataSet1;
            // 
            // gecmisTableAdapter
            // 
            this.gecmisTableAdapter.ClearBeforeFill = true;
            // 
            // GecmisRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 644);
            this.Controls.Add(this.reportViewer1);
            this.Name = "GecmisRapor";
            this.Text = "GecmisRapor";
            this.Load += new System.EventHandler(this.GecmisRapor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ybsdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gecmisBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource gecmisBindingSource;
        private ybsdbDataSet1 ybsdbDataSet1;
        private ybsdbDataSet1TableAdapters.gecmisTableAdapter gecmisTableAdapter;
    }
}