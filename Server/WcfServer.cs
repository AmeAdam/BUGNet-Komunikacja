using System;
using System.ServiceModel;
using Contracts;

namespace Server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class WcfServer : IMessageSender
    {
        public void Host()
        {
            var host = new ServiceHost(this);
            host.AddServiceEndpoint(typeof(IMessageSender), new NetTcpBinding(),
                "net.tcp://localhost:9191/IMessageSender");
            host.Open();
            Console.WriteLine("WCF Server oczekuje na wiadomości");
            Console.ReadLine();
        }

        public void Send(Message message)
        {
            Console.WriteLine($"WCF - Otrzymano wiadomość: {message.Subject} {message.Created}");
        }
    }
}
