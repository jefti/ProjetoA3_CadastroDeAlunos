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

namespace ProjetoA3_CadastroDeAlunos.Src.Forms.CoursePage
{
    public partial class CoursePage : ProjetoA3_CadastroDeAlunos.Templates.MenuForm.MenuForm
    {
        public CoursePage()
        {
            InitializeComponent();
        }

        private void CoursePage_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                connection.Open();

                string query = @"
            SELECT 
                curso.Nome,
                categoria.Nome AS categoria,
                curso.MediaAprovacao,
                curso.CargaHoraria
            FROM 
                curso
            INNER JOIN 
                categoria ON categoria.IdCategoria = curso.IdCategoria
            WHERE 
                IdFuncionario = @IdFuncionario
            AND 
                Status = 1;
        ";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Parâmetro para o IdFuncionario (ajuste conforme necessário)
                    command.Parameters.AddWithValue("@IdFuncionario", 1);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable tabela = new DataTable();
                        adapter.Fill(tabela);

                        // Preencher o DataGridView com os dados
                        Curso_dtgrd_cursos.DataSource = tabela;




                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
