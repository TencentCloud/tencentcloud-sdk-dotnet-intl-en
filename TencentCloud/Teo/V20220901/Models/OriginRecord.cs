/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OriginRecord : AbstractModel
    {
        
        /// <summary>
        /// The origin record value, which can be an IPv4/IPv6 address or a domain name.
        /// </summary>
        [JsonProperty("Record")]
        public string Record{ get; set; }

        /// <summary>
        /// The origin record ID.
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// The origin port. Value rang: 1-65535.
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// The weight when `ConfigurationType=weight`.
        /// If 0 or no value is passed, the weight of each origin in a group will be 0 or left empty, indicating that origin-pull is performed by round-robin.
        /// If a value between 1-100 is passed, the total weight of multiple origins in a group should be 100, indicating that origin-pull is performed by weight.
        /// The weight when `ConfigurationType=proto`.
        /// If 0 or no value is passed, the weight of each origin in a group will be 0 or left empty, indicating that origin-pull is performed by round-robin.
        /// If a value between 1-100 is passed, the total weight of multiple origins with the same protocol in a group should be 100, indicating that origin-pull is performed by weight.
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// The origin protocol when `ConfigurationType=proto`, indicating that origin-pull is performed by protocol.
        /// <li>`http`: HTTP protocol</li>
        /// <li>`https`: HTTPS protocol</li>
        /// </summary>
        [JsonProperty("Proto")]
        public string Proto{ get; set; }

        /// <summary>
        /// The region when `ConfigurationType=area`, which is specified by country code (ISO 3166 alpha-2) or continent code. If not specified, it indicates all regions. Supported continent codes:
        /// <li>`Asia`</li>
        /// <li>`Europe`</li>
        /// <li>`Africa`</li>
        /// <li>`Oceania`</li>
        /// <li>`Americas`</li>An origin group must have at least one origin configured with all regions.
        /// </summary>
        [JsonProperty("Area")]
        public string[] Area{ get; set; }

        /// <summary>
        /// It is valid only when `OriginType=third_part`.
        /// Whether the origin group is private. Values:
        /// <li>`true`: Yes.</li>
        /// <li>`false`: No.</li>If not specified, it defaults to false.
        /// </summary>
        [JsonProperty("Private")]
        public bool? Private{ get; set; }

        /// <summary>
        /// The authentication parameter, which is used when `Private=true`.
        /// </summary>
        [JsonProperty("PrivateParameters")]
        public PrivateParameter[] PrivateParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Record", this.Record);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "Proto", this.Proto);
            this.SetParamArraySimple(map, prefix + "Area.", this.Area);
            this.SetParamSimple(map, prefix + "Private", this.Private);
            this.SetParamArrayObj(map, prefix + "PrivateParameters.", this.PrivateParameters);
        }
    }
}

