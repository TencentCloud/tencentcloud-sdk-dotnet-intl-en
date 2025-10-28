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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeProperty : AbstractModel
    {
        
        /// <summary>
        /// Node AZ.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Node name.
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// Node access address.
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// Public network access address (IP address or domain name) of the node. The example value is an IP address.
        /// </summary>
        [JsonProperty("WanServiceAddress")]
        public string WanServiceAddress{ get; set; }

        /// <summary>
        /// Node role.
        /// - PRIMARY: primary node.
        /// - SECONDARY: secondary node.
        /// - READONLY: read-only node.
        /// - ARBITER: arbitration node.
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// Whether the node is a hidden node.
        /// - true: a hidden node.
        /// - false: not a hidden node.
        /// </summary>
        [JsonProperty("Hidden")]
        public bool? Hidden{ get; set; }

        /// <summary>
        /// Node status.
        /// - NORMAL: running normally.
        /// - STARTUP: starting.
        /// - STARTUP2: starting and processing the intermediate data.
        /// - RECOVERING: recovering and not available.
        /// - DOWN: offline.
        /// - UNKNOWN: unknown status.
        /// - ROLLBACK: rolling back.
        /// - REMOVED: removed.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Delay time of primary-secondary synchronization, in seconds.
        /// </summary>
        [JsonProperty("SlaveDelay")]
        public long? SlaveDelay{ get; set; }

        /// <summary>
        /// Node priority. Value range: [0, 100]. A larger value indicates a higher priority.
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// Node voting right.
        /// - 1: The node has the right to vote.
        /// - 0: The node does not have the right to vote.
        /// </summary>
        [JsonProperty("Votes")]
        public long? Votes{ get; set; }

        /// <summary>
        /// Node tag.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Tags")]
        public NodeTag[] Tags{ get; set; }

        /// <summary>
        /// Replica set ID.
        /// </summary>
        [JsonProperty("ReplicateSetId")]
        public string ReplicateSetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "WanServiceAddress", this.WanServiceAddress);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "Hidden", this.Hidden);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SlaveDelay", this.SlaveDelay);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "Votes", this.Votes);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ReplicateSetId", this.ReplicateSetId);
        }
    }
}

