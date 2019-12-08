using System;
using System.Threading.Tasks;
using Contracts;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace GrpcService1
{
    public class MessageSenderService : MessageSender.MessageSenderBase
    {
        private readonly ILogger<MessageSenderService> _logger;
        public MessageSenderService(ILogger<MessageSenderService> logger)
        {
            _logger = logger;
        }

        public override Task<Reply> Send(Message2 request, ServerCallContext context)
        {
            Console.WriteLine($"GRPC Core - Otrzymano wiadomoœæ: {request.Subject} {request.Created}");
            return Task.FromResult(new Reply());
        }
    }
}
