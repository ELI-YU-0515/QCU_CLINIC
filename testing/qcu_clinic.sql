-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 08, 2024 at 04:30 PM
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
-- Database: `qcu_clinic`
--

-- --------------------------------------------------------

--
-- Table structure for table `faculty`
--

CREATE TABLE `faculty` (
  `EmployeeID` varchar(12) NOT NULL,
  `Department` varchar(50) NOT NULL,
  `Year` varchar(4) NOT NULL,
  `Surname` varchar(30) NOT NULL,
  `Firstname` varchar(30) NOT NULL,
  `MiddleInitial` varchar(5) NOT NULL,
  `Prefix` varchar(5) NOT NULL,
  `Birthday` date NOT NULL,
  `Address` text NOT NULL,
  `PhoneNumber` varchar(11) NOT NULL,
  `Gender` varchar(8) NOT NULL,
  `Age` int(3) NOT NULL,
  `Height` int(3) NOT NULL,
  `Weight` int(3) NOT NULL,
  `BloodType` varchar(10) NOT NULL,
  `BloodPressure` varchar(10) NOT NULL,
  `Status` varchar(25) NOT NULL,
  `Nationality` varchar(50) NOT NULL,
  `Religion` varchar(50) NOT NULL,
  `Relatives` varchar(255) NOT NULL,
  `Relationship` varchar(25) NOT NULL,
  `ContactNumber` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `faculty`
--

INSERT INTO `faculty` (`EmployeeID`, `Department`, `Year`, `Surname`, `Firstname`, `MiddleInitial`, `Prefix`, `Birthday`, `Address`, `PhoneNumber`, `Gender`, `Age`, `Height`, `Weight`, `BloodType`, `BloodPressure`, `Status`, `Nationality`, `Religion`, `Relatives`, `Relationship`, `ContactNumber`) VALUES
('123456789', 'College of Engineering', '2024', 'Reyes', 'Juan Carlo', 'G', 'N/A', '1980-10-22', '123 Street. Ricanor Reyes Compound', '0942345665', 'Male', 44, 178, 280, 'O+', '150/80', 'Married', 'Natural Filipino', 'Roman Catholic', 'Paulita Reyes', 'Wife', '098843421');

-- --------------------------------------------------------

--
-- Table structure for table `staff`
--

CREATE TABLE `staff` (
  `EmployeeID` varchar(14) NOT NULL,
  `Department` varchar(50) NOT NULL,
  `Year` varchar(4) NOT NULL,
  `Surname` varchar(25) NOT NULL,
  `Firstname` varchar(25) NOT NULL,
  `MiddleInitial` varchar(25) NOT NULL,
  `Prefix` varchar(5) NOT NULL,
  `Birthday` date NOT NULL,
  `Address` text NOT NULL,
  `PhoneNumber` varchar(12) NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `Age` int(3) NOT NULL,
  `Height` int(3) NOT NULL,
  `Weight` int(3) NOT NULL,
  `BloodType` varchar(10) NOT NULL,
  `BloodPressure` varchar(10) NOT NULL,
  `Status` varchar(30) NOT NULL,
  `Nationality` varchar(50) NOT NULL,
  `Religion` varchar(50) NOT NULL,
  `Relatives` varchar(250) NOT NULL,
  `Relationship` varchar(50) NOT NULL,
  `ContactNumber` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `staff`
--

INSERT INTO `staff` (`EmployeeID`, `Department`, `Year`, `Surname`, `Firstname`, `MiddleInitial`, `Prefix`, `Birthday`, `Address`, `PhoneNumber`, `Gender`, `Age`, `Height`, `Weight`, `BloodType`, `BloodPressure`, `Status`, `Nationality`, `Religion`, `Relatives`, `Relationship`, `ContactNumber`) VALUES
('900932321', 'Utility', '2019', 'Hernandez', 'Jose', 'B', 'III', '1999-07-07', '14th Floor ABC Compound', '091234345', 'Male', 25, 178, 210, 'B', '170/80', 'Single', 'Natural Filipino', 'Baptist', 'Jake Hernandez', 'Guardian', '093123432');

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

CREATE TABLE `student` (
  `StudentID` varchar(7) NOT NULL,
  `Course` varchar(50) NOT NULL,
  `Year` varchar(4) NOT NULL,
  `Surname` varchar(30) NOT NULL,
  `Firstname` varchar(30) NOT NULL,
  `MiddleInitial` varchar(2) NOT NULL,
  `Prefix` varchar(5) NOT NULL,
  `Birthday` date NOT NULL,
  `Address` text NOT NULL,
  `PhoneNumber` varchar(12) NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `Age` int(3) NOT NULL,
  `Height` int(3) NOT NULL,
  `Weight` int(3) NOT NULL,
  `BloodType` varchar(10) NOT NULL,
  `BloodPressure` varchar(10) NOT NULL,
  `Status` varchar(25) NOT NULL,
  `Nationality` varchar(50) NOT NULL,
  `Religion` varchar(50) NOT NULL,
  `Relatives` varchar(255) NOT NULL,
  `Relationship` varchar(25) NOT NULL,
  `ContactNumber` varchar(12) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student`
--

INSERT INTO `student` (`StudentID`, `Course`, `Year`, `Surname`, `Firstname`, `MiddleInitial`, `Prefix`, `Birthday`, `Address`, `PhoneNumber`, `Gender`, `Age`, `Height`, `Weight`, `BloodType`, `BloodPressure`, `Status`, `Nationality`, `Religion`, `Relatives`, `Relationship`, `ContactNumber`) VALUES
('10-0001', '0', '2024', 'Gomez', 'Pablo', 'R', 'none', '2005-07-21', '123 ABC Compound. Kamuning Road. Marikina', '093213843', 'Male', 19, 197, 185, 'AB', '130/70', 'Single', 'Natural Filipino', 'Roman Catholic', 'Juana Gomez', 'Parent', '098012321');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `Lastname` varchar(25) NOT NULL,
  `Firstname` varchar(25) NOT NULL,
  `MI` varchar(5) NOT NULL,
  `Age` int(11) NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `Birthday` date NOT NULL,
  `Role` varchar(50) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`Lastname`, `Firstname`, `MI`, `Age`, `Gender`, `Birthday`, `Role`, `Username`, `Password`) VALUES
('Carpeso', '', 'O', 19, 'Male', '2005-06-10', 'Admin', 'kurtcarpeso', '1234');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD UNIQUE KEY `Username` (`Username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
