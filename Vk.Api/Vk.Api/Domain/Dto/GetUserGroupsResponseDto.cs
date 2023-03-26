namespace Vk.Api.Domain.Dto;

public class GetUserGroupsResponseDto
{
    public Guid GroupId { get; set; }

    public string Name { get; set; }

    public string PictureUrl { get; set; }
}