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

namespace ProjetoA3_CadastroDeAlunos.Src.Forms.Teacher
{
    public partial class RelatorioAcademico : ProjetoA3_CadastroDeAlunos.Templates.MenuForm.MenuForm
    {
        public RelatorioAcademico()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RelatorioAcademico_Load(object sender, EventArgs e)
        {
            this.CarregarCursos();
        }

        private void report_combo_cursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (report_combo_cursos.SelectedIndex >= 0 && report_combo_cursos.SelectedValue != null && report_combo_cursos.SelectedValue is int)
            {
                int idCurso = Convert.ToInt32(report_combo_cursos.SelectedValue);
                this.CarregarEstatisticaPorCurso(idCurso);
            }
        }

        private void CarregarCursos()
        {
            int IdFuncionario = UserSession.IdTipo;
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();

                string query = @"
                    SELECT 
                        curso.Nome,
                        curso.IdCurso
                    FROM 
                        curso
                    WHERE 
                        IdFuncionario = @IdFuncionario
                    AND 
                        Status = 0;
                ";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Parâmetro para o IdFuncionario (ajuste conforme necessário)
                    command.Parameters.AddWithValue("@IdFuncionario", UserSession.IdTipo);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        report_combo_cursos.DataSource = dt;
                        report_combo_cursos.DisplayMember = "Nome";    // O nome que aparecerá no ComboBox
                        report_combo_cursos.ValueMember = "IdCurso";   // O valor interno (ID do curso)
                    }
                }
            }
        }

        private void CarregarEstatisticaPorCurso(int idCurso)
        {
            string query = @"
                SELECT 
                    c.IdCurso,
                    c.Nome AS NomeCurso,
                    c.MediaAprovacao,
                    c.NumeroProvas,
                    c.Recuperacao,
                    COUNT(ac.IdAluno_Curso) AS TotalAlunos,
                    SUM(CASE 
                            WHEN ac.Resultado IN ('Aprovado', 'Aprovado na Recuperação') THEN 1
                            ELSE 0
                        END) AS TotalAprovados,
                    SUM(CASE 
                            WHEN ac.Resultado = 'Reprovado' THEN 1
                            ELSE 0
                        END) AS TotalReprovados,
                    ROUND(AVG(CASE WHEN n.Recuperacao = TRUE THEN n.Valor END), 2) AS MediaNotasRecuperacao,
                    ROUND(AVG(CASE WHEN n.Recuperacao = FALSE THEN n.Valor END), 2) AS MediaNotasRegulares,
                    ROUND(AVG(n.Valor), 2) AS MediaNotasLancadas,
                    ROUND(AVG(ac.MediaFinal), 2) AS MediaTotal
                FROM Curso c
                LEFT JOIN Aluno_Curso ac ON c.IdCurso = ac.IdCurso
                LEFT JOIN Nota n ON ac.IdAluno_Curso = n.IdAluno_Curso
                WHERE c.IdCurso = @idCurso
                GROUP BY c.IdCurso, c.Nome
                LIMIT 1;
            ";

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
                            if (reader.Read())
                            {
                                // Supondo que você tenha labels com esses nomes:
                                lbl_alunosTotal.Text = reader["TotalAlunos"].ToString();
                                lbl_alunosAprovados.Text = reader["TotalAprovados"].ToString();
                                lbl_alunosReprovados.Text = reader["TotalReprovados"].ToString();
                                lbl_mediaRecuperacao.Text = reader["MediaNotasRecuperacao"] != DBNull.Value ? reader["MediaNotasRecuperacao"].ToString() : "0";
                                lbl_mediaRegulares.Text = reader["MediaNotasRegulares"] != DBNull.Value ? reader["MediaNotasRegulares"].ToString() : "0";
                                lbl_mediaGeral.Text = reader["MediaNotasLancadas"] != DBNull.Value ? reader["MediaNotasLancadas"].ToString() : "0";
                                lbl_mediaTotal.Text = reader["MediaTotal"] != DBNull.Value ? reader["MediaTotal"].ToString() : "0";

                                lbl_MediaAprovacao.Text = reader["MediaAprovacao"] != DBNull.Value ? reader["MediaAprovacao"].ToString() : "0";
                                lbl_quantidadeProvas.Text = reader["NumeroProvas"] != DBNull.Value ? reader["NumeroProvas"].ToString() : "0";
                                lbl_Recuperacao.Text = Convert.ToBoolean(reader["Recuperacao"]) ? "Sim" : "Não";

                            }
                            else
                            {
                                MessageBox.Show("Nenhum dado encontrado para o curso selecionado.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar estatísticas do curso: " + ex.Message);
                }
            }
        }

    }
}
