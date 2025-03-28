using Application.DTOs.MessageDTOs;
using Domain.Entities.Message;

namespace Application.Abstractions;

public interface IMessageService
{
    public Task<Message> GetMessageById(int id);
    
    public Task<Message> GetAllMessages();
    
    public Task<Message> AddMessage(AddMessageServiceDto message);
    
    public Task<Message> UpdateMessage(UpdateMessageServiceDto message);
    
    public Task<bool> DeleteMessage(int id);
}