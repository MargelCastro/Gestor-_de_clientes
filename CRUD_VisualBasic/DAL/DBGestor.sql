use master
go
create database Gestor
go
use Gestor
go
create table Usuarios(
id int primary key identity not null,
Nombre varchar (200) not null,
Loggin varchar (100) not null unique,
Pass varchar (50) not null,
FechaRegistro DateTime not null,
IdUsuarioActualizacion int not null,
FechaActualizacion Date not null,
Activo bit,
);
go

INSERT INTO Usuarios (Nombre, Loggin, Pass, FechaRegistro, IdUsuarioActualizacion, FechaActualizacion, Activo)
VALUES
    ('Margel', 'rekedomina', 'rekedomina', GETDATE(), 1, GETDATE(), 1),
    ('Josue', 'peludito', 'peludito', GETDATE(), 1, GETDATE(), 1),
    ('Hans', 'chimpirilin', 'chimpirilin', GETDATE(), 1, GETDATE(), 1);
go

select * from Usuarios;
