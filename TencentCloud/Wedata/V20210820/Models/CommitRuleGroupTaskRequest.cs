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

    public class CommitRuleGroupTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// Rule Group ID
        /// </summary>
        [JsonProperty("RuleGroupId")]
        public ulong? RuleGroupId{ get; set; }

        /// <summary>
        /// Trigger Type 1. Manual Trigger 2. In-process Scheduling Trigger 3. Periodic Scheduling Trigger
        /// </summary>
        [JsonProperty("TriggerType")]
        public ulong? TriggerType{ get; set; }

        /// <summary>
        /// Rule Configuration List
        /// </summary>
        [JsonProperty("ExecRuleConfig")]
        public RuleConfig[] ExecRuleConfig{ get; set; }

        /// <summary>
        /// Execution configuration
        /// </summary>
        [JsonProperty("ExecConfig")]
        public RuleExecConfig ExecConfig{ get; set; }

        /// <summary>
        /// Project ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// The execution engine that this rule runs. If this parameter is not passed, the default execution engine under this data source will be requested.
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleGroupId", this.RuleGroupId);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamArrayObj(map, prefix + "ExecRuleConfig.", this.ExecRuleConfig);
            this.SetParamObj(map, prefix + "ExecConfig.", this.ExecConfig);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
        }
    }
}

