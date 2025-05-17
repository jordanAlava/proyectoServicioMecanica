USE BDTallerMecanico;
GO
--Inserción de datos en la Tabla Administrador
INSERT INTO Administrador(cedula,nombreAdmin,apellidoAdmin,e_mail,userName,passAdmin) 
VALUES('0208759645','Luis Antonio','Sanchez','luisitosnchz@gmail.com','lusitio19','luis@123');

-- Inserción de datos en la Tabla Cliente
INSERT INTO Cliente(cedula, nombreCli, apellidoCli, genero, Direccion, ciudadCli, provinciaCli, e_mail, userCliente, passCli,pasaporte)
VALUES('0301765482', 'Carlos Alberto', 'Ruiz Gómez', 'M', 'Av. San Carlos y Calle Galápagos', 'Ambato', 'Tungurahua', 'carlos.ruiz@mail.net', 'carlosr', 'diskap456', NULL);

--Verificar el id de ese cliente al ser identity
SELECT idCliente 
FROM Cliente 
WHERE cedula = '0301765482'

-- Inserción de datos en la Tabla Cliente_Telf
INSERT INTO Cliente_Telf(idCliente, telefono)
VALUES ('1', '0987654321');

-- Inserción de datos en la Tabla Vehiculo
--La foto es de tipo VARBINARY(MAX) por lo que para cargar datos en este apartado es importante desde el backend hacer la operación para cargar la imagen e insertar los bytes de la imagen en el último campo
INSERT INTO Vehiculo(placa, idCliente, modelo, marca, numChasis, color, fechaFabricacion, cilindraje, combustible, asegurado, foto)
VALUES('HBD-3341','1', 'Sedán', 'Chevrolet', '1G1ABCD1234567890', 'Rojo', '2022-05-10', '1600cc', 'Gasolina', 'S', 0x /* Aquí irían los bytes de la imagen */);

-- Inserción de datos en la Tabla Servicio
INSERT INTO Servicio(nombreServicio, tipo, descripcion, costoUnitario, iva, costoTotal, garantiaServicio)
VALUES('Cambio de Aceite y Filtro', 'Mantenimiento', 'Reemplazo de aceite de motor y filtro de aceite.', 50.00, 12, 56.00, 3);

--Verificar el id de ese servicio al ser identity
SELECT idServicio 
FROM Servicio 
WHERE nombreServicio = 'Cambio de Aceite y Filtro'

-- Inserción de datos en la Tabla Repuesto
INSERT INTO Repuesto(modelo, marca, tipoRepuesto, costoUnitario, iva, stock, tiempoGarantia)
VALUES('Filtro de Aceite Estándar', 'Fram', 'Filtro', 10.00, 12, 50, 6);

----Verificar el id de ese repuesto al ser identity
SELECT idRepuesto 
FROM Repuesto 
WHERE modelo = 'Filtro de Aceite Estándar'

-- Inserción de datos en la Tabla Vehiculo_Servicio
INSERT INTO Vehiculo_Servicio(placa, idServicio,fechaServicio)
VALUES('HBD-3341','1','2025-05-15' );

-- Inserción de datos en la Tabla Administrado_Servicio
INSERT INTO Administrado_Servicio(cedula, idServicio)
VALUES('0208759645','1');

-- Inserción de datos en la Tabla Servicio_Repuesto
INSERT INTO Servicio_Repuesto(idServicio, idRepuesto, fechaInstalacion, fechaCambio, cantidad)
VALUES('1','1', '2025-05-15', '2026-05-15', 1);
