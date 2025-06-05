using ProjetoA3_CadastroDeAlunos.Src.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoA3_CadastroDeAlunos.Src.Forms.LandingPage
{
    public partial class LandingPage : ProjetoA3_CadastroDeAlunos.Templates.MenuForm.MenuForm
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {
            Land_txt_nome.Text = UserSession.Nome;
            Land_txt_cpf.Text = UserSession.GetMaskedCpf();
            Land_txt_telefone.Text = UserSession.GetMaskedTelefone();
            Land_txt_email.Text = UserSession.Email;
            Land_txt_endereco.Text = UserSession.Endereco;
        }

    }
}
