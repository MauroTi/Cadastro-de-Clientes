-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.1.37-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win32
-- HeidiSQL Versão:              10.2.0.5599
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Copiando dados para a tabela cliente.clientes: ~5 rows (aproximadamente)
DELETE FROM `clientes`;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` (`id`, `nome`, `endereco`, `telefone_fixo`, `telefone_celular_1`, `telefone_celular_2`, `telefone_celular_3`, `observacoes`) VALUES
	(2, 'Mauro', 'rua manoel ferrador, 134', '5199947696', '', '', '000', ''),
	(5, 'Leilane', 'av joão pessoa, 555', '32314567', '', NULL, NULL, NULL),
	(7, '', '', '999999999', '', NULL, NULL, NULL),
	(8, 'Eu', '', '999999999', '', NULL, NULL, NULL),
	(9, 'mauro2', '', '999999999', '', NULL, NULL, NULL);
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;

-- Copiando dados para a tabela cliente.registro: ~6 rows (aproximadamente)
DELETE FROM `registro`;
/*!40000 ALTER TABLE `registro` DISABLE KEYS */;
INSERT INTO `registro` (`id`, `idcliente`, `registro_chamado`, `data_chamado`) VALUES
	(1, 2, 'bla\n', '0000-00-00 00:00:00'),
	(2, 2, 'bla bla\n', '0000-00-00 00:00:00'),
	(3, 2, 'uiotg5jpoy´poyk\n', '2019-12-15 00:00:00'),
	(4, 2, 'hjlhluiluiluiluil\n', '2019-12-15 17:21:54'),
	(5, 2, '\n', '2019-12-15 17:24:14'),
	(6, 2, 'fjfyyukfuykfykfgyy\n', '2019-12-15 19:38:49');
/*!40000 ALTER TABLE `registro` ENABLE KEYS */;

-- Copiando dados para a tabela cliente.usuarios: ~1 rows (aproximadamente)
DELETE FROM `usuarios`;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` (`id`, `nome`, `usuario`, `senha`) VALUES
	(5, 'Mauro', 'mmm@mmm', '333');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
