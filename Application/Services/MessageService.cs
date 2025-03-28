using Application.Abstractions;
using Application.DTOs.MessageDTOs;
using Domain.Entities.Message;
using Microsoft.Extensions.Logging;
using Persistence.Abstractions;

namespace Application.Services;
// TODO: Имплементировать сервис
public class MessageService : IMessageService
{
    private readonly IMessageRepository _messageRepository;
    private readonly ILogger<MessageService> _logger;

    public MessageService(IMessageRepository messageRepository, ILogger<MessageService> logger)
    {
        _messageRepository = messageRepository;
        _logger = logger;
    }

    public Task<Message> GetMessageById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Message> GetAllMessages()
    {
        throw new NotImplementedException();
    }

    public Task<Message> AddMessage(AddMessageServiceDto message)
    {
        throw new NotImplementedException();
    }

    public Task<Message> UpdateMessage(UpdateMessageServiceDto message)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteMessage(int id)
    {
        throw new NotImplementedException();
    }
}