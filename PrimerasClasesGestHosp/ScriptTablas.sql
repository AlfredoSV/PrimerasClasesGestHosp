CREATE DATABASE GESTIONHOSP;

drop table Producto;
drop table Paciente;
DROP TABLE Cita;

USE GESTIONHOSP;

CREATE TABLE Paciente(

	Id uniqueidentifier PRIMARY KEY NOT NULL,
	Nombre nvarchar(256) not null,
	Edad int not null,
	Direccion nvarchar(512) not null,
	Telefono nvarchar(128) not null,
	Correo nvarchar(256) NOT NULL,
	Expediente VARCHAR(MAX) NULL,
	Foto VARCHAR(MAX) NULL

);

CREATE TABLE Cita(
    Id UNIQUEIDENTIFIER primary  key NOT NULL,
    PacienteId UNIQUEIDENTIFIER NOT NULL,
    Estatus smallint NOT NULL,
    Fecha datetime NOT NULL,
	FOREIGn KEY(PacienteId) REFERENCES Paciente(Id)
	
);


CREATE TABLE Producto(
    Id UNIQUEIDENTIFIER PRIMARY KEY NOT NULL,
    Nombre nvarchar(128) NOT NULL,
    Descripcion nvarchar(512) NOT NULL,
    Tipo smallint NOT NULL,
    Precio float NOT NULL,
    Cantidad int NOT NULL,
    Foto varchar(MAX) NOT NULL
);

INSERT INTO Producto VALUES(NEWID(),'Ejemplo1','Desc1',
1,45.7,3,'base64');