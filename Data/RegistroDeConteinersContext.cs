using Microsoft.EntityFrameworkCore;

namespace RegistroDeConteiners.Data
{
    public class RegistroDeConteinersContext : DbContext
    {
        public RegistroDeConteinersContext(
            DbContextOptions<RegistroDeConteinersContext> options)
            : base(options)
        {
        }

        public DbSet<RegistroDeConteiners.Models.Conteiner> Conteiner { get; set; }
        public DbSet<RegistroDeConteiners.Models.Movimentacoes> Movimentacoes { get; set; }
    }
}