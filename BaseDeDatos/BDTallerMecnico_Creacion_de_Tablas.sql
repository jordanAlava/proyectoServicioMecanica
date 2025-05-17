CREATE DATABASE BDTallerMecanico

USE BDTallerMecanico;
GO
-- Tabla Administrador
CREATE TABLE Administrador (
    cedula VARCHAR(10) PRIMARY KEY,
    nombreAdmin VARCHAR(100) NOT NULL,
    apellidoAdmin VARCHAR(100) NOT NULL,
    e_mail VARCHAR(50) NOT NULL,
    userName VARCHAR(10) UNIQUE NOT NULL ,
    passAdmin VARCHAR(12) NOT NULL
);

-- Tabla Cliente
CREATE TABLE Cliente (
    idCliente INT PRIMARY KEY IDENTITY(1,1),
    cedula VARCHAR(10) UNIQUE,
    nombreCli VARCHAR(100) NOT NULL,
    apellidoCli VARCHAR(100) NOT NULL,
    genero CHAR(1) CHECK(genero = 'M' OR genero = 'F'),
    direccion VARCHAR(200) NOT NULL,
    ciudadCli VARCHAR(100),
    provinciaCli VARCHAR(100),
    e_mail VARCHAR(50) NOT NULL,
    userCliente VARCHAR(10) UNIQUE NOT NULL,
    passCli VARCHAR(12) NOT NULL
);

-- Tabla Cliente_Telf
CREATE TABLE Cliente_Telf (
    idCliente INT,
    telefono VARCHAR(10) NOT NULL,
    FOREIGN KEY (idCliente) REFERENCES Cliente(idCliente),
    PRIMARY KEY (idCliente, telefono)
);

-- Tabla Vehiculo
CREATE TABLE Vehiculo (
    placa VARCHAR(8) PRIMARY KEY,
    idCliente INT,
    modelo VARCHAR(100) NOT NULL,
    marca VARCHAR(100) NOT NULL,
    numChasis VARCHAR(17) NOT NULL,
    color VARCHAR(30) NOT NULL,
    fechaFabricacion DATE NOT NULL,
    cilindraje VARCHAR(10) NOT NULL,
    combustible VARCHAR(50) NOT NULL,
    asegurado CHAR(1) CHECK(asegurado = 'S' OR asegurado = 'N') NOT NULL,
    foto VARBINARY(MAX) NOT NULL,
    FOREIGN KEY (idCliente) REFERENCES Cliente(idCliente)
);

-- Tabla Servicio
CREATE TABLE Servicio (
    idServicio INT PRIMARY KEY IDENTITY (1,1),
    nombreServicio VARCHAR(100) NOT NULL,
    tipo VARCHAR(100) NOT NULL,
    descripcion TEXT NOT NULL,
    costoUnitario MONEY NOT NULL CHECK(costoUnitario >= 0),
    iva INT NOT NULL,  --Controlar a nivel de backend que sea positivo y valores reales 
    costoTotal MONEY NOT NULL CHECK(costoTotal >= 0),
    garantiaServicio INT --valor entero que representa meses
);

-- Tabla Repuesto
CREATE TABLE Repuesto (
    idRepuesto INT PRIMARY KEY IDENTITY(1,1),
    modelo VARCHAR(100) NOT NULL,
    marca VARCHAR(100) NOT NULL,
    tipoRepuesto VARCHAR(100) NOT NULL,
    costoUnitario MONEY NOT NULL CHECK(costoUnitario >= 0),
    iva INT NOT NULL, --Controlar a nivel de backend que sea positivo y valores reales 
    stock INT NOT NULL CHECK(stock >= 0),
    tiempoGarantia INT NOT NULL					--valor entero que representa meses
);

-- Tabla Vehiculo_Servicio
CREATE TABLE Vehiculo_Servicio (
    placa VARCHAR(8),
    idServicio INT,
    fechaServicio DATE,
    FOREIGN KEY (placa) REFERENCES Vehiculo(placa),
    FOREIGN KEY (idServicio) REFERENCES Servicio(idServicio),
    PRIMARY KEY (placa, idServicio)
);

-- Tabla Administrado_Servicio
CREATE TABLE Administrado_Servicio (
    cedula VARCHAR(10),
    idServicio INT,
    FOREIGN KEY (cedula) REFERENCES Administrador(cedula),
    FOREIGN KEY (idServicio) REFERENCES Servicio(idServicio),
    PRIMARY KEY (cedula, idServicio)
);

-- Tabla Servicio_Repuesto
CREATE TABLE Servicio_Repuesto (
    idServicio INT,
    idRepuesto INT,
    fechaInstalacion DATE NOT NULL,
    fechaCambio DATE NOT NULL,
    cantidad INT NOT NULL,
    FOREIGN KEY (idServicio) REFERENCES Servicio(idServicio),
    FOREIGN KEY (idRepuesto) REFERENCES Repuesto(idRepuesto),
    PRIMARY KEY (idServicio, idRepuesto)
);
