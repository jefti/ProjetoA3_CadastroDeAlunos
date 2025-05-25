using MySql.Data.MySqlClient;
using ProjetoA3_CadastroDeAlunos.Src.Forms.LandingPage;
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
                        while (reader.Read())
                        {
                            MessageBox.Show(reader["Nome"].ToString());
                        }
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
    }
}
