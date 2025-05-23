﻿DROP DATABASE NCT;

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
    RoomID      CHAR(5)             PRIMARY KEY,  -- Mã phòng định dạng A0001, B0002
    RoomType    BIT			        NOT NULL DEFAULT 0, -- Phòng trống
    RentPrice   INT                 NOT NULL,     -- Giá thuê (VNĐ)
    Area        INT                 NOT NULL,     -- Diện tích (m²)
    Status      BIT		            NOT NULL DEFAULT 0, -- 0: Trống, 1: Đang thuê
	CreatedAt   DATETIME			DEFAULT GETDATE()
);

-- ==========================
-- 2. Tenant Table
-- ==========================
CREATE TABLE Tenant (
    TenantID        VARCHAR(6)          PRIMARY KEY,
    FullName        NVARCHAR(30)        NOT NULL,
    PhoneNumber     VARCHAR(20)         NOT NULL        UNIQUE,
    Email           NVARCHAR(100)       NULL            UNIQUE,
    Address         NVARCHAR(255)       NULL,
    NationalID      CHAR(12)            NOT NULL        UNIQUE, -- CCCD
    RoomID          CHAR(5)		        NULL,

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
    TenantID        VARCHAR(6)          NOT NULL,

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
    TenantID        VARCHAR(6)          NOT NULL,

    CONSTRAINT FK_Pet_Tenant FOREIGN KEY (TenantID) REFERENCES Tenant(TenantID)
);

-- ==========================
-- 5. Rental Contract Table
-- ==========================
CREATE TABLE RentalContract (
    ContractID          CHAR(11)            PRIMARY KEY,
    TenantID            VARCHAR(6)          NOT NULL,
    RoomID              CHAR(5)		        NOT NULL,
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
    TenantID            VARCHAR(6)          NULL,
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
    TenantID            VARCHAR(6)          NOT NULL,
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
    RoomID      CHAR(5)		        NOT NULL,
    TenantID    VARCHAR(6)          NOT NULL,
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
    RoomID      CHAR(5)		    NOT NULL,
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
    ServiceID   VARCHAR(6)          PRIMARY KEY,
    ServiceName NVARCHAR(30)        NOT NULL,
	ServiceType BIT					NOT NULL DEFAULT 0,  -- 1: Định kỳ, 0: Phát sinh
    UnitPrice   INT                 NOT NULL,
    Unit        NVARCHAR(15)        NOT NULL
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
    
    ServiceID       VARCHAR(6)          NOT NULL,
    RoomID          CHAR(5)             NOT NULL,
    TenantID        VARCHAR(6)          NULL,           -- Tenant who used the service (optional for personal services)
    
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
    RoomID          CHAR(5)		        NOT NULL,
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
    ServiceID       VARCHAR(6)          NOT NULL,                       -- Which service (Electricity, Water, etc.)
    
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
    TenantID        VARCHAR(6)          NOT NULL,       -- Who made the payment
    PaymentDate     DATE                NOT NULL,
    Amount          INT                 NOT NULL,
    PaymentMethod   NVARCHAR(50)        NOT NULL,       -- Cash, Bank Transfer, ZaloPay, etc.

    CONSTRAINT FK_PaymentHistory_Invoice FOREIGN KEY (InvoiceID) REFERENCES Invoice(InvoiceID),
    CONSTRAINT FK_PaymentHistory_Tenant  FOREIGN KEY (TenantID)  REFERENCES Tenant(TenantID)
);


CREATE TABLE Account (
    AccountID   INT IDENTITY(1,1)   PRIMARY KEY,
    Username    VARCHAR(15)         NOT NULL,
    Pass        VARCHAR(15)         NOT NULL,
);

INSERT INTO Account (Username, Pass) VALUES ('admin', '123456');


-- TRIGGER: Cập nhật trạng thái phòng và thông tin khách thuê khi thêm/cập nhật hợp đồng
GO
CREATE TRIGGER trg_ContractRoom
ON RentalContract
FOR INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @RoomID CHAR(5), @TenantID VARCHAR(6);
    SELECT @RoomID = RoomID, @TenantID = TenantID FROM inserted;

    -- Cập nhật trạng thái phòng (1 = Đã thuê)
    UPDATE Room
    SET Status = 1
    WHERE RoomID = @RoomID;

    -- Gán phòng cho khách thuê
    UPDATE Tenant
    SET RoomID = @RoomID
    WHERE TenantID = @TenantID;

    -- Đặt lại trạng thái các phòng không còn được thuê (0 = Trống)
    UPDATE Room
    SET Status = 0
    WHERE RoomID NOT IN (SELECT RoomID FROM Tenant WHERE RoomID IS NOT NULL);
END;
GO

GO
CREATE TRIGGER trg_DeleteContract
ON RentalContract
FOR DELETE
AS
BEGIN
    DECLARE @RoomID CHAR(5), @TenantID VARCHAR(6);
    SELECT @RoomID = RoomID, @TenantID = TenantID FROM deleted;

    -- Gán phòng cho khách thuê
    UPDATE Tenant
    SET RoomID = NULL
    WHERE TenantID = @TenantID;

    -- Đặt lại trạng thái các phòng không còn được thuê (0 = Trống)
    UPDATE Room
    SET Status = 0
    WHERE RoomID NOT IN (SELECT RoomID FROM Tenant WHERE RoomID IS NOT NULL);
END;
