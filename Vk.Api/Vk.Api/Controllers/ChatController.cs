using Microsoft.AspNetCore.Mvc;
using Vk.Api.Domain.Dto;
using Vk.Api.Domain.Models;
using Vk.Api.Domain.Models.Chat;

namespace Vk.Api.Controllers;

[ApiController]
[Route("api/chat/")]
public class ChatController : ControllerBase
{
    [HttpPost("{chatId:guid}/message")]
    public ChatMessage SendMessage(Guid chatId, [FromBody] MessageContent content)
    {
        return new();
    }

    [HttpGet("{chatId:guid}")]
    public Chat GetChat(Guid chatId)
    {
        return new();
    }

    [HttpGet("{chatId:guid}/messages")]
    public IEnumerable<ChatMessage> GetChatMessages(Guid chatId, [FromQuery] int offset, [FromQuery] int limit)
    {
        return new List<ChatMessage>();
    }

    [HttpGet("all")]
    public IEnumerable<Chat> GetChats([FromQuery] int offset, [FromQuery] int limit)
    {
        return new List<Chat>();
    }
}