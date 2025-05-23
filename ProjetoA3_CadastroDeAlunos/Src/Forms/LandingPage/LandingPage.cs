using Microsoft.EntityFrameworkCore;
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

namespace ProjetoA3_CadastroDeAlunos.Src.Forms.LandingPage
{
    public partial class LandingPage : ProjetoA3_CadastroDeAlunos.Templates.MenuForm.MenuForm
    {

        DBContext context;
        public LandingPage()
        {
            InitializeComponent();
            this.context = new DBContext();
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {
            var listaDeAlunos = context.Alunos.ToList();
            Land_DataGrid_Alunos.DataSource = listaDeAlunos;
        }

    }
}
