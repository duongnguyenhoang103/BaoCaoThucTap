namespace DeMoQLSV1
{
    partial class frmMonHoc
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
            this.dgvMH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMH = new System.Windows.Forms.TextBox();
            this.txTenMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMaGV = new System.Windows.Forms.ComboBox();
            this.btThem = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btTK = new System.Windows.Forms.Button();
            this.cbTK = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTong = new System.Windows.Forms.Label();
            this.colMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaGV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMH)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMH
            // 
            this.dgvMH.AllowUserToAddRows = false;
            this.dgvMH.AllowUserToDeleteRows = false;
            this.dgvMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaMH,
            this.colTenMH,
            this.colMaGV});
            this.dgvMH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMH.Location = new System.Drawing.Point(0, 0);
            this.dgvMH.Name = "dgvMH";
            this.dgvMH.ReadOnly = true;
            this.dgvMH.Size = new System.Drawing.Size(534, 173);
            this.dgvMH.TabIndex = 0;
            this.dgvMH.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMH_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ma MH";
            // 
            // txtMH
            // 
            this.txtMH.Location = new System.Drawing.Point(100, 32);
            this.txtMH.Name = "txtMH";
            this.txtMH.Size = new System.Drawing.Size(100, 20);
            this.txtMH.TabIndex = 2;
            // 
            // txTenMH
            // 
            this.txTenMH.Location = new System.Drawing.Point(100, 76);
            this.txTenMH.Name = "txTenMH";
            this.txTenMH.Size = new System.Drawing.Size(100, 20);
            this.txTenMH.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ten Mon Hoc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ma Giao Vien";
            // 
            // cbMaGV
            // 
            this.cbMaGV.FormattingEnabled = true;
            this.cbMaGV.Location = new System.Drawing.Point(101, 123);
            this.cbMaGV.Name = "cbMaGV";
            this.cbMaGV.Size = new System.Drawing.Size(99, 21);
            this.cbMaGV.TabIndex = 6;
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(308, 27);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 7;
            this.btThem.Text = "Them";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(308, 73);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 8;
            this.btSua.Text = "Sua";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(308, 120);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xoa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btTK);
            this.panel1.Controls.Add(this.cbTK);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 51);
            this.panel1.TabIndex = 10;
            // 
            // btTK
            // 
            this.btTK.Location = new System.Drawing.Point(345, 14);
            this.btTK.Name = "btTK";
            this.btTK.Size = new System.Drawing.Size(75, 23);
            this.btTK.TabIndex = 14;
            this.btTK.Text = "tim kiem";
            this.btTK.UseVisualStyleBackColor = true;
            this.btTK.Click += new System.EventHandler(this.btTK_Click);
            // 
            // cbTK
            // 
            this.cbTK.Location = new System.Drawing.Point(63, 16);
            this.cbTK.Name = "cbTK";
            this.cbTK.Size = new System.Drawing.Size(112, 21);
            this.cbTK.TabIndex = 13;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(191, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(138, 20);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvMH);
            this.panel2.Location = new System.Drawing.Point(0, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 173);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtMH);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.btXoa);
            this.panel3.Controls.Add(this.txTenMH);
            this.panel3.Controls.Add(this.btSua);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btThem);
            this.panel3.Controls.Add(this.cbMaGV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 267);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(536, 151);
            this.panel3.TabIndex = 12;
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.Location = new System.Drawing.Point(13, 237);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(11, 13);
            this.lbTong.TabIndex = 13;
            this.lbTong.Text = ".";
            // 
            // colMaMH
            // 
            this.colMaMH.DataPropertyName = "MaMH";
            this.colMaMH.HeaderText = "MaMH";
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.ReadOnly = true;
            this.colMaMH.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colTenMH
            // 
            this.colTenMH.DataPropertyName = "TenMH";
            this.colTenMH.HeaderText = "Ten Mon Hoc";
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.ReadOnly = true;
            this.colTenMH.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTenMH.Width = 200;
            // 
            // colMaGV
            // 
            this.colMaGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaGV.DataPropertyName = "MaGV";
            this.colMaGV.DisplayStyleForCurrentCellOnly = true;
            this.colMaGV.HeaderText = "Ten Giao Vien";
            this.colMaGV.Name = "colMaGV";
            this.colMaGV.ReadOnly = true;
            this.colMaGV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaGV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 418);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmMonHoc";
            this.Text = "THONG TIN MON HOC";
            this.Load += new System.EventHandler(this.frmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMH;
        private System.Windows.Forms.TextBox txTenMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMaGV;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbTK;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Button btTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenMH;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaGV;
    }
}