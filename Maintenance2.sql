INSERT dbo.ApplianceRepairs
(
    fk_ApplianceID,
    fk_MaintenanceRequet
)
VALUES
(   1, -- fk_ApplianceID - int
    1  -- fk_MaintenanceRequet - int
    )

SELECT  MaintenenceRequestDate, MaintenenceRequestID,ApplianceTypeName, ApplianceBrand, MaintenenceRequestDescription, MaintenenceRequestWorkPerformed, MaintenenceRequestDateCompleted
FROM dbo.ApplianceRepairs INNER JOIN dbo.Appliance ON ApplianceID = fk_ApplianceID 
INNER  JOIN dbo.MaintenanceRequest ON fk_MaintenanceRequet = MaintenenceRequestID
INNER JOIN dbo.ApplianceType ON ApplianceType.ApplianceTypeID = Appliance.fk_ApplianceTypeID;

INSERT dbo.MaintenanceRequest
(  fk_LeadTenantID,  fk_MaintenanceTechnician,  MaintenenceRequestDate,  MaintenenceRequestDescription,  MaintenenceRequestWorkPerformed,  MaintenenceeRequestDateStarted,  MaintenenceRequestDateCompleted, MaintenenceRequestAppointmentDate, MaintenenceRequestCompletionHousrs,  fk_MaintenanceRequestTypeID,
    MaintenanceRequestCanEnter,
    MaintenancRequesteIsAppliance
)
VALUES
(   0,         -- fk_LeadTenantID - int
    0,         -- fk_MaintenanceTechnician - int
    GETDATE(), -- MaintenenceRequestDate - date
    '',        -- MaintenenceRequestDescription - varchar(255)
    '',        -- MaintenenceRequestWorkPerformed - varchar(255)
    GETDATE(), -- MaintenenceeRequestDateStarted - date
    GETDATE(), -- MaintenenceRequestDateCompleted - date
    GETDATE(), -- MaintenenceRequestAppointmentDate - date
    0,         -- MaintenenceRequestCompletionHousrs - int
    0,         -- fk_MaintenanceRequestTypeID - int
    NULL,      -- MaintenanceRequestCanEnter - bit
    NULL       -- MaintenancRequesteIsAppliance - bit
    )
INSERT dbo.Tenant
(
    TenantFirst,
    TenantLast,
    TenantPhone
)
VALUES
(   'Sharon', -- TenantFirst - varchar(30)
    'McAlpine', -- TenantLast - varchar(30)
    '503-920-1037'  -- TenantPhone - varchar(12)
    )
	SELECT * FROM dbo.Tenant

INSERT dbo.LeadTenant
(
    fk_TennantID,
    LeadPetFeePaid,
    LeadTenantRentStart,
    Children,
    LeadTenantRentAmount,
    LeadTenantBalance
)
VALUES
(   3,         -- fk_TennantID - int
    200,      -- LeadPetFeePaid - bit
    '2007-11-12', -- LeadTenantRentStart - date
    1,         -- Children - int
    989,      -- LeadTenantRentAmount - decimal(18, 0)
    0       -- LeadTenantBalance - decimal(18, 0)
    )

INSERT dbo.HouseInterior
(
    fk_PrimaryColorID,
    fk_SecondaryColorID,
    HouseLastPaintDate,
    fk_CarpetColorID,
    HouseInteriorCarpetDate,
    fk_FermicaColorID,
    fk_VynlColorID,
    HouseInteriorVFInstall,
    fk_StainID,
    HouseBlindReplacement
)
VALUES
(   1,         -- fk_PrimaryColorID - int
    NULL,         -- fk_SecondaryColorID - int
    '2005-04-01', -- HouseLastPaintDate - date
    4,         -- fk_CarpetColorID - int
    '2005-04-01', -- HouseInteriorCarpetDate - date
    1,         -- fk_FermicaColorID - int
    1,         -- fk_VynlColorID - int
   '2005-04-01', -- HouseInteriorVFInstall - date
    4,         -- fk_StainID - int
    NULL  -- HouseBlindReplacement - date
    )
	SELECT * FROM dbo.HouseInterior
	SELECT * FROM dbo.RoofMaterial
	SELECT * FROM dbo.RoofColor

INSERT dbo.HouseExterior
(
    fk_SidingID,
    fk_ExteriorColorID,
    HouseExteriorPaintDate,
    fk_TrimID,
    fk_RoofMaterialID,
    fk_RoofColorID,
    HouseExteriorRoofInstall
)
VALUES
(   1,         -- fk_SidingID - int
    2,         -- fk_ExteriorColorID - int
    '2014-07-01', -- HouseExteriorPaintDate - date
    2,         -- fk_TrimID - int
    1,         -- fk_RoofMaterialID - int
    1,         -- fk_RoofColorID - int
    '1997-09-01'  -- HouseExteriorRoofInstall - date
    )
	SELECT * FROM dbo.HouseExterior
