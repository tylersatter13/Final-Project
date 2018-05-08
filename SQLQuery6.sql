SELECT * FROM dbo.LeadTenant

SELECT LeadTenantID, LeadTenantRentAmount AS rentAmount,LeadTenantRentStart AS rentDate, Children , 
LeadTenantBalance as balance, TenantID,TenantFirst,TenantLast,TenantPhone 
FROM LeadTenant LEFT JOIN Tenant T on LeadTenant.fk_TennantID = T.TenantID WHERE LeadTena