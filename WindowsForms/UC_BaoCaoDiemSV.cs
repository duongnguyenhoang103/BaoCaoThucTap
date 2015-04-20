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
    public partial class UC_BaoCaoDiemSV : UserControl
    {
        public UC_BaoCaoDiemSV()
        {
            InitializeComponent();
        }
        SinhVienBE sv = new SinhVienBE();
        LopBE lp = new LopBE();
        MonHocBE mh = new MonHocBE();
        DiemBE d = new DiemBE();
        KhoaBE k = new KhoaBE();
        NghanhBE n = new NghanhBE();
        BCDiemSV bcDiem = new BCDiemSV();
        private void UC_BaoCaoDiemSV_Load(object sender, EventArgs e)
        {
            loadCombo();
            cbHocKi.SelectedIndex = 0;
            cbMaMon.SelectedIndex = -1;
            cbMaSV.SelectedIndex = -1;
            cbK.ResetText();
            cbN.ResetText();
            cbML.ResetText();
            cbMaSV.ResetText();
            cbMaMon.ResetText();
            btIn.Enabled = false;
            lbTg.Visible = false;
            btSearch.Enabled = false;
            btIn.Enabled = false;
            btReset.Enabled = false;
        }

        private void loadCombo()
        {
           // load CB Khoa
            cbK.DataSource = k.ShowKhoa();
            cbK.DisplayMember = "MaKhoa";
            cbK.ValueMember = "MaKhoa";
            //load Nganh
            cbN.DataSource = n.ShowNghanh();
            cbN.DisplayMember = "MaNghanh";
            cbN.ValueMember = "MaNghanh";
            //load CbMaLop
            cbML.DataSource = lp.ShowLop();
            cbML.DisplayMember = "MaLop";
            cbML.ValueMember = "MaLop";
            //load Cb MaMonHoc
            cbMaMon.DataSource = mh.ShowMH();
            cbMaMon.DisplayMember = "MaMH";
            cbMaMon.ValueMember = "MaMH";
            //load Cb Sinh vien 
            cbMaSV.DataSource = sv.GetAllSV();
            cbMaSV.DisplayMember = "MaSV";
            cbMaSV.ValueMember = "MaSV";                
        }
        private void dgvDiemSV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDiemSV.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {         
            string maK = cbK.Text;
            string maN = cbN.Text;
            string maL = cbML.Text;
            string maSV = cbMaSV.Text;
            string hocKi = cbHocKi.Text;
            string maMH = cbMaMon.Text;          
            dgvDiemSV.DataSource = bcDiem.Search(maK,maN,maL,maSV,hocKi,maMH);
            if (dgvDiemSV.Rows.Count > 0)
            {
                lbTg.Text = "có tống số: " + dgvDiemSV.Rows.Count.ToString() + "sinh viên";
                lbTg.ForeColor = Color.BlueViolet;
                lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                lbTg.Visible = true;
                btIn.Enabled = true;
            }
            else
            {
                lbTg.Text = "không có";
                lbTg.ForeColor = Color.Red;
                lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                lbTg.Visible = true;
                btIn.Enabled = false;
            }

        }

        private void SetNganhByKhoa()
        {
            btSearch.Enabled = true;
            btReset.Enabled = true;
            string key = cbK.SelectedValue != null ? cbK.SelectedValue.ToString() : string.Empty;
            cbN.DataSource = bcDiem.GetNghanhByKhoa(key);
            cbN.ValueMember = "MaNghanh";
            cbN.DisplayMember = "MaNghanh";
        }
        private void cbK_SelectedValueChanged(object sender, EventArgs e)
        {
            SetNganhByKhoa();
        }

        private void cbN_SelectedValueChanged(object sender, EventArgs e)
        {
           
            string key = cbN.SelectedValue != null ? cbN.SelectedValue.ToString() : string.Empty;
            cbML.DataSource = bcDiem.GetLopByNghanh(key);
            cbML.ValueMember = "MaLop";
            cbML.DisplayMember = "MaLop";

        }

        private void cbML_SelectedValueChanged(object sender, EventArgs e)
        {
          
            string key = cbML.SelectedValue != null ? cbML.SelectedValue.ToString() : string.Empty;
            cbMaSV.DataSource = bcDiem.GetSVByLop(key);
            cbMaSV.ValueMember = "MaSV";
            cbMaSV.DisplayMember = "MaSV";
        }
        private void btIn_Click(object sender, EventArgs e)
        {
            #region in điểm tất cả MH của 1 sv theo hoc kì
            if (cbK.Text != "" && cbN.Text != "" && cbML.Text != "" && cbHocKi.Text != "" && cbMaSV.Text != "" && cbMaMon.Text == "")
            {
                frmRP_BangDiemSVTheoHK vfrRpDiemMH = new frmRP_BangDiemSVTheoHK();
                vfrRpDiemMH.paratext_maK = cbK.Text;
                vfrRpDiemMH.paratext_maN = cbN.Text;
                vfrRpDiemMH.paratext_maL = cbML.Text;                
                vfrRpDiemMH.paratext_maSV = cbMaSV.Text;
                vfrRpDiemMH.paratext_maHocKi = cbHocKi.Text;
                vfrRpDiemMH.ShowDialog();
            }

            #endregion

            #region in diem ca lop theo mon hoc , hoc ki
            if ((cbK.Text != "" && cbN.Text != "" && cbML.Text != "" && cbMaSV.Text == "" && cbMaMon.Text != "" && cbHocKi.Text != ""))
            {
                frmRP_DiemLopMonHoc vfrRpDssv = new frmRP_DiemLopMonHoc();
                vfrRpDssv.paratext_maK = cbK.Text;
                vfrRpDssv.paratext_maN = cbN.Text;
                vfrRpDssv.paratext_maL = cbML.Text;
                vfrRpDssv.paratext_maMH = cbMaMon.Text;
                vfrRpDssv.paratext_maHocKi = cbHocKi.Text;
                vfrRpDssv.ShowDialog();
            }
            #endregion

            #region in diem ca nam của 1 sv
            if ((cbK.Text != "" && cbN.Text != "" && cbML.Text != ""  && cbMaSV.Text != "" && cbMaMon.Text == "" && cbHocKi.Text == ""))
            {
                frmRP_DiemCaNamSV vfrRpDiemCaNam = new frmRP_DiemCaNamSV();
                vfrRpDiemCaNam.paratext_maK = cbK.Text;
                vfrRpDiemCaNam.paratext_maN = cbN.Text;
                vfrRpDiemCaNam.paratext_maL = cbML.Text;
                vfrRpDiemCaNam.paratext_maSV = cbMaSV.Text;
                vfrRpDiemCaNam.ShowDialog();
            }
            #endregion
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            btReset.Enabled = false;
            btIn.Enabled = false;
            btSearch.Enabled = false;
            cbK.ResetText();
            cbN.ResetText();
            cbML.ResetText();
            cbMaSV.ResetText();
            cbMaMon.ResetText();
            cbHocKi.SelectedIndex = 0;
            cbK.Text = "";
            cbN.Text = "";
            cbML.Text = "";
            cbMaSV.Text = "";
            cbMaMon.Text = "";
            cbHocKi.Text = "1";

            dgvDiemSV.DataSource = bcDiem.Search(cbK.Text, cbN.Text, cbML.Text, cbMaSV.Text, cbMaMon.Text, cbHocKi.Text);
            lbTg.Visible = false;
        }

    

      

      
    }
}
