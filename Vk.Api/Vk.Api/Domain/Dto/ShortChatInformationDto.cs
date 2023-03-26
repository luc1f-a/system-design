using Vk.Api.Domain.Models.Chat;

namespace Vk.Api.Domain.Dto;

public class ShortChatInformationDto
{
    public Guid Id { get; set; }

    public string Name { get; set; }

    public string PictureUrl { get; set; }

    public ChatMessage LastMessage { get; set; }

    public uint? CountOfUnreadMessages { get; set; }
}