using ProjetoA3_CadastroDeAlunos.Forms.LoginForm;
using ProjetoA3_CadastroDeAlunos.Src.Forms.Admin;
using ProjetoA3_CadastroDeAlunos.Src.Forms.AppointmentPage;
using ProjetoA3_CadastroDeAlunos.Src.Forms.CoursePage;
using ProjetoA3_CadastroDeAlunos.Src.Forms.CourseRegisterPage;
using ProjetoA3_CadastroDeAlunos.Src.Forms.GradesPage;
using ProjetoA3_CadastroDeAlunos.Src.Forms.HistoricalPage;
using ProjetoA3_CadastroDeAlunos.Src.Forms.LandingPage;
using ProjetoA3_CadastroDeAlunos.Src.Forms.Students;
using ProjetoA3_CadastroDeAlunos.Src.Forms.Teacher;
using ProjetoA3_CadastroDeAlunos.Src.Forms.TeacherRegisterPage;
using ProjetoA3_CadastroDeAlunos.Src.Repositories;
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
            this.RenderMenu();
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
            AppointmentPage frm = new AppointmentPage();
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
            EnrolStudentPage frm = new EnrolStudentPage();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Close();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            UserSession.Logout();

            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Close();
        }

        public void RenderMenu()
        {
            string tipo = UserSession.Tipo;

            switch (tipo)
            {
                case "aluno":
                    this.MenuControl(true, false, false);
                    break;
                case "funcionario":
                    this.MenuControl(false, true, false);
                    break;
                case "administrador":
                    this.MenuControl(false, false, true);
                    break;
            }

        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LandingPage frm = new LandingPage();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Close();
        }

        private void atualizarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUserForm frm = new UpdateUserForm();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Close();
        }

        private void MenuControl(Boolean studentBool, Boolean teacherBool, Boolean adminBool)
        {
            Menu_MenuItem_Aluno.Visible = studentBool;
            Menu_MenuItem_Professor.Visible = teacherBool;
            Menu_MenuItem_Administracao.Visible = adminBool;
        }

        private void adicionarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseRegisterPage frm = new CourseRegisterPage();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Close();
        }

        private void criarCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseCreatePage frm = new CourseCreatePage();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Close();
        }
    }
}
