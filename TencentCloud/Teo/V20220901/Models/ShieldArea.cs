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

    public class ShieldArea : AbstractModel
    {
        
        /// <summary>
        /// The site ID.
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// The policy ID.
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// The type of protected resources. Values:
        /// <li>`domain`: Layer-7 subdomain name</li>
        /// <li>`application`: Layer-4 proxy</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// The layer-7 site name.
        /// </summary>
        [JsonProperty("EntityName")]
        public string EntityName{ get; set; }

        /// <summary>
        /// The layer-7 subdomain name.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("DDoSHosts")]
        public DDoSHost[] DDoSHosts{ get; set; }

        /// <summary>
        /// Number of layer-4 TCP forwarding rules
        /// </summary>
        [JsonProperty("TcpNum")]
        public long? TcpNum{ get; set; }

        /// <summary>
        /// Number of layer-4 UDP forwarding rules
        /// </summary>
        [JsonProperty("UdpNum")]
        public long? UdpNum{ get; set; }

        /// <summary>
        /// Name of the protected resource
        /// </summary>
        [JsonProperty("Entity")]
        public string Entity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "EntityName", this.EntityName);
            this.SetParamArrayObj(map, prefix + "DDoSHosts.", this.DDoSHosts);
            this.SetParamSimple(map, prefix + "TcpNum", this.TcpNum);
            this.SetParamSimple(map, prefix + "UdpNum", this.UdpNum);
            this.SetParamSimple(map, prefix + "Entity", this.Entity);
        }
    }
}

