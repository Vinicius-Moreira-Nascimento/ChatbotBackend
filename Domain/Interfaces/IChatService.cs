using MyChatbotBackend.Domain.Entities;

namespace MyChatbotBackend.Domain.Interfaces
{
    public interface IChatService
    {
        Task<string> GetResponseAsync(string message);
        Task LogChatAsync(Chat chat);
    }
}