-- phpMyAdmin SQL Dump
-- version 4.5.4.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Jul 31, 2017 at 06:24 AM
-- Server version: 5.7.11
-- PHP Version: 5.6.18

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `taskingben`
--

-- --------------------------------------------------------

--
-- Table structure for table `groups`
--

CREATE TABLE `groups` (
  `Id` int(11) NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Description` varchar(100) DEFAULT NULL,
  `Id_user` int(11) DEFAULT NULL COMMENT 'Creator of the group'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `groups`
--

INSERT INTO `groups` (`Id`, `Name`, `Description`, `Id_user`) VALUES
(17, 'Marioara', NULL, 22),
(18, '32f2qf', NULL, 22),
(19, 's', NULL, 22),
(20, 'fafa', NULL, 22),
(21, 'a3rqadf', NULL, 22),
(22, 'sa', NULL, 22),
(23, 'na', NULL, 22),
(24, 'test123', NULL, 22),
(25, 'test1234', NULL, 22),
(26, '1f1rf1f1', NULL, 22),
(27, 'asd', 'asdsad', 22),
(28, '2t2f2', NULL, 22),
(29, 'h3g23', NULL, 22),
(30, 'asdsad', NULL, 22),
(31, 'asfaf', NULL, 22),
(32, 'Test1', NULL, 22),
(33, 'testgfestge', NULL, 22),
(34, '3tgq23gg q32g', NULL, 22),
(35, 'r12rf2q3qt', NULL, 22),
(36, '234141', NULL, 22),
(37, '12313', NULL, 22),
(38, '2134521r12', NULL, 22),
(39, '12312414', NULL, 22),
(40, '21342153125', NULL, 22),
(41, '23d23d', NULL, 22),
(42, 'asfafa', NULL, 22),
(43, 'Vama Veche ', NULL, 22),
(44, 'asd13d2', NULL, 22),
(45, 'Vama Veche 2', NULL, 22),
(46, 'Vama veche e tare', NULL, 22),
(47, 'asdf2f', '', 22),
(48, 'g423g3gh2hg', NULL, 22),
(49, '3g2314g3f3 f4324f32f23f', NULL, 22),
(50, 'Vama Veche merge', NULL, 22),
(51, 'f2f2f2', NULL, 22),
(52, 'test23', NULL, 22),
(53, 'test2343', NULL, 22),
(54, 'test2343234', NULL, 22),
(55, 'Scoala', 'Nu imi place', 22),
(56, 'sdafadsfas', NULL, 22),
(57, 'safaFAfA', NULL, 22),
(58, 'SDAFASF', NULL, 22),
(59, 'cacas', NULL, 22),
(60, 'Vama Veche e tares', '17 Octombrie 2017', 22),
(61, 'sadfsafsdafsasdf', NULL, 22),
(62, 'cacasfsf', NULL, 22),
(63, 'sadfsagasgsfds', NULL, 22),
(64, 'sdfasfsadfg', NULL, 22),
(65, 'Alex 2', NULL, 22),
(66, 'asdfasfasdf', NULL, 22),
(67, 'asdfsafsaf', NULL, 22),
(68, 'Muie la saraci', NULL, 22),
(69, 'Muie la toti saraci din lume ba gheroger', NULL, 22),
(70, 'asdf2f2', NULL, 22),
(71, 'mamaliga', NULL, 22),
(72, 'cu malai', NULL, 22),
(73, 'si sare', NULL, 22),
(74, 'ca la bunica', NULL, 22),
(75, 'asfsf', 'asfaf', 22),
(76, 'asdadasd', 'a', 22),
(77, 'asdadasdf34f  g3wgy43g', 'a', 22);

-- --------------------------------------------------------

--
-- Table structure for table `group_user`
--

CREATE TABLE `group_user` (
  `Id_group` int(11) NOT NULL,
  `Id_user` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `group_user`
--

INSERT INTO `group_user` (`Id_group`, `Id_user`) VALUES
(17, 22),
(18, 22),
(19, 22),
(20, 22),
(21, 22),
(22, 22),
(23, 22),
(24, 22),
(25, 22),
(26, 22),
(27, 22),
(28, 22),
(29, 22),
(30, 22),
(31, 22),
(32, 22),
(33, 22),
(34, 22),
(35, 22),
(36, 22),
(37, 22),
(38, 22),
(39, 22),
(40, 22),
(41, 22),
(42, 22),
(43, 22),
(44, 22),
(45, 22),
(46, 22),
(47, 22),
(48, 22),
(49, 22),
(50, 22),
(51, 22),
(52, 22),
(53, 22),
(54, 22),
(55, 22),
(56, 22),
(57, 22),
(58, 22),
(59, 22),
(60, 22),
(61, 22),
(62, 22),
(63, 22),
(64, 22),
(65, 22),
(66, 22),
(67, 22),
(68, 22),
(69, 22),
(70, 22),
(71, 22),
(72, 22),
(73, 22),
(74, 22),
(75, 22),
(76, 22),
(77, 22);

-- --------------------------------------------------------

--
-- Table structure for table `notes`
--

CREATE TABLE `notes` (
  `Id` int(11) NOT NULL,
  `Id_user` int(11) NOT NULL,
  `Title` varchar(50) NOT NULL,
  `Subtitle` varchar(50) NOT NULL,
  `Description` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `notes`
--

INSERT INTO `notes` (`Id`, `Id_user`, `Title`, `Subtitle`, `Description`) VALUES
(16, 4, 'Test', '', ''),
(17, 4, 'Test1', 'Descriere1', ''),
(18, 4, 'Test1', 'Descriere1', '    test test test!');

-- --------------------------------------------------------

--
-- Table structure for table `tasks`
--

CREATE TABLE `tasks` (
  `Id` int(11) NOT NULL,
  `Id_user` int(11) DEFAULT NULL,
  `Id_group` int(11) DEFAULT NULL,
  `title` varchar(1000) NOT NULL,
  `description` varchar(10000) NOT NULL,
  `date` varchar(100) NOT NULL,
  `dateHours` varchar(100) NOT NULL,
  `dateMinutes` varchar(1000) NOT NULL,
  `schedule` varchar(100) NOT NULL,
  `reminderHours` varchar(100) NOT NULL,
  `reminderMinutes` varchar(100) NOT NULL,
  `checked` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `tasks`
--

INSERT INTO `tasks` (`Id`, `Id_user`, `Id_group`, `title`, `description`, `date`, `dateHours`, `dateMinutes`, `schedule`, `reminderHours`, `reminderMinutes`, `checked`) VALUES
(408, 28, NULL, 's', 's', '7/27/2017', '', '', 'Once', '', '', 0),
(409, 28, NULL, 'l', 'l', '7/27/2017', '', '', 'Once', '', '', 0),
(468, NULL, 1, 'Task group', 'Desscriere', '', '', '', '', '', '', 1),
(471, 29, NULL, 'ASA', 'DASD', '7/30/2017', '', '', 'Once', '', '', 0),
(492, 0, 67, 'asdff', '', '7/31/2017', '', '', 'Once', '', '', 0),
(496, 22, 0, 'ca', '', '7/31/2017', '', '', 'Once', '', '', 0),
(497, 22, 0, 'na', '', '7/31/2017', '', '', 'Once', '', '', 0),
(498, 22, 0, 'ha', '', '7/31/2017', '', '', 'Once', '', '', 0),
(499, 22, 0, 'cas', '', '7/31/2017', '', '', 'Once', '', '', 0);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `Id` int(11) NOT NULL,
  `FirstName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`Id`, `FirstName`, `LastName`, `Email`, `Password`) VALUES
