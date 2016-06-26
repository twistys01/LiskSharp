﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Api.Models;

namespace LiskSharp.Core.Api.Messages.Peer
{
    [DataContract]
    public class PeerBlocksResponse : BaseResponse
    {
        [DataMember(Name = "blocks")]
        public IList<PeerBlock> Blocks { get; set; }
    }
}
