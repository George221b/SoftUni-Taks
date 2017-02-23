-- CREATE DATABASE Bakery
-- USE Bakery

	--> Section 1. DDL
CREATE TABLE Products (
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(25) UNIQUE,
Description NVARCHAR(250),
Recipe NVARCHAR(MAX),
Price MONEY CHECK(Price >= 0)
)

CREATE TABLE Countries (
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(50) UNIQUE
)

CREATE TABLE Distributors (
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(25) UNIQUE,
AddressText NVARCHAR(30),
Summary NVARCHAR(200),
CountryId INT,
CONSTRAINT FK_Distributors_Country FOREIGN KEY(CountryId)
REFERENCES Countries(Id)
)

CREATE TABLE Ingredients (
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(30),
Description NVARCHAR(200),
OriginCountryId INT,
DistributorId INT,
CONSTRAINT FK_Ingredients_Country FOREIGN KEY(OriginCountryId)
REFERENCES Countries(Id),
CONSTRAINT FK_Ingredients_Distributors FOREIGN KEY(DistributorId)
REFERENCES Distributors(Id)
)

CREATE TABLE ProductsIngredients (
ProductId INT NOT NULL,
IngredientId INT NOT NULL,
CONSTRAINT PK_ProductsIngredients PRIMARY KEY(ProductId, IngredientId),
CONSTRAINT FK_ProductsIngredients_Products FOREIGN KEY(ProductId)
REFERENCES Products(Id),
CONSTRAINT FK_ProductsIngredients_Ingredients FOREIGN KEY(IngredientId)
REFERENCES Ingredients(Id)
)

CREATE TABLE Customers (
Id INT PRIMARY KEY IDENTITY,
FirstName NVARCHAR(25),
LastName NVARCHAR(25),
Gender CHAR(1) CHECK(Gender IN ('M', 'F')),
Age INT,
PhoneNumber CHAR(10) CHECK(LEN(PhoneNumber) = 10),
CountryId INT,
CONSTRAINT FK_Customers_Country FOREIGN KEY(CountryId)
REFERENCES Countries(Id)
)

CREATE TABLE Feedbacks (
Id INT PRIMARY KEY IDENTITY,
Description NVARCHAR(255),
Rate DECIMAL(8, 2) CHECK(Rate BETWEEN 0 AND 10),
ProductId INT,
CustomerId INT,
CONSTRAINT FK_Feedbacks_Products FOREIGN KEY(ProductId)
REFERENCES Products(Id),
CONSTRAINT FK_Feedbacks_Customers FOREIGN KEY(CustomerId)
REFERENCES Customers(Id)
)

	--> Section 2. DML
	--> 2. Insert
BEGIN TRANSACTION

INSERT INTO Distributors (Name, CountryId, AddressText, Summary)
VALUES
('Deloitte & Touche', 2,	'6 Arch St #9757',	'Customizable neutral traveling'),
('Congress Title',	13,	'58 Hancock St',	'Customer loyalty'),
('Kitchen People',	1,	'3 E 31st St #77',	'Triple-buffered stable delivery'),
('General Color Co Inc',	21,	'6185 Bohn St #72',	'Focus group'),
('Beck Corporation',	23,	'21 E 64th Ave',	'Quality-focused 4th generation hardware')

INSERT INTO Customers (FirstName, LastName,	Age, Gender, PhoneNumber, CountryId)
VALUES
('Francoise',	'Rautenstrauch',	15,	'M',	'0195698399',	5),
('Kendra',	'Loud',	22,	'F',	'0063631526',	11),
('Lourdes',	'Bauswell',	50,	'M',	'0139037043',	8),
('Hannah',	'Edmison', 18,	'F',	'0043343686',	1),
('Tom',	'Loeza',	31,	'M',	'0144876096',	23),
('Queenie',	'Kramarczyk',	30,	'F',	'0064215793',	29),
('Hiu',	'Portaro',	25,	'M',	'0068277755',	16),
('Josefa',	'Opitz',	43,	'F',	'0197887645',	17)



ROLLBACK

	--> 03. Update
BEGIN TRANSACTION

 UPDATE Ingredients
    SET DistributorId = 35
  WHERE Id IN (
				SELECT I.Id FROM Ingredients AS i
                 INNER JOIN Distributors AS d
                    ON d.Id = i.DistributorId
                 WHERE i.Name IN ('Bay Leaf', 'Paprika', 'Poppy')	
			  )

UPDATE Ingredients
   SET OriginCountryId = 14
 WHERE OriginCountryId = 8

ROLLBACK
	--> 04. DELETE
BEGIN TRANSACTION

DELETE FROM Feedbacks
 WHERE CustomerId = 14

