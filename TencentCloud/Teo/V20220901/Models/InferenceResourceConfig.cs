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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InferenceResourceConfig : AbstractModel
    {
        
        /// <summary>
        /// Scaling way. Valid values: <li>Auto: Automatically adjust instance count according to request volume;</li><li>Manual: Manual setting of fixed number of resource instances.</li>
        /// </summary>
        [JsonProperty("ScalingMode")]
        public string ScalingMode{ get; set; }

        /// <summary>
        /// Hardware specifications.
        /// </summary>
        [JsonProperty("HardwareSpec")]
        public string HardwareSpec{ get; set; }

        /// <summary>
        /// Inference service automatic scaling configuration. Required when ScalingMode is Auto.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("AutoScalingConfig")]
        public InferenceAutoScalingConfig AutoScalingConfig{ get; set; }

        /// <summary>
        /// Manual setting of inference service instance configuration. Required when ScalingMode is Manual.
        /// Note: This field may return null, which indicates a failure to obtain a valid value.
        /// </summary>
        [JsonProperty("ManualInstanceConfig")]
        public InferenceManualInstanceConfig ManualInstanceConfig{ get; set; }

        /// <summary>
        /// Single-instance concurrency. Default value is 1.
        /// </summary>
        [JsonProperty("Concurrency")]
        public long? Concurrency{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ScalingMode", this.ScalingMode);
            this.SetParamSimple(map, prefix + "HardwareSpec", this.HardwareSpec);
            this.SetParamObj(map, prefix + "AutoScalingConfig.", this.AutoScalingConfig);
            this.SetParamObj(map, prefix + "ManualInstanceConfig.", this.ManualInstanceConfig);
            this.SetParamSimple(map, prefix + "Concurrency", this.Concurrency);
        }
    }
}

