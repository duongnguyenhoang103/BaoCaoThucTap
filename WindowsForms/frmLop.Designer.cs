namespace DeMoQLSV1
{
    partial class frmLop
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTong = new System.Windows.Forms.Label();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txTenLp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btNhap = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNghanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKhoaHoc = new System.Windows.Forms.TextBox();
            this.cbMaNghanh = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTong);
            this.groupBox1.Controls.Add(this.dgvLop);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 263);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thông tin lớp";
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Location = new System.Drawing.Point(12, 241);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(10, 13);
            this.lbTong.TabIndex = 21;
            this.lbTong.Text = ".";
            // 
            // dgvLop
            // 
            this.dgvLop.AllowUserToAddRows = false;
            this.dgvLop.AllowUserToDeleteRows = false;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaLop,
            this.TenLop,
            this.SoSV,
            this.MaNghanh,
            this.KhoaHoc});
            this.dgvLop.Location = new System.Drawing.Point(0, 74);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.ReadOnly = true;
            this.dgvLop.Size = new System.Drawing.Size(660, 150);
            this.dgvLop.TabIndex = 20;
            this.dgvLop.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_RowEnter);
            this.dgvLop.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvLop_RowPrePaint);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(199, 25);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(141, 20);
            this.txtSearch.TabIndex = 19;
            this.txtSearch.Text = "nhap ky tu de tim kiem";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.MouseHover += new System.EventHandler(this.txtSearch_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tim kiem";
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(460, 159);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 21);
            this.btXoa.TabIndex = 15;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(361, 159);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 21);
            this.btSua.TabIndex = 14;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(262, 159);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 21);
            this.btThem.TabIndex = 13;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txTenLp
            // 
            this.txTenLp.Location = new System.Drawing.Point(301, 39);
            this.txTenLp.Name = "txTenLp";
            this.txTenLp.Size = new System.Drawing.Size(100, 20);
            this.txTenLp.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên lớp";
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(108, 39);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(100, 20);
            this.txtMaLop.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã lớp";
            // 
            // btNhap
            // 
            this.btNhap.Location = new System.Drawing.Point(163, 159);
            this.btNhap.Name = "btNhap";
            this.btNhap.Size = new System.Drawing.Size(75, 23);
            this.btNhap.TabIndex = 16;
            this.btNhap.Text = "Nhập mới";
            this.btNhap.UseVisualStyleBackColor = true;
            this.btNhap.Click += new System.EventHandler(this.btNhap_Click);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.STT.Width = 80;
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên lớp";
            this.TenLop.Name = "TenLop";
            this.TenLop.ReadOnly = true;
            this.TenLop.Width = 110;
            // 
            // SoSV
            // 
            this.SoSV.DataPropertyName = "SoSV";
            this.SoSV.HeaderText = "Số sinh viên";
            this.SoSV.Name = "SoSV";
            this.SoSV.ReadOnly = true;
            // 
            // MaNghanh
            // 
            this.MaNghanh.DataPropertyName = "MaNghanh";
            this.MaNghanh.HeaderText = "Mã nghành";
            this.MaNghanh.Name = "MaNghanh";
            this.MaNghanh.ReadOnly = true;
            // 
            // KhoaHoc
            // 
            this.KhoaHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KhoaHoc.DataPropertyName = "KhoaHoc";
            this.KhoaHoc.HeaderText = "Khóa học";
            this.KhoaHoc.Name = "KhoaHoc";
            this.KhoaHoc.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(418, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Số sinh viên";
            // 
            // txtSoSV
            // 
            this.txtSoSV.Location = new System.Drawing.Point(489, 39);
            this.txtSoSV.Name = "txtSoSV";
            this.txtSoSV.Size = new System.Drawing.Size(100, 20);
            this.txtSoSV.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã nghành";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Khóa học";
            // 
            // txtKhoaHoc
            // 
            this.txtKhoaHoc.Location = new System.Drawing.Point(383, 89);
            this.txtKhoaHoc.Name = "txtKhoaHoc";
            this.txtKhoaHoc.Size = new System.Drawing.Size(100, 20);
            this.txtKhoaHoc.TabIndex = 12;
            // 
            // cbMaNghanh
            // 
            this.cbMaNghanh.FormattingEnabled = true;
            this.cbMaNghanh.Location = new System.Drawing.Point(188, 88);
            this.cbMaNghanh.Name = "cbMaNghanh";
            this.cbMaNghanh.Size = new System.Drawing.Size(101, 21);
            this.cbMaNghanh.TabIndex = 17;
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 466);
            this.Controls.Add(this.cbMaNghanh);
            this.Controls.Add(this.btNhap);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtKhoaHoc);
            this.Controls.Add(this.txtSoSV);
            this.Controls.Add(this.txTenLp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmLop";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                   THONG TIN DANH SACH CAC LOP";
            this.Load += new System.EventHandler(this.frmLop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txTenLp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Button btNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNghanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoaHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKhoaHoc;
        private System.Windows.Forms.ComboBox cbMaNghanh;
    }
}