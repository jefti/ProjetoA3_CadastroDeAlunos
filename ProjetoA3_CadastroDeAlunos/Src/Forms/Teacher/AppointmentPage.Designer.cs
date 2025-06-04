namespace ProjetoA3_CadastroDeAlunos.Src.Forms.AppointmentPage
{
    partial class AppointmentPage
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
            Appointment_combo_curso = new ComboBox();
            Appointment_DataBind_Nota = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Appoint_List_Alunos = new ListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)Appointment_DataBind_Nota).BeginInit();
            SuspendLayout();
            // 
            // Appointment_combo_curso
            // 
            Appointment_combo_curso.FormattingEnabled = true;
            Appointment_combo_curso.Location = new Point(258, 90);
            Appointment_combo_curso.Name = "Appointment_combo_curso";
            Appointment_combo_curso.Size = new Size(275, 28);
            Appointment_combo_curso.TabIndex = 1;
            Appointment_combo_curso.SelectedIndexChanged += Appointment_combo_curso_SelectedIndexChanged;
            // 
            // Appointment_DataBind_Nota
            // 
            Appointment_DataBind_Nota.AllowUserToAddRows = false;
            Appointment_DataBind_Nota.AllowUserToDeleteRows = false;
            Appointment_DataBind_Nota.AllowUserToResizeRows = false;
            Appointment_DataBind_Nota.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Appointment_DataBind_Nota.Location = new Point(258, 165);
            Appointment_DataBind_Nota.Name = "Appointment_DataBind_Nota";
            Appointment_DataBind_Nota.RowHeadersWidth = 51;
            Appointment_DataBind_Nota.Size = new Size(588, 371);
            Appointment_DataBind_Nota.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(258, 59);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 4;
            label1.Text = "Cursos: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 59);
            label2.Name = "label2";
            label2.Size = new Size(88, 28);
            label2.TabIndex = 5;
            label2.Text = "Alunos: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(258, 134);
            label3.Name = "label3";
            label3.Size = new Size(168, 28);
            label3.TabIndex = 6;
            label3.Text = "Notas do aluno: ";
            // 
            // Appoint_List_Alunos
            // 
            Appoint_List_Alunos.FormattingEnabled = true;
            Appoint_List_Alunos.Location = new Point(12, 90);
            Appoint_List_Alunos.Name = "Appoint_List_Alunos";
            Appoint_List_Alunos.Size = new Size(226, 444);
            Appoint_List_Alunos.TabIndex = 7;
            Appoint_List_Alunos.SelectedIndexChanged += Appoint_List_Alunos_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(703, 125);
            button1.Name = "button1";
            button1.Size = new Size(143, 34);
            button1.TabIndex = 8;
            button1.Text = "Atualizar notas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AppointmentPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 589);
            Controls.Add(button1);
            Controls.Add(Appoint_List_Alunos);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Appointment_DataBind_Nota);
            Controls.Add(Appointment_combo_curso);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(930, 636);
            MinimumSize = new Size(930, 636);
            Name = "AppointmentPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AppointmentPage";
            Load += AppointmentPage_Load;
            Controls.SetChildIndex(Appointment_combo_curso, 0);
            Controls.SetChildIndex(Appointment_DataBind_Nota, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(label2, 0);
            Controls.SetChildIndex(label3, 0);
            Controls.SetChildIndex(Appoint_List_Alunos, 0);
            Controls.SetChildIndex(button1, 0);
            ((System.ComponentModel.ISupportInitialize)Appointment_DataBind_Nota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Appointment_combo_curso;
        private DataGridView Appointment_DataBind_Nota;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox Appoint_List_Alunos;
        private Button button1;
    }
}