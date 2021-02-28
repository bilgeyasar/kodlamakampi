--select
--ANSII
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

select*from Customers where City='London'
--case insensitive
select*from Products where CategoryID=1 or CategoryID=3
select*from Products where CategoryID=1 and UnitPrice>=10
select*from Products ORDER BY ProductName
select*from Products where CategoryID=1 ORDER BY UnitPrice desc
select count(*) Sayi from Products where CategoryID=2

select CategoryID,count(*) as Sayi from Products
where UnitPrice>20 Group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products INNER JOIN Categories 
ON Products.CategoryID= Categories.CategoryID
where Products.UnitPrice>10
--DTO Data Transformation Object 
--Inner join eşleşenleri getirir
--Left join solda olup sağda olmayanları da getirir
Select*from Products p LEFT JOIN [Order Details] od
ON p.ProductID=od.ProductID
INNER JOIN Orders o ON o.OrderID= od.OrderID

select*from Customers c LEFT JOIN Orders o
ON C.CustomerID=O.CustomerID
WHERe o.CustomerID IS NULL



