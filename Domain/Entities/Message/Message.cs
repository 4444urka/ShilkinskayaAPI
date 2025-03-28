using Domain.Abstractions;

namespace Domain.Entities.Message;

public class Message : BaseEntity
{
    public required int OwnerId { get; set; }
    
    public required string Text {get; set; }
    
    public required DateTime Date { get; set; } = DateTime.UtcNow;
}