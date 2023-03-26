using Microsoft.AspNetCore.Mvc;
using Vk.Api.Domain.Models.Group;

namespace Vk.Api.Controllers;

/// <summary>
/// Контроллер для взаимодействия с сообществами
/// </summary>
[ApiController]
[Route("api/group/")]
public class GroupController : ControllerBase
{
    /// <summary>
    /// Вступить в сообщество
    /// </summary>
    /// <param name="id">Идентификатор сообщества</param>
    /// <returns></returns>
    /// <response code="204">Зашёл в сообщества</response>
    /// <response code="401">Пользователь не авторизован</response>
    /// <response code="404">Пользователь не найден</response>
    [HttpPost("{id:guid}/join")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult JoinInGroup(Guid id)
    {
        return Ok();
    }

    /// <summary>
    /// Выйти из сообщества
    /// </summary>
    /// <param name="id">Идентификатор сообщества</param>
    /// <returns></returns>
    /// <response code="204">Вышел из сообщества</response>
    /// <response code="401">Пользователь не авторизован</response>
    /// <response code="404">Пользователь не найден</response>
    [HttpDelete("{id:guid}/left")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult LeftFromGroup(Guid id)
    {
        return Ok();
    }

    /// <summary>
    /// Получить список групп пользователя
    /// </summary>
    /// <param name="userId">Идентификатор пользователя</param>
    /// <param name="offset">Смещение</param>
    /// <param name="limit">Лимит</param>
    /// <returns></returns>
    /// <response code="200">Успешно</response>
    /// <response code="401">Пользователь не авторизован</response>
    /// <response code="404">Пользователь не найден</response>
    [HttpGet("{userId:guid}/groups")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IEnumerable<Group> GetUserGroups(Guid userId,[FromQuery] int offset,[FromQuery] int limit)
    {
        return new List<Group>();
    }
}