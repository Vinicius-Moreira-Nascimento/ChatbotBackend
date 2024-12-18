using MyChatbotBackend.Domain.Entities;
using MyChatbotBackend.Domain.Interfaces;

namespace MyChatbotBackend.Application.Services
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyRepository _currencyRepository;

        public CurrencyService(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }

        public async Task<IEnumerable<Currency>> GetExchangeRatesAsync()
        {
            return await _currencyRepository.GetAllAsync();
        }

        public async Task<Currency> GetExchangeRateAsync(string currencyName)
        {
            return await _currencyRepository.GetByNameAsync(currencyName);
        }

        public async Task<decimal> GetExchangeRateAsync(string fromCurrency, string toCurrency)
        {
            return await _currencyRepository.GetExchangeRateAsync(fromCurrency, toCurrency);
        }
    }
}