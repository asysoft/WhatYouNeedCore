/****** Script de la commande SelectTopNRows à partir de SSMS  ******/
use [TnTMarketDB]

SELECT *  FROM [dbo].[AspNetRoles]

SELECT *  FROM [dbo].[AspNetUserRoles]

SELECT *  FROM [dbo].[AspNetUsers]
SELECT *  FROM [dbo].[AspNetUserLogins]
SELECT *  FROM  [dbo].[AspNetUserClaims]
SELECT *  FROM  [dbo].[UsersAddInfos]
SELECT * FROM [TntMarketDB].[dbo].[__MigrationHistory]
------------------------------------------
drop table [dbo].[AspNetUserRoles]
drop table [dbo].[AspNetRoles]
drop table  [dbo].[AspNetUserLogins]
drop table [dbo].[AspNetUserClaims]
drop table [dbo].[AspNetUsers]
drop table [dbo].[__MigrationHistory]

------------------------------------------------
select * from [dbo].[Settings]