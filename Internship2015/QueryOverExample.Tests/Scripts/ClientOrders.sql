
GO

SET NOCOUNT ON

SET IDENTITY_INSERT [ClientOrder] ON

MERGE INTO [ClientOrder] AS Target
USING (VALUES
  (1,'4716428336199','2014-09-25T07:45:34',54,93)
 ,(2,'4532900623702693','2015-01-04T02:20:51',73,4)
 ,(3,'4532453538577784','2014-08-24T16:51:17',2,14)
 ,(4,'4556374220020977','2015-05-03T00:29:57',37,15)
 ,(5,'4539403564399','2015-04-02T22:52:11',50,33)
 ,(6,'4716917385550654','2016-02-17T21:32:06',15,16)
 ,(7,'4024007196732','2016-03-27T19:13:27',42,71)
 ,(8,'4929382175720616','2015-06-28T08:00:29',37,28)
 ,(9,'4024007149582','2015-07-08T15:24:37',98,19)
 ,(10,'4716875094044','2015-11-27T21:13:34',62,50)
 ,(11,'4929283293849','2015-09-30T13:46:00',25,45)
 ,(12,'4954833048139','2015-04-01T13:14:16',82,92)
 ,(13,'4539872733780','2015-08-03T12:49:16',29,83)
 ,(14,'4929283114704101','2016-02-23T05:18:57',8,77)
 ,(15,'4556100041312115','2015-04-18T19:03:48',33,25)
 ,(16,'4716551536575789','2015-08-21T03:19:54',14,85)
 ,(17,'4716034720767926','2015-04-07T16:56:12',43,73)
 ,(18,'4532202997368502','2016-06-09T03:15:12',33,70)
 ,(19,'4929968868965078','2015-10-04T05:20:19',62,41)
 ,(20,'4929368875636681','2016-03-17T05:06:08',99,16)
 ,(21,'4532028015961014','2016-08-07T07:49:05',7,73)
 ,(22,'4556775964162553','2015-08-21T06:02:57',67,80)
 ,(23,'4707663324719973','2015-07-14T20:29:15',67,5)
 ,(24,'4539786921679','2016-03-29T19:09:45',80,73)
 ,(25,'4024007155016503','2014-11-29T15:28:56',40,68)
 ,(26,'4532438852006734','2016-03-17T04:47:53',73,26)
 ,(27,'4485386517717','2014-09-23T23:04:32',21,37)
 ,(28,'4716961126965','2014-11-07T04:38:47',23,28)
 ,(29,'4916225727750406','2015-01-30T16:43:55',14,37)
 ,(30,'4485339758568297','2016-07-03T01:36:57',1,87)
 ,(31,'4024007129853015','2016-05-24T05:01:13',96,2)
 ,(32,'4929125048310','2016-01-03T18:21:13',21,10)
 ,(33,'4024007174897040','2016-08-08T20:44:09',55,60)
 ,(34,'4024007164508573','2014-10-26T20:08:46',4,71)
 ,(35,'4916604991524','2015-10-07T12:33:19',100,70)
 ,(36,'4881308674081636','2015-10-07T21:25:59',87,75)
 ,(37,'4024007124536','2016-01-25T14:35:27',56,9)
 ,(38,'4716896892688647','2015-03-17T22:59:11',39,63)
 ,(39,'4485447452763','2014-08-28T10:46:02',62,94)
 ,(40,'4929132027620','2016-04-28T09:32:36',9,39)
 ,(41,'4485664385214514','2016-05-12T19:51:23',53,38)
 ,(42,'4716728526184','2015-08-03T18:04:04',37,41)
 ,(43,'4539203700694864','2016-01-17T04:31:59',28,81)
 ,(44,'4532344232192','2016-02-18T19:56:58',48,54)
 ,(45,'4539424442831','2015-05-31T09:40:20',16,59)
 ,(46,'4929957117381','2015-05-20T09:35:55',97,11)
 ,(47,'4916723845403','2015-02-05T11:01:35',12,29)
 ,(48,'4556875805585549','2015-06-30T03:52:25',32,17)
 ,(49,'4716522903803','2014-12-09T22:54:39',97,89)
 ,(50,'4071332973667143','2015-06-18T22:33:54',95,2)
 ,(51,'4929262462295615','2015-12-30T21:51:39',5,56)
 ,(52,'4916400985633830','2015-08-28T01:19:08',14,20)
 ,(53,'4916064381745','2015-06-30T20:01:43',39,97)
 ,(54,'4929093106472579','2015-08-31T07:35:44',6,56)
 ,(55,'4997336769016','2015-08-07T18:50:34',81,36)
 ,(56,'4485156251077778','2016-08-06T13:25:19',29,29)
 ,(57,'4539886227032798','2015-04-27T21:49:35',50,81)
 ,(58,'4024007167352300','2015-10-24T18:56:25',36,75)
 ,(59,'4916951032633','2015-05-28T09:26:08',28,72)
 ,(60,'4716771059456643','2014-12-25T20:28:11',37,3)
 ,(61,'4024007159451490','2015-02-10T04:09:05',46,88)
 ,(62,'4556668479825055','2014-09-06T02:06:11',11,29)
 ,(63,'4929830465528','2015-01-09T07:30:03',88,2)
 ,(64,'4556076112092069','2015-09-29T18:21:48',11,6)
 ,(65,'4929647318188818','2016-04-05T11:09:39',43,86)
 ,(66,'4485393056881','2016-01-11T13:43:39',54,78)
 ,(67,'4929624715706203','2015-09-27T21:45:01',55,26)
 ,(68,'4716206861897866','2015-12-07T22:28:56',47,74)
 ,(69,'4716423802611864','2016-08-13T11:34:30',43,81)
 ,(70,'4716795543851127','2016-07-22T04:55:57',51,90)
 ,(71,'4916506018974700','2015-04-23T08:51:25',33,48)
 ,(72,'4716342341168','2016-05-23T19:59:54',79,91)
 ,(73,'4539034220981949','2015-06-26T06:23:33',69,97)
 ,(74,'4024007170537665','2015-06-03T19:00:52',40,4)
 ,(75,'4485006703465','2014-10-18T06:07:45',67,10)
 ,(76,'4916095041140109','2016-01-23T09:34:48',81,52)
 ,(77,'4539534300246600','2015-06-18T18:48:49',65,26)
 ,(78,'4485846056900','2016-02-02T00:38:11',4,93)
 ,(79,'4929095033573','2014-09-14T21:32:26',31,10)
 ,(80,'4716839436190','2015-12-07T16:48:15',95,14)
 ,(81,'4556000318386182','2015-06-12T04:45:09',53,97)
 ,(82,'4916727171301','2014-09-17T04:17:43',36,74)
 ,(83,'4929496707858','2016-06-11T20:34:15',40,15)
 ,(84,'4556090467637','2016-07-12T07:38:12',39,29)
 ,(85,'4485851349050098','2015-02-03T13:23:59',52,67)
 ,(86,'4716913105976','2016-05-18T05:21:46',54,38)
 ,(87,'4807329316529','2016-08-20T21:30:18',97,97)
 ,(88,'4556477356841','2015-03-23T06:09:09',47,77)
 ,(89,'4929891405479124','2016-07-12T04:02:54',15,93)
 ,(90,'4916970172691','2015-09-03T18:09:59',42,13)
 ,(91,'4502466167203528','2015-12-18T19:05:27',18,63)
 ,(92,'4916114390848962','2016-03-08T05:04:22',6,81)
 ,(93,'4916924876821196','2015-06-18T20:36:50',24,38)
 ,(94,'4556378182023','2015-02-23T22:51:06',54,62)
 ,(95,'4485060790739','2015-03-07T13:48:26',35,52)
 ,(96,'4916873689544','2016-01-28T16:42:43',99,84)
 ,(97,'4532619048859470','2015-11-09T05:22:50',53,64)
 ,(98,'4916834281710555','2015-04-24T20:00:16',11,9)
 ,(99,'4556517607354183','2015-07-31T03:24:07',28,98)
 ,(100,'4024007199454','2016-01-30T05:29:36',69,65)
) AS Source ([ClientOrderID],[Number],[CreatedDate],[ShopID],[ClientID])
ON (Target.[ClientOrderID] = Source.[ClientOrderID])
WHEN MATCHED AND (
	NULLIF(Source.[Number], Target.[Number]) IS NOT NULL OR NULLIF(Target.[Number], Source.[Number]) IS NOT NULL OR 
	NULLIF(Source.[CreatedDate], Target.[CreatedDate]) IS NOT NULL OR NULLIF(Target.[CreatedDate], Source.[CreatedDate]) IS NOT NULL OR 
	NULLIF(Source.[ShopID], Target.[ShopID]) IS NOT NULL OR NULLIF(Target.[ShopID], Source.[ShopID]) IS NOT NULL OR 
	NULLIF(Source.[ClientID], Target.[ClientID]) IS NOT NULL OR NULLIF(Target.[ClientID], Source.[ClientID]) IS NOT NULL) THEN
 UPDATE SET
  [Number] = Source.[Number], 
  [CreatedDate] = Source.[CreatedDate], 
  [ShopID] = Source.[ShopID], 
  [ClientID] = Source.[ClientID]
WHEN NOT MATCHED BY TARGET THEN
 INSERT([ClientOrderID],[Number],[CreatedDate],[ShopID],[ClientID])
 VALUES(Source.[ClientOrderID],Source.[Number],Source.[CreatedDate],Source.[ShopID],Source.[ClientID])
WHEN NOT MATCHED BY SOURCE THEN 
 DELETE
;
GO
DECLARE @mergeError int
 , @mergeCount int
SELECT @mergeError = @@ERROR, @mergeCount = @@ROWCOUNT
IF @mergeError != 0
 BEGIN
 PRINT 'ERROR OCCURRED IN MERGE FOR [ClientOrder]. Rows affected: ' + CAST(@mergeCount AS VARCHAR(100)); -- SQL should always return zero rows affected
 END
ELSE
 BEGIN
 PRINT '[ClientOrder] rows affected by MERGE: ' + CAST(@mergeCount AS VARCHAR(100));
 END
GO

SET IDENTITY_INSERT [ClientOrder] OFF
GO
SET NOCOUNT OFF
GO

