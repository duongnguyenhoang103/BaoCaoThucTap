namespace DeMoQLSV1
{
    partial class UC_TaiKhoan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btReset = new DevComponents.DotNetBar.ButtonX();
            this.btSearch = new DevComponents.DotNetBar.ButtonX();
            this.btXoa = new DevComponents.DotNetBar.ButtonX();
            this.btThem = new DevComponents.DotNetBar.ButtonX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSua = new DevComponents.DotNetBar.ButtonX();
            this.txtTaiKhoan = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMatKhau = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.dockContainerItem1 = new DevComponents.DotNetBar.DockContainerItem();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTaiKhoan = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // btReset
            // 
            this.btReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btReset.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btReset.Location = new System.Drawing.Point(593, 20);
            this.btReset.Name = "btReset";
            this.btReset.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12, 0, 0, 12);
            this.btReset.Size = new System.Drawing.Size(75, 36);
            this.btReset.TabIndex = 13;
            this.btReset.Text = "Reset";
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btSearch
            // 
            this.btSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btSearch.Location = new System.Drawing.Point(546, 25);
            this.btSearch.Name = "btSearch";
            this.btSearch.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12, 0, 0, 12);
            this.btSearch.Size = new System.Drawing.Size(75, 22);
            this.btSearch.TabIndex = 10;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btXoa
            // 
            this.btXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btXoa.Location = new System.Drawing.Point(486, 20);
            this.btXoa.Name = "btXoa";
            this.btXoa.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12, 0, 0, 12);
            this.btXoa.Size = new System.Drawing.Size(75, 36);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btThem.Location = new System.Drawing.Point(276, 20);
            this.btThem.Name = "btThem";
            this.btThem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12, 0, 0, 12);
            this.btThem.Size = new System.Drawing.Size(75, 36);
            this.btThem.TabIndex = 10;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btReset);
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.btThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 68);
            this.panel2.TabIndex = 1;
            // 
            // btSua
            // 
            this.btSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btSua.Location = new System.Drawing.Point(386, 20);
            this.btSua.Name = "btSua";
            this.btSua.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12, 0, 0, 12);
            this.btSua.Size = new System.Drawing.Size(75, 36);
            this.btSua.TabIndex = 11;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtTaiKhoan.Border.Class = "TextBoxBorder";
            this.txtTaiKhoan.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(320, 25);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(207, 25);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTaiKhoan);
            this.panel1.Controls.Add(this.btSearch);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.labelX2);
            this.panel1.Controls.Add(this.labelX6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(819, 156);
            this.panel1.TabIndex = 0;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtMatKhau.Border.Class = "TextBoxBorder";
            this.txtMatKhau.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(320, 74);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(207, 25);
            this.txtMatKhau.TabIndex = 4;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(209, 25);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(105, 22);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Tên đăng nhập";
            // 
            // labelX6
            // 
            this.labelX6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX6.Location = new System.Drawing.Point(209, 76);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Mật khẩu";
            // 
            // dockContainerItem1
            // 
            this.dockContainerItem1.Name = "dockContainerItem1";
            this.dockContainerItem1.Text = "dockContainerItem1";
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.panel3);
            this.panelEx1.Controls.Add(this.panel2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(819, 545);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(819, 477);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvTaiKhoan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 321);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tài khoản";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TaiKhoan,
            this.MatKhau});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTaiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTaiKhoan.Location = new System.Drawing.Point(3, 22);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(813, 296);
            this.dgvTaiKhoan.TabIndex = 1;
            this.dgvTaiKhoan.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTaiKhoan_CellMouseClick);
            this.dgvTaiKhoan.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvTaiKhoan_RowPrePaint);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 80;
            // 
            // TaiKhoan
            // 
            this.TaiKhoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TaiKhoan.DataPropertyName = "TaiKhoan";
            this.TaiKhoan.HeaderText = "Tài khoản";
            this.TaiKhoan.Name = "TaiKhoan";
            this.TaiKhoan.ReadOnly = true;
            this.TaiKhoan.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            this.MatKhau.Width = 600;
            // 
            // UC_TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Name = "UC_TaiKhoan";
            this.Size = new System.Drawing.Size(819, 545);
            this.Load += new System.EventHandler(this.UC_TaiKhoan_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btReset;
        private DevComponents.DotNetBar.ButtonX btSearch;
        private DevComponents.DotNetBar.ButtonX btXoa;
        private DevComponents.DotNetBar.ButtonX btThem;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX btSua;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTaiKhoan;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMatKhau;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.DockContainerItem dockContainerItem1;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
    }
}
