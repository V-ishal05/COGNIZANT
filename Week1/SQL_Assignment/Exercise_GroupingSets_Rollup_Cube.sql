USE CognizantDB;
GO

CREATE TABLE Customers
(
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    Region VARCHAR(50)
);
GO
INSERT INTO Customers VALUES
(1,'Rahul','East'),
(2,'Amit','West'),
(3,'Priya','North'),
(4,'Neha','South');
GO
CREATE TABLE Orders
(
    OrderID INT PRIMARY KEY,
    CustomerID INT
        FOREIGN KEY REFERENCES Customers(CustomerID),
    OrderDate DATE
);
GO
INSERT INTO Orders VALUES
(101,1,'2024-01-01'),
(102,2,'2024-01-05'),
(103,3,'2024-01-10'),
(104,4,'2024-01-12');
GO
CREATE TABLE OrderDetails
(
    OrderDetailID INT PRIMARY KEY,
    OrderID INT
        FOREIGN KEY REFERENCES Orders(OrderID),
    ProductID INT
        FOREIGN KEY REFERENCES Products(ProductID),
    Quantity INT
);
GO
INSERT INTO OrderDetails VALUES
(1,101,1,2),
(2,101,3,5),
(3,102,5,3),
(4,102,6,1),
(5,103,2,2),
(6,103,10,8),
(7,104,7,2),
(8,104,12,10);
GO
SELECT * FROM Customers;

SELECT * FROM Orders;

SELECT * FROM OrderDetails;
SELECT
    C.Region,
    P.Category,
    SUM(OD.Quantity) AS TotalQuantity
FROM Customers C
JOIN Orders O
    ON C.CustomerID = O.CustomerID
JOIN OrderDetails OD
    ON O.OrderID = OD.OrderID
JOIN Products P
    ON OD.ProductID = P.ProductID
GROUP BY GROUPING SETS
(
    (C.Region, P.Category),
    (C.Region),
    (P.Category)
);
SELECT
    C.Region,
    P.Category,
    SUM(OD.Quantity) AS TotalQuantity
FROM Customers C
JOIN Orders O
    ON C.CustomerID = O.CustomerID
JOIN OrderDetails OD
    ON O.OrderID = OD.OrderID
JOIN Products P
    ON OD.ProductID = P.ProductID
GROUP BY ROLLUP
(
    C.Region,
    P.Category
);
