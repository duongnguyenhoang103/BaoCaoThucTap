using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AccessData;

namespace BusinessEntity
{
    public class NguoiDungBE
    {
        SqlCommand cmd = null;



        DataConnect da = new DataConnect();

        public bool CheckLogin(string taikhoan, string matkhau)
        {
            string sql = " select * from tbl_NGUOIDUNG where TaiKhoan = '"+ taikhoan +"' and MatKhau = '"+matkhau +"'";
           return da.CheckRead(sql);
            
        }
    }
}