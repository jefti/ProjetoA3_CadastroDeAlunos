using MySql.Data.MySqlClient;
using ProjetoA3_CadastroDeAlunos.Forms.LoginForm;
using ProjetoA3_CadastroDeAlunos.Src.Repositories;

namespace ProjetoA3_CadastroDeAlunos.Src.Forms.Login
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            Reg_txt_nome.MaxLength = 60;
            Reg_msktxt_senha.MaxLength = 45;
            Reg_txt_email.MaxLength = 60;
            Reg_txt_endereco.MaxLength = 100;
        }

        private void Reg_btn_cancelar_Click(object sender, EventArgs e)
        {
            this.NavToLogin();
        }

        private void Reg_btn_salvar_Click(object sender, EventArgs e)
        {
            Reg_msktxt_cpf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Reg_msktxt_telefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Reg_msktxt_senha.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            string nome = Reg_txt_nome.Text.Trim();
            string cpf = Reg_msktxt_cpf.Text.Trim();
            string phone = Reg_msktxt_telefone.Text.Trim();
            string password = Reg_msktxt_senha.Text.Trim();
            string email = Reg_txt_email.Text.Trim();
            string address = Reg_txt_endereco.Text.Trim();
            string tipo = "aluno";

            try
            {
                using (MySqlConnection connection = Connection.GetConnection())
                {
                    connection.Open();

                    //Passo 1: Checar campos que não podem se repetir (CPF, Email e Telefone)
                    string checkUserQuery = @"SELECT COUNT(*) FROM Usuario 
                          WHERE Email = @Email OR Cpf = @Cpf OR Telefone = @Telefone";

                    using (MySqlCommand checkCommand = new MySqlCommand(checkUserQuery, connection))
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

                    //Passo 2: Inserir o usuario
                    string insertUserQuery = @"INSERT INTO Usuario (Email, Senha, Nome, Cpf, Telefone, Tipo, Endereco)
                                       VALUES (@Email, @Senha, @Nome, @Cpf, @Telefone, @Tipo, @Endereco);";

                    using (MySqlCommand userCommand = new MySqlCommand(insertUserQuery, connection))
                    {
                        userCommand.Parameters.AddWithValue("@Email", email);
                        userCommand.Parameters.AddWithValue("@Senha", password);
                        userCommand.Parameters.AddWithValue("@Nome", nome);
                        userCommand.Parameters.AddWithValue("@Cpf", cpf);
                        userCommand.Parameters.AddWithValue("@Telefone", phone);
                        userCommand.Parameters.AddWithValue("@Tipo", tipo);
                        userCommand.Parameters.AddWithValue("@Endereco", address);

                        int userRows = userCommand.ExecuteNonQuery();

                        if (userRows == 0)
                        {
                            MessageBox.Show("Falha ao cadastrar usuário.");
                            return;
                        }
                    }

                    long userId;
                    using (MySqlCommand idCommand = new MySqlCommand("SELECT LAST_INSERT_ID();", connection))
                    {
                        userId = Convert.ToInt64(idCommand.ExecuteScalar());
                    }


                    //Passo 3: Inserir o Aluno a partir do usuario criado
                    string insertAlunoQuery = "INSERT INTO Aluno (IdUsuario) VALUES (@IdUsuario);";
                    using (MySqlCommand alunoCommand = new MySqlCommand(insertAlunoQuery, connection))
                    {
                        alunoCommand.Parameters.AddWithValue("@IdUsuario", userId);

                        int alunoRows = alunoCommand.ExecuteNonQuery();

                        if (alunoRows > 0)
                        {
                            MessageBox.Show("Aluno cadastrado com sucesso!");
                            this.NavToLogin();
                        }
                        else
                        {
                            MessageBox.Show("Falha ao cadastrar aluno.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao MySQL: " + ex.Message);
            }
        }

        private void NavToLogin()
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Close();
        }

        private void Reg_txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reg_msktxt_senha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Reg_msktxt_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Reg_msktxt_telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Reg_txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reg_txt_endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
