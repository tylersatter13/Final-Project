CREATE TABLE ApplianceType(
  ApplianceTypeID INT PRIMARY KEY IDENTITY(1,1),
  ApplianceTypeName VARCHAR(30),
)

CREATE TABLE Appliance(
 ApplianceID INT PRIMARY KEY IDENTITY (1,1),
 fk_ApplianceTypeID INT,
 ApplianceBrand VARCHAR(30),
 ApplianceModel VARCHAR(30),
 ApplianceSerial VARCHAR(30),
 ApplianceLastRepalcementDate DATETIME,

 FOREIGN KEY (fk_ApplianceTypeID) REFERENCES ApplianceType (ApplianceTypeID)

);
CREATE TABLE ApplianceRepairs(
 fk_ApplianceID INT,
 fk_MaintenanceRequet INT,
 PRIMARY KEY(fk_ApplianceID,fk_MaintenanceRequet),
 FOREIGN KEY (fk_ApplianceID) REFERENCES dbo.Appliance(ApplianceID),
 FOREIGN KEY (fk_MaintenanceRequet) REFERENCES dbo.MaintenanceRequest(MaintenenceRequestID)
);

SELECT * FROM dbo.HouseAppliances
ALTER TABLE dbo.Appliance ADD ApplianceColor VARCHAR(30);
UPDATE dbo.Appliance SET ApplianceColor = 'HarvestGold' WHERE ApplianceID = 1;
UPDATE dbo.HouseAppliances SET fk_Dishwasher =2 WHERE HouseApplianceID = 1;

INSERT dbo.MaintenanceRequest
(
    fk_LeadTenantID,
    fk_MaintenanceTechnician,
    MaintenenceRequestDate,
    MaintenenceRequestDescription,
    MaintenenceeRequestDateStarted,
    MaintenenceRequestDateCompleted,
    MaintenenceRequestCompletionHousrs,
    fk_MaintenanceRequestTypeID,
    MaintenanceRequestCanEnter
)
VALUES
(   0,         -- fk_LeadTenantID - int
    0,         -- fk_MaintenanceTechnician - int
    0,         -- MaintenenceRequestDate - int
    '',        -- MaintenenceRequestDescription - varchar(255)
    GETDATE(), -- MaintenenceeRequestDateStarted - date
    GETDATE(), -- MaintenenceRequestDateCompleted - date
    0,         -- MaintenenceRequestCompletionHousrs - int
    0,         -- fk_MaintenanceRequestTypeID - int
    NULL       -- MaintenanceRequestCanEnter - bit
    )
SELECT  FROM dbo.ApplianceRepairs INNER JOIN dbo.Appliance ON fk_ApplianceTypeID=ApplianceID 
INNER JOIN dbo.MaintenanceRequest ON fk_MaintenanceRequet =MaintenenceRequestID
WHERE fk_ApplianceID = (SELECT AppalianceID FROM dbo.Appliance WHERE fk_ApplianceTypeID = 1)