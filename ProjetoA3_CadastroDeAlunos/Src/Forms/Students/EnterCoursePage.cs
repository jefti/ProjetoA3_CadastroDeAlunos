using MySql.Data.MySqlClient;
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

namespace ProjetoA3_CadastroDeAlunos.Src.Forms.Students
{
    public partial class EnterCoursePage : ProjetoA3_CadastroDeAlunos.Templates.MenuForm.MenuForm
    {
        public EnterCoursePage()
        {
            InitializeComponent();
        }

        private void EnterCoursePage_Load(object sender, EventArgs e)
        {
            this.CarregarCursos();
        }

        private void CarregarCursos()
        {
            string query = @"
                    SELECT 
                        Curso.IdCurso, 
                        Curso.Nome,
                        Curso.MediaAprovacao,
                        Curso.Duracao,
                        Curso.NumeroProvas,
                        Curso.Recuperacao,
                        Usuario.Nome as ""NomeProfessor"",
                        Categoria.Nome as ""NomeCategoria""
                     FROM Curso
                    INNER JOIN Funcionario
                        ON Funcionario.IdFuncionario = Curso.IdFuncionario
                    INNER JOIN Usuario
                        ON Usuario.IdUsuario = Funcionario.IdUsuario
                    INNER JOIN Categoria
                        ON Categoria.IdCategoria = Curso.IdCategoria
                     WHERE 
                        Curso.Status = 1
                        AND Curso.IdCurso NOT IN (
                            SELECT IdCurso 
                            FROM Aluno_Curso 
                            WHERE IdAluno = @IdAluno
                        );";

            using (MySqlConnection connection = Connection.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IdAluno", UserSession.IdTipo);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            Enter_lst_cursos.Items.Clear();

                            foreach (DataRow row in dt.Rows)
                            {
                                int IdCurso = Convert.ToInt32(row["IdCurso"]);
                                string NomeCurso = row["Nome"].ToString();
                                string NomeCategoria = row["NomeCategoria"].ToString();
                                string NomeProfessor = row["NomeProfessor"].ToString();
                                int Duracao = Convert.ToInt32(row["Duracao"]);
                                int NumeroProvas = Convert.ToInt32(row["NumeroProvas"]);
                                double MediaAprovacao = Convert.ToDouble(row["MediaAprovacao"]);
                                bool Recuperacao = Convert.ToBoolean(row["Recuperacao"]);

                                Curso curso = new Curso
                                {
                                    IdCurso = IdCurso,
                                    NomeCurso = NomeCurso,
                                    Categoria = NomeCategoria,
                                    NomeProfessor = NomeProfessor,
                                    Duracao = Duracao,
                                    QuantidadeProvas = NumeroProvas,
                                    MediaAprovacao = MediaAprovacao,
                                    PossuiRecuperacao = Recuperacao
                                };
                                Enter_lst_cursos.Items.Add(curso);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar alunos: " + ex.Message);
                }
            }
        }

        private void Enter_lst_cursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enter_lst_cursos.SelectedItems.Count > 0)
            {
                this.CarregarDadosCurso();
            }
        }

        private void CarregarDadosCurso()
        {
            Curso CursoSelecionado = (Curso)Enter_lst_cursos.SelectedItem;

            Enter_lbl_CourseName.Text = CursoSelecionado.NomeCurso;
            Enter_lbl__categoria.Text = CursoSelecionado.Categoria;
            Enter_lbl__professor.Text = CursoSelecionado.NomeProfessor;
            Enter_lbl__duracao.Text = $"{CursoSelecionado.Duracao.ToString()} horas";
            Enter_lbl__MediaAprovacao.Text = CursoSelecionado.MediaAprovacao.ToString();
            Enter_lbl__numeroProvas.Text = $"{CursoSelecionado.QuantidadeProvas.ToString()} Provas";
            Enter_lbl_possuiRecuperacao.Text = (CursoSelecionado.PossuiRecuperacao == true) ? "Sim" : "Não";
        }

        private void LimparCurso()
        {
            Enter_lbl_CourseName.Text = "";
            Enter_lbl__categoria.Text = "-";
            Enter_lbl__professor.Text = "-";
            Enter_lbl__duracao.Text = "-";
            Enter_lbl__MediaAprovacao.Text = "-";
            Enter_lbl__numeroProvas.Text = "-";
            Enter_lbl_possuiRecuperacao.Text = "-";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Enter_lst_cursos.SelectedItems.Count < 1)
            {
                return;
            }

            Curso CursoSelecionado = (Curso)Enter_lst_cursos.SelectedItem;
            int IdCurso = CursoSelecionado.IdCurso;
            int QuantidadeProvas = CursoSelecionado.QuantidadeProvas;
            int IdAluno = UserSession.IdTipo;

            using (MySqlConnection connection = Connection.GetConnection())
            {
                try
                {
                    connection.Open();


                    // 1. Inserir na tabela Aluno_Curso
                    string insertAlunoCurso = @"INSERT INTO Aluno_Curso (IdAluno, IdCurso) 
                                        VALUES (@IdAluno, @IdCurso)";
                    long idAlunoCurso;

                    using (MySqlCommand cmd = new MySqlCommand(insertAlunoCurso, connection))
                    {
                        cmd.Parameters.AddWithValue("@IdAluno", IdAluno);
                        cmd.Parameters.AddWithValue("@IdCurso", IdCurso);
                        cmd.ExecuteNonQuery();
                        idAlunoCurso = cmd.LastInsertedId;
                    }

                    // 2. Inserir notas das provas com valor 0
                    string insertNota = @"INSERT INTO Nota (IdAluno_Curso, Ordem, Recuperacao) 
                                    VALUES (@IdAlunoCurso, @Ordem, @Recuperacao)";

                    for (int i = 1; i <= QuantidadeProvas; i++)
                    {
                        using (MySqlCommand notaCmd = new MySqlCommand(insertNota, connection))
                        {
                            notaCmd.Parameters.AddWithValue("@IdAlunoCurso", idAlunoCurso);
                            notaCmd.Parameters.AddWithValue("@Ordem", i);
                            notaCmd.Parameters.AddWithValue("@Recuperacao", false);
                            notaCmd.ExecuteNonQuery();
                        }
                    }

                    connection.Close();
                    MessageBox.Show("Você se inscreveu no curso com sucesso!");
                    this.CarregarCursos();
                    this.LimparCurso();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao matricular alunos: " + ex.Message);
                }
            }
        }
    }
}
