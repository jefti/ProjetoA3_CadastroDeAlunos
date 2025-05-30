namespace ProjetoA3_CadastroDeAlunos.Src.Forms.TeacherRegisterPage
{
    partial class TeacherRegisterPage
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
            panel1 = new Panel();
            label7 = new Label();
            Reg_btn_salvar_prof = new Button();
            Reg_txt_cargo_prof = new TextBox();
            Reg_txt_endereco_prof = new TextBox();
            Reg_txt_email_prof = new TextBox();
            Reg_msktxt_telefone_prof = new MaskedTextBox();
            Reg_msktxt_cpf_prof = new MaskedTextBox();
            Reg_txt_nome_prof = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label4 = new Label();
            label1 = new Label();
            label5 = new Label();
            Reg_msktxt_senha_prof = new MaskedTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.Controls.Add(Reg_msktxt_senha_prof);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Reg_btn_salvar_prof);
            panel1.Controls.Add(Reg_txt_cargo_prof);
            panel1.Controls.Add(Reg_txt_endereco_prof);
            panel1.Controls.Add(Reg_txt_email_prof);
            panel1.Controls.Add(Reg_msktxt_telefone_prof);
            panel1.Controls.Add(Reg_msktxt_cpf_prof);
            panel1.Controls.Add(Reg_txt_nome_prof);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(113, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 519);
            panel1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(42, 177);
            label7.Name = "label7";
            label7.Size = new Size(74, 28);
            label7.TabIndex = 8;
            label7.Text = "Senha: ";
            // 
            // Reg_btn_salvar_prof
            // 
            Reg_btn_salvar_prof.Location = new Point(560, 432);
            Reg_btn_salvar_prof.Name = "Reg_btn_salvar_prof";
            Reg_btn_salvar_prof.Size = new Size(94, 29);
            Reg_btn_salvar_prof.TabIndex = 14;
            Reg_btn_salvar_prof.Text = "Salvar";
            Reg_btn_salvar_prof.UseVisualStyleBackColor = true;
            Reg_btn_salvar_prof.Click += Reg_btn_salvar_prof_Click_1;
            // 
            // Reg_txt_cargo_prof
            // 
            Reg_txt_cargo_prof.Location = new Point(134, 359);
            Reg_txt_cargo_prof.Name = "Reg_txt_cargo_prof";
            Reg_txt_cargo_prof.Size = new Size(452, 27);
            Reg_txt_cargo_prof.TabIndex = 13;
            // 
            // Reg_txt_endereco_prof
            // 
            Reg_txt_endereco_prof.Location = new Point(133, 323);
            Reg_txt_endereco_prof.Name = "Reg_txt_endereco_prof";
            Reg_txt_endereco_prof.Size = new Size(452, 27);
            Reg_txt_endereco_prof.TabIndex = 13;
            // 
            // Reg_txt_email_prof
            // 
            Reg_txt_email_prof.Location = new Point(133, 287);
            Reg_txt_email_prof.Name = "Reg_txt_email_prof";
            Reg_txt_email_prof.Size = new Size(452, 27);
            Reg_txt_email_prof.TabIndex = 12;
            // 
            // Reg_msktxt_telefone_prof
            // 
            Reg_msktxt_telefone_prof.Location = new Point(133, 251);
            Reg_msktxt_telefone_prof.Mask = "(00) 0 0000-0000";
            Reg_msktxt_telefone_prof.Name = "Reg_msktxt_telefone_prof";
            Reg_msktxt_telefone_prof.Size = new Size(451, 27);
            Reg_msktxt_telefone_prof.TabIndex = 11;
            // 
            // Reg_msktxt_cpf_prof
            // 
            Reg_msktxt_cpf_prof.Location = new Point(133, 215);
            Reg_msktxt_cpf_prof.Mask = "000,000,000-00";
            Reg_msktxt_cpf_prof.Name = "Reg_msktxt_cpf_prof";
            Reg_msktxt_cpf_prof.Size = new Size(451, 27);
            Reg_msktxt_cpf_prof.TabIndex = 10;
            // 
            // Reg_txt_nome_prof
            // 
            Reg_txt_nome_prof.Location = new Point(133, 139);
            Reg_txt_nome_prof.Name = "Reg_txt_nome_prof";
            Reg_txt_nome_prof.Size = new Size(450, 27);
            Reg_txt_nome_prof.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(42, 139);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 2;
            label3.Text = "Nome: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(42, 361);
            label2.Name = "label2";
            label2.Size = new Size(69, 28);
            label2.TabIndex = 5;
            label2.Text = "Cargo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(18, 323);
            label6.Name = "label6";
            label6.Size = new Size(102, 28);
            label6.TabIndex = 5;
            label6.Text = "Endereço: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(61, 212);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 3;
            label4.Text = "CPF: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(48, 287);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Email: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(26, 251);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 4;
            label5.Text = "Telefone: ";
            // 
            // Reg_msktxt_senha_prof
            // 
            Reg_msktxt_senha_prof.Location = new Point(134, 181);
            Reg_msktxt_senha_prof.Name = "Reg_msktxt_senha_prof";
            Reg_msktxt_senha_prof.PasswordChar = '*';
            Reg_msktxt_senha_prof.Size = new Size(449, 27);
            Reg_msktxt_senha_prof.TabIndex = 15;
            // 
            // TeacherRegisterPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 589);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(930, 636);
            MinimumSize = new Size(930, 636);
            Name = "TeacherRegisterPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherRegisterPage";
            Load += TeacherRegisterPage_Load;
            Controls.SetChildIndex(panel1, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button Reg_btn_salvar_prof;
        private TextBox Reg_txt_endereco_prof;
        private TextBox Reg_txt_email_prof;
        private MaskedTextBox Reg_msktxt_telefone_prof;
        private MaskedTextBox Reg_msktxt_cpf_prof;
        private TextBox Reg_txt_nome_prof;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label1;
        private Label label5;
        private TextBox Reg_txt_cargo_prof;
        private Label label2;
        private Label label7;
        private MaskedTextBox Reg_msktxt_senha_prof;
    }
}