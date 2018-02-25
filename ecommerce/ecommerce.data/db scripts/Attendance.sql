CREATE TABLE Attendance
(
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	StudentId INT,
	AttendanceDate DATE,
	IsPresent BIT,
	Remarks NVARCHAR(MAX)
)