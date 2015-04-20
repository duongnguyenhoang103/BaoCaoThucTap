USE [DeMoQLSV]
GO
/****** Object:  StoredProcedure [dbo].[bcDiemMonHoc]    Script Date: 4/18/2015 1:05:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
-- exec bcDiemMonHoc N'KT','KTTC','KT1','','MNM','1'
CREATE PROCEDURE bcDiemCaNam 
	-- Add the parameters for the stored procedure here
	@maK nvarchar(50),
	@maN nvarchar (50),
	@maL nvarchar (50),
	@maSV nvarchar (50),
	@maMH nvarchar (50),
	@maHocKi nvarchar (50)
AS
DECLARE @SqlStr NVARCHAR(MAX),
        @ParamList NVARCHAR(2000)

	 SELECT @SqlStr =' SELECT distinct A.MaSV, A.TenSV,A.GioiTinh,A.NgaySinh,F.TenMH ,F.SoTinChi ,
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
                            WHERE 1 = 1 '
IF @maK  !=''
       SELECT @SqlStr = @SqlStr + '
              AND (D.MaKhoa = @maK)
              '
IF @maN !=''
       SELECT @SqlStr = @SqlStr + '
              AND (C.MaNghanh = @maN)
              '
IF @maL  !=''
       SELECT @SqlStr = @SqlStr + '
             AND (A.MaLop = @maL)
             '
IF @maSV  !=''
       SELECT @SqlStr = @SqlStr + '
              AND (A.MaSV = @maSV)
              '
IF @maMH  !=''
       SELECT @SqlStr = @SqlStr + '
              AND (F.MaMH = @maMH)
              '
IF @maHocKi !=''
       SELECT @SqlStr = @SqlStr + '
              AND (E.HocKi = @maHocKi)
              '
SELECT @Paramlist = '
      @maK nvarchar(50) ,
	@maN nvarchar (50),
	@maL nvarchar (50) ,
	@maSV nvarchar (50) ,
	@maMH nvarchar (50),
	@maHocKi nvarchar (50) 
       '
	   	   EXEC SP_EXECUTESQL	@SqlStr,
								@Paramlist,
								@maK ,
								@maN ,
								@maL ,
								@maSV,
								@maMH ,
								@maHocKi 