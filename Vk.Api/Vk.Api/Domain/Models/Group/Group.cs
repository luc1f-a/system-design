namespace Vk.Api.Domain.Models.Group;

public class Group
{
    public Guid Id { get; set; }
    
    public string Name { get; set; }
    
    public bool IsSubscribe { get; set; }
}