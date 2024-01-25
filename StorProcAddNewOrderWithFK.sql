USE TA
GO
-------------------- ��������� ���������� ������ ������ � ������� ������� � ��������� �������  ----------------------
--  �������� ����� ����������, ������ � ������  
--  ��������� ������� � ���� ��� ����������, ��� � ������ � ���� ��� ���� �� ������
--  ��������� �� � ��������������� ������� ��, ������ ������ � ����������
--  ����� ����� � ������� ������� ����������� ����� ��� �������� �� ������
--  ���������� ������� �� ������������ ������, ���������� id ���� ���� ���������
CREATE PROCEDURE UsP_AddNewOrder 
  @EqTypeName VARCHAR(50),
  @MasterFio VARCHAR(50),
  @CustomerFio VARCHAR(50),
  @Country VARCHAR(50),
  @Company VARCHAR(50),
  @Age int,
  @Comment VARCHAR(MAX)
AS
BEGIN
  DECLARE @OrderID INT
  DECLARE @EqTypeID INT
  DECLARE @MasterID INT
  DECLARE @CustomerID INT
  DECLARE @EquipmentID INT
  SET @EqTypeID = (SELECT EqTypeID FROM EquipmentType WHERE EqTypeName = @EqTypeName)
  IF @EqTypeID IS NULL
    BEGIN  -- ���������� ���� ������������ ��� � ������� ����������
      INSERT INTO EquipmentType (EqTypeName) VALUES (@EqTypeName) -- ���������� ������ ���� �������
--    SET @ContinentId = (SELECT SCOPE_IDENTITY())  -- ��������� ID ������ ��� ������������ ����������
      SET @EqTypeID = (SELECT @@IDENTITY)  -- ��������� ID ������ ��� ������������ ����������
    END
  INSERT INTO Equipments (EqTypeID, Country, Company, Age) VALUES (@EqTypeID, @Country, @Company, @Age) 
  SET @EquipmentID = (SELECT @@IDENTITY)
  SET @MasterID = (SELECT MasterID FROM Masters WHERE MasterFio = @MasterFio)
  IF @MasterID IS NULL
    BEGIN  -- ������ �� �����
      -- ���������� ������ ������� � ����������
      INSERT INTO Masters(MasterFio) VALUES (@MasterFio) 
--    SET @MasterID = (SELECT SCOPE_IDENTITY())  -- ��������� ID ������ ��� ����������� ������
      SET @MasterID = (SELECT @@IDENTITY)  -- ��������� ID ������ ��� ����������� ������
    END;
	SET @CustomerID = (SELECT CustomerID FROM Customers WHERE CustomerFio = @CustomerFio)
    IF @CustomerID IS NULL
		BEGIN  -- ������ �� ������
		  -- ���������� ������ ������� � ����������
		  INSERT INTO Customers(CustomerFio) VALUES (@CustomerFio) 
	--    SET @MasterID = (SELECT SCOPE_IDENTITY())  -- ��������� ID ������ ��� ����������� ������
		  SET @CustomerID = (SELECT @@IDENTITY)  -- ��������� ID ������ ��� ����������� ������
		END;
  -- ���������� ������ ������
  INSERT INTO Orders (IzdelieID, CustomerID, MasterID, DateStart, Comment)
		VALUES (@EquipmentID, @CustomerID, @MasterID, GETDATE(), @Comment)
--  SET @OrderId = (SELECT SCOPE_IDENTITY())  -- ��������� ID ������ ��� ������������ ������
  SET @OrderID = (SELECT @@IDENTITY)  -- ��������� ID ������ ��� ������������ ������
  -- ������� ������ � ������������
  SELECT @OrderId AS OrderID
END
GO