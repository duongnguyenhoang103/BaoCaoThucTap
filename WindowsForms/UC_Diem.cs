using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessEntity;

namespace DeMoQLSV1
{
    public partial class UC_Diem : UserControl
    {
        public UC_Diem()
        {
            InitializeComponent();
        }

        SinhVienBE sv = new SinhVienBE();
        LopBE lp = new LopBE();
        MonHocBE mh = new MonHocBE();
        DiemBE d = new DiemBE();

        private float diemHs1 = 0;
        private float diemHS2 = 0;
        private float diemThi = 0;
        private float diemTP = 0;

        #region delegate show from con
        public delegate void ShowForms(string title,UserControl uct);
        public ShowForms frmShowChildrenForm;
        #endregion

        #region close from
        public delegate void CloseTab();
        public CloseTab CloseTabss;
        #endregion

        public void loadCombo()
        {
            cbSearch.SelectedIndex = 0;
            //load Cb MaSV
            cbMaSV.DataSource = sv.GetAllSV();
            cbMaSV.DisplayMember = "MaSV";
            cbMaSV.ValueMember = "MaSV";
            //load CbMaLop
            cbMaL.DataSource = lp.ShowLop();
            cbMaL.DisplayMember = "MaLop";
            cbMaL.ValueMember = "MaLop";
            //load Cb MaMonHoc
            cbMH.DataSource = mh.ShowMH();
            cbMH.DisplayMember = "MaMH";
            cbMH.ValueMember = "MaMH";
            //load ColMaSV
            colMaSV.DataSource = sv.GetAllSV();
            colMaSV.DisplayMember = "TenSV";
            colMaSV.ValueMember = "MaSV";
            // load colum Malop tren dgv  
            colMaLop.DataSource = lp.ShowLop();
            colMaLop.DisplayMember = "TenLop";
            colMaLop.ValueMember = "MaLop";
            //load Col MaMonHoc
            colMaMH .DataSource = mh.ShowMH();
            colMaMH .DisplayMember = "TenMH";
            colMaMH .ValueMember = "MaMH";
        }

        public void loadData()
        {
            dgvDiem.DataSource = d.showDiem();
            lbTg.Text = "có tổng số: " + dgvDiem.RowCount.ToString() + " sinh viên";
            lbTg.ForeColor = Color.BlueViolet;
            lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
            lbTg.Visible = false;
            
        }
        private void UC_Diem_Load(object sender, EventArgs e)
        {
            //lbTg.Text = "";
            loadCombo();
            loadData();
            btThem.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btThem.Visible = false;
        }

        private void dgvDiem_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDiem.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void Reset()
        {
          
            txtDhs1.Text = diemHs1.ToString();
            txtDhs2.Text = diemHS2.ToString();
            txtDiemChu.Text = null;
            txtDiemHocPhan.Text = null;
            txtDTP.Text = diemTP.ToString();
            txtDiemChu.Text = null;
            txtDiemThi.Text = diemThi.ToString();
            txtLanThi.Text = null;
            txtHocKi.Text = null;
            txtSoTietNgi.Text = null;
            cbMaL.Text = null;
            cbMaSV.Text = null;
            cbMH.Text = null;
            cbSearch.SelectedIndex = 0;            
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
           
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            txtDhs1.Text = diemHs1.ToString();
            txtDhs2.Text = diemHS2.ToString();
            txtDiemChu.Text = null;
            txtDiemHocPhan.Text = null;
            txtDTP.Text = diemTP.ToString();
            txtDiemChu.Text = null;
            txtDiemThi.Text = diemThi.ToString();
            txtLanThi.Text = null;
            txtHocKi.Text = null;
            txtSoTietNgi.Text = null;
            cbMaL.Text = null;
            cbMaSV.Text = null;
            cbMH.Text = null;
            cbSearch.SelectedIndex = 0;
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
         
            UCNhapDiemSV ucNhapD = new UCNhapDiemSV();
           
            frmShowChildrenForm(" Nhập Điểm Thi Sinh Viên", ucNhapD);
            ucNhapD.Disposed +=new EventHandler(ucNhapD_Disposed);        
        }

