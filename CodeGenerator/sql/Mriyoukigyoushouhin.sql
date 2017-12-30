CREATE TABLE IF NOT EXISTS `Mriyoukigyoushouhin` (
  `RiyoukigyouCD` varchar(10) NOT NULL,
  `ShouhinCD` varchar(25) NOT NULL,
  `RiyoukigyouShouhinCD` varchar(20) DEFAULT NULL,
  `RiyoukigyouShouhinName` varchar(60) DEFAULT NULL,
  `RiyoukigyouShouhinKanaName` varchar(60) DEFAULT NULL,
  `SiiresakiCD` varchar(10) DEFAULT NULL,
  `InsertDatetime` datetime DEFAULT NULL,
  `UpdateDatetime` datetime DEFAULT NULL,
  `UpdateComputerName` int(11) DEFAULT NULL,
  `UpdateUserID` varchar(8) DEFAULT NULL,
  `DeleteFLG` int(11) DEFAULT '0',
  PRIMARY KEY (`RiyoukigyouCD`,`ShouhinCD`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;