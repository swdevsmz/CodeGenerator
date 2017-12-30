CREATE TABLE IF NOT EXISTS `Mshouhinset` (
  `RiyoukigyouCD` varchar(10) NOT NULL,
  `SetCD` varchar(10) NOT NULL,
  `SetName` varchar(60) DEFAULT NULL,
  `TokuisakiCD` varchar(10) DEFAULT NULL,
  `SetShubetu` int(11) DEFAULT '0',
  `SetKakaku` int(11) DEFAULT '0',
  `SetImage` varbinary(60000) DEFAULT NULL,
  `Tesuuryouritu` decimal(4,1) DEFAULT NULL,
  `InsertDatetime` datetime DEFAULT NULL,
  `UpdateDatetime` datetime DEFAULT NULL,
  `UpdateComputerName` int(11) DEFAULT NULL,
  `UpdateUserID` varchar(8) DEFAULT NULL,
  `DeleteFLG` int(11) DEFAULT '0',
  PRIMARY KEY (`RiyoukigyouCD`,`SetCD`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;