INSERT dbo.InteriorFeatures
(
    InterriorFeaturesHallShowerDate,
    InterriorFeaturesWaterHeaterDate,
    InterriorFeaturesCelingFanDate,
    InterriorFeaturesFurnanceReplacement
)
VALUES
(   NULL, -- InterriorFeaturesHallShowerDate - date
    '2009-11-01', -- InterriorFeaturesWaterHeaterDate - date
   NULL, -- InterriorFeaturesCelingFanDate - date
   '2016-02-01' -- InterriorFeaturesFurnanceReplacement - date
    )
	SELECT * FROM dbo.InteriorFeatures
INSERT dbo.ExteriorFeatures
(
    ExteriorFenece,
    ExteriorGutterReplacement,
    ExteriorGarageDoor,
    ExteriorDriveWay,
    ExteriorChimney
)
VALUES
(    NULL, -- ExteriorFenece - date
    NULL, -- ExteriorGutterReplacement - date
    NULL, -- ExteriorGarageDoor - date
    NULL, -- ExteriorDriveWay - date
   NULL  -- ExteriorChimney - date
    )
	SELECT * FROM dbo.ExteriorFeatures

INSERT dbo.Appliance
(
    fk_ApplianceTypeID,
    ApplianceBrand,
    ApplianceModel,
    ApplianceSerial,
    ApplianceLastRepalcementDate,
    ApplianceColor
)
VALUES
(   2,         -- fk_ApplianceTypeID - int
    'GE',        -- ApplianceBrand - varchar(30)
    'GSD2100V3BB',        -- ApplianceModel - varchar(30)
    'TA804372B',        -- ApplianceSerial - varchar(30)
    '2014-1-28', -- ApplianceLastRepalcementDate - datetime
    'Black'         -- ApplianceColor - varchar(30)
    )

SELECT * FROM dbo.Appliance


INSERT dbo.HouseAppliances
(
    fk_Ranger,
    fk_Dishwasher,
    HouseApplianceWHDate,
    HouseApplianceGDDate,
    HouseApplianceHasRefer
)
VALUES
(   3,         -- fk_Ranger - int
    4,         -- fk_Dishwasher - int
    '2011-09-1', -- HouseApplianceWHDate - date
    NULL, -- HouseApplianceGDDate - date
    0       -- HouseApplianceHasRefer - bit
    )
	SELECT * FROM dbo.HouseAppliances
INSERT dbo.House(HouseNumber,
	    fk_Street,
	    fk_Owner,
	    fk_LeadTenant,
	    fk_SQPlan,
	    fk_HouseInterriorID,
	    fk_HouseExteriorID,
	    fk_KeyNunberID,
	    fk_InterriorFeaturesID,
	    fk_ExterriorFeaturesID,
	    HouseDidDiscloseLea,
	    HouseRentStartDate,
	    HouseRent,
	    fk_HouseAppliancesID,
	    HouseMiscellaneous
	)
	VALUES
	(   '4588',        -- HouseNumber - varchar(4)
	    3,         -- fk_Street - int
	    2,         -- fk_Owner - int
	    2,         -- fk_LeadTenant - int
	    8,         -- fk_SQPlan - int
	    2,         -- fk_HouseInterriorID - int
	    2,         -- fk_HouseExteriorID - int
	    NULL,         -- fk_KeyNunberID - int
	    2,         -- fk_InterriorFeaturesID - int
	    3,         -- fk_ExterriorFeaturesID - int
	    1,      -- HouseDidDiscloseLea - bit
	   '2007', -- HouseRentStartDate - date
	    989,       -- HouseRent - float
	    2,         -- fk_HouseAppliancesID - int
	    NULL         -- HouseMiscellaneous - varchar(255)
	    );
		INSERT dbo.Pet
		(
		    PetType,
		    PetBreed
		)
		VALUES
		(   'Dog', -- PetType - varchar(30)
		    NUll  -- PetBreed - varchar(30)
		    )
		INSERT dbo.FamilyPet
		(
		    fk_LeadTenantID,
		    fk_Pet
		)
		VALUES
		(   2, -- fk_LeadTenantID - int
		    2  -- fk_Pet - int
		    )
		CREATE TABLE PetType(
		PetTypeID INT PRIMARY KEY IDENTITY(1,1),
		PetTypeName VARCHAR(30));

 SELECT PetID,PetTypeName,PetBreed FROM dbo.Pet INNER JOIN dbo.PetType ON fk_PetTypeID =PetTypeID;
 
 UPDATE dbo.Pet SET fk_PetTypeID = 1;
	SELECT MaintenenceRequestID AS maintenanceRequestID,MaintenancRequesteIsAppliance AS isAppliance,
	MaintenanceRequestCanEnter AS permissionToEnter,MaintenenceRequestDate AS dateCreated, 
	MaintenenceeRequestDateStarted AS dateStarted, MaintenenceRequestDateCompleted AS dateCompleted,
	MaintenenceRequestAppointmentDate AS appointmentDate, (SELECT DISTINCT COUNT(*)FROM dbo.FamilyPet LEFT JOIN dbo.Pet ON Pet.PetID = FamilyPet.fk_Pet 
	LEFT JOIN dbo.PetType ON PetTypeID =  fk_PetTypeID WHERE PetTypeID = 1 AND fk_LeadTenantID =2) AS Dog,
	(SELECT DISTINCT COUNT(*)FROM dbo.FamilyPet LEFT JOIN dbo.Pet ON Pet.PetID = FamilyPet.fk_Pet 
	LEFT JOIN dbo.PetType ON PetTypeID = fk_PetTypeID WHERE PetTypeID = 2 AND fk_LeadTenantID =2) AS Cat,
	MaintenenceRequestDescription AS jobdescription, MaintenenceRequestWorkPerformed AS workPerformed,
	MaintenenceRequestCompletionHousrs AS hoursWorked
	
	FROM MaintenanceRequest MR LEFT JOIN
	LeadTenant LT ON LeadTenant.LeadTenantID = MaintenanceRequest.fk_LeadTenantID LEFT JOIN
	FamilyPet FP ON  FamilyPet.fk_LeadTenantID = LeadTenant.LeadTenantID 
