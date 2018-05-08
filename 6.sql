SELECT * FROM dbo.TenantTransaction
SELECT COUNT(TransactionDate) 
FROM dbo.TenantTransaction 
	INNER JOIN dbo.LeadTenant ON LeadTenant.LeadTenantID = TenantTransaction.fk_LeadTennantID
WHERE fk_TransactonTypeID = 1 AND
	TransactionDate = (SELECT DATEFROMPARTS( YEAR(GETDATE()) ,MONTH(GETDATE()),DAY(LeadTenantRentStart)) 
						FROM dbo.LeadTenant INNER JOIN dbo.Tenant ON Tenant.TenantID = LeadTenant.fk_TennantID
						WHERE TenantLast = 'Arnold' );

DECLARE @LeadTenant VARCHAR(30);
DECLARE @Date DATETIME;

SELECT @Date = DATEFROMPARTS(YEAR(GETDATE()),MONTH(GETDATE()),DAY(LeadTenantRentStart)),@LeadTenant = LeadTenantID
	FROM dbo.LeadTenant INNER JOIN dbo.Tenant ON Tenant.TenantID = LeadTenant.fk_TennantID WHERE TenantLast = 'Arnold' ;
SELECT * FROM dbo.LeadTenant WHERE LeadTenantID = @LeadTenant

EXEC dbo.spGetTennatTransactions @LastName = 0 -- int

 DECLARE @MonthlyPaymentDate DATETIME
 DECLARE @LeadTenantID INT
 DECLARE @RentAmount DECIMAL
		SELECT @MonthlyPaymentDate = DATEFROMPARTS(YEAR(GETDATE()),MONTH(GETDATE()),DAY(LeadTenantRentStart)),@LeadTenantID=LeadTenantID, @RentAmount=LeadTenantRentAmount
			FROM dbo.LeadTenant INNER JOIN dbo.Tenant ON  Tenant.TenantID = LeadTenant.fk_TennantID WHERE  TenantLast ='Arnold';

	   EXEC spCreateTransaction @LeadTenantID,@MonthlyPaymentDate,1,@RentAmount,NULL

	   UPDATE dbo.LeadTenant SET LeadTenantRentAmount = 919 WHERE LeadTenantID = 1;
	   SELECT * FROM dbo.LeadTenant
	   DELETE dbo.TenantTransaction WHERE TransactionID = 16;
	  SELECT * FROM dbo.TenantTransaction
	EXEC  spGetTennatTransactions 'Arnold' 
	SELECT * FROM dbo.LeadTenant WHERE LeadTenantID=1

	SELECT SUM(TransactionAmount) FROM dbo.TenantTransaction WHERE fk_LeadTennantID = 1  
	
	SELECT
	LeadTenantID   AS LeadtenantID , 
	Ten.TransactionDate  AS transactionDate,
	Ten.fk_TransactonTypeID   AS transactiontype  ,
	Ten.TransactionAmount transactionAmount,
	SUM(Ten.TransactionAmount) 
		OVER (PARTITION BY LeadTenantID ORDER BY TransactionDate,TransactionID) AS  currentBalance,  -- Sums balance based on tenant Type
    Ten.TransactionNotes as Notes
	FROM dbo.TenantTransaction Ten
			INNER JOIN dbo.LeadTenant ON LeadTenant.LeadTenantID = Ten.fk_LeadTennantID 
			INNER JOIN dbo.Tenant ON Tenant.TenantID = LeadTenant.fk_TennantID
	WHERE  TenantLast = 'Arnold';