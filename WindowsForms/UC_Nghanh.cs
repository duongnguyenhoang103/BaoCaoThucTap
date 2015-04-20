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
    public partial class UC_Nghanh : UserControl
    {
        NghanhBE nghanh = new NghanhBE();
        KhoaBE khoa = new KhoaBE();
        public UC_Nghanh()
        {
            InitializeComponent();
        }
        public void loadData()
        {
            //dgvNganh.DataSource = nghanh.ShowNghanh();
            string key = cbMaKhoa.Text;
            dgvNganh.DataSource = nghanh.GetNghanhByKhoa(key);
            if (dgvNganh.Rows.Count >0 )
            {
                lbTg.Visible = true;              
                lbTg.ForeColor = Color.BlueViolet;
                lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                this.lbTg.Text = " Có tổng số : " + dgvNganh.Rows.Count.ToString() + " nghành ";
            }
            else
            {
                lbTg.Visible = false;
                    
            }
          
        }
        private void cbMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            loadData();
        }
        public void loadCombox()
        {
            cbMaKhoa.DataSource = khoa.ShowKhoa();
            cbMaKhoa.DisplayMember = "MaKhoa";
            cbMaKhoa.ValueMember = "MaKhoa";
        }
        private void UC_Nghanh_Load(object sender, EventArgs e)
        {
            loadCombox();
            cbMaKhoa.ResetText();
            cbMaKhoa.SelectedIndex = -1;
            bttNew.Visible = false;
            btSua.Enabled = false;
            btXoa.Enabled = false;
           // loadData();
        }

        private void dgvNganh_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
         
        }


        private void dgvNganh_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int vt = e.RowIndex;
            this.txtMaNghanh.Text = dgvNganh.Rows[vt].Cells["MaNghanh"].Value.ToString();
            this.txtTenNghanh.Text = dgvNganh.Rows[vt].Cells["TenNghanh"].Value.ToString();
            this.txtSoL.Text = dgvNganh.Rows[vt].Cells["SoLop"].Value.ToString();
            this.cbMaKhoa.SelectedValue = dgvNganh.Rows[vt].Cells["MaKhoa"].Value.ToString();
            this.txtSDT.Text = dgvNganh.Rows[vt].Cells["SDT"].Value.ToString();
            this.txtEmail.Text = dgvNganh.Rows[vt].Cells["Email"].Value.ToString();
            this.txtDiaChi.Text = dgvNganh.Rows[vt].Cells["DiaChi"].Value.ToString();

            // hien thi bt
            btXoa.Enabled = true;
            btSua.Enabled = true;
            btThem.Enabled = false;
            cbMaKhoa.Enabled = false;
        }    

        private void cbMaKhoa_MouseClick(object sender, MouseEventArgs e)
        {
            // load lai cb sau khi UC_Khoa thay đổi
            loadCombox();
        }

        private void UC_Nghanh_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           //loadData(); 
        }

        private void btXoa_Click(object sender, EventArgs e)
        {

            int vt = dgvNganh.CurrentCell.RowIndex;
            string madk = dgvNganh.Rows[vt].Cells["MaNghanh"].Value.ToString();
            if (madk.ToString()==""|| dgvNganh.SelectedRows.Count < 0)
            {
                MessageBox.Show(" bạn phải chọn dữ liệu xóa ");
            }
            else
                if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn xóa nghành '" + txtTenNghanh.Text + "' với mã '" + txtMaNghanh.Text + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                  //  string strMaNghanh = txtMaNghanh.Text;
                    nghanh.DeleteNganh(madk);
                    MessageBox.Show("Xóa nghành có tên là :" + this.txtTenNghanh.Text + " !!! thành công");
                   // loadData();
                    Reset();


                }
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            txtMaNghanh.Text = "";
            txtTenNghanh.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtSoL.Text = "";
            btThem.Enabled = true;
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
                    string madk = dgvNganh.Rows[vt].Cells[0].Value.ToString();                    
                    nghanh.UpdateNghanh(madk, txtMaNghanh.Text, txtTenNghanh.Text, Int32.Parse(txtSoL.Text), cbMaKhoa.SelectedValue.ToString(), Int32.Parse(txtSDT.Text), txtEmail.Text, txtDiaChi.Text);
                    MessageBox.Show("Sửa nghành " + this.txtMaNghanh.Text + " thành công");
                    //loadData();
                    Reset();
                }
                catch
                {
                    MessageBox.Show(" Sửa nghành với mã " + this.txtMaNghanh.Text + "không thành công vì mã đó đã có. Bạn hãy nhập mã khác");
                    txtMaNghanh.Focus();
                    txtMaNghanh.Text = "";

                }
            }                     
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            string makhoa = cbMaKhoa.SelectedValue !=null ? cbMaKhoa.SelectedValue.ToString():string.Empty;
            if (makhoa.ToString()== null || makhoa.ToString() == "")
            {
                MessageBox.Show("bạn phải chọn khoa ");
                cbMaKhoa.Focus();
                return;
            }
            if (txtMaNghanh.TextLength==0)
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
                    int Num;
                    bool ktra = int.TryParse(txtSDT.Text.Trim(), out Num);
                    if (!ktra)
                    {
                        MessageBox.Show("hãy nhập số");
                        txtSDT.ResetText();
                        txtSDT.Focus();
                        return;
                    }
                    int Num1;
                    bool ktra1 = int.TryParse(txtSoL.Text.Trim(), out Num1);
                    if (!ktra1)
                    {
                        MessageBox.Show("hãy nhập số");
                        txtSoL.ResetText();
                        txtSoL.Focus();
                        return;
                    }
                    else
                    {
                        nghanh.InsertNghanh(txtMaNghanh.Text, txtTenNghanh.Text, Int32.Parse(txtSoL.Text), cbMaKhoa.SelectedValue.ToString(), Int32.Parse(txtSDT.Text), txtEmail.Text, txtDiaChi.Text);
                        MessageBox.Show("Thêm nghành " + this.txtMaNghanh.Text + " thành công");                        
                        //loadData();
                        Reset();
                    }
                }
                catch
                {
                    MessageBox.Show("Thêm nghành với mã " + this.txtMaNghanh.Text + "không thành công vì đã tồn tại");
                    txtMaNghanh.Focus();
                    txtMaNghanh.Text = "";

                }
            }                     
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
          //  loadCombox();
            loadData();
        }

        private void Reset()
        {
            txtMaNghanh.ResetText();
            txtTenNghanh.ResetText();
            txtSDT.ResetText();
            txtEmail.ResetText();
            txtDiaChi.ResetText();
            txtSoL.ResetText();
            loadData();
            btXoa.Enabled = false;
            btSua.Enabled = false;
            btThem.Enabled = true;
            cbMaKhoa.Enabled = true;
            cbMaKhoa.ResetText();
            cbMaKhoa.Text = "";
        }
        private void btReset_Click(object sender, EventArgs e)
        {            
            Reset();
            cbMaKhoa.Text = "";
            dgvNganh.DataSource = nghanh.GetNghanhByKhoa(cbMaKhoa.Text);
            txtSearch.Text = "";
            lbTg.Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            if (txtSearch.Text == "")
            {
               // panel2.Visible = false;                
                loadData();
                lbTg.Visible = false;
            }
            string key = txtSearch.Text;
            dgvNganh.DataSource = nghanh.Search(key);
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

       

    }
}
