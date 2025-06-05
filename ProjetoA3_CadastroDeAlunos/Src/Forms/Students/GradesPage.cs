using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProjetoA3_CadastroDeAlunos.Src.Repositories;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoA3_CadastroDeAlunos.Src.Forms.GradesPage
{
    public partial class GradesPage : ProjetoA3_CadastroDeAlunos.Templates.MenuForm.MenuForm
    {
        public GradesPage()
        {
            InitializeComponent();
        }

        private void GradesPage_Load(object sender, EventArgs e)
        {
            int idAluno = UserSession.IdTipo;
            CarregarCursos(idAluno);
        }

        private void Graee_comb_disci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Graee_comb_disci.SelectedIndex >= 0 && Graee_comb_disci.SelectedValue != null && Graee_comb_disci.SelectedValue is int)
            {
                int idCurso = Convert.ToInt32(Graee_comb_disci.SelectedValue);
                int idAluno = UserSession.IdTipo;

                CarregarNotas(idAluno, idCurso);
            }
        }

        private void CarregarCursos(int idAluno)
        {
            string query = @"SELECT Curso.IdCurso, Curso.Nome 
                     FROM Aluno
                     INNER JOIN Aluno_Curso ON Aluno.IdAluno = Aluno_Curso.IdAluno
                     INNER JOIN Curso ON Aluno_Curso.IdCurso = Curso.IdCurso
                     WHERE Aluno.IdAluno = @IdAluno
                     AND Curso.Status = 1;";

            using (MySqlConnection connection = Connection.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IdAluno", idAluno);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            Graee_comb_disci.DataSource = dt;
                            Graee_comb_disci.DisplayMember = "Nome";    // O nome que aparecerá no ComboBox
                            Graee_comb_disci.ValueMember = "IdCurso";   // O valor interno (ID do curso)
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar cursos: " + ex.Message);
                }
            }
        }

        private void dataGridNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CarregarNotas(int idAluno, int idCurso)
        {
            lbl_situacao.Text = "-";
            lbl_DataFim.Text = "-";
            lbl_media.Text = "-";

            string query = @"SELECT 
                        CASE 
                            WHEN Recuperacao = 1 THEN 'Prova de Recuperação'
                            ELSE CONCAT('Prova ', Ordem)
                        END AS ""Avaliação"",
                        Nota.Valor,
                        Nota.DataLancamento as ""Data de Correção"",
                        Aluno_Curso.Resultado,
                        Aluno_Curso.MediaFinal,
                        Aluno_Curso.DataFim as ""Ultima Atualização""
                     FROM 
                        Aluno
                     INNER JOIN 
                        Aluno_Curso ON Aluno.IdAluno = Aluno_Curso.IdAluno
                     INNER JOIN 
                        Nota ON Aluno_Curso.IdAluno_Curso = Nota.IdAluno_Curso
                     WHERE 
                        Aluno.IdAluno = @IdAluno
                        AND Aluno_Curso.IdCurso = @IdCurso
                        AND Nota.Corrigida = 1";

            using (MySqlConnection connection = Connection.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IdAluno", idAluno);
                        cmd.Parameters.AddWithValue("@IdCurso", idCurso);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridNotas.DataSource = dt;

                            dataGridNotas.Columns["Resultado"].Visible = false;
                            dataGridNotas.Columns["MediaFinal"].Visible = false;
                            dataGridNotas.Columns["Ultima Atualização"].Visible = false;

                            

                            if (dt.Rows.Count > 0)
                            {
                                DataRow row = dt.Rows[0];

                                lbl_situacao.Text = row["Resultado"] == DBNull.Value 
                                    ? "-" 
                                    : row["Resultado"].ToString();
                                
                                if (row["MediaFinal"] != DBNull.Value)
                                {
                                    double mediaFinal = Convert.ToDouble(row["MediaFinal"]);
                                    lbl_media.Text = mediaFinal.ToString("F2"); // ex: 7.50
                                }

                                lbl_DataFim.Text = row["Ultima Atualização"] == DBNull.Value
                                    ? "-"
                                    : Convert.ToDateTime(row["Ultima Atualização"]).ToString("dd/MM/yyyy");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar notas: " + ex.Message);
                }
            }
        }

    }
}
