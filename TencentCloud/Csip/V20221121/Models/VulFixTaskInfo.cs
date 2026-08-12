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

    public class VulFixTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// Primary key ID of the fix task
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// Task ID.
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// Remediation status
        /// Enumeration values:
        /// 0: initialization
        /// 1: In remediation
        /// 2: Repair successful
        /// 3: Partially fix failed
        /// 4: All fix failures
        /// 5: Stop repair
        /// </summary>
        [JsonProperty("FixStatus")]
        public long? FixStatus{ get; set; }

        /// <summary>
        /// Repair total number of assets
        /// </summary>
        [JsonProperty("AssetCount")]
        public long? AssetCount{ get; set; }

        /// <summary>
        /// Number of successful fixes
        /// </summary>
        [JsonProperty("SuccessCount")]
        public long? SuccessCount{ get; set; }

        /// <summary>
        /// FIX_FAILURE count
        /// </summary>
        [JsonProperty("FailCount")]
        public long? FailCount{ get; set; }

        /// <summary>
        /// Number of hosts in remediation
        /// </summary>
        [JsonProperty("FixingCount")]
        public long? FixingCount{ get; set; }

        /// <summary>
        /// Number in queue (waiting for distribution or snapshot creation)
        /// </summary>
        [JsonProperty("QueueCount")]
        public long? QueueCount{ get; set; }

        /// <summary>
        /// Progress percentage of the repair
        /// Value range: [0, 100].
        /// Supplemental description: Calculation method is (SuccessCount+FailCount)/AssetCount×100.
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// Number of successfully fixed vulnerabilities
        /// </summary>
        [JsonProperty("SuccessVulCount")]
        public long? SuccessVulCount{ get; set; }

        /// <summary>
        /// Number of vulnerabilities that failed to fix
        /// </summary>
        [JsonProperty("FailVulCount")]
        public long? FailVulCount{ get; set; }

        /// <summary>
        /// List of vulnerability names to be fixed
        /// </summary>
        [JsonProperty("VulNames")]
        public string[] VulNames{ get; set; }

        /// <summary>
        /// Fix startup time
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format).
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Fixing end time
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format).
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// List of vulnerability dimensional remediation status, status details of each vulnerability
        /// </summary>
        [JsonProperty("VulFixStatusList")]
        public VulFixStatusItem[] VulFixStatusList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "FixStatus", this.FixStatus);
            this.SetParamSimple(map, prefix + "AssetCount", this.AssetCount);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "FailCount", this.FailCount);
            this.SetParamSimple(map, prefix + "FixingCount", this.FixingCount);
            this.SetParamSimple(map, prefix + "QueueCount", this.QueueCount);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "SuccessVulCount", this.SuccessVulCount);
            this.SetParamSimple(map, prefix + "FailVulCount", this.FailVulCount);
            this.SetParamArraySimple(map, prefix + "VulNames.", this.VulNames);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamArrayObj(map, prefix + "VulFixStatusList.", this.VulFixStatusList);
        }
    }
}

