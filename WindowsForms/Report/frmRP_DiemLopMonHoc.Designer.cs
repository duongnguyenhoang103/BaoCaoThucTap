namespace DeMoQLSV1.Report
{
    partial class frmRP_DiemLopMonHoc
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
            this.crpv_DsDiemSV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpv_DsDiemSV
            // 
            this.crpv_DsDiemSV.ActiveViewIndex = -1;
            this.crpv_DsDiemSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpv_DsDiemSV.CachedPageNumberPerDoc = 10;
            this.crpv_DsDiemSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpv_DsDiemSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpv_DsDiemSV.Location = new System.Drawing.Point(0, 0);
            this.crpv_DsDiemSV.Name = "crpv_DsDiemSV";
            this.crpv_DsDiemSV.Size = new System.Drawing.Size(284, 262);
            this.crpv_DsDiemSV.TabIndex = 0;
            this.crpv_DsDiemSV.Load += new System.EventHandler(this.crpv_DSSV_Load);
            // 
            // frmRP_DiemLopMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.crpv_DsDiemSV);
            this.Name = "frmRP_DiemLopMonHoc";
            this.Text = "BÁO CÁO ĐIỂM THEO LỚP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpv_DsDiemSV;
    }
}