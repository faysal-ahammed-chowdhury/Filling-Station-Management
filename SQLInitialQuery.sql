DELETE FROM SaleDetails;
DELETE FROM Sales;
DELETE FROM Expenses;
DELETE FROM Inventories;
DELETE FROM Users;

-- Insert data into Users
INSERT INTO Users (UserId, Name, Phone, Password, Role) VALUES
('USER-001', 'Faysal Ahammed Chowdhury', 'admin', 'admin', 'Admin'),
('USER-002', 'Alam Pranto', 'emp', 'emp', 'Employee'),
('USER-003', 'Asef Abdullah', '01733333333', 'password789', 'Employee'),
('USER-004', 'Imran Ziad', '01744444444', 'password012', 'Admin'),
('USER-005', 'Mujahid Swadhin', '01755555555', 'password345', 'Employee'),
('USER-006', 'Israfil Diganta', '01766666666', 'password678', 'Employee'),
('USER-007', 'Rawaha Anik', '01777777777', 'password901', 'Employee'),
('USER-008', 'Faisal Amin ABir', '01788888888', 'password234', 'Employee'),
('USER-009', 'Sayed Mamun', '01799999999', 'password567', 'Admin');

-- Insert data into Inventories
INSERT INTO Inventories (InventoryId, FuelName, StockQuantity, PricePerLitre) VALUES
('INV-001', 'Petrol', 1000, 120.50),
('INV-002', 'Diesel', 800, 110.75),
('INV-003', 'CNG', 500, 50.25),
('INV-004', 'Octane', 700, 125.00),
('INV-005', 'Kerosene', 600, 90.00);

-- Insert data into Expenses
INSERT INTO Expenses (ExpenseId, Amount, Category, DateTime, Description, CreatedBy) VALUES
('EXP-001', 5000, 'Maintenance', '2025-01-20 10:00:00', 'Pump maintenance', 'USER-001'),
('EXP-002', 2000, 'Utilities', '2025-01-21 15:30:00', 'Electricity bill', 'USER-003'),
('EXP-003', 1500, 'Supplies', '2025-01-22 09:00:00', 'Office supplies', 'USER-002'),
('EXP-004', 3000, 'Repair', '2025-01-23 14:00:00', 'Pipeline repair', 'USER-004'),
('EXP-005', 4000, 'Fuel Purchase', '2025-01-24 11:00:00', 'Stock refill', 'USER-005');

-- Insert data into Sales
INSERT INTO Sales (SaleId, SaleDateTime, CreatedBy, GrandTotal, GivenAmount, Change, PaymentMethod) VALUES
('SALE-001', '2025-01-20 12:00:00', 'USER-002', 1500.50, 2000.00, 499.50, 'Cash'),
('SALE-002', '2025-01-20 16:00:00', 'USER-003', 2500.75, 3000.00, 499.25, 'Bkash'),
('SALE-003', '2025-01-21 10:30:00', 'USER-005', 750.00, 1000.00, 250.00, 'Cash'),
('SALE-004', '2025-01-22 18:00:00', 'USER-002', 3250.25, 3500.00, 249.75, 'Bkash'),
('SALE-005', '2025-01-23 08:45:00', 'USER-004', 500.50, 1000.00, 499.50, 'Cash');

-- Insert data into SaleDetails (15 records)
INSERT INTO SaleDetails (SaleDetailId, SaleId, InventoryId, PricePerLitre, Quantity, Total) VALUES
('SD-001', 'SALE-001', 'INV-001', 120.50, 10, 1205.00),
('SD-002', 'SALE-001', 'INV-002', 110.75, 3, 332.25),
('SD-003', 'SALE-002', 'INV-003', 50.25, 20, 1005.00),
('SD-004', 'SALE-002', 'INV-004', 125.00, 12, 1500.00),
('SD-005', 'SALE-002', 'INV-005', 90.00, 5, 450.00),
('SD-006', 'SALE-003', 'INV-001', 120.50, 3, 361.50),
('SD-007', 'SALE-003', 'INV-004', 125.00, 2, 250.00),
('SD-008', 'SALE-004', 'INV-002', 110.75, 15, 1661.25),
('SD-009', 'SALE-004', 'INV-003', 50.25, 25, 1256.25),
('SD-010', 'SALE-004', 'INV-005', 90.00, 3, 270.00),
('SD-011', 'SALE-005', 'INV-001', 120.50, 2, 241.00),
('SD-012', 'SALE-005', 'INV-002', 110.75, 2, 221.50),
('SD-013', 'SALE-005', 'INV-003', 50.25, 5, 251.25),
('SD-014', 'SALE-005', 'INV-005', 90.00, 3, 270.00),
('SD-015', 'SALE-001', 'INV-004', 125.00, 5, 625.00);
