CREATE DATABASE `login` ;
CREATE TABLE IF NOT EXISTS `login`.`users` (
  `id` int(11) NOT NULL,
  `firstname` varchar(25) NOT NULL,
  `lastname` varchar(15) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(100) NOT NULL,
  `status` tinyint(4) NOT NULL,
  `activecode` int(11) NOT NULL,
  `timestamp` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
 
ALTER TABLE `login`.`users`
  ADD PRIMARY KEY (`id`);
 
ALTER TABLE `login`.`users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;