using System;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Contracts;

namespace Server
{
    public class RemotingServer : MarshalByRefObject, IMessageSender
    {
        public void Host()
        {
            var serverChannel = new TcpChannel(9090);
            ChannelServices.RegisterChannel(serverChannel, false);
            RemotingConfiguration.RegisterWellKnownServiceType(
                typeof(RemotingServer), "MessageSender",
                WellKnownObjectMode.Singleton);
            Console.WriteLine("Remoting Server oczekuje na wiadomości");
            Console.ReadLine();
            ChannelServices.UnregisterChannel(serverChannel);
        }

        public void Send(Message message)
        {
            Console.WriteLine($"Remoting - Otrzymano wiadomość: {message.Subject} {message.Created}");
        }
    }
}