 SELECT * FROM dbo.Owner WHERE OwnerID = (SELECT fk_Owner FROM dbo.House WHERE HouseID = 4)

 
SELECT LeadTenantID, LeadTenantRentAmount,LeadTenantRentStart, Children, LeadTenantBalance as balance,
TenantID,TenantFirst,TenantLast,
TenantPhone FROM LeadTenant LEFT JOIN Tenant T on LeadTenant.fk_TenantID = T.TenantID WHERE LeadTenantID=1