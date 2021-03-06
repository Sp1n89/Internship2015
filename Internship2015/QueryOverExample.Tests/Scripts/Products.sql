GO


--MERGE generated by 'sp_generate_merge' stored procedure, Version 0.93
--Originally by Vyas (http://vyaskn.tripod.com): sp_generate_inserts (build 22)
--Adapted for SQL Server 2008/2012 by Daniel Nolan (http://danere.com)

SET NOCOUNT ON

SET IDENTITY_INSERT [Product] ON

MERGE INTO [Product] AS Target
USING (VALUES
  (1,'Albuterol','Clothes')
 ,(2,'Gabapentin','Clothes')
 ,(3,'Plavix','Cooking')
 ,(4,'Zyprexa','Electronics')
 ,(5,'Abilify','Book')
 ,(6,'Diazepam','Electronics')
 ,(7,'Diazepam','Book')
 ,(8,'Lorazepam','Cleaning')
 ,(9,'Benicar HCT','Book')
 ,(10,'Cyclobenzaprin HCl','Clothes')
 ,(11,'Amoxicillin','Clothes')
 ,(12,'Triamcinolone Acetonide','Electronics')
 ,(13,'Symbicort','Clothes')
 ,(14,'Amlodipine Besylate','Clothes')
 ,(15,'Triamterene/Hydrochlorothiazide','Cooking')
 ,(16,'Amoxicillin Trihydrate/Potassium Clavulanate','Book')
 ,(17,'Trazodone HCl','Cooking')
 ,(18,'Azithromycin','Clothes')
 ,(19,'Atenolol','Book')
 ,(20,'Furosemide','Book')
 ,(21,'Tramadol HCl','Clothes')
 ,(22,'Proair HFA','Book')
 ,(23,'Amlodipine Besylate','Medicine')
 ,(24,'Hydrochlorothiazide','Book')
 ,(25,'Zolpidem Tartrate','Medicine')
 ,(26,'Lorazepam','Medicine')
 ,(27,'Zetia','Cooking')
 ,(28,'Clindamycin HCl','Book')
 ,(29,'Alprazolam','Cleaning')
 ,(30,'Amlodipine Besylate','Cooking')
 ,(31,'Synthroid','Clothes')
 ,(32,'Alendronate Sodium','Cooking')
 ,(33,'Viagra','Electronics')
 ,(34,'Metoprolol Succinatee','Book')
 ,(35,'Amlodipine Besylate','Cooking')
 ,(36,'Penicillin VK','Cooking')
 ,(37,'Metoprolol Succinatee','Book')
 ,(38,'Benicar HCT','Medicine')
 ,(39,'Simvastatin','Book')
 ,(40,'Cialis','Cleaning')
 ,(41,'Amoxicillin','Cleaning')
 ,(42,'Tramadol HCl','Electronics')
 ,(43,'Promethazine HCl','Medicine')
 ,(44,'Alprazolam','Clothes')
 ,(45,'APAP/Codeine','Cleaning')
 ,(46,'Gabapentin','Cleaning')
 ,(47,'Furosemide','Medicine')
 ,(48,'Meloxicam','Cooking')
 ,(49,'Prednisone','Cooking')
 ,(50,'Diovan','Cleaning')
 ,(51,'Amlodipine Besylate','Electronics')
 ,(52,'Amphetamine Salts','Cooking')
 ,(53,'Sertraline HCl','Cleaning')
 ,(54,'Alendronate Sodium','Cleaning')
 ,(55,'Lisinopril','Cooking')
 ,(56,'Zolpidem Tartrate','Cooking')
 ,(57,'Diovan HCT','Book')
 ,(58,'Levoxyl','Electronics')
 ,(59,'Crestor','Cleaning')
 ,(60,'Loestrin 24 Fe','Clothes')
 ,(61,'Amitriptyline HCl','Medicine')
 ,(62,'Simvastatin','Electronics')
 ,(63,'Lisinopril','Clothes')
 ,(64,'Amlodipine Besylate','Book')
 ,(65,'Amitriptyline HCl','Cleaning')
 ,(66,'Amoxicillin Trihydrate/Potassium Clavulanate','Electronics')
 ,(67,'Metoprolol Succinatee','Cleaning')
 ,(68,'Amoxicillin','Book')
 ,(69,'Cyclobenzaprin HCl','Electronics')
 ,(70,'Azithromycin','Medicine')
 ,(71,'Amlodipine Besylate','Cooking')
 ,(72,'Risperidone','Medicine')
 ,(73,'Lipitor','Medicine')
 ,(74,'Amitriptyline HCl','Cooking')
 ,(75,'Azithromycin','Cleaning')
 ,(76,'TriNessa','Clothes')
 ,(77,'Clonazepam','Clothes')
 ,(78,'Cephalexin','Book')
 ,(79,'Metformin HCl','Book')
 ,(80,'Pantoprazole Sodium','Cooking')
 ,(81,'Diazepam','Electronics')
 ,(82,'Cymbalta','Medicine')
 ,(83,'Omeprazole (Rx)','Clothes')
 ,(84,'Oxycodone/APAP','Cleaning')
 ,(85,'Trazodone HCl','Clothes')
 ,(86,'Amoxicillin Trihydrate/Potassium Clavulanate','Clothes')
 ,(87,'Digoxin','Cleaning')
 ,(88,'Diovan HCT','Clothes')
 ,(89,'Sertraline HCl','Electronics')
 ,(90,'Lisinopril','Cooking')
 ,(91,'Alprazolam','Cooking')
 ,(92,'Ibuprofen (Rx)','Book')
 ,(93,'Amoxicillin','Electronics')
 ,(94,'Premarin','Cleaning')
 ,(95,'Amlodipine Besylate','Clothes')
 ,(96,'LevothyroxineSodium','Cleaning')
 ,(97,'Fluoxetine HCl','Cooking')
 ,(98,'Lipitor','Clothes')
 ,(99,'Potassium Chloride','Electronics')
 ,(100,'Carisoprodol','Cooking')
) AS Source ([ProductID],[Name],[Category])
ON (Target.[ProductID] = Source.[ProductID])
WHEN MATCHED AND (
	NULLIF(Source.[Name], Target.[Name]) IS NOT NULL OR NULLIF(Target.[Name], Source.[Name]) IS NOT NULL OR 
	NULLIF(Source.[Category], Target.[Category]) IS NOT NULL OR NULLIF(Target.[Category], Source.[Category]) IS NOT NULL) THEN
 UPDATE SET
  [Name] = Source.[Name], 
  [Category] = Source.[Category]
WHEN NOT MATCHED BY TARGET THEN
 INSERT([ProductID],[Name],[Category])
 VALUES(Source.[ProductID],Source.[Name],Source.[Category])
WHEN NOT MATCHED BY SOURCE THEN 
 DELETE
;
GO
DECLARE @mergeError int
 , @mergeCount int
SELECT @mergeError = @@ERROR, @mergeCount = @@ROWCOUNT
IF @mergeError != 0
 BEGIN
 PRINT 'ERROR OCCURRED IN MERGE FOR [Product]. Rows affected: ' + CAST(@mergeCount AS VARCHAR(100)); -- SQL should always return zero rows affected
 END
ELSE
 BEGIN
 PRINT '[Product] rows affected by MERGE: ' + CAST(@mergeCount AS VARCHAR(100));
 END
GO

SET IDENTITY_INSERT [Product] OFF
GO
SET NOCOUNT OFF
GO
