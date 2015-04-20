using AccessData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
   public class TaiKhoanBE
    {
       DataConnect kn = new DataConnect();
       public DataTable showTK()
       {
           try
           {
               string sql = @"select * from tbl_NGUOIDUNG";
               DataTable dt = new DataTable();
               dt = kn.GetTable(sql);
               return dt;
           }
           catch (Exception)
           {
               
               throw;
           }
       }
       public void InsertTK(string tk,string mk)
       {
           string sql = " INSERT INTO tbl_NGUOIDUNG VALUES (N'" + tk + "', N'" + mk + "')";
           kn.ExcuteNonQuery1(sql);
       }
       public void UpdateTK(string dk,string tk, string mk)
       {
           string sql = @" UPDATE tbl_NGUOIDUNG SET TaiKhoan = N'"+tk+"' , MatKhau= N'"+mk+"' ";
           sql += "        WHERE TaiKhoan ='"+dk+"'";
           kn.ExcuteNonQuery1(sql);
       }
       public void DeleteTK(string tk)
       {
           try
           {
               string sql = @"delete from tbl_NGUOIDUNG WHERE TaiKhoan='" + tk + "'";
               kn.ExcuteNonQuery(sql);
           }
           catch (Exception)
           {
               
               throw;
           }
          
       }
       public DataTable GetTKByKey(string key)
       {
           try
           {
               string sql = @"select * from tbl_NGUOIDUNG WHERE TaiKhoan like N'%"+key +"%' ";
               DataTable dt = new DataTable();
               dt = kn.GetTable(sql);
               return dt;
           }
           catch (Exception)
           {

               throw;
           }
       }
       public bool CheckTK(string taiKhoan)
       {
           try
           {
               string sql = @"select * from tbl_NGUOIDUNG WHERE TaiKhoan = N'" + taiKhoan + "' ";
               DataTable dt = new DataTable();
               dt = kn.GetTable(sql);
               if (dt.Rows.Count > 0 && dt != null)
               {
                   return true;
               }
               return false;
           }
           catch (Exception)
           {
               
               throw;
           }        
       }
    }
}
