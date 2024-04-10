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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyScheduledSqlRequest : AbstractModel
    {
        
        /// <summary>
        /// Task ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// Source Log Topic
        /// </summary>
        [JsonProperty("SrcTopicId")]
        public string SrcTopicId{ get; set; }

        /// <summary>
        /// Task start status. 1: Enabled, 2: Disabled
        /// </summary>
        [JsonProperty("EnableFlag")]
        public long? EnableFlag{ get; set; }

        /// <summary>
        /// Target log topic for scheduled SQL analysis
        /// </summary>
        [JsonProperty("DstResource")]
        public ScheduledSqlResouceInfo DstResource{ get; set; }

        /// <summary>
        /// Queries statements
        /// </summary>
        [JsonProperty("ScheduledSqlContent")]
        public string ScheduledSqlContent{ get; set; }

        /// <summary>
        /// Scheduling interval (minutes)
        /// </summary>
        [JsonProperty("ProcessPeriod")]
        public long? ProcessPeriod{ get; set; }

        /// <summary>
        /// Time window for a single query. Example: last 15 minutes
        /// </summary>
        [JsonProperty("ProcessTimeWindow")]
        public string ProcessTimeWindow{ get; set; }

        /// <summary>
        /// Execution delay (seconds)
        /// </summary>
        [JsonProperty("ProcessDelay")]
        public long? ProcessDelay{ get; set; }

        /// <summary>
        /// Region information of source topic ID 
        /// </summary>
        [JsonProperty("SrcTopicRegion")]
        public string SrcTopicRegion{ get; set; }

        /// <summary>
        /// Task Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Syntax rules. Default value: 0. 0: Lucene syntax, 1: CQL syntax
        /// </summary>
        [JsonProperty("SyntaxRule")]
        public ulong? SyntaxRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "SrcTopicId", this.SrcTopicId);
            this.SetParamSimple(map, prefix + "EnableFlag", this.EnableFlag);
            this.SetParamObj(map, prefix + "DstResource.", this.DstResource);
            this.SetParamSimple(map, prefix + "ScheduledSqlContent", this.ScheduledSqlContent);
            this.SetParamSimple(map, prefix + "ProcessPeriod", this.ProcessPeriod);
            this.SetParamSimple(map, prefix + "ProcessTimeWindow", this.ProcessTimeWindow);
            this.SetParamSimple(map, prefix + "ProcessDelay", this.ProcessDelay);
            this.SetParamSimple(map, prefix + "SrcTopicRegion", this.SrcTopicRegion);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "SyntaxRule", this.SyntaxRule);
        }
    }
}

