CREATE DATABASE MUNDOPC_CLIENTES;
GO
USE MUNDOPC_CLIENTES;
GO
CREATE TABLE CLIENTES(
ID INT IDENTITY(1,1) PRIMARY KEY,
NOMBRE VARCHAR(40) not null, 
DNI VARCHAR(40) not null,
TELEFONO VARCHAR(40) not null, 
DIRECCION VARCHAR(50) not null,
EMAIL VARCHAR(50) not null);
GO

INSERT INTO CLIENTES(NOMBRE, DNI, TELEFONO, DIRECCION, EMAIL)
VALUES('Valentin Ferrero Lombardo','43567897','2244418798','Alberti 654, General Roca', 'valentinlombardo912@gmail.com'),
('Maria Martina Escobar','23189975','1222567832','Los Palenques 1230, General Rodriguez','maria_martinaesc@outlook.com'),
('Isidro Casanova Ramirez','23190678','3399437887','Valentin Alsina 1230, Banderalo','isidrocasa920@gmail.com'),
('Horacio Alejandro Amorouso','32789654','112456789','Moreno 2345, Venado Tuerto','horacito_trabajo@hotmail.com'),
('Agostina Alana Trotta', '31908006','2300454678', 'Necochea 95, General Alvear', 'agosss982@hotmail.com'),
('Armando Enrique Fuertes','9876563','2330422324','San Lorenzo 234, Campo Gallo','armandoenrique24@hotmail.com');