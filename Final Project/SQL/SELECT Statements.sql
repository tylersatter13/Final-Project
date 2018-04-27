SELECT * FROM House INNER JOIN Street ON House.fk_Street = Street.StreetID;



SELECT CONCAT(Owner.OwnerFirst,' ', OwnerLast) as Owner, CONCAT(h.HouseNumber,' ',StreetName) as Address,SQPlanName as "Floor Plan",IC.InteriorColorName as 'Interior Color',IC.InteriorColorCode as "Color Code", Interior.HouseLastPaintDate as "Paint Date" ,CarpetName,Interior.HouseInteriorCarpetDate as "Carpet Install",VAFC.VAndFColor as "Viynal",C2.VAndFColor as "Fermica",Interior.HouseInteriorVFInstall as "V and F Install", S3.StainName as "Stain Color",Interior.HouseBlindReplacement as "Blind Replacement"
FROM House h
  INNER JOIN Street s  ON h.fk_Street = s.StreetID
  INNER JOIN Owner ON h.fk_Owner = Owner.OwnerID
  INNER JOIN SQPlan S2 on h.fk_SQPlan = S2.SQPlanID
  INNER JOIN HouseInterior Interior on h.fk_HouseInterriorID = Interior.HouseInteriorID
  INNER  JOIN InteriorColor IC on Interior.fk_PaintColorID = IC.InteriorColorID
  INNER JOIN Carpet C on Interior.fk_CarpetColorID = C.CarpetID
  INNER JOIN VAndFColor VAFC on Interior.fk_FermicaColorID = VAFC.VAndFID
  INNER JOIN VAndFColor C2 on Interior.fk_VynlColorID = C2.VAndFID
  INNER JOIN Stain S3 on Interior.fk_StainID = S3.StainID;

SELECT CONCAT(OwnerFirst,' ',OwnerLast) as Owner, CONCAT(h.HouseNumber,' ',StreetName) as Address, SQPlanName as 'Floor Plan',ExteriorColorName as "Paint Color", ExteriorColorCode as "Color Code",
HouseExteriorPaintDate as "Last painted", SidngType as "Siding Type", TrimColor as "Trim Color", RoofColorName as "Roof Color", RoofMaterialName as "Roof Material", HouseExteriorRoofInstall as "Roof Install" FROM House h
      INNER JOIN  Street S on h.fk_Street = S.StreetID
      INNER JOIN Owner ON h.fk_Owner = Owner.OwnerID
      INNER JOIN SQPlan S2 on h.fk_SQPlan = S2.SQPlanID
      INNER JOIN HouseExterior E on h.fk_HouseExteriorID = E.HouseExteriorID
      INNER JOIN Siding S3 on E.fk_SidingID = S3.SidingID
      INNER JOIN ExteriorColor Color on E.fk_ExteriorColorID = Color.ExteriorColorID
      INNER JOIN TrimColor TC on E.fk_TrimID = TC.TrimID
      INNER JOIN RoofColor R on E.fk_RoofColorID = R.RoofColorID
      INNER JOIN RoofMaterial Material on E.fk_RoofMaterialID = Material.RoofMaterialID;


UPDATE House SET fk_Owner =2 WHERE HouseID=1;