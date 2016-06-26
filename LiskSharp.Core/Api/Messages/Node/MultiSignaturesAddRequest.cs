﻿using System.Collections.Generic;
using LiskSharp.Core.Api.Messages.Common;
using LiskSharp.Core.Attributes;

namespace LiskSharp.Core.Api.Messages.Node
{
    public class MultiSignaturesAddRequest : BaseRequest
    {
        [QueryParam(Name = "secret")]
        public string Secret { get; set; }

        [QueryParam(Name = "secondSecret")]
        public string SecondSecret { get; set; }

        [QueryParam(Name="publicKey")]
        public string PublicKey { get; set; }

        [QueryParam(Name = "min")]
        public int? Min { get; set; }

        [QueryParam(Name = "lifetime")]
        public int? Lifetime { get; set; }
        
        [QueryParam(Name = "keysgroup")]
        public IList<string> KeysGroup { get; set; }

    }
}
