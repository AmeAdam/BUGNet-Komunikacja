using System.Net;
using System.Net.Sockets;
using System.Text;
using Contracts;

namespace Client
{
    public class UdpSender : IMessageSender
    {
        private readonly UdpSerializer serializer = new UdpSerializer();

        public void Send(Message message)
        {
            var serverAddress = new IPEndPoint(IPAddress.Loopback, 5000);
            using (var client = new UdpClient())
            {
                var bytes = serializer.Serialize(message);
                client.Send(bytes, bytes.Length, serverAddress);
            }
        }
    }
}