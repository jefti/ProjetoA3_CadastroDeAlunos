namespace ProjetoA3_CadastroDeAlunos.Src.Forms.CoursePage
{
    partial class CoursePage
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
            Curso_dtgrd_cursos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Curso_dtgrd_cursos).BeginInit();
            SuspendLayout();
            // 
            // Curso_dtgrd_cursos
            // 
            Curso_dtgrd_cursos.AllowUserToAddRows = false;
            Curso_dtgrd_cursos.AllowUserToDeleteRows = false;
            Curso_dtgrd_cursos.AllowUserToResizeColumns = false;
            Curso_dtgrd_cursos.AllowUserToResizeRows = false;
            Curso_dtgrd_cursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Curso_dtgrd_cursos.Location = new Point(12, 27);
            Curso_dtgrd_cursos.Name = "Curso_dtgrd_cursos";
            Curso_dtgrd_cursos.ReadOnly = true;
            Curso_dtgrd_cursos.Size = new Size(443, 310);
            Curso_dtgrd_cursos.TabIndex = 1;
            Curso_dtgrd_cursos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // CoursePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Curso_dtgrd_cursos);
            Name = "CoursePage";
            Text = "CoursePage";
            Load += CoursePage_Load;
            Controls.SetChildIndex(Curso_dtgrd_cursos, 0);
            ((System.ComponentModel.ISupportInitialize)Curso_dtgrd_cursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Curso_dtgrd_cursos;
    }
}