DELETE FROM Feedbacks
 WHERE ProductId = 5

ROLLBACK
SELECT COUNT(*) FROM Feedbacks
	--> Section 3. Querying 
	--> 5.
SELECT p.Name, p.Price, p.Description
  FROM Products AS p
 ORDER BY p.Price DESC,
          P.Name ASC

	--> 6.
SELECT i.Name, i.Description, i.OriginCountryId
  FROM Ingredients AS i
 WHERE i.OriginCountryId IN (1, 10, 20)
 ORDER BY i.Id ASC

	--> 7.
SELECT TOP(15) i.Name, i.Description, c.Name
  FROM Ingredients AS i
 INNER JOIN Countries AS c
    ON c.Id = i.OriginCountryId
 WHERE c.Name IN ('Bulgaria', 'Greece')
 ORDER BY i.Name, c.Name

	--> 8.
SELECT TOP(10) p.Name, p.Description,
       AVG(f.Rate) AS AverageRate,
	   COUNT(f.ProductId) AS FeedbacksAmount
  FROM Products as p
 INNER JOIN Feedbacks AS f
    ON f.ProductId = p.Id
 GROUP BY p.Name, p.Description
 ORDER BY AVG(f.Rate) DESC, COUNT(f.ProductId) DESC

	--> 9.
SELECT f.ProductId, f.Rate, f.Description, f.CustomerId, c.Age, c.Gender
  FROM Feedbacks AS f
  LEFT JOIN Customers AS c
    ON f.CustomerId = c.Id
 WHERE f.Rate < 5.00
 ORDER BY f.ProductId DESC, f.Rate ASC

	--> 10.
 SELECT
        CONCAT(c.FirstName, ' ', c.LastName) AS CustomerName,
        c.PhoneNumber,
		c.Gender
  FROM Feedbacks AS f
  right JOIN Customers AS c
    ON f.CustomerId = c.Id
 WHERE f.CustomerId IS null
 ORDER BY f.CustomerId ASC

	--> 11.
SELECT f.ProductId,
       CONCAT(c.FirstName, ' ', c.LastName) AS CustomerName,
	   f.Description
  FROM Feedbacks AS f
  LEFT JOIN Customers AS c
    ON f.CustomerId = c.Id
 WHERE f.CustomerId IN 
 (
					 SELECT f.CustomerId 
					  FROM Feedbacks AS f
					  LEFT JOIN Customers AS c
					    ON f.CustomerId = c.Id
					 GROUP BY f.CustomerId
					 HAVING COUNT(f.CustomerId) >= 3
 )
 ORDER BY f.ProductId ASC,
          CONCAT(c.FirstName, ' ', c.LastName) ASC,
          f.Id ASC

SELECT f.CustomerId 
  FROM Feedbacks AS f
  LEFT JOIN Customers AS c
    ON f.CustomerId = c.Id
 GROUP BY f.CustomerId
 HAVING COUNT(f.CustomerId) >= 3

	--> 12.
SELECT c.FirstName, c.Age, c.PhoneNumber
  FROM Customers AS c
 WHERE (c.Age >= 21 AND c.FirstName LIKE '%an%')
       OR (c.PhoneNumber LIKE '%38' AND c.CountryId != 31)
 ORDER BY c.FirstName ASC, c.Age DESC

SELECT * FROM Countries

	--> 13.
SELECT d.Name AS DistributorName,
       i.Name AS IngredientName,
	   p.Name AS ProductName,
	   AverageRate.AvgRate AS AverageRate
  FROM Distributors AS d
  INNER JOIN Ingredients AS i
    ON i.DistributorId = d.Id
  INNER JOIN ProductsIngredients AS pri
    ON pri.IngredientId = i.Id
  INNER JOIN Products AS p
    ON p.Id = pri.ProductId
  INNER JOIN Feedbacks AS f
    ON f.ProductId = p.Id
 INNER JOIN
 (
  	  SELECT f.ProductId, AVG(f.Rate) AS AvgRate
	   FROM Feedbacks AS f
	  GROUP BY f.ProductId
	 HAVING AVG(f.Rate) between 5 and 8 
 ) AS AverageRate
 ON AverageRate.ProductId = p.Id
 WHERE p.Id IN
 (
	  SELECT f.ProductId
	   FROM Feedbacks AS f
	  GROUP BY f.ProductId
	 HAVING AVG(f.Rate) between 5 and 8 
 )
 GROUP BY d.Name,
       i.Name,
	   p.Name,
	   AverageRate.AvgRate
 ORDER BY d.Name, i.Name, p.Name

 SELECT f.ProductId
   FROM Feedbacks AS f
  GROUP BY f.ProductId
 HAVING AVG(f.Rate) between 5 and 8 

	--> 14.
