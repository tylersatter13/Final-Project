SELECT * FROM House WHERE fk_HouseInterriorID = (SELECT fk_HouseInterriorID from HouseInterior WHERE fk_PrimaryColorID = 1 OR fk_SecondaryColorID = 1)
SELECT * FROM dbo.HouseExterior
SELECT * FROM dbo.ExteriorColor
SELECT  * FROM  House WHERE fk_HouseExteriorID = (SELECT  fk_HouseExteriorID from HouseExterior WHERE  fk_ExteriorColorID = 4);