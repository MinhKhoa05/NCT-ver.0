CREATE DATABASE NCT;
GO
USE NCT;

/*
===============================================
==                NCT_TENANT                 ==
===============================================
*/

-- ==========================
-- 1. Room Table
-- ==========================
CREATE TABLE Room (
    RoomID      VARCHAR(10)     PRIMARY KEY,
    RoomType    NVARCHAR(50)    NOT NULL,
    RentPrice   INT             NOT NULL,
    Area        INT             NOT NULL,
    Status      TINYINT         NOT NULL        -- 0: Available, 1: Occupied, etc.
);

-- ==========================
-- 2. Tenant Table
-- ==========================
CREATE TABLE Tenant (
    TenantID        INT IDENTITY(1,1)   PRIMARY KEY,
    FullName        NVARCHAR(50)        NOT NULL,
    PhoneNumber     VARCHAR(20)         NOT NULL,
    Email           NVARCHAR(100)       NULL,
    Address         NVARCHAR(255)       NULL,
    NationalID      VARCHAR(20)         NULL        UNIQUE, -- CCCD
    RoomID          VARCHAR(10)         NULL,

    CONSTRAINT FK_Tenant_Room FOREIGN KEY (RoomID) REFERENCES Room(RoomID)
);

-- ==========================
-- 3. Motorbike Table
-- ==========================
CREATE TABLE Motorbike (
    MotorbikeID     INT IDENTITY(1, 1)  PRIMARY KEY,
    LicensePlate    NVARCHAR(20)        NOT NULL        UNIQUE,
    Brand           NVARCHAR(50)        NOT NULL,
    Color           NVARCHAR(50)        NULL,
    Note            NVARCHAR(255)       NULL,
    Status          TINYINT             NOT NULL,       -- 0: Inactive, 1: Active
    TenantID        INT                 NOT NULL,

    CONSTRAINT FK_Motorbike_Tenant FOREIGN KEY (TenantID) REFERENCES Tenant(TenantID)
);

-- ==========================
-- 4. Pet Table
-- ==========================
CREATE TABLE Pet (
    PetID           INT IDENTITY(1, 1)  PRIMARY KEY,
    PetName         NVARCHAR(50)        NULL,
    Species         NVARCHAR(50)        NOT NULL,
    Description     NVARCHAR(255)       NULL,
    Status          TINYINT             NOT NULL,       -- 0: Inactive, 1: Active
    TenantID        INT                 NOT NULL,

    CONSTRAINT FK_Pet_Tenant FOREIGN KEY (TenantID) REFERENCES Tenant(TenantID)
);

-- ==========================
-- 5. Rental Contract Table
-- ==========================
CREATE TABLE RentalContract (
    ContractID          INT IDENTITY(1, 1)  PRIMARY KEY,
    TenantID            INT                 NOT NULL,
    RoomID              VARCHAR(10)         NOT NULL,
    StartDate           DATE                NOT NULL,
    EndDate             DATE                NOT NULL,
    RentPrice           INT                 NOT NULL,
    DepositAmount       INT                 NOT NULL,
    DepositReturnDate   DATE                NULL,
    Note                NVARCHAR(255)       NULL,

    CONSTRAINT FK_RentalContract_Tenant FOREIGN KEY (TenantID)  REFERENCES Tenant(TenantID),
    CONSTRAINT FK_RentalContract_Room   FOREIGN KEY (RoomID)    REFERENCES Room(RoomID)
);

-- ==========================
-- 6. Notification Table
-- ==========================
CREATE TABLE Notification (
    NotificationID      INT IDENTITY(1, 1)  PRIMARY KEY,
    TenantID            INT                 NULL,
    Content             NVARCHAR(500)       NOT NULL,
    SentDate            DATE                NOT NULL,
    SendChannel         NVARCHAR(50)        NOT NULL,       -- Email / Zalo / SMS, etc.
    NotificationType    NVARCHAR(50)        NOT NULL,       -- Payment Reminder / General Announcement...

    CONSTRAINT FK_Notification_Tenant FOREIGN KEY (TenantID) REFERENCES Tenant(TenantID)
);

-- ==========================
-- 7. Fingerprint Table
-- ==========================
CREATE TABLE Fingerprint (
    FingerprintID       INT IDENTITY(1, 1)  PRIMARY KEY,
    TenantID            INT                 NOT NULL,
    FingerprintTemplate VARBINARY(MAX)      NULL,
    InstallationDate    DATE                NOT NULL,
    Status              TINYINT             NOT NULL,       -- 0: Inactive, 1: Active
    Device              NVARCHAR(100)       NULL,           -- Which door/device it is registered on
    
    CONSTRAINT FK_Fingerprint_Tenant FOREIGN KEY (TenantID) REFERENCES Tenant(TenantID)
);

/*
===============================================
==                NCT_ROOM                   ==
===============================================
*/

-- ======================================
-- 8. RoomRentalHistory Table
-- ======================================
CREATE TABLE RoomRentalHistory (
    HistoryID   INT IDENTITY(1, 1)  PRIMARY KEY,
    RoomID      VARCHAR(10)         NOT NULL,
    TenantID    INT                 NOT NULL,
    MoveInDate  DATE                NOT NULL,
    MoveOutDate DATE                NULL,
    Note        NVARCHAR(255)       NULL,
    
    CONSTRAINT FK_RoomRentalHistory_Room    FOREIGN KEY (RoomID)    REFERENCES Room(RoomID),
    CONSTRAINT FK_RoomRentalHistory_Tenant  FOREIGN KEY (TenantID)  REFERENCES Tenant(TenantID)
);

