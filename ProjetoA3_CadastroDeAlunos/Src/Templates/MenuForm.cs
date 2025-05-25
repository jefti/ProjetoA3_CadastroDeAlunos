using ProjetoA3_CadastroDeAlunos.Forms.LoginForm;
using ProjetoA3_CadastroDeAlunos.Src.Forms.CoursePage;
using ProjetoA3_CadastroDeAlunos.Src.Forms.CourseRegisterPage;
using ProjetoA3_CadastroDeAlunos.Src.Forms.GradesPage;
using ProjetoA3_CadastroDeAlunos.Src.Forms.HistoricalPage;
using ProjetoA3_CadastroDeAlunos.Src.Forms.LandingPage;
using ProjetoA3_CadastroDeAlunos.Src.Forms.TeacherRegisterPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoA3_CadastroDeAlunos.Templates.MenuForm
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void teste11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradesPage frm = new GradesPage();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Close();
        }

        private void teste12ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoricalPage frm = new HistoricalPage();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Close();
        }

        private void minhasDisciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoursePage frm = new CoursePage();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Close();
        }

        private void lançarNotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradesPage frm = new GradesPage();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Close();
        }

        private void adicionarProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherRegisterPage frm = new TeacherRegisterPage();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Close();
        }

        private void gerenciarCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseRegisterPage frm = new CourseRegisterPage();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Close();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Close();
        }

    }
}
