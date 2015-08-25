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
INSERT INTO `__migrationhistory` VALUES ('201508211600422_criando-database','Sistema.Ifsp.Repositorio.Migrations.Configuration','ã\0\0\0\0\0\0Ì]_o„6/–Ô`¯©W†ví≈]ªß≈n69ΩlÇ8›◊Äëhá®$ÍD:H>€=‹GÍW(%Î≈\"i q–æ≈9‰úr8Ãˇ˚ˇ‚óÁ4ô<¡Ç úùNègG”	Ã\"£l}:›–’?M˘˘€oÁq˙<˘⁄‘{W÷c-3r:}§4ˇ0üìË¶ÄÃRò‡ùE8ùÉœOééﬁœèèÁêëò2Zì…‚vìQî¬Í˚yÜ≥Êtí+√Ñ‘ÂÏÀ≤¢:˘RHr¡”È äfó+íœnaé	¢∏@x:˘ò ¿∆≥Ñ…j:YÜ)†l¥~#pIú≠ó9+\0…›KYΩH¨π¯–U∑eËË§dhﬁ5Ù»¥eï1{ŒÑB_ ·UüN?&õå1ˆ	Xñnyõ›@B0∏@EÄoœ(‹8á}©€G8cc√«”I›úl^ßì+¸ò≠È#õqˆÒ=√∏)®≈Ú[Ü\nXZlÿœ/õ$	løœm:>ŸΩcs?CŒxÇâë…££1∏‰z7rjŸª–ŸÑ÷≤ÑnŸœå≠ï\nÛ∑0©™êGî◊®@sœW∫(pzãìP‹∑˚%ﬁÎ˚k*‹Åb\ripãyáT#~πAÙy˚æÙ\n8Ÿﬁ¬U›\Z≈<ÇtÊ\"	qr˙≠∑ìsô—w\'äiÊî≈í)¯oò¡Pﬂ\0Ja¡t¬e+ÊÜ ëK}*\0Ò„Ó`¥ûÇèÑî\n3£–Yôx∞ﬂ•ä⁄Z2(ıUwÉßûw[ÄÚ| ⁄kø/êf8Ö˚◊ñQæ⁄ª*÷Ü.ﬂè—#3˘(	oDY¬dìÄblÛJaW83É%@? s3⁄jÕœÿw(\r¶ø¢5J\0” fÿ\'.QY‚EàÇ‡%@±ß“ê®x(ô∆æîx`?6pú)ï©ÑOà\0|Œ|ˇ¢\0>”ØX~FbÊ∂)¶Ë…d∑ﬂç£	õò\rŸ}ç\ru´µÁµg†0Â\"ÃÓÎ™ùW◊êL∏¶ö |G*z3VcôF/∏\Z√|\r\\9‚ì\r/\\um≠·ÒwU]\\)∆5éP5ZC˜Záˇ<ã\'C[êN\'◊ÛtµI( ´øúNøóÑj ⁄0√+zŒ\rÌS>öÕéEæ9◊{ª⁄—Z∏æú0D¯:àeÿq_@\Z¢ÛêBÈ∆+€@{…Ë£!,à0√ˆÉ÷i´±Ñ§Qvˆh\r+∏NZ≥†Pç#	K÷¨\\Oú˜–V5üïGmàysµê>Å,¬e!|¶2î KH•ç<s?:MØ–€° â&ç-ì2ÌìEb≠$1$ı4H}hNfe˘<Ç´¶;>]zS÷r$IfÓ@≠Å\rOçü0q◊–gŸFÜÉ\ZÖ`,\rù´©Û÷∞eMl:ßXôçÈs1~KäEb◊Äπ≥ùÇ ¬\rÑçÿL“œD•∆(ÓS®ú9±ß∆l∫\ZŒp\"îMe\0·5{ó÷@vQ≈˘6¨ÿÑÁö¯„‚\n‰9€åsÒ»∫d≤‹#œ~X∫á˝“-çyD—øv¥mO`\rÖØ¨k6“T˙P\0 ˝˛YúJ’¨‹Å¶/ï1óß±1≈M´ÚÔ\ZóöÿÏLπl;q^0À#õäY»ÕΩ¶]	(‘œp≤I3õ√z’.ä ”ÎJù)ù()ù∏PÍ>yj˝/^O¥ïc\\ÃÖi!3ó0Tf´`Ø!\n„\0mdÅ]íÚÔÎ’wZ…Ò¸áá‹ÙÅ≥ÒÑ¶£∫\rfÒ¥∂%´≤LıdY‡∞r÷¬zYª¥ÆF<Å∫»ÅÉ&‘„¢)¥ß”≈{xB]©√¨pùﬁ‹pÂá£I¥ë≈Z0¥=LÌ—|ÔÏæùW¿Ì°Ç]ø¥—@Ü∆±s\\AË⁄≥≈\\C/7R{•	î}Ù ”héâZMÊ0	˝î A˝â:(2QÔBù<ÕÆ‘(™Xg2™\ZfDKzRl¬°<≠¶ÃûJ‹‰©4e˚_\Z˝Õb}»g`∂õ^#´-LπVaÁX≤åïG“¨ÁJ·µ£Úp}.`?`o#h)€Ï∆®ä\Z\\í2$ﬁÜ√=Ñ\"/∏É pƒÍæ≈1m¯êÃMS‡<W˛Ü*€/Y{ÿ˜¶©´WL¢˘T:¿nÈÌ4ç÷£vÖ›ÓéÀÓ≥ëœÿ#\0^(âåÇGı—~d\nîG«®:Ú∂–Í$≥∏ÂÇ,>àÂöèÅU)Ü\0•Õ±Ò)Eóﬁ2mÂ4åI)h%ViwHmJR-ÍÄ—p&ùA⁄VôNò,ûP\\FèÆ^ñˇMfÂ˜YıÁYÇÿ˙Îj\\Å≠ °w¯wòùNˇ9˚óêÜÁë7\'$NÃyqáô∏ÅJ…ﬁÆvºÃÁjdO†àÀ#]1°¿?CMÛxáL%≈˜ª%RÿpÓë7a¡ºOöÑf¥ÆdÂ¨àòaäV7Ÿo\n°m.Ó–ÙøŸlΩQ÷S.u£ú≠C	ıSFF≥ò%‚Ö\\’ÏÈsFu°  &m≥û˚˘%JÿΩÛPÊ˝Ù›cEUÌbsàq„}»w˜&¨wΩ,I⁄g“*Ófø∂∑·8©⁄„&oÒã/Ñr\'ƒYj’{¡º*’s\0~éãwv˜_\Zù…†oH^ˆ©Xé	7‹!ú[ Àƒtßs«º\n&oXîæHÿVò–ÇmÜ•`‡MÅ≤Â Èq\"ü∏Nb)Ïñ∂¯Â3ÃaV∫E:∆m˙∑=Ùk;@6$û}d#)èq}≥ÄKÉóUŒá ØÅØ·§-·†’=eÍ‡–d∫`vx8r9ˆ›ÇÍÿõ¥é“}ô˝|œÓ˛:ï›Udßı`B÷.ñ”FÊ{∑„\")§\Z‹h¥GZ*‰õ\\ì°}@H±/Q∫“çÑá ˚ÄÖ—µ—*ñQx˝ÿ√z{:g\'Ï`ˆ\Zz»<o]7y†Ê∞¥À∑–O√upÕ¬Cs⁄(¥H¬’Åz r¢®8´™∑,ürÿ^8ù∆•ÜŸ^9=ˆ¿Ø5π/˛∫´™\'˚*‰çû‘õ\\E’Á`(NÏπV±RwÕΩ5Eıß!¬¢óªê.…©:+\rtÀ≠r©C˛éì¢+Ó≥Õs#>¥–ìwOﬂ%m]ùØç–˙”	\Z8)Ôñ¥ò¬?Ü A^»¸;$q∏ûñhü¿Ò<p18|˛ûŸ6:/ToAÒ&dß«ÄdC&&*æõvºØÌºëçmvò/)ÌàØΩä√wˇ¢êUê≠P`l9öÉ0o‘»◊zŸNÅ˚7\ZlªB–∫#Qﬁ\\Œ`‘€#¥u.≥n∂,¬àö*Bÿ˙\nR≥\rƒ«Ç¢à(˚1yUO’~…ÜU9O`|ô]ohæ°åeò>$ΩÁÑÀ-è©ˇÍ!û˛ò◊yı$jÿ0QyìÎ:˚¥AI‹é˚Bl◊ê(˜Rı-πr.iy[n˝“R˙\"Ωí†#TãØ›ﬁ¡4O1rù-¡‘èmXÜ}â->#∞.@Jj\Z]{ˆì¡/Nü˛¨÷ãÿf\0\0','6.0.0-20911');
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
INSERT INTO `pessoafisica` VALUES (1,'Lucas','2','2',NULL,'2',NULL,'1992-02-02 00:00:00'),(2,'Pedrinho','assstente','1234',NULL,NULL,NULL,'1992-04-04 00:00:00'),(3,'Samule Muc√£o','4','4',NULL,NULL,NULL,'1990-04-04 00:00:00'),(4,'Samule Muc√£o','4','4',NULL,NULL,NULL,'1990-04-04 00:00:00');
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
