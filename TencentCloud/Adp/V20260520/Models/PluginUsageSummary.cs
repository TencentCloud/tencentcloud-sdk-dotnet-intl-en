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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PluginUsageSummary : AbstractModel
    {
        
        /// <summary>
        /// <p>Number of calls (top-level count of API calls)</p>
        /// </summary>
        [JsonProperty("CallCount")]
        public float? CallCount{ get; set; }

        /// <summary>
        /// <p>Consumption measurement list for the PLUGIN domain (authoritative field): lists each measurement category by unit + label. When unit=TOKEN, label is case-sensitive for Token subcategories (input/output/avg_*). Being empty indicates total_tokens</p>
        /// </summary>
        [JsonProperty("ResourceConsumptionList")]
        public ResourceConsumption[] ResourceConsumptionList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallCount", this.CallCount);
            this.SetParamArrayObj(map, prefix + "ResourceConsumptionList.", this.ResourceConsumptionList);
        }
    }
}

