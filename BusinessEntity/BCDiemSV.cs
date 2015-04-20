using AccessData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BusinessEntity
{
  public class BCDiemSV
    {
      DataConnect kn = new DataConnect();
      public DataTable GetKhoa()
      {
          string sql = " select  * from tbl_KHOA";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }
      public DataTable GetNghanhByKhoa(string maKhoa)
      {
          string sql = @" select * from tbl_Nghanh A
                        INNER JOIN tbl_KHOA B
                        ON A.MaKhoa = B.MaKhoa
                        Where A.MaKhoa = '"+maKhoa+"' ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }
      public DataTable GetLopByNghanh(string maNghanh)
      {
          string sql = @" select * from tbl_LOP A
                            INNER JOIN tbl_NGHANH B
                            ON A.MaNghanh= B.MaNghanh
                            Where A.MaNghanh = '" + maNghanh+ "' ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }
      public DataTable GetMonHoc()
      {
        string sql = @"  select * from tbl_MONHOC A";
          DataTable dt = new DataTable ();
          dt= kn.GetTable(sql);
          return dt;
      }
      public DataTable GetSVByLop(string maLop)
      {
          string sql = @"select distinct * from tbl_SINHVIEN A
                            INNER JOIN tbl_LOP B
                            ON A.MaLop= B.MaLop
                            Where A.MaLop = '"+maLop+"' ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }    
     public DataTable Search( string maK, string maN, string maL,string maSV, string hocKi,string maMH )
     {
         DataTable dt = new DataTable();
         try
         {
             string sql = @"SELECT A.MaSV, A.TenSV,A.GioiTinh,A.NgaySinh, ISNULL(F.MaMH,'') AS MaMH ,F.SoTinChi ,
                                   E.DiemTP ,E.DiemThi,E.LanThi ,E.DiemTBHP ,E.DiemChuTBHP ,E.HocKi 
                            FROM tbl_SINHVIEN A
                            INNER JOIN tbl_LOP B
                            ON A.MaLop = B.MaLop
                            INNER JOIN tbl_NGHANH C
                            ON B.MaNghanh = C.MaNghanh
                            INNER JOIN tbl_KHOA D
                            ON C.MaKhoa = D.MaKhoa
                            INNER JOIN tbl_DIEM E
                            ON A.MaSV = E.MaSV
							INNER JOIN tbl_MONHOC F
							ON F.MaMH =E.MaMH
                            WHERE 1 = 1 ";
            if (!string.IsNullOrEmpty(maL))
	        {
		        sql+= " AND B.MaLop = '"+maL+"' ";
	        }
            if (!string.IsNullOrEmpty(maN))
	        {
		        sql+= " AND C.MaNghanh = '"+maN+"' ";
	        }
            if (!string.IsNullOrEmpty(maK))
	        {
		        sql+= "  AND D.MaKhoa  = '"+maK+"' ";
	        }
            if (!string.IsNullOrEmpty(maSV))
            {
                sql += " AND A.MaSV = '"+maSV+"' ";
            }
            if (!string.IsNullOrEmpty(maMH))
            {
                sql += "  AND F.MaMH = '"+maMH+"' ";
            }
            if (!string.IsNullOrEmpty(hocKi))
            {
                sql += " AND E.HocKi= '"+hocKi+"' ";
            }
            sql += @"GROUP BY A.MaSV, A.TenSV,A.GioiTinh,A.NgaySinh,F.MaMH,F.SoTinChi,E.DiemTP,E.DiemThi,E.LanThi,E.DiemTBHP,E.DiemChuTBHP,E.HocKi";
            sql += " ORDER BY E.HocKi";
            dt = kn.GetTable(sql);             
         }
         catch (Exception ex )
         {
             
             throw ex;
         }
         return dt;
       }               
    }
}
