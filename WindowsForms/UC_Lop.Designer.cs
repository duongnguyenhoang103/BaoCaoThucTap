namespace DeMoQLSV1
{
    partial class UC_Lop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboItem5 = new DevComponents.Editors.ComboItem();
            this.comboItem3 = new DevComponents.Editors.ComboItem();
            this.comboItem4 = new DevComponents.Editors.ComboItem();
            this.cbMaNghanh = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLop = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNghanh = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.KhoaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbTong = new DevComponents.DotNetBar.LabelX();
            this.panelEx5 = new DevComponents.DotNetBar.PanelEx();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSearch = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem6 = new DevComponents.Editors.ComboItem();
            this.panelEx4 = new DevComponents.DotNetBar.PanelEx();
            this.txtTL = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx3 = new DevComponents.DotNetBar.PanelEx();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btReset = new DevComponents.DotNetBar.ButtonX();
            this.bttNew = new DevComponents.DotNetBar.ButtonX();
            this.btXoa = new DevComponents.DotNetBar.ButtonX();
            this.btSua = new DevComponents.DotNetBar.ButtonX();
            this.btThem = new DevComponents.DotNetBar.ButtonX();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtKhoaHoc = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtSoSV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtML = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panelEx2 = new DevComponents.DotNetBar.PanelEx();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSearch = new DevComponents.DotNetBar.ButtonX();
            this.panelEx1 = new DevComponents.DotNetBar.PanelEx();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.panelEx5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelEx4.SuspendLayout();
            this.panelEx3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelEx2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelEx1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboItem5
            // 
            this.comboItem5.Text = "Mã lớp";
            // 
            // comboItem3
            // 
            this.comboItem3.Text = "Mã nghành";
            // 
            // comboItem4
            // 
            this.comboItem4.Text = "Tên nghành";
            // 
            // cbMaNghanh
            // 
            this.cbMaNghanh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaNghanh.DisplayMember = "Text";
            this.cbMaNghanh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbMaNghanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNghanh.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNghanh.FormattingEnabled = true;
            this.cbMaNghanh.ItemHeight = 19;
            this.cbMaNghanh.Location = new System.Drawing.Point(256, 29);
            this.cbMaNghanh.Name = "cbMaNghanh";
            this.cbMaNghanh.Size = new System.Drawing.Size(130, 25);
            this.cbMaNghanh.TabIndex = 23;
            this.cbMaNghanh.SelectedIndexChanged += new System.EventHandler(this.cbMaNghanh_SelectedIndexChanged);
            // 
            // labelX4
            // 
            this.labelX4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.Location = new System.Drawing.Point(156, 31);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 14;
            this.labelX4.Text = "Mã nghành";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLop);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(841, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lớp";
            // 
            // dgvLop
            // 
            this.dgvLop.AllowUserToAddRows = false;
            this.dgvLop.AllowUserToDeleteRows = false;
            this.dgvLop.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLop,
            this.TenLop,
            this.SoSV,
            this.colMaNghanh,
            this.KhoaHoc});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLop.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvLop.Location = new System.Drawing.Point(3, 22);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.ReadOnly = true;
            this.dgvLop.Size = new System.Drawing.Size(835, 219);
            this.dgvLop.TabIndex = 2;
            this.dgvLop.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLop_CellMouseClick);
            this.dgvLop.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_RowEnter);
            // 
            // MaLop
            // 
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            this.MaLop.ReadOnly = true;
            this.MaLop.Width = 140;
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên  lớp";
            this.TenLop.Name = "TenLop";
            this.TenLop.ReadOnly = true;
            this.TenLop.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenLop.Width = 250;
            // 
            // SoSV
            // 
            this.SoSV.DataPropertyName = "SoSV";
            this.SoSV.HeaderText = "Số sinh viên";
            this.SoSV.Name = "SoSV";
            this.SoSV.ReadOnly = true;
            this.SoSV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SoSV.Width = 150;
            // 
            // colMaNghanh
            // 
            this.colMaNghanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaNghanh.DataPropertyName = "MaNghanh";
            this.colMaNghanh.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.colMaNghanh.FillWeight = 150F;
            this.colMaNghanh.HeaderText = "Tên nghành";
            this.colMaNghanh.Name = "colMaNghanh";
            this.colMaNghanh.ReadOnly = true;
            this.colMaNghanh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMaNghanh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // KhoaHoc
            // 
            this.KhoaHoc.DataPropertyName = "KhoaHoc";
            this.KhoaHoc.FillWeight = 150F;
            this.KhoaHoc.HeaderText = "Khóa học";
            this.KhoaHoc.Name = "KhoaHoc";
            this.KhoaHoc.ReadOnly = true;
            this.KhoaHoc.Width = 150;
            // 
            // lbTong
            // 
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbTong.Location = new System.Drawing.Point(3, 3);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(217, 37);
            this.lbTong.TabIndex = 0;
            this.lbTong.Text = "labelX1";
            // 
            // panelEx5
            // 
            this.panelEx5.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx5.Controls.Add(this.lbTong);
            this.panelEx5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx5.Location = new System.Drawing.Point(0, 244);
            this.panelEx5.Name = "panelEx5";
            this.panelEx5.Size = new System.Drawing.Size(841, 40);
            this.panelEx5.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx5.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx5.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx5.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx5.Style.GradientAngle = 90;
            this.panelEx5.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.cbSearch);
            this.panel1.Location = new System.Drawing.Point(156, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 41);
            this.panel1.TabIndex = 0;
            // 
            // cbSearch
            // 
            this.cbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSearch.DisplayMember = "Text";
            this.cbSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSearch.ItemHeight = 19;
            this.cbSearch.Items.AddRange(new object[] {
            this.comboItem5,
            this.comboItem6,
            this.comboItem3,
            this.comboItem4});
            this.cbSearch.Location = new System.Drawing.Point(13, 10);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(142, 25);
            this.cbSearch.TabIndex = 11;
            // 
            // comboItem6
            // 
            this.comboItem6.Text = "Tên lớp";
            // 
            // panelEx4
            // 
            this.panelEx4.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx4.Controls.Add(this.groupBox1);
            this.panelEx4.Controls.Add(this.panelEx5);
            this.panelEx4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx4.Location = new System.Drawing.Point(0, 50);
            this.panelEx4.Name = "panelEx4";
            this.panelEx4.Size = new System.Drawing.Size(841, 284);
            this.panelEx4.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx4.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx4.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx4.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx4.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx4.Style.GradientAngle = 90;
            this.panelEx4.TabIndex = 3;
            this.panelEx4.Text = "panelEx4";
            // 
            // txtTL
            // 
            this.txtTL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtTL.Border.Class = "TextBoxBorder";
            this.txtTL.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTL.Location = new System.Drawing.Point(553, 78);
            this.txtTL.Name = "txtTL";
            this.txtTL.Size = new System.Drawing.Size(130, 25);
            this.txtTL.TabIndex = 21;
            // 
            // panelEx3
            // 
            this.panelEx3.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx3.Controls.Add(this.panel5);
            this.panelEx3.Controls.Add(this.panel4);
            this.panelEx3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEx3.Location = new System.Drawing.Point(0, 334);
            this.panelEx3.Name = "panelEx3";
            this.panelEx3.Size = new System.Drawing.Size(841, 222);
            this.panelEx3.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx3.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx3.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx3.Style.GradientAngle = 90;
            this.panelEx3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btReset);
            this.panel5.Controls.Add(this.bttNew);
            this.panel5.Controls.Add(this.btXoa);
            this.panel5.Controls.Add(this.btSua);
            this.panel5.Controls.Add(this.btThem);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 164);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(841, 58);
            this.panel5.TabIndex = 1;
            // 
            // btReset
            // 
            this.btReset.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btReset.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btReset.Location = new System.Drawing.Point(591, 13);
            this.btReset.Name = "btReset";
            this.btReset.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12, 0, 0, 12);
            this.btReset.Size = new System.Drawing.Size(75, 31);
            this.btReset.TabIndex = 19;
            this.btReset.Text = "Reset";
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // bttNew
            // 
            this.bttNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bttNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.bttNew.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.bttNew.Location = new System.Drawing.Point(175, 13);
            this.bttNew.Name = "bttNew";
            this.bttNew.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12, 0, 0, 12);
            this.bttNew.Size = new System.Drawing.Size(75, 31);
            this.bttNew.TabIndex = 18;
            this.bttNew.Text = "Nhập mới";
            this.bttNew.Click += new System.EventHandler(this.bttNew_Click);
            // 
            // btXoa
            // 
            this.btXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btXoa.Location = new System.Drawing.Point(489, 13);
            this.btXoa.Name = "btXoa";
            this.btXoa.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12, 0, 0, 12);
            this.btXoa.Size = new System.Drawing.Size(75, 31);
            this.btXoa.TabIndex = 17;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btSua.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btSua.Location = new System.Drawing.Point(389, 13);
            this.btSua.Name = "btSua";
            this.btSua.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12, 0, 0, 12);
            this.btSua.Size = new System.Drawing.Size(75, 31);
            this.btSua.TabIndex = 16;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btThem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btThem.Location = new System.Drawing.Point(279, 13);
            this.btThem.Name = "btThem";
            this.btThem.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12, 0, 0, 12);
            this.btThem.Size = new System.Drawing.Size(75, 31);
            this.btThem.TabIndex = 15;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cbMaNghanh);
            this.panel4.Controls.Add(this.txtTL);
            this.panel4.Controls.Add(this.labelX4);
            this.panel4.Controls.Add(this.labelX5);
            this.panel4.Controls.Add(this.txtKhoaHoc);
            this.panel4.Controls.Add(this.labelX3);
            this.panel4.Controls.Add(this.labelX2);
            this.panel4.Controls.Add(this.txtSoSV);
            this.panel4.Controls.Add(this.labelX1);
            this.panel4.Controls.Add(this.txtML);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(841, 222);
            this.panel4.TabIndex = 0;
            // 
            // labelX5
            // 
            this.labelX5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX5.Location = new System.Drawing.Point(156, 120);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "Khóa học";
            // 
            // txtKhoaHoc
            // 
            this.txtKhoaHoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtKhoaHoc.Border.Class = "TextBoxBorder";
            this.txtKhoaHoc.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhoaHoc.Location = new System.Drawing.Point(256, 120);
            this.txtKhoaHoc.Name = "txtKhoaHoc";
            this.txtKhoaHoc.Size = new System.Drawing.Size(130, 25);
            this.txtKhoaHoc.TabIndex = 5;
            // 
            // labelX3
            // 
            this.labelX3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX3.Location = new System.Drawing.Point(451, 76);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(68, 23);
            this.labelX3.TabIndex = 10;
            this.labelX3.Text = "Tên lớp";
            // 
            // labelX2
            // 
            this.labelX2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX2.Location = new System.Drawing.Point(156, 76);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(94, 23);
            this.labelX2.TabIndex = 12;
            this.labelX2.Text = "Số sinh viên";
            // 
            // txtSoSV
            // 
            this.txtSoSV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtSoSV.Border.Class = "TextBoxBorder";
            this.txtSoSV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoSV.Location = new System.Drawing.Point(256, 76);
            this.txtSoSV.Name = "txtSoSV";
            this.txtSoSV.Size = new System.Drawing.Size(130, 25);
            this.txtSoSV.TabIndex = 7;
            // 
            // labelX1
            // 
            this.labelX1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX1.Location = new System.Drawing.Point(453, 26);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(66, 23);
            this.labelX1.TabIndex = 11;
            this.labelX1.Text = "Mã lớp";
            // 
            // txtML
            // 
            this.txtML.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtML.Border.Class = "TextBoxBorder";
            this.txtML.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtML.Location = new System.Drawing.Point(553, 28);
            this.txtML.Name = "txtML";
            this.txtML.Size = new System.Drawing.Size(130, 25);
            this.txtML.TabIndex = 8;
            // 
            // panelEx2
            // 
            this.panelEx2.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx2.Controls.Add(this.panel3);
            this.panelEx2.Controls.Add(this.panel2);
            this.panelEx2.Controls.Add(this.panel1);
            this.panelEx2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEx2.Location = new System.Drawing.Point(0, 0);
            this.panelEx2.Name = "panelEx2";
            this.panelEx2.Size = new System.Drawing.Size(841, 50);
            this.panelEx2.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx2.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx2.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx2.Style.GradientAngle = 90;
            this.panelEx2.TabIndex = 0;
            this.panelEx2.Click += new System.EventHandler(this.panelEx2_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Location = new System.Drawing.Point(317, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 34);
            this.panel3.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            // 
            // 
            // 
            this.txtSearch.Border.Class = "TextBoxBorder";
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(3, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(194, 25);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.btSearch);
            this.panel2.Location = new System.Drawing.Point(526, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 35);
            this.panel2.TabIndex = 3;
            // 
            // btSearch
            // 
            this.btSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
            this.btSearch.Location = new System.Drawing.Point(12, 3);
            this.btSearch.Name = "btSearch";
            this.btSearch.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(12, 0, 0, 12);
            this.btSearch.Size = new System.Drawing.Size(102, 24);
            this.btSearch.TabIndex = 13;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // panelEx1
            // 
            this.panelEx1.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.panelEx1.Controls.Add(this.panelEx4);
            this.panelEx1.Controls.Add(this.panelEx3);
            this.panelEx1.Controls.Add(this.panelEx2);
            this.panelEx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx1.Location = new System.Drawing.Point(0, 0);
            this.panelEx1.Name = "panelEx1";
            this.panelEx1.Size = new System.Drawing.Size(841, 556);
            this.panelEx1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.panelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx1.Style.GradientAngle = 90;
            this.panelEx1.TabIndex = 1;
            // 
            // UC_Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelEx1);
            this.Name = "UC_Lop";
            this.Size = new System.Drawing.Size(841, 556);
            this.Load += new System.EventHandler(this.UC_Lop_Load);
            this.DoubleClick += new System.EventHandler(this.UC_Lop_DoubleClick);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.panelEx5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelEx4.ResumeLayout(false);
            this.panelEx3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panelEx2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelEx1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.Editors.ComboItem comboItem5;
        private DevComponents.Editors.ComboItem comboItem3;
        private DevComponents.Editors.ComboItem comboItem4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbMaNghanh;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvLop;
        private DevComponents.DotNetBar.LabelX lbTong;
        private DevComponents.DotNetBar.PanelEx panelEx5;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cbSearch;
        private DevComponents.Editors.ComboItem comboItem6;
        private DevComponents.DotNetBar.PanelEx panelEx4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTL;
        private DevComponents.DotNetBar.PanelEx panelEx3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKhoaHoc;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSoSV;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtML;
        private DevComponents.DotNetBar.PanelEx panelEx2;
        private System.Windows.Forms.Panel panel3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSearch;
        private System.Windows.Forms.Panel panel2;
        private DevComponents.DotNetBar.ButtonX btSearch;
        private DevComponents.DotNetBar.PanelEx panelEx1;
        private DevComponents.DotNetBar.ButtonX bttNew;
        private DevComponents.DotNetBar.ButtonX btXoa;
        private DevComponents.DotNetBar.ButtonX btSua;
        private DevComponents.DotNetBar.ButtonX btThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoSV;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaNghanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhoaHoc;
        private DevComponents.DotNetBar.ButtonX btReset;
    }
}
