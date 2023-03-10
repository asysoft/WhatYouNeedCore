/****** Script de la commande SelectTopNRows à partir de SSMS  ******/
SELECT [NumSerie] as "Numero Serie" 
	  , [Code] 
      ,[NumLot] as "Numero Lot"
      ,[DateGeneration] as "Date Generation"
      ,[DateFinValidite] as "Date Fin Validite"
      --,[IsValid]
      --,[IsActif]
  FROM [TnTMarketDB].[dbo].[PrepaidCards]
  Where NumLot = 2
  order by NumSerie

  -----------------------------

  select uInf.ProCompany, *  
  FROM [dbo].[PrepaidCards] p
  inner join [dbo].[UserPrepaidCards] up on p.Code = up.Code
  inner join [dbo].[UsersAddInfos] uInf on up.UserID = uInf.UserID
    --Where NumLot = 0
  order by NumSerie desc

  ------------
