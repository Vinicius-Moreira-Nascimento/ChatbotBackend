using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using MyChatbotBackend.Infrastructure.Data;

namespace MyChatbotBackend.Infrastructure.Data
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            // Lê a string de conexão do appsettings.json (se estiver configurado no seu projeto)
            var configuration = new ConfigurationBuilder()
                                .SetBasePath(Directory.GetCurrentDirectory()) // Onde o appsettings.json está localizado
                                .AddJsonFile("appsettings.json")
                                .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Configura o DbContext para usar o SQL Server com a string de conexão
            optionsBuilder.UseSqlServer(connectionString);

            // Retorna uma nova instância do ApplicationDbContext com as opções configuradas
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
