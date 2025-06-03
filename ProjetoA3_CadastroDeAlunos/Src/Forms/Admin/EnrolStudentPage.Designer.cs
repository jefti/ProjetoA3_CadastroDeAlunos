namespace ProjetoA3_CadastroDeAlunos.Src.Forms.Admin
{
    partial class EnrolStudentPage
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
            Enrol_combo_courses = new ComboBox();
            Enrol_lbl_cursos = new Label();
            Enrol_lst_alunos = new ListBox();
            Enrol_lst_matriculados = new ListBox();
            Enrol_btn_matricular = new Button();
            Enrol_lbl_alunos = new Label();
            Enrol_lbl_matriculados = new Label();
            SuspendLayout();
            // 
            // Enrol_combo_courses
            // 
            Enrol_combo_courses.FormattingEnabled = true;
            Enrol_combo_courses.Location = new Point(114, 33);
            Enrol_combo_courses.Name = "Enrol_combo_courses";
            Enrol_combo_courses.Size = new Size(151, 28);
            Enrol_combo_courses.TabIndex = 1;
            Enrol_combo_courses.SelectedIndexChanged += Enrol_combo_courses_SelectedIndexChanged;
            // 
            // Enrol_lbl_cursos
            // 
            Enrol_lbl_cursos.AutoSize = true;
            Enrol_lbl_cursos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Enrol_lbl_cursos.Location = new Point(34, 36);
            Enrol_lbl_cursos.Name = "Enrol_lbl_cursos";
            Enrol_lbl_cursos.Size = new Size(60, 20);
            Enrol_lbl_cursos.TabIndex = 2;
            Enrol_lbl_cursos.Text = "Cursos:";
            // 
            // Enrol_lst_alunos
            // 
            Enrol_lst_alunos.FormattingEnabled = true;
            Enrol_lst_alunos.Location = new Point(63, 109);
            Enrol_lst_alunos.Name = "Enrol_lst_alunos";
            Enrol_lst_alunos.SelectionMode = SelectionMode.MultiSimple;
            Enrol_lst_alunos.Size = new Size(231, 304);
            Enrol_lst_alunos.TabIndex = 3;
            // 
            // Enrol_lst_matriculados
            // 
            Enrol_lst_matriculados.FormattingEnabled = true;
            Enrol_lst_matriculados.Location = new Point(499, 109);
            Enrol_lst_matriculados.Name = "Enrol_lst_matriculados";
            Enrol_lst_matriculados.SelectionMode = SelectionMode.None;
            Enrol_lst_matriculados.Size = new Size(231, 304);
            Enrol_lst_matriculados.TabIndex = 4;
            // 
            // Enrol_btn_matricular
            // 
            Enrol_btn_matricular.Location = new Point(322, 119);
            Enrol_btn_matricular.Name = "Enrol_btn_matricular";
            Enrol_btn_matricular.Size = new Size(130, 29);
            Enrol_btn_matricular.TabIndex = 5;
            Enrol_btn_matricular.Text = "Matricular >>>";
            Enrol_btn_matricular.UseVisualStyleBackColor = true;
            Enrol_btn_matricular.Click += Enrol_btn_matricular_Click;
            // 
            // Enrol_lbl_alunos
            // 
            Enrol_lbl_alunos.AutoSize = true;
            Enrol_lbl_alunos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Enrol_lbl_alunos.Location = new Point(63, 86);
            Enrol_lbl_alunos.Name = "Enrol_lbl_alunos";
            Enrol_lbl_alunos.Size = new Size(62, 20);
            Enrol_lbl_alunos.TabIndex = 6;
            Enrol_lbl_alunos.Text = "Alunos:";
            // 
            // Enrol_lbl_matriculados
            // 
            Enrol_lbl_matriculados.AutoSize = true;
            Enrol_lbl_matriculados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Enrol_lbl_matriculados.Location = new Point(499, 86);
            Enrol_lbl_matriculados.Name = "Enrol_lbl_matriculados";
            Enrol_lbl_matriculados.Size = new Size(157, 20);
            Enrol_lbl_matriculados.TabIndex = 7;
            Enrol_lbl_matriculados.Text = "Alunos matriculados:";
            // 
            // EnrolStudentPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Enrol_lbl_matriculados);
            Controls.Add(Enrol_lbl_alunos);
            Controls.Add(Enrol_btn_matricular);
            Controls.Add(Enrol_lst_matriculados);
            Controls.Add(Enrol_lst_alunos);
            Controls.Add(Enrol_lbl_cursos);
            Controls.Add(Enrol_combo_courses);
            Name = "EnrolStudentPage";
            Text = "Alunos:";
            Load += EnrolStudentPage_Load;
            Controls.SetChildIndex(Enrol_combo_courses, 0);
            Controls.SetChildIndex(Enrol_lbl_cursos, 0);
            Controls.SetChildIndex(Enrol_lst_alunos, 0);
            Controls.SetChildIndex(Enrol_lst_matriculados, 0);
            Controls.SetChildIndex(Enrol_btn_matricular, 0);
            Controls.SetChildIndex(Enrol_lbl_alunos, 0);
            Controls.SetChildIndex(Enrol_lbl_matriculados, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Enrol_combo_courses;
        private Label Enrol_lbl_cursos;
        private ListBox Enrol_lst_alunos;
        private ListBox Enrol_lst_matriculados;
        private Button Enrol_btn_matricular;
        private Label Enrol_lbl_alunos;
        private Label Enrol_lbl_matriculados;
    }
}