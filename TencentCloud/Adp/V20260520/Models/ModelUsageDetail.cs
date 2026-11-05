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

    public class ModelUsageDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>Invocation type, originating from billing scene_billing (corresponding to filter.call_type)</p>
        /// </summary>
        [JsonProperty("CallType")]
        public string CallType{ get; set; }

        /// <summary>
        /// <p>Whether it is the default knowledge base. It is only meaningful for the business where ResourceType=5 (knowledge base capacity)</p>
        /// </summary>
        [JsonProperty("IsDefaultKB")]
        public bool? IsDefaultKB{ get; set; }

        /// <summary>
        /// <p>Model name</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>List of consumption measurements for a single call in the MODEL field (authoritative field): lists each measurement type by unit + label. When unit=TOKEN, label is case-sensitive for Token subcategories (input/output/avg_*/cache_*), and being empty indicates total_tokens; unit=PAGE_COUNT refers to the number of pages consumed by the model</p>
        /// </summary>
        [JsonProperty("ResourceConsumptionList")]
        public ResourceConsumption[] ResourceConsumptionList{ get; set; }

        /// <summary>
        /// <p>PU consumption of this call</p>
        /// </summary>
        [JsonProperty("ConsumptionPU")]
        public float? ConsumptionPU{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CallType", this.CallType);
            this.SetParamSimple(map, prefix + "IsDefaultKB", this.IsDefaultKB);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamArrayObj(map, prefix + "ResourceConsumptionList.", this.ResourceConsumptionList);
            this.SetParamSimple(map, prefix + "ConsumptionPU", this.ConsumptionPU);
        }
    }
}

