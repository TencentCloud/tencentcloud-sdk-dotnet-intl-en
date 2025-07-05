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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HostStatistic : AbstractModel
    {
        
        /// <summary>
        /// Host type
        /// </summary>
        [JsonProperty("HostType")]
        public string HostType{ get; set; }

        /// <summary>
        /// Host model family
        /// </summary>
        [JsonProperty("HostFamily")]
        public string HostFamily{ get; set; }

        /// <summary>
        /// Number of CPU cores of host, in cores
        /// </summary>
        [JsonProperty("Cpu")]
        public ulong? Cpu{ get; set; }

        /// <summary>
        /// Host memory, in GB
        /// </summary>
        [JsonProperty("Memory")]
        public ulong? Memory{ get; set; }

        /// <summary>
        /// Number of hosts of this type
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// Average CPU load percentage 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("CpuAverage")]
        public float? CpuAverage{ get; set; }

        /// <summary>
        /// Average memory usage percentage 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("MemAverage")]
        public float? MemAverage{ get; set; }

        /// <summary>
        /// Average network traffic 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("NetAverage")]
        public float? NetAverage{ get; set; }

        /// <summary>
        /// Detailed CPU monitoring data 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("CpuDetailData")]
        public DetailData CpuDetailData{ get; set; }

        /// <summary>
        /// Memory details 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("MemDetailData")]
        public DetailData MemDetailData{ get; set; }

        /// <summary>
        /// Network rate details 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("NetRateDetailData")]
        public DetailData NetRateDetailData{ get; set; }

        /// <summary>
        /// Network packet details 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("NetPacketDetailData")]
        public DetailData NetPacketDetailData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HostType", this.HostType);
            this.SetParamSimple(map, prefix + "HostFamily", this.HostFamily);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "CpuAverage", this.CpuAverage);
            this.SetParamSimple(map, prefix + "MemAverage", this.MemAverage);
            this.SetParamSimple(map, prefix + "NetAverage", this.NetAverage);
            this.SetParamObj(map, prefix + "CpuDetailData.", this.CpuDetailData);
            this.SetParamObj(map, prefix + "MemDetailData.", this.MemDetailData);
            this.SetParamObj(map, prefix + "NetRateDetailData.", this.NetRateDetailData);
            this.SetParamObj(map, prefix + "NetPacketDetailData.", this.NetPacketDetailData);
        }
    }
}

