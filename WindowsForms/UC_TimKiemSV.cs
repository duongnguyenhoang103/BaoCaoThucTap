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
    public partial class UC_TimKiemSV : UserControl
    {
        public UC_TimKiemSV()
        {
            InitializeComponent();
        }
        LopBE lp = new LopBE();
        SinhVienBE sv = new SinhVienBE();
        TimKiemSV_BE tkSV = new TimKiemSV_BE();
        private void UC_TimKiemSV_Load(object sender, EventArgs e)
        {

            loadComBo();
            cbML.ResetText();
            cbML.SelectedIndex = -1;
            cbMaSV.ResetText();
            cbMaSV.SelectedIndex = -1;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            lbTg.Visible = false;
        }

        private void loadComBo()
        {
            // load cbMalop
            cbML.DataSource = lp.ShowLop();
            cbML.DisplayMember = "MaLop";
            cbML.ValueMember = "MaLop";
            // load colum Malop tren dgv  
            colMaLop.DataSource = lp.ShowLop();
            colMaLop.DisplayMember = "TenLop";
            colMaLop.ValueMember = "MaLop";
        }

        private void cbML_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            // load colum Malop tren dgv  
            colMaLop.DataSource = lp.ShowLop();
            colMaLop.DisplayMember = "TenLop";
            colMaLop.ValueMember = "MaLop";

            string keyML = cbML.Text;
            string keyMaSV = cbMaSV.Text;
            if (keyML!= ""&& keyMaSV == "")
            {
                dgvSV.DataSource = tkSV.GetSVByIdMaLop(keyML);
                if (dgvSV.Rows.Count > 0)
                {
                    lbTg.Visible = true;
                     lbTg.Text = "có tổng số: " + dgvSV.RowCount.ToString() + " sinh viên";
                     lbTg.ForeColor = Color.BlueViolet;
                     lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                }
                else
                {
                    lbTg.Visible = true;
                     this.lbTg.ForeColor = Color.Red;
                     this.lbTg.Text = " không tìm thấy";
                }
            }
            if (keyML != "" && keyMaSV != "")
            {
                dgvSV.DataSource = tkSV.GetSV(keyML,keyMaSV);
                if (dgvSV.Rows.Count > 0)
                {
                    lbTg.Visible = true;
                    lbTg.Text = "có tổng số: " + dgvSV.RowCount.ToString() + " sinh viên";
                    lbTg.ForeColor = Color.BlueViolet;
                    lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                }
                else
                {
                    lbTg.Visible = true;
                    this.lbTg.ForeColor = Color.Red;
                    this.lbTg.Text = " không tìm thấy";
                }
            }
        }

        private void cbML_SelectedValueChanged(object sender, EventArgs e)
        {
            string key = cbML.SelectedValue != null ? cbML.SelectedValue.ToString() : string.Empty;
            cbMaSV.DataSource = sv.GetSVByIdMaLop(key);
            cbMaSV.ValueMember = "MaSV";
            cbMaSV.DisplayMember = "MaSV";

            cbMaSV.ResetText();
            cbMaSV.SelectedIndex = -1;
        }

        private void cbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvSV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int vt = dgvSV.CurrentCell.RowIndex;
            cbMaSV.Text = dgvSV.Rows[vt].Cells["MaSV"].Value.ToString();
            txtSinhVien.Text = dgvSV.Rows[vt].Cells["TenSV"].Value.ToString();
            cbGT.Text = dgvSV.Rows[vt].Cells["GioiTinh"].Value.ToString();
            txtSDT.Text = dgvSV.Rows[vt].Cells["SDT"].Value.ToString();
            txtDiaChi.Text = dgvSV.Rows[vt].Cells["DiaChi"].Value.ToString();
            txtEmail.Text = dgvSV.Rows[vt].Cells["Email"].Value.ToString();
            dtPickerNgaySinh.Text = dgvSV.Rows[vt].Cells["NgaySinh"].Value.ToString();
            cbML.Text = dgvSV.Rows[vt].Cells["colMaLop"].Value.ToString();
            btSua.Enabled = true;
            btXoa.Enabled = true;
        }
        private void dgvSV_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btReset_Click(object sender, EventArgs e)
        {
           
            btSua.Enabled = false;
            btXoa.Enabled = false;
            cbML.ResetText();
            cbML.SelectedIndex = -1;
            cbMaSV.ResetText();
            cbMaSV.SelectedIndex = -1;
            cbML.Text = "";
         
            cbGT.Text = null;
          
            txtSinhVien.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";

            loadData();
            lbTg.Visible = false;
        }

        private void cbML_MouseClick(object sender, MouseEventArgs e)
        {
            loadComBo();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn xóa sinh viên '" + txtSinhVien.Text + "' với mã '" + cbMaSV.Text + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {

                string strMaSV = cbMaSV.Text;
                sv.DeleteSV(strMaSV);
                MessageBox.Show("Xóa sinh viên có tên là :  " + this.txtSinhVien.Text + " thành công");
                string keyML = cbML.Text;
                string keyMaSV = cbMaSV.Text;
                if (keyML != "" && keyMaSV != "")
                {
                    dgvSV.DataSource = tkSV.GetSVByIdMaLop(keyML);
                    if (dgvSV.Rows.Count > 0)
                    {
                        lbTg.Visible = true;
                        lbTg.Text = "có tổng số: " + dgvSV.RowCount.ToString() + " sinh viên";
                        lbTg.ForeColor = Color.BlueViolet;
                        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                    }
                    else
                    {
                        lbTg.Visible = true;
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " không tìm thấy";
                    }
                }
                Reset();
            }
        }

        private void Reset()
        {
            btSua.Enabled = false; 
            btXoa.Enabled = false;         
            cbMaSV.ResetText();
            cbMaSV.SelectedIndex = -1;
            cbMaSV.Text = "";
            cbGT.Text = null;
            txtSinhVien.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            dtPickerNgaySinh.Text = null;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn sửa sinh viên '" + txtSinhVien.Text + "' với mã '" + cbMaSV.Text + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    if (txtSDT.TextLength == 0 || txtSinhVien.TextLength == 0)
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
                        sv.UpdateSV(madk, cbMaSV.SelectedValue.ToString(), txtSinhVien.Text.Trim(), cbGT.SelectedItem.ToString().Trim(),
                                    Int32.Parse(txtSDT.Text.Trim()), txtDiaChi.Text.Trim(), txtEmail.Text.Trim(), dtPickerNgaySinh.Value, cbML.SelectedValue.ToString().Trim());
                        MessageBox.Show(" sửa sinh viên " + txtSinhVien.Text + " có mã " + cbMaSV.Text + " !!! thành công  ");
                        loadData();
                        Reset();
                    }
                }
                else
                {
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("đã tồn tại mã sinh viên " + cbMaSV.Text + " này !!! Hãy nhập mã mới ");            
                return;
            }                       
        }


    }
}
