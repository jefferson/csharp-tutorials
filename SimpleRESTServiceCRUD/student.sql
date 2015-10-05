-- Author: Davide Listello
--SUPPORTED DIALECT: MYSQL VERSION 5.x
--REASON: SQL FOR CREATE DATABSE AND STUDENT TABLE
CREATE DATABASE students_db;
CREATE USER 'wcfwebapp'@'%' IDENTIFIED BY '5SMB7936s3pVB6q';
RANT ALL ON students_db.* TO wcfwebapp@'%' IDENTIFIED BY '5SMB7936s3pVB6q';
USE students_db;

CREATE TABLE `student` (
  `RollNumber` int(11) NOT NULL,
  `Name` varchar(40) DEFAULT NULL,
  `Subject` varchar(40) DEFAULT NULL,
  PRIMARY KEY (`RollNumber`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;


INSERT INTO `students_db`.`student`(`RollNumber`,`Name`,`Subject`) VALUES (1,'Daniel','Chemistry Engineering');
INSERT INTO `students_db`.`student`(`RollNumber`,`Name`,`Subject`) VALUES (2,'Andreas','Materials Engineering');
INSERT INTO `students_db`.`student`(`RollNumber`,`Name`,`Subject`) VALUES (3,'Paul','Software Engineering');
INSERT INTO `students_db`.`student`(`RollNumber`,`Name`,`Subject`) VALUES (4,'Hanna','Music Engineering');
INSERT INTO `students_db`.`student`(`RollNumber`,`Name`,`Subject`) VALUES (5,'Laura','Aerospace Engineering');
