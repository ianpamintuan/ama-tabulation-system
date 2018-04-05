-- phpMyAdmin SQL Dump
-- version 4.6.5.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 05, 2018 at 08:22 PM
-- Server version: 10.1.21-MariaDB
-- PHP Version: 5.6.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbama`
--

-- --------------------------------------------------------

--
-- Table structure for table `tblcategory`
--

CREATE TABLE `tblcategory` (
  `category_id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcategory`
--

INSERT INTO `tblcategory` (`category_id`, `name`) VALUES
(1, 'Indoor'),
(2, 'Outdoor');

-- --------------------------------------------------------

--
-- Table structure for table `tblcontestants`
--

CREATE TABLE `tblcontestants` (
  `contestant_id` int(11) NOT NULL,
  `first_name` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `title` varchar(255) NOT NULL,
  `event_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcontestants`
--

INSERT INTO `tblcontestants` (`contestant_id`, `first_name`, `last_name`, `title`, `event_id`) VALUES
(5, 'John', 'Doe', 'Mr', 1),
(9, 'Adam', 'Campbell', 'Mr', 1),
(10, 'Kevin', 'Coleman', 'Mr', 1),
(11, 'Owen', 'Paul', 'Mr', 1),
(12, 'Corey', 'Taylor', 'Mr', 1),
(14, 'Anne', 'Brown', 'Ms', 1),
(16, 'Sophie', 'Young', 'Ms', 1),
(17, 'Vanessa', 'Mills', 'Ms', 1),
(18, 'Sarah', 'Jones', 'Ms', 1),
(19, 'Zoe', 'Kelly', 'Ms', 1);

-- --------------------------------------------------------

--
-- Table structure for table `tblcriterias`
--

CREATE TABLE `tblcriterias` (
  `criteria_id` int(11) NOT NULL,
  `criteria_name` varchar(255) NOT NULL,
  `percentage` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcriterias`
--

INSERT INTO `tblcriterias` (`criteria_id`, `criteria_name`, `percentage`) VALUES
(1, 'Personality', '25'),
(2, 'Uniqueness/Creativity/Style of Attire', '35'),
(3, 'Poise and Bearing', '30'),
(4, 'Audience Impact', '10');

-- --------------------------------------------------------

--
-- Table structure for table `tblcriteria_categories`
--

