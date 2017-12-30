CREATE TABLE IF NOT EXISTS `Msiiresakihatsuban` (
  `SiiresakiCD` varchar(10) NOT NULL,
  `RenbanName` varchar(50) NOT NULL,
  `Settoji` varchar(3) DEFAULT NULL,
  `Renban` int(11) DEFAULT NULL,
  PRIMARY KEY (`SiiresakiCD`,`RenbanName`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;