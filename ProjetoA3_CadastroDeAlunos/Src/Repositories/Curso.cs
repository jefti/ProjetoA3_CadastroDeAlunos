using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoA3_CadastroDeAlunos.Src.Repositories
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public string NomeCurso { get; set; }
        public string NomeProfessor { get; set; }
        public string Categoria { get; set; }
        public int Duracao { get; set; }
        public int QuantidadeProvas {  get; set; }
        public double MediaAprovacao { get; set; }
        public Boolean PossuiRecuperacao { get; set; }

        public override string ToString()
        {
            return NomeCurso;
        }

    }
}
