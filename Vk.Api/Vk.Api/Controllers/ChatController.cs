using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Vk.Api.Domain.Dto;
using Vk.Api.Domain.Models.Chat;

namespace Vk.Api.Controllers;

/// <summary>
/// Контроллер для взаимодействия с чатом
/// </summary>
[ApiController]
[Route("api/chat/")]
public class ChatController : ControllerBase
{
    /// <summary>
    /// Получить чат
    /// </summary>
    /// <param name="id">Идентификатор чата</param>
    /// <returns></returns>
    /// <response code="200">Успешно</response>
    /// <response code="401">Пользователь не авторизован</response>
    /// <response code="404">Пользователь не найден</response>
    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public Chat GetChat(Guid id)
    {
        return new();
    }

    /// <summary>
    /// Отправка сообщения 
    /// </summary>
    /// <param name="id">Идентификатор чата</param>
    /// <param name="senderId">Идентификатор отправителя. Добавлено с заделом, что сообщения смогут отправлять сообщества и боты</param>
    /// <param name="content">Сообщение</param>
    /// <returns></returns>
    /// <response code="200">Успешно</response>
    /// <response code="401">Пользователь не авторизован</response>
    /// <response code="404">Пользователь не найден</response>
    [HttpPost("{id:guid}/message")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ChatMessage SendMessage(Guid id, [FromQuery, Required] Guid senderId, [FromBody] MessageContent content)
    {
        return new();
    }

    /// <summary>
    /// Получить сообщения из чата
    /// </summary>
    /// <param name="id">Идентификатор чата</param>
    /// <param name="offset">Смещение</param>
    /// <param name="limit">Лимит записей</param>
    /// <returns></returns>
    /// <response code="200">Успешно</response>
    /// <response code="401">Пользователь не авторизован</response>
    /// <response code="404">Пользователь не найден</response>
    [HttpGet("{id:guid}/messages")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IEnumerable<ChatMessage> GetChatMessages(Guid id, [FromQuery] int offset, [FromQuery] int limit)
    {
        return new List<ChatMessage>();
    }

    /// <summary>
    /// Получить список чатов
    /// </summary>
    /// <param name="offset"></param>
    /// <param name="limit"></param>
    /// <returns></returns>
    /// <response code="200">Успешно</response>
    /// <response code="401">Пользователь не авторизован</response>
    /// <response code="404">Пользователь не найден</response>
    [HttpGet("list")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IEnumerable<ShortChatInformationDto> GetChats([FromQuery] int offset, [FromQuery] int limit)
    {
        return new List<ShortChatInformationDto>();
    }
}