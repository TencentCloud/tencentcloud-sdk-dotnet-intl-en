/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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
        /// Report name
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskLogName")]
        public string TaskLogName{ get; set; }

        /// <summary>
        /// Report ID.
        /// </summary>
        [JsonProperty("TaskLogId")]
        public string TaskLogId{ get; set; }

        /// <summary>
        /// Number of associated assets
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AssetsNumber")]
        public long? AssetsNumber{ get; set; }

        /// <summary>
        /// Number of risks
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RiskNumber")]
        public long? RiskNumber{ get; set; }

        /// <summary>
        /// Report generation time
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// Task status. `0`: Initial value; `1`: Scanning; `2`: Completed; `3`: Failed; `4`: Stopped; `5`: Paused; `6`: Retried
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// Name of the associated task
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// Scan start time
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Scan task ID
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("TaskCenterTaskId")]
        public string TaskCenterTaskId{ get; set; }

        /// <summary>
        /// User AppId
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// User UIN
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UIN")]
        public string UIN{ get; set; }

        /// <summary>
        /// User name.
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// Report type: `1`: Health check report; `2`: Daily report; `3`: Weekly report; `4`: Monthly report
        /// Note: This field may return·null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ReportType")]
        public long? ReportType{ get; set; }

        /// <summary>
        /// Report template ID
        /// Note: This field may return·null, indicating that no valid values can be obtained.
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

