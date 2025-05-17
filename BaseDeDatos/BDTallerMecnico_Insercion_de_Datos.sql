USE BDTallerMecanico;
GO
--Inserci�n de datos en la Tabla Administrador
INSERT INTO Administrador(cedula,nombreAdmin,apellidoAdmin,e_mail,userName,passAdmin) 
VALUES('0208759645','Luis Antonio','Sanchez','luisitosnchz@gmail.com','lusitio19','luis@123');

-- Inserci�n de datos en la Tabla Cliente
INSERT INTO Cliente(cedula, nombreCli, apellidoCli, genero, Direccion, ciudadCli, provinciaCli, e_mail, userCliente, passCli)
VALUES('0301765482', 'Carlos Alberto', 'Ruiz G�mez', 'M', 'Av. San Carlos y Calle Gal�pagos', 'Ambato', 'Tungurahua', 'carlos.ruiz@mail.net', 'carlosr', 'diskap456');

--Verificar el id de ese cliente al ser identity
SELECT idCliente 
FROM Cliente 
WHERE cedula = '0301765482'

-- Inserci�n de datos en la Tabla Cliente_Telf
INSERT INTO Cliente_Telf(idCliente, telefono)
VALUES ('1', '0987654321');

-- Inserci�n de datos en la Tabla Vehiculo
--La foto es de tipo VARBINARY(MAX) por lo que para cargar datos en este apartado es importante desde el backend hacer la operaci�n para cargar la imagen e insertar los bytes de la imagen en el �ltimo campo
INSERT INTO Vehiculo(placa, idCliente, modelo, marca, numChasis, color, fechaFabricacion, cilindraje, combustible, asegurado, foto)
VALUES('HAC-0134','1', 'Sed�n', 'Chevrolet', '1G1ABCD1234567890', 'Rojo', '2022-05-10', '1600cc', 'Gasolina', 'S', 0x /* Aqu� ir�an los bytes de la imagen */);

-- Inserci�n de datos en la Tabla Servicio
INSERT INTO Servicio(nombreServicio, tipo, descripcion, costoUnitario, iva, costoTotal, garantiaServicio)
VALUES('Cambio de Aceite y Filtro', 'Mantenimiento', 'Reemplazo de aceite de motor y filtro de aceite.', 50.00, 12, 56.00, 3);

--Verificar el id de ese servicio al ser identity
SELECT idServicio 
FROM Servicio 
WHERE nombreServicio = 'Cambio de Aceite y Filtro'

-- Inserci�n de datos en la Tabla Repuesto
INSERT INTO Repuesto(modelo, marca, tipoRepuesto, costoUnitario, iva, stock, tiempoGarantia)
VALUES('Filtro de Aceite Est�ndar', 'Fram', 'Filtro', 10.00, 12, 50, 6);

----Verificar el id de ese repuesto al ser identity
SELECT idRepuesto 
FROM Repuesto 
WHERE modelo = 'Filtro de Aceite Est�ndar'

-- Inserci�n de datos en la Tabla Vehiculo_Servicio
INSERT INTO Vehiculo_Servicio(placa, idServicio)
VALUES('HAC-0134','1' );

-- Inserci�n de datos en la Tabla Administrado_Servicio
INSERT INTO Administrado_Servicio(cedula, idServicio)
VALUES('0208759645','1');

-- Inserci�n de datos en la Tabla Servicio_Repuesto
INSERT INTO Servicio_Repuesto(idServicio, idRepuesto, fechaInstalacion, fechaCambio, cantidad)
VALUES('1','1', '15/05/2025', '15/05/2026', 1);