(22, 'Alex', 'Poescu', 'a', '$2a$10$/PBYX/yx7RnObQnZTpqYEOnCmaDDjIaG7t9.eLZC0/fkSzMNDNC9.'),
(23, 'x', 'x', 'x', '$2a$10$b3nNVc5erYOf2y.khgiAiem5.e8iIV3L5VbErrpApFPSbJjAA9XAa'),
(24, 'Mamaligutza@.', 'Mamaligutza@.', 'Mamaligutza@.', '$2a$10$2IZabPlgxs8lSBZd7xJmxOXGHreYJkYS/qXv4EiNlEggI.8x2K1he'),
(25, 'maca', 'caca', 'eee@y.', '$2a$10$krEyuFhyAfIPl06Vcxd2a.wRqORdDLnbeg4jTRug0VmXGLQXPxoEy'),
(26, 'Bencheas', 'Alexs', 'as', '$2a$10$wcLehbQvytvNQiRmyA79F.OCDDJLK1K3oQ61Z77bAWpGlBCW3/eJO'),
(27, 'Raluca ', 'Corbos', 'raluca.corbos@yahoo.com', '$2a$10$BxoaxAwvaLY6/w61NwAesuoLfaPf7uO5lvtTppVWVHjnRf7UI.FKC'),
(28, 'sadsadads', 'asdafdsaf', 'a@a.a', '$2a$10$uovAe113trQg8HbQuJuV8eaRtcBqpkYLRM8fC9OX1oW0OxFNeC5RS'),
(29, 'xxx', 'xasx', 'AAAAAAAAAAA@AAAA.', '$2a$10$x.3H/LrGTNztxXuomTVZBuskHf489eNC.I8fzseLSU88rONzruqMG'),
(30, 's', 's', 'alex@yahoo.com', '$2a$10$U9H/nKZHFoZREvUSRjBEMufy07uYduYYr6shJm.cT.r/OdRb.z0LW');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `groups`
--
ALTER TABLE `groups`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `group_user`
--
ALTER TABLE `group_user`
  ADD PRIMARY KEY (`Id_group`,`Id_user`);

--
-- Indexes for table `notes`
--
ALTER TABLE `notes`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `tasks`
--
ALTER TABLE `tasks`
  ADD PRIMARY KEY (`Id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `groups`
--
ALTER TABLE `groups`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=78;
--
-- AUTO_INCREMENT for table `notes`
--
ALTER TABLE `notes`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT for table `tasks`
--
ALTER TABLE `tasks`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=510;
--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
