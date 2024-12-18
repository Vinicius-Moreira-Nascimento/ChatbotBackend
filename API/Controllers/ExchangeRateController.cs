using Microsoft.AspNetCore.Mvc;
using MyChatbotBackend.Application.UseCases;

namespace MyChatbotBackend.API.Controllers
{
    [ApiController] // Indica que essa classe é um Controller
    [Route("api/[controller]")] // Rota base: /api/exchangerate
    public class ExchangeRateController : ControllerBase
    {
        private readonly GetExchangeRateUseCase _getExchangeRateUseCase;

        // Injeta o caso de uso no construtor
        public ExchangeRateController(GetExchangeRateUseCase getExchangeRateUseCase)
        {
            _getExchangeRateUseCase = getExchangeRateUseCase;
        }

        /// <summary>
        /// Obtém a taxa de câmbio entre duas moedas.
        /// </summary>
        /// <param name="fromCurrency">Código da moeda de origem (ex.: USD)</param>
        /// <param name="toCurrency">Código da moeda de destino (ex.: BRL)</param>
        /// <returns>Taxa de câmbio</returns>
        [HttpGet] // Método GET
        [Route("{fromCurrency}/{toCurrency}")] // Rota: /api/exchangerate/USD/BRL
        public async Task<IActionResult> GetExchangeRate(string fromCurrency, string toCurrency)
        {
            try
            {
                // Chama o caso de uso para obter a taxa
                var exchangeRate = await _getExchangeRateUseCase.ExecuteAsync(fromCurrency, toCurrency);

                // Retorna a taxa em JSON
                return Ok(new { FromCurrency = fromCurrency, ToCurrency = toCurrency, ExchangeRate = exchangeRate });
            }
            catch (Exception ex)
            {
                // Retorna erro caso algo dê errado
                return StatusCode(500, new { Error = "An error occurred while retrieving the exchange rate.", Details = ex.Message });
            }
        }
    }
}
