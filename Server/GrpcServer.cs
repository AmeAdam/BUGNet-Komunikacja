using System;
using System.Threading.Tasks;
using Contracts;
using Grpc.Core;

namespace Server
{
    public class GrpcServer : MessageSender.MessageSenderBase
    {
        public override Task<Reply> Send(Message2 message, ServerCallContext context)
        {
            Console.WriteLine($"GRPC - Otrzymano wiadomość: {message.Subject} {message.Created}");
            return Task.FromResult(new Reply());
        }


        public void Host()
        {
            var server = new Grpc.Core.Server
            {
                Services = { MessageSender.BindService(new GrpcServer()) },
                Ports = { new ServerPort("localhost", 9292, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine("Server GRPC oczekuje na wiadomości");
            Console.ReadLine();

            server.ShutdownAsync().Wait();
        }
    }
}
