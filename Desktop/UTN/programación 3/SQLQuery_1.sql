Create Database Clase1
go 
use Clase1
go 
create Table carreras(
ID varchar(4) not null primary key,
Nombre varchar(20) not null,
Cracion date not null,
Mail varchar(30) not null,
Nivel varchar(50) check( Nivel = 'Diplomatura' or Nivel = 'Pregrado' or Nivel = 'Grado' or  Nivel = 'Posgrado'),
Fecha date not null check (Fecha<getdate())
)
go 
Create Table Materias(
ID bigint not null primary key IDENTITY(1,1),
ID_Carrera varchar(4) not null references carreras(ID),
Nombre varchar(20) not null,
Carga time not null check(Carga>0)
) 
go 
Create Table Alumnos(
Legajo bigint not null primary key identity (1000,1),
ID_Carrera varchar(4) not null references carreras(ID),
Apellidos varchar(100) not null,
Nombres varchar(100) not null,
Mail varchar(30) not null unique,
Telefono varchar(20) null,
Fecha_na date not null check (Fecha_na<getdate())
)