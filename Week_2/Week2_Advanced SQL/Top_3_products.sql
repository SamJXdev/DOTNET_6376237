WITH Ranked AS (
    SELECT 
        ProductID, 
        ProductName, 
        Category, 
        Price,
        ROW_NUMBER() OVER(PARTITION BY Category ORDER BY Price DESC) AS RowNum
    FROM Products
)
SELECT * 
FROM Ranked
WHERE RowNum <= 3;
