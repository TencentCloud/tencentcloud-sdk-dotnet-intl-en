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

    public class BaselineMainTask : AbstractModel
    {
        
        /// <summary>
        /// <p>Global task ID corresponding to the main task.</p>
        /// </summary>
        [JsonProperty("JobID")]
        public string JobID{ get; set; }

        /// <summary>
        /// <p>Main task ID.</p>
        /// </summary>
        [JsonProperty("ID")]
        public ulong? ID{ get; set; }

        /// <summary>
        /// <p>Main task status. Values:</p><ul><li>INIT: initialization</li><li>SUBTASK_CREATING: creating subtasks</li><li>SCANNING: scanning</li><li>TIMEOUT: timeout</li><li>USER_CANCELED: canceled by the user</li><li>ALL_FAILED: all failed</li><li>SUCCESS: success</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Appid of the associated tenant of the main task.</p>
        /// </summary>
        [JsonProperty("Appid")]
        public ulong? Appid{ get; set; }

        /// <summary>
        /// <p>Main task type. Value:</p><ul><li>ONE_SHOT: one-click policy scan (manual triggering)</li><li>PERIODIC: period scanning (auto-trigger by CycleScanConf)</li><li>OTHER: other disperse scans (triggered by asset dimension, etc.)</li></ul>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>Main task start time.</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>End time of the main task. Empty if not ended.</p>
        /// </summary>
        [JsonProperty("FinishTime")]
        public string FinishTime{ get; set; }

        /// <summary>
        /// <p>Detect asset major category, case-sensitive host baseline and container cluster baseline. Parameter values:</p><ul><li>HOST: Host</li><li>CLUSTER: Container cluster</li></ul>
        /// </summary>
        [JsonProperty("CheckAssetType")]
        public string CheckAssetType{ get; set; }

        /// <summary>
        /// <p>Failure error code. Empty if the request is successful.</p>
        /// </summary>
        [JsonProperty("ErrCode")]
        public string ErrCode{ get; set; }

        /// <summary>
        /// <p>Failure reason, empty if successful.</p>
        /// </summary>
        [JsonProperty("ErrMessage")]
        public string ErrMessage{ get; set; }

        /// <summary>
        /// <p>Solution (mapped according to ErrCode; empty on success)</p>
        /// </summary>
        [JsonProperty("Solution")]
        public string Solution{ get; set; }

        /// <summary>
        /// <p>Number of assets scanned successfully.</p>
        /// </summary>
        [JsonProperty("ScanSuccessCount")]
        public ulong? ScanSuccessCount{ get; set; }

        /// <summary>
        /// <p>Number of assets with scan failure.</p>
        /// </summary>
        [JsonProperty("ScanFailedCount")]
        public ulong? ScanFailedCount{ get; set; }

        /// <summary>
        /// <p>Total number of subtasks</p>
        /// </summary>
        [JsonProperty("ScanTotalCount")]
        public ulong? ScanTotalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobID", this.JobID);
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Appid", this.Appid);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "FinishTime", this.FinishTime);
            this.SetParamSimple(map, prefix + "CheckAssetType", this.CheckAssetType);
            this.SetParamSimple(map, prefix + "ErrCode", this.ErrCode);
            this.SetParamSimple(map, prefix + "ErrMessage", this.ErrMessage);
            this.SetParamSimple(map, prefix + "Solution", this.Solution);
            this.SetParamSimple(map, prefix + "ScanSuccessCount", this.ScanSuccessCount);
            this.SetParamSimple(map, prefix + "ScanFailedCount", this.ScanFailedCount);
            this.SetParamSimple(map, prefix + "ScanTotalCount", this.ScanTotalCount);
        }
    }
}

