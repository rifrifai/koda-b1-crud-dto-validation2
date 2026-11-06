-- SELECT name FROM sys.databases;

-- CREATE DATABASE ecommercedb;
-- SELECT DB_NAME() AS CurrentDatabase;
-- CREATE TABLE dbo.Product(
--     ProductId INT IDENTITY(1,1) PRIMARY KEY,
--     ProductCode NVARCHAR(20) NOT NULL UNIQUE,
--     Name NVARCHAR(100) NOT NULL,
--     Price DECIMAL(18,2) NOT NULL,
--     Stock INT NOT NULL DEFAULT 0,
--     Category NVARCHAR(50) NOT NULL,
--     IsActive BIT NOT NULL DEFAULT 1,

--     CONSTRAINT CK_Products_Price CHECK(Price >= 0),
--     CONSTRAINT CK_Products_Stock CHECK(Stock >= 0),
-- );
-- GO

-- INSERT INTO dbo.Product(ProductCode, Name, Price, Stock, Category)VALUES
-- ('PR01', 'Keyboard', 25000, 3, 'Elektronik'),
-- ('PR02', 'Mouse', 50000, 4, 'Elektronik');
-- INSERT INTO dbo.Product(ProductCode, Name, Price, Stock, Category) VALUES
-- ('PR03', 'Monitor LED 24 Inch', 1750000, 8, 'Elektronik'),
-- ('PR04', 'Headset Gaming', 350000, 12, 'Elektronik'),
-- ('PR05', 'Meja Kerja Minimalis', 850000, 5, 'Furnitur'),
-- ('PR06', 'Kursi Ergonomis', 1200000, 7, 'Furnitur'),
-- ('PR07', 'Lampu Meja LED', 950000, 25, 'Furnitur'),
-- ('PR08', 'Kabel HDMI 2 Meter', 45000, 50, 'Aksesoris'),
-- ('PR09', 'Mousepad Deskmat', 85000, 30, 'Aksesoris'),
-- ('PR10', 'Flashdisk 64GB', 120000, 40, 'Elektronik'),
-- ('PR011', 'Keyboard Mechanical', 450000, 15, 'Elektronik'),
-- ('PR012', 'Mouse Wireless', 150000, 20, 'Elektronik');

-- SELECT * FROM dbo.Product;
-- GO

-- CREATE TABLE dbo.Customer(
--     CustomerId INT IDENTITY(1,1) PRIMARY KEY,
--     Name NVARCHAR(100) NOT NULL,
--     Email NVARCHAR(75) UNIQUE,
--     Phone NVARCHAR(13) NOT NULL,
--     Address NVARCHAR(200) NOT NULL,
-- );

-- ALTER TABLE dbo.Product ADD CustomerId INT;
-- ALTER TABLE dbo.Product ADD CONSTRAINT FK_Product_Customer FOREIGN KEY(CustomerId) REFERENCES Customer(CustomerId);

-- INSERT INTO dbo.Customer(Name, Email, Phone, Address)VALUES
-- ('Budi', 'budi@mail.com', 6287668899, 'jl. pangeran diponegoro demak jawa tengah'),
-- ('Alvin', 'alvin@mail.com', 6287663465, 'jl. pangeran alvin cibubur bogor'),
-- ('Bando', 'bando@mail.com', 62876623465, 'jl. pangeran bando depok jawa barat'),
-- ('Rizal', 'rizal@mail.com', 6287663333, 'jl. sultan rizal maluku utara'),
-- ('Afif', 'afif@mail.com', 62876630098, 'jl. tuan afif padang sumatera barat'),
-- ('Chandra', 'chandra@mail.com', 628766344556, 'jl. sipalang andara tangerang selatan');


SELECT * FROM dbo.Product;
-- SELECT * FROM dbo.Customer;

-- SELECT c.CustomerId, c.Name, c.Email, p.ProductId, p.Name FROM Customer c FULL JOIN Product p ON c.CustomerId = p.CustomerId;
-- UPDATE Product SET CustomerId = 1 WHERE ProductId IN (2, 3, 4);
-- UPDATE Product SET CustomerId = 2 WHERE ProductId IN (5, 6);
-- UPDATE Product SET CustomerId = 6 WHERE ProductId IN (10, 11);

GO