SELECT  M.MaintenenceRequestID AS maintenanceRequestID,
	        M.MaintenancRequesteIsAppliance AS isAppliance,
	        M.MaintenanceRequestCanEnter AS permissionToEnter,
            M.MaintenenceRequestDate AS dateCreated,
			M.MaintenenceeRequestDateStarted AS dateStarted,
            M.MaintenenceRequestDateCompleted AS dateCompleted, 
			M.MaintenenceRequestAppointmentDate AS appointmentDate, 
			--@Dogs AS Dogs,
			--@Cats AS Cats,
			M.MaintenenceRequestDescription AS jobdescription, 
			M.MaintenenceRequestWorkPerformed AS workPerformed ,
            M.MaintenenceRequestCompletionHousrs AS hoursWorked
	 FROM
	    MaintenanceRequest M LEFT JOIN
           LeadTenant Lead ON Lead.LeadTenantID = M.fk_LeadTenantID
		   LEFT JOIN FamilyPet ON  FamilyPet.fk_LeadTenantID = Lead.LeadTenantID
           LEFT JOIN Tenant T ON Lead.fk_TennantID = T.TenantID
     WHERE TenantLast = 'Arnold'

	 SELECT * FROM dbo.House
	 EXEC spGetMaintenceRequestByHouse 4611 
	 