        void ucNhapD_Disposed(object sender, EventArgs e)
        {
            CloseTabss();
            loadCombo();
            loadData();
        }
     
        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbMaSV.SelectedValue.ToString() == "" || dgvDiem.SelectedRows.Count < 0)
                {
                    MessageBox.Show(" bạn phải chọn điểm của 1 sinh viên để xóa ");
                }
                else
                {

                    //  if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn xóa điểm sinh viên " +colMaSV.DisplayMember.   + " với mã " + cbMaSV.SelectedValue  + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn xóa điểm sinh viên có mã " + cbMaSV.SelectedValue + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        int dong = dgvDiem.CurrentCell.RowIndex;
                      // string madk = dgvDiem.Rows[dong].Cells[0].Value.ToString().Trim();
                        string maSV = dgvDiem.Rows[dong].Cells["colMaSV"].Value.ToString().Trim();
                        string maMaL = dgvDiem.Rows[dong].Cells["colMaLop"].Value.ToString().Trim();
                        string maMH = dgvDiem.Rows[dong].Cells["colMaMH"].Value.ToString().Trim();
                        string maLanThi = dgvDiem.Rows[dong].Cells["LanThi"].Value.ToString().Trim();
                        d.deleteDiemByMaM( maSV, maMaL, maMH,maLanThi );
                        MessageBox.Show("Xóa điểm môn " + cbMH.SelectedValue + " của sinh viên có mã " + cbMaSV.SelectedValue + " thành công");
                        loadData();
                 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" lỗi" + ex); 
            }
            
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDhs1.TextLength == 0 || txtDiemThi.TextLength == 0 || txtHocKi.TextLength == 0 || txtLanThi.TextLength == 0 || txtDhs2.TextLength == 0)
                {
                    MessageBox.Show(" bạn phải nhập đầy đủ thông tin");
                    return;
                }
                float Num;
                bool ktra = float.TryParse(txtDhs1.Text.Trim(), out Num);
                if (!ktra)
                {
                    MessageBox.Show("hãy nhập số");
                    txtDhs1.ResetText();
                    txtDhs1.Focus();
                    return;
                }
                float Num5;
                bool ktra5 = float.TryParse(txtDhs2.Text.Trim(), out Num5);
                if (!ktra5)
                {
                    MessageBox.Show("hãy nhập số");
                    txtDhs2.ResetText();
                    txtDhs2.Focus();
                    return;
                }
                float Num1;
                bool ktra1 = float.TryParse(txtDiemThi.Text.Trim(), out Num1);
                if (!ktra1)
                {
                    MessageBox.Show("hãy nhập số");
                    txtDiemThi.ResetText();
                    txtDiemThi.Focus();
                    return;
                }
                float Num2;
                bool ktra2 = float.TryParse(txtLanThi.Text.Trim(), out Num2);
                if (!ktra2)
                {
                    MessageBox.Show("hãy nhập số");
                    txtLanThi.ResetText();
                    txtLanThi.Focus();
                    return;
                }
                float Num3;
                bool ktra3 = float.TryParse(txtHocKi.Text.Trim(), out Num3);
                if (!ktra3)
                {
                    MessageBox.Show("hãy nhập số");
                    txtHocKi.ResetText();
                    txtHocKi.Focus();
                    return;
                }
                float Num4;
                bool ktra4 = float.TryParse(txtSoTietNgi.Text.Trim(), out Num4);
                if (!ktra4)
                {
                    MessageBox.Show("hãy nhập số");
                    txtSoTietNgi.ResetText();
                    txtSoTietNgi.Focus();
                    return;
                }
                else
                {                  
                    if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn thêm điểm sinh viên có mã " + cbMaSV.SelectedValue + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        d.insertDiem(cbMaSV.SelectedValue.ToString().Trim(), cbMaL.SelectedValue.ToString().Trim(), cbMH.SelectedValue.ToString().Trim(), float.Parse(txtDhs1.Text.Trim()), float.Parse(txtDhs2.Text.Trim()), float.Parse(txtDiemThi.Text.Trim()),
                                  float.Parse(txtDTP.Text.Trim()), float.Parse(txtDiemHocPhan.Text.Trim()), txtDiemChu.Text.ToString().Trim(), Convert.ToInt32(txtLanThi.Text.Trim()), Convert.ToInt32(txtHocKi.Text.Trim()), Convert.ToInt32(txtSoTietNgi.Text.Trim()));
                        MessageBox.Show(" thêm thành công  ");                                      
                        btThem.Enabled = false ;
                        txtSearch.Text = "";
                        Reset();
                        loadData();
                    }
                }
            }
            catch (Exception ex)
            {             
                MessageBox.Show("lỗi" +ex);
                txtLanThi.Focus();                   
                return;
            }                       
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbMaL.SelectedValue== null || cbMaSV.SelectedValue== null)
                {
                     MessageBox.Show(" bạn phải chọn 1 sinh viên để sửa");
                    return;
                }
                if (txtDhs1.TextLength == 0 || txtDiemThi.TextLength == 0 || txtHocKi.TextLength == 0 || txtLanThi.TextLength == 0 || txtDhs2.TextLength == 0)
                {
                    MessageBox.Show(" bạn phải nhập đầy đủ thông tin");
                    return;
                }
                float Num;
                bool ktra = float.TryParse(txtDhs1.Text.Trim(), out Num);
                if (!ktra)
                {
                    MessageBox.Show("hãy nhập số");
                    txtDhs1.ResetText();
                    txtDhs1.Focus();
                    return;
                }
                float Num5;
                bool ktra5 = float.TryParse(txtDhs2.Text.Trim(), out Num5);
                if (!ktra5)
                {
                    MessageBox.Show("hãy nhập số");
                    txtDhs2.ResetText();
                    txtDhs2.Focus();
                    return;
                }

                float Num1;
                bool ktra1 = float.TryParse(txtDiemThi.Text.Trim(), out Num1);
                if (!ktra1)
                {
                    MessageBox.Show("hãy nhập số");
                    txtDiemThi.ResetText();
                    txtDiemThi.Focus();
                    return;
                }
                float Num2;
                bool ktra2 = float.TryParse(txtLanThi.Text.Trim(), out Num2);
                if (!ktra2)
                {
                    MessageBox.Show("hãy nhập số");
                    txtLanThi.ResetText();
                    txtLanThi.Focus();
                    return;
                }
                float Num3;
                bool ktra3 = float.TryParse(txtHocKi.Text.Trim(), out Num3);
                if (!ktra3)
                {
                    MessageBox.Show("hãy nhập số");
                    txtHocKi.ResetText();
                    txtHocKi.Focus();
                    return;
                }
                float Num4;
                bool ktra4 = float.TryParse(txtSoTietNgi.Text.Trim(), out Num4);
                if (!ktra4)
                {
                    MessageBox.Show("hãy nhập số");
                    txtSoTietNgi.ResetText();
                    txtSoTietNgi.Focus();
                    return;
                }
                else
                {
                    int vt = dgvDiem.CurrentCell.RowIndex;
                    string madkSV = dgvDiem.Rows[vt].Cells["colMaSV"].Value.ToString();
                    string madkL = dgvDiem.Rows[vt].Cells["colMaLop"].Value.ToString();
                     string madkMH = dgvDiem.Rows[vt].Cells["colMaMH"].Value.ToString();
                     string madkLT = dgvDiem.Rows[vt].Cells["LanThi"].Value.ToString();

                     if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn thêm điểm sinh viên có mã " + cbMaSV.SelectedValue + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                     {
                         d.updateDiem(madkSV, madkL, madkMH, madkLT, cbMaSV.SelectedValue.ToString(), cbMaL.SelectedValue.ToString(), cbMH.SelectedValue.ToString(), float.Parse(txtDhs1.Text), float.Parse(txtDhs2.Text),
                                   float.Parse(txtDiemThi.Text), float.Parse(txtDTP.Text), float.Parse(txtDiemHocPhan.Text), txtDiemChu.Text, int.Parse(txtLanThi.Text), int.Parse(txtHocKi.Text), int.Parse(txtSoTietNgi.Text));
                         MessageBox.Show(" sửa thành công  ");

                         txtSearch.Text = null;
                         Reset();
                         loadData();
                     }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Lỗi truy vấn " + ex.Message);
            }                       
        }


         private void btSearch_Click(object sender, EventArgs e)
        {
               string key = txtSearch.Text.ToString().Trim();
            try
            {
                if (txtSearch.TextLength == 0)
                {
                    MessageBox.Show(" bạn phải nhập kí tự tìm kiếm");
                    txtSearch.Focus();
                    return;
                }
                if (cbSearch.SelectedItem.ToString() == "Mã lớp")
                {
                    dgvDiem.DataSource = d.getDiemByIdLop(key);
                    if (dgvDiem.Rows.Count == 0)
                    {
                        lbTg.Visible = true;
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " không tìm thấy";
                        txtDhs1.Text = diemHs1.ToString();
                        txtDhs2.Text = diemHS2.ToString();
                        txtDiemChu.Text = null;
                        txtDiemHocPhan.Text = null;
                        txtDTP.Text = diemTP.ToString();
                        txtDiemChu.Text = null;
                        txtDiemThi.Text = diemThi.ToString();
                        txtLanThi.Text = null;
                        txtHocKi.Text = null;
                        txtSoTietNgi.Text = null;
                        cbMaL.Text = null;
                        cbMaSV.Text = null;
                        cbMH.Text = null;
                   
                    }
                    else
                    {
                        lbTg.ForeColor = Color.BlueViolet;
                        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                        this.lbTg.Text = "Tìm thấy: " + dgvDiem.Rows.Count.ToString() + " sinh Viên ";
                        bttNew.Enabled = false;
                        btThem.Enabled = false;
                        lbTg.Visible = false;
                    }
                }
                if (cbSearch.SelectedItem.ToString() == "Mã sinh viên")
                {
                    dgvDiem.DataSource = d.getDiemByIdSV(key);
                    if (dgvDiem.Rows.Count == 0)
                    {
                        lbTg.Visible = true;
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " không tìm thấy";
                        txtDhs1.Text = diemHs1.ToString();
                        txtDhs2.Text = diemHS2.ToString();
                        txtDiemChu.Text = null;
                        txtDiemHocPhan.Text = null;
                        txtDTP.Text = diemTP.ToString();
                        txtDiemChu.Text = null;
                        txtDiemThi.Text = diemThi.ToString();
                        txtLanThi.Text = null;
                        txtHocKi.Text = null;
                        txtSoTietNgi.Text = null;
                        cbMaL.Text = null;
                        cbMaSV.Text = null;
                        cbMH.Text = null;
                        //cbSearch.SelectedIndex = 0;
                    }
                    else
                    {
                        lbTg.ForeColor = Color.BlueViolet;
                        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                        this.lbTg.Text = "Tìm thấy: " + dgvDiem.Rows.Count.ToString() + " sinh Viên ";
                        bttNew.Enabled = false;
                        btThem.Enabled = false;
                        lbTg.Visible = false;

                    }
                }
                if (cbSearch.SelectedItem.ToString() == "Tất cả")
                {
                    dgvDiem.DataSource = d.getDiemByAll(key);
                    if (dgvDiem.Rows.Count == 0)
                    {
                        lbTg.Visible = true;
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " không tìm thấy";
                        txtDhs1.Text = diemHs1.ToString();
                        txtDhs2.Text = diemHS2.ToString();
                        txtDiemChu.Text = null;
                        txtDiemHocPhan.Text = null;
                        txtDTP.Text = diemTP.ToString();
                        txtDiemChu.Text = null;
                        txtDiemThi.Text = diemThi.ToString();
                        txtLanThi.Text = null;
                        txtHocKi.Text = null;
                        txtSoTietNgi.Text = null;
                        cbMaL.Text = null;
                        cbMaSV.Text = null;
                        cbMH.Text = null;
                 
                    }
                    else
                    {
                        lbTg.ForeColor = Color.BlueViolet;
                        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                        this.lbTg.Text = "Tìm thấy: " + dgvDiem.Rows.Count.ToString() + " sinh Viên ";
                        bttNew.Enabled = false;
                        btThem.Enabled = false;
                        lbTg.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" lỗi" +ex);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string key = txtSearch.Text.ToString().Trim();
            try
            {
                if (txtSearch.TextLength == 0 )
                {                                       
                    loadData();
                }
                if (cbSearch.SelectedItem.ToString() == "Mã lớp")
                {
                    dgvDiem.DataSource = d.getDiemByIdLop(key);
                    if (dgvDiem.Rows.Count == 0)
                    {
                        lbTg.Visible = true;
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " không tìm thấy";
                        txtDhs1.Text = diemHs1.ToString();
                        txtDhs2.Text = diemHS2.ToString();
                        txtDiemChu.Text = null;
                        txtDiemHocPhan.Text = null;
                        txtDTP.Text = diemTP.ToString();
                        txtDiemChu.Text = null;
                        txtDiemThi.Text = diemThi.ToString();
                        txtLanThi.Text = null;
                        txtHocKi.Text = null;
                        txtSoTietNgi.Text = null;
                        cbMaL.Text = null;
                        cbMaSV.Text = null;
                        cbMH.Text = null;                                        
                    }
                    else
                    {
                        lbTg.ForeColor = Color.BlueViolet;
                        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                        this.lbTg.Text = "Tìm thấy: " + dgvDiem.Rows.Count.ToString() + " sinh Viên ";
                        bttNew.Enabled = false;
                        btThem.Enabled = false;
                        lbTg.Visible = false;
                    }
                }
                if (cbSearch.SelectedItem.ToString() == "Mã sinh viên")
                {
                    dgvDiem.DataSource = d.getDiemByIdSV(key);
                    if (dgvDiem.Rows.Count == 0)
                    {
                        lbTg.Visible = true;
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " không tìm thấy";
                        txtDhs1.Text = diemHs1.ToString();
                        txtDhs2.Text = diemHS2.ToString();
                        txtDiemChu.Text = null;
                        txtDiemHocPhan.Text = null;
                        txtDTP.Text = diemTP.ToString();
                        txtDiemChu.Text = null;
                        txtDiemThi.Text = diemThi.ToString();
                        txtLanThi.Text = null;
                        txtHocKi.Text = null;
                        txtSoTietNgi.Text = null;
                        cbMaL.Text = null;
                        cbMaSV.Text = null;
                        cbMH.Text = null;                                        
                    }
                    else
                    {
                        lbTg.ForeColor = Color.BlueViolet;
                        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                        this.lbTg.Text = "Tìm thấy: " + dgvDiem.Rows.Count.ToString() + " sinh Viên ";
                        bttNew.Enabled = false;
                        btThem.Enabled = false;
                        lbTg.Visible = false;
                    }
                }
                if (cbSearch.SelectedItem.ToString() == "Tất cả")
                {
                    dgvDiem.DataSource = d.getDiemByAll(key);
                    if (dgvDiem.Rows.Count == 0)
                    {
                        lbTg.Visible = true;
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " không tìm thấy";
                        txtDhs1.Text = diemHs1.ToString();
                        txtDhs2.Text = diemHS2.ToString();
                        txtDiemChu.Text = null;
                        txtDiemHocPhan.Text = null;
                        txtDTP.Text = diemTP.ToString();
                        txtDiemChu.Text = null;
                        txtDiemThi.Text = diemThi.ToString();
                        txtLanThi.Text = null;
                        txtHocKi.Text = null;
                        txtSoTietNgi.Text = null;
                        cbMaL.Text = null;
                        cbMaSV.Text = null;
                        cbMH.Text = null;                   
                    }
                    else
                    {
                        lbTg.ForeColor = Color.BlueViolet;
                        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                        this.lbTg.Text = "Tìm thấy: " + dgvDiem.Rows.Count.ToString() + " sinh Viên ";
                        bttNew.Enabled = false;
                        btThem.Enabled = false;
                        lbTg.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" lỗi" + ex);
            }
        }
        private void Search()
        {
    
        }
        private void dgvDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
   
        }

        private void dgvDiem_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            this.cbMaSV.Text = dgvDiem.Rows[vt].Cells["colMaSV"].Value.ToString();
            this.cbMaL.Text = dgvDiem.Rows[vt].Cells["colMaLop"].Value.ToString();
            this.cbMH.Text = dgvDiem.Rows[vt].Cells["colMaMH"].Value.ToString();
            this.txtDhs1.Text = dgvDiem.Rows[vt].Cells["DiemQTHeS1"].Value.ToString();
            this.txtDhs2.Text = dgvDiem.Rows[vt].Cells["DiemQTHeS2"].Value.ToString();
            this.txtDTP.Text = dgvDiem.Rows[vt].Cells["colDiemHP"].Value.ToString();
            this.txtDiemThi.Text = dgvDiem.Rows[vt].Cells["colDiemThi"].Value.ToString();
            this.txtLanThi.Text = dgvDiem.Rows[vt].Cells["LanThi"].Value.ToString();
            this.txtDiemHocPhan.Text = dgvDiem.Rows[vt].Cells["DiemTBHP"].Value.ToString();
            this.txtDiemChu.Text = dgvDiem.Rows[vt].Cells["DiemChuTBHP"].Value.ToString();
            this.txtHocKi.Text = dgvDiem.Rows[vt].Cells["HocKi"].Value.ToString();
            this.txtSoTietNgi.Text = dgvDiem.Rows[vt].Cells["SoTietNghi"].Value.ToString();
            
           
            this.btSua.Enabled = true;
            this.btXoa.Enabled = true;
        }

        // lay MS theo ML
        private void cbMaL_SelectedValueChanged(object sender, EventArgs e)
        {
            string key = cbMaL.SelectedValue!=null?cbMaL.SelectedValue.ToString():string.Empty;
            cbMaSV.DataSource = d.getSVByMl(key);
            cbMaSV.ValueMember = "MaSV";
            cbMaSV.DisplayMember = "MaSV";
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            btThem.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btThem.Enabled = true;
            bttNew.Enabled = true;                                  
            Reset();
            loadCombo();
            loadData();
           
            

        }

        #region Set DTP, DHP
        private void txtDhs1_TextChanged(object sender, EventArgs e)
        {
            float Num;
            bool ktra = float.TryParse(txtDhs1.Text.Trim(), out Num);
            if (!ktra)
            {
                MessageBox.Show("hãy nhập số");
                txtDhs1.ResetText();
                txtDhs1.Focus();
                return;
            }
            if (txtDhs2!= null && txtDhs1!=null)
            {
                float diemheS1 =txtDhs1.Text == "" ? 0 : float.Parse(txtDhs1.Text);
                float diemheS2 = txtDhs2.Text == "" ? 0 : float.Parse(txtDhs2.Text);               
                float diemTP = (float)Math.Round((diemheS1 + diemheS2 * 2) / 3, 1);
                txtDTP.Text = diemTP.ToString();
            }
        }

        private void txtDhs2_TextChanged(object sender, EventArgs e)
        {
            float Num5;
            bool ktra5 = float.TryParse(txtDhs2.Text.Trim(), out Num5);
            if (!ktra5)
            {
                MessageBox.Show("hãy nhập số");
                txtDhs2.ResetText();
                txtDhs2.Focus();
                return;
            }          
            if (txtDhs2 != null && txtDhs1 != null)
            {
                float diemheS1 = txtDhs1.Text == "" ? 0 : float.Parse(txtDhs1.Text);
                float diemheS2 = txtDhs2.Text == "" ? 0 : float.Parse(txtDhs2.Text);
                float diemTP = (float)Math.Round((diemheS1 + diemheS2 * 2) / 3, 1);
                txtDTP.Text = diemTP.ToString();
            }
      
        }

        private void txtDiemThi_TextChanged(object sender, EventArgs e)
        {
            float Num1;
            bool ktra1 = float.TryParse(txtDiemThi.Text.Trim(), out Num1);
            if (!ktra1)
            {
                MessageBox.Show("hãy nhập số");
                txtDiemThi.ResetText();
                txtDiemThi.Focus();
                return;
            }
            if (txtDiemThi != null && txtDTP != null)
            {
                float diemTP = txtDTP.Text == "" ? 0 : float.Parse(txtDTP.Text);
                float diemThi = txtDiemThi.Text == "" ? 0 : float.Parse(txtDiemThi.Text);
                float diemHP = (float)Math.Round((diemTP * 3 + diemThi * 7) / 10, 1);
                txtDiemHocPhan.Text = diemHP.ToString();
            }
           
        }

        private void txtDTP_TextChanged(object sender, EventArgs e)
        {

            if (txtDiemThi != null && txtDTP != null)
            {
                float diemTP = txtDTP.Text == "" ? 0 : float.Parse(txtDTP.Text);
                float diemThi = txtDiemThi.Text == "" ? 0 : float.Parse(txtDiemThi.Text);
                float diemHP = (float)Math.Round((diemTP * 3 + diemThi * 7) / 10, 1);
                txtDiemHocPhan.Text = diemHP.ToString();
            }
            
        }

        private void txtDiemHocPhan_TextChanged(object sender, EventArgs e)
        {            
            if (txtDiemHocPhan.Text.ToString().Trim() != "" && txtDiemHocPhan != null)
            {
                float diemTP = txtDTP.Text == "" ? 0 : float.Parse(txtDTP.Text);
                float diemThi = txtDiemThi.Text == "" ? 0 : float.Parse(txtDiemThi.Text);
                float diemHP = (float)Math.Round((diemTP * 3 + diemThi * 7) / 10, 1);
                if (diemHP >= 9 && diemHP <= 10)
                {
                    txtDiemChu.Text = "A+";
                }
                if (diemHP >= 8.5 && diemHP <= 8.9)
                {
                    txtDiemChu.Text = "A";
                }
                if (diemHP >= 8.0 && diemHP <= 8.4)
                {
                    txtDiemChu.Text = "B+";
                }
                if (diemHP >= 7.0 && diemHP <= 7.9)
                {
                    txtDiemChu.Text = "B";
                }
                if (diemHP >= 6.5 && diemHP <= 6.9)
                {
                    txtDiemChu.Text = "C+";
                }
                if (diemHP >= 5.5 && diemHP <= 6.4)
                {
                    txtDiemChu.Text = "C";
                }
                if (diemHP >= 4.0 && diemHP <= 5.4)
                {
                    txtDiemChu.Text = "D";
                }
                if (diemHP < 4.0)
                {
                    txtDiemChu.Text = "F";
                }

            }
        }
        #endregion  
    }
}
