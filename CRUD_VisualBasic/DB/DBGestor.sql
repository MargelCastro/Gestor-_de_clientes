USE master
GO
CREATE DATABASE Gestor
GO
USE Gestor
GO
CREATE TABLE usuario_de_aplicacion(
	id INT PRIMARY KEY IDENTITY NOT NULL,
	primer_nombre VARCHAR(200) NOT NULL,
	segundo_nombre VARCHAR(200) NOT NULL,
	primer_apellido VARCHAR(200) NOT NULL,
	segundo_apellido VARCHAR(200) NOT NULL,
	telefono VARCHAR(200) NOT NULL,
	correo_electronico VARCHAR(200) NOT NULL,
	direccion VARCHAR(200) NOT NULL,
	[login] VARCHAR(100)  NOT NULL UNIQUE,
	[password] varchar (50) NOT NULL,
	fecha_de_registro DATETIME NOT NULL,
	fecha_de_actualizacion DATE NOT NULL,
	activo BIT,
);
GO

CREATE TABLE deudor (
	id int primary key identity NOT NULL,
	primer_nombre VARCHAR(200) NOT NULL,
	segundo_nombre VARCHAR(200) NOT NULL,
	primer_apellido VARCHAR(200) NOT NULL,
	segundo_apellido VARCHAR(200) NOT NULL,
	telefono VARCHAR(200) NOT NULL,
	correo_electronico VARCHAR(200) NOT NULL,
	direccion VARCHAR(200) NOT NULL,
	fecha_de_registro DATETIME NOT NULL,
	fecha_de_actualizacion DATE NOT NULL,
	deuda MONEY,
	activo BIT,
);
GO

-- Actualizar estos valores con el nuevo schema

-- INSERT INTO usuario_de_aplicacion(Nombre, Loggin, Pass, FechaRegistro, IdUsuarioActualizacion, FechaActualizacion, Activo)
-- VALUES
--     ('Margel', 'rekedomina', 'rekedomina', GETDATE(), 1, GETDATE(), 1),
--     ('Josue', 'peludito', 'peludito', GETDATE(), 1, GETDATE(), 1),
--     ('Hans', 'chimpirilin', 'chimpirilin', GETDATE(), 1, GETDATE(), 1);
-- GO

--Tablas Faltantes:  Productos, 

--select * from Usuarios;
