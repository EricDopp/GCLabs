--SQL With Northwind Lab
--1
SELECT *
FROM Customers

--2
SELECT Country
FROM Customers

--3
SELECT *
FROM Customers
WHERE CustomerID LIKE 'BL%'

--4 (Maybe you'd want the first 100 to get a brief snapshot or more recency of data rather than the whole thing
-- you could then query it further to get more precise data of these top 100 entries)
SELECT TOP 100 *
FROM Orders

--5
SELECT *
FROM Customers
WHERE PostalCode = '1010' OR PostalCode = '3012' OR PostalCode = '12209' OR PostalCode = '05023'

--6
SELECT *
FROM Orders
WHERE ShipRegion IS NOT NULL

--7
SELECT *
FROM Customers
ORDER BY Country, City

--8
INSERT INTO Customers
VALUES ('ROYAL', 'Royal Oak Coding', 'Eric Dopp', 'Aspirant', '1613 Midland blvd', 'Royal Oak', 'MI', '48073', 'USA', '248-881-0796', NULL)

--9
UPDATE Orders
SET ShipRegion = 'EuroZone'
WHERE ShipCountry = 'France'

--10
DELETE FROM [Order Details]
WHERE Quantity = 1

--11
SELECT CustomerID
FROM Orders
WHERE OrderID = '10290'

--12
SELECT *
FROM Orders o
JOIN Customers c ON c.CustomerID=o.CustomerID

--13
SELECT FirstName
FROM Employees
WHERE ReportsTo IS NULL

--14
SELECT FirstName
FROM Employees
WHERE ReportsTo = 2

--Extra Challenges:
--1
SELECT AVG(Quantity) AS Avg_Quantity, MAX(Quantity) AS Max_Quantity, MIN(Quantity) AS Min_Quantity
FROM [Order Details]
GROUP BY OrderID

--2
SELECT AVG(Quantity) AS Avg_Quantity, MAX(Quantity) AS Max_Quantity, MIN(Quantity) AS Min_Quantity
FROM [Order Details]

--3
SELECT *
FROM Customers
WHERE City = 'London' OR City = 'Paris'

--4
SELECT *
FROM Orders o
INNER JOIN Customers c ON c.CustomerID=o.CustomerID
LEFT JOIN Customers d ON d.CustomerID=o.CustomerID
RIGHT JOIN Customers e ON e.CustomerID=o.CustomerID

--5
SELECT DISTINCT City
FROM Customers

--6
SELECT FirstName
FROM Employees
ORDER BY FirstName ASC

--7
SELECT ((UnitPrice * Quantity) * (1 - Discount)) AS Total
FROM [Order Details]

--8
SELECT *
FROM Employees
WHERE HireDate > '1994-01-01'

--9
SELECT DATEDIFF(YEAR, HireDate, GETDATE()) AS Years_Employed
FROM Employees

--10
SELECT *
FROM Products p
JOIN [Order Details] o ON o.ProductID=p.ProductID
ORDER BY Quantity ASC

SELECT *
FROM Products p
JOIN [Order Details] o ON o.ProductID=p.ProductID
ORDER BY Quantity DESC

--11
SELECT *
FROM Products
WHERE UnitsInStock < 6

--12
SELECT *
FROM Products
WHERE Discontinued = 1

--13
SELECT *
FROM Products
WHERE ProductName LIKE '%TOFU%'

--14
SELECT TOP 1 WITH TIES *
FROM Products
ORDER BY UnitPrice DESC

--15
SELECT *
FROM Employees
WHERE HireDate > '1993-01-01'

--16
SELECT *
FROM Employees
WHERE TitleOfCourtesy = 'Ms.' OR TitleOfCourtesy = 'Mrs.'

--17
SELECT *
FROM Employees
WHERE HomePhone LIKE '%(206)%'