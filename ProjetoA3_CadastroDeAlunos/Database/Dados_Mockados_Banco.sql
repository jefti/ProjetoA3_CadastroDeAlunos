

-- Inserindo 2 alunos
INSERT INTO Usuario (Email, Senha, Nome, Cpf, Telefone, Tipo, Endereco)
VALUES
('ana.silva@gmail.com', 'senhaAna123', 'Ana Silva', '12345678901', '84999998888', 'aluno', 'Rua das Flores, 123'),
('bruno.souza@gmail.com', 'senhaBruno456', 'Bruno Souza', '98765432100', '84988887777', 'aluno', 'Av. Central, 456');

-- Inserindo na tabela Aluno (usando os Ids gerados acima - supondo que sejam 1 e 2)
INSERT INTO Aluno (IdUsuario)
VALUES (1), (2);

-- Inserindo 2 funcionários
INSERT INTO Usuario (Email, Senha, Nome, Cpf, Telefone, Tipo, Endereco)
VALUES
('maria.professora@gmail.com', 'senhaMaria789', 'Maria Oliveira', '11223344556', '84987776655', 'funcionario', 'Rua do Saber, 789'),
('joao.admin@gmail.com', 'senhaJoao321', 'João Pereira', '66554433221', '84986665544', 'funcionario', 'Travessa da Paz, 987');

-- Inserindo na tabela Funcionario (usando os Ids gerados acima - supondo que sejam 3 e 4)
INSERT INTO Funcionario (IdUsuario, Cargo)
VALUES 
(3, 'Professora de Matemática'),
(4, 'Coordenador Pedagógico');

INSERT INTO Categoria (Nome) VALUES
('Informática'),
('Culinária'),
('Enfermagem');

INSERT INTO Curso (IdCategoria, IdFuncionario, Nome, MediaAprovacao, Duracao)
VALUES (1, 1, 'Algoritmo', 7.0, 180);

INSERT INTO Curso (IdCategoria, IdFuncionario, Nome, MediaAprovacao, Duracao)
VALUES (2, 2, 'Pizzaiolo', 7.0, 20);


INSERT INTO Aluno_Curso (IdAluno, IdCurso)
VALUES (1, 1), (2,1);

INSERT INTO Aluno_Curso (IdAluno, IdCurso)
VALUES (1, 2);

INSERT INTO Nota (`IdAluno_Curso`, `Valor`, `Ordem`)
VALUES (1, 6.0, 2);
