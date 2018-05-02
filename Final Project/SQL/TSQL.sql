CREATE TABLE SQPlan(
  SQPlanID int identity(1,1) primary key,
  SQPlanName varchar(30) not null
);
INSERT INTO SQPlan (SQPlanName)VALUES ('3-1549');
INSERT INTO SQPlan (SQPlanName)VALUES ('3-1569');
INSERT INTO SQPlan (SQPlanName)VALUES ('3-1311');
INSERT INTO SQPlan (SQPlanName)VALUES ('3-1280');
INSERT INTO SQPlan (SQPlanName)VALUES ('3-1512');
INSERT INTO SQPlan (SQPlanName)VALUES ('3-1438');
INSERT INTO SQPlan (SQPlanName)VALUES ('3-1683');
INSERT INTO SQPlan (SQPlanName)VALUES ('3-1802');
INSERT INTO SQPlan (SQPlanName)VALUES ('3-1426');
INSERT INTO SQPlan (SQPlanName)VALUES ('3-1776');
INSERT INTO SQPlan (SQPlanName)VALUES ('3-1658');


CREATE TABLE Owner( 
  OwnerID int identity(1,1) primary key,
  OwnerFirst varchar(30) Not Null,
  OwnerLast varchar(30)  NOT NULL,
  OwnerInitals varchar(30) NOT NULL
);

INSERT INTO Owner (OwnerFirst,OwnerLast,OwnerInitals)VALUES ('Tyler','Satter','TAS');
INSERT INTO Owner (OwnerFirst,OwnerLast,OwnerInitals)VALUES ('Richard','Satter','RMS');
INSERT INTO Owner (OwnerFirst,OwnerLast,OwnerInitals)VALUES ('Don','Satter','DNS');
INSERT INTO Owner (OwnerFirst,OwnerLast,OwnerInitals)VALUES ('Kimberly','Nasset','KFN');

CREATE TABLE Street(
  StreetID int identity(1,1) primary key,
  StreetName varchar(40) NOT NULL
);

INSERT INTO Street (StreetName)VALUES ('Princess CT');
INSERT INTO Street (StreetName)VALUES ('Reimann ST');
INSERT INTO Street (StreetName)VALUES ('Treeside CT');
INSERT INTO Street (StreetName)VALUES ('Treeside DR');
INSERT INTO Street (StreetName)VALUES ('Jaymar DR');
INSERT INTO Street (StreetName)VALUES ('Latona DR');
INSERT INTO Street (StreetName)VALUES ('Latona CT');
INSERT INTO Street (StreetName)VALUES ('Manzanita ST');
INSERT INTO Street (StreetName)VALUES ('Woodlawn DR');
INSERT INTO Street (StreetName)VALUES ('Woodlawn CT');
INSERT INTO Street (StreetName)VALUES ('Trent Ave N');

CREATE TABLE InteriorColor(
  InteriorColorID int identity (1,1) primary key,
  InteriorColorName varchar(30),
  InteriorColorCode varchar(30)
);

INSERT INTO InteriorColor (InteriorColorName,InteriorColorCode) VALUES ('Alabaster','NS3522');
INSERT INTO InteriorColor (InteriorColorName,InteriorColorCode) VALUES ('Divine White','SW6015');
INSERT INTO InteriorColor (InteriorColorName,InteriorColorCode) VALUES ('China Doll','S1101');
INSERT INTO InteriorColor (InteriorColorName,InteriorColorCode) VALUES ('Sugar Brush','SW1312');

CREATE TABLE Stain (
  StainID int identity(1,1) primary key ,
  StainName varchar(40)
);

INSERT INTO Stain (StainName)VALUES ('Chestnut');
INSERT INTO Stain (StainName)VALUES ('Fruitwood');
INSERT INTO Stain (StainName)VALUES ('Golden Oak');
INSERT INTO Stain (StainName)VALUES ('M. chest');
INSERT INTO Stain (StainName)VALUES ('English Oak');
INSERT INTO Stain (StainName)VALUES ('Dark Walnut');
INSERT INTO Stain (StainName)VALUES ('C. Chest');
INSERT INTO Stain (StainName)VALUES ('NS6965');
INSERT INTO Stain (StainName)VALUES ('NS14-1950');
INSERT INTO Stain (StainName)VALUES ('Tacoma Oak');

