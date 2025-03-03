using Microsoft.EntityFrameworkCore;
using WebApi8_projeto.Models;

namespace WebApi8_projeto.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        // Colocar quais tabelas serão criadas
        public DbSet<AutorModel> Autores {  get; set; }
        public DbSet<LivroModel> Livros { get; set; }
    }
}
