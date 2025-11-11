-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 11, 2025 at 01:13 PM
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
  `motor_id` int(11) NOT NULL,
  `motor_model` varchar(100) DEFAULT NULL,
  `motor_plate` varchar(20) DEFAULT NULL,
  `motor_owner` varchar(100) DEFAULT NULL,
  `motor_entry` varchar(300) DEFAULT NULL,
  `motor_status` varchar(20) DEFAULT NULL,
  `motor_dateIssued` varchar(50) NOT NULL,
  `motor_dateResolved` varchar(50) DEFAULT NULL,
  `motor_ownerdetails` varchar(100) DEFAULT NULL,
  `user_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_motor`
--

INSERT INTO `tbl_motor` (`motor_id`, `motor_model`, `motor_plate`, `motor_owner`, `motor_entry`, `motor_status`, `motor_dateIssued`, `motor_dateResolved`, `motor_ownerdetails`, `user_id`) VALUES
(1, 'MotorPro', '188811', 'Baduj', '', 'Unresolved', '11/11/2025', 'Unresolved', '09991112343221', 0),
(2, 'Click123', '887JAK', 'Jason', 'The Motor Is Running On Diseal', 'Unresolved', '11/11/2025', 'Unresolved', 'Discord', 0),
(3, 'Nmaxs', '8885JPX', 'Rodje', '170/60 Rear Tyre', 'Resolved', '11/11/2025', '11/11/2025', 'Messenger', 0),
(4, 'TEst', 'Plate No.', 'Owner', 'Entry', 'Unresolved', '11/11/2025', NULL, 'Owner Details', 1),
(5, 'Model', 'Plate No.', 'Owner', 'Entry', 'Unresolved', '11/11/2025', NULL, 'Owner Details', 1),
(6, 'Model', 'Plate No.', 'Owner', 'Entry', 'Unresolved', '11/11/2025', '', 'Owner Details', 1),
(28, 'Model', 'Plate No.', 'Owner', 'Entry', 'Unresolved', '11/11/2025', NULL, 'Owner Details', 1),
(29, 'Model', 'Plate No.', 'Owner', 'Entry', 'Unresolved', '11/11/2025', NULL, 'Owner Details', 1),
(30, 'Model', 'Plate No.', 'Owner', 'Entry', 'Unresolved', '11/11/2025', NULL, 'Owner Details', 1),
(31, 'Test', 'Plate No.', 'Owner', 'Entry', 'Unresolved', '11/11/2025', NULL, 'Owner Details', 1),
(32, 'yamaha R3', 'No plate', 'Beberky', 'oil change, \nchain rust, \nbrake fluid replace, \ncoolant flush and refill,\nthrottlebody cleaning\ninterior cleaning\n', 'Unresolved', '11/11/2025', '', 'Cebu City', 2),
(33, 'honda click', '997JPX', 'admad', 'coolant not cooling\nengine overheating\ncvt cleaning\nbelt replacement', 'Resolved', '11/11/2025', '11/11/2025', 'brown out', 2),
(34, 'vulkan 650s', '122HHHH', 'spanish', 'signal light replace', 'Unresolved', '11/11/2025', NULL, 'manila', 2),
(35, 'yahama mt10', '44444', 'brother', 'brake bleeding\npassenger platforms bent', 'Resolved', '11/11/2025', '11/11/2025', 'alphans', 2);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_users`
--

CREATE TABLE `tbl_users` (
  `user_id` int(128) UNSIGNED NOT NULL,
  `username` varchar(24) NOT NULL,
  `password` varchar(64) NOT NULL,
  `role` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_users`
--

INSERT INTO `tbl_users` (`user_id`, `username`, `password`, `role`) VALUES
(2, 'adel', 'qwer', 'User'),
(1, 'admin', '1234', 'Admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_motor`
--
ALTER TABLE `tbl_motor`
  ADD PRIMARY KEY (`motor_id`);

--
-- Indexes for table `tbl_users`
--
ALTER TABLE `tbl_users`
  ADD UNIQUE KEY `username` (`username`),
  ADD UNIQUE KEY `user_id` (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_motor`
--
ALTER TABLE `tbl_motor`
  MODIFY `motor_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=36;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