CREATE TABLE ExteriorColor (
  ExteriorColorID int identity(1,1) primary key,
  ExteriorColorName varchar(30),
  ExteriorColorCode varchar(30)
);

INSERT ExteriorColor (ExteriorColorName,ExteriorColorCode)VALUES ('Ceylon Cream','SW2354');
INSERT ExteriorColor (ExteriorColorName,ExteriorColorCode)VALUES ('Old-B149','NS14-608');
INSERT ExteriorColor (ExteriorColorName,ExteriorColorCode)VALUES ('Sandstone','SW2354 + NS13-1194');
INSERT ExteriorColor (ExteriorColorName,ExteriorColorCode)VALUES ('Sharkskin','NS4013+NS12-388');
INSERT ExteriorColor (ExteriorColorName,ExteriorColorCode)VALUES ('Argos','SW7065');
INSERT ExteriorColor (ExteriorColorName,ExteriorColorCode)VALUES ('Aqua-530 Lardon','NS20305');
INSERT ExteriorColor (ExteriorColorName,ExteriorColorCode)VALUES ('White','NS20274');
INSERT ExteriorColor (ExteriorColorName,ExteriorColorCode)VALUES ('Gray','KS8229-4152');
INSERT ExteriorColor (ExteriorColorName,ExteriorColorCode)VALUES ('Cream','KS15-1533');
INSERT ExteriorColor (ExteriorColorName,ExteriorColorCode)VALUES ('Brown','A89W153');

CREATE TABLE TrimColor (
   TrimID int identity(1,1)primary key,
   TrimColor varchar(30)
);

INSERT INTO TrimColor (TrimColor)VALUES ('White');
INSERT INTO TrimColor (TrimColor)VALUES ('H. Blue');
INSERT INTO TrimColor (TrimColor)VALUES ('Blue Ridge');
INSERT INTO TrimColor (TrimColor)VALUES ('Off White');
INSERT INTO TrimColor (TrimColor)VALUES ('Black');
INSERT INTO TrimColor (TrimColor)VALUES ('Pure White');

CREATE TABLE Carpet(
  CarpetID int PRIMARY KEY identity(1,1),
  CarpetName varchar(30)
);
INSERT Carpet(CarpetName)VALUES ('Thistle');
INSERT Carpet(CarpetName)VALUES ('T.Tan');
INSERT Carpet(CarpetName)VALUES ('Mink');
INSERT Carpet(CarpetName)VALUES ('Damask');
INSERT Carpet(CarpetName)VALUES ('Rivers Edge');
INSERT Carpet(CarpetName)VALUES ('Mushroom');
INSERT Carpet(CarpetName)VALUES ('Heal Touch');
INSERT Carpet(CarpetName)VALUES ('JK 700');

CREATE TABLE VAndFColor(
  VAndFID int primary key identity(1,1),
  VAndFColor varchar(30)
);
INSERT VAndFColor (VandFColor)VALUES ('Almond');
INSERT VAndFColor (VandFColor)VALUES ('Gold');
INSERT VAndFColor (VandFColor)VALUES ('Flax GA');
INSERT VAndFColor (VandFColor)VALUES ('Tile');
INSERT VAndFColor (VandFColor)VALUES ('#99057');
INSERT VAndFColor (VandFColor)VALUES ('Beige');
INSERT VAndFColor (VandFColor)VALUES ('81041k');

CREATE TABLE RoofMaterial(
  RoofMaterialID int primary key identity(1,1),
  RoofMaterialName varchar(30)
);
INSERT RoofMaterial (RoofMaterialName)VALUES ('Prestique I-30 yr');
INSERT RoofMaterial (RoofMaterialName)VALUES ('Prestique II-25 yr');
INSERT RoofMaterial (RoofMaterialName)VALUES ('Owner Corning');

