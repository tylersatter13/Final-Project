EXEC dbo.spGetMaintenceRequestByHouse 

DEFINE @LastNames var
SELECT * FROM dbo.MaintenanceRequest WHERE MaintenenceRequestDateCompleted IS NULL;
UPDATE dbo.MaintenanceRequest SET MaintenenceRequestDateCompleted;

SELECT  M.MaintenenceRequestID AS maintenanceRequestID,
	        M.MaintenancRequesteIsAppliance AS isAppliance,
	        M.MaintenanceRequestCanEnter AS permissionToEnter,
            M.MaintenenceRequestDate AS dateCreated,
			M.MaintenenceeRequestDateStarted AS dateStarted,
            M.MaintenenceRequestDateCompleted AS dateCompleted, 
			M.MaintenenceRequestAppointmentDate AS appointmentDate, 
			(SELECT COUNT(fk_Pet) FROM dbo.FamilyPet INNER JOIN dbo.Pet ON Pet.PetID = FamilyPet.fk_Pet WHERE fk_PetTypeID=1)AS Dogs,
			(SELECT COUNT(fk_Pet) FROM dbo.FamilyPet INNER JOIN dbo.Pet ON Pet.PetID = FamilyPet.fk_Pet WHERE fk_PetTypeID=2)AS Cats,
			M.MaintenenceRequestDescription AS jobdescription, 
			M.MaintenenceRequestWorkPerformed AS workPerformed ,
            M.MaintenenceRequestCompletionHousrs AS hoursWorked
	 FROM
	    MaintenanceRequest M LEFT JOIN
           LeadTenant Lead ON Lead.LeadTenantID = M.fk_LeadTenantID
		   LEFT JOIN FamilyPet ON  FamilyPet.fk_LeadTenantID = Lead.LeadTenantID
           LEFT JOIN Tenant T ON Lead.fk_TennantID = T.TenantID
     WHERE M.MaintenenceRequestDateCompleted  IS NULL

	 SELECT * FROM dbo.MaintenanceRequestType
	 INSERT MaintenanceRequestType (MaintenanceRequestTypeName)VALUES ('Appliance');
Insert MaintenanceRequestType (MaintenanceRequestTypeName)VALUES ('Plumbing');
Insert MaintenanceRequestType (MaintenanceRequestTypeName)VALUES ('Electrical');
Insert MaintenanceRequestType (MaintenanceRequestTypeName)VALUES ('Roof');
Insert MaintenanceRequestType (MaintenanceRequestTypeName)VALUES ('Paint');
Insert MaintenanceRequestType (MaintenanceRequestTypeName)VALUES ('Landscape');
Insert MaintenanceRequestType (MaintenanceRequestTypeName)VALUES ('Floor');
Insert MaintenanceRequestType (MaintenanceRequestTypeName)VALUES ('Cabinet');
SELECT * FROM dbo.MaintenanceRequestType
SELECT * FROM dbo.MaintenanceRequest
UPDATE dbo.MaintenanceRequest SET fk_MaintenanceRequestTypeID = 1 WHERE MaintenenceRequestID= 1;
EXEC spGetMaintenceRequestByType @;


 SELECT HouseID, HouseNumber, fk_Street, StreetName, HouseDidDiscloseLea, fk_SQPlan, S3.SQPlanName 
	  FROM  House 
		INNER JOIN Street S2 on House.fk_Street = S2.StreetID 
		INNER JOIN SQPlan S3 on House.fk_SQPlan = S3.SQPlanID  
	    INNER JOIN  Owner O on House.fk_Owner = O.OwnerID
	  WHERE HouseNumber = @Hou '4611';


	EXEC spGetHouseByNumber @House = '4611';


	 EXEC spGetHouseByLastName 'Arnold';
	
	EXEC spGetHouseByNumber @House
	  DECLARE @Last VARCHAR(30)
	SELECT @Last = TenantLast FROM dbo.MaintenanceRequest 
		INNER JOIN dbo.LeadTenant ON LeadTenant.LeadTenantID = MaintenanceRequest.fk_LeadTenantID
		INNER JOIN dbo.Tenant ON Tenant.TenantID = LeadTenant.fk_TennantID 
	WHERE MaintenenceRequestID =1
	EXEC spGetHouseByLastName @Last
	EXEC spGetHouseByMaintenance 1


		SELECT 
	    A.ApplianceID AS applianceID,
	    A.ApplianceBrand AS brand,
		A.ApplianceColor AS color,
		A.ApplianceModel AS model, 
		A.ApplianceSerial AS serialNumber,
		A.ApplianceLastRepalcementDate as lastReplacementDate
	FROM dbo.ApplianceRepairs AR
		INNER JOIN dbo.Appliance A ON A.ApplianceID = AR.fk_ApplianceID
		INNER JOIN dbo.MaintenanceRequest MR  ON MR.MaintenenceRequestID = AR.fk_MaintenanceRequet
	WHERE MR.MaintenenceRequestID = 1
	SELECT * FROM dbo.MaintenanceRequest

	EXEC dbo.spGetMaintenceRequest @LastName = 'Arnold' -- varchar(30)

	
	EXEC spGetOpenMaintenceRequest

	INSERT dbo.MaintenanceTechnician
	(
	    MaintenanceTechniciansID,
	    MaintenanceTechnicianFirst,
	    MaintenanceTechnicianLast
	)
	VALUES
	(   1,  -- MaintenanceTechniciansID - int
	    'John', -- MaintenanceTechnicianFirst - varchar(20)
	    'Doe'  -- MaintenanceTechnicianLast - varchar(30)
	    )

	UPDATE dbo.MaintenanceRequest SET fk_MaintenanceTechnician = 1 WHERE MaintenenceRequestID=1;
	EXEC spGetMaintenaceTechnician 1

	DECLARE @TechID int
	SELECT @TechID = fk_MaintenanceTechnician FROM dbo.MaintenanceRequest
	WHERE MaintenenceRequestID = 1;

	EXECUTE spGetMaintenaceTechnician @TechID
	EXECUTE dbo.spGetMaintenaceTechID 1