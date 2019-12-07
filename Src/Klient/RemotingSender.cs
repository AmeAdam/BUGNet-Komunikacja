using System;
using System.IO;
using System.Runtime.Remoting;
using System.Runtime.Serialization.Formatters.Binary;
using System.ServiceModel;
using System.Text;
using Contracts;

namespace Client
{
    public class RemotingSender : IMessageSender
    {

        public void Send(Message message)
        {
            BinaryFormatter bf = new BinaryFormatter();
            var mem = new MemoryStream();
            bf.Serialize(mem, message);
            var binData = mem.ToArray();
            var txt = Encoding.UTF8.GetString(binData);

            var remoteService = (IMessageSender) Activator.GetObject(typeof(IMessageSender),
                "tcp://localhost:9090/MessageSender");
            remoteService.Send(message);
        }
    }
}
