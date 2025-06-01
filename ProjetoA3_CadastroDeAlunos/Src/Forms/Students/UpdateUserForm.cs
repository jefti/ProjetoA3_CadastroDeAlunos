using MySql.Data.MySqlClient;
using ProjetoA3_CadastroDeAlunos.Src.Repositories;

namespace ProjetoA3_CadastroDeAlunos.Src.Forms.Students
{
    public partial class UpdateUserForm : ProjetoA3_CadastroDeAlunos.Templates.MenuForm.MenuForm
    {
        public UpdateUserForm()
        {
            InitializeComponent();
        }

        private void UpdateUserForm_Load(object sender, EventArgs e)
        {
            Reg_txt_nome_updt.Text = UserSession.Nome;
            Reg_txt_email_updt.Text = UserSession.Email;
            Reg_msktxt_telefone_updt.Text = UserSession.Telefone;
        }

        private void Reg_btn__updt_Click(object sender, EventArgs e)
        {

            Reg_msktxt_telefone_updt.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // Captura os dados dos TextBoxes

            string nome = Reg_txt_nome_updt.Text.Trim();
            string email = Reg_txt_email_updt.Text.Trim();
            string telefone = Reg_msktxt_telefone_updt.Text.Trim();
            int id = UserSession.IdUsuario;

            // Simula atualização (pode ser adaptado para banco de dados)
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(telefone))
            {
                MessageBox.Show("Preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (MySqlConnection connection = Connection.GetConnection())
                {
                    connection.Open();

                    string sql = "UPDATE Usuario SET nome = @nome, email = @email, telefone = @telefone WHERE IdUsuario = @IdUsuario";
                    using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    {
                        cmd.Parameters.AddWithValue("@IdUsuario", id);
                        cmd.Parameters.AddWithValue("@nome", nome);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@telefone", telefone);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cadastro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            UserSession.Nome = nome;
                            UserSession.Email = email;
                            UserSession.Telefone = telefone;
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro encontrado com esse ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar cadastro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