-- ======================================
-- 9. Furniture Table (General)
-- ======================================
CREATE TABLE Furniture (
    FurnitureID     INT IDENTITY(1, 1)  PRIMARY KEY,
    FurnitureName   NVARCHAR(100)       NOT NULL,
    Description     NVARCHAR(255)       NULL,
    Unit            NVARCHAR(50)        NOT NULL
);

-- ======================================
-- 10. BasicFurnitureInRoom Table (Room + Furniture Mapping)
-- ======================================
CREATE TABLE BasicFurnitureInRoom (
    RoomID      VARCHAR(10)     NOT NULL,
    FurnitureID INT             NOT NULL,
    Quantity    INT             NOT NULL,
    Condition   NVARCHAR(50)    NOT NULL,    -- Example: New, Good, Needs Repair
    Note        NVARCHAR(255)   NULL,

    PRIMARY KEY (RoomID, FurnitureID),

    CONSTRAINT FK_BasicFurnitureInRoom_Room         FOREIGN KEY (RoomID)        REFERENCES Room(RoomID),
    CONSTRAINT FK_BasicFurnitureInRoom_Furniture    FOREIGN KEY (FurnitureID)   REFERENCES Furniture(FurnitureID)
);

-- ======================================
-- 11. Service Table
-- ======================================
CREATE TABLE Service (
    ServiceID   INT IDENTITY(1, 1)  PRIMARY KEY,
    ServiceName NVARCHAR(100)       NOT NULL,
    UnitPrice   INT                 NOT NULL,
    Unit        NVARCHAR(50)        NOT NULL
);

-- ======================================
-- 12. ServiceUsage Table
-- ======================================
CREATE TABLE ServiceUsage (
    ServiceUsageID  INT IDENTITY(1, 1)  PRIMARY KEY,
    UsageDate       DATE                NOT NULL,       -- The date the service was used or recorded       
    StartIndex      INT                 NULL,           -- Start meter reading (for Electricity/Water services)
    EndIndex        INT                 NULL,           -- End meter reading (for Electricity/Water services)
    Quantity        INT                 NOT NULL,
    
    ServiceID       INT                 NOT NULL,
    RoomID          VARCHAR(10)         NOT NULL,
    TenantID        INT                 NULL,           -- Tenant who used the service (optional for personal services)
    
    CONSTRAINT FK_ServiceUsage_Service  FOREIGN KEY (ServiceID) REFERENCES Service(ServiceID),
    CONSTRAINT FK_ServiceUsage_Room     FOREIGN KEY (RoomID)    REFERENCES Room(RoomID),
    CONSTRAINT FK_ServiceUsage_Tenant   FOREIGN KEY (TenantID)  REFERENCES Tenant(TenantID)
);

/*
===============================================
==                NCT_INVOICE                ==
===============================================
*/

-- ==========================
-- 13. Invoice Table
-- ==========================
CREATE TABLE Invoice (
    InvoiceID       VARCHAR(50)         PRIMARY KEY,
    RoomID          VARCHAR(10)         NOT NULL,
    IssueDate       DATE                NOT NULL,
    TotalAmount     INT                 NOT NULL,
    AmountPaid      INT                 NOT NULL DEFAULT 0,
    PreviousDebt    INT                 NOT NULL DEFAULT 0,
    BillingPeriod   VARCHAR(20)         NOT NULL,       -- For example: '2024-12' or 'March 2025'
    
    CONSTRAINT FK_Invoice_Room FOREIGN KEY (RoomID) REFERENCES Room(RoomID)
);

-- ==========================
-- 14. InvoiceDetail Table
-- ==========================
CREATE TABLE InvoiceDetail (
    InvoiceDetailID INT IDENTITY(1, 1)  PRIMARY KEY,
    InvoiceID       VARCHAR(50)         NOT NULL,
    ServiceID       INT                 NOT NULL,                       -- Which service (Electricity, Water, etc.)
    
    UnitPrice       INT                 NOT NULL,                       -- Price per unit (copy at invoice creation)
    Quantity        INT                 NOT NULL,
    Discount        INT                 DEFAULT 0,                      -- Any discount applied
    TotalAmount     AS ((UnitPrice * Quantity) - Discount) PERSISTED,   -- Calculated total
    Note            NVARCHAR(255)       NULL,

    CONSTRAINT FK_InvoiceDetail_Invoice FOREIGN KEY (InvoiceID) REFERENCES Invoice(InvoiceID),
    CONSTRAINT FK_InvoiceDetail_Service FOREIGN KEY (ServiceID) REFERENCES Service(ServiceID)
);

-- ==========================
-- 15. PaymentHistory Table
-- ==========================
CREATE TABLE PaymentHistory (
    PaymentID       INT IDENTITY(1, 1)  PRIMARY KEY,
    InvoiceID       VARCHAR(50)         NOT NULL,       -- Which invoice is paid (if any)
    TenantID        INT                 NOT NULL,       -- Who made the payment
    PaymentDate     DATE                NOT NULL,
    Amount          INT                 NOT NULL,
    PaymentMethod   NVARCHAR(50)        NOT NULL,       -- Cash, Bank Transfer, ZaloPay, etc.

    CONSTRAINT FK_PaymentHistory_Invoice FOREIGN KEY (InvoiceID) REFERENCES Invoice(InvoiceID),
    CONSTRAINT FK_PaymentHistory_Tenant  FOREIGN KEY (TenantID)  REFERENCES Tenant(TenantID)
);