CREATE TABLE RoofColor (
  RoofColorID int primary key identity(1,1),
  RoofColorName varchar(30)
);
INSERT RoofColor (RoofColorName)values ('Sablewood');
INSERT RoofColor (RoofColorName) values ('Gray');
INSERT RoofColor (RoofColorName)values ('Onyx Black');
SELECT * FROM  RoofColor;
CREATE TABLE KeyNumber(
   KeyNumberID int identity(1,1),
   KeyNumberCurrent varchar(6),
   KeyNumberCurrentDate DATE,
   KeyNumberPrevious varchar(6),
   KeyNumberPrevDate varchar(6)
);

CREATE TABLE Siding(
  SidingID int primary key  identity(1,1),
  SidngType varchar(20)
);
INSERT Siding (SidngType)values ('Vertical');
INSERT Siding (SidngType) values ('Horizontal');

CREATE TABLE HouseInteriorColors(
   fk_HouseInteriorID int ,
   fk_InteriorColorID  INT,
   CONSTRAINT pk_HouseInteriorColors PRIMARY KEY (fk_HouseInteriorID,fk_InteriorColorID),
   FOREIGN  KEY  (fk_HouseInteriorID) REFERENCES HouseInterior(HouseInteriorID),
   FOREIGN  KEY  (fk_InteriorColorID) REFERENCES InteriorColor(InteriorColorID)
);

CREATE TABLE HouseInterior(
  HouseInteriorID int identity(1,1) primary key,
  fk_PrimaryColorID int,
  fk_SecondaryColorID int,
  HouseLastPaintDate date,
  fk_CarpetColorID int,
  HouseInteriorCarpetDate DATE,
  fk_FermicaColorID int,
  fk_VynlColorID int,
  HouseInteriorVFInstall DATE,
  fk_StainID int,
  HouseBlindReplacement DATE,

  FOREIGN KEY (fk_PrimaryColorID) REFERENCES  InteriorColor(InteriorColorID),
  FOREIGN KEY (fk_SecondaryColorID) REFERENCES InteriorColor(InteriorColorID),
  FOREIGN KEY (fk_CarpetColorID) REFERENCES Carpet (CarpetID),
  FOREIGN KEY (fk_VynlColorID) REFERENCES VAndFColor(VAndFID),
  FOREIGN KEY (fk_FermicaColorID) REFERENCES VAndFColor(VAndFID),
  FOREIGN KEY (fk_StainID) REFERENCES  Stain(StainID)
);


INSERT HouseInterior (HouseLastPaintDate, fk_CarpetColorID, HouseInteriorCarpetDate, fk_FermicaColorID, fk_VynlColorID,
                      HouseInteriorVFInstall, fk_StainID, HouseBlindReplacement) VALUES ('2001-01-01',1,'2001-01-1',1,1,'2013-07-01',7,'2007-06-01');

CREATE TABLE HouseExterior(
  HouseExteriorID INT primary key identity(1,1),
  fk_SidingID INT,
  fk_ExteriorColorID Int,
  HouseExteriorPaintDate DATE,
  fk_TrimID INT,
  fk_RoofMaterialID INT,
  fk_RoofColorID INT,
  HouseExteriorRoofInstall Date,

  FOREIGN KEY (fk_SidingID) REFERENCES Siding(SidingID),
  FOREIGN KEY (fk_ExteriorColorID) REFERENCES ExteriorColor(ExteriorColorID),
  FOREIGN KEY (fk_TrimID) REFERENCES TrimColor(TrimID),
  FOREIGN KEY (fk_RoofMaterialID) REFERENCES  RoofMaterial(RoofMaterialID),
  FOREIGN KEY (fk_RoofColorID) REFERENCES  RoofColor(RoofColorID)

);
INSERT HouseExterior (fk_SidingID, fk_ExteriorColorID, HouseExteriorPaintDate, fk_TrimID, fk_RoofMaterialID, fk_RoofColorID, HouseExteriorRoofInstall)
VALUES (2,4,'2008-08-01',1,1,1,'1996-01-01');

CREATE TABLE Tenant(
  TenantID int primary key identity(1,1),
  TenantFirst varchar(30),
  TenantLast varchar(30),
  TenantPhone varchar(12)
);


