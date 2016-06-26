﻿using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;

namespace LiskSharp.Core.Api.Messages.Node
{
    /// <summary>
    /// Request class for addTransaction
    /// </summary>
    [DataContract]
    public class TransactionAddRequest : BaseRequest
    {
        [DataMember(Name = "secret")]
        public string Secret { get; set; }

        [DataMember(Name = "amount")]
        public long? Amount { get; set; }

        [DataMember(Name = "recipientId")]
        public string RecipientId { get; set; }

        [DataMember(Name = "publicKey")]
        public string PublicKey { get; set; }

        [DataMember(Name = "secondSecret")]
        public string SecondSecret { get; set; }

        [DataMember(Name = "multisigAccountPublicKey")]
        public string MultiSigAccountPublicKey { get; set; }

    }
}
