﻿// // -----------------------------------------------------------------------
// // <copyright from="2019" to="2019" file="BaseDto.cs" company="Lindell Technologies">
// //    Copyright (c) Lindell Technologies All Rights Reserved.
// //    Information Contained Herein is Proprietary and Confidential.
// // </copyright>
// // -----------------------------------------------------------------------

using Newtonsoft.Json;

namespace Nop.Plugin.Api.DTO.Base
{
    public abstract class BaseDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    }
}