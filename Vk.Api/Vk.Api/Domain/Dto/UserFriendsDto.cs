using Vk.Api.Domain.Models.User;

namespace Vk.Api.Domain.Dto;

public class GetFriendsDto
{
    public IEnumerable<User> Friends { get; set; }
    public IEnumerable<User> Requests { get; set; }
}