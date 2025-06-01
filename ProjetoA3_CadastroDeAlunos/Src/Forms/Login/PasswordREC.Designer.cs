namespace ProjetoA3_CadastroDeAlunos.Src.Forms.Login
{
    partial class PasswordREC
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
            Rec_txt_senha = new TextBox();
            label1 = new Label();
            btn_confirmar_senha = new Button();
            Rec_txt_email = new TextBox();
            Rec_lbl_email = new Label();
            Rec_lbl_cpf = new Label();
            Rec_msktxt_cpf = new MaskedTextBox();
            Rec_btn_cancelar = new Button();
            SuspendLayout();
            // 
            // Rec_txt_senha
            // 
            Rec_txt_senha.Location = new Point(137, 154);
            Rec_txt_senha.Name = "Rec_txt_senha";
            Rec_txt_senha.PasswordChar = '*';
            Rec_txt_senha.Size = new Size(395, 23);
            Rec_txt_senha.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 157);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Nova Senha:";
            // 
            // btn_confirmar_senha
            // 
            btn_confirmar_senha.Location = new Point(457, 201);
            btn_confirmar_senha.Name = "btn_confirmar_senha";
            btn_confirmar_senha.Size = new Size(75, 23);
            btn_confirmar_senha.TabIndex = 2;
            btn_confirmar_senha.Text = "Confirmar";
            btn_confirmar_senha.UseVisualStyleBackColor = true;
            btn_confirmar_senha.Click += btn_confirmar_senha_Click;
            // 
            // Rec_txt_email
            // 
            Rec_txt_email.Location = new Point(137, 125);
            Rec_txt_email.Name = "Rec_txt_email";
            Rec_txt_email.Size = new Size(395, 23);
            Rec_txt_email.TabIndex = 0;
            // 
            // Rec_lbl_email
            // 
            Rec_lbl_email.AutoSize = true;
            Rec_lbl_email.Location = new Point(58, 128);
            Rec_lbl_email.Name = "Rec_lbl_email";
            Rec_lbl_email.Size = new Size(39, 15);
            Rec_lbl_email.TabIndex = 1;
            Rec_lbl_email.Text = "Email:";
            // 
            // Rec_lbl_cpf
            // 
            Rec_lbl_cpf.AutoSize = true;
            Rec_lbl_cpf.Location = new Point(58, 99);
            Rec_lbl_cpf.Name = "Rec_lbl_cpf";
            Rec_lbl_cpf.Size = new Size(29, 15);
            Rec_lbl_cpf.TabIndex = 1;
            Rec_lbl_cpf.Text = "Cpf:";
            // 
            // Rec_msktxt_cpf
            // 
            Rec_msktxt_cpf.Location = new Point(137, 96);
            Rec_msktxt_cpf.Margin = new Padding(3, 2, 3, 2);
            Rec_msktxt_cpf.Mask = "000,000,000-00";
            Rec_msktxt_cpf.Name = "Rec_msktxt_cpf";
            Rec_msktxt_cpf.Size = new Size(395, 23);
            Rec_msktxt_cpf.TabIndex = 11;
            // 
            // Rec_btn_cancelar
            // 
            Rec_btn_cancelar.Location = new Point(538, 201);
            Rec_btn_cancelar.Name = "Rec_btn_cancelar";
            Rec_btn_cancelar.Size = new Size(75, 23);
            Rec_btn_cancelar.TabIndex = 12;
            Rec_btn_cancelar.Text = "Cancelar";
            Rec_btn_cancelar.UseVisualStyleBackColor = true;
            Rec_btn_cancelar.Click += Rec_btn_cancelar_Click;
            // 
            // PasswordREC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 276);
            Controls.Add(Rec_btn_cancelar);
            Controls.Add(Rec_msktxt_cpf);
            Controls.Add(btn_confirmar_senha);
            Controls.Add(Rec_lbl_cpf);
            Controls.Add(Rec_lbl_email);
            Controls.Add(label1);
            Controls.Add(Rec_txt_email);
            Controls.Add(Rec_txt_senha);
            Name = "PasswordREC";
            Text = "PasswordREC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Rec_txt_senha;
        private Label label1;
        private Button btn_confirmar_senha;
        private TextBox Rec_txt_email;
        private Label Rec_lbl_email;
        private Label Rec_lbl_cpf;
        private MaskedTextBox Rec_msktxt_cpf;
        private Button Rec_btn_cancelar;
    }
}