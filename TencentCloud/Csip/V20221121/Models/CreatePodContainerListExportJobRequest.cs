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

    public class CreatePodContainerListExportJobRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>Group account member id</p>
        /// </summary>
        [JsonProperty("MemberId")]
        public string[] MemberId{ get; set; }

        /// <summary>
        /// <p>Pod unique ID</p>
        /// </summary>
        [JsonProperty("PodUniqueID")]
        public string PodUniqueID{ get; set; }

        /// <summary>
        /// <p>Cluster CA certificate MD5 (used to query node information)</p>
        /// </summary>
        [JsonProperty("ClusterCaMD5")]
        public string ClusterCaMD5{ get; set; }

        /// <summary>
        /// <p>Common filter criteria list. Supported filter fields:<br>ContainerId: container ID, exact match.<br>ContainerName: container name, fuzzy match.<br>RunStatus: container running status, exact match. Values: RUNNING, PAUSED, STOPPED, CREATED, DESTROYED, RESTARTING, REMOVING, DEAD, UNKNOWN.<br>ImageId: image ID, exact match.<br>ImageName: image name, fuzzy match.<br>IsolateStatus: isolation status, exact match. Values: NORMAL (unisolated), ISOLATED (isolated), ISOLATING (isolating), ISOLATE_FAILED (isolation failed), RESTORING (restoring isolation), RESTORE_FAILED (isolation removal failed).<br>NodeUniqueId: unique ID of the node it belongs to, exact match (NodeAssetId is an equivalent alias).<br>UUID: host UUID, exact match.</p>
        /// </summary>
        [JsonProperty("Filter")]
        public Filter Filter{ get; set; }

        /// <summary>
        /// <p>Export field list (export all fields if not specified)<br>Enumeration values:<br>ContainerId: container ID<br>ContainerName: Container name<br>RunStatus: running state<br>NodeId: node ID<br>NodeType: node type<br>ImageId: image id<br>ImageName: mirror name<br>IsolateStatus: isolation status</p>
        /// </summary>
        [JsonProperty("ExportFields")]
        public string[] ExportFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "MemberId.", this.MemberId);
            this.SetParamSimple(map, prefix + "PodUniqueID", this.PodUniqueID);
            this.SetParamSimple(map, prefix + "ClusterCaMD5", this.ClusterCaMD5);
            this.SetParamObj(map, prefix + "Filter.", this.Filter);
            this.SetParamArraySimple(map, prefix + "ExportFields.", this.ExportFields);
        }
    }
}

