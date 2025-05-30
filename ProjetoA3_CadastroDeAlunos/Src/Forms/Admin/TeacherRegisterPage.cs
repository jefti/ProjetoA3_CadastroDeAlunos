using MySql.Data.MySqlClient;
using ProjetoA3_CadastroDeAlunos.Src.Repositories;

namespace ProjetoA3_CadastroDeAlunos.Src.Forms.TeacherRegisterPage
{
    public partial class TeacherRegisterPage : ProjetoA3_CadastroDeAlunos.Templates.MenuForm.MenuForm
    {
        public TeacherRegisterPage()
        {
            InitializeComponent();
        }

        private void TeacherRegisterPage_Load(object sender, EventArgs e)
        {
            Reg_txt_nome_prof.MaxLength = 60;
            Reg_msktxt_senha_prof.MaxLength = 45;
            Reg_txt_email_prof.MaxLength = 60;
            Reg_txt_endereco_prof.MaxLength = 100;
        }

        private void Reg_btn_salvar_prof_Click_1(object sender, EventArgs e)
        {
            string nome = Reg_txt_nome_prof.Text.Trim();
            string cpf = Reg_msktxt_cpf_prof.Text.Trim();
            string phone = Reg_msktxt_telefone_prof.Text.Trim();
            string email = Reg_txt_email_prof.Text.Trim();
            string address = Reg_txt_endereco_prof.Text.Trim();
            string cargo = Reg_txt_cargo_prof.Text.Trim();
            string senha = Reg_msktxt_senha_prof.Text.Trim();
            string tipo = "funcionario";

            try
            {
                using (MySqlConnection connection = Connection.GetConnection())
                {
                    connection.Open();

                    // Iniciar transação
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        // Verificar duplicidade
                        string checkUserQuery = @"SELECT COUNT(*) FROM Usuario
                                          WHERE Email = @Email OR Cpf = @Cpf OR Telefone = @Telefone";

                        using (MySqlCommand checkCommand = new MySqlCommand(checkUserQuery, connection, transaction))
                        {
                            checkCommand.Parameters.AddWithValue("@Email", email);
                            checkCommand.Parameters.AddWithValue("@Cpf", cpf);
                            checkCommand.Parameters.AddWithValue("@Telefone", phone);

                            int exists = Convert.ToInt32(checkCommand.ExecuteScalar());
                            if (exists > 0)
                            {
                                MessageBox.Show("Já existe um usuário com o mesmo e-mail, CPF ou telefone.");
                                return;
                            }
                        }

                        // Inserir usuário
                        string insertUserQuery = @"INSERT INTO Usuario (Email, Senha, Nome, Cpf, Telefone, Tipo, Endereco)
                                           VALUES (@Email, @Senha, @Nome, @Cpf, @Telefone, @Tipo, @Endereco);";

                        using (MySqlCommand userCommand = new MySqlCommand(insertUserQuery, connection, transaction))
                        {
                            userCommand.Parameters.AddWithValue("@Email", email);
                            userCommand.Parameters.AddWithValue("@Senha", senha);
                            userCommand.Parameters.AddWithValue("@Nome", nome);
                            userCommand.Parameters.AddWithValue("@Cpf", cpf);
                            userCommand.Parameters.AddWithValue("@Telefone", phone);
                            userCommand.Parameters.AddWithValue("@Tipo", tipo);
                            userCommand.Parameters.AddWithValue("@Endereco", address);

                            int userRows = userCommand.ExecuteNonQuery();

                            if (userRows == 0)
                            {
                                MessageBox.Show("Falha ao cadastrar professor.");
                                transaction.Rollback();
                                return;
                            }
                        }

                        // Obter ID do usuário inserido
                        long userId;
                        using (MySqlCommand idCommand = new MySqlCommand("SELECT LAST_INSERT_ID();", connection, transaction))
                        {
                            userId = Convert.ToInt64(idCommand.ExecuteScalar());
                        }

                        // Inserir funcionário
                        string insertProfQuery = "INSERT INTO Funcionario (IdUsuario, Cargo) VALUES (@IdUsuario, @Cargo);";
                        using (MySqlCommand profCommand = new MySqlCommand(insertProfQuery, connection, transaction))
                        {
                            profCommand.Parameters.AddWithValue("@IdUsuario", userId);
                            profCommand.Parameters.AddWithValue("@Cargo", cargo);

                            int profRows = profCommand.ExecuteNonQuery();

                            if (profRows > 0)
                            {
                                transaction.Commit();
                                MessageBox.Show("Professor cadastrado com sucesso!");

                            }
                            else
                            {
                                transaction.Rollback();
                                MessageBox.Show("Falha ao cadastrar Professor.");
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


    }
}




