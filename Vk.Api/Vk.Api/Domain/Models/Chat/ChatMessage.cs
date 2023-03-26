namespace Vk.Api.Domain.Models.Chat;

public class ChatMessage
{
    public ChatMember Author { get; set; }

    public MessageContent Content { get; set; }
}