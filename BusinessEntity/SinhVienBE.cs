using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using AccessData;

namespace BusinessEntity
{
   public class SinhVienBE
    {
       DataConnect da = new DataConnect();

       //public string MaSV { get;set;}
       //public string TenSV { get; set; }
       //public string GioiTinh { get; set; }
       //public int SDT { get; set; }
       //public DateTime NgaySinh  { get; set; }

       //public string MaLop { get; set; }
       public DataTable GetAllSV()
       {
           string sql = " select * from tbl_SINHVIEN";
           DataTable dt = new DataTable();
           dt = da.GetTable(sql);
           return dt;
       }
       public void DeleteSV(string maSV)
       {
          string sql = "delete tbl_DIEM where MaSV = '" + maSV + "' ";
            sql += "delete tbl_SINHVIEN where MaSV = '" + maSV + "' ";
          
           da.ExcuteNonQuery1(sql);
       }
       public void InsertSV(string masv, string tensv, string gioitinh, int sdt, string diaChi, string email, DateTime ngaysinh, string malop)
       {
           string sql = " INSERT INTO tbl_SINHVIEN VALUES ('" + masv + "', N'" + tensv + "',N'" + gioitinh + "','" + sdt + "', N'"+diaChi +"', '"+email+"' ,'" + ngaysinh + "','" + malop + "') ";           
           da.ExcuteNonQuery1(sql);
       }
       public void UpdateSV(string madk , string masv, string tensv, string gioitinh, int sdt, string diaChi, string email, DateTime ngaysinh, string malop)
       {
           string sql = " Update tbl_SINHVIEN SET MaSV ='"+masv+"', TenSV =N'"+tensv+"', GioiTinh= N'"+gioitinh+"', SDT='"+sdt +"', DiaChi= N'"+diaChi+"', Email='"+email +"', NgaySinh='"+ngaysinh +"', MaLop ='"+malop+"' WHERE MaSV ='"+madk+"' ";
           da.ExcuteNonQuery1(sql);
       }
       public DataTable GetSVByIdMaLop (string key)
       {

           string sql = " select Distinct sv.MaSV,sv.TenSV,sv.GioiTinh,sv.SDT, sv.DiaChi, sv.Email ,sv.NgaySinh,sv.MaLop from tbl_SINHVIEN  sv ,tbl_LOP lp "
                           + " Where sv.MaLop = lp.MaLop and sv.MaLop like N'%" + key + "%'  ";
           DataTable dt = new DataTable();
           dt = da.GetTable(sql);
           return dt;
       }
       public DataTable GetSVByIdTenLop(string key)
       {
          string sql = " select Distinct sv.MaSV,sv.TenSV,sv.GioiTinh,sv.SDT,sv.DiaChi, sv.Email ,sv.NgaySinh,sv.MaLop from tbl_SINHVIEN  sv ,tbl_LOP lp "
                           + " Where sv.MaLop = lp.MaLop and lp.TenLop like N'%"+key+"%' ";
           DataTable dt = new DataTable();
           dt = da.GetTable(sql);
           return dt;
       }
       public DataTable GetSVByIdMaSv(string key)
       {

           string sql = " select Distinct sv.MaSV,sv.TenSV,sv.GioiTinh,sv.SDT, sv.DiaChi, sv.Email ,sv.NgaySinh,sv.MaLop from tbl_SINHVIEN  sv ,tbl_LOP lp "
                           + " Where sv.MaLop = lp.MaLop and sv.MaSV like N'%" + key + "%'  ";
           DataTable dt = new DataTable();
           dt = da.GetTable(sql);
           return dt;
       }
       public DataTable GetSVByName(string key)
       {

           string sql = " select Distinct sv.MaSV,sv.TenSV,sv.GioiTinh,sv.SDT, sv.DiaChi, sv.Email ,sv.NgaySinh,sv.MaLop from tbl_SINHVIEN  sv ,tbl_LOP lp "
                           + " Where sv.MaLop = lp.MaLop and sv.TenSV like N'%" + key + "%'  ";
           DataTable dt = new DataTable();
           dt = da.GetTable(sql);
           return dt;
       }
       public DataTable GetSVByMaLopId(string key)
       {

           string sql = " select Distinct sv.MaSV,sv.TenSV,sv.GioiTinh,sv.SDT, sv.DiaChi, sv.Email ,sv.NgaySinh,sv.MaLop from tbl_SINHVIEN  sv ,tbl_LOP lp "
                           + " Where sv.MaLop = lp.MaLop and sv.MaLop = N'" + key + "'  ";
           DataTable dt = new DataTable();
           dt = da.GetTable(sql);
           return dt;
       }

    }
}
