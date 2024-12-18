using MyChatbotBackend.Domain.Entities;

namespace MyChatbotBackend.Domain.Interfaces
{
    public interface ICurrencyService
    {
        Task<IEnumerable<Currency>> GetExchangeRatesAsync();
        Task<Currency> GetExchangeRateAsync(string currencyName);
        Task<decimal> GetExchangeRateAsync(string fromCurrency, string toCurrency);
    }
}
