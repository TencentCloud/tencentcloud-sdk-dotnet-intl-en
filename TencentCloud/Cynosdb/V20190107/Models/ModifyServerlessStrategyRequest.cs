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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyServerlessStrategyRequest : AbstractModel
    {
        
        /// <summary>
        /// Specifies the serverless cluster id.
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// Specifies whether the cluster automatically pauses. valid values for the optional range.
        /// <li>yes</li>
        /// <li>no</li>
        /// </summary>
        [JsonProperty("AutoPause")]
        public string AutoPause{ get; set; }

        /// <summary>
        /// Specifies the delay for cluster auto-pause in seconds. the value range is [600,691200]. the default value is 600.
        /// </summary>
        [JsonProperty("AutoPauseDelay")]
        public long? AutoPauseDelay{ get; set; }

        /// <summary>
        /// The parameter is temporarily unavailable.
        /// </summary>
        [JsonProperty("AutoScaleUpDelay")]
        public long? AutoScaleUpDelay{ get; set; }

        /// <summary>
        /// The parameter is temporarily unavailable.
        /// </summary>
        [JsonProperty("AutoScaleDownDelay")]
        public long? AutoScaleDownDelay{ get; set; }

        /// <summary>
        /// Minimum value of cpu. for the optional range, refer to the API response of DescribeServerlessInstanceSpecs.
        /// </summary>
        [JsonProperty("MinCpu")]
        public float? MinCpu{ get; set; }

        /// <summary>
        /// Maximum value of cpu, optional range refers to the API response of DescribeServerlessInstanceSpecs.
        /// </summary>
        [JsonProperty("MaxCpu")]
        public float? MaxCpu{ get; set; }

        /// <summary>
        /// Minimum cpu value of a read-only instance. for valid values, refer to the API response of DescribeServerlessInstanceSpecs.
        /// </summary>
        [JsonProperty("MinRoCpu")]
        public float? MinRoCpu{ get; set; }

        /// <summary>
        /// Maximum value of read-only cpu, optional range refer to the API response of DescribeServerlessInstanceSpecs.
        /// </summary>
        [JsonProperty("MaxRoCpu")]
        public float? MaxRoCpu{ get; set; }

        /// <summary>
        /// Specifies the minimum count of read-only nodes.
        /// </summary>
        [JsonProperty("MinRoCount")]
        public long? MinRoCount{ get; set; }

        /// <summary>
        /// Maximum number of read-only nodes.
        /// </summary>
        [JsonProperty("MaxRoCount")]
        public long? MaxRoCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "AutoPause", this.AutoPause);
            this.SetParamSimple(map, prefix + "AutoPauseDelay", this.AutoPauseDelay);
            this.SetParamSimple(map, prefix + "AutoScaleUpDelay", this.AutoScaleUpDelay);
            this.SetParamSimple(map, prefix + "AutoScaleDownDelay", this.AutoScaleDownDelay);
            this.SetParamSimple(map, prefix + "MinCpu", this.MinCpu);
            this.SetParamSimple(map, prefix + "MaxCpu", this.MaxCpu);
            this.SetParamSimple(map, prefix + "MinRoCpu", this.MinRoCpu);
            this.SetParamSimple(map, prefix + "MaxRoCpu", this.MaxRoCpu);
            this.SetParamSimple(map, prefix + "MinRoCount", this.MinRoCount);
            this.SetParamSimple(map, prefix + "MaxRoCount", this.MaxRoCount);
        }
    }
}

