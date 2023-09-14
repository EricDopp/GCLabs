CREATE TABLE JoiningDataLab1
(CustomerID int PRIMARY KEY IDENTITY (1,1), CustomerName varchar(MAX),Item varchar(MAX), Price int, Quantity int)

INSERT INTO JoiningDataLab1
(CustomerName, Item, Price, Quantity)
VALUES('Acme Hardware', 'Mouse', 25, 3)

INSERT INTO JoiningDataLab1
(CustomerName, Item, Price, Quantity)
VALUES('Acme Hardware', 'Keyboard', 45, 2)

INSERT INTO JoiningDataLab1
(CustomerName, Item, Price, Quantity)
VALUES('Falls Realty', 'Macbook', 800, 2)

INSERT INTO JoiningDataLab1
(CustomerName, Item, Price, Quantity)
VALUES('Julie''s Morning Diner', 'iPad', 525, 1)

INSERT INTO JoiningDataLab1
(CustomerName, Item, Price, Quantity)
VALUES('Julie''s Morning Diner', 'Credit Card Reader', 45, 1)

SELECT CustomerName, Item, Price, Quantity, Price * Quantity AS Total
FROM JoiningDataLab1
WHERE CustomerName = 'Acme Hardware'

SELECT CustomerName, Item, Price, Quantity, Price * Quantity AS Total
FROM JoiningDataLab1
WHERE CustomerName = 'Falls Realty'

SELECT CustomerName, Item, Price, Quantity, Price * Quantity AS Total
FROM JoiningDataLab1
WHERE CustomerName = 'Julie''s Morning Diner'