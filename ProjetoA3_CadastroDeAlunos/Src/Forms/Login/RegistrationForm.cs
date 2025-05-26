using MySql.Data.MySqlClient;
using ProjetoA3_CadastroDeAlunos.Forms.LoginForm;
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

            string nome = Reg_txt_nome.Text;
            string cpf = Reg_msktxt_cpf.Text;
            string phone = Reg_msktxt_telefone.Text;
            string password = Reg_msktxt_senha.Text;
            string email = Reg_txt_email.Text;
            string address = Reg_txt_endereco.Text;


            try
            {
                using (MySqlConnection connection = Connection.GetConnection())
                {
                    connection.Open();

                    string query = "INSERT INTO Aluno (Nome, Cpf, Telefone, Senha, Email, Endereco) " +
                                   "VALUES (@Nome, @Cpf, @Telefone, @Senha, @Email, @Endereco);";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", nome);
                        command.Parameters.AddWithValue("@Cpf", cpf);
                        command.Parameters.AddWithValue("@Telefone", phone);
                        command.Parameters.AddWithValue("@Senha", password);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Endereco", address);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Aluno cadastrado com sucesso!");
                            this.NavToLogin();
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro foi inserido.");
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

    }
}
