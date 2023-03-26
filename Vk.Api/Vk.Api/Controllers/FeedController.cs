using Microsoft.AspNetCore.Mvc;
using Vk.Api.Domain.Dto;
using Vk.Api.Domain.Models.Feed;

namespace Vk.Api.Controllers;

/// <summary>
/// Контроллер для взаимодействия с постами пользователей и сообществ
/// </summary>
[ApiController]
[Route("api/feed/")]
public class FeedController : ControllerBase
{
    /// <summary>
    /// Отправить пост
    /// </summary>
    /// <param name="content"></param>
    /// <returns></returns>
    /// <response code="200">Успешно</response>
    /// <response code="401">Пользователь не авторизован</response>
    /// <response code="404">Пользователь не найден</response>
    [HttpPost("post")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public Post SendUserPost([FromBody] PostContent content)
    {
        return new();
    }

    /// <summary>
    /// Получает список постов пользователя
    /// </summary>
    /// <param name="userId">Идентификатор пользователя</param>
    /// <param name="offset">Смещение</param>
    /// <param name="limit">Лимит записей</param>
    /// <returns></returns>
    /// <response code="200">Успешно</response>
    /// <response code="401">Пользователь не авторизован</response>
    /// <response code="404">Пользователь не найден</response>
    [HttpGet("{userId:guid}/posts")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IEnumerable<Post> GetUserPosts([FromRoute] Guid userId, [FromQuery] int offset, [FromQuery] int limit)
    {
        return new List<Post>();
    }
}