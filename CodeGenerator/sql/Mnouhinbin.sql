CREATE TABLE IF NOT EXISTS `Mnouhinbin` (
  `AutoID` int(11) NOT NULL AUTO_INCREMENT,
  `SiiresakiCD` varchar(10) DEFAULT NULL,
  `NouhinbinName` varchar(50) DEFAULT NULL,
  `InsertDatetime` datetime DEFAULT NULL,
  `UpdateDatetime` datetime DEFAULT NULL,
  `UpdateComputerName` int(11) DEFAULT NULL,
  `UpdateUserID` varchar(8) DEFAULT NULL,
  `DeleteFLG` int(11) DEFAULT '0',
  PRIMARY KEY (`AutoID`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=64 ;