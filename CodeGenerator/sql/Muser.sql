CREATE TABLE IF NOT EXISTS `Muser` (
  `username` varchar(8) NOT NULL,
  `password` varchar(128) DEFAULT NULL,
  `BumonCD` varchar(16) DEFAULT NULL,
  `UserNameKanji` varchar(50) DEFAULT NULL,
  `UserShubetu` int(11) DEFAULT NULL,
  `RiyoukigyouCD` varchar(10) DEFAULT NULL,
  `SiiresakiCD` varchar(10) DEFAULT NULL,
  `InsertDatetime` datetime DEFAULT NULL,
  `UpdateDatetime` datetime DEFAULT NULL,
  `UpdateComputerName` int(11) DEFAULT NULL,
  `UpdateUserID` varchar(8) DEFAULT NULL,
  `DeleteFLG` int(11) DEFAULT '0',
  `HacchuuShouninKengenFLG` int(11) NOT NULL DEFAULT '0' COMMENT 'î≠íçè≥îFå†å¿ÉtÉâÉO',
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;