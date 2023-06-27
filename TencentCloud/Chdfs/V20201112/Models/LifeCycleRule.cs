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

namespace TencentCloud.Chdfs.V20201112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LifeCycleRule : AbstractModel
    {
        
        /// <summary>
        /// Lifecycle rule ID
        /// </summary>
        [JsonProperty("LifeCycleRuleId")]
        public ulong? LifeCycleRuleId{ get; set; }

        /// <summary>
        /// Lifecycle rule name
        /// </summary>
        [JsonProperty("LifeCycleRuleName")]
        public string LifeCycleRuleName{ get; set; }

        /// <summary>
        /// Lifecycle rule path (directory or file)
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// List of lifecycle rule transitions
        /// </summary>
        [JsonProperty("Transitions")]
        public Transition[] Transitions{ get; set; }

        /// <summary>
        /// Lifecycle rule status (1: enabled; 2: disabled)
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// Creation time
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// Detailed storage usage of the current lifecycle rule path
        /// </summary>
        [JsonProperty("Summary")]
        public Summary Summary{ get; set; }

        /// <summary>
        /// Update time of `Summary`
        /// </summary>
        [JsonProperty("LastSummaryTime")]
        public string LastSummaryTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LifeCycleRuleId", this.LifeCycleRuleId);
            this.SetParamSimple(map, prefix + "LifeCycleRuleName", this.LifeCycleRuleName);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamArrayObj(map, prefix + "Transitions.", this.Transitions);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "Summary.", this.Summary);
            this.SetParamSimple(map, prefix + "LastSummaryTime", this.LastSummaryTime);
        }
    }
}

