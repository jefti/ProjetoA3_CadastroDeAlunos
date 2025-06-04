using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoA3_CadastroDeAlunos.Src.Repositories
{
    public class AlunoCurso
    {
        public int IdAluno { get; set; }
        public string NomeAluno { get; set; }
        public int IdCurso { get; set; }    
        public string NomeCurso {  get; set; } 
        public int IdAluno_Curso { get; set; }

        public override string ToString()
        {
            return NomeAluno;
        }

    }
}
