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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiffDetailItem : AbstractModel
    {
        
        /// <summary>
        /// Attribute.
        /// </summary>
        [JsonProperty("Attribute")]
        public string Attribute{ get; set; }

        /// <summary>
        /// Currently effective.
        /// </summary>
        [JsonProperty("InEffect")]
        public string InEffect{ get; set; }

        /// <summary>
        /// To be effective.
        /// </summary>
        [JsonProperty("PendingEffectiveness")]
        public string PendingEffectiveness{ get; set; }

        /// <summary>
        /// Operation.
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// Queue.
        /// </summary>
        [JsonProperty("Queue")]
        public string Queue{ get; set; }

        /// <summary>
        /// Configuration set.
        /// </summary>
        [JsonProperty("ConfigSet")]
        public string ConfigSet{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("LabelName")]
        public string LabelName{ get; set; }

        /// <summary>
        /// Current position.
        /// </summary>
        [JsonProperty("InEffectIndex")]
        public string InEffectIndex{ get; set; }

        /// <summary>
        /// Position to be effective.
        /// </summary>
        [JsonProperty("PendingEffectIndex")]
        public string PendingEffectIndex{ get; set; }

        /// <summary>
        /// Plan mode name.
        /// </summary>
        [JsonProperty("PlanName")]
        public string PlanName{ get; set; }

        /// <summary>
        /// Tag.
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// Placement rule.
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// Username.
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Attribute", this.Attribute);
            this.SetParamSimple(map, prefix + "InEffect", this.InEffect);
            this.SetParamSimple(map, prefix + "PendingEffectiveness", this.PendingEffectiveness);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "Queue", this.Queue);
            this.SetParamSimple(map, prefix + "ConfigSet", this.ConfigSet);
            this.SetParamSimple(map, prefix + "LabelName", this.LabelName);
            this.SetParamSimple(map, prefix + "InEffectIndex", this.InEffectIndex);
            this.SetParamSimple(map, prefix + "PendingEffectIndex", this.PendingEffectIndex);
            this.SetParamSimple(map, prefix + "PlanName", this.PlanName);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
        }
    }
}

