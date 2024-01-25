USE TA
 
BEGIN TRANSACTION
  -- Таблицы до вставки
  SELECT * FROM Masters
  SELECT * FROM Equipments
  SELECT * FROM EquipmentType
  SELECT * FROM Orders
  -- Вставка новых городов, стран, континентов
  EXEC dbo.UsP_AddNewOrder 'Принтер','Ульянов В.И.','Горбунова Сафия Максимовна','Россия','Oki',6,'Сломался'
  EXEC dbo.UsP_AddNewOrder 'МФУ','Лукашин С.Ю.','Черкасов Георгий Семёнович','Китай','Vivo',6,'Сломался'
  EXEC dbo.UsP_AddNewOrder 'Смартфон','Ульянов В.И.','Горбунова Сафия Максимовна','США','iPhome 15X',1,'Сломался'
  EXEC dbo.UsP_AddNewOrder 'Авторегистратор','Иванов И.И.','Петров','Россия','GlobeSign',2,'Сломался'
  -- Таблицы после вставки
  SELECT * FROM Masters
  SELECT * FROM Equipments
  SELECT * FROM EquipmentType
  SELECT * FROM Orders
 
-- ROLLBACK TRANSACTION