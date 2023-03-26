using Microsoft.AspNetCore.Mvc;
using Vk.Api.Domain.Dto;
using Vk.Api.Domain.Models.Feed;

namespace Vk.Api.Controllers;

[ApiController]
[Route("api/feed/")]
public class FeedController : ControllerBase
{
    [HttpPost("post")]
    public Post SendUserPost([FromBody] PostFeedRequestDto content)
    {
        return new();
    }

    [HttpGet("posts/{userId:guid}")]
    public UserPostsDto GetUserPosts([FromRoute] Guid userId)
    {
        return new();
    }
}