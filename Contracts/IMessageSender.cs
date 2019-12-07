using System.ServiceModel;

namespace Contracts
{
    [ServiceContract]
    public interface IMessageSender
    {
        [OperationContract]
        void Send(Message message);
    }
}
