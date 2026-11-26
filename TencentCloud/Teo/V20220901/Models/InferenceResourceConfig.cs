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
        /// <p>Scaling method. Valid values: <li>Auto: automatically adjust instance count according to request volume;</li><li>Manual: manually set a fixed number of instances.</li></p>
        /// </summary>
        [JsonProperty("ScalingMode")]
        public string ScalingMode{ get; set; }

        /// <summary>
        /// <p>Hardware specification flag. Abandoned. For reference, use <code>HardwareSpecId</code>.</p>
        /// </summary>
        [JsonProperty("HardwareSpec")]
        [System.Obsolete]
        public string HardwareSpec{ get; set; }

        /// <summary>
        /// <p>Unique identification ID of the hardware specification. You can obtain the supported hardware specifications of the current site through the <code>DescribeInferenceHardwareSpecifications</code> API.</p><p>By default, the system configures the required resources for the inference service according to the hardware specification corresponding to the selected <code>HardwareSpecId</code>. If adjustments are needed, you can customize the hardware resource configuration through <code>HardwareConfig</code>.</p>
        /// </summary>
        [JsonProperty("HardwareSpecId")]
        public string HardwareSpecId{ get; set; }

        /// <summary>
        /// <p>Hardware configuration for the inference service.</p><p>As an input parameter, if unpadded, hardware resources are configured according to the default value of the selected <code>HardwareSpecId</code> specification; if padded, priority is given to the fill value for configuration.</p>
        /// </summary>
        [JsonProperty("HardwareConfig")]
        public InferenceHardwareConfig HardwareConfig{ get; set; }

        /// <summary>
        /// <p>Automatic scaling configuration of the inference service. Required when ScalingMode is Auto.</p>
        /// </summary>
        [JsonProperty("AutoScalingConfig")]
        public InferenceAutoScalingConfig AutoScalingConfig{ get; set; }

        /// <summary>
        /// <p>Inference service manual setting instance configuration. Required when ScalingMode is Manual.</p>
        /// </summary>
        [JsonProperty("ManualInstanceConfig")]
        public InferenceManualInstanceConfig ManualInstanceConfig{ get; set; }

        /// <summary>
        /// <p>Concurrency of a single instance. Default value: 1.</p>
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
            this.SetParamSimple(map, prefix + "HardwareSpecId", this.HardwareSpecId);
            this.SetParamObj(map, prefix + "HardwareConfig.", this.HardwareConfig);
            this.SetParamObj(map, prefix + "AutoScalingConfig.", this.AutoScalingConfig);
            this.SetParamObj(map, prefix + "ManualInstanceConfig.", this.ManualInstanceConfig);
            this.SetParamSimple(map, prefix + "Concurrency", this.Concurrency);
        }
    }
}

