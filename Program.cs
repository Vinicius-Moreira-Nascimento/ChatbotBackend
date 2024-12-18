using MyChatbotBackend.Application.Services;
using MyChatbotBackend.Application.UseCases;
using MyChatbotBackend.Domain.Interfaces;
using MyChatbotBackend.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using MyChatbotBackend.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);


// Configuração do DbContext para usar o SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add services to the container.
// Configuração de Serviços e Casos de Uso
builder.Services.AddScoped<ICurrencyService, CurrencyService>(); // Registrar o serviço
builder.Services.AddScoped<GetExchangeRateUseCase>(); // Registrar o caso de uso

// TODO: Substitua por uma implementação real quando criar o Repositório
builder.Services.AddScoped<ICurrencyRepository, CurrencyRepository>();

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Exemplo de rota provisória para teste do caso de uso
app.MapGet("/exchange-rate", async (GetExchangeRateUseCase useCase) =>
{
    var rate = await useCase.ExecuteAsync("USD", "BRL");
    return Results.Ok(new { ExchangeRate = rate });
})
.WithName("GetExchangeRate");

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