CREATE TABLE Pet(
  PetID int primary key identity(1,1),
  PetType varchar(30),
  PetBreed varchar(30)
);
CREATE TABLE LeadTenant(
  LeadTenantID int PRIMARY KEY identity(1,1),
  fk_TenantID int,
  LeadPetFeePaid Bit,
  LeadTenantRentStart DATE,
  Children int

  FOREIGN KEY (fk_TenantID) REFERENCES Tenant(TenantID)
);
INSERT LeadTenant( LeadTenantFirst,LeadTenantLast, LeadTenantPhone, LeadPetFeePaid,LeadTenantRentStart,Children) VALUES( 'Steve','Arnold', '805-404-1146',
    NULL,'2017-07-17', 0 );

CREATE TABLE HouseTenant (
  fk_HouseID int,
  fk_TenantID int,

  PRIMARY KEY (fk_HouseID,fk_TenantID),
  FOREIGN KEY (fk_HouseID) REFERENCES  House(HouseID),
  FOREIGN KEY (fk_TenantID)REFERENCES  Tenant(TenantID)

)
CREATE TABLE FamilyPet(
  fk_LeadTenantID int,
  fk_Pet int,

  PRIMARY KEY (fk_LeadTenantID,fk_Pet),
  FOREIGN KEY (fk_LeadTenantID) REFERENCES LeadTenant(LeadTenantID),
  FOREIGN KEY (fk_Pet) REFERENCES Pet(PetID)
);

CREATE TABLE Dishwasher(
  DishwasherID int PRIMARY KEY identity(1,1),
  DishwasherBrand varchar(30),
  DishwasherColor varchar(30),
  DishwasherModel varchar(30),
  DishwasherSerial varchar(30),
  DishwasherPurchaseDate date
);
INSERT Dishwasher (DishwasherColor, DishwasherModel, DishwasherSerial, DishwasherPurchaseDate)VALUES  ( NULL, NULL ,NULL ,'2008-04-01');

CREATE TABLE CookingRange(
  RangeID int primary key  identity(1,1),
  RangeBrand varchar(30),
  RangeColor varchar(30),
  RangeModel varchar(30),
  RangeSerial varchar(30),
  RangeReplaceDate date
);
INSERT CookingRange (RangeBrand, RangeColor, RangeModel, RangeSerial, RangeReplaceDate) values('GE','Harvest Gold','JMP22002HA',NULL,NULL );

CREATE TABLE HouseAppliances(
  HouseApplianceID int primary key identity(1,1),
  fk_Ranger int,
  fk_Dishwasher int,
  HouseApplianceWHDate DATE,
  HouseApplianceGDDate DATE,
  HouseApplianceHasRefer bit,

  FOREIGN KEY (fk_Dishwasher) REFERENCES Dishwasher(DishwasherID),
  FOREIGN KEY (fk_Ranger) REFERENCES CookingRange(RangeID)
);
INSERT HouseAppliances (fk_Ranger, fk_Dishwasher, HouseApplianceWHDate, HouseApplianceGDDate,
                         HouseApplianceHasRefer) VALUES (1,1,'2010-03-1',NULL,0);
CREATE TABLE InteriorFeatures (
  InteriorFeaturesID int identity(1,1) primary key ,
  InterriorFeaturesHallShowerDate Date,
  InterriorFeaturesWaterHeaterDate Date,
  InterriorFeaturesCelingFanDate DATE,
  InterriorFeaturesFurnanceReplacement Date
);
INSERT InteriorFeatures(InterriorFeaturesHallShowerDate, InterriorFeaturesWaterHeaterDate, InterriorFeaturesCelingFanDate, InterriorFeaturesFurnanceReplacement) VALUES (NULL,'2010-3-1',NULL,NULL) ;
SELECT  InteriorFeaturesID as houseInterriorFeaturesID, InterriorFeaturesHallShowerDate as  hallShowerReplacementDate ,InterriorFeaturesWaterHeaterDate as waterHeaterReplacementDate,
  InterriorFeaturesCelingFanDate as cielingFanReplacementDate,InterriorFeaturesFurnanceReplacement as furnanceReplacementDate FROM InteriorFeatures
