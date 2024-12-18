using MyChatbotBackend.Domain.Interfaces;

namespace MyChatbotBackend.Application.UseCases
{
    public class GetExchangeRateUseCase
    {
        private readonly ICurrencyService _currencyService;

        public GetExchangeRateUseCase(ICurrencyService currencyService)
        {
            _currencyService = currencyService;
        }

        public async Task<decimal> ExecuteAsync(string fromCurrency, string toCurrency)
        {
            // Caso de uso: busca a taxa de câmbio entre duas moedas
            return await _currencyService.GetExchangeRateAsync(fromCurrency, toCurrency);
        }
    }
}