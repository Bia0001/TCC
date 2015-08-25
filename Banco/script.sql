CREATE DATABASE  IF NOT EXISTS `sistemaifsp` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `sistemaifsp`;
-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: localhost    Database: sistemaifsp
-- ------------------------------------------------------
-- Server version	5.6.26-log

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
-- Table structure for table `__migrationhistory`
--

DROP TABLE IF EXISTS `__migrationhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `__migrationhistory` (
  `MigrationId` varchar(100) NOT NULL,
  `ContextKey` varchar(200) NOT NULL,
  `Model` longblob NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`,`ContextKey`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__migrationhistory`
--

LOCK TABLES `__migrationhistory` WRITE;
/*!40000 ALTER TABLE `__migrationhistory` DISABLE KEYS */;
INSERT INTO `__migrationhistory` VALUES ('201508211600422_criando-database','Sistema.Ifsp.Repositorio.Migrations.Configuration','�\0\0\0\0\0\0�]_o�6/��`��W�v��]���n69�l�8�׀�h��$�D:H>�=�G�W(%��\"i�qо�9��r8������4�<�� ��N�gG�	�\"�l}:���?M���o�q�<���{W�c-3r:}�4�0������R���E8���O���Ϗ�琑�2Z���v�Q����y���t�+Ä���˲�:�RHr���ʊf�+��na�	��@x:�� �Ƴ��j:Y�)�l�~#pI���9+\0��KY�H����U�e��dh�5�ȴe�1{΄B_��U�N?&��1�	X�ny��@B0�@E�o�(�8�}��G8cc���Iݜl^��+�����#�q��=ø)���[�\nXZl��/�$	l��m:>ٽcs?C�x���ɣ�1��z7rjٻ�������n�ό��\n�0���G���@s�W�(pz��Pܷ�%���k*܁b\rip�y�T#~�A�y���\n8���U�\Z�<�t�\"	qr����s��w\'�i�Œ)�o��P�\0Ja�t�e+� �K}*\0���`������\n3��Y�x�ߥ��Z2(�Uw���w[��| �k�/�f8��זQ�ڻ*ֆ.ߏ�#3�(	oDY�d��bl�JaW83�%@? s3�j���w(\r���5J\0� f�\'.QY�E���%@��Ґ�x(�ƾ�x`?6p�)���O�\0|�|��\0>ӯX~Fb�)���d�ߍ�	��\r�}�\ru���g�0�\"��몝WאL����|G*z3Vc�F/�\Z�|\r\\9��\r/\\um���wU]\\)�5�P5ZC�Z��<�\'C[�N\'��t�I(ʫ��N���j �0�+z�\r�S>�͎E�9�{���Z���0D�:�e�q_@\Z��B��+�@{��!,�0����i����Qv�h\r+�NZ��P�#	K֬\\O���V5��Gm�ys��>�,�e!|�2��KH��<s?:M����ʉ&�-�2�Eb�$1$�4H}hNfe�<���;>]zS�r$If�@��\rO��0q��g�F��\Z�`,\r����ְeMl:�X���s1~K�Eb׀���� �\r���L��D��(�S��9���l�\Z�p\"�Me\0�5{��@vQ��6�؄����\n�9یs�Ⱥd��#�~X����-�yDѿv�mO`\r���k6�T�P�\0���Y�Jլ܁�/�1���1�M���\Z����L�l;q^0�#��Y�ͽ�]	(��p�I3��z�.����J�)�()��P�>yj�/^O��c\\̅i!3�0Tf�`�!\n�\0md�]�����wZ�������񄦣�\rf�%��L�dY�r��zY���F<��ȁ�&��)����{xB]�ìp���p凣I���Z0�=L��|�쾝W��]���@���s\\A�ڳ�\\C/7R{�	�}� �h��ZM�0	���A��:(2Q�B�<ͮ�(�Xg2�\ZfDKzRl¡<��̞J��4e�_\Z��b}�g`��^#�-L�Va�X���GҬ�Jᵣ�p}.`?`o#h)��ƨ�\Z\\�2$ކ�=�\"/���p���1m���MS�<W��*�/Y{�����WL��T:�n��4�֣v��������#\0^(���G��~d\n�GǨ:���$���,>�嚏�U)�\0�ͱ�)E��2m�4�I)h%ViwHm�JR-��p&�A�V�N�,�P\\F��^��Mf��Y��Y����j\\�� �w�w��N�9�����7\'$N�yq����J�ޮv���jdO���#]1��?CM�x�L%���%R�p�7a��O��f��d嬈�a�V7�o\n�m.�����l�Q�S.u���C	��SFF��%�\\���sFu�� &m����%Jؽ�P����cEU�bs�q�}�w�&�w�,I�g�*�f����8���&o�/�r\'�Yj�{��*�s\0~��wv�_\Z�ɠoH^��X�	7�!�[���t�sǼ\n&oX��H�V�Ђm��`�M��� �q\"��Nb)얶��3�aV�E:�m��=�k;@6$�}d#)�q}��K��U·ʯ���-��=e���d�`vx8r9���������}��|���:��Ud��`B�.��F�{��\")�\Z�h�GZ*��\\��}@H�/Q�ҍ�� ���ѵ�*�Qx���z{:g\'�`�\Zz�<o]7y�水˷�O�up��Cs�(�H�Ձz r��8���,�r�^8�����^9=���5�/����\'�*䍞ԛ\\E��`(N�V�Rwͽ5E��!¢���.ɩ:+\rt˭r�C����+��s#>�ГwO�%m]������	\Z8)����?� A^��;$q���h���<p18|���6:/ToA�&d�ǀdC&&*��v����mv�/)툯���w���U��P`l9��0o���z�N��7\Zl�Bк#Q�\\�`��#�u.�n�,�*B��\nR�\r�ǂ��(�1yUO�~ɆU9O`|�]oh���e�>$���-����!����y�$j�0Qy��:��AI܎�Blא(�R�-�r.iy[n��R�\"���#T�����4O1r�-�ԏmX�}�->#�.@Jj\Z]{���/N���֋�f\0\0','6.0.0-20911');
/*!40000 ALTER TABLE `__migrationhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `aluno`
--

DROP TABLE IF EXISTS `aluno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `aluno` (
  `idPessoaFisica` int(11) NOT NULL,
  `Prontuario_idProntuario` int(11) DEFAULT NULL,
  `contato1` varchar(11) NOT NULL,
  `contato2` varchar(11) DEFAULT NULL,
  `responsavel1` varchar(100) NOT NULL,
  `responsavel2` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idPessoaFisica`),
  KEY `IX_idPessoaFisica` (`idPessoaFisica`) USING HASH,
  KEY `IX_Prontuario_idProntuario` (`Prontuario_idProntuario`) USING HASH,
  CONSTRAINT `FK_Aluno_PessoaFisica_idPessoaFisica` FOREIGN KEY (`idPessoaFisica`) REFERENCES `pessoafisica` (`idPessoaFisica`),
  CONSTRAINT `FK_Aluno_Prontuario_Prontuario_idProntuario` FOREIGN KEY (`Prontuario_idProntuario`) REFERENCES `prontuario` (`idProntuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `aluno`
--

LOCK TABLES `aluno` WRITE;
/*!40000 ALTER TABLE `aluno` DISABLE KEYS */;
INSERT INTO `aluno` VALUES (1,1,'2',NULL,'2',NULL);
/*!40000 ALTER TABLE `aluno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `assistentealuno`
--

DROP TABLE IF EXISTS `assistentealuno`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `assistentealuno` (
  `idPessoaFisica` int(11) NOT NULL,
  `Prontuario_idProntuario` int(11) DEFAULT NULL,
  PRIMARY KEY (`idPessoaFisica`),
  KEY `IX_idPessoaFisica` (`idPessoaFisica`) USING HASH,
  KEY `IX_Prontuario_idProntuario` (`Prontuario_idProntuario`) USING HASH,
  CONSTRAINT `FK_AssistenteAluno_PessoaFisica_idPessoaFisica` FOREIGN KEY (`idPessoaFisica`) REFERENCES `pessoafisica` (`idPessoaFisica`),
  CONSTRAINT `FK_AssistenteAluno_Prontuario_Prontuario_idProntuario` FOREIGN KEY (`Prontuario_idProntuario`) REFERENCES `prontuario` (`idProntuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `assistentealuno`
--

LOCK TABLES `assistentealuno` WRITE;
/*!40000 ALTER TABLE `assistentealuno` DISABLE KEYS */;
INSERT INTO `assistentealuno` VALUES (2,2);
/*!40000 ALTER TABLE `assistentealuno` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pessoafisica`
--

DROP TABLE IF EXISTS `pessoafisica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pessoafisica` (
  `idPessoaFisica` int(11) NOT NULL AUTO_INCREMENT,
  `nome` varchar(100) NOT NULL,
  `cpf` varchar(11) NOT NULL,
  `rg` varchar(9) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `celular` varchar(11) DEFAULT NULL,
  `telefone` varchar(10) DEFAULT NULL,
  `nascimento` datetime NOT NULL,
  PRIMARY KEY (`idPessoaFisica`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pessoafisica`
--

LOCK TABLES `pessoafisica` WRITE;
/*!40000 ALTER TABLE `pessoafisica` DISABLE KEYS */;
INSERT INTO `pessoafisica` VALUES (1,'Lucas','2','2',NULL,'2',NULL,'1992-02-02 00:00:00'),(2,'Pedrinho','assstente','1234',NULL,NULL,NULL,'1992-04-04 00:00:00'),(3,'Samule Mucão','4','4',NULL,NULL,NULL,'1990-04-04 00:00:00'),(4,'Samule Mucão','4','4',NULL,NULL,NULL,'1990-04-04 00:00:00');
/*!40000 ALTER TABLE `pessoafisica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prontuario`
--

DROP TABLE IF EXISTS `prontuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prontuario` (
  `idProntuario` int(11) NOT NULL AUTO_INCREMENT,
  `prontuario` varchar(7) NOT NULL,
  PRIMARY KEY (`idProntuario`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prontuario`
--

LOCK TABLES `prontuario` WRITE;
/*!40000 ALTER TABLE `prontuario` DISABLE KEYS */;
INSERT INTO `prontuario` VALUES (1,'1'),(2,'2');
/*!40000 ALTER TABLE `prontuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `solicitacaosaida`
--

DROP TABLE IF EXISTS `solicitacaosaida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `solicitacaosaida` (
  `idSolicitacaoSaida` int(11) NOT NULL AUTO_INCREMENT,
  `abertura` datetime NOT NULL,
  `previsaoEncerramento` datetime NOT NULL,
  `encerramento` datetime DEFAULT NULL,
  `motivo` varchar(300) NOT NULL,
  `status` varchar(10) NOT NULL,
  `Aluno_idPessoaFisica` int(11) DEFAULT NULL,
  `AssistenteAluno_idPessoaFisica` int(11) DEFAULT NULL,
  `Vigilante_idPessoaFisica` int(11) DEFAULT NULL,
  PRIMARY KEY (`idSolicitacaoSaida`),
  KEY `IX_Aluno_idPessoaFisica` (`Aluno_idPessoaFisica`) USING HASH,
  KEY `IX_AssistenteAluno_idPessoaFisica` (`AssistenteAluno_idPessoaFisica`) USING HASH,
  KEY `IX_Vigilante_idPessoaFisica` (`Vigilante_idPessoaFisica`) USING HASH,
  CONSTRAINT `FK_3d2dd096dd694bf397f6583498121f56` FOREIGN KEY (`AssistenteAluno_idPessoaFisica`) REFERENCES `assistentealuno` (`idPessoaFisica`),
  CONSTRAINT `FK_SolicitacaoSaida_Aluno_Aluno_idPessoaFisica` FOREIGN KEY (`Aluno_idPessoaFisica`) REFERENCES `aluno` (`idPessoaFisica`),
  CONSTRAINT `FK_SolicitacaoSaida_Vigilante_Vigilante_idPessoaFisica` FOREIGN KEY (`Vigilante_idPessoaFisica`) REFERENCES `vigilante` (`idPessoaFisica`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `solicitacaosaida`
--

LOCK TABLES `solicitacaosaida` WRITE;
/*!40000 ALTER TABLE `solicitacaosaida` DISABLE KEYS */;
INSERT INTO `solicitacaosaida` VALUES (18,'2015-08-22 18:25:59','2015-08-22 18:26:59','2015-08-22 18:26:06','TESTE 1','Expirado',1,2,3);
/*!40000 ALTER TABLE `solicitacaosaida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vigilante`
--

DROP TABLE IF EXISTS `vigilante`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vigilante` (
  `idPessoaFisica` int(11) NOT NULL,
  PRIMARY KEY (`idPessoaFisica`),
  KEY `IX_idPessoaFisica` (`idPessoaFisica`) USING HASH,
  CONSTRAINT `FK_Vigilante_PessoaFisica_idPessoaFisica` FOREIGN KEY (`idPessoaFisica`) REFERENCES `pessoafisica` (`idPessoaFisica`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vigilante`
--

LOCK TABLES `vigilante` WRITE;
/*!40000 ALTER TABLE `vigilante` DISABLE KEYS */;
INSERT INTO `vigilante` VALUES (3),(4);
/*!40000 ALTER TABLE `vigilante` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-08-24 18:03:25
