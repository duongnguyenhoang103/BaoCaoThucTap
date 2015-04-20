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
    public partial class UCNhapDiemSV : UserControl
    {
        public UCNhapDiemSV()
        {
            InitializeComponent();
        }

        LopBE l = new LopBE();
        MonHocBE mh = new MonHocBE();
        SinhVienBE sv = new SinhVienBE();
        NhapDiemSV_BE ndiem = new NhapDiemSV_BE();

        private void loadComBo()
        {

            // load cb Malop
            cbMaL.DataSource = l.ShowLop();
            cbMaL.DisplayMember = "MaLop";
            cbMaL.ValueMember = "MaLop";
            //load Cb MonHoc
            cbMH.DataSource = mh.ShowMH();
            cbMH.DisplayMember = "TenMH";
            cbMH.ValueMember = "MaMH";
        }
        private void UCNhapDiemSV_Load(object sender, EventArgs e)
        {
            string keyMaMH = cbMH.SelectedValue != null ? cbMH.SelectedValue.ToString() : string.Empty;    
            MaMH.DataSource = ndiem.GetMH(keyMaMH);
            MaMH.DisplayMember = "MaMH";
            MaMH.ValueMember = "MaMH";
            //loadComBo();
            cbMaL.SelectedValue = -1;
            cbMaL.ResetText();
            cbMH.SelectedValue  = -1;
            cbMH.ResetText();
            lbTg.Visible = false;
            btSua.Visible = false;
            btXoa.Visible = false;
        }
        private void dgvDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbMaL_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string key = cbMaL.Text;
            //columMaLop.DataSource = sv.GetSVByIdMaLop(key);
            //columMaLop.DisplayMember = "MaSV";
            //columMaLop.ValueMember = "MaSV";
        }
        private void GetSVByCb()
        {
            string key = cbMaL.SelectedValue != null ? cbMaL.SelectedValue.ToString() : string.Empty;
            string keyMaMH = cbMH.SelectedValue != null ? cbMH.SelectedValue.ToString() : string.Empty;
            string keyHocKi = cbHocKi.Text;
            if (!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(keyMaMH) && !string.IsNullOrEmpty(keyHocKi))        
            {
                DataTable dt = ndiem.GetMaSVByMaLop(key);
                var lst = new List<NhapDiemSV_BE>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhapDiemSV_BE obj = new NhapDiemSV_BE();
                    obj.MaSV = dt.Rows[i]["MaSV"].ToString();
                    obj.TenSV = dt.Rows[i]["TenSV"].ToString();
                    obj.MaLop = key;
                    obj.MaMH = keyMaMH;
                    obj.HocKi = Int32.Parse(keyHocKi.ToString());
                    obj.DiemQTHeS1 = 0;
                    obj.DiemQTHeS2 = 0;
                    obj.DiemThi = 0;
                    obj.DiemTP = 0;
                    obj.DiemTBHP = 0;
                    obj.LanThi = 1;
                    obj.DiemChuTBHP = "F";
                    lst.Add(obj);

                }
                dgvDiem.DataSource = lst;
                if ( lst != null &&  dt.Rows.Count > 0)
                {
                    lbTg.Visible = true;
                    lbTg.Text = "có tổng số: " + dgvDiem.RowCount.ToString() + " sinh viên";
                    lbTg.ForeColor = Color.BlueViolet;
                    lbTg.Font = new Font(lbTg.Font, FontStyle.Italic);
                }
            }
            else
            {
                DataTable dt = new DataTable();
                var lst = new List<NhapDiemSV_BE>();
                dgvDiem.DataSource = lst;
                lbTg.Visible = false;
                   
            
            }       
        }
        private void cbMaL_SelectedValueChanged(object sender, EventArgs e)
        {
           // loadComBo();
            GetSVByCb();
           
        }

        private void GetMhByCb()
        {
             GetSVByCb();
            string keyMaLop = cbMaL.SelectedValue != null ? cbMaL.SelectedValue.ToString() : string.Empty;
            string keyMH = cbMH.SelectedValue != null ? cbMH.SelectedValue.ToString() : string.Empty;
            string keyHocKi = cbHocKi.SelectedValue != null ? cbHocKi.SelectedValue.ToString() : string.Empty;
            if (!string.IsNullOrEmpty(keyMaLop) && !string.IsNullOrEmpty(keyMH) && !string.IsNullOrEmpty(keyHocKi))
            {
                DataTable dt = ndiem.GetMH(keyMH);
                var lst = new List<NhapDiemSV_BE>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    NhapDiemSV_BE obj = new NhapDiemSV_BE();             
                    obj.MaMH = keyMH;
                    lst.Add(obj);

                }            
                MaMH.DataSource = ndiem.GetMH(keyMH);
                MaMH.DisplayMember = "MaMH";
                MaMH.ValueMember = "MaMH";
                MaMH.DataSource = lst;
            }
        }

        private void cbMH_SelectedValueChanged(object sender, EventArgs e)
        {

            GetMhByCb();
        }

        private void cbHocKi_SelectedValueChanged(object sender, EventArgs e)
        {
            GetSVByCb();
        }
        private void dgvDiem_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
         
            dgvDiem.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void cbMaL_MouseClick(object sender, MouseEventArgs e)
        {
            // load cb Malop
            cbMaL.DataSource = l.ShowLop();
            cbMaL.DisplayMember = "MaLop";
            cbMaL.ValueMember = "MaLop";
        }

        private void cbMH_MouseClick(object sender, MouseEventArgs e)
        {
            cbMH.DataSource = mh.ShowMH();
            cbMH.DisplayMember = "TenMH";
            cbMH.ValueMember = "MaMH";
        }

        private void CheckNum()
        {
            //NhapDiemSV_BE obj = new NhapDiemSV_BE();
            //int vt = dgvDiem.CurrentCell.RowIndex;

            //obj.MaSV = dgvDiem.Rows[vt].Cells["MaSV"].Value.ToString();
            //obj.MaMH = dgvDiem.Rows[vt].Cells["MaMH"].Value.ToString();
            //obj.MaLop = dgvDiem.Rows[vt].Cells["MaLop"].Value.ToString();
            //obj.LanThi = int.Parse(dgvDiem.Rows[vt].Cells["LanThi"].Value.ToString());
            //obj.DiemChuTBHP = dgvDiem.Rows[vt].Cells["DiemChuTBHP"].Value.ToString();
            //obj.DiemQTHeS1 = float.Parse(dgvDiem.Rows[vt].Cells["DiemQTHeS1"].Value.ToString());
            //obj.DiemQTHeS2 = float.Parse(dgvDiem.Rows[vt].Cells["DiemQTHeS2"].Value.ToString());
            //obj.DiemTP = float.Parse(dgvDiem.Rows[vt].Cells["DiemTP"].Value.ToString());
            //obj.DiemThi = float.Parse(dgvDiem.Rows[vt].Cells["DiemThi"].Value.ToString());
            //obj.DiemTBHP = float.Parse(dgvDiem.Rows[vt].Cells["DiemTBHP"].Value.ToString());
            //obj.HocKi = int.Parse(dgvDiem.Rows[vt].Cells["HocKi"].Value.ToString());
            //obj.SoTietNghi = int.Parse(dgvDiem.Rows[vt].Cells["SoTietNghi"].Value.ToString());
            //if (dgvDiem.Rows.Count > 0)
            //{

            //    float Num;
            //    bool ktra = float.TryParse(obj.DiemQTHeS1.ToString(), out Num);
            //    if (!ktra)
            //    {
            //        MessageBox.Show("hãy nhập số");
            //        return;
            //    }
            //}
              
        }
        private void dgvDiem_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            

            NhapDiemSV_BE obj = new NhapDiemSV_BE();
            if (dgvDiem.Rows.Count > 0)
            {               
                int vt = dgvDiem.CurrentCell.RowIndex;
                //set diemTP
                obj.DiemQTHeS1 = float.Parse(dgvDiem.Rows[vt].Cells["DiemQTHeS1"].Value.ToString());
                obj.DiemQTHeS2 = float.Parse(dgvDiem.Rows[vt].Cells["DiemQTHeS2"].Value.ToString());
                obj.DiemTP = (float)Math.Round((obj.DiemQTHeS1 + obj.DiemQTHeS2 * 2) / 3, 1);
                dgvDiem.CurrentRow.Cells["DiemTP"].Value=obj.DiemTP;
                //set diemTBHP
                obj.DiemTP = float.Parse(dgvDiem.Rows[vt].Cells["DiemTP"].Value.ToString());
                obj.DiemThi = float.Parse(dgvDiem.Rows[vt].Cells["DiemThi"].Value.ToString());
                obj.DiemTBHP = (float)Math.Round((obj.DiemTP*3+obj.DiemThi*7)/10,1);
                dgvDiem.CurrentRow.Cells["DiemTBHP"].Value = obj.DiemTBHP;
                // set diem chu
                if (obj.DiemTBHP >= 9 && obj.DiemTBHP <= 10)
                {
                    obj.DiemChuTBHP = "A+";
                    dgvDiem.CurrentRow.Cells["DiemChuTBHP"].Value = obj.DiemChuTBHP;
                }
                if (obj.DiemTBHP >= 8.5 && obj.DiemTBHP <= 8.9)
                {
                    obj.DiemChuTBHP = "A";
                    dgvDiem.CurrentRow.Cells["DiemChuTBHP"].Value = obj.DiemChuTBHP;
                }
                if (obj.DiemTBHP >= 8.0 && obj.DiemTBHP <= 8.4)
                {
                    obj.DiemChuTBHP = "B+";
                    dgvDiem.CurrentRow.Cells["DiemChuTBHP"].Value = obj.DiemChuTBHP;
                }
                if (obj.DiemTBHP >= 7.0 && obj.DiemTBHP <= 7.9)
                {
                    obj.DiemChuTBHP = "B";
                    dgvDiem.CurrentRow.Cells["DiemChuTBHP"].Value = obj.DiemChuTBHP;
                }
                if (obj.DiemTBHP >= 6.5 && obj.DiemTBHP <= 6.9)
                {
                    obj.DiemChuTBHP = "C+";
                    dgvDiem.CurrentRow.Cells["DiemChuTBHP"].Value = obj.DiemChuTBHP;
                }
                if (obj.DiemTBHP >= 5.5 && obj.DiemTBHP <= 6.4)
                {
                    obj.DiemChuTBHP = "C";
                    dgvDiem.CurrentRow.Cells["DiemChuTBHP"].Value = obj.DiemChuTBHP;
                }
                if (obj.DiemTBHP >= 4.0 && obj.DiemTBHP <= 5.4)
                {
                    obj.DiemChuTBHP = "D";
                    dgvDiem.CurrentRow.Cells["DiemChuTBHP"].Value = obj.DiemChuTBHP;
                }
                if (obj.DiemTBHP < 4.0)
                {
                    obj.DiemChuTBHP = "F";
                    dgvDiem.CurrentRow.Cells["DiemChuTBHP"].Value = obj.DiemChuTBHP;
                }

            }

        }

        private void SetDiemTP()
        {                            
         
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {                         
                 var lst = dgvDiem.DataSource as List<NhapDiemSV_BE>;
                 for (int i = 0; i < lst.Count; i++)
                 {
                     NhapDiemSV_BE obj = new NhapDiemSV_BE();
                     obj.MaSV = lst[i].MaSV;
                     obj.MaMH = lst[i].MaMH;
                     obj.MaLop = lst[i].MaLop;
                     obj.LanThi = lst[i].LanThi;
                     obj.DiemChuTBHP = lst[i].DiemChuTBHP;
                     obj.DiemQTHeS1 = lst[i].DiemQTHeS1;
                     obj.DiemQTHeS2 = lst[i].DiemQTHeS2;
                     obj.DiemTP = lst[i].DiemTP;
                     obj.DiemThi = lst[i].DiemThi;
                     obj.DiemTBHP = lst[i].DiemTBHP;
                     obj.HocKi = lst[i].HocKi;
                     obj.SoTietNghi = lst[i].SoTietNghi;
                     bool check = ndiem.CheckDiemThiSV(obj.MaSV, obj.MaLop, obj.MaMH, obj.LanThi);
                     if (!check)
                     {
                         ndiem.InsertDiem(obj.MaSV, obj.MaLop, obj.MaMH, obj.DiemQTHeS1, obj.DiemQTHeS2, obj.DiemThi, obj.DiemTP, obj.DiemTBHP, obj.DiemChuTBHP, obj.LanThi, obj.HocKi, obj.SoTietNghi);
                         MessageBox.Show(" tạo điểm cho sinh viên "+obj.MaSV.Trim() + " thành công");

                     }
                     else
                     {
                         MessageBox.Show(" điểm môn học với sinh viên có mã: "+obj.MaSV.Trim() + " này đã được nhập");
                     }         
                 }
                                        
            }
            catch (Exception ex)
            {

                MessageBox.Show("lỗi"+ex);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            cbMaL.ResetText();
            cbMH.ResetText();
            cbHocKi.ResetText();
            GetSVByCb();
        }

       

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

     

    

       
    }
}
