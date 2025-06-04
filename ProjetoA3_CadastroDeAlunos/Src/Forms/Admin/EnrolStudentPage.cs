using MySql.Data.MySqlClient;
using ProjetoA3_CadastroDeAlunos.Src.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ProjetoA3_CadastroDeAlunos.Src.Forms.Admin
{
    public partial class EnrolStudentPage : ProjetoA3_CadastroDeAlunos.Templates.MenuForm.MenuForm
    {
        public EnrolStudentPage()
        {
            InitializeComponent();
        }

        private void EnrolStudentPage_Load(object sender, EventArgs e)
        {
            this.CarregarCursos();
        }

        private void CarregarCursos()
        {
            string query = @"SELECT Curso.IdCurso, Curso.Nome 
                     FROM Curso
                     WHERE Curso.Status = 1";

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

                            Enrol_combo_courses.DataSource = dt;
                            Enrol_combo_courses.DisplayMember = "Nome";
                            Enrol_combo_courses.ValueMember = "IdCurso";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar cursos: " + ex.Message);
                }
            }

        }
        private void CarregarAlunosPorCurso(int idCurso)
        {
            string query = @"SELECT 
                        Usuario.Nome,
                        Aluno.IdAluno,
                        CASE 
                            WHEN ac.IdAluno_Curso IS NOT NULL THEN 1
                            ELSE 0
                        END AS Matriculado
                    FROM Usuario
                    INNER JOIN Aluno ON Usuario.IdUsuario = Aluno.IdUsuario
                    LEFT JOIN Aluno_Curso ac 
                        ON ac.IdAluno = Aluno.IdAluno AND ac.IdCurso = @IdCurso";

            using (MySqlConnection connection = Connection.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IdCurso", idCurso);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            Enrol_lst_alunos.Items.Clear();
                            Enrol_lst_matriculados.Items.Clear();

                            foreach (DataRow row in dt.Rows)
                            {
                                string nome = row["Nome"].ToString();
                                int idAluno = Convert.ToInt32(row["IdAluno"]);
                                int matriculado = Convert.ToInt32(row["Matriculado"]);

                                AlunoItem aluno = new AlunoItem { IdAluno = idAluno, Nome = nome };

                                if (matriculado == 1)
                                    Enrol_lst_matriculados.Items.Add(aluno);
                                else
                                    Enrol_lst_alunos.Items.Add(aluno);
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

        private void Enrol_combo_courses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Enrol_combo_courses.SelectedIndex >= 0 && Enrol_combo_courses.SelectedValue != null && Enrol_combo_courses.SelectedValue is int)
            {
                int idCurso = Convert.ToInt32(Enrol_combo_courses.SelectedValue);
                this.CarregarAlunosPorCurso(idCurso);
            }
        }

        private void Enrol_btn_matricular_Click(object sender, EventArgs e)
        {
            if (Enrol_combo_courses.SelectedValue == null || !(Enrol_combo_courses.SelectedValue is int))
            {
                MessageBox.Show("Selecione um curso.");
                return;
            }

            if (Enrol_lst_alunos.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione ao menos um aluno.");
                return;
            }

            int idCurso = Convert.ToInt32(Enrol_combo_courses.SelectedValue);

            using (MySqlConnection connection = Connection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // Buscar dados do curso
                    string cursoQuery = @"SELECT NumeroProvas, Recuperacao FROM Curso WHERE IdCurso = @IdCurso";
                    int numeroProvas = 0;
                    bool permiteRecuperacao = false;

                    using (MySqlCommand cursoCmd = new MySqlCommand(cursoQuery, connection))
                    {
                        cursoCmd.Parameters.AddWithValue("@IdCurso", idCurso);
                        using (MySqlDataReader reader = cursoCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                numeroProvas = Convert.ToInt32(reader["NumeroProvas"]);
                                permiteRecuperacao = Convert.ToBoolean(reader["Recuperacao"]);
                            }
                        }
                    }

                    foreach (AlunoItem selected in Enrol_lst_alunos.SelectedItems)
                    {
                        // 1. Inserir na tabela Aluno_Curso
                        string insertAlunoCurso = @"INSERT INTO Aluno_Curso (IdAluno, IdCurso) 
                                            VALUES (@IdAluno, @IdCurso)";
                        long idAlunoCurso;

                        using (MySqlCommand cmd = new MySqlCommand(insertAlunoCurso, connection))
                        {
                            cmd.Parameters.AddWithValue("@IdAluno", selected.IdAluno);
                            cmd.Parameters.AddWithValue("@IdCurso", idCurso);
                            cmd.ExecuteNonQuery();
                            idAlunoCurso = cmd.LastInsertedId;
                        }

                        // 2. Inserir notas das provas com valor 0
                        string insertNota = @"INSERT INTO Nota (IdAluno_Curso, Valor, Ordem, Recuperacao) 
                                      VALUES (@IdAlunoCurso, 0, @Ordem, @Recuperacao)";

                        for (int i = 1; i <= numeroProvas; i++)
                        {
                            using (MySqlCommand notaCmd = new MySqlCommand(insertNota, connection))
                            {
                                notaCmd.Parameters.AddWithValue("@IdAlunoCurso", idAlunoCurso);
                                notaCmd.Parameters.AddWithValue("@Ordem", i);
                                notaCmd.Parameters.AddWithValue("@Recuperacao", false);
                                notaCmd.ExecuteNonQuery();
                            }
                        }

                        // 3. Inserir nota de recuperação (se permitido)
                        if (permiteRecuperacao)
                        {
                            using (MySqlCommand notaCmd = new MySqlCommand(insertNota, connection))
                            {
                                notaCmd.Parameters.AddWithValue("@IdAlunoCurso", idAlunoCurso);
                                notaCmd.Parameters.AddWithValue("@Ordem", numeroProvas + 1); // Recuperação vem depois das provas
                                notaCmd.Parameters.AddWithValue("@Recuperacao", true);
                                notaCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Aluno(s) matriculado(s) e notas criadas com sucesso!");
                    CarregarAlunosPorCurso(idCurso); // Atualiza listas
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao matricular alunos: " + ex.Message);
                }
            }
        }
    }
}
