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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CallInNumberMetrics : AbstractModel
    {
        
        /// <summary>
        /// Line number.
        /// </summary>
        [JsonProperty("Number")]
        public string Number{ get; set; }

        /// <summary>
        /// Line-Related metrics.
        /// </summary>
        [JsonProperty("Metrics")]
        public CallInMetrics Metrics{ get; set; }

        /// <summary>
        /// Bound skill group metrics.
        /// </summary>
        [JsonProperty("SkillGroupMetrics")]
        public CallInSkillGroupMetrics[] SkillGroupMetrics{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Number", this.Number);
            this.SetParamObj(map, prefix + "Metrics.", this.Metrics);
            this.SetParamArrayObj(map, prefix + "SkillGroupMetrics.", this.SkillGroupMetrics);
        }
    }
}

