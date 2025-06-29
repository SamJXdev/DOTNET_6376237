CREATE INDEX idx_ProductName ON Products(ProductName);
EXPLAIN SELECT * FROM Products WHERE ProductName = 'Laptop';
