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

namespace ProjetoA3_CadastroDeAlunos.Src.Forms.HistoricalPage
{
    public partial class HistoricalPage : ProjetoA3_CadastroDeAlunos.Templates.MenuForm.MenuForm
    {
        public HistoricalPage()
        {
            InitializeComponent();
        }

        private void HistoricalPage_Load(object sender, EventArgs e)
        {

            string query = @"
            SELECT 
                Curso.Nome as ""Curso"",
                Curso.Duracao as ""Duração"",
	            ROUND(aluno_curso.MediaFinal, 2) as ""Média Final"",
	            aluno_curso.Resultado as ""Situação"",
	            aluno_curso.DataFim as ""Data""
            FROM Aluno_curso
            INNER JOIN Curso
	            ON Aluno_Curso.IdCurso = Curso.IdCurso
            WHERE 
	            aluno_curso.Finalizado = 1 
                AND IdAluno = @IdAluno
                AND Curso.Status = 0;
            ";
            
            using (MySqlConnection connection = Connection.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IdAluno", UserSession.IdTipo);

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            Hist_DtGrd_Cursos.DataSource = dt;
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
