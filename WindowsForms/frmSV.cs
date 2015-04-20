using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessEntity;

namespace DeMoQLSV1
{
    public partial class frmSV : Form
    {
        public frmSV()
        {
            InitializeComponent();
        }

        SinhVienBE sv = new SinhVienBE();
        LopBE lp = new LopBE();
   
        public void loadData()
        {
            //DataTable dt = new DataTable();
            //dt = sv.ShowSV();
            //dgvSV.DataSource = dt;           
            dgvSV.DataSource = sv.GetAllSV();
            lbTg.Text = "có tổng số:" + dgvSV.RowCount.ToString()+ " sinh viên";
            lbTg.ForeColor = Color.Black;
            lbTg.Font = new Font(lbTg.Font,FontStyle.Bold);
        }

        public void loadCombox()
        {
            // load combox MaLop 
            cbMaLop.DataSource = lp.ShowLop();
            cbMaLop.DisplayMember = "TenLop";
            cbMaLop.ValueMember = "MaLop";
           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbSearch.SelectedIndex = 0;
           // load colum Malop tren dgv
            //colMaLop.DataSource = lp.ShowLop();
            //colMaLop.DisplayMember = "TenLop";
            //colMaLop.ValueMember = "MaLop";

            loadCombox();
           
           loadData();
        }

        //dua dl len txtbox , cb ,,,
        private void dgvSV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
          
            int dong = e.RowIndex;
            
