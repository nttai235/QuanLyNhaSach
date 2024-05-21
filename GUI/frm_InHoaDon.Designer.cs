namespace GUI
{
    partial class frm_InHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_InHoaDon));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dTOChiTietHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dTOChiTietHoaDonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dTOChiTietHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTOChiTietHoaDonBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 653);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Thoat.FlatAppearance.BorderSize = 0;
            this.btn_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.ForeColor = System.Drawing.Color.White;
            this.btn_Thoat.Location = new System.Drawing.Point(391, 30);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(150, 40);
            this.btn_Thoat.TabIndex = 0;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet_CTHD";
            reportDataSource1.Value = this.dTOChiTietHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report_InHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(932, 653);
            this.reportViewer1.TabIndex = 1;
            // 
            // dTOChiTietHoaDonBindingSource
            // 
            this.dTOChiTietHoaDonBindingSource.DataSource = typeof(DTO.DTO_ChiTietHoaDon);
            // 
            // dTOChiTietHoaDonBindingSource1
            // 
            this.dTOChiTietHoaDonBindingSource1.DataSource = typeof(DTO.DTO_ChiTietHoaDon);
            // 
            // frm_InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(932, 753);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_InHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In Hóa Đơn";
            this.Load += new System.EventHandler(this.frm_InHoaDon_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dTOChiTietHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTOChiTietHoaDonBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Thoat;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dTOChiTietHoaDonBindingSource;
        private System.Windows.Forms.BindingSource dTOChiTietHoaDonBindingSource1;
    }
}