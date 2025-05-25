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
            SuspendLayout();
            // 
            // Login_btn_logar
            // 
            Login_btn_logar.Location = new Point(366, 309);
            Login_btn_logar.Name = "Login_btn_logar";
            Login_btn_logar.Size = new Size(94, 29);
            Login_btn_logar.TabIndex = 0;
            Login_btn_logar.Text = "Entrar";
            Login_btn_logar.UseVisualStyleBackColor = true;
            Login_btn_logar.Click += Login_btn_logar_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Login_btn_logar);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Login_btn_logar;
    }
}