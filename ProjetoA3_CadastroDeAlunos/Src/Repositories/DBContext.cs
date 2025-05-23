using Microsoft.EntityFrameworkCore;
using ProjetoA3_CadastroDeAlunos.Src.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoA3_CadastroDeAlunos.Src.Repositories
{
    public class DBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) 
            {
                string server = "localhost";
                int port = 3306;
                string databaseName = "teste";
                string user = "root";
                string password = "admin";
                
                var connectionString = $"server={server};port={port};database={databaseName};uid={user};password={password}";
                optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
            
            }
            
        }

        public DbSet<Aluno> Alunos { get; set; }


    }
}
