/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeIpStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// Acceleration domain name
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// Node type.
        /// `edge`: Edge server
        /// `last`: Intermediate server
        /// If this parameter is left empty, edge server information will be returned by default
        /// </summary>
        [JsonProperty("Layer")]
        public string Layer{ get; set; }

        /// <summary>
        /// Specifies a region to query.
        /// `mainland`: Nodes in the Chinese mainland
        /// `overseas`: Nodes outside the Chinese mainland
        /// `global`: Global nodes
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// Whether to return a value as an IP range
        /// </summary>
        [JsonProperty("Segment")]
        public bool? Segment{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ShowIpv6")]
        public bool? ShowIpv6{ get; set; }

        /// <summary>
        /// Whether to abbreviate the IPv6 address.
        /// </summary>
        [JsonProperty("AbbreviationIpv6")]
        public bool? AbbreviationIpv6{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Layer", this.Layer);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Segment", this.Segment);
            this.SetParamSimple(map, prefix + "ShowIpv6", this.ShowIpv6);
            this.SetParamSimple(map, prefix + "AbbreviationIpv6", this.AbbreviationIpv6);
        }
    }
}

