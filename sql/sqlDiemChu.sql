SELECT  sub1.MaLop, SUB1.MaSV, SUB1.MaMH 
	 , SUB1.DiemThi
	 , SUB1.DiemTP,  SUB1.DiemTBHP
	 ,CASE 
			WHEN SUB1.DiemTBHP >=9 THEN 'A+'
			WHEN SUB1.DiemTBHP between 8.5 AND 8.9 THEN 'A'
			WHEN SUB1.DiemTBHP between 8.0  AND 8.4 THEN 'B+'
			WHEN SUB1.DiemTBHP between 7.0  AND 7.9 THEN 'B'
			WHEN SUB1.DiemTBHP between 6.5  AND 6.9 THEN 'C+'
			WHEN SUB1.DiemTBHP between 5.5  AND 6.4 THEN 'C'
			WHEN SUB1.DiemTBHP  between 4.0 AND 5.4 THEN 'D'
			WHEN SUB1.DiemTBHP < 4.0 THEN 'F'
       END AS DiemChuTBHP
FROM
	(
		 SELECT  d.MaSV, d.MaLop, d.MaMH, 
				Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1) AS DiemTP 
				,Round(((Round(((d.DiemQTHeS1 + d.DiemQTHeS2*2)/3),1)*3+d.DiemThi*7)/10),1) as DiemTBHP
				, DiemThi
		FROM tbl_DIEM d		
	) SUB1