USE TA
 
BEGIN TRANSACTION
  -- ������� �� �������
  SELECT * FROM Masters
  SELECT * FROM Equipments
  SELECT * FROM EquipmentType
  SELECT * FROM Orders
  -- ������� ����� �������, �����, �����������
  EXEC dbo.UsP_AddNewOrder '�������','������� �.�.','��������� ����� ����������','������','Oki',6,'��������'
  EXEC dbo.UsP_AddNewOrder '���','������� �.�.','�������� ������� ��������','�����','Vivo',6,'��������'
  EXEC dbo.UsP_AddNewOrder '��������','������� �.�.','��������� ����� ����������','���','iPhome 15X',1,'��������'
  EXEC dbo.UsP_AddNewOrder '���������������','������ �.�.','������','������','GlobeSign',2,'��������'
  -- ������� ����� �������
  SELECT * FROM Masters
  SELECT * FROM Equipments
  SELECT * FROM EquipmentType
  SELECT * FROM Orders
 
-- ROLLBACK TRANSACTION