namespace ProjetoA3_CadastroDeAlunos.Src.Forms.HistoricalPage
{
    partial class HistoricalPage
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
            label1 = new Label();
            Hist_DtGrd_Cursos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Hist_DtGrd_Cursos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 42);
            label1.Name = "label1";
            label1.Size = new Size(453, 54);
            label1.TabIndex = 1;
            label1.Text = "Seu histórico de cursos";
            // 
            // Hist_DtGrd_Cursos
            // 
            Hist_DtGrd_Cursos.AllowUserToAddRows = false;
            Hist_DtGrd_Cursos.AllowUserToDeleteRows = false;
            Hist_DtGrd_Cursos.AllowUserToResizeRows = false;
            Hist_DtGrd_Cursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Hist_DtGrd_Cursos.Location = new Point(39, 99);
            Hist_DtGrd_Cursos.Name = "Hist_DtGrd_Cursos";
            Hist_DtGrd_Cursos.RowHeadersWidth = 51;
            Hist_DtGrd_Cursos.Size = new Size(834, 450);
            Hist_DtGrd_Cursos.TabIndex = 2;
            // 
            // HistoricalPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 589);
            Controls.Add(Hist_DtGrd_Cursos);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(930, 636);
            MinimumSize = new Size(930, 636);
            Name = "HistoricalPage";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Histórico de cursos";
            Load += HistoricalPage_Load;
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(Hist_DtGrd_Cursos, 0);
            ((System.ComponentModel.ISupportInitialize)Hist_DtGrd_Cursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView Hist_DtGrd_Cursos;
    }
}