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

    public class RemoveNodeList : AbstractModel
    {
        
        /// <summary>
        /// Roles of nodes to be deleted.
        ///  - SECONDARY: Mongod secondary node.
        ///  - READONLY: read-only node.
        ///  - MONGOS: Mongos node.
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// IDs of nodes to be deleted. For a sharded cluster instance, specify the names of nodes to be deleted on one shard. Nodes with the same names on other shards will also be deleted.
        /// - Obtaining method: Log in to the [TencentDB for MongoDB console](https://console.cloud.tencent.com/mongodb), go to the **Node Management** tab, and obtain the **node ID**.
        /// - Note: For a sharded cluster instance, specify the IDs of nodes on shard 0. For example, cmgo-6hfk\*\*\*\*\_0-node-primary.
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// AZ corresponding to the node. For the currently supported AZs, see [Regions and AZs](https://www.tencentcloud.com/document/product/240/3637?from_cn_redirect=1).
        /// - Single AZ: all nodes are in the same AZ.
        /// - Multiple AZs: The current standard specification involves three AZs. The primary and secondary nodes are not in the same AZ. Note: AZs corresponding to the nodes to be deleted should be specified. After deletion, the number of nodes in any 2 AZs should be larger than that in the third AZ.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
        }
    }
}

