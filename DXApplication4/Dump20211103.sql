CREATE DATABASE  IF NOT EXISTS `sisstemadelibreria` /*!40100 DEFAULT CHARACTER SET utf8 */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `sisstemadelibreria`;
-- MySQL dump 10.13  Distrib 8.0.11, for Win64 (x86_64)
--
-- Host: localhost    Database: sisstemadelibreria
-- ------------------------------------------------------
-- Server version	8.0.25

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `cliente` (
  `idCliente` int NOT NULL AUTO_INCREMENT,
  `Cedula` varchar(25) DEFAULT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `Apellido` varchar(45) DEFAULT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `Municipio_idMunicipio` int NOT NULL,
  PRIMARY KEY (`idCliente`),
  UNIQUE KEY `idCliente_UNIQUE` (`idCliente`),
  KEY `fk_Cliente_Municipio1_idx` (`Municipio_idMunicipio`),
  CONSTRAINT `fk_Cliente_Municipio1` FOREIGN KEY (`Municipio_idMunicipio`) REFERENCES `municipio` (`idMunicipio`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamento`
--

DROP TABLE IF EXISTS `departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `departamento` (
  `idDepartamento` int NOT NULL,
  `Departamento` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idDepartamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamento`
--

LOCK TABLES `departamento` WRITE;
/*!40000 ALTER TABLE `departamento` DISABLE KEYS */;
INSERT INTO `departamento` VALUES (1,'Atlántico Norte'),(2,'Atlántico Sur'),(3,'Boaco'),(4,'Carazo'),(5,'Chinandega'),(6,'Chontales'),(7,'Estelí'),(8,'Granada'),(9,'Jinotega'),(10,'León'),(11,'Madriz'),(12,'Managua'),(13,'Masaya'),(14,'Matagalpa'),(15,'Nueva Segovia'),(16,'Río San Juan'),(17,'Rivas');
/*!40000 ALTER TABLE `departamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalladefactura`
--

DROP TABLE IF EXISTS `detalladefactura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `detalladefactura` (
  `idDetalladefactura` int NOT NULL AUTO_INCREMENT,
  `Detalladefacturacol` varchar(45) DEFAULT NULL,
  `Cantidadpedida` int DEFAULT NULL,
  `Preciototal` double DEFAULT NULL,
  `Factura_idFactura` int NOT NULL,
  `Producto_idProducto` int NOT NULL,
  PRIMARY KEY (`idDetalladefactura`),
  UNIQUE KEY `idDetalladefactura_UNIQUE` (`idDetalladefactura`),
  KEY `fk_Detalladefactura_Factura1_idx` (`Factura_idFactura`),
  KEY `fk_Detalladefactura_Producto1_idx` (`Producto_idProducto`),
  CONSTRAINT `fk_Detalladefactura_Factura1` FOREIGN KEY (`Factura_idFactura`) REFERENCES `factura` (`idFactura`),
  CONSTRAINT `fk_Detalladefactura_Producto1` FOREIGN KEY (`Producto_idProducto`) REFERENCES `producto` (`idProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalladefactura`
--

LOCK TABLES `detalladefactura` WRITE;
/*!40000 ALTER TABLE `detalladefactura` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalladefactura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `empresa_telefonica`
--

DROP TABLE IF EXISTS `empresa_telefonica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `empresa_telefonica` (
  `idEmpresa_telefonica` int NOT NULL AUTO_INCREMENT,
  `Empresa` varchar(45) DEFAULT NULL,
  `Prefijos` varchar(500) DEFAULT NULL,
  PRIMARY KEY (`idEmpresa_telefonica`),
  UNIQUE KEY `idEmpresa_telefonica_UNIQUE` (`idEmpresa_telefonica`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `empresa_telefonica`
--

LOCK TABLES `empresa_telefonica` WRITE;
/*!40000 ALTER TABLE `empresa_telefonica` DISABLE KEYS */;
/*!40000 ALTER TABLE `empresa_telefonica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `factura`
--

DROP TABLE IF EXISTS `factura`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `factura` (
  `idFactura` int NOT NULL AUTO_INCREMENT,
  `NoFactura` varchar(45) DEFAULT NULL,
  `Fecha` datetime DEFAULT NULL,
  `Totaldefactura` double DEFAULT NULL,
  `Cliente_idCliente` int NOT NULL,
  PRIMARY KEY (`idFactura`),
  UNIQUE KEY `idFactura_UNIQUE` (`idFactura`),
  KEY `fk_Factura_Cliente1_idx` (`Cliente_idCliente`),
  CONSTRAINT `fk_Factura_Cliente1` FOREIGN KEY (`Cliente_idCliente`) REFERENCES `cliente` (`idCliente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `factura`
--

LOCK TABLES `factura` WRITE;
/*!40000 ALTER TABLE `factura` DISABLE KEYS */;
/*!40000 ALTER TABLE `factura` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marca`
--

DROP TABLE IF EXISTS `marca`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `marca` (
  `idMarca` int NOT NULL,
  `marca` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idMarca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marca`
--

LOCK TABLES `marca` WRITE;
/*!40000 ALTER TABLE `marca` DISABLE KEYS */;
/*!40000 ALTER TABLE `marca` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `municipio`
--

DROP TABLE IF EXISTS `municipio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `municipio` (
  `idMunicipio` int NOT NULL,
  `Municipio` varchar(45) DEFAULT NULL,
  `Departamento_idDepartamento` int NOT NULL,
  PRIMARY KEY (`idMunicipio`),
  KEY `fk_Municipio_Departamento1_idx` (`Departamento_idDepartamento`),
  CONSTRAINT `fk_Municipio_Departamento1` FOREIGN KEY (`Departamento_idDepartamento`) REFERENCES `departamento` (`idDepartamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `municipio`
--

LOCK TABLES `municipio` WRITE;
/*!40000 ALTER TABLE `municipio` DISABLE KEYS */;
INSERT INTO `municipio` VALUES (1,'Bonanza',1),(2,'Mulukukú',1),(3,'Prinzapolka',1),(4,'Puerto Cabezas',1),(5,'Rosita',1),(6,'Siuna',1),(7,'Waslala',1),(8,'Waspán',1),(9,'Bluefields',2),(10,'Desembocadura de Río Grande',2),(11,'El Ayote',2),(12,'El Rama',2),(13,'El Tortuguero',2),(14,'Islas del Maíz',2),(15,'Kukra Hill',2),(16,'La Cruz de Río Grande',2),(17,'Laguna de Perlas',2),(18,'Muelle de los Bueyes',2),(19,'Nueva Guinea',2),(20,'Boaco',3),(21,'Camoapa',3),(22,'San José de los Remates',3),(23,'San Lorenzo',3),(24,'Santa Lucía',3),(25,'Teustepe',3),(26,'Diriamba',4),(27,'Dolores',4),(28,'El Rosario',4),(29,'Jinotepe',4),(30,'La Conquista',4),(31,'La Paz de Oriente',4),(32,'San Marcos',4),(33,'Santa Teresa',4),(34,'Chichigalpa',5),(35,'Chinandega',5),(36,'Cinco Pinos',5),(37,'Corinto',5),(38,'El Realejo',5),(39,'El Viejo',5),(40,'Posoltega',5),(41,'Puerto Morazán',5),(42,'San Francisco del Norte',5),(43,'San Pedro del Norte',5),(44,'Santo Tomás del Norte',5),(45,'Somotillo',5),(46,'Villanueva',5),(47,'Acoyapa',6),(48,'Comalapa',6),(49,'Cuapa',6),(50,'El Coral',6),(51,'Juigalpa',6),(52,'La Libertad',6),(53,'San Pedro de Lóvago',6),(54,'Santo Domingo',6),(55,'Santo Tomás',6),(56,'Villa Sandino',6),(57,'Condega',7),(58,'Estelí',7),(59,'La Trinidad',7),(60,'Pueblo Nuevo',7),(61,'San Juan de Limay',7),(62,'San Nicolás',7),(63,'Diriá',8),(64,'Diriomo',8),(65,'Granada',8),(66,'Nandaime',8),(67,'El Cuá',9),(68,'Jinotega',9),(69,'La Concordia',9),(70,'San José de Bocay',9),(71,'San Rafael del Norte',9),(72,'San Sebastián de Yalí',9),(73,'Santa María de Pantasma',9),(74,'Wiwilí de Jinotega',9),(75,'Achuapa',10),(76,'El Jicaral',10),(77,'El Sauce',10),(78,'La Paz Centro',10),(79,'Larreynaga',10),(80,'León',10),(81,'Nagarote',10),(82,'Quezalguaque',10),(83,'Santa Rosa del Peñón',10),(84,'Telica',10),(85,'Las Sabanas',11),(86,'Palacagüina',11),(87,'San José de Cusmapa',11),(88,'San Juan de Río Coco',11),(89,'San Lucas',11),(90,'Somoto',11),(91,'Telpaneca',11),(92,'Totogalpa',11),(93,'Yalagüina',11),(94,'Ciudad Sandino',12),(95,'El Crucero',12),(96,'Managua',12),(97,'Mateare',12),(98,'San Francisco Libre',12),(99,'San Rafael del Sur',12),(100,'Ticuantepe',12),(101,'Tipitapa',12),(102,'Villa El Carmen',12),(103,'Catarina',13),(104,'La Concepción',13),(105,'Masatepe',13),(106,'Masaya',13),(107,'Nandasmo',13),(108,'Nindirí',13),(109,'Niquinohomo',13),(110,'San Juan de Oriente',13),(111,'Tisma',13),(112,'Ciudad Darío',14),(113,'El Tuma - La Dalia',14),(114,'Esquipulas',14),(115,'Matagalpa',14),(116,'Matiguás',14),(117,'Muy Muy',14),(118,'Rancho Grande',14),(119,'Río Blanco',14),(120,'San Dionisio',14),(121,'San Isidro',14),(122,'San Ramón',14),(123,'Sébaco',14),(124,'Terrabona',14),(125,'Ciudad Antigua',15),(126,'Dipilto',15),(127,'El Jícaro',15),(128,'Jalapa',15),(129,'Macuelizo',15),(130,'Mozonte',15),(131,'Murra',15),(132,'Ocotal',15),(133,'Quilalí',15),(134,'San Fernando',15),(135,'Santa María',15),(136,'Wiwilí',15),(137,'El Almendro',16),(138,'El Castillo',16),(139,'Morrito',16),(140,'San Carlos',16),(141,'San Juan del Norte',16),(142,'San Miguelito',16),(143,'Altagracia',17),(144,'Belén',17),(145,'Buenos Aires',17),(146,'Cárdenas',17),(147,'Moyogalpa',17),(148,'Potosí',17),(149,'Rivas',17),(150,'San Jorge',17),(151,'San Juan del Sur',17),(152,'Tola',17);
/*!40000 ALTER TABLE `municipio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `permisos`
--

DROP TABLE IF EXISTS `permisos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `permisos` (
  `idPermisos` int NOT NULL,
  `Permisoscol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idPermisos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `permisos`
--

LOCK TABLES `permisos` WRITE;
/*!40000 ALTER TABLE `permisos` DISABLE KEYS */;
/*!40000 ALTER TABLE `permisos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `producto` (
  `idProducto` int NOT NULL,
  `Productoco` varchar(45) DEFAULT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  `Productocol` varchar(45) DEFAULT NULL,
  `Color` varchar(45) DEFAULT NULL,
  `Unidadenexistencia` varchar(45) DEFAULT NULL,
  `Preciodecosto` varchar(45) DEFAULT NULL,
  `Preciodeventa` varchar(45) DEFAULT NULL,
  `Marca_idMarca` int NOT NULL,
  PRIMARY KEY (`idProducto`),
  KEY `fk_Producto_Marca1_idx` (`Marca_idMarca`),
  CONSTRAINT `fk_Producto_Marca1` FOREIGN KEY (`Marca_idMarca`) REFERENCES `marca` (`idMarca`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto_has_proveedor`
--

DROP TABLE IF EXISTS `producto_has_proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `producto_has_proveedor` (
  `Producto_idProducto` int NOT NULL,
  `Proveedor_idProveedor` int NOT NULL,
  PRIMARY KEY (`Producto_idProducto`,`Proveedor_idProveedor`),
  KEY `fk_Producto_has_Proveedor_Proveedor1_idx` (`Proveedor_idProveedor`),
  KEY `fk_Producto_has_Proveedor_Producto1_idx` (`Producto_idProducto`),
  CONSTRAINT `fk_Producto_has_Proveedor_Producto1` FOREIGN KEY (`Producto_idProducto`) REFERENCES `producto` (`idProducto`),
  CONSTRAINT `fk_Producto_has_Proveedor_Proveedor1` FOREIGN KEY (`Proveedor_idProveedor`) REFERENCES `proveedor` (`idProveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto_has_proveedor`
--

LOCK TABLES `producto_has_proveedor` WRITE;
/*!40000 ALTER TABLE `producto_has_proveedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `producto_has_proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `proveedor` (
  `idProveedor` int NOT NULL,
  `Cedula` varchar(45) DEFAULT NULL,
  `Proveedor` varchar(80) DEFAULT NULL,
  `Direccion` varchar(45) DEFAULT NULL,
  `Representante` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idProveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proveedor_has_municipio`
--

DROP TABLE IF EXISTS `proveedor_has_municipio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `proveedor_has_municipio` (
  `Proveedor_idProveedor` int NOT NULL,
  `Municipio_idMunicipio` int NOT NULL,
  PRIMARY KEY (`Proveedor_idProveedor`,`Municipio_idMunicipio`),
  KEY `fk_Proveedor_has_Municipio_Municipio1_idx` (`Municipio_idMunicipio`),
  KEY `fk_Proveedor_has_Municipio_Proveedor1_idx` (`Proveedor_idProveedor`),
  CONSTRAINT `fk_Proveedor_has_Municipio_Municipio1` FOREIGN KEY (`Municipio_idMunicipio`) REFERENCES `municipio` (`idMunicipio`),
  CONSTRAINT `fk_Proveedor_has_Municipio_Proveedor1` FOREIGN KEY (`Proveedor_idProveedor`) REFERENCES `proveedor` (`idProveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor_has_municipio`
--

LOCK TABLES `proveedor_has_municipio` WRITE;
/*!40000 ALTER TABLE `proveedor_has_municipio` DISABLE KEYS */;
/*!40000 ALTER TABLE `proveedor_has_municipio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `role` (
  `idrole` int NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `idUsuario` int NOT NULL,
  PRIMARY KEY (`idrole`),
  UNIQUE KEY `idrole_UNIQUE` (`idrole`),
  KEY `fk_role_Usuario_idx` (`idUsuario`),
  CONSTRAINT `fk_role_Usuario` FOREIGN KEY (`idUsuario`) REFERENCES `usuario` (`idUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role_has_permisos`
--

DROP TABLE IF EXISTS `role_has_permisos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `role_has_permisos` (
  `idrole` int NOT NULL,
  `idPermisos` int NOT NULL,
  PRIMARY KEY (`idrole`,`idPermisos`),
  KEY `fk_role_has_Permisos_Permisos1_idx` (`idPermisos`),
  KEY `fk_role_has_Permisos_role1_idx` (`idrole`),
  CONSTRAINT `fk_role_has_Permisos_Permisos1` FOREIGN KEY (`idPermisos`) REFERENCES `permisos` (`idPermisos`),
  CONSTRAINT `fk_role_has_Permisos_role1` FOREIGN KEY (`idrole`) REFERENCES `role` (`idrole`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role_has_permisos`
--

LOCK TABLES `role_has_permisos` WRITE;
/*!40000 ALTER TABLE `role_has_permisos` DISABLE KEYS */;
/*!40000 ALTER TABLE `role_has_permisos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `telefono`
--

DROP TABLE IF EXISTS `telefono`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `telefono` (
  `idTelefono` int NOT NULL,
  `Telefono` varchar(45) DEFAULT NULL,
  `Cliente_idCliente` int NOT NULL,
  `idEmpresa_telefonica` int NOT NULL,
  `Proveedor_idProveedor` int NOT NULL,
  PRIMARY KEY (`idTelefono`),
  KEY `fk_Telefono_Cliente1_idx` (`Cliente_idCliente`),
  KEY `fk_Telefono_Empresa_telefonica1_idx` (`idEmpresa_telefonica`),
  KEY `fk_Telefono_Proveedor1_idx` (`Proveedor_idProveedor`),
  CONSTRAINT `fk_Telefono_Cliente1` FOREIGN KEY (`Cliente_idCliente`) REFERENCES `cliente` (`idCliente`),
  CONSTRAINT `fk_Telefono_Empresa_telefonica1` FOREIGN KEY (`idEmpresa_telefonica`) REFERENCES `empresa_telefonica` (`idEmpresa_telefonica`),
  CONSTRAINT `fk_Telefono_Proveedor1` FOREIGN KEY (`Proveedor_idProveedor`) REFERENCES `proveedor` (`idProveedor`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `telefono`
--

LOCK TABLES `telefono` WRITE;
/*!40000 ALTER TABLE `telefono` DISABLE KEYS */;
/*!40000 ALTER TABLE `telefono` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `usuario` (
  `idUsuario` int NOT NULL AUTO_INCREMENT,
  `Usuario` varchar(45) NOT NULL,
  `Clave` varchar(45) NOT NULL,
  PRIMARY KEY (`idUsuario`),
  UNIQUE KEY `idUsuario_UNIQUE` (`idUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-11-03  0:09:52
