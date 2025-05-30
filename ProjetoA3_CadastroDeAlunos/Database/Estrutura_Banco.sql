CREATE DATABASE `Gerenciamento_Alunos`;
use `Gerenciamento_Alunos`;

CREATE TABLE `Usuario` (
    `IdUsuario` INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
    `Email` VARCHAR(100) NOT NULL UNIQUE,
    `Senha` VARCHAR(100) NOT NULL,
	`Nome` varchar(60),
	`Cpf` varchar(14) UNIQUE,
	`Telefone` varchar(16) unique,
    `Tipo` ENUM('aluno', 'funcionario') NOT NULL,
	`Endereco` varchar(100)
);

CREATE TABLE `Funcionario` (
	`IdFuncionario` int NOT NULL UNIQUE PRIMARY KEY AUTO_INCREMENT,
    `IdUsuario` INT NOT NULL UNIQUE,
	`Cargo` varchar(60),
	FOREIGN KEY (`IdUsuario`) REFERENCES `Usuario`(`IdUsuario`)
);

CREATE TABLE `Aluno` (
	`IdAluno` int NOT NULL UNIQUE PRIMARY KEY AUTO_INCREMENT,
	`IdUsuario` INT NOT NULL UNIQUE,
	FOREIGN KEY (`IdUsuario`) REFERENCES `Usuario`(`IdUsuario`)
);

CREATE TABLE `Categoria` (
	`IdCategoria` int NOT NULL UNIQUE PRIMARY KEY AUTO_INCREMENT,
    `Nome` varchar(45)
);

CREATE TABLE `Curso` (
	`IdCurso` int NOT NULL UNIQUE PRIMARY KEY AUTO_INCREMENT,
    `IdCategoria` int NOT NULL,
    `IdFuncionario` int NOT NULL,
    `Nome` varchar(45) NOT NULL,
    `MediaAprovacao` double NOT NULL,
    `Duracao` int NOT NULL,
    `Status` Boolean NOT NULL DEFAULT TRUE,
    FOREIGN KEY (`IdCategoria`) REFERENCES `Categoria`(`IdCategoria`),
    FOREIGN KEY (`IdFuncionario`) REFERENCES `Funcionario`(`IdFuncionario`)
);


CREATE TABLE `Aluno_Curso` (
	`IdAluno_Curso` int NOT NULL UNIQUE PRIMARY KEY AUTO_INCREMENT,
    `IdAluno` int NOT NULL,
    `IdCurso` int NOT NULL,
	FOREIGN KEY (`IdAluno`) REFERENCES `Aluno`(`IdAluno`),
    FOREIGN KEY (`IdCurso`) REFERENCES `Curso`(`IdCurso`)
);


CREATE TABLE `Nota` (
	`IdNota` int NOT NULL UNIQUE PRIMARY KEY AUTO_INCREMENT,	
    `IdAluno_Curso` int NOT NULL,
    `Valor` Float,
    `Ordem` int, -- 1, 2, 3 ou 4
    `DataLancamento` DateTime DEFAULT NOW(),
    FOREIGN KEY (`IdAluno_Curso`) REFERENCES `Aluno_Curso`(`IdAluno_Curso`)
);