            {
                txtMSV.Text = dgvSV.Rows[dong].Cells[0].Value.ToString();
                txtTenSV.Text = dgvSV.Rows[dong].Cells[1].Value.ToString();
                cbGioiTinh.Text = dgvSV.Rows[dong].Cells[2].Value.ToString();
                txtSDT.Text = dgvSV.Rows[dong].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvSV.Rows[dong].Cells[4].Value.ToString();
                txtEmail.Text = dgvSV.Rows[dong].Cells[5].Value.ToString();
                dateTimePickerNgaySinh.Text = dgvSV.Rows[dong].Cells[6].Value.ToString();
                cbMaLop.SelectedValue = dgvSV.Rows[dong].Cells[7].Value.ToString();
            }
        }

     
        private void cbMaLop_MouseClick(object sender, MouseEventArgs e)
        {
            loadCombox();
           // loadData();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
             if (txtMSV.TextLength == 0 || dgvSV.SelectedRows.Count < 0)
            {
                MessageBox.Show(" bạn phải chọn dữ liệu xóa ");
            }
            else
                 if (DialogResult.Yes == MessageBox.Show(" bạn có chắc muốn xóa sinh viên '" + txtTenSV.Text + "' với mã '" + txtMSV.Text + "'hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                 {
                     //try
                     //{
                     //int r = dgvSV.CurrentCell.RowIndex;
                     //string strMaSV = dgvSV.Rows[r].Cells[0].Value.ToString();
                   //  string strMaSV = dgvSV.SelectedRows[0].Cells[0].Value.ToString();
                     string strMaSV = txtMSV.Text;
                     sv.DeleteSV(strMaSV);
                     Form1_Load(sender, e);
                     MessageBox.Show("Xóa sinh viên có tên là :  " + this.txtTenSV.Text + " thành công");
                     
                 }
        }

        

        private void frmSV_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            loadData();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
        ////    sv.MaSV = txtMSV.Text;
        ////    sv.TenSV = txtTenSV.Text;
        ////    sv.GioiTinh = cbGioiTinh.SelectedValue.ToString();
        ////    sv.SDT = Int32.Parse(txtSDT.Text);
        ////    sv.NgaySinh = dateTimePickerNgaySinh.Value;
        ////    sv.MaLop = cbMaLop.SelectedValue.ToString();                             
                try
                {
                    if (txtSDT.TextLength == 0 || txtMSV.TextLength == 0 || txtTenSV.TextLength == 0)
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
                        sv.InsertSV(txtMSV.Text, txtTenSV.Text, cbGioiTinh.SelectedItem.ToString(),
                                    Int32.Parse(txtSDT.Text),txtDiaChi.Text ,txtEmail.Text ,  dateTimePickerNgaySinh.Value, cbMaLop.SelectedValue.ToString());
                        MessageBox.Show(" thêm sinh viên " + txtTenSV.Text + " có mã " + txtMSV.Text + " !!! thành công  ");
                        loadData();
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

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSDT.TextLength == 0 || txtMSV.TextLength == 0 || txtTenSV.TextLength == 0)
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
                    int r = dgvSV.CurrentCell.RowIndex;
                    string madk = dgvSV.Rows[r].Cells[0].Value.ToString();
                    sv.UpdateSV(madk, txtMSV.Text, txtTenSV.Text, cbGioiTinh.SelectedItem.ToString(),
                                Int32.Parse(txtSDT.Text),txtDiaChi.Text ,txtEmail.Text , dateTimePickerNgaySinh.Value, cbMaLop.SelectedValue.ToString());
                     MessageBox.Show(" sửa thông tin sinh viên " + txtTenSV.Text + " có mã " + txtMSV.Text + " !!! thành công  ");
                    loadData();
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

        // ham k chan nhap tu ban phim cac chu cai 
        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            //{ e.Handled = true; }
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Focus();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.TextLength == 0)
                    {
                        MessageBox.Show(" bạn phải nhập kí tự tìm kiếm");
                        return;
                    }
            string key = txtSearch.Text.ToString().Trim();
            try 
            {

                if (cbSearch.SelectedItem.ToString() == "Mã Lớp")
                {
                    
                        dgvSV.DataSource = sv.GetSVByIdMaLop(key);
                        if (dgvSV.Rows.Count == 0)
                        {
                            this.lbTg.ForeColor = Color.Red;
                            this.lbTg.Text = " không tìm thấy";
                            txtMSV.Text = "";
                            txtTenSV.Text = "";
                            txtSDT.Text = "";
                        }
                        else
                        {
                            this.lbTg.ForeColor = Color.Black;
                            this.lbTg.Text = " Có tổng số : " + dgvSV.Rows.Count.ToString() + " Sinh Viên ";
                        }
                    }
                
                else
                    if (cbSearch.SelectedItem.ToString() == "Tên Lớp")
                    {
                        dgvSV.DataSource = sv.GetSVByIdTenLop(key);

                        if (dgvSV.Rows.Count == 0)
                        {
                            this.lbTg.ForeColor = Color.Red;
                            this.lbTg.Text = " không tìm thấy";
                            txtMSV.Text = "";
                            txtTenSV.Text = "";
                            txtSDT.Text = "";
                        }
                        else
                        {
                            this.lbTg.ForeColor = Color.Black;
                            this.lbTg.Text = " Có tổng số : " + dgvSV.Rows.Count.ToString() + " Sinh Viên ";
                        }
                    }
            }
            catch (Exception ex)
            { MessageBox.Show(" bạn phải chọn kiểu tìm kiếm"); }
           
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
                if (cbSearch.SelectedItem.ToString() == "Mã Lớp")
                {
                dgvSV.DataSource = sv.GetSVByIdMaLop(key);
                if (dgvSV.Rows.Count == 0)
                {
                    this.lbTg.ForeColor = Color.Red;
                    this.lbTg.Text = " không tìm thấy";
                    txtMSV.Text = "";
                    txtTenSV.Text = "";
                    txtSDT.Text = "";
                }
                else
                {
                    this.lbTg.ForeColor = Color.Black;
                    this.lbTg.Text = " Có tổng số : " + dgvSV.Rows.Count.ToString() + " Sinh Viên ";
                }
            }
            else
                if (cbSearch.SelectedItem.ToString() == "Tên Lớp")
                {
                    dgvSV.DataSource = sv.GetSVByIdTenLop(key);

                    if (dgvSV.Rows.Count == 0)
                    {
                        this.lbTg.ForeColor = Color.Red;
                        this.lbTg.Text = " khong tim thay";
                        txtMSV.Text = "";
                        txtTenSV.Text = "";
                        txtSDT.Text = "";
                    }
                    else
                    {
                        this.lbTg.ForeColor = Color.Black;
                        this.lbTg.Text = " Có tổng số : " + dgvSV.Rows.Count.ToString() + " Sinh Viên ";
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(" ban phai chon kieu tim kiem");
            }

        } 
    }
}
