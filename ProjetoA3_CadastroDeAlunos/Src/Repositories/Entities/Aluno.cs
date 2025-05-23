using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoA3_CadastroDeAlunos.Src.Repositories.Entities
{
    [Table("Aluno")]
    public class Aluno
    {
        [Key] //Para indicar que é a chave primaria da tabela, trocar por AlunoId depois
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }

    }
}
