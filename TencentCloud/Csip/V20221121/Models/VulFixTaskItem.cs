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

    public class VulFixTaskItem : AbstractModel
    {
        
        /// <summary>
        /// Primary key ID of the fix task
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// Task ID, hash flag for interactive
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// JobId, corresponding to the Task ID of the task system.
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// List of vulnerability IDs to be fixed
        /// </summary>
        [JsonProperty("VulIds")]
        public long?[] VulIds{ get; set; }

        /// <summary>
        /// List of fixed KB patch IDs
        /// </summary>
        [JsonProperty("KBIds")]
        public long?[] KBIds{ get; set; }

        /// <summary>
        /// Repair the total number of assets
        /// </summary>
        [JsonProperty("AssetCount")]
        public long? AssetCount{ get; set; }

        /// <summary>
        /// Number of successfully fixed hosts
        /// </summary>
        [JsonProperty("SuccessCount")]
        public long? SuccessCount{ get; set; }

        /// <summary>
        /// Number of hosts failed to be fixed
        /// </summary>
        [JsonProperty("FailCount")]
        public long? FailCount{ get; set; }

        /// <summary>
        /// Progress percentage of the repair
        /// Valid values: [0, 100]
        /// Supplemental description: Calculation method is (SuccessCount+FailCount)/AssetCount×100.
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// Number of users in the fix task
        /// </summary>
        [JsonProperty("TargetAppIdsCount")]
        public long? TargetAppIdsCount{ get; set; }

        /// <summary>
        /// Remediation status
        /// Enumeration value:
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
        /// Maximum repair time
        /// Unit: seconds.
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// Fix startup time
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format).
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Fix end time
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format).
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Record creation time.
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format).
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// List of vulnerability names to be fixed, making it easy to show directly on the list page
        /// </summary>
        [JsonProperty("VulNames")]
        public string[] VulNames{ get; set; }

        /// <summary>
        /// Vulnerability Type List
        /// Enumeration values:
        /// LINUX: Linux software vulnerability
        /// WINDOWS: Windows system patch vulnerability
        /// WEB_CMS: Web-CMS vulnerabilities
        /// APPLICATION: Application vulnerability
        /// EMERGENCY: Urgent vulnerability
        /// </summary>
        [JsonProperty("VulCategory")]
        public string[] VulCategory{ get; set; }

        /// <summary>
        /// Creator AppId
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamArraySimple(map, prefix + "VulIds.", this.VulIds);
            this.SetParamArraySimple(map, prefix + "KBIds.", this.KBIds);
            this.SetParamSimple(map, prefix + "AssetCount", this.AssetCount);
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "FailCount", this.FailCount);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "TargetAppIdsCount", this.TargetAppIdsCount);
            this.SetParamSimple(map, prefix + "FixStatus", this.FixStatus);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArraySimple(map, prefix + "VulNames.", this.VulNames);
            this.SetParamArraySimple(map, prefix + "VulCategory.", this.VulCategory);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
        }
    }
}

