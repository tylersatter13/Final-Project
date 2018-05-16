INSERT dbo.LeadTenant
(
    LeadTenantFirst,
    LeadTenantLast,
    LeadTenantPhone,
    LeadPetFeePaid,
    LeadTenantRentStart,
    Children
)
VALUES
(   'Steve',        -- LeadTenantFirst - varchar(30)
    'Arnold',        -- LeadTenantLast - varchar(30)
    '805-404-1146',        -- LeadTenantPhone - varchar(12)
    NULL,      -- LeadPetFeePaid - bit
    '2017-07-17', -- LeadTenantRentStart - date
    0          -- Children - int
    )
SELECT * FROM dbo.LeadTenant

UPDATE dbo.House SET fk_LeadTenant = 1 WHERE HouseID = 1;
INSERT Tenant( TenantFirst, TenantLast, TenantPhone) VALUES('Sandie',  'Arnold','805-404-1146')

CREATE TABLE HouseTenant (
  fk_HouseID int,
  fk_TenantID int,

  PRIMARY KEY (fk_HouseID,fk_TenantID),
  FOREIGN KEY (fk_HouseID) REFERENCES  House(HouseID),
  FOREIGN KEY (fk_TenantID)REFERENCES  Tenant(TenantID)

)
INSERT dbo.HouseTenant( fk_HouseID, fk_TenantID) VALUES(1, 1);

ALTER TABLE LeadTenant DROP COLUMN LeadTenantPhone;
ALTER TABLE LeadTenant ADD  fk_TennantID int;
ALTER TABLE LeadTenant ADD CONSTRAINT FOR (fk_TennantID) REFERENCES Tenant(TenantID);