USE TA
GO
-------------------- Процедура добавления нового заказа в таблицу заказов и связанные таблицы  ----------------------
--  получает имена континента, страны и города  
--  проверяет наличие в базе как континента, так и страны и если нет хотя бы одного
--  добавляет их в соответствующие таблицы БД, относя страну к континенту
--  После этого в таблицу городов добавляется новый тсо сссылкой на страну
--  Возвращает датасет из единственной записи, содержащей id всех трех сущностей
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
    BEGIN  -- Указанного типа оборудования нет в таблице континента
      INSERT INTO EquipmentType (EqTypeName) VALUES (@EqTypeName) -- Добавление нового Типа Изделия
--    SET @ContinentId = (SELECT SCOPE_IDENTITY())  -- Получение ID только что добавленного континента
      SET @EqTypeID = (SELECT @@IDENTITY)  -- Получение ID только что добавленного континента
    END
  INSERT INTO Equipments (EqTypeID, Country, Company, Age) VALUES (@EqTypeID, @Country, @Company, @Age) 
  SET @EquipmentID = (SELECT @@IDENTITY)
  SET @MasterID = (SELECT MasterID FROM Masters WHERE MasterFio = @MasterFio)
  IF @MasterID IS NULL
    BEGIN  -- Мастер не нйден
      -- Добавление нового Мастера в континенте
      INSERT INTO Masters(MasterFio) VALUES (@MasterFio) 
--    SET @MasterID = (SELECT SCOPE_IDENTITY())  -- Получение ID только что добавленной страны
      SET @MasterID = (SELECT @@IDENTITY)  -- Получение ID только что добавленной страны
    END;
	SET @CustomerID = (SELECT CustomerID FROM Customers WHERE CustomerFio = @CustomerFio)
    IF @CustomerID IS NULL
		BEGIN  -- Мастер не найден
		  -- Добавление нового Мастера в континенте
		  INSERT INTO Customers(CustomerFio) VALUES (@CustomerFio) 
	--    SET @MasterID = (SELECT SCOPE_IDENTITY())  -- Получение ID только что добавленной страны
		  SET @CustomerID = (SELECT @@IDENTITY)  -- Получение ID только что добавленной страны
		END;
  -- Добавление нового ордера
  INSERT INTO Orders (IzdelieID, CustomerID, MasterID, DateStart, Comment)
		VALUES (@EquipmentID, @CustomerID, @MasterID, GETDATE(), @Comment)
--  SET @OrderId = (SELECT SCOPE_IDENTITY())  -- Получение ID только что добавленного заказа
  SET @OrderID = (SELECT @@IDENTITY)  -- Получение ID только что добавленного заказа
  -- Вернуть строку с результатами
  SELECT @OrderId AS OrderID
END
GO