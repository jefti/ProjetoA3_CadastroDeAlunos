using MySql.Data.MySqlClient;
using ProjetoA3_CadastroDeAlunos.Forms.LoginForm;
using ProjetoA3_CadastroDeAlunos.Src.Repositories;

namespace ProjetoA3_CadastroDeAlunos.Src.Forms.Login
{
    public partial class PasswordREC : Form
    {
        public PasswordREC()
        {
            InitializeComponent();
        }

        private void btn_confirmar_senha_Click(object sender, EventArgs e)
        {
            Rec_msktxt_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            string email = Rec_txt_email.Text.Trim();
            string cpf = Rec_msktxt_cpf.Text.Trim();
            string senha = Rec_txt_senha.Text.Trim();
            int id = UserSession.IdUsuario;

            if (string.IsNullOrEmpty(cpf) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = Connection.GetConnection())
                {
                    connection.Open();

                    string sql = "UPDATE Usuario SET senha = @senha WHERE cpf = @cpf AND email = @email";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@cpf", cpf);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@senha", senha);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Senha alterada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.NavToLogin();
                        }
                        else
                        {
                            MessageBox.Show("CPF ou E-mail incorreto(s).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar a senha: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void NavToLogin()
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Close();
        }

        private void Rec_btn_cancelar_Click(object sender, EventArgs e)
        {
            this.NavToLogin();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
