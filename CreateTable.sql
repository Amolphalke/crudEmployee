
  IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME = 'Employees')
BEGIN
    CREATE TABLE [dbo].[Employees]
    (
        [id] INT PRIMARY KEY,
        [name] NVARCHAR(100),
        [address] NVARCHAR(255),
        [dob] DATE
    );
END