﻿#region copyright
// <copyright file="DelegateVotersRequest.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion

namespace LiskSharp.Core.Api.Messages
{
    public class DelegateVotersRequest : BaseRequest
    {
        public string PublicKey { get; set; }

        public override string ToQuery()
        {
            if (!string.IsNullOrWhiteSpace(PublicKey))
                QueryParams.Add($"publicKey={PublicKey}");

            return base.ToQuery();
        }
    }
}