using System.Text.Json;

namespace Contracts
{
    public class UdpSerializer
    {
        public byte[] Serialize(Message message)
        {
            return JsonSerializer.SerializeToUtf8Bytes(message);
        }

        public Message Deserialize(byte[] bytes)
        {
            return JsonSerializer.Deserialize<Message>(bytes);
        }
    }
}