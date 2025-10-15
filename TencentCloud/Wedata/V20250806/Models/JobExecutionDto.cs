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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class JobExecutionDto : AbstractModel
    {
        
        /// <summary>
        /// Job ID of the data exploration.
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// Query job ID.
        /// </summary>
        [JsonProperty("JobExecutionId")]
        public string JobExecutionId{ get; set; }

        /// <summary>
        /// Specifies the subquery name.
        /// </summary>
        [JsonProperty("JobExecutionName")]
        public string JobExecutionName{ get; set; }

        /// <summary>
        /// Specifies the subquery sql content.
        /// </summary>
        [JsonProperty("ScriptContent")]
        public string ScriptContent{ get; set; }

        /// <summary>
        /// Subquery status.
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Execution phase.
        /// </summary>
        [JsonProperty("ExecuteStageInfo")]
        public string ExecuteStageInfo{ get; set; }

        /// <summary>
        /// Log path
        /// </summary>
        [JsonProperty("LogFilePath")]
        public string LogFilePath{ get; set; }

        /// <summary>
        /// Result path for download.
        /// </summary>
        [JsonProperty("ResultFilePath")]
        public string ResultFilePath{ get; set; }

        /// <summary>
        /// Preview result path.
        /// </summary>
        [JsonProperty("ResultPreviewFilePath")]
        public string ResultPreviewFilePath{ get; set; }

        /// <summary>
        /// Total number of lines in the task execution result.
        /// </summary>
        [JsonProperty("ResultTotalCount")]
        public long? ResultTotalCount{ get; set; }

        /// <summary>
        /// Update time.
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// End time.
        /// 
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// Duration. specifies the time taken.
        /// </summary>
        [JsonProperty("TimeCost")]
        public long? TimeCost{ get; set; }

        /// <summary>
        /// SQL content in the context.
        /// </summary>
        [JsonProperty("ContextScriptContent")]
        public string[] ContextScriptContent{ get; set; }

        /// <summary>
        /// Specifies the preview row count for task execution results.
        /// </summary>
        [JsonProperty("ResultPreviewCount")]
        public long? ResultPreviewCount{ get; set; }

        /// <summary>
        /// Specifies the number of affected rows in task execution.
        /// </summary>
        [JsonProperty("ResultEffectCount")]
        public long? ResultEffectCount{ get; set; }

        /// <summary>
        /// Whether the full result is being collected: default false. true indicates the full result is being collected, for the frontend to determine whether to continue to poll.
        /// </summary>
        [JsonProperty("CollectingTotalResult")]
        public bool? CollectingTotalResult{ get; set; }

        /// <summary>
        /// Specifies whether to truncate the script content.
        /// </summary>
        [JsonProperty("ScriptContentTruncate")]
        public bool? ScriptContentTruncate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobExecutionId", this.JobExecutionId);
            this.SetParamSimple(map, prefix + "JobExecutionName", this.JobExecutionName);
            this.SetParamSimple(map, prefix + "ScriptContent", this.ScriptContent);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ExecuteStageInfo", this.ExecuteStageInfo);
            this.SetParamSimple(map, prefix + "LogFilePath", this.LogFilePath);
            this.SetParamSimple(map, prefix + "ResultFilePath", this.ResultFilePath);
            this.SetParamSimple(map, prefix + "ResultPreviewFilePath", this.ResultPreviewFilePath);
            this.SetParamSimple(map, prefix + "ResultTotalCount", this.ResultTotalCount);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "TimeCost", this.TimeCost);
            this.SetParamArraySimple(map, prefix + "ContextScriptContent.", this.ContextScriptContent);
            this.SetParamSimple(map, prefix + "ResultPreviewCount", this.ResultPreviewCount);
            this.SetParamSimple(map, prefix + "ResultEffectCount", this.ResultEffectCount);
            this.SetParamSimple(map, prefix + "CollectingTotalResult", this.CollectingTotalResult);
            this.SetParamSimple(map, prefix + "ScriptContentTruncate", this.ScriptContentTruncate);
        }
    }
}

