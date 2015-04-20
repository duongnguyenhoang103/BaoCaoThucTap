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
    public partial class UC_MonHoc : UserControl
    {
        public UC_MonHoc()
        {
            InitializeComponent();
        }

        MonHocBE mh = new MonHocBE();
        GiaoVienBE gv = new GiaoVienBE();
        public void loadCombo()
        {
            cbSearch.SelectedIndex = 0;
            //load CbGV
            cbMaGV.DataSource = gv.ShowGV();
            cbMaGV.DisplayMember = "MaGV";
            cbMaGV.ValueMember = "MaGV";
            //load ColGV
            colMaGV.DataSource = gv.ShowGV();
            colMaGV.DisplayMember = "HoTenGV";
            colMaGV.ValueMember = "MaGV";
        }
        public void loadData()
        {
            dgvMH.DataSource = mh.ShowMH();
            lbTong.Text = "có tổng số: " + dgvMH.RowCount.ToString() + " môn học";
            lbTong.ForeColor = Color.BlueViolet;
            lbTong.Font = new Font(lbTong.Font, FontStyle.Italic);
        }
        private void UC_MonHoc_Load(object sender, EventArgs e)
        {
            loadCombo();
            loadData();
            btThem.Enabled = false;
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            txtMaMH.Text = "";
            txtMonHoc.Text = "";
            txtSoTC.Text = "";
            txtSoTiet.Text = "";
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void dgvMH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            txtMaMH.Text = dgvMH.Rows[vt].Cells[0].Value.ToString();
            txtMonHoc.Text = dgvMH.Rows[vt].Cells[1].Value.ToString();
            txtSoTC.Text = dgvMH.Rows[vt].Cells[2].Value.ToString();
            txtSoTiet.Text = dgvMH.Rows[vt].Cells[3].Value.ToString();
            cbMaGV.Text = dgvMH.Rows[vt].Cells[4].Value.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            if (txtMaMH.TextLength == 0 || dgvMH.SelectedRows.Count < 0)
            {
                MessageBox.Show(" bạn phải chọn dữ liệu xóa ");
            }
            else
                if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn xóa môn học '" + txtMonHoc.Text + "' với mã '" + txtMaMH.Text + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {

                    string strMaMH = txtMaMH.Text;
                    mh.DeleteMH(strMaMH);
                    MessageBox.Show("Xóa môn học có tên là :  " + this.txtMonHoc.Text + " thành công");
                    loadData();
                }
        }

        private void btThem_Click(object sender, EventArgs e)
        {

            if (txtMaMH.TextLength == 0)
            {
                MessageBox.Show("bạn phải nhập mã khoa ");
                txtMaMH.Focus();
                return;
            }
            if (txtMonHoc.TextLength == 0)
            {
                MessageBox.Show("bạn phải nhập tên khoa ");
                txtMonHoc.Focus();
                return;
            }
            else if (txtMaMH.TextLength > 11)
            {
                MessageBox.Show(" Mã không vượt quá 10 kí tự");
                txtMaMH.ResetText();
                return;
            }
            else
            {
                try
                {
                    int Num;
                    bool ktra = int.TryParse(txtSoTC.Text.Trim(), out Num);
                    if (!ktra)
                    {
                        MessageBox.Show("hãy nhập số");
                        txtSoTC.ResetText();
                        txtSoTC.Focus();
                        return;
                    }
                    int Num1;
                    bool ktra1 = int.TryParse(txtSoTiet.Text.Trim(), out Num1);
                    if (!ktra)
                    {
                        MessageBox.Show("hãy nhập số");
                        txtSoTiet.ResetText();
                        txtSoTiet.Focus();
                        return;
                    }
                    else
                    {
                        mh.InsertMH(txtMaMH.Text, txtMonHoc.Text, Int32.Parse(txtSoTC.Text), Int32.Parse(txtSoTiet.Text), cbMaGV.SelectedValue.ToString());
                        MessageBox.Show("Thêm môn học " + this.txtMaMH.Text + " thành công");
                        loadData();
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm môn học với mã " + this.txtMaMH.Text + "không thành công vì đã tồn tại");
                    txtMaMH.Focus();
                    txtMaMH.Text = "";

                }
            }                     
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMaMH.TextLength == 0)
            {
                MessageBox.Show("bạn phải nhập mã khoa ");
                txtMaMH.Focus();
                return;
            }
            if (txtMonHoc.TextLength == 0)
            {
                MessageBox.Show("bạn phải nhập tên khoa ");
                txtMonHoc.Focus();
                return;
            }
            else if (txtMaMH.TextLength > 11)
            {
                MessageBox.Show(" Mã không vượt quá 10 kí tự");
                txtMaMH.ResetText();
                return;
            }
            else
            {
                try
                {
                    int Num;
                    bool ktra = int.TryParse(txtSoTC.Text.Trim(), out Num);
                    if (!ktra)
                    {
                        MessageBox.Show("hãy nhập số");
                        txtSoTC.ResetText();
                        txtSoTC.Focus();
                        return;
                    }
                    int Num1;
                    bool ktra1 = int.TryParse(txtSoTiet.Text.Trim(), out Num1);
                    if (!ktra)
                    {
                        MessageBox.Show("hãy nhập số");
                        txtSoTiet.ResetText();
                        txtSoTiet.Focus();
                        return;
                    }
                    else
                    {
                        int vt = dgvMH.CurrentCell.RowIndex;
                        string madk = dgvMH.Rows[vt].Cells[0].Value.ToString();
                        mh.UpdateMH(madk, txtMaMH.Text, txtMonHoc.Text, Int32.Parse(txtSoTC.Text), Int32.Parse(txtSoTiet.Text), cbMaGV.SelectedValue.ToString());
                        MessageBox.Show("Sửa môn học " + this.txtMaMH.Text + " thành công");
                        loadData();
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa môn học với mã " + this.txtMaMH.Text + "không thành công vì dl sai");
                    txtMaMH.Focus();
                    txtMaMH.Text = "";

                }
            }                     
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string key = txtSearch.Text.ToString().Trim();
            try
            {
                if (txtSearch.TextLength == 0)
                {
                    loadData();
                }
                if (cbSearch.SelectedItem.ToString() == "Mã môn học")
                {
                    dgvMH.DataSource = mh.SearchByID(key);
                    if (dgvMH.Rows.Count == 0)
                    {
                        this.lbTong.ForeColor = Color.Red;
                        this.lbTong.Text = " không tìm thấy";
                        txtMaMH.Text = "";
                        txtMonHoc.Text = "";
                        txtSoTC.Text = "";
                        txtSoTiet.Text = "";
                    }
                    else
                    {
                        lbTong.ForeColor = Color.BlueViolet;
                        lbTong.Font = new Font(lbTong.Font, FontStyle.Italic);
                        this.lbTong.Text = " Có tổng số : " + dgvMH.Rows.Count.ToString() + " Môn học ";
                    }
                }
                else
                    if (cbSearch.SelectedItem.ToString() == "Tên môn học")
                    {
                        dgvMH.DataSource = mh.SearchByName(key);

                        if (dgvMH.Rows.Count == 0)
                        {
                            this.lbTong.ForeColor = Color.Red;
                            this.lbTong.Text = " không tìm thấy";
                            txtMaMH.Text = "";
                            txtMonHoc.Text = "";
                            txtSoTC.Text = "";
                            txtSoTiet.Text = "";
                        }
                        else
                        {
                            lbTong.ForeColor = Color.BlueViolet;
                            lbTong.Font = new Font(lbTong.Font, FontStyle.Italic);
                            this.lbTong.Text = " Có tổng số : " + dgvMH.Rows.Count.ToString() + " Môn học ";
                        }
                    }
                    else
                        if (cbSearch.SelectedItem.ToString() == "Tất cả")
                        {
                            dgvMH.DataSource = mh.SearchMonHocByAll(key);

                            if (dgvMH.Rows.Count == 0)
                            {
                                this.lbTong.ForeColor = Color.Red;
                                this.lbTong.Text = " không tìm thấy";
                                txtMaMH.Text = "";
                                txtMonHoc.Text = "";
                                txtSoTC.Text = "";
                                txtSoTiet.Text = "";
                            }
                            else
                            {
                                lbTong.ForeColor = Color.BlueViolet;
                                lbTong.Font = new Font(lbTong.Font, FontStyle.Italic);
                                this.lbTong.Text = " Có tổng số : " + dgvMH.Rows.Count.ToString() + " Môn học ";
                            }
                        }
                        else
                            if (cbSearch.SelectedItem.ToString() == "Mã giáo viên")
                            {
                                dgvMH.DataSource = mh.SearchMonHocByIdGV(key);

                                if (dgvMH.Rows.Count == 0)
                                {
                                    this.lbTong.ForeColor = Color.Red;
                                    this.lbTong.Text = " không tìm thấy";
                                    txtMaMH.Text = "";
                                    txtMonHoc.Text = "";
                                    txtSoTC.Text = "";
                                    txtSoTiet.Text = "";
                                }
                                else
                                {
                                    lbTong.ForeColor = Color.BlueViolet;
                                    lbTong.Font = new Font(lbTong.Font, FontStyle.Italic);
                                    this.lbTong.Text = " Có tổng số : " + dgvMH.Rows.Count.ToString() + " Môn học ";
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
                if (cbSearch.SelectedItem.ToString() == "Mã môn học")
                {
                    dgvMH.DataSource = mh.SearchByID(key);
                    if (dgvMH.Rows.Count == 0)
                    {
                        this.lbTong.ForeColor = Color.Red;
                        this.lbTong.Text = " không tìm thấy";
                        txtMaMH.Text = "";
                        txtMonHoc.Text = "";
                        txtSoTC.Text = "";
                        txtSoTiet.Text = "";
                    }
                    else
                    {
                        lbTong.ForeColor = Color.BlueViolet;
                        lbTong.Font = new Font(lbTong.Font, FontStyle.Italic);
                        this.lbTong.Text = " Có tổng số : " + dgvMH.Rows.Count.ToString() + " Môn học ";
                    }
                }
                else
                    if (cbSearch.SelectedItem.ToString() == "Tên môn học")
                    {
                        dgvMH.DataSource = mh.SearchByName(key);

                        if (dgvMH.Rows.Count == 0)
                        {
                            this.lbTong.ForeColor = Color.Red;
                            this.lbTong.Text = " không tìm thấy";
                            txtMaMH.Text = "";
                            txtMonHoc.Text = "";
                            txtSoTC.Text = "";
                            txtSoTiet.Text = "";
                        }
                        else
                        {
                            lbTong.ForeColor = Color.BlueViolet;
                            lbTong.Font = new Font(lbTong.Font, FontStyle.Italic);
                            this.lbTong.Text = " Có tổng số : " + dgvMH.Rows.Count.ToString() + " Môn học ";
                        }
                    }
                    else
                        if (cbSearch.SelectedItem.ToString() == "Tất cả")
                        {
                            dgvMH.DataSource = mh.SearchMonHocByAll(key);

                            if (dgvMH.Rows.Count == 0)
                            {
                                this.lbTong.ForeColor = Color.Red;
                                this.lbTong.Text = " không tìm thấy";
                                txtMaMH.Text = "";
                                txtMonHoc.Text = "";
                                txtSoTC.Text = "";
                                txtSoTiet.Text = "";
                            }
                            else
                            {
                                lbTong.ForeColor = Color.BlueViolet;
                                lbTong.Font = new Font(lbTong.Font, FontStyle.Italic);
                                this.lbTong.Text = " Có tổng số : " + dgvMH.Rows.Count.ToString() + " Môn học ";
                            }
                        }
                        else
                            if (cbSearch.SelectedItem.ToString() == "Mã giáo viên")
                            {
                                dgvMH.DataSource = mh.SearchMonHocByIdGV(key);

                                if (dgvMH.Rows.Count == 0)
                                {
                                    this.lbTong.ForeColor = Color.Red;
                                    this.lbTong.Text = " không tìm thấy";
                                    txtMaMH.Text = "";
                                    txtMonHoc.Text = "";
                                    txtSoTC.Text = "";
                                    txtSoTiet.Text = "";
                                }
                                else
                                {
                                    lbTong.ForeColor = Color.BlueViolet;
                                    lbTong.Font = new Font(lbTong.Font, FontStyle.Italic);
                                    this.lbTong.Text = " Có tổng số : " + dgvMH.Rows.Count.ToString() + " Môn học ";
                                }
                            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("lỗi"+ex);
            }
        
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            loadData();
            txtSearch.ResetText();
            btThem.Enabled = false;
            btSua.Enabled = true;
            btXoa.Enabled = true;
        }
    }
}
