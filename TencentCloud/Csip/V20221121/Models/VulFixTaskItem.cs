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
        /// Primary key ID of the repair task
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// Task ID, a hash flag for interaction.
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// Task JobId, corresponding to the task ID in the task system.
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// List of fixed vulnerability IDs
        /// </summary>
        [JsonProperty("VulIds")]
        public long?[] VulIds{ get; set; }

        /// <summary>
        /// List of repaired KB patch IDs
        /// </summary>
        [JsonProperty("KBIds")]
        public long?[] KBIds{ get; set; }

        /// <summary>
        /// Total number of repaired assets
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
        /// Repair progress percentage
        /// Valid values: [0, 100].
        /// Supplemental description: Calculation method: (SuccessCount+FailCount)/AssetCount×100
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

        /// <summary>
        /// Number of users for fix tasks
        /// </summary>
        [JsonProperty("TargetAppIdsCount")]
        public long? TargetAppIdsCount{ get; set; }

        /// <summary>
        /// Remediation status
        /// Enumeration values:
        /// 0: initialization
        /// 1: In remediation
        /// 2: Repair successful
        /// 3: Partial fix failure
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
        /// Repair startup time
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format)
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Repair end time
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format)
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Record creation time.
        /// Parameter format: YYYY-MM-DDTHH:mm:ssZ (ISO8601 format)
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// List of names of repaired vulnerabilities, making it easy to show directly on the list page
        /// </summary>
        [JsonProperty("VulNames")]
        public string[] VulNames{ get; set; }

        /// <summary>
        /// Vulnerability Type List
        /// Enumeration value:
        /// LINUX: Linux software vulnerability
        /// WINDOWS: WINDOWS system patch vulnerabilities
        /// WEB_CMS: Web-CMS vulnerability
        /// APPLICATION: Application vulnerability
        /// EMERGENCY: Urgent vulnerability
        /// </summary>
        [JsonProperty("VulCategory")]
        public string[] VulCategory{ get; set; }

        /// <summary>
        /// Creator `AppId`
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

