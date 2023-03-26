namespace Vk.Api.Domain.Models.Chat;

public class Chat
{
    public Guid Id { get; set; }
    public IEnumerable<ChatMember> Members { get; set; }
    public IEnumerable<ChatMessage> Messages { get; set; }
}