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
        public static string TaiKhoan { get; set; } // khai báo biến để dùng chung 
               
        DataConnect kn = new DataConnect();

        public bool CheckLogin(string taikhoan, string matkhau)
        {
            string sql = " select * from tbl_NGUOIDUNG where TaiKhoan = '"+ taikhoan +"' and MatKhau = '"+matkhau +"'";
            return kn.CheckRead(sql);
            
        }
        public bool CheckMK(string taikhoan, string matkhau)
        {
            string sql = " select * from tbl_NGUOIDUNG where TaiKhoan = '" + taikhoan + "' and MatKhau = '" + matkhau + "'";
            return kn.CheckRead(sql);

        }
        public void UpdateTK(string dk, string tk, string mk)
        {
            string sql = @" UPDATE tbl_NGUOIDUNG SET TaiKhoan = N'" + tk + "' , MatKhau= N'" + mk + "' ";
            sql += "        WHERE TaiKhoan ='" + dk + "'";
            kn.ExcuteNonQuery1(sql);
        }
    }
}