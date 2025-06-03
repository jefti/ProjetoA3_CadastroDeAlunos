namespace ProjetoA3_CadastroDeAlunos.Src.Forms.Login
{
    partial class RegistrationForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            Reg_btn_cancelar = new Button();
            Reg_btn_salvar = new Button();
            Reg_msktxt_senha = new MaskedTextBox();
            Reg_txt_endereco = new TextBox();
            Reg_txt_email = new TextBox();
            Reg_msktxt_telefone = new MaskedTextBox();
            Reg_msktxt_cpf = new MaskedTextBox();
            Reg_txt_nome = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(19, 212);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Email: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(19, 95);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 1;
            label2.Text = "Senha: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(18, 53);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 2;
            label3.Text = "Nome: ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(18, 132);
            label4.Name = "label4";
            label4.Size = new Size(54, 28);
            label4.TabIndex = 3;
            label4.Text = "CPF: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(18, 172);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 4;
            label5.Text = "Telefone: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(18, 249);
            label6.Name = "label6";
            label6.Size = new Size(102, 28);
            label6.TabIndex = 5;
            label6.Text = "Endereço: ";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Reg_btn_cancelar);
            panel1.Controls.Add(Reg_btn_salvar);
            panel1.Controls.Add(Reg_msktxt_senha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Reg_txt_endereco);
            panel1.Controls.Add(Reg_txt_email);
            panel1.Controls.Add(Reg_msktxt_telefone);
            panel1.Controls.Add(Reg_msktxt_cpf);
            panel1.Controls.Add(Reg_txt_nome);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(119, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 379);
            panel1.TabIndex = 6;
            // 
            // Reg_btn_cancelar
            // 
            Reg_btn_cancelar.Location = new Point(577, 338);
            Reg_btn_cancelar.Name = "Reg_btn_cancelar";
            Reg_btn_cancelar.Size = new Size(94, 29);
            Reg_btn_cancelar.TabIndex = 15;
            Reg_btn_cancelar.Text = "Cancelar";
            Reg_btn_cancelar.UseVisualStyleBackColor = true;
            Reg_btn_cancelar.Click += Reg_btn_cancelar_Click;
            // 
            // Reg_btn_salvar
            // 
            Reg_btn_salvar.Location = new Point(477, 338);
            Reg_btn_salvar.Name = "Reg_btn_salvar";
            Reg_btn_salvar.Size = new Size(94, 29);
            Reg_btn_salvar.TabIndex = 14;
            Reg_btn_salvar.Text = "Salvar";
            Reg_btn_salvar.UseVisualStyleBackColor = true;
            Reg_btn_salvar.Click += Reg_btn_salvar_Click;
            // 
            // Reg_msktxt_senha
            // 
            Reg_msktxt_senha.Font = new Font("Segoe UI", 12F);
            Reg_msktxt_senha.Location = new Point(136, 89);
            Reg_msktxt_senha.Name = "Reg_msktxt_senha";
            Reg_msktxt_senha.PasswordChar = '*';
            Reg_msktxt_senha.Size = new Size(451, 34);
            Reg_msktxt_senha.TabIndex = 9;
            Reg_msktxt_senha.MaskInputRejected += Reg_msktxt_senha_MaskInputRejected;
            // 
            // Reg_txt_endereco
            // 
            Reg_txt_endereco.Font = new Font("Segoe UI", 12F);
            Reg_txt_endereco.Location = new Point(136, 249);
            Reg_txt_endereco.Name = "Reg_txt_endereco";
            Reg_txt_endereco.Size = new Size(452, 34);
            Reg_txt_endereco.TabIndex = 13;
            Reg_txt_endereco.TextChanged += Reg_txt_endereco_TextChanged;
            // 
            // Reg_txt_email
            // 
            Reg_txt_email.Font = new Font("Segoe UI", 12F);
            Reg_txt_email.Location = new Point(136, 209);
            Reg_txt_email.Name = "Reg_txt_email";
            Reg_txt_email.Size = new Size(452, 34);
            Reg_txt_email.TabIndex = 12;
            Reg_txt_email.TextChanged += Reg_txt_email_TextChanged;
            // 
            // Reg_msktxt_telefone
            // 
            Reg_msktxt_telefone.Font = new Font("Segoe UI", 12F);
            Reg_msktxt_telefone.Location = new Point(137, 169);
            Reg_msktxt_telefone.Mask = "(00) 0 0000-0000";
            Reg_msktxt_telefone.Name = "Reg_msktxt_telefone";
            Reg_msktxt_telefone.Size = new Size(451, 34);
            Reg_msktxt_telefone.TabIndex = 11;
            Reg_msktxt_telefone.MaskInputRejected += Reg_msktxt_telefone_MaskInputRejected;
            // 
            // Reg_msktxt_cpf
            // 
            Reg_msktxt_cpf.Font = new Font("Segoe UI", 12F);
            Reg_msktxt_cpf.Location = new Point(137, 129);
            Reg_msktxt_cpf.Mask = "000,000,000-00";
            Reg_msktxt_cpf.Name = "Reg_msktxt_cpf";
            Reg_msktxt_cpf.Size = new Size(451, 34);
            Reg_msktxt_cpf.TabIndex = 10;
            Reg_msktxt_cpf.MaskInputRejected += Reg_msktxt_cpf_MaskInputRejected;
            // 
            // Reg_txt_nome
            // 
            Reg_txt_nome.Font = new Font("Segoe UI", 12F);
            Reg_txt_nome.Location = new Point(138, 50);
            Reg_txt_nome.Name = "Reg_txt_nome";
            Reg_txt_nome.Size = new Size(450, 34);
            Reg_txt_nome.TabIndex = 6;
            Reg_txt_nome.TextChanged += Reg_txt_nome_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(43, 25);
            label7.Name = "label7";
            label7.Size = new Size(388, 54);
            label7.TabIndex = 7;
            label7.Text = "Cadastro de aluno:";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 589);
            Controls.Add(label7);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(930, 636);
            MinimumSize = new Size(930, 636);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de aluno";
            Load += RegistrationForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private MaskedTextBox Reg_msktxt_senha;
        private TextBox Reg_txt_nome;
        private MaskedTextBox Reg_msktxt_cpf;
        private TextBox Reg_txt_email;
        private MaskedTextBox Reg_msktxt_telefone;
        private TextBox Reg_txt_endereco;
        private Label label7;
        private Button Reg_btn_cancelar;
        private Button Reg_btn_salvar;
    }
}