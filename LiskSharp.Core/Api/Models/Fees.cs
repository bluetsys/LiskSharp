﻿#region copyright
// <copyright file="Fees.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>26/6/2016</date>
// <summary></summary>
#endregion
using System.Runtime.Serialization;

namespace LiskSharp.Core.Api.Models
{
    [DataContract]
    public class Fees
    {
        [DataMember(Name = "send")]
        public int Send { get; set; }

        [DataMember(Name = "vote")]
        public int Vote { get; set; }

        [DataMember(Name = "secondsignature")]
        public int Secondsignature { get; set; }

        [DataMember(Name = "delegate")]
        public long Delegate { get; set; }

        [DataMember(Name = "multisignature")]
        public int Multisignature { get; set; }

        [DataMember(Name = "dapp")]
        public long Dapp { get; set; }
    }
}