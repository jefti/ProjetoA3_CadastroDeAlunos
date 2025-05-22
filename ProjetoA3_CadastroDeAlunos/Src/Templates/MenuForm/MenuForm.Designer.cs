namespace ProjetoA3_CadastroDeAlunos.Templates.MenuForm
{
    partial class MenuForm
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
            menuStrip1 = new MenuStrip();
            teste1ToolStripMenuItem = new ToolStripMenuItem();
            teste11ToolStripMenuItem = new ToolStripMenuItem();
            teste12ToolStripMenuItem = new ToolStripMenuItem();
            test2ToolStripMenuItem = new ToolStripMenuItem();
            minhasDisciplinasToolStripMenuItem = new ToolStripMenuItem();
            lançarNotaToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            adicionarProfessorToolStripMenuItem = new ToolStripMenuItem();
            gerenciarCursosToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { teste1ToolStripMenuItem, test2ToolStripMenuItem, sairToolStripMenuItem, sairToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // teste1ToolStripMenuItem
            // 
            teste1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { teste11ToolStripMenuItem, teste12ToolStripMenuItem });
            teste1ToolStripMenuItem.Name = "teste1ToolStripMenuItem";
            teste1ToolStripMenuItem.Size = new Size(62, 24);
            teste1ToolStripMenuItem.Text = "Aluno";
            // 
            // teste11ToolStripMenuItem
            // 
            teste11ToolStripMenuItem.Name = "teste11ToolStripMenuItem";
            teste11ToolStripMenuItem.Size = new Size(215, 26);
            teste11ToolStripMenuItem.Text = "Disciplinas e notas";
            // 
            // teste12ToolStripMenuItem
            // 
            teste12ToolStripMenuItem.Name = "teste12ToolStripMenuItem";
            teste12ToolStripMenuItem.Size = new Size(215, 26);
            teste12ToolStripMenuItem.Text = "Histórico escolar";
            // 
            // test2ToolStripMenuItem
            // 
            test2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { minhasDisciplinasToolStripMenuItem, lançarNotaToolStripMenuItem });
            test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            test2ToolStripMenuItem.Size = new Size(84, 24);
            test2ToolStripMenuItem.Text = "Professor";
            // 
            // minhasDisciplinasToolStripMenuItem
            // 
            minhasDisciplinasToolStripMenuItem.Name = "minhasDisciplinasToolStripMenuItem";
            minhasDisciplinasToolStripMenuItem.Size = new Size(212, 26);
            minhasDisciplinasToolStripMenuItem.Text = "Minhas disciplinas";
            // 
            // lançarNotaToolStripMenuItem
            // 
            lançarNotaToolStripMenuItem.Name = "lançarNotaToolStripMenuItem";
            lançarNotaToolStripMenuItem.Size = new Size(212, 26);
            lançarNotaToolStripMenuItem.Text = "Lançar nota";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adicionarProfessorToolStripMenuItem, gerenciarCursosToolStripMenuItem });
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(119, 24);
            sairToolStripMenuItem.Text = "Administração";
            // 
            // adicionarProfessorToolStripMenuItem
            // 
            adicionarProfessorToolStripMenuItem.Name = "adicionarProfessorToolStripMenuItem";
            adicionarProfessorToolStripMenuItem.Size = new Size(222, 26);
            adicionarProfessorToolStripMenuItem.Text = "Adicionar professor";
            // 
            // gerenciarCursosToolStripMenuItem
            // 
            gerenciarCursosToolStripMenuItem.Name = "gerenciarCursosToolStripMenuItem";
            gerenciarCursosToolStripMenuItem.Size = new Size(222, 26);
            gerenciarCursosToolStripMenuItem.Text = "Gerenciar cursos";
            // 
            // sairToolStripMenuItem1
            // 
            sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            sairToolStripMenuItem1.Size = new Size(48, 24);
            sairToolStripMenuItem1.Text = "Sair";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuForm";
            Text = "MenuForm";
            Load += MenuForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem teste1ToolStripMenuItem;
        private ToolStripMenuItem teste11ToolStripMenuItem;
        private ToolStripMenuItem teste12ToolStripMenuItem;
        private ToolStripMenuItem test2ToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem minhasDisciplinasToolStripMenuItem;
        private ToolStripMenuItem lançarNotaToolStripMenuItem;
        private ToolStripMenuItem adicionarProfessorToolStripMenuItem;
        private ToolStripMenuItem gerenciarCursosToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem1;
    }
}