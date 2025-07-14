-- MariaDB dump 10.19  Distrib 10.4.32-MariaDB, for Win64 (AMD64)
--
-- Host: localhost    Database: quiz
-- ------------------------------------------------------
-- Server version	10.4.32-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `laender`
--

DROP TABLE IF EXISTS `laender`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `laender` (
  `id_land` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(50) NOT NULL,
  `hauptstadt` varchar(50) NOT NULL,
  `flagge_img_weg` varchar(255) DEFAULT NULL,
  `kontinent` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_land`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `laender`
--

LOCK TABLES `laender` WRITE;
/*!40000 ALTER TABLE `laender` DISABLE KEYS */;
INSERT INTO `laender` VALUES (1,'Deutschland','Berlin','img/Deutschland-flag.png','Europa'),(2,'Frankreich','Paris','img/Frankreich-flag.png','Europa'),(3,'Italien','Rom','img/Italien-flag.png','Europa'),(4,'Spanien','Madrid','img/Spanien-flag.png','Europa'),(5,'Schweden','Stockholm','img/Schweden-flag.png','Europa'),(6,'China','Peking','img/China-flag.png','Asien'),(7,'Japan','Tokio','img/Japan-flag.png','Asien'),(8,'Indien','Neu-Delhi','img/Indien-flag.png','Asien'),(9,'Südkorea','Seoul','img/Südkorea-flag.png','Asien'),(10,'Türkei','Ankara','img/Türkei-flag.png','Asien'),(11,'Ägypten','Kairo','img/Ägypten-flag.png','Afrika'),(12,'Südafrika','Pretoria','img/Südafrika-flag.png','Afrika'),(13,'Nigeria','Abuja','img/Nigeria-flag.png','Afrika'),(14,'Kenia','Nairobi','img/Kenia-flag.png','Afrika'),(15,'Marokko','Rabat','img/Marokko-flag.png','Afrika');
/*!40000 ALTER TABLE `laender` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `spiel_ergebnisse`
--

DROP TABLE IF EXISTS `spiel_ergebnisse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `spiel_ergebnisse` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `spieler_name` varchar(255) DEFAULT NULL,
  `punkte` int(11) DEFAULT NULL,
  `datum` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `spieler_name` (`spieler_name`),
  CONSTRAINT `spiel_ergebnisse_ibfk_1` FOREIGN KEY (`spieler_name`) REFERENCES `spieler` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=47 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `spiel_ergebnisse`
--

LOCK TABLES `spiel_ergebnisse` WRITE;
/*!40000 ALTER TABLE `spiel_ergebnisse` DISABLE KEYS */;
/*!40000 ALTER TABLE `spiel_ergebnisse` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `spieler`
--

DROP TABLE IF EXISTS `spieler`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `spieler` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(255) NOT NULL,
  `punkten_max` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `unique_name` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `spieler`
--

LOCK TABLES `spieler` WRITE;
/*!40000 ALTER TABLE `spieler` DISABLE KEYS */;
/*!40000 ALTER TABLE `spieler` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-06-27 12:24:44
