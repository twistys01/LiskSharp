﻿#region copyright
// <copyright file="AccountPublickeyResponse.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>23/6/2016</date>
// <summary></summary>
#endregion

using System.Runtime.Serialization;

namespace LiskSharp.Core.Api.Messages
{
    [DataContract]
    public class AccountPublickeyResponse : BaseResponse
    {
        [DataMember(Name = "publicKey")]
        public string PublicKey { get; set; }
    }

}