WHERE InteriorFeaturesID = (SELECT fk_InterriorFeaturesID FROM House WHERE HouseID = 4);

CREATE TABLE ExteriorFeatures(
  ExteriorFeaturesID Int primary key  identity(1,1),
  ExteriorFenece Date,
  ExteriorGutterReplacement Date,
  ExteriorGarageDoor Date,
  ExteriorDriveWay Date,
  ExteriorChimney Date
);
INSERT ExteriorFeatures(ExteriorFenece, ExteriorGutterReplacement, ExteriorGarageDoor, ExteriorDriveWay, ExteriorChimney) VALUES (NULL,'1997-8-1','2003-10-1',NULL,NULL);
SELECT ExteriorFeaturesID as exteriorFeaturesID,ExteriorFenece as fenceReplacement,ExteriorGutterReplacement  as gutterReplacemengt ,
  ExteriorGarageDoor  as grageDoorReplacement,ExteriorDriveWay as drivewayReplacemnt, ExteriorChimney as chimneyReplacement FROM ExteriorFeatures
CREATE TABLE House (
  HouseID int primary key identity(1,1),
  HouseNumber varchar(4),
  fk_Street int NOT NULL ,
  fk_Owner int NOT NULL ,
  fk_LeadTenant int,
  fk_SQPlan int,
  fk_HouseInterriorID int,
  fk_HouseExteriorID int,
  fk_KeyNunberID int,
  fk_InterriorFeaturesID int,
  fk_ExterriorFeaturesID int,
  HouseDidDiscloseLea bit,
  HouseRentStartDate date,
  HouseRent double precision,
  fk_HouseAppliancesID int,
  HouseMiscellaneous varchar(255)

  foreign key (fk_Street) REFERENCES  Street(StreetID),
  foreign key (fk_Owner) REFERENCES  Owner(OwnerID),
  foreign key (fk_LeadTenant) REFERENCES  LeadTenant(LeadTenantID),
  foreign key (fk_SQPlan) REFERENCES SQPlan(SQPlanID),
  foreign key (fk_HouseInterriorID) REFERENCES HouseInterior(HouseInteriorID),
  foreign key (fk_HouseExteriorID) REFERENCES  HouseExterior(HouseExteriorID),
  foreign key (fk_KeyNunberID) REFERENCES  KeyNumber(KeyNumberID),
  foreign key (fk_ExterriorFeaturesID) REFERENCES  ExteriorFeatures(ExteriorFeaturesID),
  foreign key (fk_InterriorFeaturesID) REFERENCES InteriorFeatures(InteriorFeaturesID),
  foreign key (fk_HouseAppliancesID) REFERENCES  HouseAppliances(HouseApplianceID)

);

INSERT House (HouseNumber, fk_Street, fk_Owner, fk_LeadTenant, fk_SQPlan, fk_HouseInterriorID, fk_HouseExteriorID,fk_KeyNunberID,
              fk_InterriorFeaturesID,fk_ExterriorFeaturesID, HouseDidDiscloseLea, HouseRentStartDate, HouseRent, fk_HouseAppliancesID,HouseMiscellaneous)
              VALUES('4611',1,2,NULL,1,1,1,NULL,1,1,0,'2017-07-07',919,  1,NULL);


