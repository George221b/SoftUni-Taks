	--> 4.
INSERT INTO Towns
VALUES (1, 'Sofia'),
(2, 'Plovdiv'),
(3, 'Varna');

INSERT INTO Minions
VALUES (1, 'Kevin', 22, 1),
(2, 'Bob', 15, 3),
(3, 'Steward', NULL, 2);

	--> 7.
CREATE TABLE People
(
Id INT IDENTITY PRIMARY KEY,
Name nvarchar(200) NOT NULL,
Picture varBINARY(max),
Height DECIMAL(10,2),
Weight DECIMAL(10,2),
Gender VARCHAR(2) NOT NULL CHECK (Gender IN ('m', 'f')),
Birthdate DATE NOT NULL,
Biography nvarchar(max)
)
 
INSERT INTO People(Name, Gender, Birthdate)
VALUES
('Stefan', 'm', '1989-01-01'),
('John', 'm', '1999-02-02'),
('Ace', 'f', '2013-01-01'),
('Peter', 'm', '1999-03-03'),
('Lena', 'f', '1993-03-01')

	--> 8.
create table Users
(
    Id BIGINT PRIMARY KEY IDENTITY,
    Username varchar(30) UNIQUE NOT NULL,
    Password nvarchar(26) NOT NULL,
    ProfilePicture VARBINARY(max),
    LastLoginTime DATE,
    IsDeleted BIT
)
  
INSERT INTO Users (Username, Password, ProfilePicture, LastLoginTime, IsDeleted)
VALUES
('George', 'Pass123', NULL, NULL, 0),
('Sam', '12345', NULL, NULL, 0),
('Frodo', '67890', NULL, NULL, 0),
('Aragorn', 'qwerty', NULL, NULL, 1),
('Gimli', 'asdfg', NULL, NULL, 0)

	--> 13.
CREATE TABLE Directors (
Id int PRIMARY KEY NOT NULL,
DirectorName nvarchar(50) NOT NULL,
Notes nvarchar(max)
)

CREATE TABLE Genres (
Id int PRIMARY KEY NOT NULL,
GenreName nvarchar(100) NOT NULL,
Notes nvarchar(max)
)

CREATE TABLE Categories (
Id int PRIMARY KEY NOT NULL,
CategoryName nvarchar(100) NOT NULL,
Notes nvarchar(max)
)

CREATE TABLE Movies (
Id int PRIMARY KEY NOT NULL,
Title nvarchar(100) NOT NULL,
DirectorId int FOREIGN KEY REFERENCES Directors(Id) NOT NULL,
CopyrightYear int,
Length int,
GenreId int NOT NULL FOREIGN KEY REFERENCES Genres(Id),
CategoryId int NOT NULL FOREIGN KEY REFERENCES Categories(Id),
Rating numeric(10,2),
Notes nvarchar(max)
)

INSERT INTO Directors
VALUES (1, 'Ivan', 'I am ivan'),
(2, 'Hristo', 'Hristo, you can call me Hristo.'),
(3, 'Franz', 'I am Franz'),
(4, 'Joseph', 'Old school name'),
(5, 'Adolfstein', 'Not the bad one')

INSERT INTO Genres
VALUES (1, 'Comedy', 'Best genre, but not among critics.'),
(2, 'Drama', 'Best genre to steal the oscards'),
(3, 'Adventure', 'Adolfs best genre'),
(4, 'Musical', 'Les Misarables the classic'),
(5, 'Western', 'All hail Quentin Tarantino')

INSERT INTO Categories
VALUES (1, 'Best Picture', NULL),
(2, 'Best Drama', NULL),
(3, 'Best among Teens', NULL),
(4, 'Worst picture', NULL),
(5, 'Worst screenplay', NULL)

INSERT INTO Movies
VALUES (1, 'Djumandji', 3, 2017, 120, 1, 2, 5.50, NULL),
(2, 'The Revenant', 1, 2015, 220, 2, 1, 9.50, NULL),
(3, 'Brother where', 2, 2000, 190, 3, 2, 5.50, NULL),
(4, 'No way', 5, 2001, 150, 1, 4, 5.55, NULL),
(5, 'In the end', 5, 2017, 190, 1, 5, 6.50, NULL)

	--> 14.
