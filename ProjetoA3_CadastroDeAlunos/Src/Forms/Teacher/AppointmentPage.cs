using MySql.Data.MySqlClient;
using ProjetoA3_CadastroDeAlunos.Src.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoA3_CadastroDeAlunos.Src.Forms.AppointmentPage
{
    public partial class AppointmentPage : ProjetoA3_CadastroDeAlunos.Templates.MenuForm.MenuForm
    {
        public AppointmentPage()
        {
            InitializeComponent();
        }

        private void AppointmentPage_Load(object sender, EventArgs e)
        {
            this.CarregarCursos();
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
                        Status = 1;
                ";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Parâmetro para o IdFuncionario (ajuste conforme necessário)
                    command.Parameters.AddWithValue("@IdFuncionario", UserSession.IdTipo);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);

                        Appointment_combo_curso.DataSource = dt;
                        Appointment_combo_curso.DisplayMember = "Nome";    // O nome que aparecerá no ComboBox
                        Appointment_combo_curso.ValueMember = "IdCurso";   // O valor interno (ID do curso)
                    }
                }
            }

        }

        private void Appointment_combo_curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Appointment_combo_curso.SelectedIndex >= 0 && Appointment_combo_curso.SelectedValue != null && Appointment_combo_curso.SelectedValue is int)
            {
                int idCurso = Convert.ToInt32(Appointment_combo_curso.SelectedValue);
                this.CarregarAlunosPorCurso(idCurso);
                Appointment_DataBind_Nota.DataSource = null;
            }
        }

        private void CarregarAlunosPorCurso(int IdCurso)
        {

            string query = @"SELECT 
                        Usuario.Nome as NomeAluno,
                        Usuario.IdUsuario,
                        Aluno.IdAluno,
                        Curso.Nome as CursoNome,
                        Curso.IdCurso,
                        Aluno_Curso.IdAluno_Curso
                    FROM Usuario
                    INNER JOIN Aluno 
                        ON Usuario.IdUsuario = Aluno.IdUsuario
                    INNER JOIN Aluno_Curso
                        ON Aluno_Curso.IdAluno = Aluno.IdAluno AND Aluno_Curso.IdCurso = @IdCurso
                    INNER JOIN Curso
                        On Curso.IdCurso = Aluno_Curso.IdCurso";



            using (MySqlConnection connection = Connection.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IdCurso", IdCurso);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            Appoint_List_Alunos.Items.Clear();

                            foreach (DataRow row in dt.Rows)
                            {
                                string nomeAluno = row["NomeAluno"].ToString();
                                int idAluno = Convert.ToInt32(row["IdAluno"]);
                                string cursoNome = row["CursoNome"].ToString();
                                int idAluno_Curso = Convert.ToInt32(row["IdAluno_Curso"]);


                                AlunoCurso curso = new AlunoCurso
                                {
                                    IdAluno = idAluno,
                                    NomeAluno = nomeAluno,
                                    NomeCurso = cursoNome,
                                    IdCurso = IdCurso,
                                    IdAluno_Curso = idAluno_Curso
                                };
                                Appoint_List_Alunos.Items.Add(curso);
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

        private void Appoint_List_Alunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Appoint_List_Alunos.SelectedItems.Count > 0)
            {
                this.CarregarNotas();
            }
        }

        private void CarregarNotas()
        {
            AlunoCurso aluno_Curso = (AlunoCurso)Appoint_List_Alunos.SelectedItem;

            string query = @"
                    SELECT 
                        IdNota,
                        Ordem,
                        Recuperacao,
                        CASE 
                            WHEN Recuperacao = 1 THEN 'Prova de Recuperação'
                            ELSE CONCAT('Prova ', Ordem)
                        END AS ""Avaliação"",
                        CAST(Valor AS DECIMAL(5,2)) AS Valor,
                        Corrigida
                    FROM Nota
                    WHERE IdAluno_Curso = @IdAluno_Curso
                    ORDER BY Ordem;
                ";

            using (MySqlConnection connection = Connection.GetConnection())
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IdAluno_Curso", aluno_Curso.IdAluno_Curso);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            Appointment_DataBind_Nota.DataSource = dt;

                            Appointment_DataBind_Nota.Columns["IdNota"].Visible = false;
                            Appointment_DataBind_Nota.Columns["Ordem"].Visible = false;
                            Appointment_DataBind_Nota.Columns["Recuperacao"].Visible = false;
                            Appointment_DataBind_Nota.Columns["Valor"].DefaultCellStyle.Format = "N2";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar cursos: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = Connection.GetConnection())
            {
                try
                {
                    connection.Open();
                    // Inicia uma transação para garantir que todas as atualizações aconteçam ou nenhuma aconteça.
                    MySqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        foreach (DataGridViewRow row in Appointment_DataBind_Nota.Rows)
                        {
                            // Pula linhas que são de novo registro ou se o IdNota está nulo.
                            // row.Cells["IdNota"].Value?.ToString() é uma forma segura de chamar ToString() em um objeto nulo.
                            if (row.IsNewRow || row.Cells["IdNota"].Value == null) continue;

                            // Tenta converter o IdNota. Se falhar, pula para a próxima linha.
                            if (!int.TryParse(row.Cells["IdNota"].Value.ToString(), out int idNota))
                            {
                                Console.WriteLine($"Erro: Não foi possível converter IdNota '{row.Cells["IdNota"].Value}' para inteiro. Pulando linha.");
                                continue;
                            }

                            // Obtém o valor da célula "Valor" como um objeto.
                            object valorCelulaObj = row.Cells["Valor"].Value;
                            double valorCorrigido; // Variável para armazenar o valor numérico corretamente.

                            // Se a célula "Valor" estiver vazia ou nula, não há nota para atualizar.
                            // Apenas continua para a próxima linha.
                            if (valorCelulaObj == null || string.IsNullOrWhiteSpace(valorCelulaObj.ToString()))
                            {
                                continue;
                            }

                            // *** AQUI É A ÚNICA E ESSENCIAL CORREÇÃO ***
                            // Tenta converter a string do DataGridView para um double.
                            // O uso de CultureInfo.GetCultureInfo("pt-BR") FORÇA a interpretação da VÍRGULA (,)
                            // como o separador decimal, garantindo que "6,00" vire 6.0 e não 600.
                            if (!double.TryParse(valorCelulaObj.ToString(), NumberStyles.Any, CultureInfo.GetCultureInfo("pt-BR"), out valorCorrigido))
                            {
                                // Se a conversão falhar (ex: texto não numérico na célula), avisa o usuário e pula a linha.
                                MessageBox.Show($"Valor inválido para a nota ID {idNota}: '{valorCelulaObj}'. Por favor, digite um número válido (use vírgula para decimal).", "Erro de Entrada de Nota", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                Console.WriteLine($"Erro: Não foi possível converter Valor '{valorCelulaObj}' para double na linha IdNota: {idNota}. Pulando linha.");
                                continue;
                            }

                            // A query SQL para atualizar a nota.
                            string updateQuery = @"
                            UPDATE Nota 
                            SET Valor = @Valor, 
                                Corrigida = 1, 
                                DataLancamento = @DataLancamento 
                            WHERE IdNota = @IdNota";

                            using (MySqlCommand cmd = new MySqlCommand(updateQuery, connection, transaction))
                            {
                                // Adiciona o valor CORRIGIDO (valorCorrigido) como parâmetro.
                                // Agora o MySQL receberá o número double exato que você digitou.
                                cmd.Parameters.AddWithValue("@Valor", valorCorrigido);
                                cmd.Parameters.AddWithValue("@DataLancamento", DateTime.Now); // Data atual para o lançamento da nota
                                cmd.Parameters.AddWithValue("@IdNota", idNota); // ID da nota a ser atualizada
                                cmd.ExecuteNonQuery(); // Executa a atualização
                            }
                        }

                        // Se todas as atualizações foram bem-sucedidas, confirma a transação no banco.
                        transaction.Commit();
                        MessageBox.Show("Notas atualizadas com sucesso!");

                        // Chama seus métodos para processar o resultado final e recarregar as notas no DataGridView.
                        this.ProcessarResultadoFinal();
                        this.CarregarNotas();
                    }
                    catch (Exception ex)
                    {
                        // Se qualquer erro ocorrer durante a atualização das notas, desfaz a transação.
                        transaction.Rollback();
                        MessageBox.Show("Erro ao atualizar notas: " + ex.Message);
                        Console.WriteLine("Erro detalhado na atualização das notas (button1_Click): " + ex.ToString());
                    }
                }
                catch (MySqlException mysqlEx)
                {
                    // Captura erros relacionados à conexão ou operações MySQL.
                    MessageBox.Show("Erro de conexão com o banco de dados: " + mysqlEx.Message);
                    Console.WriteLine("Erro MySQL detalhado: " + mysqlEx.ToString());
                }
                catch (Exception ex)
                {
                    // Captura quaisquer outros erros inesperados.
                    MessageBox.Show("Erro inesperado: " + ex.Message);
                    Console.WriteLine("Erro inesperado detalhado: " + ex.ToString());
                }
            }
        }

            private void ProcessarResultadoFinal()
        {
            AlunoCurso aluno_Curso = (AlunoCurso)Appoint_List_Alunos.SelectedItem;
            if (aluno_Curso == null)
            {
                MessageBox.Show("Nenhum aluno selecionado.");
                return;
            }

            int idAlunoCurso = aluno_Curso.IdAluno_Curso;

            using (MySqlConnection connection = Connection.GetConnection())
            {
                try
                {
                    connection.Open();

                    // 1. Média mínima do curso e o número de notas esperadas
                    double mediaCurso;
                    int numeroNotasEsperadas;
                    bool temRecuperacao;
                    
                    using (var cmd = new MySqlCommand(@"
                    SELECT c.MediaAprovacao, c.NumeroProvas as ""NumeroNotasEsperadas"", c.Recuperacao 
                    FROM Curso c 
                    INNER JOIN Aluno_Curso ac ON ac.IdCurso = c.IdCurso 
                    WHERE ac.IdAluno_Curso = @IdAlunoCurso", connection))
                    {
                        cmd.Parameters.AddWithValue("@IdAlunoCurso", idAlunoCurso);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                mediaCurso = Convert.ToDouble(reader["MediaAprovacao"]);
                                numeroNotasEsperadas = reader["NumeroNotasEsperadas"] == DBNull.Value ? 4 : Convert.ToInt32(reader["NumeroNotasEsperadas"]);
                                temRecuperacao = reader["Recuperacao"] == DBNull.Value ? false : Convert.ToBoolean(reader["Recuperacao"]); // Lendo o campo
                            }
                            else
                            {
                                MessageBox.Show("Configurações do curso não encontradas.");
                                return;
                            }
                        }
                    }

                    var notas = new List<(int IdNota, double? Valor, bool Recuperacao, bool Corrigida)>();
                    using (var cmd = new MySqlCommand("SELECT IdNota, Valor, Recuperacao, Corrigida FROM Nota WHERE IdAluno_Curso = @IdAlunoCurso", connection))
                    {
                        cmd.Parameters.AddWithValue("@IdAlunoCurso", idAlunoCurso);
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int idNota = Convert.ToInt32(reader["IdNota"]);
                                double? valor = reader["Valor"] == DBNull.Value ? (double?)null : Convert.ToDouble(reader["Valor"]);
                                bool recuperacao = Convert.ToBoolean(reader["Recuperacao"]);
                                bool corrigida = Convert.ToBoolean(reader["Corrigida"]);

                                notas.Add((idNota, valor, recuperacao, corrigida));
                            }
                        }
                    }

                    // Filtra apenas as notas normais que têm valor E foram corrigidas
                    var notasNormaisLancadasECorrigidas = notas
                        .Where(n => !n.Recuperacao && n.Valor.HasValue && n.Corrigida)
                        .Select(n => n.Valor.Value)
                        .ToList();

                    var notaRecuperacao = notas.FirstOrDefault(n => n.Recuperacao);
                    bool temNotaRecuperacaoRegistrada = notas.Any(n => n.Recuperacao);
                    // Verifica se a nota de recuperação tem valor E foi corrigida
                    bool notaRecuperacaoLancadaECorrigida = notaRecuperacao.Valor.HasValue && notaRecuperacao.Corrigida;

                    //this.DebugNotasMessage(numeroNotasEsperadas, notasNormaisLancadasECorrigidas.Count, temNotaRecuperacaoRegistrada, notaRecuperacaoLancadaECorrigida);

                    if (notasNormaisLancadasECorrigidas.Count < numeroNotasEsperadas ||
                        (temNotaRecuperacaoRegistrada && !notaRecuperacaoLancadaECorrigida))
                    {
                        // Passou direto
                        if (temNotaRecuperacaoRegistrada)
                        {
                            // Deleta a nota de recuperação se o aluno já passou direto
                            using (var cmd = new MySqlCommand("DELETE FROM Nota WHERE IdNota = @Id", connection))
                            {
                                cmd.Parameters.AddWithValue("@Id", notaRecuperacao.IdNota);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        return;
                    }
                    // ********************************************

                    // Se chegou até aqui, significa que todas as notas normais esperadas estão lançadas e corrigidas,
                    // e, se houver recuperação, ela também já foi lançada e corrigida.

                    string resultadoFinal = string.Empty;
                    bool finalizarCurso = false;
                    double media = notasNormaisLancadasECorrigidas.Average(); // Média só é calculada se a condição acima for atendida

                    if (media >= mediaCurso)
                    {
                        // Passou direto
                        if (temNotaRecuperacaoRegistrada)
                        {
                            // Deleta a nota de recuperação se o aluno já passou direto
                            using (var cmd = new MySqlCommand("DELETE FROM Nota WHERE IdNota = @Id", connection))
                            {
                                cmd.Parameters.AddWithValue("@Id", notaRecuperacao.IdNota);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        resultadoFinal = "Aprovado";
                        finalizarCurso = true;
                    }
                    else // Média abaixo do mínimo
                    {
                        if (!temNotaRecuperacaoRegistrada)
                        {
                            if (temRecuperacao) 
                            {
                                // Criar nota de recuperação (sem valor ainda, Corrigida = 0)
                                using (var cmd = new MySqlCommand(@"
                                INSERT INTO Nota (IdAluno_Curso, Ordem, Valor, Recuperacao, Corrigida, DataLancamento)
                                VALUES (@IdAlunoCurso, @Ordem, NULL, 1, 0, NULL)", connection))
                                {
                                    int ordem = numeroNotasEsperadas + 1;
                                    cmd.Parameters.AddWithValue("@IdAlunoCurso", idAlunoCurso);
                                    cmd.Parameters.AddWithValue("@Ordem", ordem);
                                    cmd.ExecuteNonQuery();
                                }
                                resultadoFinal = "Em Recuperação";
                                finalizarCurso = false;
                            }
                            else
                            {
                                //Reprovado diretamente se não tem recuperação
                                resultadoFinal = "Reprovado";
                                finalizarCurso = true;
                            }
                        }
                        else // Já existe uma nota de recuperação (e sabemos que ela foi corrigida, pela condição de 'return' inicial)
                        {
                            // Acha a menor nota normal para substituí-la pela nota de recuperação
                            double menorNotaNormal = notasNormaisLancadasECorrigidas.Min();
                            double novaMedia = (notasNormaisLancadasECorrigidas.Sum() - menorNotaNormal + notaRecuperacao.Valor.Value) / notasNormaisLancadasECorrigidas.Count;

                            resultadoFinal = novaMedia >= mediaCurso ? "Aprovado na Recuperação" : "Reprovado";
                            media = novaMedia;
                            finalizarCurso = true;
                        }
                    }

                    // Atualizar resultado do Aluno_Curso
                    using (var cmd = new MySqlCommand(@"
                    UPDATE Aluno_Curso 
                    SET Resultado = @ResultadoFinal 
                    WHERE IdAluno_Curso = @IdAlunoCurso", connection))
                    {
                        cmd.Parameters.AddWithValue("@ResultadoFinal", resultadoFinal);
                        cmd.Parameters.AddWithValue("@IdAlunoCurso", idAlunoCurso);
                        cmd.ExecuteNonQuery();
                    }

                    // Finalizar curso somente se 'finalizarCurso' for true
                    if (finalizarCurso)
                    {
                        using (var cmd = new MySqlCommand(@"
                        UPDATE Aluno_Curso 
                        SET Finalizado = 1, DataFim = @DataFim, MediaFinal = @MediaFinal
                        WHERE IdAluno_Curso = @IdAlunoCurso", connection))
                        {
                            cmd.Parameters.AddWithValue("@DataFim", DateTime.Now);
                            cmd.Parameters.AddWithValue("@MediaFinal", media);
                            cmd.Parameters.AddWithValue("@IdAlunoCurso", idAlunoCurso);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (MySqlException mysqlEx)
                {
                    MessageBox.Show("Erro de banco de dados ao processar resultado: " + mysqlEx.Message);
                    Console.WriteLine("Erro MySQL detalhado: " + mysqlEx.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro inesperado ao processar resultado: " + ex.Message);
                    Console.WriteLine("Erro inesperado detalhado: " + ex.ToString());
                }
            }
        }

        private void DebugNotasMessage(int numNotasEsperadas, int numNotasCorrigidas, bool temRecuperacao, bool recuperacaoCorrigida)
        {
            string debugMessage = $"--- Estado das Notas ---\n" +
                                  $"Número de Notas Esperadas: {numNotasEsperadas}\n" +
                                  $"Notas Normais Lançadas e Corrigidas: {numNotasCorrigidas}\n" +
                                  $"Tem Nota de Recuperação Registrada: {temRecuperacao}\n" +
                                  $"Nota de Recuperação Lançada e Corrigida: {recuperacaoCorrigida}\n\n" +
                                  $"--- Condição de Saída ---\n" +
                                  $"Condição 1 (Faltam Notas): {numNotasCorrigidas < numNotasEsperadas}\n" +
                                  $"Condição 2 (Recuperação Pendente): {(temRecuperacao && !recuperacaoCorrigida)}\n" +
                                  $"Resultado Final da Condição: {(numNotasCorrigidas < numNotasEsperadas || (temRecuperacao && !recuperacaoCorrigida))}";

            MessageBox.Show(debugMessage, "Debugging: Análise de Notas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
