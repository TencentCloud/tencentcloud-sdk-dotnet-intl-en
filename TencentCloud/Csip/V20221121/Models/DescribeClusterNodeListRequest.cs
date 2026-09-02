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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterNodeListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Cluster asset id</p>
        /// </summary>
        [JsonProperty("ClusterAssetId")]
        [System.Obsolete]
        public string ClusterAssetId{ get; set; }

        /// <summary>
        /// <p>Group account member id.</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Common filter criteria list. Supported filter fields:<br>NodeName: node name, fuzzy matching.<br>NodeId: node ID, exact matching.<br>NodeUniqueID: node unique ID, exact matching (NodeAssetID is an equivalent alias).<br>NodeType: node type, exact matching. Values: SUPER (super node), MASTER (primary node), WORKER (work node).<br>RunStatus: node running status, exact matching.<br>InternalIP: private IP address, exact matching.<br>ClientStatus: client status, exact matching. Values: ONLINE (online), OFFLINE (offline), UNINSTALL (not installed).</p>
        /// </summary>
        [JsonProperty("Filter")]
        public Filter Filter{ get; set; }

        /// <summary>
        /// <p>Cluster ca certificate md5 value, the unique identifier of the cluster</p>
        /// </summary>
        [JsonProperty("ClusterCaMD5")]
        public string ClusterCaMD5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterAssetId", this.ClusterAssetId);
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamSimple(map, prefix + "ClusterCaMD5", this.ClusterCaMD5);
        }
    }
}