CREATE TABLE Categories (
Id int PRIMARY KEY NOT NULL,
Category nvarchar(100) NOT NULL,
DailyRate numeric(10, 2),
MonthlyRate numeric(10, 2),
WeekendRate numeric(10, 2),
)

CREATE TABLE Cars (
Id int PRIMARY KEY NOT NULL,
PlateNumber nvarchar(50) NOT NULL,
Make nvarchar(50),
Model nvarchar(100),
CarYear int,
CategoryId int FOREIGN KEY REFERENCES Categories(Id),
Doors int,
Picture varbinary(max),
Condition nvarchar(250),
Available bit
)

CREATE TABLE Employees (
Id int PRIMARY KEY NOT NULL,
FirstName nvarchar(50) NOT NULL,
LastName nvarchar(50) NOT NULL,
Title nvarchar(25),
Notes nvarchar(max)
)

CREATE TABLE Customers (
Id int PRIMARY KEY NOT NULL,
DriverLicenseNumber nvarchar(100) NOT NULL,
FullName nvarchar(100) NOT NULL,
Adress nvarchar(200) NOT NULL,
City nvarchar(50) NOT NULL,
ZIPCode nvarchar(10) NOT NULL,
Notes nvarchar(max)
)

CREATE TABLE RentalOrders (
Id int PRIMARY KEY NOT NULL,
EmployeeId int FOREIGN KEY REFERENCES Employees(Id),
CustomerId int FOREIGN KEY REFERENCES Customers(Id),
CarId int FOREIGN KEY REFERENCES Cars(Id),
CarCondition nvarchar(100),
TankLevel int,
KilometrageStart int,
KilometrageEnd int,
TotalKilometrage int,
StartDate date,
EndDate date,
TotalDays int,
RateApplied numeric(10, 2),
TaxRate numeric(10, 2),
OrderStatus bit,
Notes nvarchar(max)
)

INSERT INTO Categories
VALUES (1, 'Raceing', 100.44, 190.43, 200.50),
(2, 'Old School', 55.1, 244.43, 500.50),
(3, 'Common', 2300.44, 2190.43, 5100.50)

INSERT INTO Cars
VALUES (1, 'BG10020NC', NULL, 'BMW', 2014, 3, 4, NULL, 'Not bad', 0),
(2, 'BG2320DC', NULL, 'Opel', 2000, 1, 4, NULL, 'Superb', 0),
(3, 'BG1240SNC', NULL, 'Nissan', 2011, 2, 4, NULL, 'Hell Yeah', 0)

INSERT INTO Employees
VALUES (1, 'Michael', 'Johnson', 'Dr.', NULL),
(2, 'Brad', 'Pitt', 'Mr.', NULL),
(3, 'Chritoph', 'Waltz', 'Sir', NULL)

INSERT INTO Customers
VALUES (1, '100L100', 'Benedict', 'Levski 29', 'Buzludja', '1010', NULL),
(2, '2030LC', 'Lena Headey', '22 Zapad', 'Buzludja', '211', NULL),
(3, '4020DS', 'Emilia Clarke', 'Iztok 29', 'Buzludja', '36500', NULL)

INSERT INTO RentalOrders
VALUES (1, 2, 3, 1, 'Good', 20, 100, 120, 200, '2015-03-03', '2015-04-04', 200, 100.20, 200.20, 0, NULL),
(2, 2, 1, 3, 'Perfect', 10, 200, 200, 170, '2015-05-03', '2015-04-12', 23, 34.20, 56.20, 0, NULL),
(3, 3, 2, 2, 'Schlimm', 20, 210, 218, 144, '2015-03-05', '2015-12-04', 32, 43.20, 65.20, 1, NULL)

	--> 15.
CREATE TABLE Employees(
 Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
 FirstName varchar(50) NOT NULL,
 LastName varchar(50) NOT NULL,
 Title varchar(50) NOT NULL,
 Notes varchar(MAX)
)

CREATE TABLE Customers(
 AccountNumber int PRIMARY KEY NOT NULL,
 FirstName varchar(50) NOT NULL,
 LastName varchar(50) NOT NULL,
 PhoneNumber varchar(50) NOT NULL,
 EmergencyName varchar(50) NOT NULL,
 EmergencyNumber int NOT NULL,
 Notes varchar(MAX)
)

