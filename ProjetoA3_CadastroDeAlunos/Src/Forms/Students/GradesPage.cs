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
                     WHERE Aluno.IdAluno = @IdAluno";

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
        
            string query = @"SELECT 
                        Nota.IdNota,
                        Nota.Valor,
                        Nota.Ordem,
                        Nota.DataLancamento
                     FROM 
                        Aluno
                     INNER JOIN 
                        Aluno_Curso ON Aluno.IdAluno = Aluno_Curso.IdAluno
                     INNER JOIN 
                        Nota ON Aluno_Curso.IdAluno_Curso = Nota.IdAluno_Curso
                     WHERE 
                        Aluno.IdAluno = @IdAluno
                        AND Aluno_Curso.IdCurso = @IdCurso";

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
