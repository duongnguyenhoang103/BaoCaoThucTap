using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeMoQLSV1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            frmLog _frmLog = new frmLog(this );
            _frmLog.Show();

        }

        private void thongTinSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSV _frSV = new frmSV();
            _frSV.Show();
        }

        private void danhMucLopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLop _frLop = new frmLop();
        _frLop.MdiParent = this;
            _frLop.Show();
        }

        private void thongTinMonHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonHoc _frMH = new frmMonHoc();
           _frMH.MdiParent = this;
            _frMH.Show();
        }

        private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLog _frmLog = new frmLog(this);
            _frmLog.MdiParent = this;
            _frmLog.Show();
        }

        public void EnabelMenu()
        {
            quanLyToolStripMenuItem.Enabled = false ;
            baoCaoToolStripMenuItem.Enabled = false;
        }

        public void ShowMenu()
        {
            quanLyToolStripMenuItem.Enabled = true;
            //baoCaoToolStripMenuItem.Enabled = true;
            dangNhapToolStripMenuItem.Enabled = false;
        }
        public void ShowAllMenu()
        {
            quanLyToolStripMenuItem.Enabled = true ;
            baoCaoToolStripMenuItem.Enabled = true;
            dangNhapToolStripMenuItem.Enabled = false;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
           EnabelMenu();            
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnabelMenu();
            frmLog _frmLog = new frmLog(this);
            _frmLog.MdiParent = this;
            _frmLog.Show();
        }

        private void thoatChuongTrinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes==MessageBox.Show("ban that su muon thoat chuong tring" ,"Thong bao",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
            Application.Exit();
        }

        
    }
}