CREATE TABLE MaintenanceTechnician (
  MaintenanceTechniciansID int primary key,
  MaintenanceTechnicianFirst varchar(20) NOT NULL,
  MaintenanceTechnicianLast varchar(30) NOT NULL
);
CREATE TABLE MaintenanceRequestType(
  MaintenanceRequestTypeID int primary key identity(1,1),
  MaintenanceRequestTypeName varchar(30)
);
CREATE TABLE MaintenanceRequest (
  MaintenenceRequestID int primary key identity(1,1),
  fk_LeadTenantID int NOT NULL,
  fk_MaintenanceTechnician Int,
  MaintenenceRequestDate INT,
  MaintenenceIsAppliance Bit,
  MaintenenceRequestDescription varchar(255),
  MaintenenceeRequestDateStarted date,
  MaintenenceRequestDateCompleted date,
  MaintenenceRequestCompletionHousrs int,
  fk_MaintenanceRequestTypeID int,
  MaintenanceRequestCanEnter bit,

  FOREIGN KEY (fk_LeadTenantID) REFERENCES LeadTenant(LeadTenantID),
  FOREIGN KEY (fk_MaintenanceTechnician) REFERENCES  MaintenanceTechnician(MaintenanceTechniciansID),
  FOREIGN KEY (fk_MaintenanceRequestTypeID) REFERENCES MaintenanceRequestType(MaintenanceRequestTypeID)
);
CREATE TABLE PartBrand(
  PartBrandID int identity(1,1) primary key,
  PartBrandName varchar(20) NOT NULL
);
CREATE TABLE Part(
  PartID int primary key identity(1,1),
  PartName varchar(20),
  fk_PartBrand int,
  PartCost double precision,
  PartPurchaseLocation varchar(20),
  PartStockorCharge bit,

  FOREIGN KEY  (fk_PartBrand) REFERENCES PartBrand(PartBrandID)

);
CREATE TABLE Material (
  fk_MaintenanceRequest int NOT NULL,
  fk_PartID             int NOT NULL,
  PRIMARY KEY (fk_MaintenanceRequest, fk_PartID),
  foreign key (fk_MaintenanceRequest) REFERENCES  MaintenanceRequest(MaintenenceRequestID),
  foreign key (fk_PartID) REFERENCES  Part(PartID)
);
CREATE TABLE  TransactionTypes(
  TransactionTypeID int identity(1,1) primary key,
  TransactionType varchar(20) NOT NULL
);
CREATE TABLE  TransactionFlags(
  TransactionFlagID int identity(1,1) primary key,
  TransactionFlagName varchar(30)
);
  CREATE TABLE TenantTransaction(
    TransactionID int primary key identity(1,1),
    fk_TennantID int,
    TransactionDate date,
    fk_TransactonTypeID int,
    TransactionAmount double precision,
    TransactionNotes varchar(255),
    fk_TransactionFlags int,

    FOREIGN KEY (fk_TennantID) REFERENCES Tenant(TenantID),
    FOREIGN KEY (fk_TransactonTypeID) REFERENCES  TransactionTypes(TransactionTypeID) ,
    FOREIGN KEY (fk_TransactionFlags) REFERENCES  TransactionFlags(TransactionFlagID)

);
SELECT HouseID,fk_Owner, HouseNumber,fk_Street,fk_SQPlan,fk_LeadTenant,fk_LeadTenant,fk_HouseInterriorID,fk_HouseExteriorID,fk_HouseAppliancesID,
  fk_InterriorFeaturesID,fk_ExterriorFeaturesID FROM House
  INNER JOIN Street S2 on House.fk_Street = S2.StreetID
  INNER JOIN SQPlan S3 on House.fk_SQPlan = S3.SQPlanID
  INNER JOIN  Owner O on House.fk_Owner = O.OwnerID
UPDATE HouseInterior SET fk_PrimaryColorID = 1 WHERE HouseInteriorID=1;

SELECT HouseInteriorID,fk_PrimaryColorID,IC.InteriorColorName,fk_SecondaryColorID,IC2.InteriorColorName,HouseLastPaintDate,CarpetID,CarpetName,
  HouseInteriorCarpetDate,fk_FermicaColorID,VAFC.VAndFColor,VAndFColor,Interior.HouseInteriorVFInstall,Interior.fk_StainID,StainName,Interior.HouseBlindReplacement FROM HouseInterior
  INNER JOIN InteriorColor IC on HouseInterior.fk_PrimaryColorID = IC.InteriorColorID
  INNER JOIN InteriorColor IC2 on HouseInterior.fk_SecondaryColorID = IC2.InteriorColorID
  INNER JOIN Carpet C on HouseInterior.fk_CarpetColorID = C.CarpetID
  INNER JOIN VAndFColor VAFC on HouseInterior.fk_FermicaColorID = VAFC.VAndFID
  INNER JOIN HouseInterior Interior on VAFC.VAndFID = Interior.fk_VynlColorID
  inner JOIN Stain S2 on HouseInterior.fk_StainID = S2.StainID