CREATE TABLE `tblcriteria_categories` (
  `criteria_category_id` int(11) NOT NULL,
  `criteria_category_name` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblcriteria_categories`
--

INSERT INTO `tblcriteria_categories` (`criteria_category_id`, `criteria_category_name`) VALUES
(1, 'Fantasy Attire'),
(2, 'Talent'),
(3, 'Swimwear'),
(4, 'Casual Wear'),
(5, 'Question and Answer');

-- --------------------------------------------------------

--
-- Table structure for table `tblevents`
--

CREATE TABLE `tblevents` (
  `event_id` int(11) NOT NULL,
  `event_name` varchar(255) NOT NULL,
  `event_description` varchar(255) DEFAULT NULL,
  `event_date` varchar(255) NOT NULL,
  `has_criteria` int(1) NOT NULL DEFAULT '0',
  `is_pageant` int(1) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblevents`
--

INSERT INTO `tblevents` (`event_id`, `event_name`, `event_description`, `event_date`, `has_criteria`, `is_pageant`) VALUES
(1, 'Mr and Miss AMA', 'Mr and Miss AMA', '3/29/2018', 1, 1),
(5, 'Basketball 2018', 'Basketball', '3/29/2018', 0, 0),
(6, 'Volleyball 2018', 'Volleyball', '3/30/2018', 0, 0),
(7, 'Mr and Ms AMA 2019', 'Mr and Ms AMA 2019', '1/31/2019', 0, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tblmatches`
--

CREATE TABLE `tblmatches` (
  `match_id` int(11) NOT NULL,
  `event_id` int(11) DEFAULT NULL,
  `team_a` varchar(255) NOT NULL,
  `team_b` varchar(255) NOT NULL,
  `a_score` varchar(3) NOT NULL DEFAULT '0',
  `b_score` varchar(3) NOT NULL DEFAULT '0',
  `a_fouls` varchar(3) NOT NULL DEFAULT '0',
  `b_fouls` varchar(3) NOT NULL DEFAULT '0',
  `winner` varchar(255) DEFAULT NULL,
  `mvp` varchar(255) DEFAULT NULL,
  `status` varchar(255) NOT NULL DEFAULT 'Pending'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblmatches`
--

INSERT INTO `tblmatches` (`match_id`, `event_id`, `team_a`, `team_b`, `a_score`, `b_score`, `a_fouls`, `b_fouls`, `winner`, `mvp`, `status`) VALUES
(13, 5, 'LA Lakers', 'Golden State Warriors', '40', '32', '1', '1', 'LA Lakers', 'Kobe Bryant', 'Finished'),
(14, 5, 'Golden State Warriors', 'LA Lakers', '3', '0', '0', '0', 'Golden State Warriors', 'Stephen Curry', 'Finished'),
(15, 5, 'LA Lakers', 'Golden State Warriors', '39', '17', '1', '2', 'LA Lakers', 'Brandon Ingram', 'Finished');

-- --------------------------------------------------------

--
-- Table structure for table `tblplayers`
--

CREATE TABLE `tblplayers` (
  `player_id` int(11) NOT NULL,
  `first_name` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `team_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblplayers`
--

INSERT INTO `tblplayers` (`player_id`, `first_name`, `last_name`, `team_id`) VALUES
(4, 'Kobe', 'Bryant', 1),
(5, 'Stephen', 'Curry', 5),
(6, 'Brandon', 'Ingram', 1),
(7, 'Lonzo', 'Ball', 1),
(8, 'Kyle', 'Kuzma', 1),
(9, 'Julius', 'Randle', 1),
(10, 'Klay', 'Thompson', 5),
(11, 'Kevin', 'Durant', 5),
(12, 'Draymond', 'Green', 5),
(13, 'JaVale', 'McGee', 5);

-- --------------------------------------------------------

--
-- Table structure for table `tblplayerscores`
--

CREATE TABLE `tblplayerscores` (
  `playerscore_id` int(11) NOT NULL,
  `player_id` int(11) NOT NULL,
  `team_id` int(11) NOT NULL,
  `match_id` int(11) NOT NULL,
  `points` int(11) NOT NULL DEFAULT '0',
  `fouls` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblplayerscores`
--

INSERT INTO `tblplayerscores` (`playerscore_id`, `player_id`, `team_id`, `match_id`, `points`, `fouls`) VALUES
(11, 4, 1, 13, 11, 1),
(12, 6, 1, 13, 8, 1),
(13, 7, 1, 13, 4, 0),
(14, 8, 1, 13, 9, 1),
(15, 9, 1, 13, 8, 3),
(16, 5, 5, 13, 9, 2),
(17, 10, 5, 13, 8, 1),
(18, 11, 5, 13, 9, 0),
(19, 12, 5, 13, 4, 3),
(20, 13, 5, 13, 2, 1),
(21, 5, 5, 14, 3, 0),
(22, 10, 5, 14, 0, 0),
(23, 11, 5, 14, 0, 0),
(24, 12, 5, 14, 0, 0),
(25, 13, 5, 14, 0, 0),
(26, 4, 1, 14, 0, 0),
(27, 6, 1, 14, 0, 0),
(28, 7, 1, 14, 0, 0),
(29, 8, 1, 14, 0, 0),
(30, 9, 1, 14, 0, 0),
(51, 4, 1, 15, 11, 0),
(52, 6, 1, 15, 12, 0),
(53, 7, 1, 15, 4, 0),
(54, 8, 1, 15, 8, 0),
(55, 9, 1, 15, 4, 1),
(56, 5, 5, 15, 4, 0),
(57, 10, 5, 15, 3, 0),
(58, 11, 5, 15, 6, 0),
(59, 12, 5, 15, 2, 2),
(60, 13, 5, 15, 2, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tblscores`
--

CREATE TABLE `tblscores` (
  `score_id` int(11) NOT NULL,
  `event_id` int(11) NOT NULL,
  `judge_id` int(11) DEFAULT NULL,
  `criteria_id` int(11) DEFAULT NULL,
  `category_id` int(11) NOT NULL,
  `contestant_id` int(11) DEFAULT NULL,
  `score` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblscores`
--

INSERT INTO `tblscores` (`score_id`, `event_id`, `judge_id`, `criteria_id`, `category_id`, `contestant_id`, `score`) VALUES
(801, 1, 6, 1, 1, 5, 22),
(802, 1, 6, 2, 1, 5, 23),
(803, 1, 6, 3, 1, 5, 23),
(804, 1, 6, 4, 1, 5, 8),
(805, 1, 6, 1, 2, 5, 22),
(806, 1, 6, 2, 2, 5, 31),
(807, 1, 6, 3, 2, 5, 27),
(808, 1, 6, 4, 2, 5, 4),
(809, 1, 6, 1, 3, 5, 25),
(810, 1, 6, 2, 3, 5, 30),
(811, 1, 6, 3, 3, 5, 25),
(812, 1, 6, 4, 3, 5, 3),
(813, 1, 6, 1, 4, 5, 23),
(814, 1, 6, 2, 4, 5, 30),
(815, 1, 6, 3, 4, 5, 26),
(816, 1, 6, 4, 4, 5, 7),
(817, 1, 6, 1, 5, 5, 23),
(818, 1, 6, 2, 5, 5, 31),
(819, 1, 6, 3, 5, 5, 23),
(820, 1, 6, 4, 5, 5, 5),
(821, 1, 6, 1, 1, 9, 23),
(822, 1, 6, 2, 1, 9, 28),
(823, 1, 6, 3, 1, 9, 28),
(824, 1, 6, 4, 1, 9, 10),
(825, 1, 6, 1, 2, 9, 23),
(826, 1, 6, 2, 2, 9, 30),
(827, 1, 6, 3, 2, 9, 26),
(828, 1, 6, 4, 2, 9, 6),
(829, 1, 6, 1, 3, 9, 24),
(830, 1, 6, 2, 3, 9, 29),
(831, 1, 6, 3, 3, 9, 28),
(832, 1, 6, 4, 3, 9, 9),
(833, 1, 6, 1, 4, 9, 23),
(834, 1, 6, 2, 4, 9, 31),
(835, 1, 6, 3, 4, 9, 28),
(836, 1, 6, 4, 4, 9, 9),
(837, 1, 6, 1, 5, 9, 20),
(838, 1, 6, 2, 5, 9, 31),
(839, 1, 6, 3, 5, 9, 27),
(840, 1, 6, 4, 5, 9, 5),
(841, 1, 6, 1, 1, 10, 22),
(842, 1, 6, 2, 1, 10, 28),
(843, 1, 6, 3, 1, 10, 28),
(844, 1, 6, 4, 1, 10, 6),
(845, 1, 6, 1, 2, 10, 20),
(846, 1, 6, 2, 2, 10, 29),
(847, 1, 6, 3, 2, 10, 21),
(848, 1, 6, 4, 2, 10, 6),
(849, 1, 6, 1, 3, 10, 22),
(850, 1, 6, 2, 3, 10, 25),
(851, 1, 6, 3, 3, 10, 25),
(852, 1, 6, 4, 3, 10, 8),
(853, 1, 6, 1, 4, 10, 21),
(854, 1, 6, 2, 4, 10, 22),
(855, 1, 6, 3, 4, 10, 26),
(856, 1, 6, 4, 4, 10, 9),
(857, 1, 6, 1, 5, 10, 23),
(858, 1, 6, 2, 5, 10, 31),
(859, 1, 6, 3, 5, 10, 26),
(860, 1, 6, 4, 5, 10, 5),
(861, 1, 6, 1, 1, 11, 20),
(862, 1, 6, 2, 1, 11, 25),
(863, 1, 6, 3, 1, 11, 25),
(864, 1, 6, 4, 1, 11, 4),
(865, 1, 6, 1, 2, 11, 20),
(866, 1, 6, 2, 2, 11, 26),
(867, 1, 6, 3, 2, 11, 23),
(868, 1, 6, 4, 2, 11, 3),
(869, 1, 6, 1, 3, 11, 20),
(870, 1, 6, 2, 3, 11, 21),
(871, 1, 6, 3, 3, 11, 27),
(872, 1, 6, 4, 3, 11, 9),
(873, 1, 6, 1, 4, 11, 20),
(874, 1, 6, 2, 4, 11, 30),
(875, 1, 6, 3, 4, 11, 26),
(876, 1, 6, 4, 4, 11, 8),
(877, 1, 6, 1, 5, 11, 22),
(878, 1, 6, 2, 5, 11, 32),
(879, 1, 6, 3, 5, 11, 26),
(880, 1, 6, 4, 5, 11, 7),
(881, 1, 6, 1, 1, 12, 24),
(882, 1, 6, 2, 1, 12, 34),
(883, 1, 6, 3, 1, 12, 28),
(884, 1, 6, 4, 1, 12, 8),
(885, 1, 6, 1, 2, 12, 24),
(886, 1, 6, 2, 2, 12, 34),
(887, 1, 6, 3, 2, 12, 29),
(888, 1, 6, 4, 2, 12, 9),
(889, 1, 6, 1, 3, 12, 23),
(890, 1, 6, 2, 3, 12, 33),
(891, 1, 6, 3, 3, 12, 28),
(892, 1, 6, 4, 3, 12, 8),
(893, 1, 6, 1, 4, 12, 24),
(894, 1, 6, 2, 4, 12, 34),
(895, 1, 6, 3, 4, 12, 29),
(896, 1, 6, 4, 4, 12, 8),
(897, 1, 6, 1, 5, 12, 23),
(898, 1, 6, 2, 5, 12, 34),
(899, 1, 6, 3, 5, 12, 28),
(900, 1, 6, 4, 5, 12, 9),
(901, 1, 6, 1, 1, 14, 23),
(902, 1, 6, 2, 1, 14, 33),
(903, 1, 6, 3, 1, 14, 28),
(904, 1, 6, 4, 1, 14, 5),
(905, 1, 6, 1, 2, 14, 22),
(906, 1, 6, 2, 2, 14, 33),
(907, 1, 6, 3, 2, 14, 29),
(908, 1, 6, 4, 2, 14, 9),
(909, 1, 6, 1, 3, 14, 23),
(910, 1, 6, 2, 3, 14, 33),
(911, 1, 6, 3, 3, 14, 28),
(912, 1, 6, 4, 3, 14, 8),
(913, 1, 6, 1, 4, 14, 23),
(914, 1, 6, 2, 4, 14, 34),
(915, 1, 6, 3, 4, 14, 28),
(916, 1, 6, 4, 4, 14, 9),
(917, 1, 6, 1, 5, 14, 23),
(918, 1, 6, 2, 5, 14, 28),
(919, 1, 6, 3, 5, 14, 28),
(920, 1, 6, 4, 5, 14, 9),
(921, 1, 6, 1, 1, 16, 23),
(922, 1, 6, 2, 1, 16, 31),
(923, 1, 6, 3, 1, 16, 27),
(924, 1, 6, 4, 1, 16, 7),
(925, 1, 6, 1, 2, 16, 21),
(926, 1, 6, 2, 2, 16, 33),
(927, 1, 6, 3, 2, 16, 28),
(928, 1, 6, 4, 2, 16, 5),
(929, 1, 6, 1, 3, 16, 21),
(930, 1, 6, 2, 3, 16, 31),
(931, 1, 6, 3, 3, 16, 28),
(932, 1, 6, 4, 3, 16, 5),
(933, 1, 6, 1, 4, 16, 21),
(934, 1, 6, 2, 4, 16, 30),
(935, 1, 6, 3, 4, 16, 26),
(936, 1, 6, 4, 4, 16, 9),
(937, 1, 6, 1, 5, 16, 20),
(938, 1, 6, 2, 5, 16, 32),
(939, 1, 6, 3, 5, 16, 29),
(940, 1, 6, 4, 5, 16, 9),
(941, 1, 6, 1, 1, 17, 24),
(942, 1, 6, 2, 1, 17, 34),
(943, 1, 6, 3, 1, 17, 29),
(944, 1, 6, 4, 1, 17, 9),
(945, 1, 6, 1, 2, 17, 23),
(946, 1, 6, 2, 2, 17, 34),
(947, 1, 6, 3, 2, 17, 28),
(948, 1, 6, 4, 2, 17, 9),
(949, 1, 6, 1, 3, 17, 24),
(950, 1, 6, 2, 3, 17, 34),
(951, 1, 6, 3, 3, 17, 28),
(952, 1, 6, 4, 3, 17, 8),
(953, 1, 6, 1, 4, 17, 22),
(954, 1, 6, 2, 4, 17, 32),
(955, 1, 6, 3, 4, 17, 29),
(956, 1, 6, 4, 4, 17, 4),
(957, 1, 6, 1, 5, 17, 22),
(958, 1, 6, 2, 5, 17, 33),
(959, 1, 6, 3, 5, 17, 25),
(960, 1, 6, 4, 5, 17, 6),
(961, 1, 6, 1, 1, 18, 21),
(962, 1, 6, 2, 1, 18, 25),
(963, 1, 6, 3, 1, 18, 24),
(964, 1, 6, 4, 1, 18, 5),
(965, 1, 6, 1, 2, 18, 21),
(966, 1, 6, 2, 2, 18, 30),
(967, 1, 6, 3, 2, 18, 25),
(968, 1, 6, 4, 2, 18, 7),
(969, 1, 6, 1, 3, 18, 22),
(970, 1, 6, 2, 3, 18, 30),
(971, 1, 6, 3, 3, 18, 26),
(972, 1, 6, 4, 3, 18, 7),
(973, 1, 6, 1, 4, 18, 21),
(974, 1, 6, 2, 4, 18, 32),
(975, 1, 6, 3, 4, 18, 29),
(976, 1, 6, 4, 4, 18, 9),
(977, 1, 6, 1, 5, 18, 23),
(978, 1, 6, 2, 5, 18, 32),
(979, 1, 6, 3, 5, 18, 27),
(980, 1, 6, 4, 5, 18, 7),
(981, 1, 6, 1, 1, 19, 24),
(982, 1, 6, 2, 1, 19, 34),
(983, 1, 6, 3, 1, 19, 29),
(984, 1, 6, 4, 1, 19, 8),
(985, 1, 6, 1, 2, 19, 24),
(986, 1, 6, 2, 2, 19, 34),
(987, 1, 6, 3, 2, 19, 29),
(988, 1, 6, 4, 2, 19, 5),
(989, 1, 6, 1, 3, 19, 22),
(990, 1, 6, 2, 3, 19, 34),
(991, 1, 6, 3, 3, 19, 29),
(992, 1, 6, 4, 3, 19, 9),
(993, 1, 6, 1, 4, 19, 20),
(994, 1, 6, 2, 4, 19, 33),
(995, 1, 6, 3, 4, 19, 28),
(996, 1, 6, 4, 4, 19, 5),
(997, 1, 6, 1, 5, 19, 24),
(998, 1, 6, 2, 5, 19, 34),
(999, 1, 6, 3, 5, 19, 28),
(1000, 1, 6, 4, 5, 19, 9),
(1001, 1, 8, 1, 1, 5, 20),
(1002, 1, 8, 2, 1, 5, 30),
(1003, 1, 8, 3, 1, 5, 25),
(1004, 1, 8, 4, 1, 5, 8),
(1005, 1, 8, 1, 2, 5, 20),
(1006, 1, 8, 2, 2, 5, 32),
(1007, 1, 8, 3, 2, 5, 30),
(1008, 1, 8, 4, 2, 5, 9),
(1009, 1, 8, 1, 3, 5, 22),
(1010, 1, 8, 2, 3, 5, 30),
(1011, 1, 8, 3, 3, 5, 22),
(1012, 1, 8, 4, 3, 5, 9),
(1013, 1, 8, 1, 4, 5, 22),
(1014, 1, 8, 2, 4, 5, 32),
(1015, 1, 8, 3, 4, 5, 27),
(1016, 1, 8, 4, 4, 5, 9),
(1017, 1, 8, 1, 5, 5, 22),
(1018, 1, 8, 2, 5, 5, 32),
(1019, 1, 8, 3, 5, 5, 22),
(1020, 1, 8, 4, 5, 5, 10),
(1021, 1, 8, 1, 1, 9, 22),
(1022, 1, 8, 2, 1, 9, 30),
(1023, 1, 8, 3, 1, 9, 27),
(1024, 1, 8, 4, 1, 9, 8),
(1025, 1, 8, 1, 2, 9, 22),
(1026, 1, 8, 2, 2, 9, 32),
(1027, 1, 8, 3, 2, 9, 29),
(1028, 1, 8, 4, 2, 9, 9),
(1029, 1, 8, 1, 3, 9, 20),
(1030, 1, 8, 2, 3, 9, 28),
(1031, 1, 8, 3, 3, 9, 27),
(1032, 1, 8, 4, 3, 9, 10),
(1033, 1, 8, 1, 4, 9, 22),
(1034, 1, 8, 2, 4, 9, 32),
(1035, 1, 8, 3, 4, 9, 26),
(1036, 1, 8, 4, 4, 9, 9),
(1037, 1, 8, 1, 5, 9, 22),
(1038, 1, 8, 2, 5, 9, 32),
(1039, 1, 8, 3, 5, 9, 27),
(1040, 1, 8, 4, 5, 9, 10),
(1041, 1, 8, 1, 1, 10, 23),
(1042, 1, 8, 2, 1, 10, 28),
(1043, 1, 8, 3, 1, 10, 25),
(1044, 1, 8, 4, 1, 10, 9),
(1045, 1, 8, 1, 2, 10, 22),
(1046, 1, 8, 2, 2, 10, 32),
(1047, 1, 8, 3, 2, 10, 22),
(1048, 1, 8, 4, 2, 10, 8),
(1049, 1, 8, 1, 3, 10, 22),
(1050, 1, 8, 2, 3, 10, 32),
(1051, 1, 8, 3, 3, 10, 20),
(1052, 1, 8, 4, 3, 10, 10),
(1053, 1, 8, 1, 4, 10, 22),
(1054, 1, 8, 2, 4, 10, 32),
(1055, 1, 8, 3, 4, 10, 27),
(1056, 1, 8, 4, 4, 10, 8),
(1057, 1, 8, 1, 5, 10, 20),
(1058, 1, 8, 2, 5, 10, 27),
(1059, 1, 8, 3, 5, 10, 26),
(1060, 1, 8, 4, 5, 10, 9),
(1061, 1, 8, 1, 1, 11, 23),
(1062, 1, 8, 2, 1, 11, 32),
(1063, 1, 8, 3, 1, 11, 28),
(1064, 1, 8, 4, 1, 11, 9),
(1065, 1, 8, 1, 2, 11, 22),
(1066, 1, 8, 2, 2, 11, 32),
(1067, 1, 8, 3, 2, 11, 29),
(1068, 1, 8, 4, 2, 11, 9),
(1069, 1, 8, 1, 3, 11, 23),
(1070, 1, 8, 2, 3, 11, 32),
(1071, 1, 8, 3, 3, 11, 28),
(1072, 1, 8, 4, 3, 11, 8),
(1073, 1, 8, 1, 4, 11, 22),
(1074, 1, 8, 2, 4, 11, 32),
(1075, 1, 8, 3, 4, 11, 26),
(1076, 1, 8, 4, 4, 11, 10),
(1077, 1, 8, 1, 5, 11, 22),
(1078, 1, 8, 2, 5, 11, 32),
(1079, 1, 8, 3, 5, 11, 24),
(1080, 1, 8, 4, 5, 11, 8),
(1081, 1, 8, 1, 1, 12, 25),
(1082, 1, 8, 2, 1, 12, 32),
(1083, 1, 8, 3, 1, 12, 28),
(1084, 1, 8, 4, 1, 12, 9),
(1085, 1, 8, 1, 2, 12, 25),
(1086, 1, 8, 2, 2, 12, 33),
(1087, 1, 8, 3, 2, 12, 29),
(1088, 1, 8, 4, 2, 12, 9),
(1089, 1, 8, 1, 3, 12, 23),
(1090, 1, 8, 2, 3, 12, 32),
(1091, 1, 8, 3, 3, 12, 28),
(1092, 1, 8, 4, 3, 12, 10),
(1093, 1, 8, 1, 4, 12, 25),
(1094, 1, 8, 2, 4, 12, 35),
(1095, 1, 8, 3, 4, 12, 26),
(1096, 1, 8, 4, 4, 12, 10),
(1097, 1, 8, 1, 5, 12, 23),
(1098, 1, 8, 2, 5, 12, 32),
(1099, 1, 8, 3, 5, 12, 29),
(1100, 1, 8, 4, 5, 12, 9),
(1101, 1, 8, 1, 1, 14, 23),
(1102, 1, 8, 2, 1, 14, 30),
(1103, 1, 8, 3, 1, 14, 27),
(1104, 1, 8, 4, 1, 14, 9),
(1105, 1, 8, 1, 2, 14, 22),
(1106, 1, 8, 2, 2, 14, 31),
(1107, 1, 8, 3, 2, 14, 28),
(1108, 1, 8, 4, 2, 14, 9),
(1109, 1, 8, 1, 3, 14, 22),
(1110, 1, 8, 2, 3, 14, 32),
(1111, 1, 8, 3, 3, 14, 28),
(1112, 1, 8, 4, 3, 14, 8),
(1113, 1, 8, 1, 4, 14, 22),
(1114, 1, 8, 2, 4, 14, 32),
(1115, 1, 8, 3, 4, 14, 30),
(1116, 1, 8, 4, 4, 14, 10),
(1117, 1, 8, 1, 5, 14, 20),
(1118, 1, 8, 2, 5, 14, 30),
(1119, 1, 8, 3, 5, 14, 28),
(1120, 1, 8, 4, 5, 14, 9),
(1121, 1, 8, 1, 1, 16, 25),
(1122, 1, 8, 2, 1, 16, 30),
(1123, 1, 8, 3, 1, 16, 29),
(1124, 1, 8, 4, 1, 16, 9),
(1125, 1, 8, 1, 2, 16, 23),
(1126, 1, 8, 2, 2, 16, 32),
(1127, 1, 8, 3, 2, 16, 27),
(1128, 1, 8, 4, 2, 16, 9),
(1129, 1, 8, 1, 3, 16, 22),
(1130, 1, 8, 2, 3, 16, 32),
(1131, 1, 8, 3, 3, 16, 28),
(1132, 1, 8, 4, 3, 16, 9),
(1133, 1, 8, 1, 4, 16, 25),
(1134, 1, 8, 2, 4, 16, 32),
(1135, 1, 8, 3, 4, 16, 29),
(1136, 1, 8, 4, 4, 16, 9),
(1137, 1, 8, 1, 5, 16, 22),
(1138, 1, 8, 2, 5, 16, 32),
(1139, 1, 8, 3, 5, 16, 28),
(1140, 1, 8, 4, 5, 16, 9),
(1141, 1, 8, 1, 1, 17, 22),
(1142, 1, 8, 2, 1, 17, 32),
(1143, 1, 8, 3, 1, 17, 26),
(1144, 1, 8, 4, 1, 17, 8),
(1145, 1, 8, 1, 2, 17, 22),
(1146, 1, 8, 2, 2, 17, 30),
(1147, 1, 8, 3, 2, 17, 27),
(1148, 1, 8, 4, 2, 17, 9),
(1149, 1, 8, 1, 3, 17, 25),
(1150, 1, 8, 2, 3, 17, 32),
(1151, 1, 8, 3, 3, 17, 27),
(1152, 1, 8, 4, 3, 17, 9),
(1153, 1, 8, 1, 4, 17, 25),
(1154, 1, 8, 2, 4, 17, 35),
(1155, 1, 8, 3, 4, 17, 22),
(1156, 1, 8, 4, 4, 17, 9),
(1157, 1, 8, 1, 5, 17, 22),
(1158, 1, 8, 2, 5, 17, 32),
(1159, 1, 8, 3, 5, 17, 27),
(1160, 1, 8, 4, 5, 17, 9),
(1161, 1, 8, 1, 1, 18, 22),
(1162, 1, 8, 2, 1, 18, 30),
(1163, 1, 8, 3, 1, 18, 28),
(1164, 1, 8, 4, 1, 18, 7),
(1165, 1, 8, 1, 2, 18, 20),
(1166, 1, 8, 2, 2, 18, 30),
(1167, 1, 8, 3, 2, 18, 25),
(1168, 1, 8, 4, 2, 18, 9),
(1169, 1, 8, 1, 3, 18, 23),
(1170, 1, 8, 2, 3, 18, 32),
(1171, 1, 8, 3, 3, 18, 22),
(1172, 1, 8, 4, 3, 18, 8),
(1173, 1, 8, 1, 4, 18, 25),
(1174, 1, 8, 2, 4, 18, 30),
(1175, 1, 8, 3, 4, 18, 25),
(1176, 1, 8, 4, 4, 18, 10),
(1177, 1, 8, 1, 5, 18, 20),
(1178, 1, 8, 2, 5, 18, 30),
(1179, 1, 8, 3, 5, 18, 27),
(1180, 1, 8, 4, 5, 18, 8),
(1181, 1, 8, 1, 1, 19, 25),
(1182, 1, 8, 2, 1, 19, 30),
(1183, 1, 8, 3, 1, 19, 27),
(1184, 1, 8, 4, 1, 19, 8),
(1185, 1, 8, 1, 2, 19, 23),
(1186, 1, 8, 2, 2, 19, 33),
(1187, 1, 8, 3, 2, 19, 28),
(1188, 1, 8, 4, 2, 19, 10),
(1189, 1, 8, 1, 3, 19, 23),
(1190, 1, 8, 2, 3, 19, 33),
(1191, 1, 8, 3, 3, 19, 28),
(1192, 1, 8, 4, 3, 19, 9),
(1193, 1, 8, 1, 4, 19, 25),
(1194, 1, 8, 2, 4, 19, 32),
(1195, 1, 8, 3, 4, 19, 29),
(1196, 1, 8, 4, 4, 19, 9),
(1197, 1, 8, 1, 5, 19, 23),
(1198, 1, 8, 2, 5, 19, 32),
(1199, 1, 8, 3, 5, 19, 29),
(1200, 1, 8, 4, 5, 19, 10),
(1201, 1, 9, 1, 1, 5, 22),
(1202, 1, 9, 2, 1, 5, 32),
(1203, 1, 9, 3, 1, 5, 22),
(1204, 1, 9, 4, 1, 5, 8),
(1205, 1, 9, 1, 2, 5, 20),
(1206, 1, 9, 2, 2, 5, 30),
(1207, 1, 9, 3, 2, 5, 26),
(1208, 1, 9, 4, 2, 5, 9),
(1209, 1, 9, 1, 3, 5, 22),
(1210, 1, 9, 2, 3, 5, 32),
(1211, 1, 9, 3, 3, 5, 26),
(1212, 1, 9, 4, 3, 5, 7),
(1213, 1, 9, 1, 4, 5, 23),
(1214, 1, 9, 2, 4, 5, 32),
(1215, 1, 9, 3, 4, 5, 26),
(1216, 1, 9, 4, 4, 5, 8),
(1217, 1, 9, 1, 5, 5, 23),
(1218, 1, 9, 2, 5, 5, 32),
(1219, 1, 9, 3, 5, 5, 26),
(1220, 1, 9, 4, 5, 5, 8),
(1221, 1, 9, 1, 1, 9, 22),
(1222, 1, 9, 2, 1, 9, 30),
(1223, 1, 9, 3, 1, 9, 28),
(1224, 1, 9, 4, 1, 9, 8),
(1225, 1, 9, 1, 2, 9, 23),
(1226, 1, 9, 2, 2, 9, 32),
(1227, 1, 9, 3, 2, 9, 28),
(1228, 1, 9, 4, 2, 9, 8),
(1229, 1, 9, 1, 3, 9, 20),
(1230, 1, 9, 2, 3, 9, 30),
(1231, 1, 9, 3, 3, 9, 26),
(1232, 1, 9, 4, 3, 9, 9),
(1233, 1, 9, 1, 4, 9, 23),
(1234, 1, 9, 2, 4, 9, 32),
(1235, 1, 9, 3, 4, 9, 27),
(1236, 1, 9, 4, 4, 9, 7),
(1237, 1, 9, 1, 5, 9, 23),
(1238, 1, 9, 2, 5, 9, 32),
(1239, 1, 9, 3, 5, 9, 27),
(1240, 1, 9, 4, 5, 9, 8),
(1241, 1, 9, 1, 1, 10, 23),
(1242, 1, 9, 2, 1, 10, 32),
(1243, 1, 9, 3, 1, 10, 27),
(1244, 1, 9, 4, 1, 10, 8),
(1245, 1, 9, 1, 2, 10, 23),
(1246, 1, 9, 2, 2, 10, 28),
(1247, 1, 9, 3, 2, 10, 26),
(1248, 1, 9, 4, 2, 10, 8),
(1249, 1, 9, 1, 3, 10, 20),
(1250, 1, 9, 2, 3, 10, 30),
(1251, 1, 9, 3, 3, 10, 28),
(1252, 1, 9, 4, 3, 10, 9),
(1253, 1, 9, 1, 4, 10, 23),
(1254, 1, 9, 2, 4, 10, 32),
(1255, 1, 9, 3, 4, 10, 26),
(1256, 1, 9, 4, 4, 10, 8),
(1257, 1, 9, 1, 5, 10, 23),
(1258, 1, 9, 2, 5, 10, 32),
(1259, 1, 9, 3, 5, 10, 26),
(1260, 1, 9, 4, 5, 10, 9),
(1261, 1, 9, 1, 1, 11, 23),
(1262, 1, 9, 2, 1, 11, 33),
(1263, 1, 9, 3, 1, 11, 24),
(1264, 1, 9, 4, 1, 11, 9),
(1265, 1, 9, 1, 2, 11, 22),
(1266, 1, 9, 2, 2, 11, 31),
(1267, 1, 9, 3, 2, 11, 25),
(1268, 1, 9, 4, 2, 11, 8),
(1269, 1, 9, 1, 3, 11, 20),
(1270, 1, 9, 2, 3, 11, 30),
(1271, 1, 9, 3, 3, 11, 25),
(1272, 1, 9, 4, 3, 11, 9),
(1273, 1, 9, 1, 4, 11, 22),
(1274, 1, 9, 2, 4, 11, 32),
(1275, 1, 9, 3, 4, 11, 27),
(1276, 1, 9, 4, 4, 11, 8),
(1277, 1, 9, 1, 5, 11, 23),
(1278, 1, 9, 2, 5, 11, 30),
(1279, 1, 9, 3, 5, 11, 26),
(1280, 1, 9, 4, 5, 11, 8),
(1281, 1, 9, 1, 1, 12, 25),
(1282, 1, 9, 2, 1, 12, 32),
(1283, 1, 9, 3, 1, 12, 27),
(1284, 1, 9, 4, 1, 12, 10),
(1285, 1, 9, 1, 2, 12, 23),
(1286, 1, 9, 2, 2, 12, 32),
(1287, 1, 9, 3, 2, 12, 27),
(1288, 1, 9, 4, 2, 12, 10),
(1289, 1, 9, 1, 3, 12, 23),
(1290, 1, 9, 2, 3, 12, 33),
(1291, 1, 9, 3, 3, 12, 28),
(1292, 1, 9, 4, 3, 12, 9),
(1293, 1, 9, 1, 4, 12, 23),
(1294, 1, 9, 2, 4, 12, 33),
(1295, 1, 9, 3, 4, 12, 27),
(1296, 1, 9, 4, 4, 12, 9),
(1297, 1, 9, 1, 5, 12, 23),
(1298, 1, 9, 2, 5, 12, 32),
(1299, 1, 9, 3, 5, 12, 27),
(1300, 1, 9, 4, 5, 12, 9),
(1301, 1, 9, 1, 1, 14, 23),
(1302, 1, 9, 2, 1, 14, 32),
(1303, 1, 9, 3, 1, 14, 26),
(1304, 1, 9, 4, 1, 14, 8),
(1305, 1, 9, 1, 2, 14, 22),
(1306, 1, 9, 2, 2, 14, 32),
(1307, 1, 9, 3, 2, 14, 26),
(1308, 1, 9, 4, 2, 14, 8),
(1309, 1, 9, 1, 3, 14, 22),
(1310, 1, 9, 2, 3, 14, 32),
(1311, 1, 9, 3, 3, 14, 27),
(1312, 1, 9, 4, 3, 14, 7),
(1313, 1, 9, 1, 4, 14, 22),
(1314, 1, 9, 2, 4, 14, 32),
(1315, 1, 9, 3, 4, 14, 26),
(1316, 1, 9, 4, 4, 14, 9),
(1317, 1, 9, 1, 5, 14, 23),
(1318, 1, 9, 2, 5, 14, 32),
(1319, 1, 9, 3, 5, 14, 27),
(1320, 1, 9, 4, 5, 14, 9),
(1321, 1, 9, 1, 1, 16, 23),
(1322, 1, 9, 2, 1, 16, 32),
(1323, 1, 9, 3, 1, 16, 25),
(1324, 1, 9, 4, 1, 16, 10),
(1325, 1, 9, 1, 2, 16, 23),
(1326, 1, 9, 2, 2, 16, 31),
(1327, 1, 9, 3, 2, 16, 28),
(1328, 1, 9, 4, 2, 16, 9),
(1329, 1, 9, 1, 3, 16, 22),
(1330, 1, 9, 2, 3, 16, 32),
(1331, 1, 9, 3, 3, 16, 26),
(1332, 1, 9, 4, 3, 16, 9),
(1333, 1, 9, 1, 4, 16, 22),
(1334, 1, 9, 2, 4, 16, 32),
(1335, 1, 9, 3, 4, 16, 27),
(1336, 1, 9, 4, 4, 16, 8),
(1337, 1, 9, 1, 5, 16, 25),
(1338, 1, 9, 2, 5, 16, 32),
(1339, 1, 9, 3, 5, 16, 27),
(1340, 1, 9, 4, 5, 16, 8),
(1341, 1, 9, 1, 1, 17, 22),
(1342, 1, 9, 2, 1, 17, 30),
(1343, 1, 9, 3, 1, 17, 25),
(1344, 1, 9, 4, 1, 17, 8),
(1345, 1, 9, 1, 2, 17, 22),
(1346, 1, 9, 2, 2, 17, 32),
(1347, 1, 9, 3, 2, 17, 26),
(1348, 1, 9, 4, 2, 17, 9),
(1349, 1, 9, 1, 3, 17, 23),
(1350, 1, 9, 2, 3, 17, 31),
(1351, 1, 9, 3, 3, 17, 25),
(1352, 1, 9, 4, 3, 17, 9),
(1353, 1, 9, 1, 4, 17, 23),
(1354, 1, 9, 2, 4, 17, 32),
(1355, 1, 9, 3, 4, 17, 27),
(1356, 1, 9, 4, 4, 17, 8),
(1357, 1, 9, 1, 5, 17, 23),
(1358, 1, 9, 2, 5, 17, 32),
(1359, 1, 9, 3, 5, 17, 26),
(1360, 1, 9, 4, 5, 17, 8),
(1361, 1, 9, 1, 1, 18, 22),
(1362, 1, 9, 2, 1, 18, 32),
(1363, 1, 9, 3, 1, 18, 25),
(1364, 1, 9, 4, 1, 18, 9),
(1365, 1, 9, 1, 2, 18, 20),
(1366, 1, 9, 2, 2, 18, 30),
(1367, 1, 9, 3, 2, 18, 25),
(1368, 1, 9, 4, 2, 18, 8),
(1369, 1, 9, 1, 3, 18, 20),
(1370, 1, 9, 2, 3, 18, 30),
(1371, 1, 9, 3, 3, 18, 26),
(1372, 1, 9, 4, 3, 18, 9),
(1373, 1, 9, 1, 4, 18, 22),
(1374, 1, 9, 2, 4, 18, 30),
(1375, 1, 9, 3, 4, 18, 25),
(1376, 1, 9, 4, 4, 18, 9),
(1377, 1, 9, 1, 5, 18, 20),
(1378, 1, 9, 2, 5, 18, 30),
(1379, 1, 9, 3, 5, 18, 24),
(1380, 1, 9, 4, 5, 18, 8),
(1381, 1, 9, 1, 1, 19, 23),
(1382, 1, 9, 2, 1, 19, 32),
(1383, 1, 9, 3, 1, 19, 28),
(1384, 1, 9, 4, 1, 19, 9),
(1385, 1, 9, 1, 2, 19, 23),
(1386, 1, 9, 2, 2, 19, 32),
(1387, 1, 9, 3, 2, 19, 28),
(1388, 1, 9, 4, 2, 19, 9),
(1389, 1, 9, 1, 3, 19, 23),
(1390, 1, 9, 2, 3, 19, 32),
(1391, 1, 9, 3, 3, 19, 27),
(1392, 1, 9, 4, 3, 19, 9),
(1393, 1, 9, 1, 4, 19, 23),
(1394, 1, 9, 2, 4, 19, 32),
(1395, 1, 9, 3, 4, 19, 27),
(1396, 1, 9, 4, 4, 19, 8),
(1397, 1, 9, 1, 5, 19, 23),
(1398, 1, 9, 2, 5, 19, 32),
(1399, 1, 9, 3, 5, 19, 28),
(1400, 1, 9, 4, 5, 19, 9);

-- --------------------------------------------------------

--
-- Table structure for table `tblsports`
--

CREATE TABLE `tblsports` (
  `sport_id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `sport_category` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblsports`
--

INSERT INTO `tblsports` (`sport_id`, `name`, `sport_category`) VALUES
(1, 'Chess', 'Indoor'),
(2, 'Scrabble', 'Indoor'),
(3, 'Darts', 'Indoor'),
(4, 'Table Tennis', 'Indoor'),
(5, 'Word Factory', 'Indoor'),
(6, 'Basketball', 'Outdoor'),
(7, 'Volleyball', 'Outdoor'),
(8, 'Badminton', 'Outdoor'),
(9, 'Singing Competition', 'Outdoor'),
(10, 'Dance Competition', 'Outdoor'),
(11, 'asdas', 'Indoor');

-- --------------------------------------------------------

--
-- Table structure for table `tblteams`
--

CREATE TABLE `tblteams` (
  `team_id` int(11) NOT NULL,
  `team_name` varchar(255) NOT NULL,
  `sport_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblteams`
--

INSERT INTO `tblteams` (`team_id`, `team_name`, `sport_id`) VALUES
(1, 'LA Lakers', 6),
(5, 'Golden State Warriors', 6),
(6, 'AMA', 7),
(7, 'STI', 7);

-- --------------------------------------------------------

--
-- Table structure for table `tblusers`
--

CREATE TABLE `tblusers` (
  `user_id` int(11) NOT NULL,
  `first_name` varchar(255) NOT NULL,
  `middle_name` varchar(255) NOT NULL,
  `last_name` varchar(255) NOT NULL,
  `email` varchar(255) DEFAULT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` varchar(255) NOT NULL,
  `event_id` int(11) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tblusers`
--

INSERT INTO `tblusers` (`user_id`, `first_name`, `middle_name`, `last_name`, `email`, `username`, `password`, `role`, `event_id`) VALUES
(1, 'Mark Ian', 'V', 'Pamintuan', 'mark@gmail.com', 'admin', '12345678', 'Administrator', 0),
(5, 'Test', 'T', 'Test', 'Test@gmail.com', 'Test', 'TestTest', 'Scorer', 0),
(6, 'Judge', 'Jay', 'Judge', 'judge@gmail.com', 'judge', 'judgejudge', 'Judge', 1),
(8, 'Second', 'J', 'Judge', 'judge2@gmail.com', 'judge2', 'judge2judge2', 'Judge', 1),
(9, 'Third', 'J', 'Judge', 'judge3@gmail.com', 'judge3', 'judge3judge3', 'Judge', 1);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tblcategory`
--
ALTER TABLE `tblcategory`
  ADD PRIMARY KEY (`category_id`),
  ADD KEY `category_id` (`category_id`);

--
-- Indexes for table `tblcontestants`
--
ALTER TABLE `tblcontestants`
  ADD PRIMARY KEY (`contestant_id`),
  ADD KEY `event_id` (`event_id`),
  ADD KEY `contestant_id` (`contestant_id`);

--
-- Indexes for table `tblcriterias`
--
ALTER TABLE `tblcriterias`
  ADD PRIMARY KEY (`criteria_id`);

--
-- Indexes for table `tblcriteria_categories`
--
ALTER TABLE `tblcriteria_categories`
  ADD PRIMARY KEY (`criteria_category_id`);

--
-- Indexes for table `tblevents`
--
ALTER TABLE `tblevents`
  ADD PRIMARY KEY (`event_id`),
  ADD KEY `event_id` (`event_id`),
  ADD KEY `is_pageant` (`is_pageant`),
  ADD KEY `event_name` (`event_name`);

--
-- Indexes for table `tblmatches`
--
ALTER TABLE `tblmatches`
  ADD PRIMARY KEY (`match_id`),
  ADD KEY `event_id` (`event_id`),
  ADD KEY `status` (`status`),
  ADD KEY `team_a` (`team_a`),
  ADD KEY `team_b` (`team_b`);

--
-- Indexes for table `tblplayers`
--
ALTER TABLE `tblplayers`
  ADD PRIMARY KEY (`player_id`);

--
-- Indexes for table `tblplayerscores`
--
ALTER TABLE `tblplayerscores`
  ADD PRIMARY KEY (`playerscore_id`);

--
-- Indexes for table `tblscores`
--
ALTER TABLE `tblscores`
  ADD PRIMARY KEY (`score_id`),
  ADD KEY `score_id` (`score_id`),
  ADD KEY `event_id` (`event_id`),
  ADD KEY `judge_id` (`judge_id`),
  ADD KEY `criteria_id` (`criteria_id`),
  ADD KEY `contestant_id` (`contestant_id`);

--
-- Indexes for table `tblsports`
--
ALTER TABLE `tblsports`
  ADD PRIMARY KEY (`sport_id`),
  ADD KEY `sport_id` (`sport_id`),
  ADD KEY `name` (`name`),
  ADD KEY `name_2` (`name`);

--
-- Indexes for table `tblteams`
--
ALTER TABLE `tblteams`
  ADD PRIMARY KEY (`team_id`),
  ADD KEY `team_id` (`team_id`),
  ADD KEY `team_name` (`team_name`),
  ADD KEY `sport_id` (`sport_id`);

--
-- Indexes for table `tblusers`
--
ALTER TABLE `tblusers`
  ADD PRIMARY KEY (`user_id`),
  ADD KEY `event_id` (`event_id`),
  ADD KEY `username` (`username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tblcategory`
--
ALTER TABLE `tblcategory`
  MODIFY `category_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT for table `tblcontestants`
--
ALTER TABLE `tblcontestants`
  MODIFY `contestant_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
--
-- AUTO_INCREMENT for table `tblcriterias`
--
ALTER TABLE `tblcriterias`
  MODIFY `criteria_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `tblcriteria_categories`
--
ALTER TABLE `tblcriteria_categories`
  MODIFY `criteria_category_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT for table `tblevents`
--
ALTER TABLE `tblevents`
  MODIFY `event_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT for table `tblmatches`
--
ALTER TABLE `tblmatches`
  MODIFY `match_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT for table `tblplayers`
--
ALTER TABLE `tblplayers`
  MODIFY `player_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
--
-- AUTO_INCREMENT for table `tblplayerscores`
--
ALTER TABLE `tblplayerscores`
  MODIFY `playerscore_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;
--
-- AUTO_INCREMENT for table `tblscores`
--
ALTER TABLE `tblscores`
  MODIFY `score_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1401;
--
-- AUTO_INCREMENT for table `tblsports`
--
ALTER TABLE `tblsports`
  MODIFY `sport_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT for table `tblteams`
--
ALTER TABLE `tblteams`
  MODIFY `team_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `tblusers`
--
ALTER TABLE `tblusers`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
