using System;
using System.Runtime.Serialization;

namespace Contracts
{
    [Serializable]
    [DataContract]
    public class Message
    {
        [DataMember]
        public string Subject { get; set; }

        [DataMember]
        public DateTime Created { get; set; }
    }
}
