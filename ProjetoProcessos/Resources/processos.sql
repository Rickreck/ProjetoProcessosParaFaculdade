-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 29/05/2025 às 15:19
-- Versão do servidor: 10.4.32-MariaDB
-- Versão do PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `processos`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `login`
--

CREATE TABLE `login` (
  `id` int(11) NOT NULL,
  `nome de usuário` varchar(80) NOT NULL,
  `email` varchar(100) NOT NULL,
  `senha` varchar(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `login`
--

INSERT INTO `login` (`id`, `nome de usuário`, `email`, `senha`) VALUES
(2, '', '', ''),
(3, 'khrçilhepç', 'çhe.çited.li,eçl.çwtl', '$2a$11$5f3IQ7/JsGvXt'),
(4, '', '', '$2a$11$41IP5eyq49BLv'),
(5, 'oi', 'oioioioi', '$2a$11$fNPQZ49Pqgab7wwfaY9sJu/qKooGOkMX6oBacbEZJQ4FkUCPp5BuW'),
(6, 'Rickreck', 'eiwsiywi@gmail.com', '$2a$11$60rysFgbwi2T/ReE1r4.3O.65zUlnkGOevY7dLU6K7JWG.POvZHae'),
(7, 'Roberto', 'robertopereira@gmal.com', '$2a$11$2AVQawMbdr3BLDKw3hvcgOzimfKLdsGDsIGw68y8OhNgo.HmY9h0q'),
(8, 'Carlos123', 'carlos@gmail.com', '$2a$11$cXQX7MDo.e22UeVOWlgadOQq/Uoi9RXpVXe84jWiR0PGXP0waM.A.');

-- --------------------------------------------------------

--
-- Estrutura para tabela `processos`
--

CREATE TABLE `processos` (
  `id` int(11) NOT NULL,
  `nome` varchar(80) NOT NULL,
  `local` varchar(80) DEFAULT NULL,
  `telefone` varchar(17) DEFAULT NULL,
  `data` date NOT NULL,
  `data final` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `processos`
--

INSERT INTO `processos` (`id`, `nome`, `local`, `telefone`, `data`, `data final`) VALUES
(24, 'Avaliação de Riscos Estruturais', 'Fortaleza–CE', '85998321102', '2024-03-15', '2025-06-15'),
(25, 'Regularização de Documentos Patrimoniais', 'SãoPaulo–SP', '11937620045', '2023-11-02', '2025-11-05'),
(26, 'Revisão Estratégica de Contratos Terceirizados', '( não informado )', '', '2024-08-29', '2026-01-01'),
(27, 'Implantação do Sistema Integrado de Logística', 'Curitiba-PR', '41999451223', '2025-02-02', '2026-07-01'),
(28, 'Revisão Estratégica de Contratos Terceirizados', '( não informado )', '', '2025-09-01', '2025-08-17'),
(29, 'Apuração de Irregularidades Administrativas', 'Remoto', '', '2025-04-04', '2025-07-17'),
(30, 'Auditoria Interna de Recursos Humanos', 'Remoto', '', '2025-07-14', '2025-07-16'),
(31, 'Gerenciamento de Crises Operacionais', 'Salvador - BA', '', '2025-09-18', '2025-10-28');

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`id`);

--
-- Índices de tabela `processos`
--
ALTER TABLE `processos`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `login`
--
ALTER TABLE `login`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `processos`
--
ALTER TABLE `processos`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
