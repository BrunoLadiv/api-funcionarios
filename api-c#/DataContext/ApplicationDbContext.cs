using api_c_.Models;
using Microsoft.EntityFrameworkCore;

namespace api_c_.DataContext
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
    }
}


