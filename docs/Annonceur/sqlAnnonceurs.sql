/****** Script de la commande SelectTopNRows à partir de SSMS  ******/
use [TnTMarketDB]

SELECT *  FROM [dbo].[AspNetRoles]
SELECT *  FROM [dbo].[AspNetUsers]

SELECT *  FROM [dbo].[AspNetUserRoles] ur
inner join [dbo].[AspNetRoles] r on r.Id = ur.RoleId





------------------------------------------


