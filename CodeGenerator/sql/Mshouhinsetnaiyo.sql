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
  `HanbaiHontaiTanka` decimal(21,6) DEFAULT NULL COMMENT '�̔��{�̒P��',
  `HanbaiTankaShouhizei` decimal(21,6) DEFAULT NULL COMMENT '�̔��P�������',
  `SiiresakiCD` varchar(10) DEFAULT NULL COMMENT '�d����R�[�h',
  `SiireHontaiTanka` decimal(21,6) DEFAULT NULL COMMENT '�d���{�̒P��',
  `SiireTankaShouhizei` decimal(21,6) DEFAULT NULL COMMENT '�d���P�������',
  PRIMARY KEY (`RiyoukigyouCD`,`SetAutoNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;