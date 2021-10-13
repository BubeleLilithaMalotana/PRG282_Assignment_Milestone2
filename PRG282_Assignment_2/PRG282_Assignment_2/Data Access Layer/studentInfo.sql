CREATE DATABASE studentDB;

CREATE TABLE studentInformation (
    StudentNumber INT,
    StudentName VARCHAR(100),
    Surname VARCHAR(100),
	DateOfBirth Date,
	Gender VARCHAR(100),
	Phone VARCHAR(100),
	StudentAddress VARCHAR(100)
)

CREATE TABLE moduleInformation(
	ModuleCode VARCHAR(100),
	ModuleName VARCHAR(100),
	ModuleDescription VARCHAR(100),
	Link VARCHAR(100)
)

SELECT * FROM studentInformation
SELECT * FROM moduleInformation