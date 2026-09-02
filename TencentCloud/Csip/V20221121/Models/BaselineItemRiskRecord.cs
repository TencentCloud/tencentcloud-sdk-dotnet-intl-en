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

    public class BaselineItemRiskRecord : AbstractModel
    {
        
        /// <summary>
        /// <p>Risk record primary key ID.</p>
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// <p>Risk-hit host asset information. If no data is available, this field is null.</p>
        /// </summary>
        [JsonProperty("HostInfo")]
        public BaselineHostAsset HostInfo{ get; set; }

        /// <summary>
        /// <p>Cluster asset information. The value is null if no data is available.</p>
        /// </summary>
        [JsonProperty("ClusterInfo")]
        public BaselineClusterAsset ClusterInfo{ get; set; }

        /// <summary>
        /// <p>Asset type of the hit asset. Value:</p><ul><li>HOST: host</li><li>CLUSTER: cluster</li><li>POD: Pod</li><li>CONTAINER: container</li><li>IMAGE: mirror</li></ul>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// <p>Risk detection result status. Parameter values:</p><ul><li>CHECKING: in-progress detection</li><li>PASS: passed</li><li>NOT_PASS: failed</li><li>CHECK_FAILED: detection failed</li><li>NOT_INVOLVED: not involved</li><li>IGNORED: ignored</li></ul>
        /// </summary>
        [JsonProperty("ResultStatus")]
        public string ResultStatus{ get; set; }

        /// <summary>
        /// <p>Latest check time.</p>
        /// </summary>
        [JsonProperty("LatestCheckTime")]
        public string LatestCheckTime{ get; set; }

        /// <summary>
        /// <p>Baseline detection item ID.</p>
        /// </summary>
        [JsonProperty("ItemID")]
        public ulong? ItemID{ get; set; }

        /// <summary>
        /// <p>Risk event ID, used for uniquely identifying this risk record.</p>
        /// </summary>
        [JsonProperty("RiskID")]
        public string RiskID{ get; set; }

        /// <summary>
        /// <p>Global JobID of this scan.</p>
        /// </summary>
        [JsonProperty("JobID")]
        public string JobID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamObj(map, prefix + "HostInfo.", this.HostInfo);
            this.SetParamObj(map, prefix + "ClusterInfo.", this.ClusterInfo);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "ResultStatus", this.ResultStatus);
            this.SetParamSimple(map, prefix + "LatestCheckTime", this.LatestCheckTime);
            this.SetParamSimple(map, prefix + "ItemID", this.ItemID);
            this.SetParamSimple(map, prefix + "RiskID", this.RiskID);
            this.SetParamSimple(map, prefix + "JobID", this.JobID);
        }
    }
}

