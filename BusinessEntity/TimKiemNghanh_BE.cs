using AccessData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
  public class TimKiemNghanh_BE
    {
      DataConnect kn = new DataConnect();

      public DataTable Search(string key)
      {
          DataTable dt = new DataTable();
          try
          {
              string sql = string.Empty;
              if (key == "")
              {
                  sql = @" Select distinct A.MaNghanh,A.TenNghanh,A.SoLop,B.MaKhoa,A.SDT,A.Email,A.DiaChi
                            from tbl_NGHANH A 
							INNER JOIN tbl_KHOA B
                            ON A.MaKhoa = B.MaKhoa 
                            WHERE B.MaKhoa = '' AND B.TenKhoa='' AND A.MaNghanh='' AND A.TenNghanh='' ";                
              }
              else
              {
                  sql = @" Select distinct A.MaNghanh,A.TenNghanh,A.SoLop,B.MaKhoa,A.SDT,A.Email,A.DiaChi
                            from tbl_NGHANH A 
							INNER JOIN tbl_KHOA B
                            ON A.MaKhoa = B.MaKhoa 
                            WHERE  ";
                  if (!string.IsNullOrEmpty(key))
                  {
                      sql += " B.MaKhoa = '" + key + "' ";
                  }
                  if (!string.IsNullOrEmpty(key))
                  {
                      sql += " OR B.TenKhoa like N'%" + key + "%' ";
                  }
                  if (!string.IsNullOrEmpty(key))
                  {
                      sql += "  OR A.MaNghanh  = '" + key + "' ";
                  }
                  if (!string.IsNullOrEmpty(key))
                  {
                      sql += " OR A.TenNghanh like N'%" + key + "%' ";
                  }                  
              }
              sql += " GROUP BY A.MaNghanh,A.TenNghanh,A.SoLop,B.MaKhoa,A.SDT,A.Email,A.DiaChi ";        
              dt = kn.GetTable(sql);
          }
          catch (Exception ex)
          {

              throw ex;
          }
          return dt;
      }
      public void UpdateNghanh(string madk, string maNghanh, string tenNghanh, int soLop, string maKhoa, int sdt, string email, string diaChi)
      {
          string sql = " Update tbl_NGHANH SET MaNghanh ='" + maNghanh + "', TenNghanh =N'" + tenNghanh + "', SoLop= '" + soLop + "', MaKhoa='" + maKhoa + "', SDT='" + sdt + "', Email ='" + email + "' , DiaChi =N'" + diaChi + "' WHERE MaNghanh ='" + madk + "' ";
          kn.ExcuteNonQuery1(sql);
      }
      public void DeleteNganh(string maNganh)
      {
          string sql = "delete tbl_NGHANH where MaNghanh = '" + maNganh + "' ";
          kn.ExcuteNonQuery1(sql);
      }
    }
}