SELECT TOP(1) WITH TIES co.Name, AVG(f.Rate) AS FeedbackRate
  FROM Feedbacks AS f
 INNER JOIN Customers AS c
    ON c.Id = f.CustomerId
 INNER JOIN Countries AS co
    ON co.Id = c.CountryId
 GROUP BY co.Name
 ORDER BY AVG(f.Rate) DESC

	--> 15.
SELECT Result.CountryName, Result.DisributorName
  FROM
(
SELECT co.Name AS CountryName, d.Name AS DisributorName, COUNT(i.DistributorId) AS IngredientsCount,
	   DENSE_RANK() OVER (PARTITION BY co.Name ORDER BY COUNT(i.DistributorId) DESC) AS RANK
  FROM Countries AS co
  LEFT JOIN Distributors AS d
    ON d.CountryId = co.Id
  LEFT JOIN Ingredients AS i
    ON i.DistributorId = d.Id
 GROUP BY co.Name, d.Name
) AS Result
 WHERE Result.RANK = 1
 ORDER BY Result.CountryName, Result.DisributorName

	--> 16.
CREATE VIEW v_UserWithCountries
AS
SELECT CONCAT(c.FirstName, ' ', c.LastName) AS CustomerName,
       c.Age,
	   c.Gender,
	   co.Name
  FROM Customers AS c
  LEFT JOIN Countries AS co
    ON co.Id = c.CountryId

	--> 17.
GO
CREATE FUNCTION udf_GetRating (@Name NVARCHAR(25))
RETURNS NVARCHAR(10)
AS
BEGIN
	DECLARE @result NVARCHAR(10)

	IF ( @Name IN (
	SELECT p.Name
	  FROM Products AS p
	 LEFT JOIN Feedbacks AS f
	    ON f.ProductId = p.Id
	 WHERE f.ProductId IS null
	 ))
	BEGIN
		SET @result = 'No rating'
		RETURN @result
	END

DECLARE @averageRate DECIMAL = (
SELECT AvgName.AvgRate
  FROM Products AS p
 INNER JOIN
			(
			SELECT f.ProductId, AVG(f.Rate) AS AvgRate
			  FROM Feedbacks AS f
			 GROUP BY f.ProductId
			) AS AvgName
    ON AvgName.ProductId = p.Id
 WHERE p.Name = @Name
 )
IF (@averageRate < 5)
BEGIN
	SET @result = 'Bad'
	RETURN @result
END
ELSE IF (@averageRate BETWEEN 5 AND 8)
BEGIN
	SET @result = 'Average'
	RETURN @result
END

SET @result = 'Good'
RETURN @result

END

SELECT TOP 5 Id, Name, dbo.udf_GetRating(Name)
  FROM Products
 ORDER BY Id


	--> 18.
GO

CREATE PROC usp_SendFeedback (@CustomerId INT, @ProductId INT, @rate DECIMAL(8, 2), @description NVARCHAR(255))
AS
BEGIN

	 BEGIN TRANSACTION

	 INSERT INTO Feedbacks (CustomerId, ProductId, Rate, Description)
	 VALUES (@CustomerId, @ProductId, @rate, @description)

	 DECLARE @prodcutsCount INT = (
							 	SELECT COUNT(f.ProductId) AS ProductsPerCustomer
							      FROM Feedbacks AS f
							     GROUP BY f.CustomerId
							    HAVING f.CustomerId = @CustomerId
							      )
	IF (@prodcutsCount > 3)
	BEGIN
		RAISERROR('You are limited to only 3 feedbacks per product!', 16, 1)
		ROLLBACK
		RETURN
	END

	COMMIT
END

	--> 19.
GO
CREATE TRIGGER T_Prodcuts_Instead_Of_Delete ON Products INSTEAD OF DELETE
AS
BEGIN
	DELETE FROM Feedbacks
	 WHERE Feedbacks.ProductId IN (
										SELECT deleted.Id
									 FROM deleted
									INNER JOIN Products AS p
									   ON p.Id = deleted.Id
								  )

	DELETE FROM ProductsIngredients
	 WHERE ProductsIngredients.ProductId IN (
										SELECT deleted.Id
									 FROM deleted
									INNER JOIN Products AS p
									   ON p.Id = deleted.Id
								  )

	DELETE FROM Products
	 WHERE Products.Id IN (
										SELECT deleted.Id
									 FROM deleted
									INNER JOIN Products AS p
									   ON p.Id = deleted.Id
								  )
END

BEGIN TRANSACTION
DELETE FROM Products WHERE Id = 7
ROLLBACK

	--> 20.

