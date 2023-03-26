using Vk.Api.Domain.Enums;

namespace Vk.Api.Domain.Models.Feed;

public class PostAuthor
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string PictureUrl { get; set; }

    public PostAuthorType AuthorType { get; set; }
}