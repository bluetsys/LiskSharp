﻿#region copyright
// <copyright file="DappAsset.cs" >
// Copyright (c) 2016 All Rights Reserved
// Licensed under MIT
// </copyright>
// <author>Raj Bandi</author>
// <date>26/6/2016</date>
// <summary></summary>
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace LiskSharp.Core.Common
{
    [DataContract]
    public class DappAsset :Asset
    {
        [DataMember(Name = "dapp")]
        public Dapp Dapp { get; set; }

        public override byte[] GetBytes()
        {
            return Dapp.GetBytes();
        }
    }
}
