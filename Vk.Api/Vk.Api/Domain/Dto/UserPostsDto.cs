using Vk.Api.Domain.Models.Feed;

namespace Vk.Api.Domain.Dto;

public class UserPostsDto
{
    public PostAuthor Author { get; set; }

    public IEnumerable<PostContent> Posts { get; set; }
}