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
    public partial class UC_SinhVien : UserControl
    {
        LopBE lp = new LopBE();
        SinhVienBE sv = new SinhVienBE();
        public UC_SinhVien()
        {
            InitializeComponent();
        }

        private void loadCombox()
        {
            cbSearch.SelectedIndex = 0;
            cbSearch.DropDownStyle= System.Windows.Forms.ComboBoxStyle.DropDownList;
            // load cbMalop
            cbMaL.DataSource = lp.ShowLop();
            cbMaL.DisplayMember = "MaLop";
            cbMaL.ValueMember = "MaLop";
            // load colum Malop tren dgv  
            colMaLop.DataSource = lp.ShowLop();
            colMaLop.DisplayMember = "TenLop";
            colMaLop.ValueMember = "MaLop";
        }

        private void loadData()
        {
            dgvSV.DataSource = sv.GetAllSV();
            lbTg.Text = "có tổng số: " + dgvSV.RowCount.ToString() + " sinh viên";
            lbTg.ForeColor = Color.BlueViolet;
            lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
        }
        private void UC_SinhVien_Load(object sender, EventArgs e)
        {
            cbSearch.SelectedIndex = 0;
                    
            loadCombox();
            loadData();
            btThem.Enabled = false;
        }

        private void Reset()
        {
            txtMSV.Text = "";
            cbGT.Text = null;
            cbMaL.Text = null;
            txtSinhVien.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
          
            //bt
            btThem.Enabled = false;
        }
        private void dgvSV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int vt= e.RowIndex;

                txtMSV.Text = dgvSV.Rows[vt].Cells["MaSV"].Value.ToString();
                txtSinhVien.Text = dgvSV.Rows[vt].Cells["TenSV"].Value.ToString();
                cbGT.Text = dgvSV.Rows[vt].Cells["GioiTinh"].Value.ToString();
                txtSDT.Text = dgvSV.Rows[vt].Cells["SDT"].Value.ToString();
                txtDiaChi.Text = dgvSV.Rows[vt].Cells["DiaChi"].Value.ToString();
                txtEmail.Text = dgvSV.Rows[vt].Cells["Email"].Value.ToString();
                dtPickerNgaySinh.Text = dgvSV.Rows[vt].Cells["NgaySinh"].Value.ToString();
                cbMaL.Text = dgvSV.Rows[vt].Cells["colMaLop"].Value.ToString();

            
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
           
            txtSearch.Text = "";
            loadData();
            Reset();
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
           // dtPickerNgaySinh.Text = DateTime.Today.ToString();

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {
                string key = cbMaL.SelectedValue != null ?  cbMaL.SelectedValue.ToString() : string.Empty;
                if (key.ToString()==null || key.ToString() == "")
                {
                    MessageBox.Show(" bạn phải chọn lớp");
                    cbMaL.Focus();
                    return;
                }

                if (txtSDT.TextLength == 0 || txtMSV.TextLength == 0 || txtSinhVien.TextLength == 0)
                {
                    MessageBox.Show(" bạn phải nhập đầy đủ thông tin");
                    return;
                }
                int Num;
                bool ktra = int.TryParse(txtSDT.Text.Trim(), out Num);
                if (!ktra)
                {
                    MessageBox.Show("hãy nhập số");
                    txtSDT.ResetText();
                    txtSDT.Focus();
                    return;
                }
                else if (txtMSV.TextLength > 11)
                {
                    MessageBox.Show(" Mã không vượt quá 10 kí tự");
                    txtMSV.ResetText();
                    return;
                }
                else
                {
                    sv.InsertSV(txtMSV.Text.Trim(), txtSinhVien.Text.Trim(), cbGT.SelectedItem.ToString().Trim(),
                                Int32.Parse(txtSDT.Text.Trim()), txtDiaChi.Text.Trim(), txtEmail.Text.Trim(), dtPickerNgaySinh.Value, cbMaL.SelectedValue.ToString().Trim());
                    MessageBox.Show(" thêm sinh viên " + txtSinhVien.Text + " có mã " + txtMSV.Text + " !!! thành công  ");
                    loadData();
                    btThem.Enabled = false;
                    btSua.Enabled = true;
                    btXoa.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("đã tồn tại mã sinh viên " + txtMSV.Text + " này !!! Hãy nhập mã mới ");
                txtMSV.ResetText();
                txtMSV.Focus();
                return;
            }                       
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMSV.TextLength == 0 || dgvSV.SelectedRows.Count < 0)
            {
                MessageBox.Show(" bạn phải chọn dữ liệu xóa ");
            }
            else
                if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn xóa sinh viên '" + txtSinhVien.Text + "' với mã '" + txtMSV.Text + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                   
                    string strMaSV = txtMSV.Text;
                    sv.DeleteSV(strMaSV);                    
                    MessageBox.Show("Xóa sinh viên có tên là :  " + this.txtSinhVien.Text + " thành công");
                    loadData();
                    btThem.Enabled = false;
                    btSua.Enabled = true;
                    btXoa.Enabled = true;
                }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn sửa sinh viên '" + txtSinhVien.Text + "' với mã '" + txtMSV.Text + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (txtSDT.TextLength == 0 || txtMSV.TextLength == 0 || txtSinhVien.TextLength == 0)
                    {
                        MessageBox.Show(" bạn phải nhập đầy đủ thông tin");
                        return;
                    }
                    int Num;
                    bool ktra = int.TryParse(txtSDT.Text.Trim(), out Num);
                    if (!ktra)
                    {
                        MessageBox.Show("hãy nhập số");
                        txtSDT.ResetText();
                        txtSDT.Focus();
                        return;
                    }
                    else
                    {
                        int vt = dgvSV.CurrentRow.Index;
                        string madk = dgvSV.Rows[vt].Cells["MaSV"].Value.ToString().Trim();
                        sv.UpdateSV(madk, txtMSV.Text.Trim(), txtSinhVien.Text.Trim(), cbGT.SelectedItem.ToString().Trim(),
                                    Int32.Parse(txtSDT.Text.Trim()), txtDiaChi.Text.Trim(), txtEmail.Text.Trim(), dtPickerNgaySinh.Value, cbMaL.SelectedValue.ToString().Trim());
                        MessageBox.Show(" sửa sinh viên " + txtSinhVien.Text + " có mã " + txtMSV.Text + " !!! thành công  ");
                        loadData();
                        btThem.Enabled = false;
                        btSua.Enabled = true;
                        btXoa.Enabled = true;
                    }
                }
                else
                {
                    return;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("đã tồn tại mã sinh viên " + txtMSV.Text + " này !!! Hãy nhập mã mới ");
                txtMSV.ResetText();
                txtMSV.Focus();
                return;
            }                       
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string key = txtSearch.Text.ToString().Trim();
            try
            {
                if (cbSearch.SelectedItem.ToString() == "")
                {
                    loadData();
                }
                if (cbSearch.SelectedItem.ToString() == "Mã lớp")
                {
                    dgvSV.DataSource = sv.GetSVByIdMaLop(key);
                    if (dgvSV.Rows.Count == 0)
                    {
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " không tìm thấy";
                        txtMSV.Text = "";
                        txtSinhVien.Text = "";
                        txtSDT.Text = "";
                        txtDiaChi.Text = "";
                        txtEmail.Text = "";    
                    }
                    else
                    {
                        lbTg.ForeColor = Color.BlueViolet;
                        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                        this.lbTg.Text = " Có tổng số : " + dgvSV.Rows.Count.ToString() + " Sinh Viên ";
                    }
                }
                else
                    if (cbSearch.SelectedItem.ToString() == "Tên lớp")
                    {
                        dgvSV.DataSource = sv.GetSVByIdTenLop(key);

                        if (dgvSV.Rows.Count == 0)
                        {
                            this.lbTg.ForeColor = Color.Red;
                            this.lbTg.Text = " không tìm thấy";
                            txtMSV.Text = "";
                            txtSinhVien.Text = "";
                            txtSDT.Text = "";
                        }
                        else
                        {
                            lbTg.ForeColor = Color.BlueViolet;
                            lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                            this.lbTg.Text = " Có tổng số : " + dgvSV.Rows.Count.ToString() + " Sinh Viên ";
                        }
                    }
                    else
                        if (cbSearch.SelectedItem.ToString() == "Mã sinh viên")
                        {
                            dgvSV.DataSource = sv.GetSVByIdMaSv(key);

                            if (dgvSV.Rows.Count == 0)
                            {
                                this.lbTg.ForeColor = Color.Red;
                                this.lbTg.Text = " không tìm thấy";
                                txtMSV.Text = "";
                                txtSinhVien.Text = "";
                                txtSDT.Text = "";
                            }
                            else
                            {
                                lbTg.ForeColor = Color.BlueViolet;
                                this.lbTg.Text = " Có tổng số : " + dgvSV.Rows.Count.ToString() + " Sinh Viên ";
                            }
                        }
                        else
                            if (cbSearch.SelectedItem.ToString() == "Tên sinh viên")
                            {
                                dgvSV.DataSource = sv.GetSVByName(key);

                                if (dgvSV.Rows.Count == 0)
                                {
                                    this.lbTg.ForeColor = Color.Red;
                                    this.lbTg.Text = " không tìm thấy";
                                    txtMSV.Text = "";
                                    txtSinhVien.Text = "";
                                    txtSDT.Text = "";
                                }
                                else
                                {
                                    lbTg.ForeColor = Color.BlueViolet;
                                    lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                                    this.lbTg.Text = " Có tổng số : " + dgvSV.Rows.Count.ToString() + " Sinh Viên ";
                                }
                            }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(" ban phai chon kieu tim kiem");
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
                    dgvSV.DataSource = sv.GetSVByMaLopId(key);
                    if (dgvSV.Rows.Count == 0)
                    {
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " không tìm thấy";
                        txtMSV.Text = "";
                        txtSinhVien.Text = "";
                        txtSDT.Text = "";
                        txtDiaChi.Text = "";
                        txtEmail.Text = "";
                    }
                    else
                    {
                        lbTg.ForeColor = Color.BlueViolet;
                        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                        this.lbTg.Text = " Có tổng số : " + dgvSV.Rows.Count.ToString() + " Sinh Viên ";
                    }
                }
                else
                    if (cbSearch.SelectedItem.ToString() == "Tên lớp")
                    {
                        dgvSV.DataSource = sv.GetSVByIdTenLop(key);

                        if (dgvSV.Rows.Count == 0)
                        {
                            this.lbTg.ForeColor = Color.Red;
                            this.lbTg.Text = " không tìm thấy";
                            txtMSV.Text = "";
                            txtSinhVien.Text = "";
                            txtSDT.Text = "";
                        }
                        else
                        {
                            lbTg.ForeColor = Color.BlueViolet;
                            lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                            this.lbTg.Text = " Có tổng số : " + dgvSV.Rows.Count.ToString() + " Sinh Viên ";
                        }
                    }
                    else
                        if (cbSearch.SelectedItem.ToString() == "Mã sinh viên")
                        {
                            dgvSV.DataSource = sv.GetSVByIdMaSv(key);

                            if (dgvSV.Rows.Count == 0)
                            {
                                this.lbTg.ForeColor = Color.Red;
                                this.lbTg.Text = " không tìm thấy";
                                txtMSV.Text = "";
                                txtSinhVien.Text = "";
                                txtSDT.Text = "";
                            }
                            else
                            {
                                lbTg.ForeColor = Color.BlueViolet;
                                lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                                this.lbTg.Text = " Có tổng số : " + dgvSV.Rows.Count.ToString() + " Sinh Viên ";
                            }
                        }
                        else
                            if (cbSearch.SelectedItem.ToString() == "Tên sinh viên")
                            {
                                dgvSV.DataSource = sv.GetSVByName(key);

                                if (dgvSV.Rows.Count == 0)
                                {
                                    this.lbTg.ForeColor = Color.Red;
                                    this.lbTg.Text = " không tìm thấy";
                                    txtMSV.Text = "";
                                    txtSinhVien.Text = "";
                                    txtSDT.Text = "";
                                }
                                else
                                {
                                    lbTg.ForeColor = Color.BlueViolet;
                                    lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                                    this.lbTg.Text = " Có tổng số : " + dgvSV.Rows.Count.ToString() + " Sinh Viên ";
                                }
                            }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(" ban phai chon kieu tim kiem");
            }
        }

        private void cbMaL_MouseClick(object sender, MouseEventArgs e)
        {
            loadCombox();
        }

        private void panel4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadData();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            loadCombox();
            loadData();
            txtSearch.ResetText();
            btThem.Enabled = false;
            btSua.Enabled = true;
            btXoa.Enabled = true;
         
        }

        
    }
}
