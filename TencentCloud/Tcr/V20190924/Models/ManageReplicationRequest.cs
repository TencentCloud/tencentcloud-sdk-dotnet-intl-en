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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ManageReplicationRequest : AbstractModel
    {
        
        /// <summary>
        /// Source instance ID
        /// </summary>
        [JsonProperty("SourceRegistryId")]
        public string SourceRegistryId{ get; set; }

        /// <summary>
        /// Destination instance ID
        /// </summary>
        [JsonProperty("DestinationRegistryId")]
        public string DestinationRegistryId{ get; set; }

        /// <summary>
        /// Synchronization rule
        /// </summary>
        [JsonProperty("Rule")]
        public ReplicationRule Rule{ get; set; }

        /// <summary>
        /// Rule description
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// Region ID of the destination instance. For example, `1` represents Guangzhou
        /// </summary>
        [JsonProperty("DestinationRegionId")]
        public ulong? DestinationRegionId{ get; set; }

        /// <summary>
        /// Configuration of the synchronization rule
        /// </summary>
        [JsonProperty("PeerReplicationOption")]
        public PeerReplicationOption PeerReplicationOption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceRegistryId", this.SourceRegistryId);
            this.SetParamSimple(map, prefix + "DestinationRegistryId", this.DestinationRegistryId);
            this.SetParamObj(map, prefix + "Rule.", this.Rule);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "DestinationRegionId", this.DestinationRegionId);
            this.SetParamObj(map, prefix + "PeerReplicationOption.", this.PeerReplicationOption);
        }
    }
}

