using MyChatbotBackend.Domain.Entities;
using MyChatbotBackend.Domain.Interfaces;

namespace MyChatbotBackend.Infrastructure.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        // Simulação de dados
        private static readonly List<Currency> Currencies = new()
        {
            new Currency { Name = "USD", ExchangeRate = 5.25m },
            new Currency { Name = "EUR", ExchangeRate = 6.10m },
            new Currency { Name = "BRL", ExchangeRate = 1.00m }
        };

        public Task<IEnumerable<Currency>> GetAllAsync()
        {
            return Task.FromResult(Currencies.AsEnumerable());
        }

        public Task<Currency> GetByNameAsync(string currencyName)
        {
            var currency = Currencies.FirstOrDefault(c => c.Name == currencyName);
            return Task.FromResult(currency);
        }

        public Task<decimal> GetExchangeRateAsync(string fromCurrency, string toCurrency)
        {
            var from = Currencies.FirstOrDefault(c => c.Name == fromCurrency);
            var to = Currencies.FirstOrDefault(c => c.Name == toCurrency);

            if (from == null || to == null)
                throw new ArgumentException("Invalid currency name(s).");

            var rate = to.ExchangeRate / from.ExchangeRate;
            return Task.FromResult(rate);
        }
    }
}
