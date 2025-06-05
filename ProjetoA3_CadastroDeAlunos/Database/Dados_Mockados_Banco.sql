

-- Inserindo 2 alunos
INSERT INTO Usuario (Email, Senha, Nome, Cpf, Telefone, Tipo, Endereco)
VALUES
('ana.silva@gmail.com', '123', 'Ana Silva', '12345678901', '84999998888', 'aluno', 'Rua das Flores, 123'),
('bruno.souza@gmail.com', '123', 'Bruno Souza', '98765432100', '84988887777', 'aluno', 'Av. Central, 456'),
('aluno@email.com', '123', 'Aluno', '98765431233', '84988812345', 'aluno', 'Av. Central, 456');

-- Inserindo na tabela Aluno (usando os Ids gerados acima - supondo que sejam 1 e 2)
INSERT INTO Aluno (IdUsuario)
VALUES (1), (2), (3);

-- Inserindo 2 funcionários
INSERT INTO Usuario (Email, Senha, Nome, Cpf, Telefone, Tipo, Endereco)
VALUES
('maria.professora@gmail.com', '123', 'Maria Oliveira', '11223344556', '84987776655', 'funcionario', 'Rua do Saber, 789'),
('joao.admin@gmail.com', '123', 'João Pereira', '66554433221', '84986665544', 'funcionario', 'Travessa da Paz, 987'),
('professor@email.com', '123', 'Professor', '66554433112', '84912313123', 'funcionario', 'Travessa da Paz, 987');

-- Inserindo na tabela Funcionario (usando os Ids gerados acima - supondo que sejam 3 e 4)
INSERT INTO Funcionario (IdUsuario, Cargo)
VALUES 
(4, 'Professor'),
(5, 'Professor'),
(6, 'Professor');

INSERT INTO Usuario (Email, Senha, Nome, Cpf, Telefone, Tipo, Endereco)
VALUES
('admin@email.com', '123', 'Administrador', '99910010099', '84987999955', 'administrador', 'Rua do Saber, 789');

INSERT INTO Administrador (IdUsuario)
VALUES (7);


INSERT INTO Categoria (Nome) VALUES
('Informática'),
('Culinária'),
('Enfermagem');
