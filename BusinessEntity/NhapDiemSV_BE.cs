using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using AccessData;

namespace BusinessEntity
{
  public class NhapDiemSV_BE
    {
      public string MaSV{set;get;}
      public string TenSV {set;get;}
      public string MaLop { set; get; }
      public string MaMH { set; get; }
      public float  DiemQTHeS1 { set; get; }
      public float DiemQTHeS2 { set; get; }
      public float DiemTP { set; get; }
      public float DiemThi { set; get; }
      public float DiemTBHP { set; get; }
      public string DiemChuTBHP { set; get; }
      public int LanThi { set; get; }
      public int HocKi { set; get; }
      public int SoTietNghi { set; get; }
     // public string GhiChu { set; get; }

      DataConnect kn = new DataConnect ();
      public DataTable GetMaSVByMaLop(string key)
      {
          try
          {
              string sql = @" select Distinct sv.MaSV ,sv.TenSV
                              from tbl_SINHVIEN  sv ,tbl_LOP lp  
                              Where sv.MaLop = lp.MaLop and sv.MaLop like N'%"+key+"%'";
              DataTable dt = new DataTable();
              dt = kn.GetTable(sql);
              return dt;
          }
          catch (Exception)
          {              
              throw;
          }                   
      }
      public DataTable GetMH(string maMH)
      {
          try
          {
              string sql = @" select Distinct mh.MaMH ,mh.TenMH
                              from tbl_MONHOC mh
                              Where MaMH like N'%"+maMH+"%'";
              DataTable dt = new DataTable();
              dt = kn.GetTable(sql);
              return dt;
          }
          catch (Exception)
          {
              throw;
          }
      }
      public DataTable GetTenSVByMaLop(string maLop)
      {
          try
          {
              string sql = @" select Distinct sv.TenSV
                              from tbl_SINHVIEN  sv ,tbl_LOP lp  
                              Where sv.MaLop = lp.MaLop and sv.MaLop like N'%KT1       %'  ";
              DataTable dt = new DataTable();
              dt = kn.GetTable(sql);
              return dt;
          }
          catch (Exception)
          {
              throw;
          }
      }
      public void InsertDiem(string maSV, string maLop, string maMH, float dHS1, float dHS2, float diemThi, float diemTP, float diemHP, string diemChu, int lanThi, int hocKi, int soTietN)
      {
          try
          {
              string sql = @"insert into tbl_DIEM (MaSV,MaLop,MaMH,DiemQTHeS1,DiemQTHeS2,DiemThi,DiemTP,DiemTBHP,DiemChuTBHP,LanThi,HocKi,SoTietNghi)";
              sql += "values( '" + maSV + "','" + maLop + "','" + maMH + "','" + dHS1 + "','" + dHS2 + "','" + diemThi + "','" + diemTP + "','" + diemHP + "','" + diemChu + "','" + lanThi + "','" + hocKi + "','" + soTietN + "')";
              kn.ExcuteNonQuery1(sql);
          }
          catch (Exception ex)
          {

              throw ex;
          }
      }
      public void updateDiem(string madkSV, string madkL, string madkMH, string madkLanThi, string maSV, string maLop, string maMH, float dHS1, float dHS2, float diemThi, float diemTP, float diemHP, string diemChu, int lanThi, int hocKi, int soTietN)
      {
          try
          {
              string sql = "update tbl_DIEM set MaSV = '" + maSV + "', MaLop='" + maLop + "',MaMH='" + maMH + "', DiemQTHeS1='" + dHS1 + "',DiemQTHeS2='" + dHS2 + "',DiemThi='" + diemThi + "',DiemTP='" + diemTP + "',DiemTBHP='" + diemHP + "',DiemChuTBHP='" + diemChu + "',LanThi='" + lanThi + "',HocKi='" + hocKi + "',SoTietNghi='" + soTietN + "'  "
                      + "  where MaSV='" + madkSV + "' and  MaLop='" + madkL + "' and MaMH = '" + madkMH + "'  and LanThi = '" + madkLanThi + "'   ";
              kn.ExcuteNonQuery1(sql);
          }
          catch (Exception ex)
          {

              throw ex;
          }

      }
      public bool CheckDiemThiSV(string maSV, string maLop,string maMH, int lanThi)
      {
          try
          {
              string sql = @"SELECT *
                            FROM tbl_DIEM 
                            WHERE MaSV = '" + maSV + "'";
              sql += " AND MaLop = '" + maLop + "'";
              sql += " AND MaMH = '" + maMH + "'";
              sql += " AND LanThi = '" + lanThi + "'";
              DataTable dt = new DataTable();
              dt = kn.GetTable(sql);
              if (dt != null && dt.Rows.Count > 0)
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
      public void Save(NhapDiemSV_BE lst)
      {
          string result = string.Empty;
          try
          {
              bool check = CheckDiemThiSV(lst.MaSV,lst.MaLop,lst.MaMH,lst.LanThi);
              string sql = string.Empty;
              if (!check)
              {
                  //insert
                  sql = @"insert into tbl_DIEM (MaSV,MaLop,MaMH,DiemQTHeS1,DiemQTHeS2,DiemThi,DiemTP,DiemTBHP,DiemChuTBHP,LanThi,HocKi,SoTietNghi)";
                  sql += "values( '" + lst.MaSV + "','" + lst.MaLop + "','" + lst.MaMH + "','" + lst.DiemQTHeS1 + "','" + lst.DiemQTHeS2 + "','" + lst.DiemThi + "','" + lst.DiemTP + "','" + lst.DiemTBHP + "','" + lst.DiemChuTBHP + "','" + lst.LanThi + "','" + lst.HocKi + "','" + lst.SoTietNghi + "')";
                  // kn.ExcuteNonQuery(sql);
              }
              else
              {
                  //update
                  sql = "update tbl_DIEM set MaSV = '" + lst.MaSV + "', MaLop='" + lst.MaLop + "',MaMH='" + lst.MaMH + "', DiemQTHeS1='" + lst.DiemQTHeS1 + "',DiemQTHeS2='" + lst.DiemQTHeS2 + "',DiemThi='" + lst.DiemThi + "',DiemTP='" + lst.DiemTP + "',DiemTBHP='" + lst.DiemTBHP + "',DiemChuTBHP='" + lst.DiemChuTBHP + "',LanThi='" + lst.LanThi + "',HocKi='" + lst.HocKi + "',SoTietNghi='" + lst.SoTietNghi + "'  "
                      + "  where MaSV='" + lst.MaSV + "' and  MaLop='" + lst.MaLop + "' and MaMH = '" + lst.MaMH + "'  and LanThi = '" + lst.LanThi + "'   ";
              }
              //SAVE
           kn.ExcuteNonQuery(sql);          
          }
          catch (Exception)
          {
              
              throw;
          }
         
      }
    }
}
