Create database SistemaSalud
go
use SistemaSalud
go


--Esquema
Create table Provincias 
(
IdProvincia int primary key,
NombreProvincia varchar(100) not null unique 
)

Create table Usuarios
(
IdUsuario int primary key identity,
Nombre varchar (100) not null,
usuario varchar (30) not null unique,
contraseña varchar(100) not null,
Rol varchar(30) not null,

IdProvincia int,

foreign key (IdProvincia) References Provincias(IdProvincia)
)

Create table TipoEstablecimiento
(
IdTipo int primary key,
Nombre varchar(100) not null,
descripcion varchar (255)
)

Create table Establecimientos
(
IdEstablecimiento int primary key identity,
Nombre varchar(100) not null,
Direccion varchar(255) not null,
Telefono varchar(20) not null,

IdProvincia int not null,
IdTipo int not null,

foreign key (IdProvincia) References Provincias(IdProvincia),
foreign key (IdTipo) References TipoEstablecimiento(IdTipo)
)

