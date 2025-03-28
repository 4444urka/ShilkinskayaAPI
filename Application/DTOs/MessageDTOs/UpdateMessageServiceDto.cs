namespace Application.DTOs.MessageDTOs;

public class UpdateMessageServiceDto
{
    int Id { get; set; }
    
    public required string Text { get; set; }
}