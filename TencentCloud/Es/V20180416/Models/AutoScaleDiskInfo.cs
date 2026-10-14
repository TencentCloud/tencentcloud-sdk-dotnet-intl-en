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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoScaleDiskInfo : AbstractModel
    {
        
        /// <summary>
        /// Node type. Valid values: `hotData`, `warmData`.
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 0: Percentage-based scale-out; 1: Absolute value-based scale-out
        /// </summary>
        [JsonProperty("ScaleType")]
        public ulong? ScaleType{ get; set; }

        /// <summary>
        /// Trigger threshold. Unit: %. For example, 80%.
        /// </summary>
        [JsonProperty("Threshold")]
        public ulong? Threshold{ get; set; }

        /// <summary>
        /// Trigger duration in minutes, for example, 60
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// Expansion ratio per time, unit: %, for example, 20%
        /// </summary>
        [JsonProperty("PercentSize")]
        public ulong? PercentSize{ get; set; }

        /// <summary>
        /// Absolute value-based scale-out, in GB, for example, 100 GB
        /// </summary>
        [JsonProperty("FixSize")]
        public ulong? FixSize{ get; set; }

        /// <summary>
        /// Capacity limit for scale-out, in GB, for example, 500 GB
        /// </summary>
        [JsonProperty("MaxSize")]
        public ulong? MaxSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "ScaleType", this.ScaleType);
            this.SetParamSimple(map, prefix + "Threshold", this.Threshold);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "PercentSize", this.PercentSize);
            this.SetParamSimple(map, prefix + "FixSize", this.FixSize);
            this.SetParamSimple(map, prefix + "MaxSize", this.MaxSize);
        }
    }
}

