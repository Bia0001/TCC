CREATE DATABASE  IF NOT EXISTS `sistemaacesso` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `sistemaacesso`;
-- MySQL dump 10.13  Distrib 5.6.23, for Win64 (x86_64)
--
-- Host: localhost    Database: sistemaacesso
-- ------------------------------------------------------
-- Server version	5.6.24-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `aluno`
--

DROP TABLE IF EXISTS `aluno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aluno` (
  `idAluno` int(11) NOT NULL,
  `responsavel1` varchar(45) NOT NULL,
  `responsavel2` varchar(45) DEFAULT NULL,
  `phoneResponsavel1` char(14) NOT NULL,
  `phoneResponsavel2` char(14) DEFAULT NULL,
  `idPessoaFisica` int(11) NOT NULL,
  `idProntuarioIFSP` int(11) NOT NULL,
  PRIMARY KEY (`idAluno`),
  KEY `fk_Aluno_PessoaFisica1_idx` (`idPessoaFisica`),
  KEY `fk_Aluno_ProntuarioIFSP1_idx` (`idProntuarioIFSP`),
  CONSTRAINT `fk_Aluno_PessoaFisica1` FOREIGN KEY (`idPessoaFisica`) REFERENCES `pessoafisica` (`idPessoaFisica`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Aluno_ProntuarioIFSP1` FOREIGN KEY (`idProntuarioIFSP`) REFERENCES `prontuarioifsp` (`idProntuarioIFSP`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aluno`
--

LOCK TABLES `aluno` WRITE;
/*!40000 ALTER TABLE `aluno` DISABLE KEYS */;
INSERT INTO `aluno` VALUES (5,'Gelson Livramento','Aparecida Livramento','1934917345','19992443549',5,5);
/*!40000 ALTER TABLE `aluno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `assistentealuno`
--

DROP TABLE IF EXISTS `assistentealuno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `assistentealuno` (
  `idAssistenteAluno` int(11) NOT NULL,
  `idPessoaFisica` int(11) NOT NULL,
  `idProntuarioIFSP` int(11) NOT NULL,
  PRIMARY KEY (`idAssistenteAluno`),
  KEY `fk_AssistenteAluno_PessoaFisica1_idx` (`idPessoaFisica`),
  KEY `fk_AssistenteAluno_ProntuarioIFSP1_idx` (`idProntuarioIFSP`),
  CONSTRAINT `fk_AssistenteAluno_PessoaFisica1` FOREIGN KEY (`idPessoaFisica`) REFERENCES `pessoafisica` (`idPessoaFisica`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_AssistenteAluno_ProntuarioIFSP1` FOREIGN KEY (`idProntuarioIFSP`) REFERENCES `prontuarioifsp` (`idProntuarioIFSP`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assistentealuno`
--

LOCK TABLES `assistentealuno` WRITE;
/*!40000 ALTER TABLE `assistentealuno` DISABLE KEYS */;
INSERT INTO `assistentealuno` VALUES (6,6,6);
/*!40000 ALTER TABLE `assistentealuno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `endereco`
--

DROP TABLE IF EXISTS `endereco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `endereco` (
  `idEndereco` int(11) NOT NULL,
  `cep` char(10) NOT NULL,
  `uf` char(2) NOT NULL,
  `complemento` varchar(45) DEFAULT NULL,
  `cidade` varchar(45) NOT NULL,
  `bairro` varchar(45) DEFAULT NULL,
  `numero` varchar(10) NOT NULL,
  `logradouro` varchar(45) NOT NULL,
  `idPessoaFisica` int(11) NOT NULL,
  PRIMARY KEY (`idEndereco`),
  KEY `fk_Endereco_PessoaFisica1_idx` (`idPessoaFisica`),
  CONSTRAINT `fk_Endereco_PessoaFisica1` FOREIGN KEY (`idPessoaFisica`) REFERENCES `pessoafisica` (`idPessoaFisica`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `endereco`
--

LOCK TABLES `endereco` WRITE;
/*!40000 ALTER TABLE `endereco` DISABLE KEYS */;
INSERT INTO `endereco` VALUES (5,'13360000','SP','','Capivari','Alto do Castellani','355','Vitorio Roggeri',5),(6,'13360000','SP','','Capivari','Engelho Velho','567','João da Paz',6),(7,'13360000','SP','','Capvari','Centro','33','',7);
/*!40000 ALTER TABLE `endereco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pessoafisica`
--

DROP TABLE IF EXISTS `pessoafisica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pessoafisica` (
  `idPessoaFisica` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `sobrenome` varchar(45) NOT NULL,
  `cpf` char(14) NOT NULL,
  `rg` char(12) NOT NULL,
  `email` varchar(70) DEFAULT NULL,
  `celular` char(14) DEFAULT NULL,
  `telefone` char(13) DEFAULT NULL,
  `nascimento` date NOT NULL,
  `sexo` char(1) NOT NULL,
  PRIMARY KEY (`idPessoaFisica`),
  UNIQUE KEY `cpf` (`cpf`),
  KEY `nome` (`nome`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pessoafisica`
--

LOCK TABLES `pessoafisica` WRITE;
/*!40000 ALTER TABLE `pessoafisica` DISABLE KEYS */;
INSERT INTO `pessoafisica` VALUES (5,'Jonatas','Bueno','38409147874','484697742','jonatas.livramento@gmail.com','19991735030','1934917345','1991-12-13','M'),(6,'Gustavo','Datti','48373923745','493029384','gustavo.datti@outlook.com','199837282745','1934827364','1992-10-10','M'),(7,'Eliot','Jansen','84739203948','3827493023','eliot.j@gmail.com','19973627193','1934913498','1988-02-05','M');
/*!40000 ALTER TABLE `pessoafisica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prontuarioifsp`
--

DROP TABLE IF EXISTS `prontuarioifsp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prontuarioifsp` (
  `idProntuarioIFSP` int(11) NOT NULL AUTO_INCREMENT,
  `prontuario` varchar(8) NOT NULL,
  PRIMARY KEY (`idProntuarioIFSP`),
  UNIQUE KEY `prontuario` (`prontuario`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prontuarioifsp`
--

LOCK TABLES `prontuarioifsp` WRITE;
/*!40000 ALTER TABLE `prontuarioifsp` DISABLE KEYS */;
INSERT INTO `prontuarioifsp` VALUES (5,'1320271'),(7,'1438849'),(6,'1495738');
/*!40000 ALTER TABLE `prontuarioifsp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `solicitacaosaida`
--

DROP TABLE IF EXISTS `solicitacaosaida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `solicitacaosaida` (
  `idSolicitacaoSaida` int(11) NOT NULL AUTO_INCREMENT,
  `motivo` varchar(300) NOT NULL,
  `abertura` datetime NOT NULL,
  `previsaoEncerramento` datetime NOT NULL,
  `encerramento` datetime DEFAULT NULL,
  `idAluno` int(11) NOT NULL,
  `idAssistenteAluno` int(11) NOT NULL,
  `idVigilante` int(11) DEFAULT NULL,
  `estado` varchar(15) NOT NULL,
  PRIMARY KEY (`idSolicitacaoSaida`),
  UNIQUE KEY `abertura_UNIQUE` (`abertura`),
  KEY `fk_SolicitacaoSaida_Aluno1_idx` (`idAluno`),
  KEY `fk_SolicitacaoSaida_AssistenteAluno1_idx` (`idAssistenteAluno`),
  KEY `fk_SolicitacaoSaida_Vigilante1_idx` (`idVigilante`),
  KEY `abertura` (`abertura`),
  KEY `encerramento` (`encerramento`),
  CONSTRAINT `fk_SolicitacaoSaida_Aluno1` FOREIGN KEY (`idAluno`) REFERENCES `aluno` (`idAluno`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_SolicitacaoSaida_AssistenteAluno1` FOREIGN KEY (`idAssistenteAluno`) REFERENCES `assistentealuno` (`idAssistenteAluno`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `solicitacaosaida`
--

LOCK TABLES `solicitacaosaida` WRITE;
/*!40000 ALTER TABLE `solicitacaosaida` DISABLE KEYS */;
INSERT INTO `solicitacaosaida` VALUES (4,'dor de barriga','2015-05-19 12:38:13','2015-05-19 13:23:13','2015-05-21 12:53:51',5,6,7,'Expirado'),(7,'dor de barriga','2015-05-19 12:45:55','2015-05-19 13:30:55','0001-01-01 00:00:00',5,6,NULL,'Expirado'),(8,'c','2015-05-19 12:52:33','2015-05-19 13:37:33','0001-01-01 00:00:00',5,6,0,'Expirado');
/*!40000 ALTER TABLE `solicitacaosaida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `solicitacaosaidatemp`
--

DROP TABLE IF EXISTS `solicitacaosaidatemp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `solicitacaosaidatemp` (
  `idSolicitacao` int(11) NOT NULL,
  `idAluno` int(11) NOT NULL,
  `idAssistenteAluno` int(11) NOT NULL,
  `motivo` varchar(300) NOT NULL,
  `estado` varchar(15) NOT NULL,
  `previsaoEncerramento` datetime NOT NULL,
  `abertura` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `solicitacaosaidatemp`
--

LOCK TABLES `solicitacaosaidatemp` WRITE;
/*!40000 ALTER TABLE `solicitacaosaidatemp` DISABLE KEYS */;
/*!40000 ALTER TABLE `solicitacaosaidatemp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vigilante`
--

DROP TABLE IF EXISTS `vigilante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vigilante` (
  `idVigilante` int(11) NOT NULL,
  `idPessoaFisica` int(11) NOT NULL,
  PRIMARY KEY (`idVigilante`),
  KEY `fk_Vigilante_PessoaFisica1_idx` (`idPessoaFisica`),
  CONSTRAINT `fk_Vigilante_PessoaFisica1` FOREIGN KEY (`idPessoaFisica`) REFERENCES `pessoafisica` (`idPessoaFisica`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vigilante`
--

LOCK TABLES `vigilante` WRITE;
/*!40000 ALTER TABLE `vigilante` DISABLE KEYS */;
INSERT INTO `vigilante` VALUES (7,7);
/*!40000 ALTER TABLE `vigilante` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'sistemaacesso'
--
/*!50106 SET @save_time_zone= @@TIME_ZONE */ ;
/*!50106 DROP EVENT IF EXISTS `zerarTblTemp` */;
DELIMITER ;;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;;
/*!50003 SET character_set_client  = utf8 */ ;;
/*!50003 SET character_set_results = utf8 */ ;;
/*!50003 SET collation_connection  = utf8_general_ci */ ;;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;;
/*!50003 SET @saved_time_zone      = @@time_zone */ ;;
/*!50003 SET time_zone             = 'SYSTEM' */ ;;
/*!50106 CREATE*/ /*!50117 DEFINER=`root`@`localhost`*/ /*!50106 EVENT `zerarTblTemp` ON SCHEDULE EVERY 24 HOUR STARTS '2015-05-22 00:00:00' ON COMPLETION PRESERVE ENABLE DO delete from solicitacaosaidatemp */ ;;
/*!50003 SET time_zone             = @saved_time_zone */ ;;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;;
/*!50003 SET character_set_client  = @saved_cs_client */ ;;
/*!50003 SET character_set_results = @saved_cs_results */ ;;
/*!50003 SET collation_connection  = @saved_col_connection */ ;;
DELIMITER ;
/*!50106 SET TIME_ZONE= @save_time_zone */ ;

--
-- Dumping routines for database 'sistemaacesso'
--
/*!50003 DROP PROCEDURE IF EXISTS `alterarAluno` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `alterarAluno`(
	in idPessoaFisica1 integer,
	in nome1 varchar(45),
	in sobrenome1 varchar(45),
    in sexo1 char(1),
	in cpf1 char(14),
	in rg1 char(12),
	in email1 varchar(70),
	in celular1 char(14),
	in telefone1 char(13),
	in nascimento1 datetime,
	in cep1 char(10),
	in uf1 char(2),
	in complemento1 varchar(45),
	in cidade1 varchar(45),
	in bairro1 varchar(45),
	in numero1 varchar(10),
	in logradouro1 varchar(45),
	in responsavel11 varchar(45),
	in responsavel21 varchar(45),
	in phoneResponsavel11 char(14),
	in phoneResponsavel21 char(14),
	in prontuario1 varchar(8))
BEGIN
	BEGIN
		DECLARE excessao INT DEFAULT 0;
		DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1; 
		START TRANSACTION;
		UPDATE pessoafisica SET nome = nome1, sobrenome = sobrenome1, sexo = sexo1, cpf = cpf1, rg = rg1,
        email = email1, celular = celular1, telefone = telefone1, nascimento = nascimento1
        WHERE idPessoaFisica = idPessoaFisica1;
        -- se erro ao alterar pessoa fisica
        IF excessao = 1 THEN
			SELECT 'Erro ao alterar pessoa fisica' AS Retorno;
			ROLLBACK;
		ELSE
			UPDATE endereco SET cep = cep1, uf = uf1, complemento = complemento1, cidade = cidade1,
			bairro = bairro1, numero = numero1, logradouro = logradouro1
			WHERE idEndereco = idPessoaFisica1;
			-- se erro ao alterar endereco
            IF excessao = 1 THEN
				SELECT 'Erro ao alterar endereco' AS Retorno;
				ROLLBACK;
			ELSE
				UPDATE prontuarioIFSP SET prontuario = prontuario1 
				WHERE idProntuarioIFSP = idPessoaFisica1;
                -- se erro ao alterar prontuario
                IF excessao = 1 THEN
					SELECT 'Erro ao alterar prontuario' AS Retorno;
					ROLLBACK;
				ELSE
					UPDATE aluno SET responsavel1 = responsavel11, responsavel2 = responsavel21, 
					phoneResponsavel1 = phoneResponsavel11, phoneResponsavel2 = phoneResponsavel21
					WHERE idAluno = idPessoaFisica1;
					-- se erro ao alterar aluno
					IF excessao = 1 THEN
						SELECT 'Erro ao alterar aluno' AS Retorno;
						ROLLBACK;
					ELSE
						SELECT idPessoafisica1 as Retorno;
						COMMIT;
					END IF;
				END IF;
			END IF;
		END IF;
	END;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `alterarAssistenteAluno` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `alterarAssistenteAluno`(
	in idAssistenteAluno1 int,
	in nome1 varchar(45),
	in sobrenome1 varchar(45),
    in sexo1 char(1),
	in cpf1 char(14),
	in rg1 char(12),
	in email1 varchar(70),
	in celular1 char(14),
	in telefone1 char(13),
	in nascimento1 datetime,
	in cep1 char(10),
	in uf1 char(2),
	in complemento1 varchar(45),
	in cidade1 varchar(45),
	in bairro1 varchar(45),
	in numero1 varchar(10),
	in logradouro1 varchar(45),
	in prontuario1 varchar(8))
BEGIN
	DECLARE excessao INT DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	BEGIN
		START TRANSACTION;
        
		UPDATE pessoafisica SET nome = nome1, sobrenome = sobrenome1, sexo = sexo1, cpf = cpf1, rg = rg1,
        email = email1, celular = celular1, telefone = telefone1, nascimento = nascimento1
		WHERE idPessoaFisica = idAssistenteAluno1;

		UPDATE endereco SET cep = cep1, uf = uf1, complemento = complemento1, cidade = cidade1, 
        bairro = bairro1, numero = numero1, logradouro = logradouro1
		WHERE idEndereco = idAssistenteAluno1;
			
		UPDATE prontuarioIFSP SET prontuario = prontuario1
		WHERE idProntuarioIFSP = idAssistenteAluno1;

		UPDATE assistentealuno SET idAssistenteAluno = idAssistenteAluno1, idPessoaFisica = idAssistenteAluno1,
        idProntuarioIFSP = idAssistenteAluno1 
		WHERE idAssistenteAluno = idAssistenteAluno1;

		IF (excessao = 1) THEN
			SELECT 'Erro ao alterar assistente de aluno' AS Retorno;
			ROLLBACK;
        ELSE
			SELECT idAssistenteAlnuo1 as Retorno;
            COMMIT;
		END IF;
	END;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `alterarSolicitacaoSaida` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `alterarSolicitacaoSaida`(
	in idSolicitacaoSaida1 int,
	in motivo1 varchar(300),
	in abertura1 datetime,
	in previsaoEncerramento1 datetime,
	in encerramento1 datetime,
	in idAluno1 int,
	in idAssistenteAluno1 int,
    in estado1 varchar(15))
BEGIN
	DECLARE excessao INT DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	BEGIN
		START TRANSACTION;        
		UPDATE solicitacaosaida SET motivo = motivo1, abertura = abertura1, previsaoEncerramento = previsaoEncerramento1, 
        encerramento = encerramento1, idAluno = idAluno1, idAssistenteAluno = idAssistenteAluno1, estado = estado1
		WHERE idSolicitacaoSaida = idSolicitacaoSaida1;
        IF (excessao = 1) THEN
			SELECT 'Erro ao alterar solicitacao de aluno (Erro solicitacaosaida)' AS Retorno;
            ROLLBACK;
		ELSE
			UPDATE solicitacaosaidatemp SET motivo = motivo1, abertura = abertura1, estado = estado1, previsaoEncerramento = previsaoEncerramento1,
            idAluno = idAluno1, idAssistenteAluno = idAssistenteAluno1
       
			WHERE idSolicitacao = idSolicitacaoSaida1;		
			IF (excessao = 1) THEN
				SELECT 'Erro ao alterar solicitacao de aluno (Erro solicitacaosaidatemp)' AS Retorno;
				ROLLBACK;
			ELSE
				SELECT idSolicitacaoSaida1 as Retorno;
				COMMIT;
			END IF;
		END IF;
	END;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `alterarVigilante` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `alterarVigilante`(
	in idVigilante1 int,
	in nome1 varchar(45),
	in sobrenome1 varchar(45),
    in sexo1 char(1),
	in cpf1 char(14),
	in rg1 char(12),
	in email1 varchar(70),
	in celular1 char(14),
	in telefone1 char(13),
	in nascimento1 datetime,
	in cep1 char(10),
	in uf1 char(2),
	in complemento1 varchar(45),
	in cidade1 varchar(45),
	in bairro1 varchar(45),
	in numero1 varchar(10),
	in logradouro1 varchar(45),
	in prontuario1 varchar(8))
BEGIN
	DECLARE excessao INT DEFAULT 0;
    DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
	BEGIN
		START TRANSACTION;
        
		UPDATE pessoafisica SET nome = nome1, sobrenome = sobrenome1, sexo = sexo1, cpf = cpf1, rg = rg1,
        email = email1, celular = celular1, telefone = telefone1, nascimento = nascimento1
		WHERE idPessoaFisica = idAssistenteAluno1;

		UPDATE endereco SET cep = cep1, uf = uf1, complemento = complemento1, cidade = cidade1, 
        bairro = bairro1, numero = numero1, logradouro = logradouro1
		WHERE idEndereco = idAssistenteAluno1;
	
		IF (excessao = 1) THEN
			SELECT 'Erro ao alterar vigilante' AS Retorno;
			ROLLBACK;
		ELSE
            SELECT idPessoaFisica as Retorno;
            COMMIT;
		END IF;
	END;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `consultarAlunoId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultarAlunoId`(IN idAluno int)
BEGIN
	SELECT * FROM pessoafisica INNER JOIN endereco INNER JOIN aluno INNER JOIN prontuarioIFSP
    ON pessoafisica.idpessoafisica = aluno.idpessoafisica AND pessoafisica.idPessoaFisica = endereco.idPessoaFisica AND aluno.idProntuarioIFSP = prontuarioifsp.idProntuarioIFSP
	WHERE aluno.idaluno = idAluno;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `consultarAlunoNome` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultarAlunoNome`(IN nome VARCHAR(45))
BEGIN
	SELECT * FROM pessoafisica INNER JOIN endereco INNER JOIN aluno INNER JOIN prontuarioIFSP
    ON pessoafisica.idpessoafisica = aluno.idpessoafisica AND pessoafisica.idPessoaFisica = endereco.idPessoaFisica AND aluno.idProntuarioIFSP = prontuarioifsp.idProntuarioIFSP
	WHERE pessoafisica.nome = nome + '%';
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `consultarAlunoProntuario` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultarAlunoProntuario`(IN prontuario VARCHAR(11))
BEGIN
	SELECT * FROM pessoafisica INNER JOIN endereco INNER JOIN aluno INNER JOIN prontuarioIFSP
    ON pessoafisica.idpessoafisica = aluno.idpessoafisica AND pessoafisica.idPessoaFisica = endereco.idPessoaFisica AND aluno.idProntuarioIFSP = prontuarioifsp.idProntuarioIFSP
	WHERE prontuarioifsp.prontuario = prontuario;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `consultarAssistenteAluno` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultarAssistenteAluno`(in prontuario varchar(10))
BEGIN
	SELECT * FROM pessoafisica AS pessoa INNER JOIN assistentealuno INNER JOIN prontuarioifsp
    ON pessoa.idpessoafisica = assistentealuno.idpessoafisica 
    AND assistentealuno.idprontuarioifsp = prontuarioifsp.idprontuarioifsp
    WHERE prontuarioifsp.prontuario = prontuario;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `consultarAssistenteAlunoId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultarAssistenteAlunoId`(in idAssistente int)
BEGIN
	SELECT * FROM pessoafisica AS pessoa INNER JOIN endereco 
    INNER JOIN assistentealuno INNER JOIN prontuarioifsp
    ON pessoa.idpessoafisica = assistentealuno.idpessoafisica 
    AND endereco.idPessoaFisica = pessoa.idPessoaFisica
    AND assistentealuno.idprontuarioifsp = prontuarioifsp.idprontuarioifsp
    WHERE assistenteAluno.idPessoaFisica = idAssistente;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `consultarSolicitacaoSaidaId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultarSolicitacaoSaidaId`(in id INTEGER)
BEGIN
	SELECT * FROM solicitacaosaida WHERE idsolicitacaosaida = id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `consultarSolicitacaoSaidaTempId` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultarSolicitacaoSaidaTempId`(IN id INTEGER)
BEGIN
	SELECT * FROM solictacaoSaidaTemp WHERE idsolicitacao = id; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `consultarSolicitacoesSaida` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultarSolicitacoesSaida`()
BEGIN
	SELECT * FROM solicitacaosaida;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `consultarSolicitacoesSaidaTemp` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultarSolicitacoesSaidaTemp`()
BEGIN
	SELECT * FROM SolicitacaoSaidaTemp;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `consultarVigilante` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultarVigilante`(in id INTEGER)
BEGIN
	SELECT * FROM pessoafisica AS pessoa INNER JOIN vigilante
    ON vigilante.idpessoafisica = vigilante.idpessoafisica
    WHERE vigilante.idpessoafisica = id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `deletarPessoaFisica` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `deletarPessoaFisica`(in idPessoaFisica int)
BEGIN
	BEGIN
		START TRANSACTION;
        
		DELETE FROM pessoafisica WHERE idPessoaFisica = idPessoaFisica;

		SELECT idPessoaFisica as Retorno;				

		END;
end ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `deletarSolicitacaoSaida` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `deletarSolicitacaoSaida`(in id integer)
BEGIN
	DECLARE excessao INT DEFAULT 0;
	DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
    BEGIN
		START TRANSACTION;
		DELETE FROM solicitacaosaida WHERE idSolicitacaoSaida = id;
        IF (excessao = 1) THEN
			SELECT 'Erro ao deletar solicitacao (Erro "solicitacaosaida")' AS Retorno;
            ROLLBACK;
		ELSE
			DELETE FROM solicitacaosaidatemp WHERE idSolicitacao = id;		
			IF (excessao = 1) THEN
				SELECT 'Erro ao deletar solicitacao (Erro "solicitacaosaidatemp")' AS Retorno;
				ROLLBACK;
			ELSE
				SELECT id AS Retorno;
				COMMIT;
			END IF;
		END IF;
    END;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `deletarSolicitacaoSaidaTemp` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `deletarSolicitacaoSaidaTemp`(in idSolicitacaoSaidaTemp INT)
BEGIN
	DELETE FROM solicitacaosaidatemp WHERE idSolicitacao = idSolicitacaoSaidaTemp;
    SELECT idSolicitacaoSaidaTemp AS Retorno;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `inserirAluno` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `inserirAluno`(
	in nome varchar(45),
	in sobrenome varchar(45),
    in sexo char(1),
	in cpf char(14),
	in rg char(12),
	in email varchar(70),
	in celular char(14),
	in telefone char(13),
	in nascimento datetime,
	in cep char(10),
	in uf char(2),
	in complemento varchar(45),
	in cidade varchar(45),
	in bairro varchar(45),
	in numero varchar(10),
	in logradouro varchar(45),
	in responsavel1 varchar(45),
	in responsavel2 varchar(45),
	in phoneResponsavel1 char(14),
	in phoneResponsavel2 char(14),
	in prontuario varchar(8))
BEGIN
	BEGIN    
		DECLARE idPessoa INT;
		DECLARE excessao SMALLINT DEFAULT 0;
        -- variável que capita erro sql e muda varial 
		DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
		START TRANSACTION;
		INSERT INTO pessoafisica (nome, sobrenome, sexo, cpf, rg, email, celular, telefone, nascimento) 
        VALUES (nome, sobrenome, sexo, cpf, rg, email, celular, telefone, nascimento);
        -- se erro na inserção da tabela física rollback e mensagem
        IF excessao = 1 THEN			
			ROLLBACK; 
            SELECT 'Erro ao inserir dados em "pessoafísica' AS Retorno;
		ELSE
			SET idPessoa = @@identity;
            -- se erro ao pegar ultimo id inserido, mensagem e rollback
            IF excessao = 1 THEN
				SELECT 'Erro ao recuperar "id"' AS Retorno;
				ROLLBACK;
			ELSE
				INSERT INTO endereco (idEndereco, cep, uf, complemento, cidade, bairro, numero, logradouro, idPessoaFisica) 
                VALUES (idPessoa, cep, uf, complemento, cidade, bairro, numero, logradouro, idPessoa);
				-- se erro ao inserir em 'endereco'
                IF excessao = 1 THEN
					SELECT 'Erro ao inserir "endereco"' AS Retorno;
					ROLLBACK;
				ELSE
					INSERT INTO prontuarioIFSP (idProntuarioIFSP, prontuario) VALUES (idPessoa, prontuario);
                    -- se erro ao inserir em 'prontuario'
                    IF excessao = 1 THEN
						SELECT 'Erro ao inserir "prontuario"' AS Retorno;
						ROLLBACK;
					ELSE
						INSERT INTO aluno (idAluno, responsavel1, responsavel2, phoneResponsavel1, phoneResponsavel2, idPessoaFisica, idProntuarioIFSP) VALUES (idPessoa, responsavel1, responsavel2, phoneResponsavel1, phoneResponsavel2, idPessoa, idPessoa);
						-- se erro ao inserir em 'aluno'
                        IF excessao = 1 THEN
							SELECT 'Erro ao inserir "aluno"' AS Retorno;
							ROLLBACK;
						ELSE
							SELECT idPessoa as Retorno;
							COMMIT;							
						END IF;
					END IF;                
				END IF;		
			END IF;
		END IF;
    END;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `inserirAssistenteAluno` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `inserirAssistenteAluno`(
	in nome varchar(45),
	in sobrenome varchar(45),
	in sexo char(1),
	in cpf char(14),
	in rg char(12),
	in email varchar(70),
	in celular char(14),
	in telefone char(13),
	in nascimento datetime,
	in cep char(10),
	in uf char(2),
	in complemento varchar(45),
	in cidade varchar(45),
	in bairro varchar(45),
	in numero varchar(10),
	in logradouro varchar(45),
	in prontuario varchar(8))
BEGIN
	BEGIN    
		DECLARE idPessoa INT;
		DECLARE excessao SMALLINT DEFAULT 0;
        -- variável que capita erro sql e muda varial 
		DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
		START TRANSACTION;
		INSERT INTO pessoafisica (nome, sobrenome, sexo, cpf, rg, email, celular, telefone, nascimento) VALUES (nome, sobrenome, sexo, cpf, rg, email, celular, telefone, nascimento);
        -- se erro na inserção da tabela física rollback e mensagem
        IF excessao = 1 THEN			
			ROLLBACK; 
            SELECT 'Erro ao inserir dados em "pessoafísica' AS Retorno;
		ELSE
			SET idPessoa = @@identity;
            -- se erro ao pegar ultimo id inserido, mensagem e rollback
            IF excessao = 1 THEN
				SELECT 'Erro ao recuperar "id"' AS Retorno;
				ROLLBACK;
			ELSE
				INSERT INTO endereco (idEndereco, cep, uf, complemento, cidade, bairro, numero, logradouro, idPessoaFisica) VALUES (idPessoa, cep, uf, complemento, cidade, bairro, numero, logradouro, idPessoa);
				-- se erro ao inserir em 'endereco'
                IF excessao = 1 THEN
					SELECT 'Erro ao inserir "endereco"' AS Retorno;
					ROLLBACK;
				ELSE
					INSERT INTO prontuarioIFSP (idProntuarioIFSP, prontuario) VALUES (idPessoa, prontuario);
                    -- se erro ao inserir em 'prontuario'
                    IF excessao = 1 THEN
						SELECT 'Erro ao inserir "prontuario"' AS Retorno;
						ROLLBACK;
					ELSE
						INSERT INTO assistentealuno (idAssistenteAluno, idPessoaFisica, idProntuarioIFSP) VALUES (idPessoa, idPessoa, idPessoa);
						-- se erro ao inserir em 'aluno'
                        IF excessao = 1 THEN
							SELECT 'Erro ao inserir "assistente aluno"' AS Retorno;
							ROLLBACK;
						ELSE
							SELECT idPessoa as Retorno;
							COMMIT;							
						END IF;
					END IF;                
				END IF;		
			END IF;
		END IF;
    END;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `inserirSolicitacaoSaida` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `inserirSolicitacaoSaida`(
	in motivo varchar(300),
	in idAluno int,
	in idAssistenteAluno int)
BEGIN
DECLARE dt DATETIME;
DECLARE dtp DATETIME;
DECLARE excessao INT DEFAULT 0;
DECLARE idSolicitacao INT;
DECLARE estadoSet VARCHAR(15);
DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
SET estadoSet = 'Autorizado';
SET dt = NOW();
SET dtp = DATE_ADD(NOW(), INTERVAL 45 MINUTE);
		START TRANSACTION;	

		INSERT INTO solicitacaosaida (motivo, abertura, previsaoEncerramento, encerramento, idAluno, idAssistenteAluno, idVigilante, estado) 
        VALUES (motivo, dt, dtp, null, idAluno, idAssistenteAluno, null, estadoSet);
		SET idSolicitacao = @@identity;
        IF (excessao = 1) THEN
			SELECT 'Erro ao inserir solicitação. Detalhes: "solicitacaosaida"' AS Retorno;
			ROLLBACK;
		ELSE
			INSERT INTO solicitacaosaidatemp (idSolicitacao, idAluno, idAssistenteAluno, motivo, abertura, estado, previsaoEncerramento) 
            VALUES (idSolicitacao, idAluno, idAssistenteAluno, motivo, dt, estadoSet, dtp);
            IF (excessao = 1) THEN
				SELECT 'Erro ao inserir solicitação. Detelhes:  "solicitacaosaidatemp"' AS Retorno;
				ROLLBACK;
			ELSE
				SELECT idSolicitacao as Retorno;
				COMMIT;
			END IF;
		END IF;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `inserirVigilante` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `inserirVigilante`(
	in nome varchar(45),
	in sobrenome varchar(45),
	in sexo char(1),
	in cpf char(14),
	in rg char(12),
	in email varchar(70),
	in celular char(14),
	in telefone char(13),
	in nascimento datetime,
	in cep char(10),
	in uf char(2),
	in complemento varchar(45),
	in cidade varchar(45),
	in bairro varchar(45),
	in numero varchar(10),
	in logradouro varchar(45),
	in prontuario varchar(8))
BEGIN
	BEGIN    
		DECLARE idPessoa INT;
		DECLARE excessao SMALLINT DEFAULT 0;
        -- variável que capita erro sql e muda varial 
		DECLARE CONTINUE HANDLER FOR SQLEXCEPTION SET excessao = 1;
		START TRANSACTION;
		INSERT INTO pessoafisica (nome, sobrenome, sexo, cpf, rg, email, celular, telefone, nascimento) 
        VALUES (nome, sobrenome, sexo, cpf, rg, email, celular, telefone, nascimento);
        -- se erro na inserção da tabela física rollback e mensagem
        IF excessao = 1 THEN			
			ROLLBACK; 
            SELECT 'Erro ao inserir dados em "pessoafísica' AS Retorno;
		ELSE
			SET idPessoa = @@identity;
            -- se erro ao pegar ultimo id inserido, mensagem e rollback
            IF excessao = 1 THEN
				SELECT 'Erro ao recuperar "id"' AS Retorno;
				ROLLBACK;
			ELSE
				INSERT INTO endereco (idEndereco, cep, uf, complemento, cidade, bairro, numero, logradouro, idPessoaFisica) 
                VALUES (idPessoa, cep, uf, complemento, cidade, bairro, numero, logradouro, idPessoa);
				-- se erro ao inserir em 'endereco'
                IF excessao = 1 THEN
					SELECT 'Erro ao inserir "endereco"' AS Retorno;
					ROLLBACK;
				ELSE
					INSERT INTO prontuarioIFSP (idProntuarioIFSP, prontuario) 
                    VALUES (idPessoa, prontuario);
                    -- se erro ao inserir em 'prontuario'
                    IF excessao = 1 THEN
						SELECT 'Erro ao inserir "prontuario"' AS Retorno;
						ROLLBACK;
					ELSE
						INSERT INTO vigilante (idVigilante, idPessoaFisica) 
                        VALUES (idPessoa, idPessoa);
						-- se erro ao inserir em 'aluno'
                        IF excessao = 1 THEN
							SELECT 'Erro ao inserir "vigilante"' AS Retorno;
							ROLLBACK;
						ELSE
							SELECT idPessoa as Retorno;
							COMMIT;							
						END IF;
					END IF;                
				END IF;		
			END IF;
		END IF;
    END;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-05-22 13:49:49
