CREATE INDEX idx_Customer_OrderDate ON Orders(CustomerID, OrderDate);
EXPLAIN SELECT * FROM Orders WHERE CustomerID = 1 AND OrderDate = '2023-01-15';

