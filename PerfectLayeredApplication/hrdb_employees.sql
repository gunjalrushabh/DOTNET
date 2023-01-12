-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: localhost    Database: hrdb
-- ------------------------------------------------------
-- Server version	8.0.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employees` (
  `id` int NOT NULL AUTO_INCREMENT,
  `firstName` varchar(255) DEFAULT NULL,
  `lastName` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `password` varchar(25) NOT NULL,
  `deptid` int NOT NULL,
  `managerid` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_dept` (`deptid`),
  CONSTRAINT `fk_dept` FOREIGN KEY (`deptid`) REFERENCES `departments` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES (1,'Rajiv','Pande','rajiv.pande@gmail.com','Manchar','Rajiv@123',1,1),(2,'Shiv','Jadhav','Siv.kumar@gmail.com','Bhavadi','Shiv23@34',1,1),(3,'Manish','Varma','rajiv.pande@gmail.com','Manchar','Rajiv@123',1,2),(4,'Rutuja','Patil','Siv.kumar@gmail.com','Bhavadi','Shiv23@34',1,2),(5,'Kalyani','Kulkarni','rajiv.pande@gmail.com','Manchar','Rajiv@123',1,3),(6,'Sham','Jadhav','Siv.kumar@gmail.com','Bhavadi','Shiv23@34',1,2),(7,'Chaitanya','Gore','rajiv.pande@gmail.com','Manchar','Rajiv@123',1,3),(8,'Riyaz','Shaikh','Siv.kumar@gmail.com','Bhavadi','Shiv23@34',1,3),(9,'Ravindar','Singh','rajiv.pande@gmail.com','Manchar','Rajiv@123',1,2),(10,'Sham','Murthy','Siv.kumar@gmail.com','Bhavadi','Shiv23@34',1,1),(11,'Chaitanya','Pandit','rajiv.pande@gmail.com','Manchar','Rajiv@123',1,2),(12,'Randhir','Jadhav','Siv.kumar@gmail.com','Bhavadi','Shiv23@34',1,1),(13,'Gautam','Raman','ganesh.shinde@gmail.com','Karegoan','GaneshShinde56',1,2);
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-01-10 17:41:30
