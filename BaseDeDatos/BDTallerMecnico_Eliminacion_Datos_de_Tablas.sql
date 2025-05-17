--Los siguientes comandos me permiten borrar todos los datos de la BD y reiniciar los identity
USE BDTallerMecanico;
GO

-- 1. Desactivar temporalmente las restricciones de clave foránea
ALTER TABLE Cliente_Telf NOCHECK CONSTRAINT ALL;
ALTER TABLE Vehiculo NOCHECK CONSTRAINT ALL;

-- 2. Eliminar datos respetando relaciones
DELETE FROM Cliente_Telf;
DELETE FROM Vehiculo;
DELETE FROM Cliente;
DELETE FROM Servicio;
DELETE FROM Repuesto;
DELETE FROM Administrador;

-- 3. Reiniciar campos IDENTITY (para tablas que lo tengan)
DBCC CHECKIDENT ('Cliente', RESEED, 0);
DBCC CHECKIDENT ('Servicio', RESEED, 0);
DBCC CHECKIDENT ('Repuesto', RESEED, 0);

-- 4. Reactivar restricciones de clave foránea
ALTER TABLE Cliente_Telf WITH CHECK CHECK CONSTRAINT ALL;
ALTER TABLE Vehiculo WITH CHECK CHECK CONSTRAINT ALL;
