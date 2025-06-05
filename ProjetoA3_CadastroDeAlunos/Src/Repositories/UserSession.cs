using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoA3_CadastroDeAlunos.Src.Repositories
{
    public static class UserSession
    {
        public static int IdUsuario { get; set; }
        public static string Nome { get; set; }
        public static string Cpf { get; set; }
        public static string Email { get; set; }
        public static string Telefone { get; set; }
        public static string Endereco { get; set; }
        public static string Tipo { get; set; }
        public static int IdTipo { get; set; }
        public static string GetFirstName() 
        {
            if (string.IsNullOrWhiteSpace(Nome))
                return string.Empty;

            var listaNomes = Nome.Trim().Split(' ');
            return listaNomes[0];
        }

        public static string GetMaskedCpf() 
        {
            if (Cpf.Length == 11)
            {
                return Convert.ToUInt64(Cpf).ToString(@"000\.000\.000\-00");
            }

            return Cpf;
        }

        public static string GetMaskedTelefone()
        {
            if (Telefone.Length == 11)
            {
                return Convert.ToUInt64(Telefone).ToString(@"\(00\) 00000\-0000");
            }

            return Telefone;
        }

        public static void Logout() 
        {
            IdUsuario = 0;
            Nome = string.Empty;
            Cpf = string.Empty;
            Cpf = string.Empty;
            Email = string.Empty;
            Telefone = string.Empty;
            Endereco = string.Empty;
        }

    }
}
