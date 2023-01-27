USE [TnTMarketDB]
GO

INSERT INTO [dbo].[Settings]
           ([ID]
           ,[Name]
           ,[Description]
           ,[Slogan]
           ,[SearchPlaceHolder]
           ,[EmailContact]
           ,[Version]
           ,[Currency]
           ,[TransactionFeePercent]
           ,[TransactionMinimumSize]
           ,[TransactionMinimumFee]
           --,[SmtpHost]
           --,[SmtpPort]
           --,[SmtpUserName]
           ----,[SmtpPassword]
           ,[SmtpSSL]
           --,[EmailAddress]
           --,[EmailDisplayName]
           ,[AgreementRequired]
           --,[AgreementLabel]
           --,[AgreementText]
           --,[SignupText]
           ,[EmailConfirmedRequired]
           ,[Theme]
           ,[DateFormat]
           ,[TimeFormat]
           ,[ListingReviewEnabled]
           ,[ListingReviewMaxPerDay]
           ,[Created]
           ,[LastUpdated]
           ,[NbMaxListingUsrDefault])
     VALUES (
           1	 --1,
           , 'TrucnTrocs'
           ,'Trouver des biens et des services de tous genre dans votre entourage!'
           ,'TrucnTrocs -  Demo'
           ,'Rechercher vos bons plans...'
           ,'asysoft@yahoo.com'
           ,'2.0'
           ,'EUR'
           ,1
           ,10
           ,10
           --,<SmtpHost, nvarchar(100),>
           --,<SmtpPort, int,>
           --,<SmtpUserName, nvarchar(100),>
           --,<SmtpPassword, nvarchar(100),>
           ,0	--,<SmtpSSL, bit,>
           --,<EmailAddress, nvarchar(100),>
           --,<EmailDisplayName, nvarchar(100),>
           ,1	--,<AgreementRequired, bit,>
           --,<AgreementLabel, nvarchar(100),>
           --,<AgreementText, nvarchar(max),>
           --,<SignupText, nvarchar(max),>
           ,0	--,<EmailConfirmedRequired, bit,>
           ,'Default'	--,<Theme, nvarchar(250),>
           , 'dd/MM/yyyy'	--,<DateFormat, nvarchar(10),>
           , 'HH:mm'	--,<TimeFormat, nvarchar(10),>
           , 1	-- ,<ListingReviewEnabled, bit,>
           , 5	--,<ListingReviewMaxPerDay, int,>
           , GETDATE()	--,<Created, datetime,>
           , GETDATE()	-- <LastUpdated, datetime,>
           , 10	--,<NbMaxListingUsrDefault, int,>
		   )
GO

select * from [dbo].[Settings]

