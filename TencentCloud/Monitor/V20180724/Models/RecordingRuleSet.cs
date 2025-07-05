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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordingRuleSet : AbstractModel
    {
        
        /// <summary>
        /// Rule ID
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// Rule status code
        /// </summary>
        [JsonProperty("RuleState")]
        public long? RuleState{ get; set; }

        /// <summary>
        /// Group name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// Rule group
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// Number of rules
        /// </summary>
        [JsonProperty("Total")]
        public long? Total{ get; set; }

        /// <summary>
        /// Rule creation time
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// Rule update time
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// Rule name
        /// Note: This field may return null, indicating that no valid values can be obtained.
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleState", this.RuleState);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
        }
    }
}

