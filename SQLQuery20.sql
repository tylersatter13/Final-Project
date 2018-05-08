SELECT 
	    A.ApplianceID AS applianceID,
	    A.ApplianceBrand AS brand,
		A.ApplianceColor AS color,
		A.ApplianceModel AS model, 
		A.ApplianceSerial AS serialNumber,
		A.fk_ApplianceTypeID AS applianceType,
		A.ApplianceLastRepalcementDate as lastReplacementDate
	FROM dbo.Appliance A
	WHERE ApplianceID = (SELECT ApplianceID  FROM dbo.HouseAppliances INNER JOIN dbo.Appliance ON Appliance.ApplianceID = HouseAppliances.fk_Ranger
	WHERE HouseApplianceID = 1)

	SELECT
	   A.ApplianceID AS applianceID,
	    A.ApplianceBrand AS brand,
		A.ApplianceColor AS color,
		A.ApplianceModel AS model, 
		A.ApplianceSerial AS serialNumber,
		A.fk_ApplianceTypeID AS applianceType,
		A.ApplianceLastRepalcementDate as lastReplacementDate
	FROM dbo.Appliance A
	WHERE A.ApplianceID = (SELECT ApplianceID  FROM dbo.HouseAppliances INNER JOIN dbo.Appliance ON Appliance.ApplianceID = HouseAppliances.fk_Dishwasher
	WHERE HouseApplianceID = 1)


	SELECT * FROM dbo.House INNER JOIN 
	SELECT * FROM dbo.LeadTenant INNER JOIN dbo.Tenant ON Tenant.TenantID = LeadTenant.fk_TennantID
	SELECT * FROM dbo.SQPlan
	McAlpine