using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using AccessData ;

namespace BusinessEntity
{
 public class BCThongKeSvBE
    {
     DataConnect kn = new DataConnect();
     public string MaLop { get; set; }
     public string MaKhoa { get; set; }
     public string MaNghanh { get; set; }
     public DataTable showSV()
     {
         string sql = " select sv.MaSV, sv.TenSV, sv.GioiTinh, sv.SDT, sv.DiaChi, sv.Email ,sv.NgaySinh from tbl_SINHVIEN";
         DataTable dt = new DataTable();
         dt = kn.GetTable(sql);
         return dt;
     }
     public DataTable getLopByIdLop(string key)
     {
         string sql = " select * from tbl_LOP lp"
                       + " where lp.MaLop like '" + key + "'  ";
         DataTable dt = new DataTable();
         dt = kn.GetTable(sql);
         return dt;
     }
     public DataTable getSvByIdLop(string key)
     {
         string sql = " select sv.MaSV, sv.TenSV, sv.GioiTinh, sv.SDT, sv.DiaChi, sv.Email ,sv.NgaySinh from tbl_SINHVIEN sv , tbl_LOP lp"
                       + " where sv.MaLop = lp.MaLop and sv.MaLop like '%"+key +"%'  ";
         DataTable dt = new DataTable();
         dt = kn.GetTable(sql);
         return dt;
     }
     public DataTable getSvByMaLop(string key)
     {
         string sql = " select sv.MaSV, sv.TenSV, sv.GioiTinh, sv.SDT, sv.DiaChi, sv.Email ,sv.NgaySinh from tbl_SINHVIEN sv , tbl_LOP lp"
                       + " where sv.MaLop = lp.MaLop and sv.MaLop like '" + key + "'  ";
         DataTable dt = new DataTable();
         dt = kn.GetTable(sql);
         return dt;
     }
     public DataTable getNganhByKhoa(string key)
     {
         DataTable dt = new DataTable();
         try
         {
             string sql = @"SELECT DISTINCT A.MaNghanh
                            FROM tbl_NGHANH A
                            INNER JOIN tbl_KHOA B
                            ON A.MaKhoa = B.MaKhoa
                            AND B.MaKhoa = '"+key+"' ";
             dt = kn.GetTable(sql);
         }
         catch (Exception)
         {
             
             throw;
         }
         return dt;
     }
     public DataTable getLopByNganh(string key)
     {
         DataTable dt = new DataTable();
         try
         {
             string sql = @"SELECT DISTINCT A.MaLop
                            FROM tbl_LOP A
                            INNER JOIN tbl_NGHANH B
                            ON A.MaNghanh = B.MaNghanh
                            AND B.MaNghanh = '"+key +"' ";
             dt = kn.GetTable(sql);
         }
         catch (Exception)
         {

             throw;
         }
         return dt;
     }
     public DataTable Search( string maK, string maN, string maL)
     {
         DataTable dt = new DataTable();
         try
         {
             string sql = string.Empty;
             if (maK =="" && maN==""&& maL=="")
             {
                 sql = @"SELECT A.MaSV, A.TenSV,A.GioiTinh,A.SDT,A.DiaChi,A.Email,A.NgaySinh
                            FROM tbl_SINHVIEN A
                            INNER JOIN tbl_LOP B
                            ON A.MaLop = B.MaLop
                            INNER JOIN tbl_NGHANH C
                            ON B.MaNghanh = C.MaNghanh
                            INNER JOIN tbl_KHOA D
                            ON C.MaKhoa = D.MaKhoa
                            Where B.MaLop = '' And C.MaNghanh='' AND D.MaKhoa=''
                            GROUP BY A.MaSV, A.TenSV,A.GioiTinh,A.SDT,A.DiaChi,A.Email,A.NgaySinh ";              
             }
             else
             {
                 sql = @"SELECT A.MaSV, A.TenSV,A.GioiTinh,A.SDT,A.DiaChi,A.Email,A.NgaySinh
                            FROM tbl_SINHVIEN A
                            INNER JOIN tbl_LOP B
                            ON A.MaLop = B.MaLop
                            INNER JOIN tbl_NGHANH C
                            ON B.MaNghanh = C.MaNghanh
                            INNER JOIN tbl_KHOA D
                            ON C.MaKhoa = D.MaKhoa
                            WHERE 1 = 1 ";
                 if (!string.IsNullOrEmpty(maL))
                 {
                     sql += " AND B.MaLop = '"+ maL+"' ";
                 }
                 if (!string.IsNullOrEmpty(maN))
                 {
                     sql += " AND C.MaNghanh = '"+maN+"' ";
                 }
                 if (!string.IsNullOrEmpty(maK))
                 {
                     sql += "  AND D.MaKhoa  = '"+maK+"' ";
                 }
                 sql += "GROUP BY A.MaSV, A.TenSV,A.GioiTinh,A.SDT,A.DiaChi,A.Email,A.NgaySinh";
             }
             
            dt = kn.GetTable(sql);             
         }
         catch (Exception )
         {
             
             throw;
         }
         return dt;
     }
    }
}
