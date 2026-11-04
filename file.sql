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
GO

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

SELECT * FROM dbo.Product;
GO