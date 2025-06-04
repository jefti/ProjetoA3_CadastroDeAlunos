namespace ProjetoA3_CadastroDeAlunos.Src.Forms.GradesPage
{
    partial class GradesPage
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
            Graee_comb_disci = new ComboBox();
            dataGridNotas = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            lbl_situacao = new Label();
            panel2 = new Panel();
            lbl_media = new Label();
            label4 = new Label();
            panel3 = new Panel();
            lbl_DataFim = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridNotas).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // Graee_comb_disci
            // 
            Graee_comb_disci.FormattingEnabled = true;
            Graee_comb_disci.Location = new Point(115, 55);
            Graee_comb_disci.Margin = new Padding(3, 4, 3, 4);
            Graee_comb_disci.Name = "Graee_comb_disci";
            Graee_comb_disci.Size = new Size(534, 28);
            Graee_comb_disci.TabIndex = 1;
            Graee_comb_disci.SelectedIndexChanged += Graee_comb_disci_SelectedIndexChanged;
            // 
            // dataGridNotas
            // 
            dataGridNotas.AllowUserToAddRows = false;
            dataGridNotas.AllowUserToDeleteRows = false;
            dataGridNotas.AllowUserToResizeRows = false;
            dataGridNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridNotas.Location = new Point(35, 108);
            dataGridNotas.Margin = new Padding(3, 4, 3, 4);
            dataGridNotas.Name = "dataGridNotas";
            dataGridNotas.RowHeadersWidth = 51;
            dataGridNotas.Size = new Size(799, 334);
            dataGridNotas.TabIndex = 2;
            dataGridNotas.CellContentClick += dataGridNotas_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 56);
            label1.Name = "label1";
            label1.Size = new Size(70, 28);
            label1.TabIndex = 3;
            label1.Text = "Curso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 17);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 4;
            label2.Text = "Situação";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lbl_situacao);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(35, 452);
            panel1.Name = "panel1";
            panel1.Size = new Size(172, 125);
            panel1.TabIndex = 6;
            // 
            // lbl_situacao
            // 
            lbl_situacao.AutoSize = true;
            lbl_situacao.Location = new Point(12, 61);
            lbl_situacao.Name = "lbl_situacao";
            lbl_situacao.Size = new Size(15, 20);
            lbl_situacao.TabIndex = 5;
            lbl_situacao.Text = "-";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbl_media);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(227, 452);
            panel2.Name = "panel2";
            panel2.Size = new Size(172, 125);
            panel2.TabIndex = 7;
            // 
            // lbl_media
            // 
            lbl_media.AutoSize = true;
            lbl_media.Location = new Point(12, 61);
            lbl_media.Name = "lbl_media";
            lbl_media.Size = new Size(15, 20);
            lbl_media.TabIndex = 6;
            lbl_media.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 17);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 4;
            label4.Text = "Média";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lbl_DataFim);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(420, 452);
            panel3.Name = "panel3";
            panel3.Size = new Size(172, 125);
            panel3.TabIndex = 8;
            // 
            // lbl_DataFim
            // 
            lbl_DataFim.AutoSize = true;
            lbl_DataFim.Location = new Point(12, 61);
            lbl_DataFim.Name = "lbl_DataFim";
            lbl_DataFim.Size = new Size(15, 20);
            lbl_DataFim.TabIndex = 6;
            lbl_DataFim.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 17);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 4;
            label5.Text = "Última atualização";
            // 
            // GradesPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 589);
            Controls.Add(panel3);
            Controls.Add(label1);
            Controls.Add(dataGridNotas);
            Controls.Add(Graee_comb_disci);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(930, 636);
            MinimumSize = new Size(930, 636);
            Name = "GradesPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GradesPage";
            Load += GradesPage_Load;
            Controls.SetChildIndex(panel2, 0);
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(Graee_comb_disci, 0);
            Controls.SetChildIndex(dataGridNotas, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(panel3, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridNotas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Graee_comb_disci;
        private DataGridView dataGridNotas;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label lbl_situacao;
        private Label lbl_media;
        private Panel panel3;
        private Label lbl_DataFim;
        private Label label5;
    }
}