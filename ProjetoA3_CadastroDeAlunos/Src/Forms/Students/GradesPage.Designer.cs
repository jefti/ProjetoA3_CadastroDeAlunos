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
            ((System.ComponentModel.ISupportInitialize)dataGridNotas).BeginInit();
            SuspendLayout();
            // 
            // Graee_comb_disci
            // 
            Graee_comb_disci.FormattingEnabled = true;
            Graee_comb_disci.Location = new Point(12, 27);
            Graee_comb_disci.Name = "Graee_comb_disci";
            Graee_comb_disci.Size = new Size(249, 23);
            Graee_comb_disci.TabIndex = 1;
            Graee_comb_disci.SelectedIndexChanged += Graee_comb_disci_SelectedIndexChanged;
            // 
            // dataGridNotas
            // 
            dataGridNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridNotas.Location = new Point(12, 56);
            dataGridNotas.Name = "dataGridNotas";
            dataGridNotas.Size = new Size(249, 146);
            dataGridNotas.TabIndex = 2;
            dataGridNotas.CellContentClick += dataGridNotas_CellContentClick;
            // 
            // GradesPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridNotas);
            Controls.Add(Graee_comb_disci);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "GradesPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GradesPage";
            Load += GradesPage_Load;
            Controls.SetChildIndex(Graee_comb_disci, 0);
            Controls.SetChildIndex(dataGridNotas, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridNotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Graee_comb_disci;
        private DataGridView dataGridNotas;
    }
}