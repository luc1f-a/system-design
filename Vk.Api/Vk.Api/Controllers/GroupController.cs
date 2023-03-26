using Microsoft.AspNetCore.Mvc;
using Vk.Api.Domain.Dto;

namespace Vk.Api.Controllers;

[ApiController]
[Route("api/group/")]
public class GroupController : ControllerBase
{
    [HttpPost("join")]
    public IActionResult JoinInGroup(Guid groupId)
    {
        return Ok();
    }

    [HttpDelete("left")]
    public IActionResult LeftFromGroup(Guid groupId)
    {
        return Ok();
    }
}