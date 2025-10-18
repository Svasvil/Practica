
CREATE DATABASE Habitaciones
GO

USE Habitaciones;
GO


drop table InfoHabitaciones;
CREATE TABLE InfoHabitaciones (
 
    ID INT PRIMARY KEY IDENTITY (1,1),
    CODIGO INT NOT NULL UNIQUE, 
    NOMBRE VARCHAR(100) NOT NULL,
    UBICACION VARCHAR(150) NOT NULL,
    CANTIDAD_HUESPEDES_PERMITIDOS INT NOT NULL,
    CANTIDAD_DE_CAMAS INT NOT NULL,
    CANTIDAD_DE_BANIOS INT NOT NULL,
    RESPONSABLE_DE_LIMPIEZA VARCHAR(100),
    COSTO_DE_LIMPIEZA DECIMAL(10, 2) NOT NULL,
    COSTO_DE_RESERVA DECIMAL(10, 2) NOT NULL,
    TIPO_DE_HABITACION INT NOT NULL,
    FECHA_DE_REGISTRO DATETIME NOT NULL,
    FECHA_DE_MODIFICACION DATETIME,
    ESTADO INT  NOT NULL 
);
GO

---------------------------------------------------

INSERT INTO [dbo].InfoHabitaciones
           ([CODIGO]
           ,[NOMBRE]
           ,[UBICACION]
           ,[CANTIDAD_HUESPEDES_PERMITIDOS]
           ,[CANTIDAD_DE_CAMAS]
           ,[CANTIDAD_DE_BANIOS]
           ,[RESPONSABLE_DE_LIMPIEZA]
           ,[COSTO_DE_LIMPIEZA]
           ,[COSTO_DE_RESERVA]
           ,[TIPO_DE_HABITACION]
           ,[FECHA_DE_REGISTRO]
           ,[FECHA_DE_MODIFICACION]
           ,[ESTADO])
     VALUES
           (1111
           ,'Habitación Junior Vista al Jardín'
           ,'Piso 1, Ala Oeste'
           ,2
           ,1
           ,1
           ,'Ana López'
           ,15.00
           ,80.00
           ,1 -- Junior
           ,GETDATE()
           ,NULL
           ,1)
GO
-- 5. Consulta de los Datos Insertados
SELECT * FROM InfoHabitaciones
GO