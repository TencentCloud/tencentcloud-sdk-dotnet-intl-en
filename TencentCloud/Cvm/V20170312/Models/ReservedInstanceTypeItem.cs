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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReservedInstanceTypeItem : AbstractModel
    {
        
        /// <summary>
        /// Instance type.
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// Number of CPU cores.
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// Memory size.
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// Number of GPUs.
        /// </summary>
        [JsonProperty("Gpu")]
        public ulong? Gpu{ get; set; }

        /// <summary>
        /// Number of FPGAs.
        /// </summary>
        [JsonProperty("Fpga")]
        public ulong? Fpga{ get; set; }

        /// <summary>
        /// Number of local storage blocks.
        /// </summary>
        [JsonProperty("StorageBlock")]
        public ulong? StorageBlock{ get; set; }

        /// <summary>
        /// Number of NICs.
        /// </summary>
        [JsonProperty("NetworkCard")]
        public ulong? NetworkCard{ get; set; }

        /// <summary>
        /// Maximum bandwidth.
        /// </summary>
        [JsonProperty("MaxBandwidth")]
        public float? MaxBandwidth{ get; set; }

        /// <summary>
        /// CPU frequency.
        /// </summary>
        [JsonProperty("Frequency")]
        public string Frequency{ get; set; }

        /// <summary>
        /// CPU type.
        /// </summary>
        [JsonProperty("CpuModelName")]
        public string CpuModelName{ get; set; }

        /// <summary>
        /// Packet forwarding rate.
        /// </summary>
        [JsonProperty("Pps")]
        public ulong? Pps{ get; set; }

        /// <summary>
        /// Other information.
        /// </summary>
        [JsonProperty("Externals")]
        public Externals Externals{ get; set; }

        /// <summary>
        /// Remarks.
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// Price information about the reserved instance.
        /// </summary>
        [JsonProperty("Prices")]
        public ReservedInstancePriceItem[] Prices{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Gpu", this.Gpu);
            this.SetParamSimple(map, prefix + "Fpga", this.Fpga);
            this.SetParamSimple(map, prefix + "StorageBlock", this.StorageBlock);
            this.SetParamSimple(map, prefix + "NetworkCard", this.NetworkCard);
            this.SetParamSimple(map, prefix + "MaxBandwidth", this.MaxBandwidth);
            this.SetParamSimple(map, prefix + "Frequency", this.Frequency);
            this.SetParamSimple(map, prefix + "CpuModelName", this.CpuModelName);
            this.SetParamSimple(map, prefix + "Pps", this.Pps);
            this.SetParamObj(map, prefix + "Externals.", this.Externals);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "Prices.", this.Prices);
        }
    }
}

