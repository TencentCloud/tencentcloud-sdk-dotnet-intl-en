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

    public class TaskLogInfo : AbstractModel
    {
        
        /// <summary>
        /// report name
        /// </summary>
        [JsonProperty("TaskLogName")]
        public string TaskLogName{ get; set; }

        /// <summary>
        /// Report ID.
        /// </summary>
        [JsonProperty("TaskLogId")]
        public string TaskLogId{ get; set; }

        /// <summary>
        /// Associated Asset Count
        /// </summary>
        [JsonProperty("AssetsNumber")]
        public long? AssetsNumber{ get; set; }

        /// <summary>
        /// Security Risk Count
        /// </summary>
        [JsonProperty("RiskNumber")]
        public long? RiskNumber{ get; set; }

        /// <summary>
        /// Report generation time
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// Task Status Code. 0-Initial Value; 1-Scanning; 2-Scan Completed; 3-Scan Error; 4-Stopped; 5-Halted; 6-Task Has Been Restarted.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Associated Task Name
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Scan start time
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Task Center Scan Task ID
        /// </summary>
        [JsonProperty("TaskCenterTaskId")]
        public string TaskCenterTaskId{ get; set; }

        /// <summary>
        /// Tenant ID
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// Host Account ID
        /// </summary>
        [JsonProperty("UIN")]
        public string UIN{ get; set; }

        /// <summary>
        /// User name
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Report Type. 1: Security Checkup; 2: Daily Report; 3: Weekly Report; 4: Monthly Report.
        /// </summary>
        [JsonProperty("ReportType")]
        public long? ReportType{ get; set; }

        /// <summary>
        /// Report Template ID
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskLogName", this.TaskLogName);
            this.SetParamSimple(map, prefix + "TaskLogId", this.TaskLogId);
            this.SetParamSimple(map, prefix + "AssetsNumber", this.AssetsNumber);
            this.SetParamSimple(map, prefix + "RiskNumber", this.RiskNumber);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "TaskCenterTaskId", this.TaskCenterTaskId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "UIN", this.UIN);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "ReportType", this.ReportType);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
        }
    }
}

