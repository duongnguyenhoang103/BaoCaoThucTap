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
    public partial class UC_Khoa : UserControl
    {
        KhoaBE khoa = new KhoaBE();
        public UC_Khoa()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            dgvKhoa.DataSource =khoa.ShowKhoa();

        }
        private void Reset()
        {         
            loadData();
            btSua.Enabled = true;
            btXoa.Enabled = true;
            btThem.Enabled = false;
        }
        private void UC_Khoa_Load(object sender, EventArgs e)
        {
//          loadData();                      
            Reset();
         
           
        }

        private void dgvKhoa_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int vt = e.RowIndex;
            txtMaKhoa.Text = dgvKhoa.Rows[vt].Cells[0].Value.ToString();
            txtTenKhoa.Text = dgvKhoa.Rows[vt].Cells[1].Value.ToString();
            txtSDT.Text = dgvKhoa.Rows[vt].Cells[2].Value.ToString();
            txtEmail.Text = dgvKhoa.Rows[vt].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvKhoa.Rows[vt].Cells[4].Value.ToString();

            // show bt
            btSua.Enabled = true;
            btXoa.Enabled = true;
            
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            txtMaKhoa.Text = "";
            txtMaKhoa.Focus();
            txtTenKhoa.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            btThem.Enabled = true;
            btXoa.Enabled = false;
            btSua.Enabled = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.TextLength == 0)
            {
                MessageBox.Show("bạn phải nhập mã khoa ");
                txtMaKhoa.Focus();
                return;
            }
            if (txtTenKhoa.TextLength == 0)
            {
                MessageBox.Show("bạn phải nhập tên khoa ");
                txtTenKhoa.Focus();
                return;
            }
            else if (txtMaKhoa.TextLength > 11)
            {
                MessageBox.Show(" Mã không vượt quá 10 kí tự");
                txtMaKhoa.ResetText();
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
                        khoa.InsertKhoa(txtMaKhoa.Text, txtTenKhoa.Text, txtSDT.Text, txtEmail.Text, txtDiaChi.Text);
                        MessageBox.Show("Thêm khoa " + this.txtMaKhoa.Text + " thành công");
                        //loadData();
                        Reset();
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm khoa với mã " + this.txtMaKhoa.Text + "không thành công vì đã tồn tại");
                    txtMaKhoa.Focus();
                    txtMaKhoa.Text = "";

                }
            }                     
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.TextLength == 0)
            {
                MessageBox.Show("bạn phải nhập mã khoa ");
                txtMaKhoa.Focus();
                return;
            }
            if (txtTenKhoa.TextLength == 0)
            {
                MessageBox.Show("bạn phải nhập tên khoa ");
                txtTenKhoa.Focus();
                return;
            }
            else if (txtMaKhoa.TextLength > 11)
            {
                MessageBox.Show(" Mã không vượt quá 10 kí tự");
                txtMaKhoa.ResetText();
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
                        int vt = dgvKhoa.CurrentCell.RowIndex;
                        string madk = dgvKhoa.Rows[vt].Cells[0].Value.ToString();
                        //string madk = txtMaKhoa.Text; 
                        khoa.UpdateKhoa(madk, txtMaKhoa.Text, txtTenKhoa.Text, txtSDT.Text, txtEmail.Text, txtDiaChi.Text);
                        MessageBox.Show("Sửa khoa " + this.txtMaKhoa.Text + " thành công");
                        //loadData();
                        Reset();
                    }
                }
                catch
                {
                    MessageBox.Show("Sửa khoa với mã " + this.txtMaKhoa.Text + "không thành công vì đã tồn tại");
                    txtMaKhoa.Focus();
                    txtMaKhoa.Text = "";

                }
            }                     
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.TextLength == 0 || dgvKhoa.SelectedRows.Count < 0)
            {
                MessageBox.Show(" bạn phải chọn dữ liệu xóa ");
            }
            else
                if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn xóa khoa '" + txtTenKhoa.Text + "' với mã '" + txtMaKhoa.Text + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    string strMaKhoa = txtMaKhoa.Text;
                    khoa.DeleteKhoa(strMaKhoa);
                    MessageBox.Show("Xóa khoa có tên là :" + this.txtTenKhoa.Text + " !!! thành công");
                   // loadData();
                    Reset();

                }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            Reset();
           
        }
    }
}
