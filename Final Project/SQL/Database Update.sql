DROP TABLE HOUSE;
DROP TABLE HouseAppliances;


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
CREATE TABLE ExteriorFeatures(
  ExteriorFeaturesID Int primary key  identity(1,1),
  ExteriorFenece Date,
  ExteriorGutterReplacement Date,
  ExteriorGarageDoor Date,
  ExteriorDriveWay Date,
  ExteriorChimney Date
);
CREATE TABLE KeyNumber(
   KeyNumberID int identity(1,1) primary key ,
   KeyNumberCurrent varchar(6),
   KeyNumberCurrentDate DATE,
   KeyNumberPrevious varchar(6),
   KeyNumberPrevDate varchar(6)
);
CREATE TABLE HouseInterior(
  HouseInteriorID int identity(1,1) primary key,
  HouseLastPaintDate date,
  fk_CarpetColorID int,
  HouseInteriorCarpetDate DATE,
  fk_FermicaColorID int,
  fk_VynlColorID int,
  HouseInteriorVFInstall DATE,
  fk_StainID int,
  HouseBlindReplacement DATE,

  FOREIGN KEY (fk_CarpetColorID) REFERENCES Carpet (CarpetID),
  FOREIGN KEY (fk_VynlColorID) REFERENCES VAndFColor(VAndFID),
  FOREIGN KEY (fk_FermicaColorID) REFERENCES VAndFColor(VAndFID),
  FOREIGN KEY (fk_StainID) REFERENCES  Stain(StainID)
);


INSERT HouseInterior (HouseLastPaintDate, fk_CarpetColorID, HouseInteriorCarpetDate, fk_FermicaColorID, fk_VynlColorID,
                      HouseInteriorVFInstall, fk_StainID, HouseBlindReplacement) VALUES ('2001-01-01',1,'2001-01-1',1,1,'2013-07-01',7,'2007-06-01');

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

CREATE TABLE HouseInteriorColors(
   fk_HouseInteriorID int ,
   fk_InteriorColorID  INT,
   CONSTRAINT pk_HouseInteriorColors PRIMARY KEY (fk_HouseInteriorID,fk_InteriorColorID),
   FOREIGN  KEY  (fk_HouseInteriorID) REFERENCES HouseInterior(HouseInteriorID),
   FOREIGN  KEY  (fk_InteriorColorID) REFERENCES InteriorColor(InteriorColorID)
);

ALTER TABLE LeadTenant DROP COLUMN LeadTenantFirst;
ALTER TABLE LeadTenant ADD  fk_TennantID int;
ALTER TABLE LeadTenant ADD CONSTRAINT foreign key (fk_TennantID) REFERENCES Tenant(TenantID);