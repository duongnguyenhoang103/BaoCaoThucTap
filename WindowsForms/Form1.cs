using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace DeMoQLSV1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CloseTab() {
           tabContent.Tabs.Remove(tabContent.SelectedTab); 
        
        }

        private void tabContent_TabItemClose(object sender, DevComponents.DotNetBar.TabStripActionEventArgs e)
        {
            tabContent.Tabs.Remove(tabContent.SelectedTab); 
        }

        public void AddNewTab(string strTabName, UserControl ucContent)
        {
            //-----------If exist tabpage then exit---------------
             foreach (TabItem tabPage in tabContent.Tabs)
                 if (tabPage.Text == strTabName)
                 {
                     tabContent.SelectedTab = tabPage;
                     return;
                 }
             TabControlPanel newTabPanel = new DevComponents.DotNetBar.TabControlPanel();
             TabItem newTabPage = new TabItem(this.components);
             newTabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
             newTabPanel.Location = new System.Drawing.Point(0, 26);
             newTabPanel.Name = "panel" + strTabName ;
             newTabPanel.Padding = new System.Windows.Forms.Padding(1);
             newTabPanel.Size = new System.Drawing.Size(796, 342);
             newTabPanel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
             newTabPanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
             newTabPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
             newTabPanel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
             newTabPanel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                         | DevComponents.DotNetBar.eBorderSide.Bottom)));
             newTabPanel.Style.GradientAngle = 90;
             newTabPanel.TabIndex = 2;
             newTabPanel.TabItem = newTabPage ;
            //----------New tab page------------
             Random ran = new Random();
             newTabPage.Name = strTabName + ran.Next(100000) + ran.Next(22342);
             newTabPage.AttachedControl = newTabPanel ;
             newTabPage.Text = strTabName;
            //-------add form vao tab page------------
             ucContent.Dock = DockStyle.Fill;
             newTabPanel.Controls.Add(ucContent);
            //-------add Tab page to Tab Control------------
             tabContent.Controls.Add(newTabPanel);
             tabContent.Tabs.Add(newTabPage);
             tabContent.SelectedTab = newTabPage; 
        }
     
        private void ctmnMain_Opening(object sender, CancelEventArgs e)
        {
            bool isShow = (tabContent.SelectedTabIndex == 0) ? false : true;

            đóngCácTrangCònLạiToolStripMenuItem.Visible = isShow;
                đóngTấtCảToolStripMenuItem.Visible = isShow;
        }

        private void đóngCácTrangCònLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            int index = tabContent.SelectedTabIndex;
            for (int i = tabContent.Tabs.Count - 1; i > 0; i--)
                if (index != i)
                    tabContent.Tabs.RemoveAt(i);
            tabContent.Refresh();

        }

        public void CloseAllTab()
        {
            int index = tabContent.SelectedTabIndex;
            for (int i = tabContent.Tabs.Count - 1; i > 0; i--)
                tabContent.Tabs.RemoveAt(i);
            tabContent.Refresh();
        }

        private void đóngTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllTab();
        }

        public void ShowUC(string title,UserControl ctl)
        {
            AddNewTab(title, ctl); 
        }

        #region Goi from
        private void buttonItem4_Click(object sender, EventArgs e)
        {
            UC_Khoa uckhoa = new UC_Khoa();
            AddNewTab("Thông tin khoa", uckhoa); 
        }

        private void buttonItem5_Click_1(object sender, EventArgs e)
        {
            UC_Nghanh ucNganh = new UC_Nghanh();
            AddNewTab("Thông tin nghành", ucNganh);
        }

        private void buttonItem7_Click(object sender, EventArgs e)
        {
            UC_SinhVien ucSV = new UC_SinhVien ();
            AddNewTab("Thông tin sinh viên", ucSV);

        }
        private void buttonItem6_Click(object sender, EventArgs e)
        {
            UC_Lop uclop = new UC_Lop();
            AddNewTab("Thông tin lớp học", uclop);
        }

        private void buttonItem8_Click(object sender, EventArgs e)
        {
            UC_GiangVien uc_gv = new UC_GiangVien();
            AddNewTab("Thông tin giảng viên", uc_gv );
        }

        private void buttonItem10_Click(object sender, EventArgs e)
        {
            UC_Diem ucDiem = new UC_Diem();
            ucDiem.frmShowChildrenForm = new UC_Diem.ShowForms(ShowUC); // goi from con
            ucDiem.CloseTabss = new UC_Diem.CloseTab(CloseTab); // dong from con
            AddNewTab("Thông tin điểm thi sinh viên", ucDiem);
        }
       
        private void buttonItem16_Click(object sender, EventArgs e)
        {
            UC_BCThongKeSV ucBc_SV = new UC_BCThongKeSV();
            AddNewTab("Thống kê sinh viên", ucBc_SV);
        }

        private void buttonItem15_Click(object sender, EventArgs e)
        {
            UC_BaoCaoDiemSV ucBc_SV = new UC_BaoCaoDiemSV();
            AddNewTab("Báo cáo điểm thi sinh viên", ucBc_SV);
        }

        private void buttonItem19_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem9_Click(object sender, EventArgs e)
        {
            UC_MonHoc ucMH = new UC_MonHoc();
            AddNewTab("Thông tin môn học", ucMH);
        }

        private void buttonItem17_Click_1(object sender, EventArgs e)
        {
            UC_TaiKhoan ucTK = new UC_TaiKhoan();
            AddNewTab("Thông tin tài khoản", ucTK);
        }


        private void buttonItem11_Click(object sender, EventArgs e)
        {
             UC_TimKiemSV ucTKSV = new UC_TimKiemSV();
            AddNewTab("Tìm kiếm thông tin sinh viên ", ucTKSV);
        }

        private void buttonItem12_Click(object sender, EventArgs e)
        {
            UC_TimKiemNganh ucTKNganh = new UC_TimKiemNganh();
            AddNewTab("Tìm kiếm thông tin nghanh ", ucTKNganh);
        }

        private void buttonItem17_Click(object sender, EventArgs e)
        {

            frmDangN _frmLog = new frmDangN(this);
            _frmLog.Show();
        }
        #endregion

        public void showMenu()
        {
            //System
                  
            LogOut_buttonItem18.Enabled = true ;
            LogInbuttonItem17.Enabled = false ;
            //Menu hệ thống
            LogOut_ribbonBar2.Enabled = true;
            LogIn_ribbonBar1.Enabled = false;
            // Menu QUản lý
            QuanLy_ribbonTabItem2.Enabled = true;
                QLNghanh_ribbonBar3.Enabled = true;
                QlLop_ribbonBar4.Enabled = true;
                QLKhoa_ribbonBar5.Enabled = true;
                QLSV_ribbonBar6.Enabled = true;
                QLGV_ribbonBar7.Enabled = true;
                QLMH_ribbonBar8.Enabled = true;
                QLD_ribbonBar9.Enabled = true;
                QL_TaiKhoan.Enabled = true;
                //Menu tìm kiếm
            TimKiem_ribbonTabItem3.Enabled = true;
                TkSinhVien_ribbonBar10.Enabled = true;
                TkNghanh_ribbonBar11.Enabled = true;
                //Menu báo cáo
            BaoCao_ribbonTabItem4.Enabled = true;
                BcDiemThiSinhVien_ribbonBar12.Enabled = true;
                BcTkSinhVien_ribbonBar13.Enabled = true;
              //  BcTKGiangVien_ribbonBar14.Enabled = true;

            
            
        }

        public void hideMenu()
        {
            //System
            LogOut_ribbonBar2.Enabled = true;
            LogIn_ribbonBar1.Enabled = false;
            LogOut_buttonItem18.Enabled = false;
          //  LogIn_ribbonBar1.Enabled = true; 
            //Menu HeThong_ribbonTabItem1
           // LogOut_ribbonBar2.Enabled = false;
          //  LogIn_ribbonBar1.Enabled = true;
            // Menu QUản lý
         //   QuanLy_ribbonTabItem2.Enabled = false;
                QLNghanh_ribbonBar3.Enabled = false;
                QlLop_ribbonBar4.Enabled = false;
                QLKhoa_ribbonBar5.Enabled = false;
                QLSV_ribbonBar6.Enabled = false;
                QLGV_ribbonBar7.Enabled = false;
                QLMH_ribbonBar8.Enabled = false;
                QLD_ribbonBar9.Enabled = true;
                QL_TaiKhoan.Enabled = false;
            //Menu tìm kiếm
           // TimKiem_ribbonTabItem3.Enabled = false;
                TkSinhVien_ribbonBar10.Enabled = false;
                TkNghanh_ribbonBar11.Enabled = false;
            //Menu báo cáo
            //BaoCao_ribbonTabItem4.Enabled = false;
                BcDiemThiSinhVien_ribbonBar12.Enabled = true;
                BcTkSinhVien_ribbonBar13.Enabled = false;
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  LogIn_ribbonBar1.Visible = false;
            hideMenu();
            QLD_ribbonBar9.Enabled = false;
            BcDiemThiSinhVien_ribbonBar12.Enabled = false;
            BcTKGiangVien_ribbonBar14.Visible = false;
            frmDangN _frmLog = new frmDangN(this);
            _frmLog.ShowDialog();
            this.reportViewer1.RefreshReport();
        }
       

        private void buttonItem2_Click(object sender, EventArgs e)
        {

            frmDangN _frmLog = new frmDangN(this);
            _frmLog.Show();
        }

        private void buttonItem3_Click(object sender, EventArgs e)
        {
            CloseAllTab();
            hideMenu();
            QLD_ribbonBar9.Enabled = false;
            BcDiemThiSinhVien_ribbonBar12.Enabled = false;

            frmDangN frm = new frmDangN(this);
            frm.ShowDialog(); 

        }

        public void showBtDN()
        {
            LogIn_ribbonBar1.Enabled = true;
            LogOut_ribbonBar2.Enabled = false;
        }

       
      

        private void LogOut_buttonItem18_Click(object sender, EventArgs e)
        {
            CloseAllTab();
            hideMenu();
            LogOut_buttonItem18.Enabled = false;
            LogInbuttonItem17.Enabled = true; 
            frmDangN frm = new frmDangN(this);
            frm.ShowDialog(); 
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

      

       
    }
}
