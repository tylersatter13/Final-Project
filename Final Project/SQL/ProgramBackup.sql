SELECT * FROM SQPlan

INSERT INTO dbo.SQPlan(SQPlanName)VALUES('3-1549');
INSERT INTO SQPlan(SQPlanName)VALUES('3-1569');
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

CREATE TABLE Siding(
  SidingID int primary key  identity(1,1),
  SidngType varchar(20)
);
INSERT Siding (SidngType)values ('Vertical');
INSERT Siding (SidngType) values ('Horizontal');

CREATE TABLE HouseInterior(
  HouseInteriorID int identity(1,1) primary key,
  fk_PaintColorID int,
  HouseLastPaintDate date,
  fk_CarpetColorID int,
  HouseInteriorCarpetDate DATE,
  fk_FermicaColorID int,
  fk_VynlColorID int,
  HouseInteriorVFInstall DATE,
  fk_StainID int,
  HouseBlindReplacement DATE,

  FOREIGN KEY (fk_PaintColorID) REFERENCES InteriorColor(InteriorColorID),
  FOREIGN KEY (fk_CarpetColorID) REFERENCES Carpet (CarpetID),
  FOREIGN KEY (fk_VynlColorID) REFERENCES VAndFColor(VAndFID),
  FOREIGN KEY (fk_FermicaColorID) REFERENCES VAndFColor(VAndFID),
  FOREIGN KEY (fk_StainID) REFERENCES  Stain(StainID)
);
INSERT HouseInterior (fk_PaintColorID, HouseLastPaintDate, fk_CarpetColorID, HouseInteriorCarpetDate, fk_FermicaColorID, fk_VynlColorID,
                      HouseInteriorVFInstall, fk_StainID, HouseBlindReplacement) VALUES (2,'2001-01-01',1,'2001-01-1',1,1,'2013-07-01',7,'2007-06-01');

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
  LeadTenantFirst varchar(30),
  LeadTenantLast varchar(30),
  LeadTenantPhone varchar(12),
  LeadPetFeePaid Bit,
  LeadTenantRentStart DATE,
  Children int
);
CREATE TABLE FamilyPet(
  fk_LeadTenantID int,
  fk_Pet int,

  PRIMARY KEY (fk_LeadTenantID,fk_Pet),
  FOREIGN KEY (fk_LeadTenantID) REFERENCES LeadTenant(LeadTenantID),
  FOREIGN KEY (fk_Pet) REFERENCES Pet(PetID)
);


CREATE TABLE Dishwasher(
  DishwasherID int PRIMARY KEY identity(1,1),
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
  HouseApplianceGutterDate DATE,
  HouseApplianceFurance Date,
  HouseApplianceHasRefer bit,

  FOREIGN KEY (fk_Dishwasher) REFERENCES Dishwasher(DishwasherID),
  FOREIGN KEY (fk_Ranger) REFERENCES CookingRange(RangeID)
);

INSERT HouseAppliances (fk_Ranger, fk_Dishwasher, HouseApplianceWHDate, HouseApplianceGDDate, HouseApplianceGutterDate,
                        HouseApplianceFurance, HouseApplianceHasRefer) VALUES (1,1,'2010-03-1',NULL,'1997-08-01',NULL,NULL);

CREATE TABLE House (
  HouseID int primary key identity(1,1),
  HouseNumber varchar(4),
  fk_Street int NOT NULL ,
  fk_Owner int NOT NULL ,
  fk_LeadTenant int,
  fk_SQPlan int,
  fk_HouseInterriorID int,
  fk_HouseExteriorID int,
  HouseHasGarageOpener bit,
  HouseHasFence bit,
  HouseHasOver bit,
  HouseDidDiscloseLea bit,
  HouseRent double precision,
  fk_HouseAppliancesID int,

  foreign key (fk_Street) REFERENCES  Street(StreetID),
  foreign key (fk_Owner) REFERENCES  Owner(OwnerID),
  foreign key (fk_LeadTenant) REFERENCES  LeadTenant(LeadTenantID),
  foreign key (fk_SQPlan) REFERENCES SQPlan(SQPlanID),
  foreign key (fk_HouseInterriorID) REFERENCES HouseInterior(HouseInteriorID),
  foreign key (fk_HouseExteriorID) REFERENCES  HouseExterior(HouseExteriorID),
  foreign key (fk_HouseAppliancesID) REFERENCES  HouseAppliances(HouseApplianceID)

);

INSERT House (HouseNumber, fk_Street, fk_Owner, fk_LeadTenant, fk_SQPlan, fk_HouseInterriorID, fk_HouseExteriorID, 
              HouseHasGarageOpener, HouseHasFence, HouseHasOver, HouseDidDiscloseLea, HouseRent, fk_HouseAppliancesID)
              VALUES('4611',1,1,NULL,1,1,1,0,0,1,1, 1099, 1);

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


