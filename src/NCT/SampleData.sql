USE FootballScheduler;

-- Insert sample league
INSERT INTO League (LeagueID, LeagueName, LogoURL, MaxTeams, MinRestDays, StartDate, EndDate)
VALUES 
('L00001', N'V-League 2025', NULL, 20, 2, '2025-04-01', '2025-08-01');

-- Insert 20 stadiums (mỗi đội có một sân)
INSERT INTO Stadium (StadiumID, StadiumName, Address)
VALUES 
('S00001', N'Sân Đội 1', N'Hà Nội'),
('S00002', N'Sân Đội 2', N'Hồ Chí Minh'),
('S00003', N'Sân Đội 3', N'Đà Nẵng'),
('S00004', N'Sân Đội 4', N'Hải Phòng'),
('S00005', N'Sân Đội 5', N'Cần Thơ'),
('S00006', N'Sân Đội 6', N'Quảng Ninh'),
('S00007', N'Sân Đội 7', N'Nha Trang'),
('S00008', N'Sân Đội 8', N'Bình Dương'),
('S00009', N'Sân Đội 9', N'Vinh'),
('S00010', N'Sân Đội 10', N'Nam Định'),
('S00011', N'Sân Đội 11', N'Huế'),
('S00012', N'Sân Đội 12', N'Bắc Ninh'),
('S00013', N'Sân Đội 13', N'Long An'),
('S00014', N'Sân Đội 14', N'Thanh Hóa'),
('S00015', N'Sân Đội 15', N'Quảng Nam'),
('S00016', N'Sân Đội 16', N'Hà Tĩnh'),
('S00017', N'Sân Đội 17', N'Lạng Sơn'),
('S00018', N'Sân Đội 18', N'An Giang'),
('S00019', N'Sân Đội 19', N'Tây Ninh'),
('S00020', N'Sân Đội 20', N'Phú Yên');

-- Insert 20 teams (mỗi đội có sân riêng)
INSERT INTO Team (TeamID, TeamName, LogoURL, CoachName, Region, HomeStadiumID, Email, Phone)
VALUES 
('T00001', N'Đội 1', NULL, N'HLV 1', N'Hà Nội', 'S00001', 'team1@email.com', '0123456789'),
('T00002', N'Đội 2', NULL, N'HLV 2', N'Hồ Chí Minh', 'S00002', 'team2@email.com', '0123456790'),
('T00003', N'Đội 3', NULL, N'HLV 3', N'Đà Nẵng', 'S00003', 'team3@email.com', '0123456791'),
('T00004', N'Đội 4', NULL, N'HLV 4', N'Hải Phòng', 'S00004', 'team4@email.com', '0123456792'),
('T00005', N'Đội 5', NULL, N'HLV 5', N'Cần Thơ', 'S00005', 'team5@email.com', '0123456793'),
('T00006', N'Đội 6', NULL, N'HLV 6', N'Quảng Ninh', 'S00006', 'team6@email.com', '0123456794'),
('T00007', N'Đội 7', NULL, N'HLV 7', N'Nha Trang', 'S00007', 'team7@email.com', '0123456795'),
('T00008', N'Đội 8', NULL, N'HLV 8', N'Bình Dương', 'S00008', 'team8@email.com', '0123456796'),
('T00009', N'Đội 9', NULL, N'HLV 9', N'Vinh', 'S00009', 'team9@email.com', '0123456797'),
('T00010', N'Đội 10', NULL, N'HLV 10', N'Nam Định', 'S00010', 'team10@email.com', '0123456798'),
('T00011', N'Đội 11', NULL, N'HLV 11', N'Huế', 'S00011', 'team11@email.com', '0123456799'),
('T00012', N'Đội 12', NULL, N'HLV 12', N'Bắc Ninh', 'S00012', 'team12@email.com', '0123456800'),
('T00013', N'Đội 13', NULL, N'HLV 13', N'Long An', 'S00013', 'team13@email.com', '0123456801'),
('T00014', N'Đội 14', NULL, N'HLV 14', N'Thanh Hóa', 'S00014', 'team14@email.com', '0123456802'),
('T00015', N'Đội 15', NULL, N'HLV 15', N'Quảng Nam', 'S00015', 'team15@email.com', '0123456803'),
('T00016', N'Đội 16', NULL, N'HLV 16', N'Hà Tĩnh', 'S00016', 'team16@email.com', '0123456804'),
('T00017', N'Đội 17', NULL, N'HLV 17', N'Lạng Sơn', 'S00017', 'team17@email.com', '0123456805'),
('T00018', N'Đội 18', NULL, N'HLV 18', N'An Giang', 'S00018', 'team18@email.com', '0123456806'),
('T00019', N'Đội 19', NULL, N'HLV 19', N'Tây Ninh', 'S00019', 'team19@email.com', '0123456807'),
('T00020', N'Đội 20', NULL, N'HLV 20', N'Phú Yên', 'S00020', 'team20@email.com', '0123456808');

-- Insert 10 referees
INSERT INTO Referee (RefereeID, FullName, Region, ExperienceYears, BirthDate, Status, Email, Phone)
VALUES 
('R00001', N'Trọng tài 1', N'Hà Nội', 10, '1985-03-10', 1, 'ref1@email.com', '0900000001'),
('R00002', N'Trọng tài 2', N'Hồ Chí Minh', 12, '1983-06-21', 1, 'ref2@email.com', '0900000002'),
('R00003', N'Trọng tài 3', N'Đà Nẵng', 8, '1987-09-15', 1, 'ref3@email.com', '0900000003'),
('R00004', N'Trọng tài 4', N'Hải Phòng', 15, '1980-12-05', 1, 'ref4@email.com', '0900000004'),
('R00005', N'Trọng tài 5', N'Cần Thơ', 11, '1984-07-19', 1, 'ref5@email.com', '0900000005'),
('R00006', N'Trọng tài 6', N'Quảng Ninh', 7, '1990-05-30', 1, 'ref6@email.com', '0900000006'),
('R00007', N'Trọng tài 7', N'Nha Trang', 9, '1988-02-14', 1, 'ref7@email.com', '0900000007'),
('R00008', N'Trọng tài 8', N'Bình Dương', 13, '1982-11-23', 1, 'ref8@email.com', '0900000008'),
('R00009', N'Trọng tài 9', N'Vinh', 6, '1992-04-08', 1, 'ref9@email.com', '0900000009'),
('R00010', N'Trọng tài 10', N'Nam Định', 14, '1981-08-17', 1, 'ref10@email.com', '0900000010');