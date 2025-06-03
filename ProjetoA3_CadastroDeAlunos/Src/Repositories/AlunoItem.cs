using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoA3_CadastroDeAlunos.Src.Repositories
{
    public class AlunoItem
    {
        public int IdAluno { get; set; }
        public string Nome { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}
