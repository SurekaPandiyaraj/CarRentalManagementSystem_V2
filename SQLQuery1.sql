create database CarRentalManagement ;

use CarRentalManagement;

 CREATE TABLE Cars(
   CarId NVARCHAR (10) PRIMARY KEY,  
   Brand NVARCHAR(50) ,
   Model NVARCHAR(50) ,
   RentalPrice DECIMAL(10,2) 
   )

INSERT INTO Cars (CarId,Brand, Model, RentalPrice)
VALUES ('CAR_001 ','Honda' ,'Vessel', 10.00 )