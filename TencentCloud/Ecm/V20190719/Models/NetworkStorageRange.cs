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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkStorageRange : AbstractModel
    {
        
        /// <summary>
        /// Network bandwidth cap
        /// </summary>
        [JsonProperty("MaxBandwidth")]
        public long? MaxBandwidth{ get; set; }

        /// <summary>
        /// Upper limit of the data disk size
        /// </summary>
        [JsonProperty("MaxSystemDiskSize")]
        public long? MaxSystemDiskSize{ get; set; }

        /// <summary>
        /// Lower limit of the network bandwidth
        /// </summary>
        [JsonProperty("MinBandwidth")]
        public long? MinBandwidth{ get; set; }

        /// <summary>
        /// Lower limit of the data disk size
        /// </summary>
        [JsonProperty("MinSystemDiskSize")]
        public long? MinSystemDiskSize{ get; set; }

        /// <summary>
        /// Maximum data disk size
        /// </summary>
        [JsonProperty("MaxDataDiskSize")]
        public long? MaxDataDiskSize{ get; set; }

        /// <summary>
        /// Minimum data disk size
        /// </summary>
        [JsonProperty("MinDataDiskSize")]
        public long? MinDataDiskSize{ get; set; }

        /// <summary>
        /// Suggested bandwidth
        /// </summary>
        [JsonProperty("SuggestBandwidth")]
        public long? SuggestBandwidth{ get; set; }

        /// <summary>
        /// Suggested disk size
        /// </summary>
        [JsonProperty("SuggestDataDiskSize")]
        public long? SuggestDataDiskSize{ get; set; }

        /// <summary>
        /// Suggested system disk size
        /// </summary>
        [JsonProperty("SuggestSystemDiskSize")]
        public long? SuggestSystemDiskSize{ get; set; }

        /// <summary>
        /// Peak number of CPU cores
        /// </summary>
        [JsonProperty("MaxVcpu")]
        public long? MaxVcpu{ get; set; }

        /// <summary>
        /// Minimum number of CPU cores
        /// </summary>
        [JsonProperty("MinVcpu")]
        public long? MinVcpu{ get; set; }

        /// <summary>
        /// Maximum number of CPU cores per request
        /// </summary>
        [JsonProperty("MaxVcpuPerReq")]
        public long? MaxVcpuPerReq{ get; set; }

        /// <summary>
        /// Bandwidth increment
        /// </summary>
        [JsonProperty("PerBandwidth")]
        public long? PerBandwidth{ get; set; }

        /// <summary>
        /// Data disk increment
        /// </summary>
        [JsonProperty("PerDataDisk")]
        public long? PerDataDisk{ get; set; }

        /// <summary>
        /// Total number of modules
        /// </summary>
        [JsonProperty("MaxModuleNum")]
        public long? MaxModuleNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxBandwidth", this.MaxBandwidth);
            this.SetParamSimple(map, prefix + "MaxSystemDiskSize", this.MaxSystemDiskSize);
            this.SetParamSimple(map, prefix + "MinBandwidth", this.MinBandwidth);
            this.SetParamSimple(map, prefix + "MinSystemDiskSize", this.MinSystemDiskSize);
            this.SetParamSimple(map, prefix + "MaxDataDiskSize", this.MaxDataDiskSize);
            this.SetParamSimple(map, prefix + "MinDataDiskSize", this.MinDataDiskSize);
            this.SetParamSimple(map, prefix + "SuggestBandwidth", this.SuggestBandwidth);
            this.SetParamSimple(map, prefix + "SuggestDataDiskSize", this.SuggestDataDiskSize);
            this.SetParamSimple(map, prefix + "SuggestSystemDiskSize", this.SuggestSystemDiskSize);
            this.SetParamSimple(map, prefix + "MaxVcpu", this.MaxVcpu);
            this.SetParamSimple(map, prefix + "MinVcpu", this.MinVcpu);
            this.SetParamSimple(map, prefix + "MaxVcpuPerReq", this.MaxVcpuPerReq);
            this.SetParamSimple(map, prefix + "PerBandwidth", this.PerBandwidth);
            this.SetParamSimple(map, prefix + "PerDataDisk", this.PerDataDisk);
            this.SetParamSimple(map, prefix + "MaxModuleNum", this.MaxModuleNum);
        }
    }
}

