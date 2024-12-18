namespace MyChatbotBackend.Domain.Entities
{
    public class Chat
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid UserId { get; set; }
        public string Message { get; set; }
        public string Response { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}