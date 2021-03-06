select A.MaSV,A.MaLop,A.MaMH,C.TenMH, A.DiemChuTBHP
,CASE WHEN A.DiemChuTBHP = 'A+' THEN 4.0  
		WHEN A.DiemChuTBHP = 'A' THEN 3.7 
		WHEN A.DiemChuTBHP = 'B+' THEN 3.5 
		WHEN A.DiemChuTBHP = 'B' THEN 3.0
		WHEN A.DiemChuTBHP = 'C+' THEN 2.5
		WHEN A.DiemChuTBHP = 'C' THEN 2.0
		WHEN A.DiemChuTBHP = 'D' THEN 1.0
		WHEN A.DiemChuTBHP = 'F' THEN 0.0
  END AS DiemMonHocPhan,
  A.SoTinChi,
  CASE WHEN A.DiemChuTBHP = 'A+' THEN 4.0  * a.SoTinChi 
		WHEN A.DiemChuTBHP = 'A' THEN 3.7  * a.SoTinChi 
		WHEN A.DiemChuTBHP = 'B+' THEN 3.5  * a.SoTinChi 
		WHEN A.DiemChuTBHP = 'B' THEN 3.0 * a.SoTinChi 
		WHEN A.DiemChuTBHP = 'C+' THEN 2.5 * a.SoTinChi 
		WHEN A.DiemChuTBHP = 'C' THEN 2.0 * a.SoTinChi 
		WHEN A.DiemChuTBHP = 'D' THEN 1.0 * a.SoTinChi 
		WHEN A.DiemChuTBHP = 'F' THEN 0.0 * a.SoTinChi 
  END AS DiemTBMon,
A.HocKi,A.GhiChu
from tbl_KETQUA A
LEFT JOIN tbl_SINHVIEN B
ON A.MaSV = B.MaSV
LEFT JOIN tbl_MONHOC C
ON A.MaMH = C.MaMH
LEFT JOIN tbl_DIEM D
ON A.DiemChuTBHP = D.DiemChuTBHP
WHERE 1=1
AND  A.MaSV= 'KT1_01'
AND  A.HocKi = 1
 -- select * from tbl_KETQUA
  