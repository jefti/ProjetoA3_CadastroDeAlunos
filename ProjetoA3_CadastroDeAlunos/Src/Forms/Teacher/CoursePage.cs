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
                        curso.IdCurso,
                        curso.Nome AS 'Disciplina',
                        categoria.Nome AS 'Categoria',
                        curso.MediaAprovacao AS 'Média',
                        curso.Duracao AS 'Carga horária',
                        CASE 
                            WHEN curso.Status = 1 THEN 'Não'
                            ELSE 'Sim'
                        END AS 'Concluído'
                    FROM 
                        curso
                    INNER JOIN 
                        categoria ON categoria.IdCategoria = curso.IdCategoria
                    WHERE 
                        curso.IdFuncionario = @IdFuncionario
                    ORDER BY 
                        curso.Status DESC; -- Status 1 (Não concluído) vem primeiro
                ";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Parâmetro para o IdFuncionario (ajuste conforme necessário)
                    command.Parameters.AddWithValue("@IdFuncionario", UserSession.IdTipo);

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

        private void Course_Btn_Encerrar_Click(object sender, EventArgs e)
        {
            if (Curso_dtgrd_cursos.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = Curso_dtgrd_cursos.SelectedRows[0];
                int idCurso = Convert.ToInt32(selectedRow.Cells["IdCurso"].Value);
                string concluido = selectedRow.Cells["Concluído"].Value.ToString();

                // Verifica se já está encerrado
                if (concluido == "Sim")
                {
                    MessageBox.Show("Este curso já está encerrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (MySqlConnection connection = Connection.GetConnection())
                {
                    connection.Open();

                    // 1. Checa se ainda existem notas não corrigidas
                    string checkNotasQuery = @"
                SELECT COUNT(*) 
                FROM nota n
                JOIN aluno_curso ac ON n.IdAluno_Curso = ac.IdAluno_Curso
                WHERE ac.IdCurso = @IdCurso AND n.Corrigida = FALSE;
            ";

                    using (MySqlCommand checkCmd = new MySqlCommand(checkNotasQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@IdCurso", idCurso);
                        long notasPendentes = (long)checkCmd.ExecuteScalar();

                        if (notasPendentes > 0)
                        {
                            MessageBox.Show(
                                "Este curso não pode ser encerrado. Existem Notas que não foram lançadas.",
                                "Atenção",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                            return;
                        }
                    }

                    // 2. Confirma encerramento
                    DialogResult result = MessageBox.Show(
                        "Deseja realmente encerrar este curso?",
                        "Confirmar encerramento",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        // 3. Atualiza o status do curso
                        string updateQuery = "UPDATE curso SET Status = 0 WHERE IdCurso = @IdCurso";

                        using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@IdCurso", idCurso);
                            int affectedRows = cmd.ExecuteNonQuery();

                            if (affectedRows > 0)
                            {
                                MessageBox.Show("Curso encerrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CoursePage_Load(null, null); // Atualiza grid
                            }
                            else
                            {
                                MessageBox.Show("Falha ao encerrar o curso.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um curso na lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
