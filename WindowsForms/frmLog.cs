using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BusinessEntity;

namespace DeMoQLSV1
{
    public partial class frmLog : Form
    {

        NguoiDungBE nguoidg = new NguoiDungBE();

        public frmMain main_from;
    
        public frmLog( frmMain f00)
        {
            InitializeComponent();
            main_from = f00;
            
        }

        private void btLogIn_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtDN.TextLength == 0)
                {
                    MessageBox.Show(" ban phai nhap tai khoan");
                    txtDN.Focus();
                    return;
                }
                if (txtMK.TextLength == 0)
                {
                    MessageBox.Show(" mat khau khong dc de trong");
                    txtMK.Focus();
                    return;
                }
                else
                {
                    bool kq = nguoidg.CheckLogin(txtDN.Text.Trim(), txtMK.Text.Trim());
                    if (kq == true)
                    {
                        if (txtDN.Text == "admin")
                        {
                            main_from.ShowAllMenu();
                            this.Close();
                        }
                        else
                            main_from.ShowMenu();
                        this.Close();
                        
                    }
                    else
                    {
                        MessageBox.Show("Bạn đã nhập sai tai khoan hoặc mat khau", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDN.Focus();
                        return;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(" Loi" +ex.Message); }
           
        }

            private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

            private void btDN2_Click(object sender, EventArgs e)
            {

            }

                                         
        

        private void btReset_Click(object sender, EventArgs e)
        {
            txtDN.ResetText();
            txtMK.ResetText();
        }

        private void frmLog_Load(object sender, EventArgs e)
        {

        }

      

    }
}
