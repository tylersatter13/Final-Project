CREATE TABLE SQPlan(
  SQPlanID int auto_increment primary key,
  SQPlanName varchar(30) not null
);

INSERT SQPlan values (2,"3-1549");
INSERT SQPlan values (3,"3-1569");
INSERT SQPlan values (4,"3-1311");
INSERT SQPlan values (5,"3-1280");
INSERT SQPlan values (6,"3-1512");
INSERT SQPlan values (7,"3-1438");
INSERT SQPlan values (8,"3-1683");
INSERT SQPlan values (9,"3-1802");
INSERT SQPlan values (10,"3-1426");
INSERT SQPlan values (11,"3-1776");
INSERT SQPlan values (12,"3-1658");

CREATE TABLE Owner(
  OwnerID int auto_increment primary key,
  OwnerFirst varchar(30) Not Null,
  OwnerLast varchar(30)  NOT NULL,
  OwnerInitals varchar(30) NOT NULL
);

INSERT Owner values (1,"Tyler","Satter","TAS");
INSERT Owner values (2,"Richard","Satter","RMS");
INSERT Owner values (3,"Don","Satter","DNS");
INSERT Owner values (4,"Kimberly","Nasset","KFN");

CREATE TABLE Street(
  StreetID int auto_increment primary key,
  StreetName varchar(40) NOT NULL
);

INSERT Street values (1,"Princess CT");
INSERT Street values (2,"Reimann ST");
INSERT Street values (3,"Treeside CT");
INSERT Street values (4,"Treeside DR");
INSERT Street values (5,"Jaymar DR");
INSERT Street values (6,"Latona DR");
INSERT Street values (7,"Latona CT");
INSERT Street values (8,"Manzanita ST");
INSERT Street values (9,"Woodlawn DR");
INSERT Street values (10,"Woodlawn CT");
INSERT Street values (11,"Trent Ave N");

CREATE TABLE InteriorColor(
  InteriorColorID int auto_increment primary key,
  InteriorColorName varchar(30),
  InteriorColorCode varchar(30)
);

INSERT InteriorColor VALUES (1,"Alabaster","NS3522");
INSERT InteriorColor VALUES (2,"Divine White","SW6015");
INSERT InteriorColor VALUES (3,"China Doll","S1101");
INSERT InteriorColor VALUES (4,"Sugar Brush","SW1312");

CREATE TABLE Stain (
  StainID int auto_increment primary key ,
  StainName varchar(40)
);

INSERT Stain values (1,"Chestnut");
INSERT Stain values (2,"Fruitwood");
INSERT Stain values (3,"Golden Oak");
INSERT Stain values (4,"M. chest");
INSERT Stain values (5,"English Oak");
INSERT Stain values (6,"Dark Walnut");
INSERT Stain values (7,"C. Chest");
INSERT Stain values (8,"NS6965");
INSERT Stain values (9,"NS14-1950");
INSERT Stain values (10,"Tacoma Oak");
CREATE TABLE ExteriorColor (
  ExteriorColorID int auto_increment primary key,
  ExteriorColorName varchar(30),
  ExteriorColorCode varchar(30)
);

INSERT ExteriorColor values (1, "Ceylon Cream","SW2354");
INSERT ExteriorColor values (2, "Old-B149","NS14-608");
INSERT ExteriorColor values (3, "Sandstone","SW2354 + NS13-1194");
INSERT ExteriorColor values (4, "Sharkskin","NS4013+NS12-388");
INSERT ExteriorColor values (5, "Argos","SW7065");
INSERT ExteriorColor values (6, "Aqua-530 Lardon","NS20305");
INSERT ExteriorColor values (7, "White","NS20274");
INSERT ExteriorColor values (8, "Gray","KS8229-4152");
INSERT ExteriorColor values (9, "Cream","KS15-1533");
INSERT ExteriorColor values (10, "Brown","A89W153");


CREATE TABLE TrimColor (
   TrimID int auto_increment primary key,
   TrimColor varchar(30)
);

INSERT TrimColor values (1,"White");
INSERT TrimColor values (2,"H. Blue");
INSERT TrimColor values (3,"Blue Ridge");
INSERT TrimColor values (4,"Off White");
INSERT TrimColor values (5,"Black");
INSERT TrimColor values (6,"Pure White");

