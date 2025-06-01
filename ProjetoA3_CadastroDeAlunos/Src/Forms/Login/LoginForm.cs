using MySql.Data.MySqlClient;
using ProjetoA3_CadastroDeAlunos.Src.Forms.LandingPage;
using ProjetoA3_CadastroDeAlunos.Src.Forms.Login;
using ProjetoA3_CadastroDeAlunos.Src.Repositories;

namespace ProjetoA3_CadastroDeAlunos.Forms.LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Login_btn_logar_Click(object sender, EventArgs e)
        {
            string email = Lgn_txt_email.Text.Trim();
            string password = Lgn_txt_senha.Text;

            try
            {
                using (MySqlConnection connection = Connection.GetConnection())
                {
                    connection.Open();

                    string query = @"
                        SELECT u.IdUsuario, u.Nome, u.Cpf, u.Email, u.Telefone, u.Endereco, u.Tipo,
                               a.IdAluno, f.IdFuncionario, ad.IdAdministrador
                        FROM Usuario u
                        LEFT JOIN Aluno a ON u.IdUsuario = a.IdUsuario
                        LEFT JOIN Funcionario f ON u.IdUsuario = f.IdUsuario
                        LEFT JOIN Administrador ad ON u.IdUsuario = ad.IdUsuario
                        WHERE u.Email = @Email AND u.Senha = @Senha";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Senha", password);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                UserSession.IdUsuario = reader.GetInt32("IdUsuario");
                                UserSession.Nome = reader.GetString("Nome");
                                UserSession.Cpf = reader.GetString("Cpf");
                                UserSession.Email = reader.GetString("Email");
                                UserSession.Telefone = reader.GetString("Telefone");
                                UserSession.Endereco = reader.GetString("Endereco");
                                UserSession.Tipo = reader.GetString("Tipo");

                                // Salvar o Id específico com base no tipo
                                switch (UserSession.Tipo)
                                {
                                    case "aluno":
                                        UserSession.IdTipo = reader.IsDBNull(reader.GetOrdinal("IdAluno")) ? 0 : reader.GetInt32("IdAluno");
                                        break;
                                    case "funcionario":
                                        UserSession.IdTipo = reader.IsDBNull(reader.GetOrdinal("IdFuncionario")) ? 0 : reader.GetInt32("IdFuncionario");
                                        break;
                                    case "administrador":
                                        UserSession.IdTipo = reader.IsDBNull(reader.GetOrdinal("IdAdministrador")) ? 0 : reader.GetInt32("IdAdministrador");
                                        break;
                                }

                                MessageBox.Show($"Bem-vindo, {UserSession.Nome}!");

                                this.NavToLandingPage(); // ou redirecionar para telas diferentes se desejar
                            }
                            else
                            {
                                MessageBox.Show("Email ou senha incorretos.");
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao MySQL: " + ex.Message);
            }
        }


        private void NavToLandingPage()
        {
            LandingPage frm = new LandingPage();
            frm.Show();
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
        }

        private void login_lnklbl_register_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm frm = new RegistrationForm();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Close();
        }
    }
}
