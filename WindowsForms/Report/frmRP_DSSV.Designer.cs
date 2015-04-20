namespace DeMoQLSV1.Report
{
    partial class frmRP_DSSV
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
            this.crpv_DSSV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crpv_DSSV
            // 
            this.crpv_DSSV.ActiveViewIndex = -1;
            this.crpv_DSSV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crpv_DSSV.CachedPageNumberPerDoc = 10;
            this.crpv_DSSV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crpv_DSSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crpv_DSSV.Location = new System.Drawing.Point(0, 0);
            this.crpv_DSSV.Name = "crpv_DSSV";
            this.crpv_DSSV.Size = new System.Drawing.Size(284, 262);
            this.crpv_DSSV.TabIndex = 0;
            this.crpv_DSSV.Load += new System.EventHandler(this.crpv_DSSV_Load);
            // 
            // frmRP_DSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.crpv_DSSV);
            this.Name = "frmRP_DSSV";
            this.Text = "DANH SÁCH SINH VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crpv_DSSV;
    }
}