CREATE TABLE Carpet(
  CarpetID int PRIMARY KEY AUTO_INCREMENT,
  CarpetName varchar(30)
);
INSERT Carpet VALUES (1,"Thistle");
INSERT Carpet VALUES (2,"T.Tan");
INSERT Carpet VALUES (3,"Mink");
INSERT Carpet VALUES (4,"Damask");
INSERT Carpet VALUES (5,"River's Edge");
INSERT Carpet VALUES (6,"Mushroom");
INSERT Carpet VALUES (7,"Heal Touch");
INSERT Carpet VALUES (8,"JK 700");

CREATE TABLE VAndFColor(
  VAndFID int primary key auto_increment,
  VAndFColor varchar(30)
);
INSERT VAndFColor VALUES (1, "Almond");
INSERT VAndFColor VALUES (2, "Gold");
INSERT VAndFColor VALUES (3, "Flax GA");
INSERT VAndFColor VALUES (4, "Tile");
INSERT VAndFColor VALUES (5, "#99057");
INSERT VAndFColor VALUES (6, "Beige");
INSERT VAndFColor VALUES (7, "81041k");

CREATE TABLE RoofMaterial(
  RoofMaterialID int primary key auto_increment,
  RoofMaterialName varchar(30)
);
INSERT RoofMaterial VALUES (1,"Prestique I-30 yr");
INSERT RoofMaterial VALUES (2,"Prestique II-25 yr");
INSERT RoofMaterial VALUES (3,"Owner Corning");

CREATE TABLE RoofColor (
  RoofColorID int primary key auto_increment,
  RoofColorName varchar(30)
);
INSERT RoofColor values (1,"Sablewood");
INSERT RoofColor values (2,"Gray");
INSERT RoofColor values (3,"Onyx Black");
SELECT * FROM  RoofColor;

CREATE TABLE Siding(
  SidingID int primary key  auto_increment,
  SidngType varchar(20)
);
INSERT Siding values (1,"Vertical");
INSERT Siding values (2,"Horizontal");


