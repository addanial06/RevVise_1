-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 10, 2025 at 11:26 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_revapp`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_motor`
--

CREATE TABLE `tbl_motor` (
  `motor_id` int(10) UNSIGNED NOT NULL,
  `motor_model` varchar(100) DEFAULT NULL,
  `motor_plate` varchar(20) DEFAULT NULL,
  `motor_owner` varchar(100) DEFAULT NULL,
  `motor_entry` varchar(300) DEFAULT NULL,
  `motor_status` varchar(20) DEFAULT NULL,
  `motor_dateIssued` date NOT NULL,
  `motor_dateResolved` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_motor`
--

INSERT INTO `tbl_motor` (`motor_id`, `motor_model`, `motor_plate`, `motor_owner`, `motor_entry`, `motor_status`, `motor_dateIssued`, `motor_dateResolved`) VALUES
(1, 'Yamaha Click 1500 v2', '998LAK', 'Badj Ajubatir', 'Engine cleaning', 'Pending', '2025-11-01', NULL);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
