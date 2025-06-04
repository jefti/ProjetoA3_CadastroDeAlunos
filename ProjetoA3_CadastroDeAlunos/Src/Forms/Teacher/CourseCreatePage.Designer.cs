namespace ProjetoA3_CadastroDeAlunos.Src.Forms.Teacher
{
    partial class CourseCreatePage
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            RegC_Txt_Nome = new TextBox();
            RegC_Combo_Categoria = new ComboBox();
            RegC_Radio_Yes = new RadioButton();
            RegC_Radio_No = new RadioButton();
            RegC_Txt_Duracao = new TextBox();
            RegC_Txt_NumProvas = new TextBox();
            RegC_Btn_Create = new Button();
            label7 = new Label();
            panel1 = new Panel();
            RegC_Txt_Media = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(25, 129);
            label5.Name = "label5";
            label5.Size = new Size(143, 20);
            label5.TabIndex = 10;
            label5.Text = "Numero de provas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(23, 231);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 9;
            label4.Text = "Duração do curso:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(25, 183);
            label3.Name = "label3";
            label3.Size = new Size(167, 20);
            label3.TabIndex = 8;
            label3.Text = "Media para aprovação:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(25, 79);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 7;
            label2.Text = "Categoria do curso:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 37);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 6;
            label1.Text = "Nome do curso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(23, 286);
            label6.Name = "label6";
            label6.Size = new Size(163, 20);
            label6.TabIndex = 11;
            label6.Text = "Prova de recuperação:";
            // 
            // RegC_Txt_Nome
            // 
            RegC_Txt_Nome.Location = new Point(211, 30);
            RegC_Txt_Nome.Name = "RegC_Txt_Nome";
            RegC_Txt_Nome.Size = new Size(311, 27);
            RegC_Txt_Nome.TabIndex = 12;
            // 
            // RegC_Combo_Categoria
            // 
            RegC_Combo_Categoria.FormattingEnabled = true;
            RegC_Combo_Categoria.Location = new Point(211, 76);
            RegC_Combo_Categoria.Name = "RegC_Combo_Categoria";
            RegC_Combo_Categoria.Size = new Size(311, 28);
            RegC_Combo_Categoria.TabIndex = 13;
            // 
            // RegC_Radio_Yes
            // 
            RegC_Radio_Yes.AutoSize = true;
            RegC_Radio_Yes.Checked = true;
            RegC_Radio_Yes.Location = new Point(211, 282);
            RegC_Radio_Yes.Name = "RegC_Radio_Yes";
            RegC_Radio_Yes.Size = new Size(156, 24);
            RegC_Radio_Yes.TabIndex = 14;
            RegC_Radio_Yes.TabStop = true;
            RegC_Radio_Yes.Text = "Possui recuperação";
            RegC_Radio_Yes.UseVisualStyleBackColor = true;
            // 
            // RegC_Radio_No
            // 
            RegC_Radio_No.AutoSize = true;
            RegC_Radio_No.Location = new Point(211, 312);
            RegC_Radio_No.Name = "RegC_Radio_No";
            RegC_Radio_No.Size = new Size(190, 24);
            RegC_Radio_No.TabIndex = 15;
            RegC_Radio_No.Text = "Não possui recuperação";
            RegC_Radio_No.UseVisualStyleBackColor = true;
            // 
            // RegC_Txt_Duracao
            // 
            RegC_Txt_Duracao.Location = new Point(211, 224);
            RegC_Txt_Duracao.Name = "RegC_Txt_Duracao";
            RegC_Txt_Duracao.Size = new Size(311, 27);
            RegC_Txt_Duracao.TabIndex = 16;
            RegC_Txt_Duracao.KeyPress += RegC_Txt_Duracao_KeyPress;
            // 
            // RegC_Txt_NumProvas
            // 
            RegC_Txt_NumProvas.Location = new Point(211, 126);
            RegC_Txt_NumProvas.Name = "RegC_Txt_NumProvas";
            RegC_Txt_NumProvas.Size = new Size(311, 27);
            RegC_Txt_NumProvas.TabIndex = 18;
            RegC_Txt_NumProvas.KeyPress += RegC_Txt_NumProvas_KeyPress;
            // 
            // RegC_Btn_Create
            // 
            RegC_Btn_Create.Location = new Point(632, 312);
            RegC_Btn_Create.Name = "RegC_Btn_Create";
            RegC_Btn_Create.Size = new Size(94, 29);
            RegC_Btn_Create.TabIndex = 19;
            RegC_Btn_Create.Text = "Criar";
            RegC_Btn_Create.UseVisualStyleBackColor = true;
            RegC_Btn_Create.Click += RegC_Btn_Create_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(322, 45);
            label7.Name = "label7";
            label7.Size = new Size(182, 31);
            label7.TabIndex = 20;
            label7.Text = "Cadastrar Curso";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(RegC_Txt_Media);
            panel1.Controls.Add(RegC_Btn_Create);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(RegC_Combo_Categoria);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(RegC_Txt_Nome);
            panel1.Controls.Add(RegC_Txt_NumProvas);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(RegC_Radio_Yes);
            panel1.Controls.Add(RegC_Radio_No);
            panel1.Controls.Add(RegC_Txt_Duracao);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(32, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(742, 359);
            panel1.TabIndex = 21;
            panel1.Paint += panel1_Paint;
            // 
            // RegC_Txt_Media
            // 
            RegC_Txt_Media.Location = new Point(211, 176);
            RegC_Txt_Media.Name = "RegC_Txt_Media";
            RegC_Txt_Media.Size = new Size(311, 27);
            RegC_Txt_Media.TabIndex = 20;
            RegC_Txt_Media.KeyPress += RegC_Txt_Media_KeyPress;
            // 
            // CourseCreatePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(panel1);
            Name = "CourseCreatePage";
            Text = "CourseCreatePage";
            Load += CourseCreatePage_Load;
            Controls.SetChildIndex(panel1, 0);
            Controls.SetChildIndex(label7, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private TextBox RegC_Txt_Nome;
        private ComboBox RegC_Combo_Categoria;
        private RadioButton RegC_Radio_Yes;
        private RadioButton RegC_Radio_No;
        private TextBox RegC_Txt_Duracao;
        private TextBox RegC_Txt_NumProvas;
        private Button RegC_Btn_Create;
        private Label label7;
        private Panel panel1;
        private TextBox RegC_Txt_Media;
    }
}