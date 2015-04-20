using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccessData;
using System.Data ;
namespace BusinessEntity
{
    public partial class DiemBE
    {
      DataConnect kn = new DataConnect();       
      public DataTable showDiem()
      {
         // string sql = "select distinct d.MaSV, d.MaLop, d.MaMH,d.DiemTP,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi  from tbl_DIEM d";
          string sql = @"SELECT DISTINCT d.MaSV, d.MaLop, d.MaMH, d.DiemQTHeS1,d.DiemQTHeS2,
		                                Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1) AS DiemTP 
			                            ,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi 
				                        ,Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) as DiemTBHP
                                        , CASE WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) >=9 THEN 'A+'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 8.5 AND 8.9 THEN 'A'
                                               WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 8.0  AND 8.4 THEN 'B+'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 7.0  AND 7.9 THEN 'B'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 6.5  AND 6.9 THEN 'C+'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 5.5  AND 6.4 THEN 'C'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 4.0 AND 5.4 THEN 'D'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) < 4.0 THEN 'F'
                                           END AS DiemChuTBHP
                          FROM  tbl_DIEM d					     
                          GROUP BY d.MaSV, d.MaLop, d.MaMH,d.DiemTP,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi,d.DiemTBHP ,d.DiemQTHeS1,d.DiemQTHeS2 ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }       
      public void insertDiem(string maSV, string maLop, string maMH,float dHS1, float dHS2 , float diemThi,float diemTP,float diemHP,string diemChu, int lanThi, int hocKi, int soTietN )
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
      public void deleteDiemByMaM(string maSV ,string maL, string maMH ,string lanthi)
      {
          string sql = "delete tbl_DIEM where  MaSV = '" + maSV + "' and MaLop ='" + maL  + "' and MaMH ='" + maMH + "'and LanThi='"+lanthi +"'  ";
          kn.ExcuteNonQuery1(sql);
      }
      public DataTable getDiemByIdSV(string key)
      {
        string sql =  @"SELECT DISTINCT d.MaSV, d.MaLop, d.MaMH, d.DiemQTHeS1,d.DiemQTHeS2,
		                                Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1) AS DiemTP 
			                            ,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi 
				                        ,Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) as DiemTBHP
                                        , CASE WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) >=9 THEN 'A+'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 8.5 AND 8.9 THEN 'A'
                                               WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 8.0  AND 8.4 THEN 'B+'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 7.0  AND 7.9 THEN 'B'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 6.5  AND 6.9 THEN 'C+'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 5.5  AND 6.4 THEN 'C'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 4.0 AND 5.4 THEN 'D'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) < 4.0 THEN 'F'
                                           END AS DiemChuTBHP
                          FROM  tbl_DIEM d					     
                          WHERE d.MaSV = '" + key + "' ";
          sql += "    GROUP BY d.MaSV, d.MaLop, d.MaMH,d.DiemTP,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi,d.DiemTBHP ,d.DiemQTHeS1,d.DiemQTHeS2 ";
          //string sql = "select distinct d.MaSV, d.MaLop, d.MaMH,d.DiemTP,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi  from tbl_DIEM d"
          //            + " where d.MaSV = '"+key +"' ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }
      public DataTable getDiemByIdLop(string key)
      {
          string sql = @"SELECT DISTINCT d.MaSV, d.MaLop, d.MaMH, d.DiemQTHeS1,d.DiemQTHeS2,
		                                Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1) AS DiemTP 
			                            ,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi 
				                        ,Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) as DiemTBHP
                                        , CASE WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) >=9 THEN 'A+'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 8.5 AND 8.9 THEN 'A'
                                               WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 8.0  AND 8.4 THEN 'B+'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 7.0  AND 7.9 THEN 'B'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 6.5  AND 6.9 THEN 'C+'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 5.5  AND 6.4 THEN 'C'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 4.0 AND 5.4 THEN 'D'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) < 4.0 THEN 'F'
                                           END AS DiemChuTBHP
                          FROM  tbl_DIEM d					     
                          WHERE d.MaLop = '" +key+"' ";
          sql += "    GROUP BY d.MaSV, d.MaLop, d.MaMH,d.DiemTP,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi,d.DiemTBHP ,d.DiemQTHeS1,d.DiemQTHeS2 ";
          //string sql = "select distinct d.MaSV, d.MaLop, d.MaMH,d.DiemTP,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi  from tbl_DIEM d"
          //            + " where d.MaLop = '" + key + "' ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }
      public DataTable getDiemByAll(string key)
      {
          string sql = @"SELECT DISTINCT d.MaSV, d.MaLop, d.MaMH, d.DiemQTHeS1,d.DiemQTHeS2,
		                                Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1) AS DiemTP 
			                            ,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi 
				                        ,Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) as DiemTBHP
                                        , CASE WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) >=9 THEN 'A+'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 8.5 AND 8.9 THEN 'A'
                                               WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 8.0  AND 8.4 THEN 'B+'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 7.0  AND 7.9 THEN 'B'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 6.5  AND 6.9 THEN 'C+'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 5.5  AND 6.4 THEN 'C'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) between 4.0 AND 5.4 THEN 'D'
	                                           WHEN Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) < 4.0 THEN 'F'
                                           END AS DiemChuTBHP
                          FROM  tbl_DIEM d	
                            INNER JOIN tbl_SINHVIEN sv
						    ON sv.MaSV = d.MaSV					     
                          WHERE d.MaLop like N'%" + key + "%'or d.MaSV like N'%" + key + "%' or d.MaMH like '%" + key + "%'  or sv.TenSV like N'%"+key+"%' ";
          sql += "    GROUP BY d.MaSV,sv.MaSV, d.MaLop, d.MaMH,d.DiemTP,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi,d.DiemTBHP ,d.DiemQTHeS1,d.DiemQTHeS2 ";        
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }
      public DataTable getDiemByMaSV(string key)
      {
          string sql = "select distinct d.MaSV, d.MaLop, d.MaMH,d.DiemTP,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi  from tbl_DIEM d"
                      + " where d.MaSV like '%" + key + "%' ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }
      public DataTable getDiemByMaLop(string key)
      {
          string sql = "select distinct d.MaSV, d.MaLop, d.MaMH,d.DiemTP,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi  from tbl_DIEM d"
                      + " where d.MaLop like '%" + key + "%' ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }
      public DataTable getDiemByTatCa(string key)
      {
          string sql = "select distinct d.MaSV, d.MaLop, d.MaMH,d.DiemTP,d.DiemThi,d.LanThi,d.HocKi,d.SoTietNghi  from tbl_DIEM d, tbl_MonHoc mh"
                      + " where d.MaLop like '%" + key + "%'or d.MaSV like '%" + key + "%' or d.MaMH like '%" + key + "%'or d.MaMH = mh.MaMH and mh.TenMH like '%"+key+"%' ";
          DataTable dt = new DataTable();
          dt = kn.GetTable(sql);
          return dt;
      }
      public DataTable getSVByMl(string key)
      {
          string sql = @"SELECT distinct ISNULL (A.MaSV,null) AS MaSV , isnull (B.MaLop,null) AS MaLop 
                        FROM tbl_SINHVIEN A 
                        INNER JOIN tbl_LOP B 
                        ON A.MaLop = B.MaLop
                        AND B.MaLop = '"+key+"' ";
          DataTable dt = new DataTable();
          return dt = kn.GetTable(sql);
      }

    }
}
