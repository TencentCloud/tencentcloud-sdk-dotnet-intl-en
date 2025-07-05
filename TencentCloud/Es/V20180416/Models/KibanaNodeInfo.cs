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

    public class KibanaNodeInfo : AbstractModel
    {
        
        /// <summary>
        /// Kibana node specification
        /// </summary>
        [JsonProperty("KibanaNodeType")]
        public string KibanaNodeType{ get; set; }

        /// <summary>
        /// Number of Kibana nodes
        /// </summary>
        [JsonProperty("KibanaNodeNum")]
        public ulong? KibanaNodeNum{ get; set; }

        /// <summary>
        /// Number of Kibana node's CPUs
        /// </summary>
        [JsonProperty("KibanaNodeCpuNum")]
        public ulong? KibanaNodeCpuNum{ get; set; }

        /// <summary>
        /// Kibana node's memory in GB
        /// </summary>
        [JsonProperty("KibanaNodeMemSize")]
        public ulong? KibanaNodeMemSize{ get; set; }

        /// <summary>
        /// Kibana node's disk type
        /// </summary>
        [JsonProperty("KibanaNodeDiskType")]
        public string KibanaNodeDiskType{ get; set; }

        /// <summary>
        /// Kibana node's disk size
        /// </summary>
        [JsonProperty("KibanaNodeDiskSize")]
        public ulong? KibanaNodeDiskSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KibanaNodeType", this.KibanaNodeType);
            this.SetParamSimple(map, prefix + "KibanaNodeNum", this.KibanaNodeNum);
            this.SetParamSimple(map, prefix + "KibanaNodeCpuNum", this.KibanaNodeCpuNum);
            this.SetParamSimple(map, prefix + "KibanaNodeMemSize", this.KibanaNodeMemSize);
            this.SetParamSimple(map, prefix + "KibanaNodeDiskType", this.KibanaNodeDiskType);
            this.SetParamSimple(map, prefix + "KibanaNodeDiskSize", this.KibanaNodeDiskSize);
        }
    }
}

