using Microsoft.EntityFrameworkCore;

namespace SistemaIgreja.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        { 

        }

        public DbSet<Cadastro> Cadastro { get; set; }


    }
}
