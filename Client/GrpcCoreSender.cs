using Contracts;
using Grpc.Core;

namespace Client
{
    public class GrpcCoreSender : IMessageSender
    {
        public void Send(Message message)
        {
            var channel = new Channel("localhost", 5000, ChannelCredentials.Insecure);
            var client = new MessageSender.MessageSenderClient(channel);
            client.Send(new Message2{ Subject = message.Subject, Created = message.Created.Ticks});
        }
    }
}