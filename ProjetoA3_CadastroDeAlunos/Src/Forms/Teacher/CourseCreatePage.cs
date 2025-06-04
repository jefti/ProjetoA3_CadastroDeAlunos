using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
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

namespace ProjetoA3_CadastroDeAlunos.Src.Forms.Teacher
{
    public partial class CourseCreatePage : ProjetoA3_CadastroDeAlunos.Templates.MenuForm.MenuForm
    {
        public CourseCreatePage()
        {
            InitializeComponent();
        }

        private void CourseCreatePage_Load(object sender, EventArgs e)
        {
            this.CarregarCategorias();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegC_Btn_Create_Click(object sender, EventArgs e)
        {
            if (!this.IsFieldsFilled())
            {
                MessageBox.Show("Preencha todos os campos para finalizar o cadastro.");
                return;
            }

            this.CadastrarCurso();
        }

        private bool IsFieldsFilled()
        {
            // Verifica se campos estão preenchidos
            if (string.IsNullOrWhiteSpace(RegC_Txt_Nome.Text)) return false;
            if (string.IsNullOrWhiteSpace(RegC_Txt_Duracao.Text)) return false;
            if (string.IsNullOrWhiteSpace(RegC_Txt_Media.Text)) return false;
            if (string.IsNullOrWhiteSpace(RegC_Txt_NumProvas.Text)) return false;

            if (RegC_Combo_Categoria.SelectedItem == null) return false;

            // Verifica se os campos numéricos contêm valores válidos
            if (!int.TryParse(RegC_Txt_Duracao.Text, out _)) return false;
            if (!double.TryParse(RegC_Txt_Media.Text, out _)) return false;
            if (!int.TryParse(RegC_Txt_NumProvas.Text, out _)) return false;

            return true;
        }

        private void RegC_Txt_Duracao_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas números e tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RegC_Txt_NumProvas_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas números e tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void RegC_Txt_Media_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceita apenas números e tecla Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CarregarCategorias()
        {
            string query = @"SELECT Categoria.IdCategoria, Categoria.Nome 
                     FROM Categoria";

            using (MySqlConnection connection = Connection.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            RegC_Combo_Categoria.DataSource = dt;
                            RegC_Combo_Categoria.DisplayMember = "Nome";    // O nome que aparecerá no ComboBox
                            RegC_Combo_Categoria.ValueMember = "IdCategoria";   // O valor interno (ID da Categoria)
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar cursos: " + ex.Message);
                }
            }
        }

        private void CadastrarCurso() 
        {
            if (RegC_Combo_Categoria.SelectedValue == null) return;
            string Nome = RegC_Txt_Nome.Text;
            int Duracao = Convert.ToInt32(RegC_Txt_Duracao.Text);
            int MediaAprovacao = Convert.ToInt32(RegC_Txt_Media.Text);
            int NumeroProvas = Convert.ToInt32(RegC_Txt_NumProvas.Text);
            int IdCategoria = Convert.ToInt32(RegC_Combo_Categoria.SelectedValue);
            int IdFuncionario = UserSession.IdTipo;
            Boolean Recuperacao = RegC_Radio_Yes.Checked;

            try
            {
                using (MySqlConnection connection = Connection.GetConnection())
                {
                    connection.Open();

                    string insertUserQuery = @"INSERT INTO Curso (IdCategoria, IdFuncionario, Nome, Duracao, MediaAprovacao, NumeroProvas, Recuperacao)
                                       VALUES (@IdCategoria, @IdFuncionario, @Nome, @Duracao, @MediaAprovacao, @NumeroProvas, @Recuperacao);";

                    using (MySqlCommand userCommand = new MySqlCommand(insertUserQuery, connection))
                    {
                        userCommand.Parameters.AddWithValue("@IdCategoria", IdCategoria);
                        userCommand.Parameters.AddWithValue("@IdFuncionario", IdFuncionario);
                        userCommand.Parameters.AddWithValue("@Nome", Nome);
                        userCommand.Parameters.AddWithValue("@Duracao", Duracao);
                        userCommand.Parameters.AddWithValue("@MediaAprovacao", MediaAprovacao);
                        userCommand.Parameters.AddWithValue("@NumeroProvas", NumeroProvas);
                        userCommand.Parameters.AddWithValue("@Recuperacao", Recuperacao);

                        int userRows = userCommand.ExecuteNonQuery();

                        if (userRows == 0)
                        {
                            MessageBox.Show("Falha ao cadastrar usuário.");
                            return;
                        }

                        MessageBox.Show("Cadastro realizado com sucesso.");
                        this.LimparForm();

                    }

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao MySQL: " + ex.Message);
            }
        }

        private void LimparForm()
        {
            RegC_Txt_Nome.Text = "";
            RegC_Txt_Duracao.Text = "";
            RegC_Txt_Media.Text = "";
            RegC_Txt_NumProvas.Text = "";
            RegC_Combo_Categoria.SelectedValue = 0;
        }
    }
}
