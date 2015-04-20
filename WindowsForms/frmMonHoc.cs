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
    public partial class frmMonHoc : Form
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }

        MonHocBE mh = new MonHocBE();
        GiaoVienBE gv = new GiaoVienBE();
        private void loadDgvMH()
        {
            dgvMH.DataSource = mh.ShowMH();
            lbTong.Text = "co tong so " + dgvMH.Rows.Count.ToString() + " mon hoc";
            lbTong.ForeColor = Color.Black;
            lbTong.Font = new Font(lbTong.Font, FontStyle.Bold);

        }

    
        public void loadCombo()
        {
            // load cbMaGV
            cbMaGV.DataSource = gv.ShowGV();
            cbMaGV.DisplayMember = "MaGV";
            cbMaGV.ValueMember = "MaGV";

            //load colMaGV
            colMaGV.DataSource = gv.ShowGV();
            colMaGV.DisplayMember = "TenGV";
            colMaGV.ValueMember = "MaGV";

            // chi cho chon 
            cbTK.DropDownStyle = ComboBoxStyle.DropDownList; 
            // Add Item vao cbTK 
           cbTK.Items.Add("Ma MH"); 
            cbTK.Items.Add("Ten MH");
            cbTK.Items.Add("Ma GV");                  
            
        }
        private void frmMonHoc_Load(object sender, EventArgs e)
        {

            loadCombo();
            loadDgvMH();

        }

        private void dgvMH_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong = e.RowIndex;
            txtMH.Text = dgvMH.Rows[dong].Cells[0].Value.ToString();
            txTenMH.Text = dgvMH.Rows[dong].Cells[1].Value.ToString(); ;
            cbMaGV.SelectedValue = dgvMH.Rows[dong].Cells[2].Value.ToString(); ;

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show(" ban co chac xoa ten mon hoc" +txTenMH.Text+ " hay khong ?" ,
                    " Thong bao" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    int r = dgvMH.CurrentCell.RowIndex;

                    //int r = dgvMH.SelectedRows.Count;

                    string strmaMH = dgvMH.Rows[r].Cells[0].Value.ToString();
                    mh.DeleteMH(strmaMH);
                    MessageBox.Show("khong co du lieu trong he thong de xoa ");
                    frmMonHoc_Load(sender, e);
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("khong co du lieu trong he thong de xoa ");
                return;
            }

        }

        private void btThem_Click(object sender, EventArgs e)
        {
            try
            {

                //mh.InsertMH(txtMaMH.Text, txtMonHoc.Text, Int32.Parse(txtSoTC.Text), Int32.Parse(txtSoTiet.Text), cbMaGV.SelectedValue.ToString());
                MessageBox.Show(" ban da them mon hoc " + txTenMH.Text + " voi ma " + txtMH.Text + "!!! Thanh cong");
                frmMonHoc_Load(sender, e);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(" da ton tai ma mon hoc " + txtMH.Text + "!!! Ban hay nhap ma khac");
                txtMH.ResetText();
                txtMH.Focus();
                return;
            }


        }

        private void btSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("ban co muon sua ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    int r = dgvMH.CurrentCell.RowIndex;
                    string strmadk = dgvMH.Rows[r].Cells[0].Value.ToString();
                  //  mh.Update(strmadk, this.txtMH.Text, txTenMH.Text, cbMaGV.SelectedValue.ToString());
                    MessageBox.Show(" ban da sua Thanh cong");
                   // frmMonHoc_Load(sender, e);
                    loadDgvMH();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("loi" + ex.Message);
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            string key = txtSearch.Text.ToString().Trim();
            try
            {
                if (cbTK.SelectedItem.ToString() == "Ma MH")
                {
                    dgvMH.DataSource = mh.SearchByID(key);
                    if (dgvMH.Rows.Count == 0)
                    {
                        this.lbTong.ForeColor = Color.Red;
                        this.lbTong.Text = " khong tim thay";
                    }
                    else
                    {
                        this.lbTong.ForeColor = Color.BlueViolet;
                        this.lbTong.Text = " Co tong so : " + dgvMH.Rows.Count.ToString() + " Mon hoc ";
                    }
                }
                else if (cbTK.SelectedItem.ToString() == "Ten MH")
                {
                    dgvMH.DataSource = mh.SearchByName(key);
                    if (dgvMH.Rows.Count == 0)
                    {
                        this.lbTong.ForeColor = Color.Red;
                        this.lbTong.Text = " khong tim thay";
                    }
                    else
                    {
                        this.lbTong.ForeColor = Color.BlueViolet;
                        this.lbTong.Text = " Co tong so : " + dgvMH.Rows.Count.ToString() + " Mon hoc ";
                    }
                }
                else if (cbTK.SelectedItem.ToString() == "Ma GV")
                {
                    dgvMH.DataSource = mh.SearchMonHocByIdGV(key);
                    if (dgvMH.Rows.Count == 0)
                    {
                        this.lbTong.ForeColor = Color.Red;
                        this.lbTong.Text = " khong tim thay";
                    }
                    else
                    {
                        this.lbTong.ForeColor = Color.BlueViolet;
                        this.lbTong.Text = " Co tong so : " + dgvMH.Rows.Count.ToString() + " Mon hoc ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" ban phai chon kieu tim kiem ");
                return;
                

            }


        }

        private void cbTK_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            txtSearch.Focus();
        }

        private void btTK_Click(object sender, EventArgs e)
        {
            if (txtSearch.TextLength == 0)
            {
                MessageBox.Show(" ban phai nhap ki tu tim kiem ");
                txtSearch.Focus();
                return;
            }
            string key = txtSearch.Text.Trim();
            try
            {
                if (cbTK.SelectedItem.ToString() == "Ma MH")
                {
                    dgvMH.DataSource = mh.SearchByID(key);
                    if (dgvMH.Rows.Count == 0)
                    {
                        this.lbTong.ForeColor = Color.Red;
                        this.lbTong.Text = " khong tim thay";
                        txtMH.Text = "";
                        txTenMH.Text = "" ;
                    }
                    else
                    {
                        this.lbTong.ForeColor = Color.BlueViolet;
                        this.lbTong.Text = " Co tong so : " + dgvMH.Rows.Count.ToString() + " Mon hoc ";
                    }
                }
                else if (cbTK.SelectedItem.ToString() == "Ten MH")
                {
                    dgvMH.DataSource = mh.SearchByName(key);
                    if (dgvMH.Rows.Count == 0)
                    {
                        this.lbTong.ForeColor = Color.Red;
                        this.lbTong.Text = " khong tim thay";
                    }
                    else
                    {
                        this.lbTong.ForeColor = Color.BlueViolet;
                        this.lbTong.Text = " Co tong so : " + dgvMH.Rows.Count.ToString() + " Mon hoc ";
                    }
                }
                else if (cbTK.SelectedItem.ToString() == "Ma GV")
                {
                    dgvMH.DataSource = mh.SearchMonHocByIdGV(key);
                    if (dgvMH.Rows.Count == 0)
                    {
                        this.lbTong.ForeColor = Color.Red;
                        this.lbTong.Text = " khong tim thay";
                    }
                    else
                    {
                        this.lbTong.ForeColor = Color.BlueViolet;
                        this.lbTong.Text = " Co tong so : " + dgvMH.Rows.Count.ToString() + " Mon hoc ";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" ban phai chon kieu tim kiem ");
                return;


            }

        }

        
    }    
        
    
}
