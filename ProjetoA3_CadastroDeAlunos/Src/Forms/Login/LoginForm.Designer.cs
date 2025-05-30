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
            SuspendLayout();
            // 
            // Login_btn_logar
            // 
            Login_btn_logar.Location = new Point(376, 220);
            Login_btn_logar.Margin = new Padding(3, 2, 3, 2);
            Login_btn_logar.Name = "Login_btn_logar";
            Login_btn_logar.Size = new Size(100, 22);
            Login_btn_logar.TabIndex = 0;
            Login_btn_logar.Text = "Entrar";
            Login_btn_logar.UseVisualStyleBackColor = true;
            Login_btn_logar.Click += Login_btn_logar_Click;
            // 
            // Lgn_txt_email
            // 
            Lgn_txt_email.Location = new Point(264, 129);
            Lgn_txt_email.Name = "Lgn_txt_email";
            Lgn_txt_email.Size = new Size(212, 23);
            Lgn_txt_email.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 132);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(207, 173);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Senha:";
            // 
            // Lgn_txt_senha
            // 
            Lgn_txt_senha.Location = new Point(264, 170);
            Lgn_txt_senha.Name = "Lgn_txt_senha";
            Lgn_txt_senha.PasswordChar = '*';
            Lgn_txt_senha.Size = new Size(212, 23);
            Lgn_txt_senha.TabIndex = 5;
            // 
            // login_lnklbl_register
            // 
            login_lnklbl_register.AutoSize = true;
            login_lnklbl_register.Location = new Point(264, 227);
            login_lnklbl_register.Name = "login_lnklbl_register";
            login_lnklbl_register.Size = new Size(98, 15);
            login_lnklbl_register.TabIndex = 6;
            login_lnklbl_register.TabStop = true;
            login_lnklbl_register.Text = "Realizar cadastro!";
            login_lnklbl_register.LinkClicked += login_lnklbl_register_LinkClicked_1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(login_lnklbl_register);
            Controls.Add(Lgn_txt_senha);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Lgn_txt_email);
            Controls.Add(Login_btn_logar);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(816, 489);
            MinimumSize = new Size(816, 489);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            TopMost = true;
            Load += LoginForm_Load;
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
    }
}