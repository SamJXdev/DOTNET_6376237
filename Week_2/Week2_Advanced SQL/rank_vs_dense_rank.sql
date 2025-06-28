SELECT 
    ProductID, 
    ProductName, 
    Category, 
    Price,
    RANK() OVER(PARTITION BY Category ORDER BY Price DESC) AS RankPos,
    DENSE_RANK() OVER(PARTITION BY Category ORDER BY Price DESC) AS DenseRankPos
FROM Products;