CREATE TABLE RoomStatus(	
	RoomStatus varchar(50) primary key NOT NULL,
	Notes varchar(MAX) 
)

CREATE TABLE RoomTypes(
	RoomType varchar(50) primary key NOT NULL,
	Notes varchar(MAX)
)

CREATE TABLE BedTypes(
	BedType varchar(50) primary key NOT NULL,
	Notes varchar(MAX)
)

CREATE TABLE Rooms(
  RoomNumber int primary key NOT NULL,
  RoomType varchar(50) FOREIGN KEY REFERENCES RoomTypes(RoomType) NOT NULL,
  BedType varchar(50) FOREIGN KEY REFERENCES BedTypes(BedType) NOT NULL,
  Rate float NOT NULL,
  RoomStatus varchar(50) FOREIGN KEY REFERENCES RoomStatus(RoomStatus) NOT NULL,
)

CREATE TABLE Payments(
  Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
  EmployeeId int FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
  PaymentDate date NOT NULL,
  AccountNumber int FOREIGN KEY REFERENCES Customers(AccountNumber) NOT NULL,
  FirstDateOccupied date NOT NULL,
  LastDateOccupied date NOT NULL,
  TotalDays int NOT NULL,
  AmountCharged money NOT NULL,
  TaxRate float NOT NULL,
  TaxAmount money NOT NULL,
  PaymentTotal money NOT NULL,
  Notes varchar(MAX)
)

CREATE TABLE Occupancies(
  Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
  EmployeeId int FOREIGN KEY REFERENCES Employees(Id) NOT NULL,
  DateOccupied date NOT NULL,
  AccountNumber int FOREIGN KEY REFERENCES Customers(AccountNumber) NOT NULL,
  RoomNumber int FOREIGN KEY REFERENCES Rooms(RoomNumber) NOT NULL,
  RateApplied float,
  PhoneCharge money,
  Notes varchar(MAX)
)

INSERT INTO Employees
Values('Ancho','Ivanov','CEO','nema'),
('Ancho2','Ivanov','CEO','nema'),
('Ancho3','Ivanov','CEO','nema')

INSERT INTO Customers
VALUES(1,'asd','bb','+424','555',55,'nema'),
(2,'asd','bb','+424','555',55,'nema'),
(3,'asd','bb','+424','555',55,'nema')

Insert Into RoomStatus
VALUES('u1','note'),
('u2','note'),
('u3','note')

Insert Into RoomTypes
VALUES('t1','note'),
('t2','note'),
('t3','note')

Insert Into BedTypes
VALUES('b1','note'),
('b2','note'),
('b3','note')

Insert Into Rooms
VALUES(1,'t1','b1',50,'u1'),
(2,'t2','b2',50,'u2'),
(3,'t3','b3',50,'u3')

Insert Into Payments
VALUES(1,'1990-10-10',1,'1929-10-10','1992-10-10',30,50,15,44,99,'notes'),
(2,'1990-10-10',2,'1929-10-10','1992-10-10',30,50,15,44,99,'notes'),
(3,'1990-10-10',3,'1929-10-10','1992-10-10',30,50,15,44,99,'notes')

INSERT INTO Occupancies
VALUES(1,'1990-10-10',1,1,10,44,'note'),
(2,'1990-10-10',2,2,10,44,'note'),
(3,'1990-10-10',3,3,10,44,'note')

	--> 19.
SELECT * FROM Towns

SELECT * FROM Departments

SELECT * FROM Employees

	--> 20.
SELECT * FROM Towns ORDER BY Name ASC

SELECT * FROM Departments ORDER BY Name ASC

SELECT * FROM Employees ORDER BY Salary DESC

	--> 21.
SELECT Name FROM Towns ORDER BY Name ASC;

SELECT Name FROM Departments ORDER BY Name ASC;

SELECT FirstName, LastName, JobTitle, Salary FROM Employees ORDER BY Salary DESC;

	--> 22.
UPDATE Employees
SET Salary *= 1.1

SELECT Salary
FROM Employees

	--> 23.
UPDATE Payments
SET TaxRate = TaxRate - (0.03 * TaxRate)

SELECT TaxRate
FROM Payments

	--> 24.
TRUNCATE TABLE Occupancies