CREATE TABLE HouseInterior(
  HouseInteriorID int auto_increment primary key,
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

INSERT HouseInterior VALUES (1,1,DATE '2001-01-01',1,'2001-01-1',1,1,'2013-07-01',7,'2007-06-01');

CREATE TABLE HouseExterior(
  HouseExteriorID INT primary key auto_increment,
  fk_SidingID INT,
  fk_ExteriorColorID Int,
  HouseExteriorPaintDate,
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
INSERT HouseExterior VALUES (1,2,4,2,1,1,'1996-01-01');

CREATE TABLE Tenant(
  TenantID int primary key auto_increment,
  TenantFirst varchar(30),
  TenantLast varchar(30),
  TenantPhone varchar(12)
);
CREATE TABLE Pet(
  PetID int primary key auto_increment,
  PetType varchar(30),
  PetBreed varchar(30)
);
CREATE TABLE LeadTenant(
  LeadTenantID int PRIMARY KEY auto_increment,
  LeadTenantFirst varchar(30),
  LeadTenantLast varchar(30),
  LeadTenantPhone varchar(12),
  LeadPetFeePaid bool,
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
  DishwasherID int PRIMARY KEY auto_increment,
  DishwasherColor varchar(30),
  DishwasherModel varchar(30),
  DishwasherSerial varchar(30),
  DishwasherPurchaseDate date
);
INSERT Dishwasher values (1, NULL, NULL ,NULL ,'2008-04-01');
CREATE TABLE CookingRange(
  RangeID int primary key  auto_increment,
  RangeBrand varchar(30),
  RangeColor varchar(30),
  RangeModel varchar(30),
  RangeSerial varchar(30),
  RangeReplaceDate date
);
INSERT CookingRange values(1,"GE","Harvest Gold","JMP22002HA",NULL,NULL );
CREATE TABLE HouseAppliances(
  HouseApplianceID int primary key auto_increment,
  fk_Ranger int,
  fk_Dishwasher int,
  HouseApplianceWHDate DATE,
  HouseApplianceGDDate DATE,
  HouseApplianceGutterDate DATE,
  HouseApplianceFurance Date,
  HouseApplianceHasRefer BOOL,

  FOREIGN KEY (fk_Dishwasher) REFERENCES Dishwasher(DishwasherID),
  FOREIGN KEY (fk_Ranger) REFERENCES CookingRange(RangeID)
);

INSERT HouseAppliances VALUES (1,1,1,'2010-03-1',NULL,'1997-08-01',NULL,NULL);


CREATE TABLE House (
  HouseID int primary key auto_increment,
  HouseNumber varchar(4),
  fk_Street int NOT NULL ,
  fk_Owner int NOT NULL ,
  fk_LeadTenant int,
  fk_SQPlan int,
  fk_HouseInterriorID int,
  fk_HouseExteriorID int,
  HouseHasGarageOpener BOOL,
  HouseHasFence BOOL,
  HouseHasOver BOOL,
  HouseDidDiscloseLea bool,
  HouseRent double,
  fk_HouseAppliancesID int,

  foreign key (fk_Street) REFERENCES  Street(StreetID),
  foreign key (fk_Owner) REFERENCES  Owner(OwnerID),
  foreign key (fk_LeadTenant) REFERENCES  LeadTenant(LeadTenantID),
  foreign key (fk_SQPlan) REFERENCES SQPlan(SQPlanID),
  foreign key (fk_HouseInterriorID) REFERENCES HouseInterior(HouseInteriorID),
  foreign key (fk_HouseExteriorID) REFERENCES  HouseExterior(HouseExteriorID),
  foreign key (fk_HouseAppliancesID) REFERENCES  HouseAppliances(HouseApplianceID)

);

INSERT House VALUES (1,"4611",1,1,NULL,1,1,1,FALSE,FALSE,TRUE,TRUE, 1099, 1);
CREATE TABLE MaintenanceTechnician (
  MaintenanceTechniciansID int primary key,
  MaintenanceTechnicianFirst varchar(20) NOT NULL,
  MaintenanceTechnicianLast varchar(30) NOT NULL
);
CREATE TABLE MaintenanceRequestType(
  MaintenanceRequestTypeID int primary key auto_increment,
  MaintenanceRequestTypeName varchar(30)
);
CREATE TABLE MaintenanceRequest (
  MaintenenceRequestID int primary key auto_increment,
  fk_LeadTenantID int NOT NULL,
  fk_MaintenanceTechnician Int,
  MaintenenceRequestDate INT,
  MaintenenceRequestDescription varchar(255),
  MaintenenceeRequestDateStarted date,
  MaintenenceRequestDateCompleted date,
  MaintenenceRequestCompletionHousrs int,
  fk_MaintenanceRequestTypeID int,
  MaintenanceRequestCanEnter bool,

  FOREIGN KEY (fk_LeadTenantID) REFERENCES LeadTenant(LeadTenantID),
  FOREIGN KEY (fk_MaintenanceTechnician) REFERENCES  MaintenanceTechnician(MaintenanceTechniciansID),
  FOREIGN KEY (fk_MaintenanceRequestTypeID) REFERENCES MaintenanceRequestType(MaintenanceRequestTypeID)
);
CREATE TABLE PartBrand(
  PartBrandID int auto_increment primary key,
  PartBrandName varchar(20) NOT NULL
);
CREATE TABLE Part(
  PartID int primary key auto_increment,
  PartName varchar(20),
  fk_PartBrand int,
  PartCost double,
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
  TransactionTypeID int auto_increment primary key,
  TransactionType varchar(20) NOT NULL
);
CREATE TABLE  TransactionFlags(
  TransactionFlagID int auto_increment primary key,
  TransactionFlagName varchar(30)
);
  CREATE TABLE Transaction(
    TransactionID int primary key auto_increment,
    fk_TennantID int,
    TransactionDate date,
    fk_TransactonTypeID int,
    TransactionAmount double,
    TransactionNotes varchar(255),
    fk_TransactionFlags int,

    FOREIGN KEY (fk_TennantID) REFERENCES Tenant(TenantID),
    FOREIGN KEY (fk_TransactonTypeID) REFERENCES  TransactionTypes(TransactionTypeID) ,
    FOREIGN KEY (fk_TransactionFlags) REFERENCES  TransactionFlags(TransactionFlagID)

  );