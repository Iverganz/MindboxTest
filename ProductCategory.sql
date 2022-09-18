SELECT pr.Name as product, 
	cat.Name as category
FROM Product pr
LEFT JOIN ProductCategory pc
	ON pc.ProductId = pr.Id
LEFT JOIN Category cat
	ON pc.CategoryId = cat.Id