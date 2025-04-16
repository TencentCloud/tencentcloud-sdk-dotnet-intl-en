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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceLogVO : AbstractModel
    {
        
        /// <summary>
        /// Unique id of an instance.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceKey")]
        public string InstanceKey{ get; set; }

        /// <summary>
        /// Project ID.
        /// 
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// **Instance status**.
        /// 
        /// -Indicates waiting for event.
        /// -[12] indicates waiting for upstream.
        /// -[6, 7, 9, 10, 18] indicates awaiting execution.
        /// -1, 19, 22 indicate running.
        /// -21: skip running.
        /// -[3] indicates retry on failure.
        /// -[8, 4, 5, 13] indicates a failure.
        /// -[2] indicates a success.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("InstanceState")]
        public ulong? InstanceState{ get; set; }

        /// <summary>
        /// Instance running trigger type.
        /// 
        /// -RERUN indicates rerunning.
        /// -ADDITION indicates supplementary recording.
        /// -PERIODIC indicates a period.
        /// -APERIODIC indicates non-periodic.
        /// -RERUN_SKIP_RUN means empty run for re-run.
        /// -ADDITION_SKIP_RUN indicates a supplementary run - empty run.
        /// -PERIODIC_SKIP_RUN indicates an empty run in a periodic cycle.
        /// -APERIODIC_SKIP_RUN indicates a non-periodic empty run.
        /// -MANUAL_TRIGGER indicates manual triggering.
        /// -RERUN_MANUAL_TRIGGER indicates manual triggering - rerun.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RunType")]
        public string RunType{ get; set; }

        /// <summary>
        /// Start time of running.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// Indicates the operation completion time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Run code content.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CodeInfo")]
        public string CodeInfo{ get; set; }

        /// <summary>
        /// File size for running code.
        /// Unit: KB.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("CodeFileSize")]
        public string CodeFileSize{ get; set; }

        /// <summary>
        /// Log node information.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("BrokerIp")]
        public string BrokerIp{ get; set; }

        /// <summary>
        /// Log content.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LogInfo")]
        public string LogInfo{ get; set; }

        /// <summary>
        /// Log file size.
        /// KB.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LogFileSize")]
        public string LogFileSize{ get; set; }

        /// <summary>
        /// Row count of returned logs this time.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("LineCount")]
        public ulong? LineCount{ get; set; }

        /// <summary>
        /// Execute platform log pagination query parameters, transparently input for each request. the value is an empty string when querying the first page.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }

        /// <summary>
        /// Paging query for logs. indicates whether it is the last page.
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("IsEnd")]
        public bool? IsEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceKey", this.InstanceKey);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamSimple(map, prefix + "RunType", this.RunType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CodeInfo", this.CodeInfo);
            this.SetParamSimple(map, prefix + "CodeFileSize", this.CodeFileSize);
            this.SetParamSimple(map, prefix + "BrokerIp", this.BrokerIp);
            this.SetParamSimple(map, prefix + "LogInfo", this.LogInfo);
            this.SetParamSimple(map, prefix + "LogFileSize", this.LogFileSize);
            this.SetParamSimple(map, prefix + "LineCount", this.LineCount);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
            this.SetParamSimple(map, prefix + "IsEnd", this.IsEnd);
        }
    }
}

