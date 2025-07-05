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

    public class DescribeBaseOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// Number of modules
        /// </summary>
        [JsonProperty("ModuleNum")]
        public long? ModuleNum{ get; set; }

        /// <summary>
        /// Number of nodes
        /// </summary>
        [JsonProperty("NodeNum")]
        public long? NodeNum{ get; set; }

        /// <summary>
        /// Number of CPU cores
        /// </summary>
        [JsonProperty("VcpuNum")]
        public long? VcpuNum{ get; set; }

        /// <summary>
        /// Memory size in GB
        /// </summary>
        [JsonProperty("MemoryNum")]
        public long? MemoryNum{ get; set; }

        /// <summary>
        /// Disk size in GB
        /// </summary>
        [JsonProperty("StorageNum")]
        public long? StorageNum{ get; set; }

        /// <summary>
        /// Yesterday's network peak in Mbps
        /// </summary>
        [JsonProperty("NetworkNum")]
        public long? NetworkNum{ get; set; }

        /// <summary>
        /// Number of instances
        /// </summary>
        [JsonProperty("InstanceNum")]
        public long? InstanceNum{ get; set; }

        /// <summary>
        /// Number of running instances
        /// </summary>
        [JsonProperty("RunningNum")]
        public long? RunningNum{ get; set; }

        /// <summary>
        /// Number of isolated instances
        /// </summary>
        [JsonProperty("IsolationNum")]
        public long? IsolationNum{ get; set; }

        /// <summary>
        /// Number of expired instances
        /// </summary>
        [JsonProperty("ExpiredNum")]
        public long? ExpiredNum{ get; set; }

        /// <summary>
        /// Number of instances about to expire
        /// </summary>
        [JsonProperty("WillExpireNum")]
        public long? WillExpireNum{ get; set; }

        /// <summary>
        /// The unique request ID, which is returned for each request. RequestId is required for locating a problem.
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModuleNum", this.ModuleNum);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "VcpuNum", this.VcpuNum);
            this.SetParamSimple(map, prefix + "MemoryNum", this.MemoryNum);
            this.SetParamSimple(map, prefix + "StorageNum", this.StorageNum);
            this.SetParamSimple(map, prefix + "NetworkNum", this.NetworkNum);
            this.SetParamSimple(map, prefix + "InstanceNum", this.InstanceNum);
            this.SetParamSimple(map, prefix + "RunningNum", this.RunningNum);
            this.SetParamSimple(map, prefix + "IsolationNum", this.IsolationNum);
            this.SetParamSimple(map, prefix + "ExpiredNum", this.ExpiredNum);
            this.SetParamSimple(map, prefix + "WillExpireNum", this.WillExpireNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

