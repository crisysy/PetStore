SELECT p.Nume
FROM Producator p
WHERE p.ID IN (	SELECT tabel1.Producator
				FROM ( SELECT TOP 1 m.Producator, SUM(m.Stoc) AS TotalStoc
					FROM Mancare m
					GROUP BY m.Producator
					ORDER BY TotalStoc DESC) AS tabel1 )
