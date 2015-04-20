using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessEntity;
using DeMoQLSV1.Report;

namespace DeMoQLSV1
{
    public partial class UC_BCThongKeSV : UserControl
    {
        public UC_BCThongKeSV()
        {
            InitializeComponent();
            // khai bao thuoc tính cho ComboSearch auto
             //  1.AutoComPeleteMode = Suggest;
            //  2.AutoComPeleteSource = ListItems;
            //  3.DisPlaymember = text;
            //  4.DrawMode = OwenrDrawVariable;
        }
        BCThongKeSvBE bcSV = new BCThongKeSvBE();
        LopBE lp = new LopBE();
        KhoaBE k = new KhoaBE();
        NghanhBE n = new NghanhBE();
        public void loadComb()
        {
            cbML.DataSource = lp.ShowLop();
            cbML.DisplayMember = "MaLop";
            cbML.ValueMember = "MaLop";

            // load CbKhoa
            cbK.DataSource = k.ShowKhoa();
            cbK.DisplayMember = "MaKhoa";
            cbK.ValueMember = "MaKhoa";
            //load CbMaNganh
            cbN.DataSource = n.ShowNghanh();
            cbN.DisplayMember = "MaNganh";
            cbN.ValueMember = "MaNghanh";
        }
        private void UC_BCThongKeSV_Load(object sender, EventArgs e)
        {
            lbTg.Text = "";
            loadComb();
            cbML.SelectedValue = -1;
            cbML.ResetText();
            cbK.SelectedValue = -1;
            cbN.SelectedValue = -1;
            cbN.ResetText();
            btIn.Enabled = false;
            btHuy.Enabled = false;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {       
            string maL = cbML.Text;
            string maK = cbK.Text;
            string maN = cbN.Text;
            dgvSV.DataSource = bcSV.Search(maK,maN,maL);
            if (dgvSV.Rows.Count > 0)
            {
                lbTg.Text = "có tống số: " + dgvSV.Rows.Count.ToString() + "sinh viên";
                lbTg.ForeColor = Color.BlueViolet;
                lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                btIn.Enabled = true;
                btHuy.Enabled = true;
            }
            else
            {
                lbTg.Text = "không có";
                lbTg.ForeColor = Color.Red;
                lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                btIn.Enabled = false;
            }


        }

        private void btIn_Click(object sender, EventArgs e)
        {
            if (cbK.Text != "" && cbN.Text != "" && cbML.Text != "" )
            {
                frmRP_DSSV vfrmDSSV = new frmRP_DSSV();
                vfrmDSSV.paratext_maK = cbK.Text.Trim();
                vfrmDSSV.paratext_maN = cbN.Text.Trim();
                vfrmDSSV.paratext_maL = cbML.Text.Trim();
                vfrmDSSV.ShowDialog();
            }
          
        }

        private void dgvSV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvSV.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }



        private void cbSearch_TextChanged(object sender, EventArgs e)
        {
            //    string key = cbSearch.Text;
            //    cbSearch.DataSource = bcSV.getLopByIdLop(key);
            //    cbSearch.DisplayMember = "MaLop";
            //    cbSearch.ValueMember = "MaLop";

            //    dgvSV.DataSource = bcSV.getSvByIdLop(key);
            //    if (dgvSV.Rows.Count > 0)
            //    {
            //        lbTg.Text = "có tống số: " + dgvSV.Rows.Count.ToString() + "sinh viên";
            //        lbTg.ForeColor = Color.BlueViolet;
            //        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
            //    }
            //    else
            //    {
            //        lbTg.Text = "không có";
            //        lbTg.ForeColor = Color.Red;
            //        lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
            //    }
        }


        private void cbSearch_MouseClick(object sender, MouseEventArgs e)
        {
            cbML.ResetText();
        }
        private void Reset()
        {
            string key = cbML.Text.Trim();
            cbML.ResetText();
           // cbML.Focus();
            string key1 = cbN.Text.Trim();
            cbN.ResetText();
            string key2 = cbK.Text.Trim();
            cbK.ResetText();
            if (key == "")
            {
                
                DataTable dt = new System.Data.DataTable();
                dgvSV.Rows.Clear();
            }
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
           
            cbK.ResetText();
            cbN.ResetText();
            cbML.ResetText();
            cbK.SelectedText = "";
            cbN.SelectedText = "";
            cbML.SelectedText = "";
            dgvSV.DataSource = bcSV.Search(cbK.SelectedText, cbN.SelectedText, cbML.SelectedText);  
            lbTg.Visible = false;
            btHuy.Enabled = false;
            btIn.Enabled = false;
        }

        private void cbK_SelectedValueChanged(object sender, EventArgs e)
        {
            string key = cbK.SelectedValue != null ? cbK.SelectedValue.ToString().Trim() : string.Empty;
            cbN.DataSource = bcSV.getNganhByKhoa(key);
            cbN.ValueMember = "MaNghanh";
            cbN.DisplayMember = "MaNghanh";
        }

        private void cbN_SelectedValueChanged(object sender, EventArgs e)
        {
            string key = cbN.SelectedValue != null ? cbN.SelectedValue.ToString().Trim() : string.Empty;
            cbML.DataSource = bcSV.getLopByNganh(key);
            cbML.ValueMember = "MaLop";
            cbML.DisplayMember = "MaLop";
        }

    }
}