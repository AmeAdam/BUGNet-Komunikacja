using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Contracts;
using Grpc.Core;

namespace Client
{
    public class GrpcSender : IMessageSender
    {
        public void Send(Message message)
        {
            Channel channel = new Channel("127.0.0.1:9292", ChannelCredentials.Insecure);
            var client = new MessageSender.MessageSenderClient(channel);
            client.Send(new Message2{ Subject = message.Subject, Created = message.Created.Ticks});
        }
    }
}