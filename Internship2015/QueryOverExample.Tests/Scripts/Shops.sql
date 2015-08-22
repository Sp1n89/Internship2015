GO
SET NOCOUNT ON

SET IDENTITY_INSERT [Shop] ON

MERGE INTO [Shop] AS Target
USING (VALUES
  (1,'Ut Mi Consulting','Etalle')
 ,(2,'Rutrum Non Hendrerit Corp.','Grembergen')
 ,(3,'Fermentum Fermentum Arcu PC','Ghaziabad')
 ,(4,'Egestas Incorporated','Arrone')
 ,(5,'In Company','Blevio')
 ,(6,'Maecenas Industries','Lloydminster')
 ,(7,'In Scelerisque Company','Piegaro')
 ,(8,'Est Ac Facilisis Corporation','Scalloway')
 ,(9,'Nibh Quisque Nonummy Associates','Martigues')
 ,(10,'Semper Erat LLP','Muiden')
 ,(11,'Turpis Egestas Fusce Incorporated','Ch?telineau')
 ,(12,'Facilisis Eget Institute','St. David''s')
 ,(13,'Neque Et Associates','Rocky Mountain House')
 ,(14,'Et Magna Consulting','Crewe')
 ,(15,'Faucibus Ut Nulla Limited','Provost')
 ,(16,'Aenean Foundation','Comblain-Fairon')
 ,(17,'Eleifend LLC','Adana')
 ,(18,'Sed Id Foundation','San Felice a Cancello')
 ,(19,'Elementum Sem Consulting','Alacant')
 ,(20,'Non Limited','Sant''Egidio alla Vibrata')
 ,(21,'Mus Donec Dignissim Consulting','Heist-op-den-Berg')
 ,(22,'Mauris Aliquam Eu Consulting','Amsterdam')
 ,(23,'Ut Pharetra Consulting','Dendermonde')
 ,(24,'Nulla Corp.','Reggio nell''Emilia')
 ,(25,'Mauris Nulla Corporation','Szczecin')
 ,(26,'Aliquam Corporation','Saint-Denis')
 ,(27,'Urna Institute','Sint-Laureins-Berchem')
 ,(28,'Purus Institute','Passau')
 ,(29,'Maecenas Mi Felis Inc.','Herstal')
 ,(30,'Tincidunt Ltd','Georgia')
 ,(31,'Blandit Inc.','Dunkerque')
 ,(32,'Facilisi Sed Neque Incorporated','Eigenbrakel')
 ,(33,'Enim Etiam Gravida Corporation','Kerkrade')
 ,(34,'Fusce PC','Ede')
 ,(35,'Arcu LLC','Temuka')
 ,(36,'Pede Suspendisse Industries','Barasat')
 ,(37,'Lacus Quisque Purus Limited','San Martino in Badia/St. Martin in Thurn')
 ,(38,'Faucibus Morbi Vehicula Corporation','Warminster')
 ,(39,'Non Company','Lomza')
 ,(40,'Nam Interdum Institute','Malvern')
 ,(41,'Diam At Pretium Associates','Saint Paul')
 ,(42,'Pede Praesent Eu Corp.','Gorinchem')
 ,(43,'Phasellus Ltd','Campofelice di Fitalia')
 ,(44,'Vivamus Nisi Mauris Limited','Rocca d''Arazzo')
 ,(45,'Montes Nascetur Corp.','Boston')
 ,(46,'Lorem Eget Mollis Ltd','Ayas')
 ,(47,'Pellentesque LLC','Saint-Urbain')
 ,(48,'Lacus Institute','Dandenong')
 ,(49,'Sit LLP','Richmond')
 ,(50,'Non Magna PC','Oteppe')
 ,(51,'Lobortis Tellus Incorporated','Mérignac')
 ,(52,'Tempor Arcu Vestibulum LLP','Vidisha')
 ,(53,'Nulla Corporation','Zierikzee')
 ,(54,'Mauris LLP','Caprauna')
 ,(55,'Mauris Non LLP','Gols')
 ,(56,'Pellentesque Consulting','Çesme')
 ,(57,'Natoque Corporation','San Damiano al Colle')
 ,(58,'At Limited','Bicester')
 ,(59,'Quis Limited','Carnoustie')
 ,(60,'Nonummy Corp.','Minna')
 ,(61,'In Nec Associates','Ercis')
 ,(62,'Non Ltd','Guilmi')
 ,(63,'Massa Rutrum LLP','Le Mans')
 ,(64,'Facilisi Sed PC','Malgesso')
 ,(65,'Nunc Lectus Pede Foundation','Birkenhead')
 ,(66,'Libero LLP','Leverkusen')
 ,(67,'Integer Eu Incorporated','Malbaie')
 ,(68,'Mauris Corp.','Schweinfurt')
 ,(69,'Nibh Quisque PC','Florenville')
 ,(70,'Lobortis Tellus Justo PC','Ragnies')
 ,(71,'Scelerisque Sed Limited','Huntly')
 ,(72,'Lorem Vitae Odio Incorporated','Gateshead')
 ,(73,'Sociis Natoque Penatibus Consulting','Rocca d''Arazzo')
 ,(74,'Dignissim Lacus Aliquam Foundation','Deschambault')
 ,(75,'Libero Lacus Incorporated','Ankara')
 ,(76,'Commodo Foundation','Saint-Maur-des-Fossés')
 ,(77,'Cubilia Curae; Corporation','Raymond')
 ,(78,'Nibh Lacinia Orci Company','Neuss')
 ,(79,'Luctus Corp.','Pavone del Mella')
 ,(80,'Vestibulum Ut Eros Inc.','Rimbey')
 ,(81,'Sit Institute','Priolo Gargallo')
 ,(82,'Mauris Ipsum LLP','Maidstone')
 ,(83,'A Feugiat Consulting','Minneapolis')
 ,(84,'Dolor Ltd','Fairbanks')
 ,(85,'Mattis Integer Company','Ravenstein')
 ,(86,'Facilisis Facilisis Foundation','Hamoir')
 ,(87,'Donec Elementum LLP','Honolulu')
 ,(88,'Ac Orci LLC','Guysborough')
 ,(89,'Semper Cursus Integer Institute','Béziers')
 ,(90,'Leo Vivamus Institute','Sutton')
 ,(91,'Facilisis Facilisis Incorporated','Portland')
 ,(92,'Quisque Libero Foundation','Tourinnes-la-Grosse')
 ,(93,'In Consulting','Bhavnagar')
 ,(94,'Lobortis Quis LLC','L?vis')
 ,(95,'Lobortis Quam A Limited','Mazzano Romano')
 ,(96,'Sed Leo PC','Aurora')
 ,(97,'Vel Nisl PC','Arendonk')
 ,(98,'Ridiculus Mus Proin LLC','Carbonear')
 ,(99,'Amet Faucibus Company','Ludwigsfelde')
 ,(100,'Sit Amet Risus Incorporated','Narbolia')
) AS Source ([ShopID],[Name],[Address])
ON (Target.[ShopID] = Source.[ShopID])
WHEN MATCHED AND (
	NULLIF(Source.[Name], Target.[Name]) IS NOT NULL OR NULLIF(Target.[Name], Source.[Name]) IS NOT NULL OR 
	NULLIF(Source.[Address], Target.[Address]) IS NOT NULL OR NULLIF(Target.[Address], Source.[Address]) IS NOT NULL) THEN
 UPDATE SET
  [Name] = Source.[Name], 
  [Address] = Source.[Address]
WHEN NOT MATCHED BY TARGET THEN
 INSERT([ShopID],[Name],[Address])
 VALUES(Source.[ShopID],Source.[Name],Source.[Address])
WHEN NOT MATCHED BY SOURCE THEN 
 DELETE
;
GO
DECLARE @mergeError int
 , @mergeCount int
SELECT @mergeError = @@ERROR, @mergeCount = @@ROWCOUNT
IF @mergeError != 0
 BEGIN
 PRINT 'ERROR OCCURRED IN MERGE FOR [Shop]. Rows affected: ' + CAST(@mergeCount AS VARCHAR(100)); -- SQL should always return zero rows affected
 END
ELSE
 BEGIN
 PRINT '[Shop] rows affected by MERGE: ' + CAST(@mergeCount AS VARCHAR(100));
 END
GO

SET IDENTITY_INSERT [Shop] OFF
GO
SET NOCOUNT OFF
GO
