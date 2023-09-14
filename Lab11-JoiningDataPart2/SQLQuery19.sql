CREATE TABLE JoiningDataLab2
(CustomerID int PRIMARY KEY IDENTITY (1,1), CustomerName varchar(MAX),Item varchar(MAX), Price int, Quantity int)

INSERT INTO JoiningDataLab2
(CustomerName, Item, Price, Quantity)
VALUES('Acme Hardware', 'Mouse', 25, 3)

INSERT INTO JoiningDataLab2
(CustomerName, Item, Price, Quantity)
VALUES('Acme Hardware', 'Keyboard', 45, 2)

INSERT INTO JoiningDataLab2
(CustomerName, Item, Price, Quantity)
VALUES('Falls Realty', 'Macbook', 800, 2)

INSERT INTO JoiningDataLab2
(CustomerName)
VALUES('Joe''s Chicago Pizza')

INSERT INTO JoiningDataLab2
(CustomerName, Item, Price, Quantity)
VALUES('Julie''s Morning Diner', 'iPad', 525, 1)

INSERT INTO JoiningDataLab2
(CustomerName, Item, Price, Quantity)
VALUES('Julie''s Morning Diner', 'Credit Card Reader', 45, 1)


SELECT CustomerName, Item, Price, Quantity, Price * Quantity AS Total
FROM JoiningDataLab2
WHERE CustomerName = 'Acme Hardware' OR CustomerName = 'Falls Realty' OR CustomerName = 'Joe''s Chicago Pizza' OR CustomerName = 'Julie''s Morning Diner'


SELECT
    CustomerID,
    CustomerName,
    Price,
    Quantity,
    (Price * Quantity) AS Total,
    SUM(Price * Quantity) OVER (PARTITION BY CustomerName) AS TotalSum
FROM
    JoiningDataLab2
GROUP BY
    CustomerID, CustomerName, Price, Quantity
