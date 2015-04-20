using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AccessData;

namespace BusinessEntity
{
  public  class GiaoVienBE
    {
      DataConnect kn = new DataConnect();
      public DataTable ShowGV() 
      {
          string sql = "select * from tbl_GIAOVIEN";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
      return dt;
      }

      public void DeleteGV(string maGV)
      {
          string sql = "delete tbl_GIAOVIEN where MaGV = '" + maGV + "' ";
          kn.ExcuteNonQuery1(sql);
      }

      public void InsertGV(string maGV, string tenGV,string diaChi,string gioiTinh, int sdt, string email)
      {
          string sql = " insert into tbl_GIAOVIEN Values(N'" + maGV + "',N'" + tenGV + "', N'" +diaChi + "',N'" + gioiTinh  + "', '" + sdt + "', '"+email +"')";
          kn.ExcuteNonQuery1(sql);
          // them  N phong truong hop la unicode
      }

      public void UpdateGV(string madk, string maGV, string tenGV, string diaChi, string gioiTinh, int sdt, string email)
      {
          string sql = "update tbl_GIAOVIEN set maGV = N'" + maGV + "', HoTenGV = N'" + tenGV + "',DiaChiGV = N'" + diaChi  + "', GioiTinh=N'" + gioiTinh  + "', SDT = '" + sdt + "', Email ='"+email +"' WHERE MaGV = N'" + madk + "' ";
          kn.ExcuteNonQuery1(sql);
      }

      public DataTable GetGVByIdGV(string key)
      {

          string sql = " select * from tbl_GIAOVIEN  gv"
                          + " Where  gv.MaGV like N'%" + key + "%'  ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }
      public DataTable GetgvByNameGV(string key)
      {

          string sql = " select * from tbl_GIAOVIEN  gv "
                          + " Where gv.HoTenGV  like N'%" + key + "%'  ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }
      public DataTable GetGVByMaGV(string key)
      {

          string sql = " select * from tbl_GIAOVIEN  gv"
                          + " Where  gv.MaGV = N'" + key + "'  ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }
      public DataTable GetgvByTenGV(string key)
      {

          string sql = " select * from tbl_GIAOVIEN  gv "
                          + " Where gv.HoTenGV = N'" + key + "'  ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }
    }
}
