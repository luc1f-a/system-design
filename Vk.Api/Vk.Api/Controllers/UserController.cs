using Microsoft.AspNetCore.Mvc;
using Vk.Api.Domain.Models.User;

namespace Vk.Api.Controllers;

/// <summary>
/// Контроллер для взаимодействия с пользователем
/// </summary>
[ApiController]
[Route("api/user/")]
public class UserController : ControllerBase
{
    /// <summary>
    /// Отправить пользователю запрос о дружбе
    /// </summary>
    /// <param name="id">Идентификатор пользователя</param>
    /// <returns></returns>
    /// <response code="204">Запрос успешно отправлен</response>
    /// <response code="401">Пользователь не авторизован</response>
    /// <response code="404">Пользователь не найден</response>
    [HttpPost("{id:guid}/friendship-request")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult SendRequestToAddFriend([FromRoute] Guid id)
    {
        return Ok();
    }

    /// <summary>
    /// Подтвердить запрос о дружбе
    /// </summary>
    /// <param name="id">Идентификатор пользователя</param>
    /// <returns></returns>
    /// <response code="204">Запрос на дружбу успешно принят</response>
    /// <response code="401">Пользователь не авторизован</response>
    /// <response code="404">Пользователь не найден</response>
    [HttpPost("{id:guid}/friendship-accept")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult AcceptFriend([FromRoute] Guid id)
    {
        return Ok();
    }

    /// <summary>
    /// Удалить пользователя из друзей
    /// </summary>
    /// <param name="id">Идентификатор пользователя</param>
    /// <returns></returns>
    /// <response code="204">Пользователь удалён из друзей</response>
    /// <response code="401">Пользователь не авторизован</response>
    /// <response code="404">Пользователь не найден</response>
    [HttpDelete("{id:guid}/friend")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult RemoveFriend(Guid id)
    {
        return Ok();
    }

    /// <summary>
    /// Получить список друзей
    /// </summary>
    /// <param name="id">Идентификатор пользователя</param>
    /// <returns></returns>
    /// <response code="200">Успешно</response>
    /// <response code="401">Пользователь не авторизован</response>
    /// <response code="404">Пользователь не найден</response>
    [HttpGet("{id:guid}/friends")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IEnumerable<User> GetFriends([FromRoute] Guid id)
    {
        return new List<User>();
    }

    /// <summary>
    /// Получить пользователя
    /// </summary>
    /// <param name="id">Идентификатор пользователя</param>
    /// <returns></returns>
    /// <response code="200">Успешно</response>
    /// <response code="401">Пользователь не авторизован</response>
    /// <response code="404">Пользователь не найден</response>
    [HttpGet("{id:guid}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public User GetUser([FromRoute] Guid id)
    {
        return new();
    }
}