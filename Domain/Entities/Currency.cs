namespace MyChatbotBackend.Domain.Entities
{
    public class Currency
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public decimal ExchangeRate { get; set; } // Taxa de câmbio
        public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    }
}