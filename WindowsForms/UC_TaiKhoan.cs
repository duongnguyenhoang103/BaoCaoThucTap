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
    public partial class UC_TaiKhoan : UserControl
    {
        public UC_TaiKhoan()
        {
            InitializeComponent();
        }
        TaiKhoanBE tk = new TaiKhoanBE();
        private void UC_TaiKhoan_Load(object sender, EventArgs e)
        {
            loadData();
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }

        private void loadData()
        {
            dgvTaiKhoan.DataSource = tk.showTK();
        }

        private void dgvTaiKhoan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int vt = dgvTaiKhoan.CurrentCell.RowIndex;
            txtTaiKhoan.Text = dgvTaiKhoan.Rows[vt].Cells["TaiKhoan"].Value.ToString();
            txtMatKhau.Text = dgvTaiKhoan.Rows[vt].Cells["MatKhau"].Value.ToString();
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
        }

        private void dgvTaiKhoan_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvTaiKhoan.Rows[e.RowIndex].Cells["STT"].Value=e.RowIndex+1;
        }

        private void Reset()
        {
            txtTaiKhoan.Text = "";
            txtTaiKhoan.Focus();
            txtMatKhau.Text = "";
            btSua.Enabled = false;
            btXoa.Enabled = false;
        }
        private void btReset_Click(object sender, EventArgs e)
        {
            Reset();
            loadData();
            btThem.Enabled = true;
              
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int vt = dgvTaiKhoan.CurrentCell.RowIndex;
            string taiKhoan = dgvTaiKhoan.Rows[vt].Cells["TaiKhoan"].Value.ToString().Trim();
          
                if (DialogResult.Yes == MessageBox.Show("bạn có chắc muốn xóa tài khoản" + txtTaiKhoan.Text + "hay không ?" ,"Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    tk.DeleteTK(taiKhoan);
                    loadData();
                    Reset();
                }   
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int vt = dgvTaiKhoan.CurrentCell.RowIndex;
            string key = dgvTaiKhoan.Rows[vt].Cells["TaiKhoan"].Value.ToString().Trim();        
            if (DialogResult.Yes == MessageBox.Show("bạn có chắc muốn sửa tài khoản" + txtTaiKhoan.Text + "hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                tk.UpdateTK(key,txtTaiKhoan.Text,txtMatKhau.Text);
                loadData();
                Reset();
            }   
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.TextLength==0)
            {
                MessageBox.Show("bạn phải nhập tài khoản");
                txtTaiKhoan.Focus();
                return;
            }
            if (txtMatKhau.TextLength == 0)
            {
                MessageBox.Show("mật khẩu không được để trống");
                txtMatKhau.Focus();
                return;
            }
            string key = txtTaiKhoan.Text;
            bool check = tk.CheckTK(key);
            if (!check)
            {
                if (DialogResult.Yes == MessageBox.Show("bạn có chắc muốn thêm tài khoản" + txtTaiKhoan.Text + "hay không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    tk.InsertTK(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim());
                    loadData();
                    Reset();
                }   
            }
            else
            {
                MessageBox.Show("tài khoản đã tồn tại , bạn hãy nhập tài khoản khác");             
                txtTaiKhoan.ResetText();
                txtTaiKhoan.Focus();
            }
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string key = txtTaiKhoan.Text;
            dgvTaiKhoan.DataSource = tk.GetTKByKey(key);
        }
    }
}
