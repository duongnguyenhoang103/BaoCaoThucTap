namespace DeMoQLSV1.Report
{
    partial class frmRP_BangDiemSVTheoHK
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
            this.crpv_DiemMonHoc = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpv_DiemMonHoc
            // 
            this.crpv_DiemMonHoc.ActiveViewIndex = -1;
            this.crpv_DiemMonHoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpv_DiemMonHoc.CachedPageNumberPerDoc = 10;
            this.crpv_DiemMonHoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpv_DiemMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpv_DiemMonHoc.Location = new System.Drawing.Point(0, 0);
            this.crpv_DiemMonHoc.Name = "crpv_DiemMonHoc";
            this.crpv_DiemMonHoc.Size = new System.Drawing.Size(284, 262);
            this.crpv_DiemMonHoc.TabIndex = 0;
            this.crpv_DiemMonHoc.Load += new System.EventHandler(this.crpv_DiemMonHoc_Load);
            // 
            // frmRP_BangDiemSVTheoHK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.crpv_DiemMonHoc);
            this.Name = "frmRP_BangDiemSVTheoHK";
            this.Text = "BẢNG ĐIỂM SINH VIÊN THEO HỌC KÌ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRP_DiemMonHoc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpv_DiemMonHoc;
    }
}