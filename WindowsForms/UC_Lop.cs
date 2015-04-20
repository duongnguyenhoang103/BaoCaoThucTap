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
    public partial class UC_Lop : UserControl
    {
        public UC_Lop()
        {
            InitializeComponent();
        }
        LopBE lp = new LopBE();
        NghanhBE nghanh = new NghanhBE();

        private void cbMaNghanh_SelectedIndexChanged(object sender, EventArgs e)
        {

            loadData();
        }
        public void loadData()
        {
            //load colMaNganh tren dgv
            colMaNghanh.DataSource = nghanh.ShowNghanh();
            colMaNghanh.DisplayMember = "TenNghanh";
            colMaNghanh.ValueMember = "MaNghanh";
           // dgvLop.DataSource = lp.ShowLop(); 
            string key = cbMaNghanh.Text;
            dgvLop.DataSource = lp.ShowLopByNghanh(key);
            if (dgvLop.Rows.Count >0)
            {
                this.lbTong.Text = " Có tổng số : " + dgvLop.Rows.Count.ToString() + " lớp ";
                lbTong.ForeColor = Color.BlueViolet;
                lbTong.Font = new Font(lbTong.Font, FontStyle.Italic);
                lbTong.Visible = true;
            }
            else
            {
                lbTong.Visible = false;
            }
        }
        public void loadCombox()
        {
            cbSearch.SelectedIndex = 0; 
            // load combox MaNghanh
            cbMaNghanh.DataSource = nghanh.ShowNghanh();
            cbMaNghanh.DisplayMember = "MaNghanh";
            cbMaNghanh.ValueMember = "MaNghanh";
            //load colMaNganh tren dgv
            colMaNghanh.DataSource = nghanh.ShowNghanh();
            colMaNghanh.DisplayMember = "TenNghanh";
            colMaNghanh.ValueMember = "MaNghanh";
           
        }
        private void UC_Lop_Load(object sender, EventArgs e)
        {
            loadCombox();
            cbMaNghanh.SelectedIndex = -1;
            cbMaNghanh.ResetText();
            btSua.Enabled = false;
            btXoa.Enabled = false;
            bttNew.Visible = false;

           
           // Reset();
        }

        private void UC_Lop_DoubleClick(object sender, EventArgs e)
        {

        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            //txtKhoaHoc.Text = "";
            //txtML.Text = "";
            //txtTL.Text = "";
            //txtSoSV.Text = "";
            //btThem.Enabled = true;
            //btSua.Enabled = false;
            //btXoa.Enabled = false;

        }
        private void dgvLop_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int dong = e.RowIndex;
            this.txtML.Text = dgvLop.Rows[dong].Cells["MaLop"].Value.ToString();
            this.txtTL.Text = dgvLop.Rows[dong].Cells["TenLop"].Value.ToString();
            this.txtSoSV.Text = dgvLop.Rows[dong].Cells["SoSV"].Value.ToString();
            this.cbMaNghanh.SelectedValue = dgvLop.Rows[dong].Cells["colMaNghanh"].Value.ToString();
            this.txtKhoaHoc.Text = dgvLop.Rows[dong].Cells["KhoaHoc"].Value.ToString();       
            btThem.Enabled = false;
            btSua.Enabled = true;
            btXoa.Enabled = true;
            cbMaNghanh.Enabled = false;
        }
        private void dgvLop_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            if (txtML.TextLength == 0 || txtTL.TextLength == 0)
            {
                MessageBox.Show(" bạn phải nhập đầy đủ thông tin");
                return;
            }
            else if (txtML.TextLength > 11)
            {
                MessageBox.Show(" Mã không vượt quá 11 kí tự");
                txtML.ResetText();
                return;
            }
            else
            {
                try
                {
                    lp.InsertLop(this.txtML.Text.Trim(), this.txtTL.Text.Trim(), Int32.Parse(txtSoSV.Text), cbMaNghanh.SelectedValue.ToString(), txtKhoaHoc.Text);
                    MessageBox.Show("Thêm mã lớp " + this.txtML.Text + " thành công");
                  //  loadData();
                    Reset();
                }
                catch
                {
                    MessageBox.Show("Thêm mã lớp " + this.txtML.Text + " không thành công vì đã tồn tại");
                    txtML.Focus();
                    txtML.Text = "";

                }
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtML.TextLength == 0 || txtTL.TextLength == 0)
                {
                    MessageBox.Show(" bạn phải chọn 1 thông tin dữ liệu nào đó để sửa");
                    return;
                }

                if (txtML.TextLength > 11)
                {
                    MessageBox.Show(" Mã không vượt quá 11 kí tự");
                    txtML.ResetText();
                    return;
                }
                else
                    if (DialogResult.Yes == MessageBox.Show("bạn có muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        int r = dgvLop.CurrentCell.RowIndex;
                        string strmadk = dgvLop.Rows[r].Cells["MaLop"].Value.ToString();
                        lp.UpdateLop(strmadk, this.txtML.Text.Trim(), this.txtTL.Text.Trim(), Int32.Parse(txtSoSV.Text), cbMaNghanh.SelectedValue.ToString(), txtKhoaHoc.Text);
                        MessageBox.Show(" Bạn đã sửa thành công");
                        loadData();                       
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi" + ex.Message);
            }

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtML.TextLength == 0)
            {
                MessageBox.Show(" bạn phải chọn dữ liệu để xóa ");
            }
            else
                if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn xóa lớp '" + txtTL.Text + "' voi ma '" + txtML.Text + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                   
                    int r = dgvLop.CurrentCell.RowIndex;
                    string strMaLop = dgvLop.Rows[r].Cells["MaLop"].Value.ToString();
                    lp.DeleteLop(strMaLop);
                    MessageBox.Show("Xóa mã lớp " + this.txtML.Text + " thành công");
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
                if (cbSearch.SelectedItem.ToString() == "Mã lớp")
                {
                    dgvLop.DataSource = lp.SearchLopByMaL(key);
                    if (dgvLop.Rows.Count == 0)
                    {
                        this.lbTong.ForeColor = Color.Red;
                        this.lbTong.Text = " không tìm thấy";
                        txtML.Text = "";
                        txtKhoaHoc.Text = "";
                        txtML.Text = "";
                        txtTL.Text = "";
                        txtSoSV.Text = "";
                    }
                    else
                    {
                        lbTong.ForeColor = Color.BlueViolet;
                        lbTong.Font = new Font(lbTong.Font, FontStyle.Italic);
                        this.lbTong.Text = " Có tổng số : " + dgvLop.Rows.Count.ToString() + " Sinh Viên ";
                        lbTong.Visible = true;
                    }
                }
                else
                    if (cbSearch.SelectedItem.ToString() == "Tên lớp")
                    {
                        dgvLop.DataSource = lp.SearchLopByTenL(key);

                        if (dgvLop.Rows.Count == 0)
                        {
                            this.lbTong.ForeColor = Color.Red;
                            this.lbTong.Text = " không tìm thấy";
                            txtML.Text = "";
                            txtKhoaHoc.Text = "";
                            txtML.Text = "";
                            txtTL.Text = "";
                            txtSoSV.Text = "";
                        }
                        else
                        {
                            lbTong.ForeColor = Color.BlueViolet;
                            lbTong.Font = new Font(lbTong.Font, FontStyle.Italic);
                            this.lbTong.Text = " Có tổng số : " + dgvLop.Rows.Count.ToString() + " Sinh Viên ";
                            lbTong.Visible = true;
                        }
                    }
                    else
                        if (cbSearch.SelectedItem.ToString() == "Mã nghành")
                        {
                            dgvLop.DataSource = lp.SearchLopByMaNghanh(key);

                            if (dgvLop.Rows.Count == 0)
                            {
                                this.lbTong.ForeColor = Color.Red;
                                this.lbTong.Text = " không tìm thấy";
                                txtML.Text = "";
                                txtKhoaHoc.Text = "";
                                txtML.Text = "";
                                txtTL.Text = "";
                                txtSoSV.Text = "";
                            }
                            else
                            {
                                lbTong.ForeColor = Color.BlueViolet;
                                lbTong.Font = new Font(lbTong.Font, FontStyle.Italic);
                                this.lbTong.Text = " Có tổng số : " + dgvLop.Rows.Count.ToString() + " Sinh Viên ";
                                lbTong.Visible = true;
                            }
                        }
                        else
                            if (cbSearch.SelectedItem.ToString() == "Tên sinh viên")
                            {
                                dgvLop.DataSource = lp.SearchLopByTenNghanh(key);

                                if (dgvLop.Rows.Count == 0)
                                {
                                    this.lbTong.ForeColor = Color.Red;
                                    this.lbTong.Text = " không tìm thấy";
                                    txtML.Text = "";
                                    txtKhoaHoc.Text = "";
                                    txtML.Text = "";
                                    txtTL.Text = "";
                                    txtSoSV.Text = "";
                                }
                                else
                                {
                                    lbTong.ForeColor = Color.BlueViolet;
                                    lbTong.Font = new Font(lbTong.Font, FontStyle.Italic);
                                    this.lbTong.Text = " Có tổng số : " + dgvLop.Rows.Count.ToString() + " Sinh Viên ";
                                    lbTong.Visible = true;
                                }
                            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(""+ex);
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
                if (cbSearch.SelectedItem.ToString() == "Mã lớp")
                {
                    dgvLop.DataSource = lp.SearchLopByIdMaL(key);
                    if (dgvLop.Rows.Count == 0)
                    {
                        this.lbTong.ForeColor = Color.Red;
                        this.lbTong.Text = " không tìm thấy";
                        txtML.Text = "";
                        txtKhoaHoc.Text = "";
                        txtML.Text = "";
                        txtTL.Text = "";
                        txtSoSV.Text = "";
                    }
                    else
                    {
                        lbTong.ForeColor = Color.BlueViolet;
                        lbTong.Font = new Font(lbTong.Font, FontStyle.Italic);
                        this.lbTong.Text = " Có tổng số : " + dgvLop.Rows.Count.ToString() + " Sinh Viên ";
                        lbTong.Visible = true;
                    }
                }
                else
                    if (cbSearch.SelectedItem.ToString() == "Tên lớp")
                    {
                        dgvLop.DataSource = lp.SearchLopByNameMaL(key);

                        if (dgvLop.Rows.Count == 0)
                        {
                            this.lbTong.ForeColor = Color.Red;
                            this.lbTong.Text = " không tìm thấy";
                            txtML.Text = "";
                            txtKhoaHoc.Text = "";
                            txtML.Text = "";
                            txtTL.Text = "";
                            txtSoSV.Text = "";
                        }
                        else
                        {
                            lbTong.ForeColor = Color.BlueViolet;
                            lbTong.Font = new Font(lbTong.Font, FontStyle.Italic);
                            this.lbTong.Text = " Có tổng số : " + dgvLop.Rows.Count.ToString() + " Sinh Viên ";
                            lbTong.Visible = true;
                        }
                    }
                    else
                        if (cbSearch.SelectedItem.ToString() == "Mã nghành")
                        {
                            dgvLop.DataSource = lp.SearchLopByIdNghanh(key);

                            if (dgvLop.Rows.Count == 0)
                            {
                                this.lbTong.ForeColor = Color.Red;
                                this.lbTong.Text = " không tìm thấy";
                                txtML.Text = "";
                                txtKhoaHoc.Text = "";
                                txtML.Text = "";
                                txtTL.Text = "";
                                txtSoSV.Text = "";
                            }
                            else
                            {
                                lbTong.ForeColor = Color.BlueViolet;
                                lbTong.Font = new Font(lbTong.Font, FontStyle.Italic);
                                this.lbTong.Text = " Có tổng số : " + dgvLop.Rows.Count.ToString() + " Sinh Viên ";
                                lbTong.Visible = true;
                            }
                        }
                        else
                            if (cbSearch.SelectedItem.ToString() == "Tên sinh viên")
                            {
                                dgvLop.DataSource = lp.SearchLopByNameNghanh(key);

                                if (dgvLop.Rows.Count == 0)
                                {
                                    this.lbTong.ForeColor = Color.Red;
                                    this.lbTong.Text = " không tìm thấy";
                                    txtML.Text = "";
                                    txtKhoaHoc.Text = "";
                                    txtML.Text = "";
                                    txtTL.Text = "";
                                    txtSoSV.Text = "";
                                }
                                else
                                {
                                    lbTong.ForeColor = Color.BlueViolet;
                                    lbTong.Font = new Font(lbTong.Font, FontStyle.Italic);
                                    this.lbTong.Text = " Có tổng số : " + dgvLop.Rows.Count.ToString() + " Sinh Viên ";
                                    lbTong.Visible = true;
                                }
                            }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(" ban phai chon kieu tim kiem");
            }
        }

        private void panelEx2_Click(object sender, EventArgs e)
        {

        }

        private void btReset_Click(object sender, EventArgs e)
        {
            cbMaNghanh.SelectedIndex = -1;
            cbMaNghanh.ResetText();
            cbMaNghanh.Text = "";
            Reset();
        }

        private void Reset()
        {
            txtSearch.ResetText();
            btSua.Enabled = false;
            btXoa.Enabled = false;
            btThem.Enabled = true;
            txtKhoaHoc.Text = "";
            txtML.Text = "";
            txtTL.Text = "";
            txtSoSV.Text = "";
            cbMaNghanh.Enabled = true;
            loadData();
        }

     

       

      
    }
}
