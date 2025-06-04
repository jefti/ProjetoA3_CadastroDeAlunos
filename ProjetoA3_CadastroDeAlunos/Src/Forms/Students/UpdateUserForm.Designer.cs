namespace ProjetoA3_CadastroDeAlunos.Src.Forms.Students
{
    partial class UpdateUserForm
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
            Reg_btn__updt = new Button();
            Reg_txt_email_updt = new TextBox();
            Reg_msktxt_telefone_updt = new MaskedTextBox();
            Reg_txt_nome_updt = new TextBox();
            label3 = new Label();
            label1 = new Label();
            label5 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(Reg_btn__updt);
            panel1.Controls.Add(Reg_txt_email_updt);
            panel1.Controls.Add(Reg_msktxt_telefone_updt);
            panel1.Controls.Add(Reg_txt_nome_updt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(113, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(689, 450);
            panel1.TabIndex = 8;
            // 
            // Reg_btn__updt
            // 
            Reg_btn__updt.Location = new Point(580, 401);
            Reg_btn__updt.Margin = new Padding(3, 4, 3, 4);
            Reg_btn__updt.Name = "Reg_btn__updt";
            Reg_btn__updt.Size = new Size(91, 31);
            Reg_btn__updt.TabIndex = 13;
            Reg_btn__updt.Text = "Atualizar";
            Reg_btn__updt.UseVisualStyleBackColor = true;
            Reg_btn__updt.Click += Reg_btn__updt_Click;
            // 
            // Reg_txt_email_updt
            // 
            Reg_txt_email_updt.Location = new Point(141, 269);
            Reg_txt_email_updt.Margin = new Padding(3, 4, 3, 4);
            Reg_txt_email_updt.Name = "Reg_txt_email_updt";
            Reg_txt_email_updt.Size = new Size(450, 27);
            Reg_txt_email_updt.TabIndex = 12;
            // 
            // Reg_msktxt_telefone_updt
            // 
            Reg_msktxt_telefone_updt.Location = new Point(139, 232);
            Reg_msktxt_telefone_updt.Mask = "(00) 0 0000-0000";
            Reg_msktxt_telefone_updt.Name = "Reg_msktxt_telefone_updt";
            Reg_msktxt_telefone_updt.Size = new Size(451, 27);
            Reg_msktxt_telefone_updt.TabIndex = 11;
            // 
            // Reg_txt_nome_updt
            // 
            Reg_txt_nome_updt.Location = new Point(141, 192);
            Reg_txt_nome_updt.Name = "Reg_txt_nome_updt";
            Reg_txt_nome_updt.Size = new Size(450, 27);
            Reg_txt_nome_updt.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(50, 190);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 2;
            label3.Text = "Nome: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(56, 266);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 0;
            label1.Text = "Email: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(34, 229);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 4;
            label5.Text = "Telefone: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(250, 30);
            label8.Name = "label8";
            label8.Size = new Size(206, 28);
            label8.TabIndex = 14;
            label8.Text = "Alterar informações:";
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 589);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(930, 636);
            MinimumSize = new Size(930, 636);
            Name = "UpdateUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UpdateUserForm";
            Load += UpdateUserForm_Load;
            Controls.SetChildIndex(panel1, 0);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MaskedTextBox Reg_msktxt_senha_updt;
        private Label label7;
        private Button Reg_btn_salvar_prof;
        private TextBox Reg_txt_cargo_prof;
        private TextBox Reg_txt_endereco_prof;
        private TextBox Reg_txt_email_prof;
        private MaskedTextBox Reg_msktxt_telefone_updt;
        private MaskedTextBox Reg_msktxt_cpf_updt;
        private TextBox Reg_txt_nome_updt;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label4;
        private Label label1;
        private Label label5;
        private Button Reg_btn__updt;
        private TextBox Reg_txt_email_updt;
        private Label label8;
    }
}