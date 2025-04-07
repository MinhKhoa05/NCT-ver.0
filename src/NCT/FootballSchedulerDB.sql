CREATE DATABASE FootballScheduler;
GO
USE FootballScheduler;

/*
============================
=====   CREATE TABLE   =====
============================
*/

-- League information
CREATE TABLE League (
    LeagueID        VARCHAR(6)      PRIMARY KEY,
    LeagueName      NVARCHAR(100)   NOT NULL,
    LogoURL         NVARCHAR(255)   NULL,

    MaxTeams        TINYINT         NOT NULL    DEFAULT 2 CHECK (MaxTeams >= 2),
    MinRestDays     TINYINT         NOT NULL    DEFAULT 2 CHECK (MinRestDays > 0),

    StartDate       DATE            NOT NULL,
    EndDate         DATE            NOT NULL,
    Status          TINYINT         NOT NULL    DEFAULT 1,       -- 1: Not started, 2: Ongoing, 3: Completed

    CreatedAt       DATETIME        NOT NULL    DEFAULT GETDATE()
);

-- Stadium information
CREATE TABLE Stadium (
    StadiumID       VARCHAR(6)      PRIMARY KEY,
    StadiumName     NVARCHAR(50)    NOT NULL,
    Address         NVARCHAR(100)   NOT NULL,
    IsNeutralVenue  BIT             NOT NULL    DEFAULT 0,     -- 1: Neutral, 0: Home stadium
    Status          TINYINT         NOT NULL    DEFAULT 1,     -- 1: Active, 2: Inactive, 3: Maintenance
);

-- System user accounts (Admin, Team, Referee)
CREATE TABLE Account (
    AccountID       INT IDENTITY(1,1) PRIMARY KEY,
    UserName        VARCHAR(50)       NOT NULL UNIQUE,
    PasswordHash    NVARCHAR(255)     NOT NULL,
    -- Role            TINYINT           NOT NULL,             -- 1: Admin, 2: Team, 3: Referee
    -- IsActive        BIT               NOT NULL DEFAULT 1,   -- 1: Active, 0: Locked
);

-- Teams
CREATE TABLE Team (
    TeamID          VARCHAR(6)      PRIMARY KEY,
    TeamName        NVARCHAR(50)    NOT NULL,
    LogoURL         NVARCHAR(255)   NULL,
    CoachName       NVARCHAR(30)    NOT NULL,
    Region          NVARCHAR(30)    NOT NULL,

    HomeStadiumID   VARCHAR(6)      NULL,       -- Home stadium (optional)

    Email           NVARCHAR(255)   NOT NULL,
    Phone           VARCHAR(20)     NULL,

    CONSTRAINT FK_Team_Stadium  FOREIGN KEY (HomeStadiumID) REFERENCES Stadium(StadiumID),
);

-- League_Team
CREATE TABLE League_Team (
    LeagueID        VARCHAR(6)  NOT NULL,
    TeamID          VARCHAR(6)  NOT NULL,
    WithdrawDate    DATE        NULL, -- NULL = Active, HasDate = Withdrawn

    PRIMARY KEY (LeagueID, TeamID),

    CONSTRAINT FK_LeagueTeam_League FOREIGN KEY (LeagueID)  REFERENCES League(LeagueID),
    CONSTRAINT FK_LeagueTeam_Team   FOREIGN KEY (TeamID)    REFERENCES Team(TeamID)
);

-- Referees
CREATE TABLE Referee (
    RefereeID       VARCHAR(6)      PRIMARY KEY,
    FullName        NVARCHAR(30)    NOT NULL,
    Region          NVARCHAR(30)    NOT NULL,
    ExperienceYears TINYINT         NOT NULL,
    BirthDate       DATE            NOT NULL,
    Status          TINYINT         NOT NULL DEFAULT 1,   -- 1: Active, 2: Retired, 3: Suspended

    Email           NVARCHAR(255)   NOT NULL,
    Phone           VARCHAR(20)     NULL
);

-- Matches
CREATE TABLE Match (
    MatchID         INT IDENTITY(1,1)   PRIMARY KEY,
    HomeTeamID      VARCHAR(6)          NOT NULL,
    AwayTeamID      VARCHAR(6)          NOT NULL,
    HomeGoals       TINYINT             NULL CHECK (HomeGoals >= 0),
    AwayGoals       TINYINT             NULL CHECK (AwayGoals >= 0),
    RoundNumber     TINYINT             NOT NULL,
    
    LeagueID        VARCHAR(6)          NOT NULL,
    KickoffDateTime DATETIME            NOT NULL,

    StadiumID       VARCHAR(6)          NOT NULL,

    RefereeID       VARCHAR(6)          NULL,           -- Main Referee

    Status          TINYINT             NOT NULL DEFAULT 1,  
    -- 1: Scheduled, 2: Postponed, 3: Completed, 4: Canceled

    CONSTRAINT FK_Match_HomeTeam  FOREIGN KEY (HomeTeamID) REFERENCES Team(TeamID),
    CONSTRAINT FK_Match_AwayTeam  FOREIGN KEY (AwayTeamID) REFERENCES Team(TeamID),
    CONSTRAINT FK_Match_League    FOREIGN KEY (LeagueID)   REFERENCES League(LeagueID),
    CONSTRAINT FK_Match_Stadium   FOREIGN KEY (StadiumID)  REFERENCES Stadium(StadiumID),
    CONSTRAINT FK_Match_Referee   FOREIGN KEY (RefereeID)  REFERENCES Referee(RefereeID), 

    CONSTRAINT CK_Match_TeamDifferent CHECK (HomeTeamID <> AwayTeamID)
);

-- League standings
CREATE TABLE Standing (
    LeagueID        VARCHAR(6)  NOT NULL,
    TeamID          VARCHAR(6)  NOT NULL,
    MatchesPlayed   SMALLINT    NOT NULL DEFAULT 0,
    Wins            SMALLINT    NOT NULL DEFAULT 0,
    Draws           SMALLINT    NOT NULL DEFAULT 0,
    Losses          SMALLINT    NOT NULL DEFAULT 0,
    GoalsScored     INT         NOT NULL DEFAULT 0,
    GoalsConceded   INT         NOT NULL DEFAULT 0,

    GoalDiff       AS (GoalsScored - GoalsConceded) PERSISTED,
    Points         AS (Wins * 3 + Draws)            PERSISTED,


    PRIMARY KEY (LeagueID, TeamID),

    CONSTRAINT FK_Standing_League FOREIGN KEY (LeagueID) REFERENCES League(LeagueID),
    CONSTRAINT FK_Standing_Team   FOREIGN KEY (TeamID)   REFERENCES Team(TeamID)
);

-- Notifications to users
CREATE TABLE Notification (
    NotificationID    INT IDENTITY(1,1) PRIMARY KEY,
    Title             NVARCHAR(100)     NOT NULL,
    Content           NVARCHAR(500)     NOT NULL,
    CreatedAt         DATETIME          NOT NULL DEFAULT GETDATE(),
    Receiver          NVARCHAR(6)       NOT NULL
);

insert into Account(UserName, PasswordHash)
values ('admin', '123456');