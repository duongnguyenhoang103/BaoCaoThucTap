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
    public partial class UC_TimKiemNganh : UserControl
    {
        public UC_TimKiemNganh()
        {
            InitializeComponent();
        }
        TimKiemNghanh_BE tkN = new TimKiemNghanh_BE ();
        KhoaBE k = new KhoaBE();
        private void LoadData()
        {
            if (txtSearch.Text == "")
            {
                panel2.Visible = false;
                lbTg.Visible = false;
            }
            string key = txtSearch.Text;
            dgvNganh.DataSource = tkN.Search(key);
            if (dgvNganh.Rows.Count > 0)
            {
                lbTg.Visible = true;
                lbTg.ForeColor = Color.BlueViolet;
                lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                this.lbTg.Text = " Có tổng số : " + dgvNganh.Rows.Count.ToString() + " nghành ";
            }
            else
            {
                lbTg.Visible = false;
                lbTg.ForeColor = Color.BlueViolet;
                lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                this.lbTg.Text = " không tìm thấy ";
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadData();
         }

        private void UC_TimKiemNganh_Load(object sender, EventArgs e)
        {
            CbK.ResetText();
            CbK.SelectedIndex = -1;
            // loadCb khoa
            CbK.DataSource = k.ShowKhoa();
            CbK.DisplayMember = "MaKhoa";
            CbK.ValueMember = "TenKhoa";
            lbTg.Visible = false;
            panel2.Visible = false;
        }

        private void dgvNganh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            panel2.Visible = true;
            int vt = e.RowIndex;
            this.txtMaNghanh.Text = dgvNganh.Rows[vt].Cells["MaNghanh"].Value.ToString();
            this.txtTenNghanh.Text = dgvNganh.Rows[vt].Cells["TenNghanh"].Value.ToString();
            this.txtSoL.Text = dgvNganh.Rows[vt].Cells["SoLop"].Value.ToString();
            this.CbK.Text = dgvNganh.Rows[vt].Cells["MaKhoa"].Value.ToString();
            this.txtSDT.Text = dgvNganh.Rows[vt].Cells["SDT"].Value.ToString();
            this.txtEmail.Text = dgvNganh.Rows[vt].Cells["Email"].Value.ToString();
            this.txtDiaChi.Text = dgvNganh.Rows[vt].Cells["DiaChi"].Value.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int vt = dgvNganh.CurrentCell.RowIndex;
            string madk = dgvNganh.Rows[vt].Cells["MaNghanh"].Value.ToString();
            if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn xóa nghành '" + txtTenNghanh.Text + "' với mã '" + txtMaNghanh.Text + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
            
                tkN.DeleteNganh(madk);
                MessageBox.Show("Xóa nghành có tên là :" + this.txtTenNghanh.Text + " !!! thành công");
                LoadData();
                panel2.Visible = false;

            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMaNghanh.TextLength == 0)
            {
                MessageBox.Show("bạn phải nhập mã nghành ");
                txtMaNghanh.Focus();
                return;
            }
            if (txtTenNghanh.TextLength == 0)
            {
                MessageBox.Show("bạn phải nhập tên nghành ");
                txtTenNghanh.Focus();
                return;
            }
            else if (txtMaNghanh.TextLength > 11)
            {
                MessageBox.Show(" Mã không vượt quá 10 kí tự");
                txtMaNghanh.ResetText();
                return;
            }
            else
            {
                try
                {
                    int vt = dgvNganh.CurrentCell.RowIndex;
                    string madk = dgvNganh.Rows[vt].Cells["MaNghanh"].Value.ToString().Trim();
                    tkN.UpdateNghanh(madk, txtMaNghanh.Text.Trim(), txtTenNghanh.Text.Trim(), Int32.Parse(txtSoL.Text), CbK.Text.ToString().Trim(), Int32.Parse(txtSDT.Text), txtEmail.Text.Trim(), txtDiaChi.Text.Trim());
                    MessageBox.Show("Sửa nghành " + this.txtMaNghanh.Text + " thành công");
                    LoadData();
                    // Reset();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(" Sửa nghành với mã " + this.txtMaNghanh.Text + "không thành công vì mã đó đã có. Bạn hãy nhập mã khác");
                    //txtMaNghanh.Focus();
                    //txtMaNghanh.Text = "";
                    MessageBox.Show(""+ ex);

                }
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            txtSearch.Text = "";
        }        
    }
}
