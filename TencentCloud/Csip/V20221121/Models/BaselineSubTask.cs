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

    public class BaselineSubTask : AbstractModel
    {
        
        /// <summary>
        /// <p>Subtask ID.</p>
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// <p>ID of the main task it belongs to (corresponds to BaselineMainTask.ID).</p>
        /// </summary>
        [JsonProperty("TaskID")]
        public ulong? TaskID{ get; set; }

        /// <summary>
        /// <p>Execution result of the subtask. Value:</p><ul><li>SUCCESS: successful</li><li>FAILED: failed</li><li>USER_CANCELED: canceled by the user</li><li>CHECKING: detecting</li><li>UNKNOWN: unknown status</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Appid of the tenant associated with the subtask.</p>
        /// </summary>
        [JsonProperty("Appid")]
        public ulong? Appid{ get; set; }

        /// <summary>
        /// <p>Subtask start execution time.</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>Subtask end time. If not ended, it is empty</p>
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// <p>Detect asset major category, case-sensitive between host baseline and container cluster baseline. Parameter Value:</p><ul><li>HOST: host</li><li>CLUSTER: container cluster</li></ul>
        /// </summary>
        [JsonProperty("CheckAssetType")]
        public string CheckAssetType{ get; set; }

        /// <summary>
        /// <p>Host asset information returned when CheckAssetType=HOST. Empty when CheckAssetType=CLUSTER.</p>
        /// </summary>
        [JsonProperty("HostAsset")]
        public BaselineHostAsset HostAsset{ get; set; }

        /// <summary>
        /// <p>Status code: In case of failure, a failure code is returned (for example, AGENT_OFFLINE, SCAN_TIMEOUT, CLIENT_SCAN_FAILED). During detection, the detection status is returned. It is empty for success or user cancellation.</p>
        /// </summary>
        [JsonProperty("ErrCode")]
        public string ErrCode{ get; set; }

        /// <summary>
        /// <p>Detailed description of the reason for failure. Empty on success, canceled by the user, or during detection.</p>
        /// </summary>
        [JsonProperty("ErrMessage")]
        public string ErrMessage{ get; set; }

        /// <summary>
        /// <p>Solution recommendation in case of failure. Empty for success, canceled by the user, or in-progress detection.</p>
        /// </summary>
        [JsonProperty("Solution")]
        public string Solution{ get; set; }

        /// <summary>
        /// <p>Cluster asset information returned when CheckAssetType=CLUSTER. Empty when CheckAssetType=HOST.</p>
        /// </summary>
        [JsonProperty("ClusterAsset")]
        public BaselineClusterAsset ClusterAsset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "TaskID", this.TaskID);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamSimple(map, prefix + "CheckAssetType", this.CheckAssetType);
            this.SetParamObj(map, prefix + "HostAsset.", this.HostAsset);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "ErrMessage", this.ErrMessage);
            this.SetParamSimple(map, prefix + "Solution", this.Solution);
            this.SetParamObj(map, prefix + "ClusterAsset.", this.ClusterAsset);
        }
    }
}

