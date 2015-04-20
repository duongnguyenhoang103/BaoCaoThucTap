namespace DeMoQLSV1.Report
{
    partial class frmRP_DiemCaNamSV
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
            this.crpv_DiemCaNamSV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpv_DiemCaNamSV
            // 
            this.crpv_DiemCaNamSV.ActiveViewIndex = -1;
            this.crpv_DiemCaNamSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpv_DiemCaNamSV.CachedPageNumberPerDoc = 10;
            this.crpv_DiemCaNamSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpv_DiemCaNamSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpv_DiemCaNamSV.Location = new System.Drawing.Point(0, 0);
            this.crpv_DiemCaNamSV.Name = "crpv_DiemCaNamSV";
            this.crpv_DiemCaNamSV.Size = new System.Drawing.Size(284, 262);
            this.crpv_DiemCaNamSV.TabIndex = 0;
            this.crpv_DiemCaNamSV.Load += new System.EventHandler(this.crpv_DiemCaNamSV_Load);
            // 
            // frmRP_DiemCaNamSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.crpv_DiemCaNamSV);
            this.Name = "frmRP_DiemCaNamSV";
            this.Text = "frmDiemCaNamSV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpv_DiemCaNamSV;
    }
}