using EmpresaAPI.Mapping;
using Microsoft.EntityFrameworkCore;

namespace EmpresaAPI.Context
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring
(DbContextOptionsBuilder optionsBuilder)
        {
            //Adicionar a string de conexão do banco de dados
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDEmpresaApp;Integrated Security=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Adicionar as classes de mapeamento (ORM) do projeto
            modelBuilder.ApplyConfiguration(new EmpresaMap());
        }
    }
}
