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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceInitInfo : AbstractModel
    {
        
        /// <summary>
        /// Instance CPU
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// Instance memory
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Instance type. Valid values:`rw`, `ro`.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Number of the instances. Value range: 1-15.
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// Minimum number of serverless instances. Value range: 1-15.
        /// </summary>
        [JsonProperty("MinRoCount")]
        public long? MinRoCount{ get; set; }

        /// <summary>
        /// Maximum number of serverless instances. Value range: 1-15.
        /// </summary>
        [JsonProperty("MaxRoCount")]
        public long? MaxRoCount{ get; set; }

        /// <summary>
        /// Minimum specifications for serverless instance
        /// </summary>
        [JsonProperty("MinRoCpu")]
        public float? MinRoCpu{ get; set; }

        /// <summary>
        /// Maximum specifications for serverless instance
        /// </summary>
        [JsonProperty("MaxRoCpu")]
        public float? MaxRoCpu{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceCount", this.InstanceCount);
            this.SetParamSimple(map, prefix + "MinRoCount", this.MinRoCount);
            this.SetParamSimple(map, prefix + "MaxRoCount", this.MaxRoCount);
            this.SetParamSimple(map, prefix + "MinRoCpu", this.MinRoCpu);
            this.SetParamSimple(map, prefix + "MaxRoCpu", this.MaxRoCpu);
        }
    }
}

