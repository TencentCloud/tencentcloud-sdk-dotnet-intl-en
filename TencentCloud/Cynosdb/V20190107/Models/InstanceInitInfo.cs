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
        /// <p>Instance cpu</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>Instance memory</p>
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// <p>Instance type rw/ro</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>Number of instances, range [1,15]</p>
        /// </summary>
        [JsonProperty("InstanceCount")]
        public long? InstanceCount{ get; set; }

        /// <summary>
        /// <p>Minimum count of Serverless instance, range [1,15]</p>
        /// </summary>
        [JsonProperty("MinRoCount")]
        public long? MinRoCount{ get; set; }

        /// <summary>
        /// <p>Maximum count of Serverless instances, range [1,15]</p>
        /// </summary>
        [JsonProperty("MaxRoCount")]
        public long? MaxRoCount{ get; set; }

        /// <summary>
        /// <p>Minimum specification of Serverless instance</p>
        /// </summary>
        [JsonProperty("MinRoCpu")]
        public float? MinRoCpu{ get; set; }

        /// <summary>
        /// <p>Maximum specification of Serverless instance</p>
        /// </summary>
        [JsonProperty("MaxRoCpu")]
        public float? MaxRoCpu{ get; set; }

        /// <summary>
        /// <p>Instance Machine Type</p><ol><li>common, universal type.</li><li>exclusive, dedicated.</li></ol>
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }


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
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
        }
    }
}

