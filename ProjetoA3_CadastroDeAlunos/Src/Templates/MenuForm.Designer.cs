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
            inicioToolStripMenuItem = new ToolStripMenuItem();
            Menu_MenuItem_Aluno = new ToolStripMenuItem();
            entrarEmUmCursoToolStripMenuItem = new ToolStripMenuItem();
            teste11ToolStripMenuItem = new ToolStripMenuItem();
            teste12ToolStripMenuItem = new ToolStripMenuItem();
            atualizarDadosToolStripMenuItem = new ToolStripMenuItem();
            Menu_MenuItem_Professor = new ToolStripMenuItem();
            criarCursoToolStripMenuItem = new ToolStripMenuItem();
            minhasDisciplinasToolStripMenuItem = new ToolStripMenuItem();
            lançarNotaToolStripMenuItem = new ToolStripMenuItem();
            Menu_MenuItem_Administracao = new ToolStripMenuItem();
            adicionarProfessorToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, Menu_MenuItem_Aluno, Menu_MenuItem_Professor, Menu_MenuItem_Administracao, sairToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(59, 24);
            inicioToolStripMenuItem.Text = "Inicio";
            inicioToolStripMenuItem.Click += inicioToolStripMenuItem_Click;
            // 
            // Menu_MenuItem_Aluno
            // 
            Menu_MenuItem_Aluno.DropDownItems.AddRange(new ToolStripItem[] { entrarEmUmCursoToolStripMenuItem, teste11ToolStripMenuItem, teste12ToolStripMenuItem, atualizarDadosToolStripMenuItem });
            Menu_MenuItem_Aluno.Name = "Menu_MenuItem_Aluno";
            Menu_MenuItem_Aluno.Size = new Size(62, 24);
            Menu_MenuItem_Aluno.Text = "Aluno";
            // 
            // entrarEmUmCursoToolStripMenuItem
            // 
            entrarEmUmCursoToolStripMenuItem.Name = "entrarEmUmCursoToolStripMenuItem";
            entrarEmUmCursoToolStripMenuItem.Size = new Size(220, 26);
            entrarEmUmCursoToolStripMenuItem.Text = "Entrar em um curso";
            entrarEmUmCursoToolStripMenuItem.Click += entrarEmUmCursoToolStripMenuItem_Click;
            // 
            // teste11ToolStripMenuItem
            // 
            teste11ToolStripMenuItem.Name = "teste11ToolStripMenuItem";
            teste11ToolStripMenuItem.Size = new Size(220, 26);
            teste11ToolStripMenuItem.Text = "Cursos ativos";
            teste11ToolStripMenuItem.Click += teste11ToolStripMenuItem_Click;
            // 
            // teste12ToolStripMenuItem
            // 
            teste12ToolStripMenuItem.Name = "teste12ToolStripMenuItem";
            teste12ToolStripMenuItem.Size = new Size(220, 26);
            teste12ToolStripMenuItem.Text = "Histórico de cursos";
            teste12ToolStripMenuItem.Click += teste12ToolStripMenuItem_Click;
            // 
            // atualizarDadosToolStripMenuItem
            // 
            atualizarDadosToolStripMenuItem.Name = "atualizarDadosToolStripMenuItem";
            atualizarDadosToolStripMenuItem.Size = new Size(220, 26);
            atualizarDadosToolStripMenuItem.Text = "Atualizar dados";
            atualizarDadosToolStripMenuItem.Click += atualizarDadosToolStripMenuItem_Click;
            // 
            // Menu_MenuItem_Professor
            // 
            Menu_MenuItem_Professor.DropDownItems.AddRange(new ToolStripItem[] { criarCursoToolStripMenuItem, minhasDisciplinasToolStripMenuItem, lançarNotaToolStripMenuItem });
            Menu_MenuItem_Professor.Name = "Menu_MenuItem_Professor";
            Menu_MenuItem_Professor.Size = new Size(84, 24);
            Menu_MenuItem_Professor.Text = "Professor";
            // 
            // criarCursoToolStripMenuItem
            // 
            criarCursoToolStripMenuItem.Name = "criarCursoToolStripMenuItem";
            criarCursoToolStripMenuItem.Size = new Size(174, 26);
            criarCursoToolStripMenuItem.Text = "Criar curso";
            criarCursoToolStripMenuItem.Click += criarCursoToolStripMenuItem_Click;
            // 
            // minhasDisciplinasToolStripMenuItem
            // 
            minhasDisciplinasToolStripMenuItem.Name = "minhasDisciplinasToolStripMenuItem";
            minhasDisciplinasToolStripMenuItem.Size = new Size(174, 26);
            minhasDisciplinasToolStripMenuItem.Text = "Meus Cursos";
            minhasDisciplinasToolStripMenuItem.Click += minhasDisciplinasToolStripMenuItem_Click;
            // 
            // lançarNotaToolStripMenuItem
            // 
            lançarNotaToolStripMenuItem.Name = "lançarNotaToolStripMenuItem";
            lançarNotaToolStripMenuItem.Size = new Size(174, 26);
            lançarNotaToolStripMenuItem.Text = "Lançar nota";
            lançarNotaToolStripMenuItem.Click += lançarNotaToolStripMenuItem_Click;
            // 
            // Menu_MenuItem_Administracao
            // 
            Menu_MenuItem_Administracao.DropDownItems.AddRange(new ToolStripItem[] { adicionarProfessorToolStripMenuItem });
            Menu_MenuItem_Administracao.Name = "Menu_MenuItem_Administracao";
            Menu_MenuItem_Administracao.Size = new Size(119, 24);
            Menu_MenuItem_Administracao.Text = "Administração";
            // 
            // adicionarProfessorToolStripMenuItem
            // 
            adicionarProfessorToolStripMenuItem.Name = "adicionarProfessorToolStripMenuItem";
            adicionarProfessorToolStripMenuItem.Size = new Size(224, 26);
            adicionarProfessorToolStripMenuItem.Text = "Adicionar professor";
            adicionarProfessorToolStripMenuItem.Click += adicionarProfessorToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem1
            // 
            sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            sairToolStripMenuItem1.Size = new Size(48, 24);
            sairToolStripMenuItem1.Text = "Sair";
            sairToolStripMenuItem1.Click += sairToolStripMenuItem1_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
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
        private ToolStripMenuItem Menu_MenuItem_Aluno;
        private ToolStripMenuItem teste11ToolStripMenuItem;
        private ToolStripMenuItem teste12ToolStripMenuItem;
        private ToolStripMenuItem Menu_MenuItem_Professor;
        private ToolStripMenuItem Menu_MenuItem_Administracao;
        private ToolStripMenuItem minhasDisciplinasToolStripMenuItem;
        private ToolStripMenuItem lançarNotaToolStripMenuItem;
        private ToolStripMenuItem adicionarProfessorToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem atualizarDadosToolStripMenuItem;
        private ToolStripMenuItem criarCursoToolStripMenuItem;
        private ToolStripMenuItem entrarEmUmCursoToolStripMenuItem;
    }
}