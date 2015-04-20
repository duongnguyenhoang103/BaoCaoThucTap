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
    public partial class UC_GiangVien : UserControl
    {
        GiaoVienBE gv = new GiaoVienBE();
        public UC_GiangVien()
        {
            InitializeComponent();
        }

        private void UC_GiangVien_Load(object sender, EventArgs e)
        {           
            loadCombobox();
            loadData();
            btThem.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void loadData()
        {
            dgvGV.DataSource = gv.ShowGV();
            lbTg.Text = "có tổng số: " + dgvGV.RowCount.ToString() + " giảng viên";
            lbTg.ForeColor = Color.BlueViolet;
            lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
        }

        private void loadCombobox()
        {
            cbSearch.SelectedIndex = 0; 
        }

        private void UC_GiangVien_DoubleClick(object sender, EventArgs e)
        {

        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            Reset();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMGV.TextLength == 0)
            {
                MessageBox.Show("bạn phải nhập mã giảng viên ");
                txtMGV.Focus();
                return;
            }
            if (txtTenGV.TextLength == 0)
            {
                MessageBox.Show("bạn phải nhập tên giảng viên ");
                txtTenGV.Focus();
                return;
            }
            else if (txtMGV.TextLength > 11)
            {
                MessageBox.Show(" Mã không vượt quá 10 kí tự");
                txtMGV.ResetText();
                return;
            }
            else
            {
                try
                {
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
                        gv.InsertGV(txtMGV.Text, txtTenGV.Text,txtDiaChi.Text ,cbGT.SelectedItem.ToString(), Int32.Parse(txtSDT.Text), txtEmail.Text);
                        MessageBox.Show("Thêm giảng viên " + this.txtMGV.Text + " thành công");
                        loadData();
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm giảng viên với mã " + this.txtMGV.Text + "không thành công vì đã tồn tại");
                    txtMGV.Focus();
                    txtMGV.Text = "";

                }
            }                   
        }

        private void btSua_Click(object sender, EventArgs e)
        {

            if (txtMGV.TextLength == 0)
            {
                MessageBox.Show("bạn phải nhập mã giảng viên ");
                txtMGV.Focus();
                return;
            }
            if (txtTenGV.TextLength == 0)
            {
                MessageBox.Show("bạn phải nhập tên giảng viên ");
                txtTenGV.Focus();
                return;
            }
            else if (txtMGV.TextLength > 11)
            {
                MessageBox.Show(" Mã không vượt quá 10 kí tự");
                txtMGV.ResetText();
                return;
            }
            else
            {
                try
                {
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
                        int vt = dgvGV.CurrentCell.RowIndex;
                        string madk = dgvGV.Rows[vt].Cells[0].Value.ToString();
                        gv.UpdateGV(madk, txtMGV.Text, txtTenGV.Text, txtDiaChi.Text, cbGT.SelectedItem.ToString(), Int32.Parse(txtSDT.Text), txtEmail.Text);
                        MessageBox.Show("Sửa giảng viên " + this.txtMGV.Text + " thành công");
                        loadData();
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa giảng viên với mã " + this.txtMGV.Text + "không thành công vì đã tồn tại");
                    txtMGV.Focus();
                    txtMGV.Text = "";

                }
            }
        }
        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMGV.TextLength == 0 || dgvGV.SelectedRows.Count < 0)
            {
                MessageBox.Show(" bạn phải chọn dữ liệu xóa ");
            }
            else
                if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn xóa giảng viên '" + txtTenGV.Text + "' với mã '" + txtMGV.Text + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string strMaKhoa = txtMGV.Text;
                    gv.DeleteGV(strMaKhoa);
                    MessageBox.Show("Xóa giảng viên có tên là :" + this.txtTenGV.Text + " !!! thành công");
                    loadData();


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
                if (cbSearch.SelectedItem.ToString() == "Mã giảng viên")
                {
                    dgvGV.DataSource = gv.GetGVByMaGV(key);
                    if (dgvGV.Rows.Count == 0)
                    {
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " không tìm thấy";
                        txtDiaChi.Text = "";
                        txtEmail.Text = "";
                        txtMGV.Text = "";
                        txtSDT.Text = "";
                        txtTenGV.Text = ""; ;
                    }
                    else
                    {
                        lbTg.ForeColor = Color.BlueViolet;
                        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                        this.lbTg.Text = " Có tổng số : " + dgvGV.Rows.Count.ToString() + " giảng viên ";
                    }
                }
                else
                    if (cbSearch.SelectedItem.ToString() == "Tên giảng viên")
                    {
                        dgvGV.DataSource = gv.GetgvByTenGV(key);

                        if (dgvGV.Rows.Count == 0)
                        {
                            this.lbTg.ForeColor = Color.Red;
                            this.lbTg.Text = " không tìm thấy";
                            txtDiaChi.Text = "";
                            txtEmail.Text = "";
                            txtMGV.Text = "";
                            txtSDT.Text = "";
                            txtTenGV.Text = "";
                        }
                        else
                        {
                            lbTg.ForeColor = Color.BlueViolet;
                            lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                            this.lbTg.Text = " Có tổng số : " + dgvGV.Rows.Count.ToString() + " giảng viên ";
                        }
                    }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(" ban phai chon kieu tim kiem");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string key = txtSearch.Text.ToString().Trim();
            try
            {
                if (txtSearch.TextLength == 0)
                {
                    loadData();
                }
                if (cbSearch.SelectedItem.ToString() == "Mã giảng viên")
                {
                    dgvGV.DataSource = gv.GetGVByIdGV(key);
                    if (dgvGV.Rows.Count == 0)
                    {
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " không tìm thấy";
                        txtDiaChi.Text = "";
                        txtEmail.Text = "";
                        txtMGV.Text = "";
                        txtSDT.Text = "";
                        txtTenGV.Text = ""; ;
                    }
                    else
                    {
                        lbTg.ForeColor = Color.BlueViolet;
                        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                        this.lbTg.Text = " Có tổng số : " + dgvGV.Rows.Count.ToString() + " giảng viên ";
                    }
                }
                else
                    if (cbSearch.SelectedItem.ToString() == "Tên giảng viên")
                    {
                        dgvGV.DataSource = gv.GetgvByNameGV(key);

                        if (dgvGV.Rows.Count == 0)
                        {
                            this.lbTg.ForeColor = Color.Red;
                            this.lbTg.Text = " không tìm thấy";
                            txtDiaChi.Text = "";
                            txtEmail.Text = "";
                            txtMGV.Text = "";
                            txtSDT.Text = "";
                            txtTenGV.Text = "";
                        }
                        else
                        {
                            lbTg.ForeColor = Color.BlueViolet;
                            lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                            this.lbTg.Text = " Có tổng số : " + dgvGV.Rows.Count.ToString() + " giảng viên ";
                        }
                    }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(" ban phai chon kieu tim kiem");
            }
        }

        private void dgvGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            txtMGV.Text = dgvGV.Rows[vt].Cells[0].Value.ToString();
            txtTenGV.Text = dgvGV.Rows[vt].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvGV.Rows[vt].Cells[2].Value.ToString();
            cbGT.Text = dgvGV.Rows[vt].Cells[3].Value.ToString();
            txtSDT.Text = dgvGV.Rows[vt].Cells[4].Value.ToString();
            txtEmail.Text = dgvGV.Rows[vt].Cells[5].Value.ToString();
            btSua.Enabled = true;
            btXoa.Enabled = true;
           // bttNew.Enabled = false;
        }
        private void dgvGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private void btReset_Click(object sender, EventArgs e)
        {
            btThem.Enabled = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            bttNew.Enabled = true;
            Reset();
            loadData();
            txtSearch.ResetText();
        }

        private void Reset()
        {
            txtMGV.Text = null;
            txtTenGV.Text = null;
            txtDiaChi.Text = null;
            cbGT.Text = null;
            txtSDT.Text = null;
            txtEmail.Text = null;
        }

       
    }
}
