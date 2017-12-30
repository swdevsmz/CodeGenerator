CREATE TABLE IF NOT EXISTS `Mshouhinsetnaiyo` (
  `RiyoukigyouCD` varchar(10) NOT NULL,
  `SetAutoNo` varchar(10) NOT NULL,
  `SetCD` varchar(10) DEFAULT NULL,
  `ShouhinCD` varchar(25) DEFAULT NULL,
  `Suuryou` int(11) DEFAULT '0',
  `InsertDatetime` datetime DEFAULT NULL,
  `UpdateDatetime` datetime DEFAULT NULL,
  `UpdateComputerName` int(11) DEFAULT NULL,
  `UpdateUserID` varchar(8) DEFAULT NULL,
  `DeleteFLG` int(11) DEFAULT '0',
  `HanbaiHontaiTanka` decimal(21,6) DEFAULT NULL COMMENT '販売本体単価',
  `HanbaiTankaShouhizei` decimal(21,6) DEFAULT NULL COMMENT '販売単価消費税',
  `SiiresakiCD` varchar(10) DEFAULT NULL COMMENT '仕入先コード',
  `SiireHontaiTanka` decimal(21,6) DEFAULT NULL COMMENT '仕入本体単価',
  `SiireTankaShouhizei` decimal(21,6) DEFAULT NULL COMMENT '仕入単価消費税',
  PRIMARY KEY (`RiyoukigyouCD`,`SetAutoNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;