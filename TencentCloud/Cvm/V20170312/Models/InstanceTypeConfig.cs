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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceTypeConfig : AbstractModel
    {
        
        /// <summary>
        /// Availability zone.
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// Instance model.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Instance model family.
        /// </summary>
        [JsonProperty("InstanceFamily")]
        public string InstanceFamily{ get; set; }

        /// <summary>
        /// Number of GPU cores.
        /// </summary>
        [JsonProperty("GPU")]
        public long? GPU{ get; set; }

        /// <summary>
        /// Number of CPU cores.
        /// </summary>
        [JsonProperty("CPU")]
        public long? CPU{ get; set; }

        /// <summary>
        /// Memory capacity; unit: `GB`.
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// Number of FPGA cores; unit: core.
        /// </summary>
        [JsonProperty("FPGA")]
        public long? FPGA{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "InstanceFamily", this.InstanceFamily);
            this.SetParamSimple(map, prefix + "GPU", this.GPU);
            this.SetParamSimple(map, prefix + "CPU", this.CPU);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "FPGA", this.FPGA);
        }
    }
}

