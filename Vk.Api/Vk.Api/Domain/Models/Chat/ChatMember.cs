using Vk.Api.Domain.Enums;

namespace Vk.Api.Domain.Models.Chat;

public class ChatMember
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string PictureUrl { get; set; }

    public MemberAuthorType MemberType { get; set; }
}