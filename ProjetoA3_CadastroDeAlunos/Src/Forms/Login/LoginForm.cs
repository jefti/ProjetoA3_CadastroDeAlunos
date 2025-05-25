using MySql.Data.MySqlClient;
using ProjetoA3_CadastroDeAlunos.Src.Forms.Login;
using ProjetoA3_CadastroDeAlunos.Src.Forms.LandingPage;
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
            try
            {
                using (MySqlConnection connection = Connection.GetConnection())
                {
                    connection.Open();

                    // Exemplo de comando SQL
                    string query = "SELECT * FROM aluno";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao MySQL: " + ex.Message);
            }
        }

        private void Login_btn_logar_Click(object sender, EventArgs e)
        {
            LandingPage frm = new LandingPage();
            frm.Show();
            this.Hide();
            frm.FormClosed += (s, args) => this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_lnklbl_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm frm = new RegistrationForm();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Close();
        }
    }
}
