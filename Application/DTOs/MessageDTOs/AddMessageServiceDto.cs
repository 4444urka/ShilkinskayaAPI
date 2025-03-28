namespace Application.DTOs.MessageDTOs;

public class AddMessageServiceDto
{
    public int OwnerId { get; set; }
    
    public required string Text { get; set; }
}