w	
	SELECT DISTINCT COUNT(*)FROM dbo.FamilyPet LEFT JOIN dbo.Pet ON Pet.PetID = FamilyPet.fk_Pet 
	LEFT JOIN dbo.PetType ON PetTypeID =  fk_PetTypeID WHERE PetTypeID = 1 AND fk_LeadTenantID =2;
  
	SELECT * FROM dbo.FamilyPet;

	SELECT * FROM dbo.Pet;
	SELECT * FROM dbo.ApplianceRepairs;

SELECT * FROM dbo.MaintenanceRequest

SELECT MaintenenceRequestID AS maintenanceRequestID,MaintenancRequesteIsAppliance AS isAppliance,
	MaintenanceRequestCanEnter AS permissionToEnter,MaintenenceRequestDate AS dateCreated, 
	MaintenenceeRequestDateStarted AS dateStarted, MaintenenceRequestDateCompleted AS dateCompleted,
	MaintenenceRequestAppointmentDate AS appointmentDate, (SELECT DISTINCT COUNT(*)FROM dbo.FamilyPet LEFT JOIN dbo.Pet ON Pet.PetID = FamilyPet.fk_Pet 
	LEFT JOIN dbo.PetType ON PetTypeID =  fk_PetTypeID WHERE PetTypeID = 1 AND fk_LeadTenantID =2) AS Dog,
	(SELECT DISTINCT COUNT(*)FROM dbo.FamilyPet LEFT JOIN dbo.Pet ON Pet.PetID = FamilyPet.fk_Pet 
	LEFT JOIN dbo.PetType ON PetTypeID = fk_PetTypeID WHERE PetTypeID = 2 AND fk_LeadTenantID =2) AS Cat,
	MaintenenceRequestDescription AS jobdescription, MaintenenceRequestWorkPerformed AS workPerformed,
	MaintenenceRequestCompletionHousrs AS hoursWorked FROM MaintenanceRequest MR LEFT JOIN ApplianceRepairs AR ON
	AR.fk_MaintenanceRequet = MR.MaintenenceRequestID  LEF WHERE AR.fk_ApplianceID =1;


SELECT * FROM dbo.LeadTenant INNER JOIN dbo.Tenant ON Tenant.TenantID = LeadTenant.fk_TennantID;

	SELECT COUNT(fk_Pet) FROM dbo.FamilyPet 
		INNER JOIN dbo.Pet ON Pet.PetID = FamilyPet.fk_Pet
    WHERE fk_LeadTenantID = 
	  (SELECT LeadTenantID
	   FROM LeadTenant LEFT JOIN dbo.Tenant ON Tenant.TenantID = LeadTenant.fk_TennantID
			LEFT JOIN dbo.MaintenanceRequest ON MaintenanceRequest.fk_LeadTenantID = LeadTenant.LeadTenantID
	   WHERE TenantLast = 'McAlpine') AND fk_PetTypeID = 1 AS Dogs
	SELECT fk_LeadTenant FROM  House WHERE HouseNumber = 1

	SELECT COUNT(FPet.fk_Pet) AS Dogs FROM dbo.FamilyPet FPet
		LEFT JOIN Pet P ON P.PetID = FPet.fk_Pet 
	WHERE FPet.fk_LeadTenantID = (SELECT LeadTenantID
		  FROM LeadTenant Lead 
				LEFT JOIN dbo.Tenant Ten ON Ten.TenantID = Lead.fk_TennantID
				LEFT JOIN dbo.MaintenanceRequest MR ON MR.fk_LeadTenantID = Lead.LeadTenantID
		  WHERE Ten.TenantLast ='McAlpine') AND P.fk_PetTypeID = '';
	DECLARE @count INT EXEC  dbo.spGetPetCount @LastName ='McAlpine', @PetType= 1, @count OUTPUT;
	 DECLARE @Dogs INT EXEC dbo.spGetPetCount 'McAlpine', 1, @Dogs OUTPUT 
	 DECLARE @Cats INT EXEC dbo.spGetPetCount 'McAlpine', 2, @Cats OUTPUT 
 SELECT @Dogs AS Dogs,@Cats AS cats  FROM dbo.House
	EXECUTE dbo.spGetMaintenceRequest @LastName = 'Arnold'