SELECT  HouseInteriorID,fk_PrimaryColorID,IC.InteriorColorName,IC.InteriorColorCode,fk_SecondaryColorID,IC2.InteriorColorName,IC2.InteriorColorCode,C.CarpetID,C.CarpetName,HouseInteriorCarpetDate,
  VAFC.VAndFID,VAFC.VAndFColor,C2.VAndFID,C2.VAndFColor,HouseInteriorVFInstall, S2.StainID,S2.StainName, HouseBlindReplacement FROM HouseInterior
  INNER JOIN InteriorColor IC on HouseInterior.fk_PrimaryColorID = IC.InteriorColorID
  INNER JOIN InteriorColor IC2 on HouseInterior.fk_SecondaryColorID = IC2.InteriorColorID
  INNER JOIN Carpet C on HouseInterior.fk_CarpetColorID = C.CarpetID
  INNER JOIN VAndFColor VAFC on HouseInterior.fk_FermicaColorID = VAFC.VAndFID
  INNER JOIN VAndFColor C2 on HouseInterior.fk_VynlColorID = C2.VAndFID
  INNER JOIN Stain S2 on HouseInterior.fk_StainID = S2.StainID

SELECT HouseExteriorID,fk_SidingID,SidngType,ExteriorColorID,E.ExteriorColorName,E.ExteriorColorCode,HouseExteriorPaintDate,fk_TrimID, Color.TrimColor, fk_RoofMaterialID, RoofMaterial.RoofMaterialName,RoofColorID,RoofColorName FROM HouseExterior
  LEFT JOIN Siding S2 on HouseExterior.fk_SidingID = S2.SidingID
  LEFT JOIN ExteriorColor E on HouseExterior.fk_ExteriorColorID = E.ExteriorColorID
  LEFT JOIN TrimColor Color on HouseExterior.fk_TrimID = Color.TrimID
  LEFT JOIN RoofMaterial on HouseExterior.fk_RoofMaterialID = RoofMaterial.RoofMaterialID
  LEFT JOIN RoofColor R on HouseExterior.fk_RoofColorID = R.RoofColorID

SELECT HouseApplianceID as houseApplianceID,HouseApplianceWHDate as lastWaterHeaterReplacement, HouseApplianceGDDate as lastGarbageDisposalReplacement,
  HouseApplianceHasRefer as hasRef FROM HouseAppliances;

  SELECT * FROM CookingRange WHERE RangeID = (SELECT RangeID FROM HouseAppliances WHERE HouseApplianceID = 1);


SELECT HouseExteriorID as houseExteriorID , fk_SidingID as sidingID , SidngType as sidingName , ExteriorColorID as exteriorColorID , E.ExteriorColorName as exteriorColor , E.ExteriorColorCode as exteriorColorCode ,HouseExteriorPaintDate as exteriorPaintDate , fk_TrimID as trimID , Color.TrimColor as trim , fk_RoofMaterialID as roofMaterialID , RoofMaterial.RoofMaterialName as roofMaterial , RoofColorID as roofColorID , RoofColorName as roofColorName , HouseExteriorRoofInstall as roofInstall FROM HouseExterior LEFT JOIN Siding S2 on HouseExterior.fk_SidingID = S2.SidingID LEFT JOIN ExteriorColor E on HouseExterior.fk_ExteriorColorID = E.ExteriorColorID LEFT JOIN TrimColor Color on HouseExterior.fk_TrimID = Color.TrimID LEFT JOIN RoofMaterial on HouseExterior.fk_RoofMaterialID = RoofMaterial.RoofMaterialID LEFT JOIN RoofColor R on HouseExterior.fk_RoofColorID = R.RoofColorID WHERE SELECT * FROM HouseExterior WHERE HouseExteriorID = (SELECT fk_HouseExteriorID FROM House WHERE HouseID = 4);

SELECT LeadTenantID, L FROM LeadTenant