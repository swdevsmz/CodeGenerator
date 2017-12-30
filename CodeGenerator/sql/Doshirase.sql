CREATE TABLE IF NOT EXISTS `Doshirase` (
  `guideid` int(11) NOT NULL AUTO_INCREMENT,
  `UserShubetu` int(11) NOT NULL,
  `testmode` int(2) NOT NULL,
  `guide` text CHARACTER SET utf8 NOT NULL,
  `information` text CHARACTER SET utf8 NOT NULL,
  PRIMARY KEY (`guideid`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=5 ;