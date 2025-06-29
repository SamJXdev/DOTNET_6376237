CREATE INDEX idx_OrderDate ON Orders(OrderDate);
EXPLAIN SELECT * FROM Orders WHERE OrderDate = '2023-01-15';

