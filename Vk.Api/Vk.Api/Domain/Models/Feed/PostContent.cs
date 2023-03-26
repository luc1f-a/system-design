namespace Vk.Api.Domain.Models.Feed;

public class PostContent
{
    public string Content { get; set; }

    public string[] Files { get; set; }

    public DateTime CreationDate { get; set; }
}