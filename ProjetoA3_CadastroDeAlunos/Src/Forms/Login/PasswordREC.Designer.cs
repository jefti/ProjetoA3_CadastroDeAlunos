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
            label2 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Rec_txt_senha
            // 
            Rec_txt_senha.Location = new Point(189, 150);
            Rec_txt_senha.Margin = new Padding(3, 4, 3, 4);
            Rec_txt_senha.Name = "Rec_txt_senha";
            Rec_txt_senha.PasswordChar = '*';
            Rec_txt_senha.Size = new Size(451, 27);
            Rec_txt_senha.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(47, 149);
            label1.Name = "label1";
            label1.Size = new Size(121, 28);
            label1.TabIndex = 1;
            label1.Text = "Nova Senha:";
            // 
            // btn_confirmar_senha
            // 
            btn_confirmar_senha.Location = new Point(630, 318);
            btn_confirmar_senha.Margin = new Padding(3, 4, 3, 4);
            btn_confirmar_senha.Name = "btn_confirmar_senha";
            btn_confirmar_senha.Size = new Size(86, 31);
            btn_confirmar_senha.TabIndex = 2;
            btn_confirmar_senha.Text = "Confirmar";
            btn_confirmar_senha.UseVisualStyleBackColor = true;
            btn_confirmar_senha.Click += btn_confirmar_senha_Click;
            // 
            // Rec_txt_email
            // 
            Rec_txt_email.Location = new Point(189, 112);
            Rec_txt_email.Margin = new Padding(3, 4, 3, 4);
            Rec_txt_email.Name = "Rec_txt_email";
            Rec_txt_email.Size = new Size(451, 27);
            Rec_txt_email.TabIndex = 0;
            // 
            // Rec_lbl_email
            // 
            Rec_lbl_email.AutoSize = true;
            Rec_lbl_email.Font = new Font("Segoe UI", 12F);
            Rec_lbl_email.Location = new Point(47, 112);
            Rec_lbl_email.Name = "Rec_lbl_email";
            Rec_lbl_email.Size = new Size(63, 28);
            Rec_lbl_email.TabIndex = 1;
            Rec_lbl_email.Text = "Email:";
            // 
            // Rec_lbl_cpf
            // 
            Rec_lbl_cpf.AutoSize = true;
            Rec_lbl_cpf.Font = new Font("Segoe UI", 12F);
            Rec_lbl_cpf.Location = new Point(47, 73);
            Rec_lbl_cpf.Name = "Rec_lbl_cpf";
            Rec_lbl_cpf.Size = new Size(46, 28);
            Rec_lbl_cpf.TabIndex = 1;
            Rec_lbl_cpf.Text = "Cpf:";
            // 
            // Rec_msktxt_cpf
            // 
            Rec_msktxt_cpf.Location = new Point(189, 73);
            Rec_msktxt_cpf.Mask = "000,000,000-00";
            Rec_msktxt_cpf.Name = "Rec_msktxt_cpf";
            Rec_msktxt_cpf.Size = new Size(451, 27);
            Rec_msktxt_cpf.TabIndex = 11;
            // 
            // Rec_btn_cancelar
            // 
            Rec_btn_cancelar.Location = new Point(722, 318);
            Rec_btn_cancelar.Margin = new Padding(3, 4, 3, 4);
            Rec_btn_cancelar.Name = "Rec_btn_cancelar";
            Rec_btn_cancelar.Size = new Size(86, 31);
            Rec_btn_cancelar.TabIndex = 12;
            Rec_btn_cancelar.Text = "Cancelar";
            Rec_btn_cancelar.UseVisualStyleBackColor = true;
            Rec_btn_cancelar.Click += Rec_btn_cancelar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 32);
            label2.Name = "label2";
            label2.Size = new Size(339, 54);
            label2.TabIndex = 13;
            label2.Text = "Recuperar Senha";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Rec_btn_cancelar);
            panel1.Controls.Add(Rec_msktxt_cpf);
            panel1.Controls.Add(btn_confirmar_senha);
            panel1.Controls.Add(Rec_lbl_cpf);
            panel1.Controls.Add(Rec_lbl_email);
            panel1.Controls.Add(Rec_txt_senha);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Rec_txt_email);
            panel1.Location = new Point(48, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 368);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            // 
            // PasswordREC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 589);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(930, 636);
            MinimumSize = new Size(930, 636);
            Name = "PasswordREC";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recuperar Senha";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label2;
        private Panel panel1;
    }
}