using System;
using System.IO;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Contracts;

namespace Client
{
    public class WcfSender : IMessageSender
    {
        private ChannelFactory<IMessageSender> factory = 
            new ChannelFactory<IMessageSender>(new NetTcpBinding(), "net.tcp://localhost:9191/IMessageSender");

        public void Send(Message message)
        {
            DataContractSerializer serializer = new DataContractSerializer(typeof(Message));
            var mem = new MemoryStream();
            serializer.WriteObject(mem, message);
            var binData = mem.ToArray();
            var txt = Encoding.UTF8.GetString(binData);

            var remoteService = factory.CreateChannel();
            remoteService.Send(message);
            ((IClientChannel)remoteService).Close();
        }
    }
}
