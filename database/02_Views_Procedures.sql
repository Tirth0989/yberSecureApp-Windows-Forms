USE CyberSecureCloudSolutionsDB;
GO

/* Views used by the Windows Forms application */

CREATE OR ALTER VIEW dbo.vw_ClientsAccounts
AS
SELECT
    c.ClientID,
    c.Name AS ClientName,
    c.ContactEmail,
    c.ContactPhone,
    c.Address,
    a.AccountID,
    a.AccountName,
    a.AccountStatus
FROM dbo.Client AS c
LEFT JOIN dbo.Account AS a
    ON a.ClientID = c.ClientID;
GO

CREATE OR ALTER VIEW dbo.vw_AccountsServices
AS
SELECT
    a.AccountID,
    a.AccountName,
    s.ServiceID,
    s.ServiceName,
    sub.SubscriptionID,
    sub.SubscriptionDate,
    sub.SubscriptionStatus
FROM dbo.Subscriptions AS sub
INNER JOIN dbo.Account AS a
    ON a.AccountID = sub.AccountID
INNER JOIN dbo.Services AS s
    ON s.ServiceID = sub.ServiceID;
GO

/* Client procedures */

CREATE OR ALTER PROCEDURE dbo.usp_InsertClient
    @Name NVARCHAR(100),
    @ContactEmail NVARCHAR(255),
    @ContactPhone NVARCHAR(20),
    @Address NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.Client (Name, ContactEmail, ContactPhone, Address)
    VALUES (@Name, @ContactEmail, @ContactPhone, @Address);
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_UpdateClient
    @ClientID INT,
    @Name NVARCHAR(100),
    @ContactEmail NVARCHAR(255),
    @ContactPhone NVARCHAR(20),
    @Address NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.Client
    SET
        Name = @Name,
        ContactEmail = @ContactEmail,
        ContactPhone = @ContactPhone,
        Address = @Address
    WHERE ClientID = @ClientID;
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_DeleteClient
    @ClientID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM dbo.Client
    WHERE ClientID = @ClientID;
END;
GO

/* Account procedures */

CREATE OR ALTER PROCEDURE dbo.usp_InsertAccount
    @AccountName NVARCHAR(100),
    @ClientID INT,
    @SubscriptionDate DATE,
    @AccountStatus NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.Account
        (AccountName, ClientID, SubscriptionDate, AccountStatus)
    VALUES
        (@AccountName, @ClientID, @SubscriptionDate, @AccountStatus);
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_UpdateAccount
    @AccountID INT,
    @AccountName NVARCHAR(100),
    @AccountStatus NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.Account
    SET
        AccountName = @AccountName,
        AccountStatus = @AccountStatus
    WHERE AccountID = @AccountID;
END;
GO

/* Service procedures */

CREATE OR ALTER PROCEDURE dbo.usp_InsertService
    @ServiceName NVARCHAR(100),
    @ServiceDescription NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.Services (ServiceName, ServiceDescription)
    VALUES (@ServiceName, @ServiceDescription);
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_UpdateService
    @ServiceID INT,
    @ServiceName NVARCHAR(100),
    @ServiceDescription NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.Services
    SET
        ServiceName = @ServiceName,
        ServiceDescription = @ServiceDescription
    WHERE ServiceID = @ServiceID;
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_DeleteService
    @ServiceID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM dbo.Services
    WHERE ServiceID = @ServiceID;
END;
GO

/* Subscription procedure */

CREATE OR ALTER PROCEDURE dbo.usp_InsertSubscription
    @AccountID INT,
    @ServiceID INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.Subscriptions
        (AccountID, ServiceID, SubscriptionDate)
    VALUES
        (@AccountID, @ServiceID, CONVERT(DATE, GETDATE()));
END;
GO

/* Cybersecurity incident procedures */

CREATE OR ALTER PROCEDURE dbo.usp_InsertCybersecurityIncident
    @AccountID INT,
    @IncidentDate DATE,
    @IncidentType NVARCHAR(100),
    @SeverityLevel NVARCHAR(20),
    @Description NVARCHAR(500)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO dbo.CybersecurityIncidents
        (AccountID, IncidentDate, IncidentType, IncidentStatus, SeverityLevel, Description)
    VALUES
        (@AccountID, @IncidentDate, @IncidentType, 'Open', @SeverityLevel, @Description);
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_UpdateCybersecurityIncident
    @IncidentID INT,
    @AccountID INT,
    @IncidentDate DATE,
    @IncidentType NVARCHAR(100),
    @SeverityLevel NVARCHAR(20),
    @Description NVARCHAR(500)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.CybersecurityIncidents
    SET
        AccountID = @AccountID,
        IncidentDate = @IncidentDate,
        IncidentType = @IncidentType,
        SeverityLevel = @SeverityLevel,
        Description = @Description
    WHERE IncidentID = @IncidentID;
END;
GO

CREATE OR ALTER PROCEDURE dbo.usp_ResolveCybersecurityIncident
    @IncidentID INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE dbo.CybersecurityIncidents
    SET IncidentStatus = 'Resolved'
    WHERE IncidentID = @IncidentID;
END;
GO
