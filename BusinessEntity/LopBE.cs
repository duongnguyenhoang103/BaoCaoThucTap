using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AccessData;

namespace BusinessEntity
{
  public class LopBE
    {
      DataConnect da = new DataConnect();

      public DataTable ShowLop()
      {
          string sql = " select  * from tbl_LOP";
          DataTable dt = new DataTable();
          dt = da.GetTable(sql);        
              return dt;
      }

      public DataTable ShowLopByNghanh(string key)
      {
          string sql = string.Empty;
          if (key=="")
          {
              sql = @"select distinct l.MaLop, l.TenLop,l.SoSV,l.MaNghanh,l.KhoaHoc from tbl_LOP l, tbl_NGHANH n 
                            WHERE l.MaNghanh= n.MaNghanh and l.MaNghanh = '' ";
              DataTable dt = new DataTable();
              dt = da.GetTable(sql);
              return dt;
          }
          else
          {
              sql = @"select distinct l.MaLop, l.TenLop,l.SoSV,l.MaNghanh,l.KhoaHoc from tbl_LOP l, tbl_NGHANH n 
                            WHERE l.MaNghanh= n.MaNghanh and l.MaNghanh = '" + key + "' ";
              DataTable dt = new DataTable();
              dt = da.GetTable(sql);
              return dt;
          }
         
      }
      public void DeleteLop(string malop)
      {
          string sql = "delete tbl_LOP where MaLop = '" + malop + "' ";
          da.ExcuteNonQuery1(sql);
      }

      public void InsertLop(string maLop, string tenLop, int soSV, string maNghanh, string khoaHoc)
      {
          string sql = " insert into tbl_LOP Values(N'" +maLop+ "',N'" +tenLop+ "', '"+soSV+"','"+maNghanh +"', '"+khoaHoc +"')";
          da.ExcuteNonQuery1(sql);
          // them  N phong truong hop la unicode
      }
   
      public void UpdateLop(string madk, string maLop, string tenLop, int soSV, string maNghanh, string khoaHoc)
      {
          string sql = "update tbl_LOP set MaLop = N'" + maLop + "', TenLop = N'" + tenLop + "',SoSV = '"+soSV +"', MaNghanh='"+maNghanh +"', KhoaHoc = '"+khoaHoc +"' WHERE MaLop = N'" + madk + "' ";
          da.ExcuteNonQuery1(sql);

         
      

      }

      public DataTable SearchLopByIdMaL(string keywork)
      {
          //string sql = "select * from tbl_LOP WHERE MaLop like N'%"+keywork+"%' or TenLop like N'%"+keywork+"%' "; 
          string sql = "select * from tbl_LOP WHERE MaLop like N'%"+keywork+"%' "; 
          DataTable dt = new DataTable();
          dt = da.GetTable(sql);
          return dt;
      }

      public DataTable SearchLopByNameMaL(string keywork)
      {
          
          string sql = "select * from tbl_LOP WHERE TenLop like N'%" + keywork + "%' ";
          DataTable dt = new DataTable();
          dt = da.GetTable(sql);
          return dt;
      }

      public DataTable SearchLopByIdNghanh(string keywork)
      {

          string sql = @"select distinct l.MaLop, l.TenLop,l.SoSV,l.MaNghanh,l.KhoaHoc from tbl_LOP l, tbl_NGHANH n 
                            WHERE l.MaNghanh= n.MaNghanh and l.MaNghanh like N'%" + keywork + "%' ";
          DataTable dt = new DataTable();
          dt = da.GetTable(sql);
          return dt;
      }
    
      public DataTable SearchLopByNameNghanh(string keywork)
      {

          string sql = "select distinct l.MaLop, l.TenLop,l.SoSV,l.MaNghanh,l.KhoaHoc from tbl_LOP l, tbl_NGHANH n WHERE l.MaNghanh= n.MaNghanh and n.TenNghanh like N'%" + keywork + "%' ";
          DataTable dt = new DataTable();
          dt = da.GetTable(sql);
          return dt;
      }

      public DataTable SearchLopByMaL(string keywork)
      {
          
          string sql = "select * from tbl_LOP WHERE MaLop = N'" + keywork + "' ";
          DataTable dt = new DataTable();
          dt = da.GetTable(sql);
          return dt;
      }

      public DataTable SearchLopByTenL(string keywork)
      {

          string sql = "select * from tbl_LOP WHERE TenLop = N'" + keywork + "' ";
          DataTable dt = new DataTable();
          dt = da.GetTable(sql);
          return dt;
      }

      public DataTable SearchLopByMaNghanh(string keywork)
      {

          string sql = "select distinct l.MaLop, l.TenLop,l.SoSV,l.MaNghanh,l.KhoaHoc from tbl_LOP l, tbl_NGHANH n WHERE l.MaNghanh= n.MaNghanh and l.MaNghanh = N'" + keywork + "' ";
          DataTable dt = new DataTable();
          dt = da.GetTable(sql);
          return dt;
      }

      public DataTable SearchLopByTenNghanh(string keywork)
      {

          string sql = "select distinct l.MaLop, l.TenLop,l.SoSV,l.MaNghanh,l.KhoaHoc from tbl_LOP l, tbl_NGHANH n WHERE l.MaNghanh= n.MaNghanh and n.TenNghanh = N'" + keywork + "' ";
          DataTable dt = new DataTable();
          dt = da.GetTable(sql);
          return dt;
      }
    }
}
