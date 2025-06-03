namespace ProjetoA3_CadastroDeAlunos.Forms.LoginForm
{
    partial class LoginForm
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
            Login_btn_logar = new Button();
            Lgn_txt_email = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Lgn_txt_senha = new MaskedTextBox();
            login_lnklbl_register = new LinkLabel();
            label3 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Login_btn_logar
            // 
            Login_btn_logar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_btn_logar.Location = new Point(309, 261);
            Login_btn_logar.Name = "Login_btn_logar";
            Login_btn_logar.Size = new Size(150, 40);
            Login_btn_logar.TabIndex = 0;
            Login_btn_logar.Text = "Entrar";
            Login_btn_logar.UseVisualStyleBackColor = true;
            Login_btn_logar.Click += Login_btn_logar_Click;
            // 
            // Lgn_txt_email
            // 
            Lgn_txt_email.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lgn_txt_email.Location = new Point(202, 110);
            Lgn_txt_email.Margin = new Padding(3, 4, 3, 4);
            Lgn_txt_email.Name = "Lgn_txt_email";
            Lgn_txt_email.Size = new Size(382, 38);
            Lgn_txt_email.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(103, 113);
            label1.Name = "label1";
            label1.Size = new Size(79, 31);
            label1.TabIndex = 3;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(103, 179);
            label2.Name = "label2";
            label2.Size = new Size(85, 31);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // Lgn_txt_senha
            // 
            Lgn_txt_senha.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Lgn_txt_senha.Location = new Point(202, 172);
            Lgn_txt_senha.Margin = new Padding(3, 4, 3, 4);
            Lgn_txt_senha.Name = "Lgn_txt_senha";
            Lgn_txt_senha.PasswordChar = '*';
            Lgn_txt_senha.Size = new Size(382, 38);
            Lgn_txt_senha.TabIndex = 5;
            // 
            // login_lnklbl_register
            // 
            login_lnklbl_register.AutoSize = true;
            login_lnklbl_register.Location = new Point(244, 304);
            login_lnklbl_register.Name = "login_lnklbl_register";
            login_lnklbl_register.Size = new Size(284, 20);
            login_lnklbl_register.TabIndex = 6;
            login_lnklbl_register.TabStop = true;
            login_lnklbl_register.Text = "Ainda não tem acesso? Realizar cadastro!";
            login_lnklbl_register.LinkClicked += login_lnklbl_register_LinkClicked_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(312, 67);
            label3.Name = "label3";
            label3.Size = new Size(295, 54);
            label3.TabIndex = 7;
            label3.Text = "Tela de Acesso";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Login_btn_logar);
            panel1.Controls.Add(Lgn_txt_senha);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(login_lnklbl_register);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Lgn_txt_email);
            panel1.Location = new Point(112, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 352);
            panel1.TabIndex = 8;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 589);
            Controls.Add(label3);
            Controls.Add(panel1);
            MaximumSize = new Size(930, 636);
            MinimumSize = new Size(930, 636);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela de login";
            TopMost = true;
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login_btn_logar;
        private TextBox Lgn_txt_email;
        private Label label1;
        private Label label2;
        private MaskedTextBox Lgn_txt_senha;
        private LinkLabel login_lnklbl_register;
        private Label label3;
        private Panel panel1;
    }
}