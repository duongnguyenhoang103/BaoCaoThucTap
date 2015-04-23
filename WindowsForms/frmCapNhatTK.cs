using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessEntity;
namespace DeMoQLSV1
{
    public partial class frmCapNhatTK : Form
    {
        NguoiDungBE nguoidg = new NguoiDungBE();
        public Form1 main_from;
     

        public frmCapNhatTK(Form1 f00)
        {
            InitializeComponent();
            main_from = f00;
        }
        public frmCapNhatTK()
        {
            InitializeComponent();
        }
        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {                      
                if (txtMK.TextLength == 0)
                {
                    MessageBox.Show(" mật khẩu không được để trống");
                    txtMK.Focus();
                    return;
                }
                if (txtMkNew.TextLength==0)
                {
                     MessageBox.Show(" mật khẩu không được để trống");
                    txtMkNew.Focus();
                    return;
                }
                else
                {
                    bool kq = nguoidg.CheckLogin(txtDN.Text.Trim(), txtMK.Text.Trim());
                    if (kq == true)
                    {                
                        lbChekc.Visible = false;
                        string dk = txtDN.Text.Trim();
                        string tk = txtDN.Text.Trim();                       
                        string mkNew = txtMkNew.Text.Trim(); 
                        if (DialogResult.Yes==MessageBox.Show("Bạn có muốn thay đổi mật khẩu ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                        {
                            nguoidg.UpdateTK(dk, tk, mkNew);
                            MessageBox.Show("Mật khẩu của bạn đã được thay đổi thành công");
                            this.Close();
                        }
                        else
                        {
                            return;
                        }

                    }
                    else
                    {                        
                        lbChekc.Visible = true;
                        lbChekc.Text = "không đúng";
                        lbChekc.ForeColor = Color.BlueViolet;
                        lbChekc.Font = new Font(lbChekc.Font, FontStyle.Italic);
                        txtMK.Focus();
                        txtMK.ResetText();
                        return;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(" Lỗi" + ex.Message); }
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            main_from.showBtDN();
           
        }

        private void frmCapNhatTK_Load(object sender, EventArgs e)
        {
            txtDN.Text = NguoiDungBE.TaiKhoan; // lấy tên ĐN từ hệ thống
            lbChekc.Visible = false;
        }

        private void txtMK_Leave(object sender, EventArgs e)
        {
            bool kq = nguoidg.CheckLogin(txtDN.Text.Trim(), txtMK.Text.Trim());
            if (kq == true)
            {
                lbChekc.Visible = false;
            }
            else
            {
                lbChekc.Visible = true;
                lbChekc.Text = "không đúng";
                lbChekc.ForeColor = Color.BlueViolet;
                lbChekc.Font = new Font(lbChekc.Font, FontStyle.Italic);
                txtMK.Focus();
                txtMK.ResetText();
                return;
            }
        }

       
    }
}