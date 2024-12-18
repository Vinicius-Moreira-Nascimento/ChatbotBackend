using MyChatbotBackend.Domain.Entities;

namespace MyChatbotBackend.Domain.Interfaces
{
    public interface ICurrencyRepository
    {
        Task<IEnumerable<Currency>> GetAllAsync();
        Task<Currency> GetByNameAsync(string currencyName);
        Task<decimal> GetExchangeRateAsync(string fromCurrency, string toCurrency);
    }
}
