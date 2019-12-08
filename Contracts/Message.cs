using System;
using System.Runtime.Serialization;
using ProtoBuf;

namespace Contracts
{
    [Serializable]
    [DataContract]
    [ProtoContract]
    public class Message
    {
        [DataMember]
        [ProtoMember(1)]
        public string Subject { get; set; }

        [DataMember]
        [ProtoMember(2)]
        public DateTime Created { get; set; }
    }
}
