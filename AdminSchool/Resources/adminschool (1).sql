create database adminschool;

use adminschool

DROP TABLE IF EXISTS `escuela`;
CREATE TABLE IF NOT EXISTS `escuela` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nombre` text NOT NULL,
  `CodigoPostal` text NOT NULL,
  `Calle` text,
  `NoInt` int DEFAULT NULL,
  `NoExt` int DEFAULT NULL,
  `Colonia` text,
  `Ciudad` text,
  `Municipio` text,
  `Estado` text,
  `Pais` text,
  `Correo` text,
  `Logo` text,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `escuela` (`Id`, `Nombre`, `CodigoPostal`, `Calle`, `NoInt`, `NoExt`, `Colonia`, `Ciudad`, `Municipio`, `Estado`, `Pais`, `Correo`, `Logo`) VALUES
(1, 'escuela patito', '40709', 'x', 1, 2, 'c', 'd', 'ds', 'dd', 'dd', NULL, '285_2021 ASUS TUF Gaming - Graphite Black.jpg');

DROP TABLE IF EXISTS `estudiante`;
CREATE TABLE IF NOT EXISTS `estudiante` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nombre` text NOT NULL,
  `ApellidoPaterno` text NOT NULL,
  `ApellidoMaterno` text NOT NULL,
  `FechaNacimiento` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `Genero` enum('masculino','femenino') DEFAULT NULL,
  `Edad` int DEFAULT NULL,
  `Dirección` text NOT NULL,
  `IdGrupo` int NOT NULL,
  `Matricula` text NOT NULL,
  `NombreTutor` text NOT NULL,
  `Teléfono` varchar(10) NOT NULL,
  `Correo` text,
  `Foto` text,
  PRIMARY KEY (`Id`),
  KEY `IdGrupo` (`IdGrupo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

DROP TABLE IF EXISTS `grupo`;
CREATE TABLE IF NOT EXISTS `grupo` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nombre` text NOT NULL,
  `Grado` int NOT NULL,
  `Nivel` enum('preescolar','primaria','secundaria','preparatoria','licenciatura') DEFAULT NULL,
  `IdAsesor` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IdAsesor` (`IdAsesor`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `grupo` (`Id`, `Nombre`, `Grado`, `Nivel`, `IdAsesor`) VALUES
(1, '1°A', 1, 'primaria', 1);

DROP TABLE IF EXISTS `profesor`;
CREATE TABLE IF NOT EXISTS `profesor` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nombre` text NOT NULL,
  `ApellidoPaterno` text NOT NULL,
  `ApellidoMaterno` text NOT NULL,
  `FechaNacimiento` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `Genero` enum('masculino','femenino') DEFAULT NULL,
  `Edad` int DEFAULT NULL,
  `Dirección` text NOT NULL,
  `NumeroEmpleado` text NOT NULL,
  `IdEscuela` int NOT NULL,
  `Teléfono` varchar(10) NOT NULL,
  `Correo` text,
  `Foto` text,
  PRIMARY KEY (`Id`),
  KEY `IdEscuela` (`IdEscuela`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

INSERT INTO `profesor` (`Id`, `Nombre`, `ApellidoPaterno`, `ApellidoMaterno`, `FechaNacimiento`, `Genero`, `Edad`, `Dirección`, `NumeroEmpleado`, `IdEscuela`, `Teléfono`, `Correo`, `Foto`) VALUES
(1, 'Francisco Javier', 'Calvillo', 'Torres', '2024-11-27 22:33:39', 'masculino', 26, 'camelinas #5, el capire, coyuca de catalan, gro.', '1020352740', 1, '5584029281', 'caalvvillo2013@gmail.com', '703553.jpg');

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Nombre` text NOT NULL,
  `Apodo` text NOT NULL,
  `Password` text NOT NULL,
  `Privilegio` enum('comun','admin') DEFAULT NULL,
  `IdEscuela` int NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IdEscuela` (`IdEscuela`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

ALTER TABLE `estudiante`
  ADD CONSTRAINT `estudiante_ibfk_1` FOREIGN KEY (`IdGrupo`) REFERENCES `grupo` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `grupo`
  ADD CONSTRAINT `grupo_ibfk_1` FOREIGN KEY (`IdAsesor`) REFERENCES `profesor` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `profesor`
  ADD CONSTRAINT `profesor_ibfk_1` FOREIGN KEY (`IdEscuela`) REFERENCES `escuela` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE;

ALTER TABLE `usuario`
  ADD CONSTRAINT `usuario_ibfk_1` FOREIGN KEY (`IdEscuela`) REFERENCES `escuela` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE;