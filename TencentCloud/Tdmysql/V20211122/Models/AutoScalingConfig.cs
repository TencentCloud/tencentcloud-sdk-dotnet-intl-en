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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoScalingConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Minimum value</p>
        /// </summary>
        [JsonProperty("RangeMin")]
        public float? RangeMin{ get; set; }

        /// <summary>
        /// <p>Maximum value</p>
        /// </summary>
        [JsonProperty("RangeMax")]
        public float? RangeMax{ get; set; }

        /// <summary>
        /// <p>Resource type corresponding to the returned range parameter</p><p>Enumeration values:</p><ul><li>cpu: Returns the CPU adjustment return limit. When no mem limit exists, it represents ccu.</li><li>nodecount: Returns the limit range of the number of nodes for horizontal scaling.</li><li>datadisk: Returns the capacity limit range for disk scale-out.</li></ul>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// <p>Whether upgrade is allowed</p>
        /// </summary>
        [JsonProperty("ScaleUpEnabled")]
        public bool? ScaleUpEnabled{ get; set; }

        /// <summary>
        /// <p>Whether to allow downgrade</p>
        /// </summary>
        [JsonProperty("ScaleDownEnabled")]
        public bool? ScaleDownEnabled{ get; set; }

        /// <summary>
        /// <p>Trigger threshold (%)</p>
        /// </summary>
        [JsonProperty("ThresholdPercent")]
        public long? ThresholdPercent{ get; set; }

        /// <summary>
        /// <p>Configuration change step length</p>
        /// </summary>
        [JsonProperty("Step")]
        public float? Step{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RangeMin", this.RangeMin);
            this.SetParamSimple(map, prefix + "RangeMax", this.RangeMax);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ScaleUpEnabled", this.ScaleUpEnabled);
            this.SetParamSimple(map, prefix + "ScaleDownEnabled", this.ScaleDownEnabled);
            this.SetParamSimple(map, prefix + "ThresholdPercent", this.ThresholdPercent);
            this.SetParamSimple(map, prefix + "Step", this.Step);
        }
    }
}

