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
            string email = Lgn_txt_email.Text;
            string password = Lgn_txt_senha.Text;
            try
            {
                using (MySqlConnection connection = Connection.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT * FROM aluno WHERE Email=@Email AND Senha=@Senha;";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {

                        command.Parameters.AddWithValue("@Senha", password);
                        command.Parameters.AddWithValue("@Email", email);



                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                this.NavToLandingPage();
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



        private void login_lnklbl_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm frm = new RegistrationForm();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Close();
        }


        private void NavToLandingPage()
        {
            LandingPage frm = new LandingPage();
            frm.Show();
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
        }
    }
}
