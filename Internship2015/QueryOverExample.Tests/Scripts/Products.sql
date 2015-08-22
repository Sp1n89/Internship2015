GO

SET NOCOUNT ON

SET IDENTITY_INSERT [Product] ON

MERGE INTO [Product] AS Target
USING (VALUES
  (1,'Januvia',1)
 ,(2,'Nasonex',4)
 ,(3,'Sertraline HCl',3)
 ,(4,'Zolpidem Tartrate',4)
 ,(5,'Suboxone',1)
 ,(6,'Furosemide',2)
 ,(7,'Pravastatin Sodium',1)
 ,(8,'Pravastatin Sodium',3)
 ,(9,'Synthroid',1)
 ,(10,'Zolpidem Tartrate',3)
 ,(11,'Famotidine',1)
 ,(12,'Sertraline HCl',2)
 ,(13,'Lexapro',3)
 ,(14,'Metformin HCl',3)
 ,(15,'APAP/Codeine',3)
 ,(16,'Metoprolol Succinate',2)
 ,(17,'Atenolol',3)
 ,(18,'Atenolol',1)
 ,(19,'Lisinopril',1)
 ,(20,'Sertraline HCl',3)
 ,(21,'Levothyroxine Sodium',3)
 ,(22,'Tramadol HCl',3)
 ,(23,'Zyprexa',1)
 ,(24,'Cyclobenzaprin HCl',1)
 ,(25,'Promethazine HCl',2)
 ,(26,'Triamcinolone Acetonide',4)
 ,(27,'Tamsulosin HCl',3)
 ,(28,'Endocet',3)
 ,(29,'Fluticasone Propionate',2)
 ,(30,'Carvedilol',2)
 ,(31,'Amlodipine Besylate',4)
 ,(32,'Clindamycin HCl',2)
 ,(33,'Metformin HCl',1)
 ,(34,'Allopurinol',1)
 ,(35,'Glipizide',2)
 ,(36,'Lidoderm',4)
 ,(37,'Simvastatin',3)
 ,(38,'Suboxone',4)
 ,(39,'Lantus',4)
 ,(40,'Diovan',2)
 ,(41,'Namenda',3)
 ,(42,'Albuterol',2)
 ,(43,'Atenolol',1)
 ,(44,'Famotidine',4)
 ,(45,'Metoprolol Tartrate ',2)
 ,(46,'Abilify',2)
 ,(47,'Doxycycline Hyclate',3)
 ,(48,'Loestrin 24 Fe',3)
 ,(49,'Loestrin 24 Fe',3)
 ,(50,'Diovan HCT',1)
 ,(51,'Doxycycline Hyclate',2)
 ,(52,'Prednisone',1)
 ,(53,'Fluticasone Propionate',1)
 ,(54,'Carvedilol',3)
 ,(55,'Simvastatin',2)
 ,(56,'Citalopram HBR',1)
 ,(57,'Amlodipine Besylate',3)
 ,(58,'Simvastatin',3)
 ,(59,'Hydrocodone/APAP',1)
 ,(60,'Hydrocodone/APAP',4)
 ,(61,'Gabapentin',3)
 ,(62,'Sertraline HCl',4)
 ,(63,'Zyprexa',4)
 ,(64,'Simvastatin',3)
 ,(65,'Lipitor',4)
 ,(66,'Symbicort',2)
 ,(67,'Simvastatin',1)
 ,(68,'Amoxicillin',2)
 ,(69,'Promethazine HCl',3)
 ,(70,'Cyclobenzaprin HCl',2)
 ,(71,'Vytorin',4)
 ,(72,'Lisinopril',3)
 ,(73,'Advair Diskus',3)
 ,(74,'Prednisone',4)
 ,(75,'Amlodipine Besylate',3)
 ,(76,'APAP/Codeine',4)
 ,(77,'Namenda',4)
 ,(78,'Lyrica',1)
 ,(79,'Metformin HCl',1)
 ,(80,'Pantoprazole Sodium',4)
 ,(81,'Azithromycin',1)
 ,(82,'Metoprolol Succinate',2)
 ,(83,'Premarin',4)
 ,(84,'Hydrocodone/APAP',3)
 ,(85,'Amlodipine Besylate',1)
 ,(86,'Promethazine HCl',4)
 ,(87,'Abilify',1)
 ,(88,'Amlodipine Besylate',3)
 ,(89,'Simvastatin',1)
 ,(90,'Atenolol',3)
 ,(91,'Metoprolol Succinatee',2)
 ,(92,'Ciprofloxacin HCl',4)
 ,(93,'Alprazolam',1)
 ,(94,'Furosemide',3)
 ,(95,'Alprazolam',3)
 ,(96,'Lorazepam',4)
 ,(97,'Famotidine',3)
 ,(98,'Cialis',1)
 ,(99,'Pantoprazole Sodium',3)
 ,(100,'Lisinopril',1)
) AS Source ([ProductID],[Name],[ProductCategory])
ON (Target.[ProductID] = Source.[ProductID])
WHEN MATCHED AND (
	NULLIF(Source.[Name], Target.[Name]) IS NOT NULL OR NULLIF(Target.[Name], Source.[Name]) IS NOT NULL OR 
	NULLIF(Source.[ProductCategory], Target.[ProductCategory]) IS NOT NULL OR NULLIF(Target.[ProductCategory], Source.[ProductCategory]) IS NOT NULL) THEN
 UPDATE SET
  [Name] = Source.[Name], 
  [ProductCategory] = Source.[ProductCategory]
WHEN NOT MATCHED BY TARGET THEN
 INSERT([ProductID],[Name],[ProductCategory])
 VALUES(Source.[ProductID],Source.[Name],Source.[ProductCategory])
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
