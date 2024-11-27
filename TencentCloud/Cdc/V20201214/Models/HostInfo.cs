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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HostInfo : AbstractModel
    {
        
        /// <summary>
        /// Host IP
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// Cloud service type
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// Host running status
        /// </summary>
        [JsonProperty("HostStatus")]
        public string HostStatus{ get; set; }

        /// <summary>
        /// Host type
        /// </summary>
        [JsonProperty("HostType")]
        public string HostType{ get; set; }

        /// <summary>
        /// Number of available CPUs
        /// </summary>
        [JsonProperty("CpuAvailable")]
        public ulong? CpuAvailable{ get; set; }

        /// <summary>
        /// Total CPUs
        /// </summary>
        [JsonProperty("CpuTotal")]
        public ulong? CpuTotal{ get; set; }

        /// <summary>
        /// Available memories
        /// </summary>
        [JsonProperty("MemAvailable")]
        public ulong? MemAvailable{ get; set; }

        /// <summary>
        /// Total memories
        /// </summary>
        [JsonProperty("MemTotal")]
        public ulong? MemTotal{ get; set; }

        /// <summary>
        /// Running time
        /// </summary>
        [JsonProperty("RunTime")]
        public string RunTime{ get; set; }

        /// <summary>
        /// Expiration time
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// Host id 
        /// Note: The returned value of this field may be null, indicating that no valid value is obtained.
        /// </summary>
        [JsonProperty("HostId")]
        public string HostId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "HostStatus", this.HostStatus);
            this.SetParamSimple(map, prefix + "HostType", this.HostType);
            this.SetParamSimple(map, prefix + "CpuAvailable", this.CpuAvailable);
            this.SetParamSimple(map, prefix + "CpuTotal", this.CpuTotal);
            this.SetParamSimple(map, prefix + "MemAvailable", this.MemAvailable);
            this.SetParamSimple(map, prefix + "MemTotal", this.MemTotal);
            this.SetParamSimple(map, prefix + "RunTime", this.RunTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "HostId", this.HostId);
        }
    }
}

