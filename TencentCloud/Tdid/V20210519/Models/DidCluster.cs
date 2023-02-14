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

namespace TencentCloud.Tdid.V20210519.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DidCluster : AbstractModel
    {
        
        /// <summary>
        /// The chain ID.
        /// </summary>
        [JsonProperty("ChainId")]
        public ulong? ChainId{ get; set; }

        /// <summary>
        /// The chain name.
        /// </summary>
        [JsonProperty("ChainName")]
        public string ChainName{ get; set; }

        /// <summary>
        /// The number of organizations.
        /// </summary>
        [JsonProperty("AgencyCount")]
        public ulong? AgencyCount{ get; set; }

        /// <summary>
        /// The consortium ID.
        /// </summary>
        [JsonProperty("ConsortiumId")]
        public ulong? ConsortiumId{ get; set; }

        /// <summary>
        /// The creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// The expiration time.
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// The network status.
        /// </summary>
        [JsonProperty("ChainStatus")]
        public ulong? ChainStatus{ get; set; }

        /// <summary>
        /// The resource ID.
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// The network ID.
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// The consortium name.
        /// </summary>
        [JsonProperty("ConsortiumName")]
        public string ConsortiumName{ get; set; }

        /// <summary>
        /// The organization ID.
        /// </summary>
        [JsonProperty("AgencyId")]
        public ulong? AgencyId{ get; set; }

        /// <summary>
        /// Whether auto-renewal is enabled.
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public ulong? AutoRenewFlag{ get; set; }

        /// <summary>
        /// The total number of network nodes.
        /// </summary>
        [JsonProperty("TotalNetworkNode")]
        public ulong? TotalNetworkNode{ get; set; }

        /// <summary>
        /// The number of nodes of the current organization.
        /// </summary>
        [JsonProperty("TotalCreateNode")]
        public ulong? TotalCreateNode{ get; set; }

        /// <summary>
        /// The total number of groups.
        /// </summary>
        [JsonProperty("TotalGroups")]
        public ulong? TotalGroups{ get; set; }

        /// <summary>
        /// The total number of DIDs.
        /// </summary>
        [JsonProperty("DidCount")]
        public ulong? DidCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChainId", this.ChainId);
            this.SetParamSimple(map, prefix + "ChainName", this.ChainName);
            this.SetParamSimple(map, prefix + "AgencyCount", this.AgencyCount);
            this.SetParamSimple(map, prefix + "ConsortiumId", this.ConsortiumId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "ChainStatus", this.ChainStatus);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ConsortiumName", this.ConsortiumName);
            this.SetParamSimple(map, prefix + "AgencyId", this.AgencyId);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "TotalNetworkNode", this.TotalNetworkNode);
            this.SetParamSimple(map, prefix + "TotalCreateNode", this.TotalCreateNode);
            this.SetParamSimple(map, prefix + "TotalGroups", this.TotalGroups);
            this.SetParamSimple(map, prefix + "DidCount", this.DidCount);
        }
    }
}

