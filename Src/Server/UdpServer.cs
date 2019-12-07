using System;
using System.Net;
using System.Net.Sockets;
using Contracts;

namespace Server
{
    public class UdpServer
    {
        private readonly UdpSerializer serializer = new UdpSerializer();
        public void Host()
        {
            var ep = new IPEndPoint(IPAddress.Any, 5000);
            var receiver = new IPEndPoint(IPAddress.Any, 0);
            var udpHost = new UdpClient(ep);
            Console.WriteLine("Server oczekuje na wiadomości");
            while (true)
            {
                var bytes = udpHost.Receive(ref receiver);
                var message = serializer.Deserialize(bytes);
                Console.WriteLine($"UDP - Otrzymano wiadomość: {message.Subject} {message.Created} od {receiver.Address} {receiver.Port}");
            }
        }
    }
}
