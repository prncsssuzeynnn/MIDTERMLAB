-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 06, 2024 at 12:34 PM
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
-- Database: `midtermlab_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `studentgrades`
--

CREATE TABLE `studentgrades` (
  `record_id` int(11) NOT NULL,
  `student_id` int(11) DEFAULT NULL,
  `midterm_grade` float DEFAULT NULL,
  `final_grade` float DEFAULT NULL,
  `overall_grade` float GENERATED ALWAYS AS (if(`midterm_grade` is not null and `final_grade` is not null,(`midterm_grade` + `final_grade`) / 2,NULL)) VIRTUAL,
  `status` enum('PASSED','FAILED','UD') GENERATED ALWAYS AS (if(`overall_grade` >= 75,'PASSED',if(`overall_grade` is null,'UD','FAILED'))) VIRTUAL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `student_id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `gender` enum('MALE','FEMALE','OTHER') NOT NULL,
  `contact_number` varchar(15) DEFAULT NULL,
  `department` enum('ENGINEERING','INFORMATION TECHNOLOGY','COMPUTER SCIENCE','INFORMATION SYSTEM') NOT NULL,
  `user_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `studentsubjects`
--

CREATE TABLE `studentsubjects` (
  `student_subject_id` int(11) NOT NULL,
  `student_id` int(11) DEFAULT NULL,
  `subject_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `subject_id` int(11) NOT NULL,
  `subject_code` varchar(50) NOT NULL,
  `subject_name` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `subject_initialgrade`
--

CREATE TABLE `subject_initialgrade` (
  `id` int(11) NOT NULL,
  `student_id` int(11) DEFAULT NULL,
  `subject_id` int(11) DEFAULT NULL,
  `midterm_grade` double DEFAULT NULL,
  `final_grade` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `username` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `user_type` enum('ADMIN','STUDENT') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `studentgrades`
--
ALTER TABLE `studentgrades`
  ADD PRIMARY KEY (`record_id`),
  ADD KEY `student_id` (`student_id`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`student_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexes for table `studentsubjects`
--
ALTER TABLE `studentsubjects`
  ADD PRIMARY KEY (`student_subject_id`),
  ADD KEY `student_id` (`student_id`),
  ADD KEY `subject_id` (`subject_id`);

--
-- Indexes for table `subjects`
--
ALTER TABLE `subjects`
  ADD PRIMARY KEY (`subject_id`),
  ADD UNIQUE KEY `subject_code` (`subject_code`);

--
-- Indexes for table `subject_initialgrade`
--
ALTER TABLE `subject_initialgrade`
  ADD PRIMARY KEY (`id`),
  ADD KEY `student_id` (`student_id`),
  ADD KEY `subject_id` (`subject_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `studentgrades`
--
ALTER TABLE `studentgrades`
  MODIFY `record_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `student_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `studentsubjects`
--
ALTER TABLE `studentsubjects`
  MODIFY `student_subject_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `subjects`
--
ALTER TABLE `subjects`
  MODIFY `subject_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `subject_initialgrade`
--
ALTER TABLE `subject_initialgrade`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `studentgrades`
--
ALTER TABLE `studentgrades`
  ADD CONSTRAINT `studentgrades_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`);

--
-- Constraints for table `students`
--
ALTER TABLE `students`
  ADD CONSTRAINT `students_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`);

--
-- Constraints for table `studentsubjects`
--
ALTER TABLE `studentsubjects`
  ADD CONSTRAINT `studentsubjects_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`),
  ADD CONSTRAINT `studentsubjects_ibfk_2` FOREIGN KEY (`subject_id`) REFERENCES `subjects` (`subject_id`);

--
-- Constraints for table `subject_initialgrade`
--
ALTER TABLE `subject_initialgrade`
  ADD CONSTRAINT `subject_initialgrade_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`),
  ADD CONSTRAINT `subject_initialgrade_ibfk_2` FOREIGN KEY (`subject_id`) REFERENCES `subjects` (`subject_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
