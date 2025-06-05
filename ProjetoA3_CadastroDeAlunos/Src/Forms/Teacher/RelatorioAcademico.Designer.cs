namespace ProjetoA3_CadastroDeAlunos.Src.Forms.Teacher
{
    partial class RelatorioAcademico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            report_combo_cursos = new ComboBox();
            label1 = new Label();
            panel1 = new Panel();
            lbl_Recuperacao = new Label();
            lbl_quantidadeProvas = new Label();
            lbl_MediaAprovacao = new Label();
            label12 = new Label();
            label11 = new Label();
            label8 = new Label();
            lbl_mediaGeral = new Label();
            label9 = new Label();
            panel3 = new Panel();
            lbl_mediaRecuperacao = new Label();
            lbl_mediaRegulares = new Label();
            lbl_mediaTotal = new Label();
            label10 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            lbl_alunosReprovados = new Label();
            lbl_alunosAprovados = new Label();
            lbl_alunosTotal = new Label();
            lbl_numAlunos = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // report_combo_cursos
            // 
            report_combo_cursos.FormattingEnabled = true;
            report_combo_cursos.Location = new Point(35, 82);
            report_combo_cursos.Name = "report_combo_cursos";
            report_combo_cursos.Size = new Size(275, 28);
            report_combo_cursos.TabIndex = 2;
            report_combo_cursos.SelectedIndexChanged += report_combo_cursos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 51);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 5;
            label1.Text = "Cursos: ";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lbl_Recuperacao);
            panel1.Controls.Add(lbl_quantidadeProvas);
            panel1.Controls.Add(lbl_MediaAprovacao);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lbl_mediaGeral);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(35, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(831, 420);
            panel1.TabIndex = 6;
            // 
            // lbl_Recuperacao
            // 
            lbl_Recuperacao.AutoSize = true;
            lbl_Recuperacao.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Recuperacao.Location = new Point(253, 125);
            lbl_Recuperacao.Name = "lbl_Recuperacao";
            lbl_Recuperacao.Size = new Size(19, 25);
            lbl_Recuperacao.TabIndex = 18;
            lbl_Recuperacao.Text = "-";
            // 
            // lbl_quantidadeProvas
            // 
            lbl_quantidadeProvas.AutoSize = true;
            lbl_quantidadeProvas.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_quantidadeProvas.Location = new Point(288, 97);
            lbl_quantidadeProvas.Name = "lbl_quantidadeProvas";
            lbl_quantidadeProvas.Size = new Size(19, 25);
            lbl_quantidadeProvas.TabIndex = 17;
            lbl_quantidadeProvas.Text = "-";
            // 
            // lbl_MediaAprovacao
            // 
            lbl_MediaAprovacao.AutoSize = true;
            lbl_MediaAprovacao.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_MediaAprovacao.Location = new Point(288, 69);
            lbl_MediaAprovacao.Name = "lbl_MediaAprovacao";
            lbl_MediaAprovacao.Size = new Size(19, 25);
            lbl_MediaAprovacao.TabIndex = 16;
            lbl_MediaAprovacao.Text = "-";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(60, 122);
            label12.Name = "label12";
            label12.Size = new Size(187, 28);
            label12.TabIndex = 15;
            label12.Text = "Teve Recuperação:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(57, 94);
            label11.Name = "label11";
            label11.Size = new Size(225, 28);
            label11.TabIndex = 14;
            label11.Text = "Quantidade de provas:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(57, 66);
            label8.Name = "label8";
            label8.Size = new Size(228, 28);
            label8.TabIndex = 13;
            label8.Text = "Média para aprovação:";
            // 
            // lbl_mediaGeral
            // 
            lbl_mediaGeral.AutoSize = true;
            lbl_mediaGeral.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_mediaGeral.Location = new Point(202, 41);
            lbl_mediaGeral.Name = "lbl_mediaGeral";
            lbl_mediaGeral.Size = new Size(19, 25);
            lbl_mediaGeral.TabIndex = 12;
            lbl_mediaGeral.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(57, 38);
            label9.Name = "label9";
            label9.Size = new Size(139, 28);
            label9.TabIndex = 4;
            label9.Text = "Média geral*:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lbl_mediaRecuperacao);
            panel3.Controls.Add(lbl_mediaRegulares);
            panel3.Controls.Add(lbl_mediaTotal);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(439, 219);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 161);
            panel3.TabIndex = 10;
            // 
            // lbl_mediaRecuperacao
            // 
            lbl_mediaRecuperacao.AutoSize = true;
            lbl_mediaRecuperacao.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_mediaRecuperacao.Location = new Point(274, 82);
            lbl_mediaRecuperacao.Name = "lbl_mediaRecuperacao";
            lbl_mediaRecuperacao.Size = new Size(19, 25);
            lbl_mediaRecuperacao.TabIndex = 14;
            lbl_mediaRecuperacao.Text = "-";
            // 
            // lbl_mediaRegulares
            // 
            lbl_mediaRegulares.AutoSize = true;
            lbl_mediaRegulares.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_mediaRegulares.Location = new Point(229, 46);
            lbl_mediaRegulares.Name = "lbl_mediaRegulares";
            lbl_mediaRegulares.Size = new Size(19, 25);
            lbl_mediaRegulares.TabIndex = 13;
            lbl_mediaRegulares.Text = "-";
            // 
            // lbl_mediaTotal
            // 
            lbl_mediaTotal.AutoSize = true;
            lbl_mediaTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_mediaTotal.Location = new Point(249, 10);
            lbl_mediaTotal.Name = "lbl_mediaTotal";
            lbl_mediaTotal.Size = new Size(19, 25);
            lbl_mediaTotal.TabIndex = 12;
            lbl_mediaTotal.Text = "-";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 7);
            label10.Name = "label10";
            label10.Size = new Size(232, 28);
            label10.TabIndex = 8;
            label10.Text = "Média (todas as notas):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F);
            label6.Location = new Point(12, 82);
            label6.Name = "label6";
            label6.Size = new Size(260, 25);
            label6.TabIndex = 7;
            label6.Text = "Apenas provas de recuperação:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F);
            label7.Location = new Point(12, 46);
            label7.Name = "label7";
            label7.Size = new Size(211, 25);
            label7.TabIndex = 6;
            label7.Text = "Apenas provas regulares:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(lbl_alunosReprovados);
            panel2.Controls.Add(lbl_alunosAprovados);
            panel2.Controls.Add(lbl_alunosTotal);
            panel2.Controls.Add(lbl_numAlunos);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(26, 219);
            panel2.Name = "panel2";
            panel2.Size = new Size(361, 161);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // lbl_alunosReprovados
            // 
            lbl_alunosReprovados.AutoSize = true;
            lbl_alunosReprovados.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_alunosReprovados.Location = new Point(144, 113);
            lbl_alunosReprovados.Name = "lbl_alunosReprovados";
            lbl_alunosReprovados.Size = new Size(19, 25);
            lbl_alunosReprovados.TabIndex = 13;
            lbl_alunosReprovados.Text = "-";
            // 
            // lbl_alunosAprovados
            // 
            lbl_alunosAprovados.AutoSize = true;
            lbl_alunosAprovados.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_alunosAprovados.Location = new Point(137, 82);
            lbl_alunosAprovados.Name = "lbl_alunosAprovados";
            lbl_alunosAprovados.Size = new Size(19, 25);
            lbl_alunosAprovados.TabIndex = 12;
            lbl_alunosAprovados.Text = "-";
            // 
            // lbl_alunosTotal
            // 
            lbl_alunosTotal.AutoSize = true;
            lbl_alunosTotal.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_alunosTotal.Location = new Point(86, 46);
            lbl_alunosTotal.Name = "lbl_alunosTotal";
            lbl_alunosTotal.Size = new Size(19, 25);
            lbl_alunosTotal.TabIndex = 11;
            lbl_alunosTotal.Text = "-";
            // 
            // lbl_numAlunos
            // 
            lbl_numAlunos.AutoSize = true;
            lbl_numAlunos.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_numAlunos.Location = new Point(226, 10);
            lbl_numAlunos.Name = "lbl_numAlunos";
            lbl_numAlunos.Size = new Size(19, 25);
            lbl_numAlunos.TabIndex = 4;
            lbl_numAlunos.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 7);
            label2.Name = "label2";
            label2.Size = new Size(194, 28);
            label2.TabIndex = 0;
            label2.Text = "Número de Alunos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F);
            label5.Location = new Point(31, 113);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 3;
            label5.Text = "Reprovados:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(31, 46);
            label3.Name = "label3";
            label3.Size = new Size(53, 25);
            label3.TabIndex = 1;
            label3.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F);
            label4.Location = new Point(31, 82);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 2;
            label4.Text = "Aprovados:";
            // 
            // RelatorioAcademico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 589);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(report_combo_cursos);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MaximumSize = new Size(930, 636);
            MinimumSize = new Size(930, 636);
            Name = "RelatorioAcademico";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Relatorio Acadêmico";
            Load += RelatorioAcademico_Load;
            Controls.SetChildIndex(report_combo_cursos, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(panel1, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox report_combo_cursos;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
        private Label label9;
        private Label label10;
        private Panel panel3;
        private Panel panel2;
        private Label lbl_mediaGeral;
        private Label lbl_mediaRecuperacao;
        private Label lbl_mediaRegulares;
        private Label lbl_mediaTotal;
        private Label lbl_alunosReprovados;
        private Label lbl_alunosAprovados;
        private Label lbl_alunosTotal;
        private Label lbl_numAlunos;
        private Label label8;
        private Label lbl_Recuperacao;
        private Label lbl_quantidadeProvas;
        private Label lbl_MediaAprovacao;
        private Label label12;
        private Label label11;
    }
}