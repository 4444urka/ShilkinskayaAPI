using Domain.Entities.Message;

namespace Persistence.Abstractions;

// TODO: Репозиторий создан чисто для примера, в будующем планируется сделать его на дженериках
public interface IMessageRepository
{
    public Task<Message> AddMessage(Message message);
    
    public Task<bool> DeleteMessage(int id);
    
    public Task<Message> UpdateMessage(int id, Message newMessage);
    
    public Task<Message> GetMessageById(int id);
    
    public Task<List<Message>> GetAllMessages();
}