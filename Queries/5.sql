	SELECT 
	
	P.PartID AS partID,
	P.PartName AS partName,
	P.PartCost ASpartCost,
	P.PartStockorCharge AS inStock
	FROM
	 dbo.Material Mat
		INNER JOIN dbo.MaintenanceRequest MR ON MR.MaintenenceRequestID = Mat.fk_MaintenanceRequest
		INNER JOIN dbo.Part P ON P.PartID = Mat.fk_PartID
	WHERE Mat.fk_MaintenanceRequest = 1