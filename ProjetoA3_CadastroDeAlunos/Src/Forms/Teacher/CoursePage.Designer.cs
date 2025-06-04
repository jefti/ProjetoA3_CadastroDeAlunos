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
            label1 = new Label();
            Course_Btn_Encerrar = new Button();
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
            Curso_dtgrd_cursos.Location = new Point(47, 99);
            Curso_dtgrd_cursos.Margin = new Padding(3, 4, 3, 4);
            Curso_dtgrd_cursos.Name = "Curso_dtgrd_cursos";
            Curso_dtgrd_cursos.ReadOnly = true;
            Curso_dtgrd_cursos.RowHeadersWidth = 51;
            Curso_dtgrd_cursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Curso_dtgrd_cursos.Size = new Size(798, 413);
            Curso_dtgrd_cursos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(47, 44);
            label1.Name = "label1";
            label1.Size = new Size(178, 41);
            label1.TabIndex = 2;
            label1.Text = "Seus cursos";
            // 
            // Course_Btn_Encerrar
            // 
            Course_Btn_Encerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Course_Btn_Encerrar.Location = new Point(696, 63);
            Course_Btn_Encerrar.Name = "Course_Btn_Encerrar";
            Course_Btn_Encerrar.Size = new Size(149, 29);
            Course_Btn_Encerrar.TabIndex = 3;
            Course_Btn_Encerrar.Text = "Encerrar curso";
            Course_Btn_Encerrar.UseVisualStyleBackColor = true;
            Course_Btn_Encerrar.Click += Course_Btn_Encerrar_Click;
            // 
            // CoursePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 589);
            Controls.Add(Course_Btn_Encerrar);
            Controls.Add(label1);
            Controls.Add(Curso_dtgrd_cursos);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(930, 636);
            MinimumSize = new Size(930, 636);
            Name = "CoursePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CoursePage";
            Load += CoursePage_Load;
            Controls.SetChildIndex(Curso_dtgrd_cursos, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(Course_Btn_Encerrar, 0);
            ((System.ComponentModel.ISupportInitialize)Curso_dtgrd_cursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Curso_dtgrd_cursos;
        private Label label1;
        private Button Course_Btn_Encerrar;
    }
}