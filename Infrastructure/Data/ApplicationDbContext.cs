using Microsoft.EntityFrameworkCore;
using MyChatbotBackend.Domain.Entities;

namespace MyChatbotBackend.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Construtor que recebe as opções de configuração
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // DbSet para as entidades que serão armazenadas no banco
        public DbSet<Currency> Currencies { get; set; }
    }
}
