using Microsoft.AspNetCore.Mvc;
using Vk.Api.Domain.Dto;
using Vk.Api.Domain.Models.User;

namespace Vk.Api.Controllers;

[ApiController]
[Route("api/user/")]
public class UserController : ControllerBase
{

    [HttpPost("friend")]
    public IActionResult AddFriend(Guid targetUserId)
    {
        return Ok();
    }

    [HttpDelete("friend")]
    public IActionResult RemoveFriend(Guid targetUserId)
    {
        return Ok();
    }


    [HttpGet("{userId:guid}/friends")]
    public IEnumerable<User> GetFriends([FromRoute] Guid userId)
    {
        return new List<User>();
    }

}