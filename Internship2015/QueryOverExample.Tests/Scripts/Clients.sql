GO

SET NOCOUNT ON

SET IDENTITY_INSERT [Client] ON

MERGE INTO [Client] AS Target
USING (VALUES
  (1,'John','Doe','+40 (76) 555-666','Timisoara')
 ,(2,'Martin','Mcgee','(0114) 524 6633','North Vancouver')
 ,(3,'Lucas','Gallagher','0375 579 7254','Hearst')
 ,(4,'Kenneth','Quinn','(0171) 048 1174','South Portland')
 ,(5,'Micah','Mclaughlin','070 8028 8121','Collines-de-l''Outaouais')
 ,(6,'Leroy','West','056 3831 6515','Carnoustie')
 ,(7,'Lawrence','Cunningham','(01051) 23154','Loppem')
 ,(8,'Benjamin','Malone','(0118) 896 2713','Sparwood')
 ,(9,'Camden','Fitzgerald','07624 049766','Liberchies')
 ,(10,'Jesse','Warner','0880 272 1651','Siliguri')
 ,(11,'Adrian','Porter','076 7450 8815','Grand Rapids')
 ,(12,'Jerry','Caldwell','0845 46 47','Anderlecht')
 ,(13,'Mason','Poole','(01676) 45863','Labico')
 ,(14,'Berk','Marquez','(0151) 748 9545','Richmond')
 ,(15,'Berk','Atkinson','0500 391324','Tirupati')
 ,(16,'Hashim','Long','0912 727 3406','Inveraray')
 ,(17,'Kenyon','Simon','055 6641 0513','Göksun')
 ,(18,'Fuller','Carlson','(0191) 668 8820','Saint-Eug?ne-de-Guigues')
 ,(19,'Louis','Coffey','0997 219 9660','Wilmont')
 ,(20,'Brent','Glass','07624 325459','Bonavista')
 ,(21,'Stone','Stafford','(01266) 82641','Arquata del Tronto')
 ,(22,'Dillon','Fowler','(01485) 304601','Villanova d''Albenga')
 ,(23,'Orson','Benton','0800 919507','Landelies')
 ,(24,'Tyrone','Finley','(01206) 54856','McCallum')
 ,(25,'Ezekiel','Glenn','(018081) 82197','Castelluccio Inferiore')
 ,(26,'Keith','Goff','076 6448 2322','Montague')
 ,(27,'Raja','Sullivan','0800 1111','Borghetto di Vara')
 ,(28,'Curran','Russo','(0131) 122 1155','Houthalen')
 ,(29,'Vernon','Moran','07624 895400','Vernon')
 ,(30,'Gil','Price','0845 46 46','Sapele')
 ,(31,'Phillip','Holden','(0111) 179 2526','Labrecque')
 ,(32,'Mark','Mercer','(01845) 77312','Saint-L?onard')
 ,(33,'Jasper','Gillespie','(0116) 365 9875','Molenbeersel')
 ,(34,'Malachi','Hughes','(01249) 47754','Stewart')
 ,(35,'Cullen','Webster','07715 957275','Monfumo')
 ,(36,'Sylvester','Ferrell','0844 511 3813','Ollolai')
 ,(37,'Thomas','Reese','0800 392 4261','Gdansk')
 ,(38,'Dale','Armstrong','0867 608 3995','Aubagne')
 ,(39,'Hasad','Levy','07557 495299','Stigliano')
 ,(40,'Dillon','Puckett','070 8737 7838','Hameln')
 ,(41,'Beck','Berg','0500 481843','Spaniard''s Bay')
 ,(42,'Hall','Richard','0845 46 41','Vidisha')
 ,(43,'Damon','Duffy','0800 855970','M?rfelden-Walldorf')
 ,(44,'Brian','Harrison','076 6229 3872','Swadlincote')
 ,(45,'Timothy','Cash','(0111) 335 3688','Wollongong')
 ,(46,'Merrill','Green','(01358) 46894','Burlington')
 ,(47,'Ignatius','Matthews','0800 350 4091','Hull')
 ,(48,'Vincent','Freeman','0800 934049','Gladstone')
 ,(49,'Driscoll','Charles','0800 333 1891','Wilmington')
 ,(50,'Jackson','Dale','(01304) 314561','Giustino')
 ,(51,'Stewart','Brooks','0800 1111','Beerse')
 ,(52,'Aaron','Hubbard','(0114) 040 4097','Vico nel Lazio')
 ,(53,'Christian','Gutierrez','07624 252721','Soria')
 ,(54,'Allen','Hartman','0845 46 43','Springfield')
 ,(55,'Finn','Lancaster','(025) 4581 3986','Sargodha')
 ,(56,'Reese','Jarvis','070 1406 2266','Delft')
 ,(57,'Raymond','Moss','076 6999 6465','Pietrasanta')
 ,(58,'Finn','Carpenter','07820 912499','Zelzate')
 ,(59,'Kennedy','Perkins','0845 46 40','Melle')
 ,(60,'Vladimir','Graham','0845 46 48','Llandovery')
 ,(61,'Jeremy','Armstrong','(0141) 831 5335','Meerdonk')
 ,(62,'Gary','Rush','0800 946264','Onze-Lieve-Vrouw-Lombeek')
 ,(63,'Gray','Richardson','076 9973 5105','San Lazzaro di Savena')
 ,(64,'Allen','Berger','0500 221637','Erode')
 ,(65,'Gage','Witt','0845 46 41','Aberystwyth')
 ,(66,'Cullen','Kelly','07624 699105','Ingolstadt')
 ,(67,'Colt','Downs','(01368) 666608','Saint-Herblain')
 ,(68,'Harding','Buckner','0500 990027','Macerata')
 ,(69,'Aquila','Keith','076 8492 4948','Court-Saint-Etienne')
 ,(70,'Marsden','Salazar','0821 347 5252','Forbach')
 ,(71,'Kyle','Casey','(01251) 12760','Kohima')
 ,(72,'Beck','Rivas','055 6103 9909','Lachine')
 ,(73,'Moses','Stuart','(0116) 344 3886','San Diego')
 ,(74,'Hunter','Pickett','0800 542 9381','Worcester')
 ,(75,'Wylie','Nielsen','056 2947 2170','Embourg')
 ,(76,'Ishmael','Sampson','0359 938 8294','Medicine Hat')
 ,(77,'Jacob','Benjamin','07624 734412','Tramatza')
 ,(78,'Griffin','Morrison','0800 1111','Aschaffenburg')
 ,(79,'Trevor','Leonard','0320 243 5040','Colleretto Castelnuovo')
 ,(80,'Hayden','Watts','0868 902 7220','Pont-de-Loup')
 ,(81,'Colorado','Hayes','0800 706 0816','Oklahoma City')
 ,(82,'Kadeem','Sargent','0845 46 46','Birkenhead')
 ,(83,'Sebastian','William','(01348) 731024','Lewiston')
 ,(84,'Judah','Giles','(016977) 0926','La Matap?dia')
 ,(85,'Yoshio','Bowen','070 3197 8835','Gbongan')
 ,(86,'Stephen','Rodriquez','(0131) 119 1371','Laon')
 ,(87,'Josiah','Berg','0929 196 0991','Naumburg')
 ,(88,'Denton','Hunter','0812 759 2257','Bangalore')
 ,(89,'Alexander','Hensley','0845 46 43','Roux')
 ,(90,'Felix','Collier','056 5400 6422','Montgomery')
 ,(91,'Abel','Rivas','(0113) 435 3103','Cambrai')
 ,(92,'Zephania','Oliver','055 7934 4739','Tarcento')
 ,(93,'Kenneth','Fitzpatrick','07624 820175','B.S.D.')
 ,(94,'Joseph','Booker','07537 110458','Monfumo')
 ,(95,'Burton','Craig','055 4310 3230','San Marcello')
 ,(96,'Bevis','Maldonado','(01855) 581160','L?neburg')
 ,(97,'Isaiah','Barnett','0800 212 6042','Aalst')
 ,(98,'Nero','Patton','07624 580229','Aartrijke')
 ,(99,'Kennan','Carr','0500 179992','Mandurah')
 ,(100,'Hayden','Cobb','(0116) 165 8910','Trois-Rivi?res')
 ,(101,'Bruno','Moody','(01769) 082362','Avellino')
) AS Source ([ClientID],[Firstname],[Lastname],[TelephoneNumber],[Address])
ON (Target.[ClientID] = Source.[ClientID])
WHEN MATCHED AND (
	NULLIF(Source.[Firstname], Target.[Firstname]) IS NOT NULL OR NULLIF(Target.[Firstname], Source.[Firstname]) IS NOT NULL OR 
	NULLIF(Source.[Lastname], Target.[Lastname]) IS NOT NULL OR NULLIF(Target.[Lastname], Source.[Lastname]) IS NOT NULL OR 
	NULLIF(Source.[TelephoneNumber], Target.[TelephoneNumber]) IS NOT NULL OR NULLIF(Target.[TelephoneNumber], Source.[TelephoneNumber]) IS NOT NULL OR 
	NULLIF(Source.[Address], Target.[Address]) IS NOT NULL OR NULLIF(Target.[Address], Source.[Address]) IS NOT NULL) THEN
 UPDATE SET
  [Firstname] = Source.[Firstname], 
  [Lastname] = Source.[Lastname], 
  [TelephoneNumber] = Source.[TelephoneNumber], 
  [Address] = Source.[Address]
WHEN NOT MATCHED BY TARGET THEN
 INSERT([ClientID],[Firstname],[Lastname],[TelephoneNumber],[Address])
 VALUES(Source.[ClientID],Source.[Firstname],Source.[Lastname],Source.[TelephoneNumber],Source.[Address])
WHEN NOT MATCHED BY SOURCE THEN 
 DELETE
;
GO
DECLARE @mergeError int
 , @mergeCount int
SELECT @mergeError = @@ERROR, @mergeCount = @@ROWCOUNT
IF @mergeError != 0
 BEGIN
 PRINT 'ERROR OCCURRED IN MERGE FOR [Client]. Rows affected: ' + CAST(@mergeCount AS VARCHAR(100)); -- SQL should always return zero rows affected
 END
ELSE
 BEGIN
 PRINT '[Client] rows affected by MERGE: ' + CAST(@mergeCount AS VARCHAR(100));
 END
GO

SET IDENTITY_INSERT [Client] OFF
GO
SET NOCOUNT OFF
GO
