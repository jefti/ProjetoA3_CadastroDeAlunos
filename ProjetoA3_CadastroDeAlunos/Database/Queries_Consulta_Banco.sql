SELECT * 
FROM gerenciamento_alunos.aluno
INNER JOIN gerenciamento_alunos.usuario 
WHERE gerenciamento_alunos.aluno.IdUsuario = gerenciamento_alunos.usuario.IdUsuario ;

SELECT * 
FROM funcionario
INNER JOIN usuario
WHERE gerenciamento_alunos.funcionario.IdUsuario = gerenciamento_alunos.usuario.IdUsuario ;

SELECT * FROM categoria;

SELECT * FROM curso;

SELECT 
AC.IdAluno_Curso as Matricula,
U.Nome,
U.Cpf,
C.Nome as Curso,
N.Ordem as Ordem,
N.Valor as Nota
FROM Aluno_Curso as AC
INNER JOIN Aluno as A 
	ON AC.IdAluno = A.IdAluno
INNER JOIN usuario as U
	ON U.IdUsuario = A.IdUsuario
INNER JOIN curso as c
	ON C.IdCurso = AC.IdCurso
Inner JOIN Nota as N
	ON N.IdAluno_Curso = AC.IdAluno_Curso
ORDER BY Ordem;

